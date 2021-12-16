using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art_Calculator
{

    public partial class Form1 : Form
    {
        int Time_Spent;
        int Time_Left;
        int Time_Needed;
        int Percentage;

        public Form1()
        {
            InitializeComponent();

            //Okina.Controls.Add(pictureBox1);
            //pictureBox1.Location = new Point(0, 0);
            //pictureBox1.BackColor = Color.Transparent;

        }

        //Ignore
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Button :)
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Put in a Correct Value");
            }
            else
            {
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Put in a Correct Value");
                }
                else
                {
                    if (String.IsNullOrEmpty(textBox3.Text))
                    {
                        MessageBox.Show("Put in a Correct Value");
                    }
                    else 
                    {
                        if(int.Parse(textBox2.Text) > 0)
                        {
                            if (int.Parse(textBox3.Text) > 0)
                            {
                                if (int.Parse(textBox1.Text) > 0)
                                {
                                    //Time Spent = Frames done / Average
                                    Time_Spent = int.Parse(textBox2.Text) / int.Parse(textBox3.Text);
                                    //Time Left = (length - FD) / Average
                                    Time_Left = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)) / int.Parse(textBox3.Text);
                                    //Time Needed = length / Average
                                    Time_Needed = int.Parse(textBox1.Text) / int.Parse(textBox3.Text);
                                    //Percentage = (Length / FD) x 10
                                    Percentage = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text));

                                    textBox4.Text = (Time_Spent.ToString() + "h");
                                    textBox5.Text = (Time_Left.ToString() + "h");
                                    textBox6.Text = (Time_Needed.ToString() + "h");
                                    label9.Text = (Percentage.ToString() + "%");
                                    progressBar1.Value = Percentage;
                                }
                                else
                                {
                                    MessageBox.Show("Put in a Correct Value");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Put in a Correct Value");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Put in a Correct Value");
                        }
                    }
                }
            }
        }
    

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        // Frames done
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Average
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Okina_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
