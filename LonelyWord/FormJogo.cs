﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LonelyWord
{
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }
        private void FormJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            this.Hide();
        }
    }
}