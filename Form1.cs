﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestWinForms
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOne.Text = rnd.Next(0, 101).ToString();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtTwo.Text = rnd.Next(0, 3001).ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtThree.Text = rnd.Next(30000, 100001).ToString();
        }

        private void btnCheckOne_Click(object sender, EventArgs e)
        {
            int valueFromTxtBox = Convert.ToInt32(txtOne.Text);
            if (valueFromTxtBox <= 50)
            {
                btnCheckOne.BackColor = Color.Red;
            } else
            {
                btnCheckOne.BackColor = Color.Green;
            }
        }

        private void btnCheckTwo_Click(object sender, EventArgs e)
        {
            int valueFromTxtBox = Convert.ToInt32(txtTwo.Text);
            if (valueFromTxtBox <= 1000)
            {
                btnCheckTwo.BackColor = Color.Red;
            } else if (valueFromTxtBox <= 2000)
            {
                btnCheckTwo.BackColor = Color.Yellow;
            } else if (valueFromTxtBox <= 3000)
            {
                btnCheckTwo.BackColor = Color.Green;
            }
        }

        private void btnCheckThree_Click(object sender, EventArgs e)
        {
            int valueFromTxtBox = Convert.ToInt32(txtThree.Text);
            if (valueFromTxtBox <= 30000)
            {
                btnCheckThree.BackColor = Color.Red;
            }
            else if (valueFromTxtBox <= 50000)
            {
                btnCheckThree.BackColor = Color.Orange;
            }
            else if (valueFromTxtBox <= 75000)
            {
                btnCheckThree.BackColor = Color.Yellow;
            } else
            {
                btnCheckThree.BackColor = Color.Green;
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = Convert.ToInt32(txtOne.Text) + Convert.ToInt32(txtTwo.Text) + Convert.ToInt32(txtThree.Text);
                lblSum.Text = sum.ToString();
            } catch
            {
                MessageBox.Show("One or more text boxes are empty.");
            }
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            int intAddition = 0;
            for (int i = 0; i <= 1000; i++)
            {
                intAddition += i;
            }
            lblForLoop.Text = intAddition.ToString();
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int intWhile = 10000;
            while (intWhile >= -100)
            {
                intWhile -= 101;
            }
            lblWhileLoop.Text = intWhile.ToString();
        }
    }
}
