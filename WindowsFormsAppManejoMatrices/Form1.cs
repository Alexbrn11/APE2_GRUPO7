using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppManejoMatrices
{
    public partial class Form1 : Form
    {
        private double[,] matriz;

        public Form1()
        {
            InitializeComponent();
            // Limpieza inicial
            txtFilas.Clear();
            txtColumnas.Clear();
            dtgmatrgene.Rows.Clear();
            dtgmatrgene.Columns.Clear();

            // --- Estilo visual mejorado del DataGridView ---
            dtgmatrgene.BorderStyle = BorderStyle.None;
            dtgmatrgene.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtgmatrgene.GridColor = Color.Gray;

            dtgmatrgene.RowHeadersVisible = false;
            dtgmatrgene.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgmatrgene.EnableHeadersVisualStyles = false;
            dtgmatrgene.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dtgmatrgene.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dtgmatrgene.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgmatrgene.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgmatrgene.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dtgmatrgene.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Evento para generar matriz al presionar Enter en txtColumnas
            txtColumnas.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    GenerarMatriz();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };
        }

        private void GenerarMatriz()
        {
            try
            {
                int filas = int.Parse(txtFilas.Text);
                int columnas = int.Parse(txtColumnas.Text);

                if (filas <= 0 || columnas <= 0)
                {
                    MessageBox.Show("Ingrese números mayores que 0.");
                    return;
                }

                matriz = new double[filas, columnas];
                dtgmatrgene.RowCount = filas;
                dtgmatrgene.ColumnCount = columnas;

                for (int i = 0; i < columnas; i++)
                {
                    dtgmatrgene.Columns[i].Name = "Col " + (i + 1);
                    dtgmatrgene.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese números válidos.");
            }
        }

        private void btngenermatri_Click_1(object sender, EventArgs e)
        {
            GenerarMatriz();
        }

        private void btngenermatri_Click(object sender, EventArgs e)
        {
            GenerarMatriz();
        }

        private double[,] InvertirMatriz(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            double[,] resultado = new double[n, n];
            double[,] identidad = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultado[i, j] = matriz[i, j];
                    identidad[i, j] = (i == j) ? 1.0 : 0.0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                double pivote = resultado[i, i];
                if (pivote == 0)
                {
                    return null;
                }

                for (int j = 0; j < n; j++)
                {
                    resultado[i, j] /= pivote;
                    identidad[i, j] /= pivote;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = resultado[k, i];
                        for (int j = 0; j < n; j++)
                        {
                            resultado[k, j] -= factor * resultado[i, j];
                            identidad[k, j] -= factor * identidad[i, j];
                        }
                    }
                }
            }

            return identidad;
        }

        private void btnmatrinverti_Click(object sender, EventArgs e)
        {
            var matrizOriginal = ObtenerMatrizDelGrid();
            if (matrizOriginal == null) return;

            var matrizInvertida = InvertirMatriz(matrizOriginal);
            if (matrizInvertida == null)
            {
                MessageBox.Show("La matriz no es invertible.");
                return;
            }

            this.Hide();
            Form3 formInversa = new Form3(matrizOriginal, matrizInvertida);
            formInversa.Show();
        }

        private double[,] ObtenerMatrizDelGrid()
        {
            int filas = dtgmatrgene.RowCount;
            int columnas = dtgmatrgene.ColumnCount;
            double[,] matriz = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (double.TryParse(dtgmatrgene[j, i].Value?.ToString(), out double valor))
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        MessageBox.Show($"Valor inválido en ({i + 1},{j + 1})");
                        return null;
                    }
                }
            }

            return matriz;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtFilas.Clear();
            txtColumnas.Clear();
            dtgmatrgene.Columns.Clear();
            dtgmatrgene.Rows.Clear();
        }

        private void btninstruccin_Click(object sender, EventArgs e)
        {
            instrucciones ventanaInstrucciones = new instrucciones();
            ventanaInstrucciones.ShowDialog();
        }

        private void btnPortada_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 portada = new Form4();
            portada.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPortada_Click_1(object sender, EventArgs e)
        {
            Form4 portada = new Form4(); // Crear instancia de Form4
            portada.Show();              // Mostrar la ventana de portada
            this.Hide();                 // Ocultar la ventana actual (opcional)
        }
    }
}
