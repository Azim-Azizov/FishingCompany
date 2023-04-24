using System;
using System.Collections.Generic;
using org.fishing.random;


namespace org.fishing.departments
{
    interface IDepartment<T>
    {
        void Hire(T worker);
        void Fire(int id);
        void Fire(T worker);
    }

    abstract class BaseDepartment<T> : IDepartment<T>
    {
        protected int budget = SingleRand.Instance.Next(500, 1000);
        protected int workersCount {get; } = 0;
        protected List<T> workers;
        protected BaseDepartment()
        {
            this.budget = SingleRand.Instance.Next(5000, 10000);
        }
        protected override void Hire(T worker)
        {
            workers.Add(worker);
            workersCount++;
        }
        protected override void Fire(int id)
        {
            workers.RemoveAt(id - 1);
            workersCount--;
        }
        protected override void Fire(T worker)
        {
            workers.Remove(worker);
            workersCount--;
        }
    }
}