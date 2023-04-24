using org.fishing.workers.enums;
using org.fishing.random;


namespace org.fishing.workers
{
    sealed class Fisher : BaseWorker
    {
        private FishingSpeciality speciality;
        public Fisher(string name, int salary, int money) : base(name, salary, money)
        {
            this.speciality = SingleRand.Speciality();
        }
        public override void Work(int hours)
        {
            money += ((salary + (int) speciality) * hours);
        }
    }
}