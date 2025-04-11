namespace WindowsFormsAppManejoMatrices
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.btnmatrinverti = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btninstruccin = new System.Windows.Forms.Button();
            this.dtgmatrgene = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.btnPortada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmatrgene)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el número de filas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matriz";
            // 
            // txtFilas
            // 
            this.txtFilas.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilas.Location = new System.Drawing.Point(346, 123);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(100, 27);
            this.txtFilas.TabIndex = 5;
            // 
            // btnmatrinverti
            // 
            this.btnmatrinverti.BackColor = System.Drawing.Color.DarkGray;
            this.btnmatrinverti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatrinverti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmatrinverti.Location = new System.Drawing.Point(350, 321);
            this.btnmatrinverti.Name = "btnmatrinverti";
            this.btnmatrinverti.Size = new System.Drawing.Size(96, 72);
            this.btnmatrinverti.TabIndex = 6;
            this.btnmatrinverti.Text = "Matriz Invertida";
            this.btnmatrinverti.UseVisualStyleBackColor = false;
            this.btnmatrinverti.Click += new System.EventHandler(this.btnmatrinverti_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.Image = global::WindowsFormsAppManejoMatrices.Properties.Resources.icons8_clear_50;
            this.btnlimpiar.Location = new System.Drawing.Point(686, 214);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(77, 68);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Manejo de Matrices";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btninstruccin
            // 
            this.btninstruccin.BackColor = System.Drawing.Color.Transparent;
            this.btninstruccin.BackgroundImage = global::WindowsFormsAppManejoMatrices.Properties.Resources.icons8_help_50;
            this.btninstruccin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btninstruccin.FlatAppearance.BorderSize = 0;
            this.btninstruccin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btninstruccin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btninstruccin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninstruccin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstruccin.ForeColor = System.Drawing.Color.Transparent;
            this.btninstruccin.Location = new System.Drawing.Point(694, 125);
            this.btninstruccin.Name = "btninstruccin";
            this.btninstruccin.Size = new System.Drawing.Size(69, 64);
            this.btninstruccin.TabIndex = 9;
            this.btninstruccin.UseVisualStyleBackColor = false;
            this.btninstruccin.Click += new System.EventHandler(this.btninstruccin_Click);
            // 
            // dtgmatrgene
            // 
            this.dtgmatrgene.AllowUserToAddRows = false;
            this.dtgmatrgene.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgmatrgene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmatrgene.Location = new System.Drawing.Point(31, 288);
            this.dtgmatrgene.Name = "dtgmatrgene";
            this.dtgmatrgene.RowHeadersWidth = 51;
            this.dtgmatrgene.RowTemplate.Height = 24;
            this.dtgmatrgene.Size = new System.Drawing.Size(303, 224);
            this.dtgmatrgene.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(11, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese el número de columnas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtColumnas
            // 
            this.txtColumnas.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.Location = new System.Drawing.Point(346, 162);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(100, 27);
            this.txtColumnas.TabIndex = 15;
            // 
            // btnPortada
            // 
            this.btnPortada.BackColor = System.Drawing.Color.Transparent;
            this.btnPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPortada.FlatAppearance.BorderSize = 0;
            this.btnPortada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPortada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortada.Image = global::WindowsFormsAppManejoMatrices.Properties.Resources.icons8_home_50;
            this.btnPortada.Location = new System.Drawing.Point(686, 302);
            this.btnPortada.Name = "btnPortada";
            this.btnPortada.Size = new System.Drawing.Size(75, 54);
            this.btnPortada.TabIndex = 16;
            this.btnPortada.UseVisualStyleBackColor = false;
            this.btnPortada.Click += new System.EventHandler(this.btnPortada_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppManejoMatrices.Properties.Resources._20_Breathtaking_Landscape_Photos_From_The_2024_ReFocus_Awards;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 548);
            this.Controls.Add(this.btnPortada);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgmatrgene);
            this.Controls.Add(this.btninstruccin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmatrinverti);
            this.Controls.Add(this.txtFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgmatrgene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Button btnmatrinverti;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninstruccin;
        private System.Windows.Forms.DataGridView dtgmatrgene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Button btnPortada;
    }
}

