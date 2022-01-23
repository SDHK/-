




namespace ObjectPool_
{

    /// <summary>
    /// 对象池基类
    /// </summary>
    public abstract class ObjectPoolBase
    {

        /// <summary>
        /// 倒计时
        /// </summary>
        protected float clocktime = -1;

        /// <summary>
        /// 无操作自动回收时间设定
        /// </summary>
        public float clock = -1;

        /// <summary>
        /// 回收保留对象最大数量
        /// </summary>
        public int maxCount = -1;

        /// <summary>
        /// 预加载数量
        /// </summary>
        public int preloadCount = 0;

        /// <summary>
        /// 当前保留对象数量
        /// </summary>
        public abstract int Count { get; }

        /// <summary>
        /// 获取一个对象：转换类型
        /// </summary>
        public abstract T Get<T>() where T : class;

        /// <summary>
        /// 回收对象
        /// </summary>
        /// <param name="obj">对象</param>
        public abstract void Recycle(object obj);

        /// <summary>
        /// 清空对象池
        /// </summary>
        public abstract void Clear();

        /// <summary>
        /// 预加载
        /// </summary>
        public abstract void Preload();

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="deltaTime">刷新时间差</param>
        public abstract void Update(float deltaTime);


    }
}