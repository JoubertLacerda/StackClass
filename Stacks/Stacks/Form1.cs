using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Stacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //create a stack
            Stack months = new Stack();

            //Insert elemets to the stack 
            months.Push("January");
            months.Push("Feb");
            months.Push("March");
            months.Push("April");
            months.Push("May");
            months.Push("June");
            months.Push("July");
            months.Push("August");
            months.Push("Sept");
            months.Push("October");
            months.Push("November");
            months.Push("Dec");

            //Returns number of elements in stack
            txtOUTPUT.Text += "Num. of elements in the stack:  " + months.Count.ToString();

            //return the top most of elemet of stack
            txtOUTPUT.Text += "\r\nThe top most item of stack is: "+months.Peek().ToString();

            //view items in the stack.
            txtOUTPUT.Text += "\r\nItems in the Stack: \r\n";
            foreach (string value in months)
            {
                txtOUTPUT.Text += value + "\r\n";
            }

            //remove an element from the stack 
            txtOUTPUT.Text += "\r\nRemove last in item of Stack: " + months.Pop().ToString();

            //check if element December is in the stack 
            if (!months.Contains("Dec")) txtOUTPUT.Text += "\r\n Dec. is not in the Stack!!";

            //view the new top most element of the stack
            txtOUTPUT.Text +="\r\nRead the top most item of the Stack: " + months.Peek().ToString();

            //empty the stack 
            months.Clear();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
