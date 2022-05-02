using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula52_Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCLT_Click(object sender, EventArgs e)
        {

            txtBonus.Visible = false;
            lblBonus.Visible = false;
            txtBoxVProjeto.Visible = false;
            lblVProjeto.Visible = false;

            if (txtSalario.Text == "")
            {
                MessageBox.Show("Digite o Nome e o Salario: ");
            }
            else
            {
                decimal salarioBruto = decimal.Parse(txtSalario.Text);
                decimal descontoVT = (salarioBruto / 100) * 6;
                decimal descontoINSS = 0;

                if (salarioBruto < 1000)
                {
                    descontoINSS = (salarioBruto / 100) * 8;
                }
                else if (salarioBruto < 2000)
                {
                    descontoINSS = (salarioBruto / 100) * 12;
                }
                else
                {
                    descontoINSS = (salarioBruto / 100) * 15;
                }

                decimal salarioFinal = salarioBruto - descontoVT - descontoINSS;

                txtboxSalarioFinal.Text = salarioFinal.ToString("N2") ;

                lblSalarioLiquido.Visible = true;
                txtboxSalarioFinal.Visible = true;
                string nome = textBoxColaborador.Text;
                lblN2.Text = nome;
                textBoxColaborador.Clear();
                txtSalario.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBonus.Visible = false;
            lblBonus.Visible = false;
            txtBoxVProjeto.Visible = false;
            lblVProjeto.Visible = false;
            lblSalarioLiquido.Visible = true;
            txtboxSalarioFinal.Visible = true;
        }

        private void btnFreela_Click(object sender, EventArgs e)
        {
            txtBonus.Visible = true;
            lblBonus.Visible = true;
            txtBoxVProjeto.Visible = true;
            lblVProjeto.Visible = true;
            txtboxSalarioFinal.Visible = false;
            lblSalarioLiquido.Visible = false;

            if (txtBoxVProjeto.Text != "" && txtSalario.Text != "")
            {
                decimal valorProjeto = decimal.Parse(txtBoxVProjeto.Text);
                decimal abono = (valorProjeto / 100) * 8.5M;
                decimal salarioFreela = abono + decimal.Parse(txtSalario.Text);
                txtBonus.Text = salarioFreela.ToString("N2");
                string nome = textBoxColaborador.Text;
                lblN2.Visible = false;
                lblN.Text = nome;
    
                txtSalario.Clear();
                txtBoxVProjeto.Clear();
                textBoxColaborador.Clear();
            }
        
        }

        private void btnPJ_Click(object sender, EventArgs e)
        {
            txtBonus.Visible = false;
            lblBonus.Visible = false;
            txtBoxVProjeto.Visible = false;
            lblVProjeto.Visible = false;

            if (txtSalario.Text == "")
            {
                MessageBox.Show("Digite o Nome e o Salario: ");
            }
            else
            {
                decimal salarioBruto = decimal.Parse(txtSalario.Text);
                decimal descontoDAS = (salarioBruto / 100) * 6;
                decimal salarioFinal = salarioBruto - descontoDAS;
                txtboxSalarioFinal.Text = salarioFinal.ToString("N2");
                string nome = textBoxColaborador.Text;
                lblN2.Text = nome;
                textBoxColaborador.Clear();
                txtSalario.Clear();
            }
            
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
