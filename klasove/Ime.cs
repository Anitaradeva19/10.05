using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace klasove
{
    internal class Ime
    {
        private string name;
        private int age;

        private string firstName;
        private string lastName;    

        public Ime(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;   
            this.age = age; 
        }
        public string Name    
        {
            get { return name; }
            set { name = value; }   
        }
        public int getAge()
        {
            return this.age;
        }
        public void setAge(int value)
        {
            this.age = value;
        }
        public string getFirstName()
        {
            return this.firstName;  
        }
        public string setFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;   
        }
        public string setLastName()
        {
            return this.lastName;   
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is a {this.age} years old";
        }
        public void Out()
        {
            Console.WriteLine("Zdraveite!Az sum {0} i sum  mnogo dobyr.", Name);
        }
    }
}
