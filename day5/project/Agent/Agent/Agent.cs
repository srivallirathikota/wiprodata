using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent
{
      
    public class Agent
    {
        public int AgentId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String City {  get; set; }
        public string Gender {  get; set; }
        public double PremiumAmount {  get; set; }
     
        public Agent() { }
        public Agent(int agentId, string firstName, string lastName, string city, string gender, double premiumAmount)
        {
            AgentId = agentId;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Gender = gender;
            PremiumAmount = premiumAmount;
        }
        public override string ToString()
        {
            return "AgentId: " + AgentId + " FirstName: " + FirstName + " Lastname: " + LastName + " city: " + City + " Gender: " + Gender + "PremiumAmount " + PremiumAmount;
        }
    }
}
