using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace Scheduler
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       TaskCenter
     * 机器名称:       HSERVER
     * 命名空间:       Scheduler
     * 文 件 名:       TaskCenter
     * 创建时间:       2012/8/17 15:42:21
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
    /// 任务中心
    /// 可以同时进行多个任务
    /// </summary>
    public class TaskCenter
    {
        private ArrayList m_scheduleTasks;

        public TaskCenter()
        {
            m_scheduleTasks = new ArrayList();
        }


        /// <summary>
        /// 添加任务
        /// </summary>
        /// <param name="task">新任务</param>
        public void AddTask(Task task)
        {
            m_scheduleTasks.Add(task);
        }


        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="task">待删除的任务</param>
        public void RemoveTask(Task task)
        {
            m_scheduleTasks.Remove(task);
        }


        /// <summary>
        /// 启动所有任务
        /// </summary>
        public void StartAllTask()
        {
            foreach (Task task in m_scheduleTasks)
            {
                StartTask(task); 
            }
        }


        /// <summary>
        /// 启动一个任务
        /// </summary>
        /// <param name="task"></param>
        public void StartTask(Task task)
        {
            if (task.Job == null)
            {
                task.Job += new TimerCallback(task.Execute);
            }
        }



        /// <summary>
        /// 终止一个任务
        /// </summary>
        /// <param name="task"></param>
        public void TerminateTask(Task task)
        {
            task.Stop();
        }



        /// <summary>
        /// 终止所有的任务
        /// </summary>
        public void TerminateAllTask()
        {
            foreach (Task task in m_scheduleTasks)
            {
                TerminateTask(task);
            }
        }


        /// <summary>
        /// 获取所有任务
        /// </summary>
        ArrayList ScheduleTasks
        {
            get
            {
                return m_scheduleTasks;
            }
        }


    }
}
