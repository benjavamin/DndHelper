using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndHelper
{
    abstract class Town
    {
        string townName;
        int townXPos;
        int townYPos;
        static List<Person> peopleList;

        public string TownName { get => townName; set => townName = value; }
        public int TownXPos { get => townXPos; set => townXPos = value; }

        public abstract void GenerateEvent();
    }
}
