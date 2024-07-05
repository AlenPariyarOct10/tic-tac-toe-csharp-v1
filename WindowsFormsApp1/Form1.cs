using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RestartGame()
        {
            // Create a new instance of the form
            Form1 newForm = new Form1();
            newForm.Show();

            // Close the current form
            
        }

        private void checkWon()
        {
            Button[][] btns = new Button[][]
            {
                new Button[] { button1, button2, button3 },
                new Button[] { button4, button5, button6 },
                new Button[] { button7, button8, button9 }
            };



            // Row Match Win Logic

            if (btns[0][0].Text != "" && btns[0][1].Text != "" && btns[0][2].Text != ""
                && btns[0][0].Text == btns[0][1].Text && btns[0][1].Text == btns[0][2].Text)
            {
                MessageBox.Show(btns[0][0].Text + " won the game.");
                this.Close();
            }

            if (btns[1][0].Text != "" && btns[1][1].Text != "" && btns[1][2].Text != ""
                && btns[1][0].Text == btns[1][1].Text && btns[1][1].Text == btns[1][2].Text)
            {
                MessageBox.Show(btns[1][0].Text + " won the game.");
                this.Close();

            }

            if (btns[2][0].Text != "" && btns[2][1].Text != "" && btns[2][2].Text != ""
                && btns[2][0].Text == btns[2][1].Text && btns[2][1].Text == btns[2][2].Text)
            {
                MessageBox.Show(btns[2][0].Text + " won the game.");
                this.Close();

            }

            // Column Match Win Logic

            if (btns[0][0].Text != "" && btns[1][0].Text != "" && btns[2][0].Text != ""
                && btns[0][0].Text == btns[1][0].Text && btns[1][0].Text == btns[2][0].Text)
            {
                MessageBox.Show(btns[2][0].Text + " won the game.");
                this.Close();

            }

            if (btns[0][1].Text != "" && btns[1][1].Text != "" && btns[2][1].Text != ""
                && btns[0][1].Text == btns[1][1].Text && btns[1][1].Text == btns[2][1].Text)
            {
                MessageBox.Show(btns[2][1].Text + " won the game.");
                this.Close();

            }

            if (btns[0][2].Text != "" && btns[1][2].Text != "" && btns[2][2].Text != ""
                && btns[0][2].Text == btns[1][2].Text && btns[1][2].Text == btns[2][2].Text)
            {
                MessageBox.Show(btns[2][2].Text + " won the game.");
                this.Close();

            }

            // Diagonal Match Win Logic

            if (btns[0][0].Text != "" && btns[1][1].Text != "" && btns[2][2].Text != ""
                && btns[0][0].Text == btns[1][1].Text && btns[1][1].Text == btns[2][2].Text)
            {
                MessageBox.Show(btns[2][2].Text + " won the game.");
                this.Close();

            }

            if (btns[0][2].Text != "" && btns[1][1].Text != "" && btns[2][0].Text != ""
                && btns[0][2].Text == btns[1][1].Text && btns[1][1].Text == btns[2][0].Text)
            {
                MessageBox.Show(btns[2][0].Text + " won the game.");
                this.Close();


            }



        }

        private void btn_clicked(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                count++;

                if(count == 9)
                {
                    MessageBox.Show("------------- Draw -------------");
                    this.Close();
                }
                else
                {
                    if (count % 2 == 0)
                    {
                        btn.Text = "X";
                        btn.BackColor = Color.LightBlue;

                    }
                    else
                    {
                        btn.Text = "O";
                        btn.BackColor = Color.OrangeRed;

                    }
                }

                

                btn.Enabled = false;

                checkWon();
            }
        }
    }
}
