using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsAppManejoMatrices
{
    public partial class Form3 : Form


    {
        private double[,] matrizInvertida; // Definir un campo para almacenar la matriz invertida
        private double[,] matrizOriginal; // mostramos la matriz original

        public Form3(double[,] matrizOriginal, double[,] matrizInvertida)
        {
            InitializeComponent();
            this.matrizOriginal = matrizOriginal;
            this.matrizInvertida = matrizInvertida;

            MostrarMatrizEnGrid(matrizOriginal, dtgmatrorin);  // Mostrar la matriz original en el DataGridView correspondiente
            MostrarMatrizEnGrid(TransponerMatriz(matrizOriginal), dtgmatrinver); // Mostrar la transpuesta en lugar de la inversa

        }

        // Método para mostrar la matriz invertida en el DataGridView

        private void MostrarMatrizEnGrid(double[,] matriz, DataGridView grid)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            grid.Columns.Clear();
            grid.Rows.Clear();

            // Aplica estilos visuales uniformes
            EstilizarDataGridView(grid);

            // Agregar columnas
            for (int j = 0; j < columnas; j++)
            {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = $"Col {j + 1}";
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grid.Columns.Add(col);
            }

            // Agregar filas
            grid.RowCount = filas;

            // Asignar los valores
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    grid.Rows[i].Cells[j].Value = ((int)matriz[i, j]).ToString();

                }
            }
        }
        private double[,] TransponerMatriz(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[,] transpuesta = new double[columnas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            return transpuesta;
        }

        private void EstilizarDataGridView(DataGridView grid)
        {
            // Bordes y colores
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grid.GridColor = Color.Gray;

            // Encabezados
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Celdas
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Otras configuraciones
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.ReadOnly = true;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para calcular las diagonales de una matriz

        private void CalcularDiagonales(double[,] matriz, bool esOriginal)
        {
            int n = matriz.GetLength(0); // Tamaño de la matriz (asumimos que es cuadrada)

            double diagonalPrincipal = 0;
            double diagonalInvertida = 0;

            for (int i = 0; i < n; i++)
            {
                diagonalPrincipal += matriz[i, i];  // Elementos de la diagonal principal
                diagonalInvertida += matriz[i, n - 1 - i];  // Elementos de la diagonal invertida
            }

            // Mostrar los resultados en las etiquetas correspondientes
            if (esOriginal)
            {
                txtdiagprin1.Text = " " + ((int)diagonalPrincipal).ToString();
                txtdiaginver1.Text = " " + ((int)diagonalInvertida).ToString();
            }
            else
            {
                txtdiagprinc.Text = " " + ((int)diagonalPrincipal).ToString();
                txtdiagoinver.Text = " " + ((int)diagonalInvertida).ToString();
            }
        }
        private bool EsSimetrica(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            if (filas != columnas)
                return false;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                        return false;
                }
            }

            return true;
        }
        private void btnsuminvert_Click(object sender, EventArgs e)
        {
            // Calcular las diagonales para la matriz original
            CalcularDiagonales(matrizOriginal, true);

            // Calcular las diagonales para la matriz invertida
            CalcularDiagonales(TransponerMatriz(matrizOriginal), false);
        }

        private void btnsummatorig_Click(object sender, EventArgs e)
        {
            // Calcular las diagonales para la matriz original
            CalcularDiagonales(matrizOriginal, true);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Alexbrn11/APE2_GRUPO7",
                UseShellExecute = true
            });
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 nuevoForm1 = new Form1(); // Crea una nueva instancia limpia de Form1
            nuevoForm1.Show();              // Muestra Form1
            this.Close();                   // Cierra Form3
        }

        private void dtgmatrorin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bool simetrica = EsSimetrica(matrizOriginal);
            textBox1.Text = simetrica ? "Sí" : "No";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
