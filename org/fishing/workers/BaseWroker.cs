namespace org.fishing.workers
{
    interface IWorker
    {
        void Work(int hours);
    }

    abstract class BaseWorker : IWorker
    {
        protected string name {get; }
        protected int salary {get; }
        protected int money {get; }
        protected BaseWorker(string name, int salary, int money)
        {
            this.name = name;
            this.salary = salary;
            this.money = money;
        }
        abstract virtual void Work(int hours);
    }
}