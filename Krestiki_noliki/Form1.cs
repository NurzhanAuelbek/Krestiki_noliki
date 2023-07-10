using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krestiki_noliki
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            if(xTurn)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            //Если пользователь нажмет второй раз
            ////наше кнопка присвоить значения “О” 
            xTurn = !xTurn;
            //Делам так что бы пользователь мог нажимать
            //одну и ту же кнопку только 1 раз 
            senderB.Enabled = false;
            //Вызываем метод победителя
            CheckWin(senderB);

        }
        void CheckWin(Button pressesButton)
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false) 
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Enabled == false)
            {
                //Для вывода сообщений
                MessageBox.Show("WIN --- " + pressesButton.Text);
                Application.Restart();
            }
        }
    }
}
