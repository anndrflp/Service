﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.CONTROL;

namespace Service.CONTROL.Menu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterOnClick(object sender, EventArgs e)
        {
            //Security validation here
            //------------------------
            GTableRegister GTableRegister = new GTableRegister();
            GTableRegister.ShowDialog();
        }

        private String GetTableName()
        {
            return "MS_LOGIN";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
