using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //(4178 6f6e 5465 6368) sha3 Enctyption 256 bit
        //string Key="200d3bd2dfbab28d2b4c2bad45937431659a5d5f0cb7b3f22cd640e830c553ec";

        private void Form1_Load(object sender, EventArgs e)
        {
            keyarray[0]="4178";
            keyarray[1]="6f6e";
            keyarray[2]="5465";
            keyarray[3]="6368";
        }


        string[] keyarray = new string[4];
        Random num = new Random();
        
 
        private void gen_btn_Click(object sender, EventArgs e)
        {
            string generatedkey="";
            macid_tbox.Clear();
            foreach (string blocks in keyarray)
            {
                generatedkey += new string(blocks.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray())+" ";
            }
            macid_tbox.Text = generatedkey;

            //Checking Machine ID
            //ManagementObjectCollection mbsList = null;
            //ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            //mbsList = mbs.Get();
            //foreach (ManagementObject mo in mbsList)
            //{ 
            //    macid_tbox.Text = mo["ProcessorID"].ToString();
            //}

        }
    }
}
