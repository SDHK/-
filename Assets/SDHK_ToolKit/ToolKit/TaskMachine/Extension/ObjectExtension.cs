/******************************

 * 作者: 闪电黑客

 * 日期: 2021/02/22 10:08:09

 * 最后日期: 2021/02/22 17:05:41

 * 描述: 
    任务执行管理器: 对象绑定 的 功能扩展
    

******************************/

namespace TaskMachine
{
    public static class ObjectExtension
    {

        /// <summary>
        ///  启动一个绑定任务：未执行完时，新任务以追加的形式执行
        /// </summary>
        /// <param name="obj">绑定对象</param>
        /// <param name="model">运行模式</param>
        /// <returns>任务进程</returns>
        public static TaskProcess TaskRun(this object obj, TaskModel model = TaskModel.Update)
        {
            return TaskManager.TaskRun(obj, model);
        }

        /// <summary>
        /// 强制结束一个绑定任务
        /// </summary>
        /// <param name="obj">绑定对象</param>
        public static void TaskKill(this object obj)
        {
            TaskManager.TaskKill(obj);
        }

    }

}