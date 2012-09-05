using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       ISchedule
     * 机器名称:       HSERVER
     * 命名空间:       Scheduler
     * 文 件 名:       ISchedule
     * 创建时间:       2012/8/17 15:12:07
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
    /// 计划 接口
    /// 
    /// </summary>
    public interface ISchedule
    {
        /// <summary>
        /// 返回最初计划执行时间
        /// </summary>
        DateTime ExecutionTime { get; set; }


        /// <summary>
        /// 初始化执行时间与现在时间的时间刻度差
        /// </summary>
        long DueTime
        {
            get;
        }


        /// <summary>
        /// 循环的周期
        /// </summary>
        long Period { get; }


    }
}
