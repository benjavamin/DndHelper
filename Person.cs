using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndHelper
{
    public abstract class Person
    {
       
        private string firstName;
        private string lastName;
        private int age;
        private string sex;
        private string race;
        private bool alive;


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Race { get => race; set => race = value; }
        public bool Alive { get => alive; set => alive = value; }

        public abstract void GenerateEvent();

        public Person()
        {

        }
        

        public Person(string firstName , string lastName, int age, string sex,string race,bool alive)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.sex = sex;
            this.race = race;
            this.alive = alive;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
