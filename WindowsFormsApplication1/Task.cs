using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.269
     * 类 名 称:       Task
     * 机器名称:       HSERVER
     * 命名空间:       WindowsFormsApplication1
     * 文 件 名:       Task
     * 创建时间:       2012/8/17 15:21:58
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
        public Task()
        {

        }
    }
}
