﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Form2 : Form
    {
        int nivel = 0;

        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nivel = 1;
            chamaJogo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nivel = 2;
            chamaJogo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nivel = 3;
            chamaJogo();
        }

        private void chamaJogo()
        {
            Form1 jogo = new Form1(nivel);
            jogo.ShowDialog();
        }        
    }
}