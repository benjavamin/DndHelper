using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndHelper
{
    public class GeneratorClass
    {
        public InfoSource infoSource = new InfoSource();
        
        public Person GenNewAdult()
        {
            Person person = new NPC();
            string genName = "", genlName = "", genRace = "";
            int maxAge = 80;
            int counter = 0, deathChance = 0;
            bool genAlive = true;
            Random rnd = new Random();

            if (new Random().Next(0, 2) == 1) person.Sex = "Male";
            else person.Sex = "Female";
            
            while (true)
            {

                if (counter == 100) { MessageBox.Show("Name " + genName + " " + genlName + " exists"); break; }

                if (person.Sex == "Male")
                    genName = infoSource.maleNames[rnd.Next(0, infoSource.maleNames.Count)];
                else genName = infoSource.femaleNames[rnd.Next(0, infoSource.femaleNames.Count)];
                genlName = infoSource.lNames[rnd.Next(0, infoSource.lNames.Count)];

                if (String.IsNullOrEmpty(person.Race))
                {
                    genRace = infoSource.races[rnd.Next(0, infoSource.races.Count)];
                }

                if (InfoSource.existingNames.Contains(genName + " " + genlName + " " + genRace))
                { counter++; continue; }
                else break;


            }

            if (counter != 100)
            {

                if (rnd.Next(0, 100) % 5 != 0) maxAge =(int)(maxAge*0.6);
                person.Age = rnd.Next(18, maxAge);
                //if (person.Age <= 30) deathChance += 35-person.Age/2;
                //if (rnd.Next(0 + deathChance, 100) < person.Age) genAlive = false;//napravit uslove za sve rase

                person.FirstName = genName;
                person.LastName = genlName;
                person.Race = genRace;
                person.Alive = genAlive;
                InfoSource.existingNames.Add(person.FirstName + " " + person.LastName + " " + person.Race);
            }

            return person;
        }

        public Person GenNewPartner(Person partner)
        {
            Random rnd = new Random();
            Person person = new NPC();
            int minAge = partner.Age - 7, maxAge = partner.Age + 7;
            string genName = "", genlName = partner.LastName, genRace = partner.Race;
            int counter = 0, deathChance = 0;
            bool genAlive = true;
            

            if (new Random().Next(0, 2) == 1) person.Sex = "Male";
            else person.Sex = "Female";

            while (true)
            {

                if (counter == 100) { MessageBox.Show("Name " + genName + " " + genlName + " exists"); break; }

                if (partner.Sex == "Female")
                    genName = infoSource.maleNames[rnd.Next(0, infoSource.maleNames.Count)];
                else genName = infoSource.femaleNames[rnd.Next(0, infoSource.femaleNames.Count)];
                genlName = infoSource.lNames[rnd.Next(0, infoSource.lNames.Count)];

                if (String.IsNullOrEmpty(person.Race))
                {
                    genRace = infoSource.races[rnd.Next(0, infoSource.races.Count)];
                }

                if (InfoSource.existingNames.Contains(genName + " " + genlName + " " + genRace))
                { counter++; continue; }
                else break;


            }

            if (counter != 100)
            {
                if (minAge < 18) minAge = 18;
                if (maxAge < 18) maxAge = 22;
                person.Age = rnd.Next(minAge,maxAge);
                if (person.Age <= 30) deathChance += 35 - person.Age / 2;
                if (rnd.Next(0 + deathChance, 100) < person.Age) genAlive = false;//napravit uslove za sve rase//kappa

                person.FirstName = genName;
                person.LastName = genlName;
                person.Race = genRace;
                person.Alive = genAlive;
                InfoSource.existingNames.Add(person.FirstName + " " + person.LastName + " " + person.Race);
            }
            if (partner.Alive == false) person.Alive = true;
            return person;
        }

        public Person GenNewChild(Person parent1,Person parent2)
        {
            Person person = new NPC();
            string genName = "", genlName = parent1.LastName, genRace = parent1.Race;
            int maxAge = (parent1.Age+parent2.Age)/2 - 18 ;
            int counter = 0, deathChance = 0;
            bool genAlive = true;
            Random rnd = new Random();

            if (new Random().Next(0, 2) == 1) person.Sex = "Male";
            else person.Sex = "Female";

            while (true)
            {

                if (counter == 100) { MessageBox.Show("Name " + genName + " " + genlName + " exists"); break; }

                if (person.Sex == "Male")
                    genName = infoSource.maleNames[rnd.Next(0, infoSource.maleNames.Count)];
                else genName = infoSource.femaleNames[rnd.Next(0, infoSource.femaleNames.Count)];           

                if (InfoSource.existingNames.Contains(genName + " " + genlName + " " + genRace))
                { counter++; continue; }
                else break;

            }

            if (counter != 100)
            {
                
                if (maxAge == 0) maxAge = 2;
                if (maxAge >= 17) maxAge = 17;
                person.Age = rnd.Next(1, maxAge);
                deathChance = 60;
                if (rnd.Next(0 , 100+deathChance) < person.Age) genAlive = false;//napravit uslove za sve rase

                person.FirstName = genName;
                person.LastName = genlName;
                person.Race = genRace;
                person.Alive = genAlive;
                InfoSource.existingNames.Add(person.FirstName + " " + person.LastName + " " + person.Race);
            }

            return person;
        }
    }
}
