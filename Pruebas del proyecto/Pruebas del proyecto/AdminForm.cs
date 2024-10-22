using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_del_proyecto
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];

            dataGridViewAdmin.Rows.Clear();


            foreach (DataGridViewRow row in formPrincipal.dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    dataGridViewAdmin.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                }
            }
        }

        private void btnRechazar_Click_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAdmin.SelectedRows[0].Index;
                dataGridViewAdmin.Rows.RemoveAt(selectedIndex);

                Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
                formPrincipal.BorrarPedidoEnPrincipal(selectedIndex);

                MessageBox.Show("Pedido rechazado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido para rechazar.");
            }
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAdmin.SelectedRows[0].Index;
                dataGridViewAdmin.Rows.RemoveAt(selectedIndex);

                // Eliminar en el formulario principal
                Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
                formPrincipal.BorrarPedidoEnPrincipal(selectedIndex);

                MessageBox.Show("Pedido rechazado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido para rechazar.");
            }
        }
    }
}
