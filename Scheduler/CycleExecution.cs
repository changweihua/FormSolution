using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       CycleExecution
     * 机器名称:       HSERVER
     * 命名空间:       Scheduler
     * 文 件 名:       CycleExecution
     * 创建时间:       2012/8/17 15:15:07
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
    /// 周期性的执行计划
    /// </summary>
    public class CycleExecution : ISchedule
    {
        private DateTime m_schedule;
        private TimeSpan m_period;


        /// <summary>
        /// 构造函数，在一个将来时间开始运行
        /// </summary>
        /// <param name="schedule">计划执行的时间</param>
        /// <param name="period">周期时间</param>
        public CycleExecution(DateTime schedule, TimeSpan period)
        {

        }


        /// <summary>
        /// 构造函数，马上开始运行
        /// </summary>
        /// <param name="period"></param>
        public CycleExecution(TimeSpan period)
        {

        }

        #region 接口实现部分

        public DateTime ExecutionTime
        {
            get
            {
                return m_schedule;
            }
            set
            {
                m_schedule = value;
            }
        }

        public long DueTime
        {
            get 
            {
                long ms = (m_schedule.Ticks - DateTime.Now.Ticks) / 1000;

                if (ms < 0)
                {
                    ms = 0;
                }

                return ms;

            }
        }

        public long Period
        {
            get { return m_period.Ticks; }
        }

        #endregion

        
    }
}
