using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EELS_Kalkulator
{
    public partial class Form1 : Form
    {
        public int Number=0;
        public int Number2 = 2;
        bool addition = false;
        bool subtract = false;
        bool multiplication = false;
        bool divide = false;

        
        public string Operation;
        public Form1()
        {
            InitializeComponent();

            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            addNumber(1);
                           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNumber(2);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNumber(3);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNumber(4);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNumber(6);
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNumber(7);
           
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            addNumber(8);
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNumber(9);
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            addNumber(0);
            
        }

        public void UpdateLabels()
        {
            Operation = Number.ToString();
            textBox.Text = Operation;
        }

        public void ClearLabels()
        {
            Operation = "";
            textBox.Text = Operation;
            Number = 0;
            Number2 = 0;
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            addition = true;

            Number2 = Number;
            
            textBox.Text = "+";

            Number = 0;
                        
        }
        private void subtractionButton_Click(object sender, EventArgs e)
        {
            subtract = true;

            Number2 = Number;

            textBox.Text = "-";

            Number = 0;

        }
        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            multiplication = true;
            Number2 = Number;

            textBox.Text = "*";

            Number = 0;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            divide = true;
            Number2 = Number;

            textBox.Text = "/";

            Number = 0;
        }


        private void equalButton_Click(object sender, EventArgs e)
        {
            int equal=0;
            if (addition)
            {
                 equal = Number2 + Number;
            }
            if (subtract)
            {
                equal = Number2 - Number;
            }
            if (multiplication)
            {
                equal = Number2 * Number;
            }
            if (divide)
            {
                if (Number != 0)
                    equal = Number2 / Number;
                else
                    MessageBox.Show("Nie dziel przez zero !","DZIELENIE PRZEZ ZERO");
            }

            textBox.Text = equal.ToString();


        }

        public int addNumber(int buttonNr)
        {
            if (Number != 0)
            {
                Number = Number * 10 + buttonNr;
            }
            else
            {
                Number = buttonNr;
            }
            UpdateLabels();
            return Number;
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearLabels();
        }

        
    }
}
