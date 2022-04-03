//Array of labels demo
//The array is created in the constructor
//It is made global in order to be accessible to all functions

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Label[] arr; 

        public Form1()
        {
            InitializeComponent();
            //Create an array of 5 labels
            arr = new Label[] { label1, label2, label3, label4, label5 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i].Text = i.ToString();
        }
    }
}
