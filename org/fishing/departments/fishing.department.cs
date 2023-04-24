using org.fishing.workers;
using org.fishing.random;


namespace org.fishing.departments
{
    sealed class FishingDepartment : BaseDepartment<Fisher>
    {
        private int workingBoats;
        private int DamagedBoats;
        public FishingDepartment() : base()
        {
            this.workingBoats = SingleRand.Instance.Next(5, 10);
            this.DamagedBoats = SingleRand.Instance.Next(1, 3);
        }
        public void FixBoat()
        {
            if (DamagedBoats > 0)
            {
                this.budget -= SingleRand.Instance.Next(500, 1000);
                this.DamagedBoats--;
                this.workingBoats++;
            }
        }
    }
}