using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void act_btn_Click(object sender, EventArgs e)
        {
            bool status=checkvalidation(macid_tbox.Text);
            if (status) 
                label1.Text = "Key is Valid";
            else
                label1.Text = "Key is InValid";
        }

        string[] keyarray = new string[4];
        private void Form1_Load(object sender, EventArgs e)
        {
            keyarray[0] = "4178";
            keyarray[1] = "6f6e";
            keyarray[2] = "5465";
            keyarray[3] = "6368";
        }

        private bool checkvalidation(string text) 
        {
            string[] blocksArr = text.Split(' ');
            for (int i = 0; i < blocksArr.Length; i++)
            {
                foreach (char letter in blocksArr[i])
                {
                    if (!keyarray[i].Contains(letter.ToString()))
                        return false;
                }
            }
            return true;
        }
        
    }
}
