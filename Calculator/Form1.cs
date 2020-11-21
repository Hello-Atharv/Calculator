using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            if ((Display.Text == "0")||(operation_pressed)) Display.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            Display.Text = Display.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void oper(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Display.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch (operation)
            {
                case "+":
                    Display.Text = (value + Double.Parse(Display.Text)).ToString();
                    break;
                case "-":
                    Display.Text = (value - Double.Parse(Display.Text)).ToString();
                    break;
                case "*":
                    Display.Text = (value * Double.Parse(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (value / Double.Parse(Display.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            value = 0;
        }
    }
}
