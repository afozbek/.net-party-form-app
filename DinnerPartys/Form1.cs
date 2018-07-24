using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerPartys
{
    public partial class Form1 : Form
    {
        BirthdayParty birthdayParty;
        DinnerParty dinnerParty;
        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healty_Check.Checked);
            costLabel.Text = Cost.ToString("c");

        }
        public void DisplayBirthdayPartyCost()
        {
            birth_text.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            costB_label.Text = cost.ToString("c");
        }
        public Form1()
        {
            
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,healty_Check.Checked,
                fancy_Check.Checked);

            birthdayParty = new BirthdayParty((int)numB_numeric.Value,
                fancy_CheckB.Checked, 
                birth_text.Text);
            DisplayBirthdayPartyCost();

            DisplayDinnerPartyCost();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfpeople=(int)numericUpDown1.Value ;

            DisplayDinnerPartyCost();
        }

        private void fancy_Check_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancy_Check.Checked);
            DisplayDinnerPartyCost();

        }

        private void healty_Check_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healty_Check.Checked);
            DisplayDinnerPartyCost();
        }

        private void numB_numeric_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numB_numeric.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancy_CheckB_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancy_CheckB.Checked);
            DisplayBirthdayPartyCost();
        }

        private void cakeText_Changed(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = birth_text.Text;
            DisplayBirthdayPartyCost();
        }

        private void enterPressed(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

           
            birthdayParty.NumberOfPeople=(int)numB_numeric.Value;
            DisplayBirthdayPartyCost();
            }
        }
    }
}
