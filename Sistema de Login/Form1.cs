﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistema_de_Login
{
    public partial class Form1 : Form
    {
        Thread nt; //criação da Thead como se fosse uma variavel
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Yasha" && textBoxSenha.Text == "270221")
            {
                // MessageBox.Show("Bem vindo ao sistema!", "Acesso ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //Neste caso iremos ja fechar o primeiro formulario e iremos ja para o segundo formulario
                nt = new Thread(formulario2);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Acesso Negado!", "Acesso Negado ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)

        {


        }
        private void formulario2(object obj)
        {
            Application.Run(new FormDeLogin());
        }
    }
}
