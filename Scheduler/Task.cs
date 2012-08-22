using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Scheduler
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       Task
     * 机器名称:       HSERVER
     * 命名空间:       Scheduler
     * 文 件 名:       Task
     * 创建时间:       2012/8/17 15:24:48
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// 计划任务的基类
    /// 启动的任务会在工作线程中完成，调用启动方法之后会立即返回
    ///  
    /// 用法： 
    /// (1)如果你要创建自己的任务，需要从这个类继承一个新类，然后重载Execute(object param)方法． 
    /// 实现自己的任务,再把任务加入到任务管理中心来启动和停止。 
    /// 比如： 
    /// TaskCenter center = new TaskCenter(); 
    /// Task newTask = new Task( new ImmediateExecution()); 
    /// center.AddTask(newTask); 
    /// center.StartAllTask(); 
    /// (2)直接把自己的任务写入TimerCallBack委托，然后生成一个Task类的实例， 
    /// 设置它的Job和JobParam属性，再Start就可以启动该服务了。此时不能够再使用任务管理中心了。 
    /// 比如： 
    /// Task newTask = new Task( new ImmediateExecution()); 
    ///    newTask.Job+= new TimerCallback(newTask.Execute); 
    ///    newTask.JobParam = "Test immedialte task"; //添加自己的参数 
    ///    newTask.Start();

    /// </summary>
    public class Task
    {

        private ISchedule m_schedule;
        private Timer m_timer;
        private DateTime m_nextExecuteTime;
        private TimerCallback m_execTask;
        private object m_param;
        private string m_name;
        private string m_description;
        private DateTime m_lastExecTime;


        /// <summary>
        /// 为每个任务制定一个执行计划
        /// </summary>
        /// <param name="schedule"></param>
        public Task(ISchedule schedule)
        {
            if (schedule == null)
            { 
                throw (new ArgumentNullException("schedule"));
            }

            m_schedule = schedule;
        }


        /// <summary>
        /// 启动任务
        /// </summary>
        public void Start()
        { 
            //启动定时器
            m_timer = new Timer(m_execTask, m_param, m_schedule.DueTime, m_schedule.Period);
        }


        /// <summary>
        /// 停止任务
        /// </summary>
        public void Stop()
        {
            m_timer.Change(Timeout.Infinite, Timeout.Infinite);
        }


        /// <summary>
        /// 任务内容
        /// </summary>
        /// <param name="param">任务函数参数</param>
        public virtual void Execute(object param)
        {
            //你需要重载该函数,但是需要在你的新函数中调用base.Execute(); 
            m_lastExecTime = DateTime.Now;
            if (m_schedule.Period == Timeout.Infinite)
            {
                m_nextExecuteTime = DateTime.MaxValue;
            }
            else
            {
                TimeSpan period = new TimeSpan(m_schedule.Period * 1000);
                m_nextExecuteTime = m_lastExecTime + period;
            }
        }


        /// <summary>
        /// 任务下一次执行时间
        /// </summary>
        public DateTime NextExecuteTime
        {
            get
            {
                return m_nextExecuteTime;
            }
        }


        /// <summary>
        /// 执行任务的计划
        /// </summary>
        public ISchedule Schedule
        {
            get
            {
                return m_schedule;
            }
        }


        /// <summary>
        /// 任务内容
        /// </summary>
        public TimerCallback Job
        {
            get
            {
                return m_execTask;
            }
            set
            {
                m_execTask = value;
            }
        }


        /// <summary>
        /// 任务参数
        /// </summary>
        public object JobParam
        {
            set
            {
                m_param = value;
            }
        }


        /// <summary>
        /// 任务名称
        /// </summary>
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }


        /// <summary>
        /// 任务描述
        /// </summary>
        public string Description
        {
            get
            {
                return m_description;
            }
            set
            {
                m_description = value;

            }
        }



        /// <summary>
        /// 该任务最后一次执行时间
        /// </summary>
        public DateTime LastExecuteTime
        {
            get
            {
                return m_lastExecTime;
            }
            set
            {
                m_lastExecTime = value;
            }
        }

    }
}
