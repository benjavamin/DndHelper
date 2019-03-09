using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndHelper
{
    class NPC : Person
    {
        string profession;
        Person partner;
        List<Person> children;
        int aBar;

        public NPC()
        {
        }

        public NPC(string firstName, string lastName,string sex,int age, string race, bool alive, string profession) : base(firstName,lastName,age,sex,race,alive)
        {
            this.aBar = new Random().Next(40, 70);
            this.profession = profession;
        }

        public string Profession { get => profession; set => profession = value; }
        public Person Partner { get => partner; set => partner = value; }
        public List<Person> Children { get => children; set => children = value; }
        public int ABar { get => aBar; set => aBar = value; }

        public override void GenerateEvent() => MessageBox.Show("Ime : " + FirstName + ", Prezime: " + LastName);

        public override string ToString()
        {
            string Info = FirstName + " " + LastName + " " + Race;
            if (Alive == false) Info += ",and he died at the age of " + Age;
            else Info += " and they are " + Age;
            if (!String.IsNullOrWhiteSpace(Profession)) Info += ",their profession is/was " + profession; 

            return Info;
        }

    }
}
