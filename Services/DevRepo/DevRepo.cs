using System;
using System.Collections.Generic; 

namespace KomodoInsurance.ConsoleApp
{
    //reps a developer in the system
    public class developer
    {
        //ID for the developer
        public int DeveloperID { get; set; }
        
        //Name of the dev
        public string Name { get; set; }
        
        //Indicates whether they have access to Pluralsight
        public bool HasPluralsightAccess { get; set; }

        //Reps the develpment team in the system
        public class DevTeam
        {
            //ID for the team
            public int TeamId { get; set; }

            //Team Name
            public string TeamName { get; set; }
            
            //List of DevIDs repping the team members
            public List<int> TeamMembers { get; set; } //Store devIDS
        }
    }
}