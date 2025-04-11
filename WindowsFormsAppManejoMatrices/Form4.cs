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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();     // Mostrar el formulario principal
            this.Hide();     // Ocultar la portad
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
