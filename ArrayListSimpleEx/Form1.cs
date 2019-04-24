using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList msg;
        bool revmsg = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayMessage(ArrayList msg)
        {

            lblMessage.Text = "";

            for(int i = 0; i < msg.Count; i++)
            {
                lblMessage.Text += msg[i] + " ";
            }

        }

        private void ReverseMessage()
        {
            ArrayList rev = new ArrayList(msg);

            rev.Reverse();

            DisplayMessage(rev);

            revmsg = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg = new ArrayList();

            msg.Add("I");
            msg.Add("love");
            msg.Add("programming");
            msg.Add("so");
            msg.Add("much");
           
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            DisplayMessage(msg);
            revmsg = false;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
             ReverseMessage();
             
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(revmsg == true)
           {
                MessageBox.Show("Cannot insert in reverse");

           }
           else
           {
                msg.Insert(1, txtSecondPos.Text);
           }

            DisplayMessage(msg);
        }
    }
}
