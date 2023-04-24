using org.fishing.workers;
using org.fishing.random;


namespace org.fishing.departments
{
    sealed class AnalystDepartment : BaseDepartment<Analyst>
    {
        private int monthlyIncome;
        public AnalystDepartment() : base()
        {
            this.monthlyIncome = SingleRand.Instance.Next(1000, 5000);
        }
        public void PayTaxes()
        {
            this.budget -= SingleRand.Instance.Next(1000, 2000);
        }
    }
}