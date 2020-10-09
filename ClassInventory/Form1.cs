using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<ClassInv> classIn = new List<ClassInv>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 
            string name = nameInput.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            // TODO - create object with gathered information
            ClassInv newClassInv = new ClassInv(name, age, team, position);

            // TODO - add object to global list
            classIn.Add(newClassInv);

            // TODO - display message to indicate addition made\
            outputLabel.Text = "A team member was added to the list \n";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = null;

            string name = nameInput.Text;
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object is in list remove it
            int index = classIn.FindIndex(n => n.name == name);

            if (index >= 0)

            {
                classIn.RemoveAt(index);
            }

            // TODO - display message to indicate deletion made
            outputLabel.Text = "A team member was removed from the list \n";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = null;

            string name = textBox1.Text;

            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object entered exists in list show it
            ClassInv player = classIn.Find(x => x.name == name);

            outputLabel.Text = player.name + "\n" + player.age + "\n" + player.team + "\n" + player.position;

            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list
            outputLabel.Text = null;

            foreach (ClassInv c in classIn)
            {
                outputLabel.Text += c.name + "\n";
                outputLabel.Text += c.age + "\n";
                outputLabel.Text += c.team + "\n";
                outputLabel.Text += c.position + "\n\n";
            }
        }
    }
}
