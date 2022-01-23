任务执行器

引入命名空间
using TaskMachine;

使用方法： 链式编写

TaskManager.TaskRun()
...
;

或者

object.TaskRun()
...
;

主要框架类:
TaskManager 执行总管理器 ：跟随程序启动自启动
TaskActuator 进程执行器
TaskProcess 任务进程 

附加功能：
TaskEvent 顺序任务 ：Event()
TaskWait 等待任务：Wait()
TaskDelay 延时任务：Delay() \ TimeOutWait() \ TimeOutReset
TaskClock 闹钟任务：ClockReset() \ ClockSet()
TaskFor 循环任务： For()
TaskForeach 遍历任务 ：Foreach()


20210227:初步功能完成 , 后续: 对象池, 扩展编辑器,控制TaskManager 的自启

20210310：对象池加入，TaskManager改为懒汉单例自启，GC优化为0


