﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;


        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void resultadolistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6, c = 10, d = 13;
            int A = 42;

            resultadoListBox.Items.Add("a = " + a.ToString());
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add($"c = {c}, mas d = {d}");
            resultadoListBox.Items.Add(string.Concat("d = ", d, "mas o c = ", c));

            resultadoListBox.Items.Add(new string('-', 11));
            resultadoListBox.Items.Add("c * d = " + (c * d));
            resultadoListBox.Items.Add("c / a = " + (c / a));
            resultadoListBox.Items.Add("d % a = " + (d % a));

            //decimal valor = 10;
            //var nomeCliente = "Miguel";
            //nomeCliente = 10.ToString();
            //bool habilitado = false;
            //var dataNascimento = new DateTime(01, 01, 1900);
            //var @class = "1º Ano";

            /*if (a == 14)
            {

            }*/
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("x = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pré-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + ++a = " +(2+ ++a));
            resultadoListBox.Items.Add("a = " + a);

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pós-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + a++ = " + (2 + a++));
            resultadoListBox.Items.Add("a = " + a);


        }

        private void boleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

            resultadoListBox.Items.Add("w <= x =" + (_w <= _x));
            resultadoListBox.Items.Add("x == z = " + (_x == _z));
            resultadoListBox.Items.Add("x != z = " + (_x != _z));

        }

        private void MostrarVariaveis()
        {
            resultadoListBox.Items.Add("x = " + _x);
            resultadoListBox.Items.Add("w = " + _w);
            resultadoListBox.Items.Add("y = " + _y);
            resultadoListBox.Items.Add("z = " + _z);
        }

        private void lógicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

            resultadoListBox.Items.Add("_w <= _x || _y == 16 =" + (_w <= _x || _y == 16));
            resultadoListBox.Items.Add("_x == _z && _z != _x =" + (_x == _z && _z != _x));
            resultadoListBox.Items.Add("!(_y > _w )= " + (!(_y > _w)));

            //if (true)
            //{
            //    var x = 42;
            //}

            //X = 10;
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
            
            ano = 2014;
            resultadoListBox.Items.Add("Ano = " + ano);
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
                ano % 4 == 0 ?"Sim" : "Não"));

            ano = 2016;
            resultadoListBox.Items.Add("Ano = " + ano);
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
                DateTime.IsLeapYear(ano) ? "Sim" : "Não"));

            //var resposta = "";
            //if(ano % 4 == 0)
            //{
            //    resposta = "Sim";
            //}
            //else
            //{
            //    resposta = "Não";
            //}

        }
    }
}
