using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndHelper
{
    class PC : Person
    {

        int aBar = new Random().Next(70, 100);
        string backStory;
        string desires;
        string fears;

        public PC(string firstName, string lastName) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;      
        }

        public override void GenerateEvent() => MessageBox.Show("Ime : " + FirstName + ", Prezime: " + LastName);
    }
}
