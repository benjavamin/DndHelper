using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DndHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chance = 0;
            NPC personOne = (NPC)new GeneratorClass().GenNewAdult();
            NPC personPartner = (NPC)new GeneratorClass().GenNewPartner(personOne);

            Random random = new Random();
            listBox1.Items.Add(personOne.ToString() + ", " + personPartner.ToString());
            while (random.Next(100 - personOne.Age) > ((personOne.Age + personPartner.Age+chance)/2))
            {
                NPC child = (NPC)new GeneratorClass().GenNewChild(personOne,personPartner);
                listBox1.Items.Add("Child: " + child.ToString() + "\n\n");
                chance += 15;
            }
            
            
        }
    }
}
