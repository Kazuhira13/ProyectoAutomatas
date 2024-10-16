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
    public partial class ChatBoxForm : Form
    {
        public ChatBoxForm()
        {
            InitializeComponent();
        }

        private void ChatBoxForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensajeUsuario = textBoxInput.Text;

            if (string.IsNullOrEmpty(mensajeUsuario))
            {
                MessageBox.Show("Por favor, escribe un mensaje.");
                return;
            }

            richTextBoxChat.AppendText("Usuario: " + mensajeUsuario + "\n");

            textBoxInput.Clear();

            string respuesta = ObtenerRespuestaAutomatica(mensajeUsuario);
            richTextBoxChat.AppendText("ChatBot: " + respuesta + "\n");

        }

        private string ObtenerRespuestaAutomatica(string mensajeUsuario) 
        {
            mensajeUsuario = mensajeUsuario.ToLower();
            if (mensajeUsuario.Contains("hola"))
            {
                return "¡Hola! ¿En qué puedo ayudarte hoy?";
            }
            else if (mensajeUsuario.Contains("paquete"))
            {
                return "¿Estás consultando sobre un envío de paquetes?";
            }
            else if (mensajeUsuario.Contains("horario") || mensajeUsuario.Contains("horarios") || mensajeUsuario.Contains("atención"))
            {
                return "Los horarios de atención de la paquetería son de Lunes a Viernes, de 9:00 AM a 6:00 PM.";
            }
            else if (mensajeUsuario.Contains("costo") || mensajeUsuario.Contains("precio") || mensajeUsuario.Contains("cuesta"))
            {
                return "El costo de envío depende del peso y la distancia. Por favor, consulta nuestras tarifas o proporciona más detalles del paquete.";
            }
            else if (mensajeUsuario.Contains("rastrear") || mensajeUsuario.Contains("seguimiento") || mensajeUsuario.Contains("ubicación"))
            {
                return "Para rastrear tu paquete, por favor ingresa el número de seguimiento en nuestra página web o aplicación.";
            }
            else if (mensajeUsuario.Contains("tarda") || mensajeUsuario.Contains("llegar") || mensajeUsuario.Contains("entrega"))
            {
                return "El tiempo de entrega varía según la distancia. Envíos nacionales suelen tardar de 3 a 5 días hábiles.";
            }
            else if (mensajeUsuario.Contains("cancelar") || mensajeUsuario.Contains("anular"))
            {
                return "Puedes cancelar un envío siempre y cuando no haya sido procesado. Contáctanos lo antes posible para más detalles.";
            }
            else if (mensajeUsuario.Contains("no puedo enviar") || mensajeUsuario.Contains("prohibido") || mensajeUsuario.Contains("restricciones"))
            {
                return "No puedes enviar sustancias peligrosas, explosivos, productos inflamables, drogas ilegales, armas, y animales vivos. Consulta nuestra lista completa en la página web.";
            }
            else if (mensajeUsuario.Contains("ubicación") || mensajeUsuario.Contains("dónde están") || mensajeUsuario.Contains("dirección"))
            {
                return "Nuestra oficina principal está ubicada en [dirección]. También tenemos sucursales en diferentes ciudades.";
            }
            else if (mensajeUsuario.Contains("devoluciones") || mensajeUsuario.Contains("devolver") || mensajeUsuario.Contains("reembolso"))
            {
                return "Aceptamos devoluciones si el paquete no ha sido entregado. Contáctanos para más información sobre cómo procesar una devolución.";
            }
            else if (mensajeUsuario.Contains("seguro") || mensajeUsuario.Contains("asegurar") || mensajeUsuario.Contains("protección"))
            {
                return "Sí, ofrecemos seguro opcional para proteger tu paquete en caso de pérdida o daños. El costo depende del valor del paquete.";
            }
            else if (mensajeUsuario.Contains("métodos de pago") || mensajeUsuario.Contains("formas de pago") || mensajeUsuario.Contains("pago"))
            {
                return "Aceptamos tarjetas de crédito, PayPal, transferencias bancarias y pagos en efectivo en nuestras sucursales.";
            }
            else if (mensajeUsuario.Contains("adios"))
            {
                return "¡Adiós! ¡Espero que vuelvas pronto!";
            }
            else if (mensajeUsuario.Contains("qué te puedo preguntar") || mensajeUsuario.Contains("puedo preguntar") || mensajeUsuario.Contains("ayuda"))
            {
                return "Puedes preguntarme sobre lo siguiente:\n" +
               "1. Horarios de atención.\n" +
               "2. Costo de envío.\n" +
               "3. Cómo rastrear un paquete.\n" +
               "4. Tiempo estimado de entrega.\n" +
               "5. Cancelación de envíos.\n" +
               "6. Contenidos prohibidos para el envío.\n" +
               "7. Ubicación de nuestras oficinas.\n" +
               "8. Política de devoluciones.\n" +
               "9. Seguro para paquetes.\n" +
               "10. Métodos de pago aceptados.";
            }
            else
            {
                return "Lo siento, no entiendo tu pregunta.";
            }
        }
    }
}
