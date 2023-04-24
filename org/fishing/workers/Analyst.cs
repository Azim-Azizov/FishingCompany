using org.fishing.workers.enums;
using org.fishing.random;


namespace org.fishing.workers
{
    sealed class Analyst : BaseWorker
    {
        private AnalystTeam team;
        public Analyst(string name, int salary, int money) : base(name, salary, money)
        {
            this.team = SingleRand.Team();
        }
        public override void Work(int hours)
        {
            money += ((salary + (int) team) * hours);
        }
    }
}