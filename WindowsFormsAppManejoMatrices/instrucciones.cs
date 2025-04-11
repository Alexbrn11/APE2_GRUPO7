using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppManejoMatrices
{
    public partial class instrucciones : Form
    {
        public instrucciones()
        {
            InitializeComponent();
        }
        private void ConfigurarInstrucciones()
        {
            // Título y texto de instrucciones (ya lo tienes)
            Label lblTitulo = new Label();
            lblTitulo.Text = "Guía de Uso del Programa";
            lblTitulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(20, 20);
            this.Controls.Add(lblTitulo);

            Label lblTexto = new Label();
            lblTexto.Text =
                "🖥️ Ventana Principal\n" +
                "1. Define filas y columnas.\n" +
                "2. Ingresa los valores.\n" +
                "3. Botones:\n" +
                "   • Limpiar: Reinicia la matriz.\n" +
                "   • Matriz invertida: Muestra la transpuesta.\n\n" +
                "📄 Ventana Secundaria\n" +
                "1. Muestra la matriz original y transpuesta.\n" +
                "2. Suma: Diagonales principal e invertida.\n" +
                "3. Extras:\n" +
                "   • Regresar: Vuelve atrás.\n" +
                "   • GitHub: Abre el código fuente.";
            lblTexto.Font = new Font("Segoe UI", 10);
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(20, 60);
            this.Controls.Add(lblTexto);

            // Botón "Cerrar"
            Button btnCerrar = new Button();
            btnCerrar.Text = "Cerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.Location = new Point(200, 400);  // Colocamos el botón un poco más abajo
            btnCerrar.Click += new EventHandler(btnCerrar_Click); // Asignamos el evento Click
            this.Controls.Add(btnCerrar);

            // Ajustamos el tamaño de la ventana para que sea lo suficientemente grande
            this.Text = "Instrucciones";
            this.Size = new Size(500, 500);  // Ventana más grande
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        // Evento para cerrar la ventana de instrucciones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instrucciones_Load(object sender, EventArgs e)
        {
            ConfigurarInstrucciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ir = new Form1();
            ir.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
