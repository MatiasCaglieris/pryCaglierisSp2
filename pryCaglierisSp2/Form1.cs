using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCaglierisSp2
{
    public partial class lblNumero : Form
    {
        public lblNumero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbtickets.Items.Clear();
            cmbtickets.Items.Add("General");
            cmbtickets.Items.Add("VIP");
            cmbtickets.Items.Add("Preferencial");
            cmbtickets.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroTickets.Text))
            {
                MessageBox.Show("Debe ingresar un número de ticket válido.");
                return; 
            }

            if (string.IsNullOrEmpty(cmbtickets.Text))
            {
                MessageBox.Show("Debe seleccionar un tipo de ticket.");
                return;
            }

            // Validar que SelectedItem no sea null antes de llamar ToString()
            if (cmbtickets.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de ticket de la lista.");
                return;
            }

            string numeroTickets = txtNumeroTickets.Text;
            string tipo = cmbtickets.SelectedItem.ToString();
            string entrada = numeroTickets + " - " + tipo + " - " + dtpFecha.Value.ToShortDateString();
            lstboxventas.Items.Add(entrada);

            txtNumeroTickets.Clear();
            txtNumeroTickets.Focus();
        }

        private void txtNumeroTickets_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void lstboxventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
