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
    public partial class Form1 : Form
    {
        List<string> contenidosProhibidos = new List<string>
            {
                "explosivos", "gases comprimidos", "líquidos inflamables", "sustancias tóxicas",
                "vidrio", "drogas", "armas", "animales vivos","sustancia corrosiva", "sustancia química peligrosa"
            };


        List<Paquete> paquetes = new List<Paquete>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var contenido in contenidosProhibidos)
            {
                excluido.Items.Add(contenido);

            }

        }

        private void btnAgregarPaquete_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textdesti.Text))
            {
                MessageBox.Show("Por favor, rellena el campo de destinatario.");
                return; 
            }

            if (string.IsNullOrWhiteSpace(textRemitente.Text))
            {
                MessageBox.Show("Por favor, rellena el campo de remitente.");
                return; 
            }

            string contenidoIngresado = textContenido.Text.Trim().ToLower();

            foreach (var prohibido in contenidosProhibidos)
            {
                if (contenidoIngresado.Contains(prohibido))
                {
                    MessageBox.Show("No puedes enviar este paquete con ese contenido.");
                    return; // Detener la ejecución si el contenido está prohibido
                }
            }


            Paquete paquete = new Paquete()
            {
                Destinatario = textdesti.Text,
                Remitente = textRemitente.Text,
                Direccion = textDirec.Text,
                Contenido = textContenido.Text,

            };
            paquetes.Add(paquete);

            Random random = new Random();
            DateTime fechaLlegada = DateTime.Now.AddDays(random.Next(7, 31));

            dataGridView1.Rows.Add(paquete.Destinatario,"listo",fechaLlegada.ToString("dd/MM/yyyy"), paquete.Contenido);

            textdesti.Clear();
            textRemitente.Clear();
            textDirec.Clear();
            textContenido.Clear();
            MessageBox.Show("Paquete agregado correctamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChatBoxForm chatBox = new ChatBoxForm();
            chatBox.Show();
        }
    }
}
