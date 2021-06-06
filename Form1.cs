using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace A_fence_cipher
{
    public partial class Form1 : Form
    {
        FileStream file = new FileStream("message.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        int key;
        string message = "";
        char[] messagechar;

        public Form1()
        {
            InitializeComponent();
            //draw a key
            Random r = new Random();
            tBKey.Text = Convert.ToString(r.Next(int.MinValue, int.MaxValue));
        }

        private void Btngo_Click(object sender, EventArgs e)
        {
            //the key cannot be empty!!!
            if (tBKey.Text == "") tBKey.Text = "0";
            key = Convert.ToInt32(tBKey.Text);
            //loading the message from the text field and saving it to a file
            if (rBText.Checked == true)
            {
                message = tBText.Text;
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(message);
                sw.Close();
            }
            //loading a message from a file and saving it to the text field
            else if (rBFile.Checked == true)
            {
                StreamReader sr = new StreamReader(file);
                message = sr.ReadLine();
                sr.Close();
                tBText.Text = message;
            }
            //the beginning of the algorithm
            messagechar = message.ToCharArray();
            //message encryption
            if (rBE.Checked == true)
            {
                char[,] result = new char[key, messagechar.Length];//cryptogram
                int row = 0;//row number
                int d = 1;//direction
                //creating a hurdle
                for (int j = 0; j < messagechar.Length; j++)
                {
                    result[row, j] = messagechar[j];
                    if (row < key - 1 && d == 1) row++;
                    else if (row == key - 1)
                    {
                        row--;
                        d = -1;//small
                    }
                    else if (row > 0 && d == -1) row--;
                    else if (row == 0)
                    {
                        row++;
                        d = 1;//grow
                    }
                }
                //writing a ciphertext
                for (int i = 0; i < key; i++)
                    for(int j = 0; j < messagechar.Length; j++)
                        tBMessage.Text += result[i, j].ToString();
            }
            //message decryption
            else if (rBD.Checked == true)
            {
                char[,] result = new char[key, messagechar.Length];//cryptogram
                int d = 1;//direction
                int row = 0, col = 0;
                int cursor = 0;

                //creating a hurdle with marker
                for (int i = 0; i < messagechar.Length; i++)
                {
                    if (row == 0) d = 1;//grow
                    if (row == key - 1) d = -1;//small
                    //marker to mark the place
                    result[row,col++] = '*';

                    if (d == 1) row++;
                    else row--;
                }
                //entering a character from the ciphertext to the fence
                for (int i = 0; i < key; i++) {
                    for (int j = 0; j < messagechar.Length; j++) {
                        if (result[i,j] == '*' && cursor < messagechar.Length)
                            result[i,j] = messagechar[cursor++];
                    }
                }

                //writing a message       
                row = 0;
                col = 0;
                for (int i = 0; i < messagechar.Length; i++)
                {
                    if (row == 0) d = 1;
                    if (row == key - 1) d = -1;

                    if (result[row,col] != '*') tBMessage.Text+=result[row,col++].ToString();

                    if (d == 1) row++;
                    else row--;
                }
            }
            //protection against the next operation
            gBOperation.Enabled = false;
            gBSource.Enabled = false;
            gBKey.Enabled = false;
            tBText.Enabled = false;
        }

        //draw a key
        private void Btndraw_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tBKey.Text = Convert.ToString(r.Next(int.MinValue, int.MaxValue));
        }

        ////select a message input method
        private void SelectSource(object sender, EventArgs e)
        {
            if (rBText.Checked == true) tBText.Enabled = true;
            else if (rBFile.Checked == true) tBText.Enabled = false;
        }

        //display the selected operation as the button text
        private void SelectOperation(object sender, EventArgs e)
        {
            if (rBE.Checked == true) Btngo.Text = rBE.Text;
            else if (rBD.Checked == true) Btngo.Text = rBD.Text;
        }
    }
}
