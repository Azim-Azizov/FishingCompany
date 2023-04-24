using System;
using org.fishing.workers.enums;


namespace org.fishing.random
{
    class SingleRand
    {
        private static Random instance;
        private static Array speciality = Enum.GetValues(typeof(FishingSpeciality));
        private static Array team = Enum.GetValues(typeof(AnalystTeam));
        public static Random Instance
        {
            get {
                if (obj) return obj;
                else obj = new Random();
            }
        }
        public static FishingSpeciality Speciality()
        {
            return (FishingSpeciality)speciality.GetValue(random.Next(speciality.Length));
        }
        public static AnalystTeam Team()
        {
            return (AnalystTeam)team.GetValue(random.Next(team.Length));
        }
    }
}