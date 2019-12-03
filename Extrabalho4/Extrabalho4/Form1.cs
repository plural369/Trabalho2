using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extrabalho4
{
    public partial class Form1 : Form
    {
        Queue<String> fila = new Queue<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFila_Click(object sender, EventArgs e)
        {
            //testa para ver se o campo esta vazio
            if (String.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Informe um valor:");
                txtValor.Focus();
            }
            else
            {
                fila.Enqueue(txtValor.Text);
                txtValor.Clear();
                txtValor.Focus();
            }

            lstFila.Items.Clear();

            //percorre o array
            foreach (var item in fila)
            {
                lstFila.Items.Add((Environment.NewLine + item.ToString()));
            }
        }

        private void btnTira_Click(object sender, EventArgs e)
        {
            if (fila.Count == 0)
            {
                MessageBox.Show("Fila Vazia.");
            }
            else
            {
                fila.Dequeue();
                lstFila.Items.Clear();
                foreach (string d in fila)
                {
                    lstFila.Items.Add((Environment.NewLine + d.ToString()));
                }
            }
        }
    }
}
