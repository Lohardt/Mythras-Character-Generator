﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mythras_Character_Generator
{
    public partial class SystemSelectForm : Form
    {
        public SystemSelectForm()
        {
            InitializeComponent();
        }

        private void SystemSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void MythrasSelectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdventuresInGloranthaForm frm = new AdventuresInGloranthaForm();
            frm.Show();
            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
