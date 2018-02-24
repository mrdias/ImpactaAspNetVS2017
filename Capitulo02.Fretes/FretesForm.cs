using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo02.Fretes
{
    public partial class fretesForm : Form
    {
        public fretesForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Calcular();
            }
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text);

            //ToDo: exemplificar novo switch do C# 2017.
            switch (ufComboBox.Text.ToUpper())
            {
                case "São Paulo SP":
                    percentual = 0.2m;
                    break;

                case "Rio de Janeiro RJ":
                    percentual = 0.3m;
                    break;

                case "Minas Gerais MG":
                    percentual = 0.35m;
                    break;

                case "Amazonas AM":
                    percentual = 0.6m;
                    break;

                default:
                    percentual = 0.75m;
                    break;
                case null:

                    break;
            }

            //if (ufComboBox.Text.ToUpper() == "São Paulo SP")
            //{
            //    percentual = 0.2m;
            //}

            //else if (ufComboBox.Text.ToUpper() == "Rio de Janeiro RJ" || ufComboBox.Text.ToUpper() == "Minas Gerais MG")
            //{
            //    percentual = 0.25m;
            //}
            //else
            //{
            //    percentual = 0.75m;
            //}

            freteTextBox.Text = percentual.ToString("p2");
            totalTextBox.Text = ((1 + percentual) * valor).ToString("c");

        }

        private bool ValidarFormulario()
        {
         
            if (clienteTextBox.Text == "")
            {
                MessageBox.Show("O Campo nome é obrigatorio.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (valorTextBox.Text == string.Empty)
            {
                MessageBox.Show("O valor é obrigatorio.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(valorTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Valor Invalido",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                    return false;
                }
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a UF",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (freteTextBox.Text == string.Empty)
            {
                MessageBox.Show("O frete é obrigatorio.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            //throw new NotImplementedException();
            return true;
        }

        private void calcularButton_Click_1(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Calcular();
            }
        }
    }
}
