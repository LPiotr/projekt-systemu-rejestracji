﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_systemu_rejestracji
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System rejestracji Lebelt Piotr, 155243, Eliasz Bąk, 148988, 22/23, " +
                "Wydział Techniki i Informatyki, D1, Sem 5");
        }
    }
}
