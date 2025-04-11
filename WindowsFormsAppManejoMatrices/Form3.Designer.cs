namespace WindowsFormsAppManejoMatrices
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiagprin1 = new System.Windows.Forms.TextBox();
            this.txtdiagoinver = new System.Windows.Forms.TextBox();
            this.txtdiagprinc = new System.Windows.Forms.TextBox();
            this.txtdiaginver1 = new System.Windows.Forms.TextBox();
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.btnsuminvert = new System.Windows.Forms.Button();
            this.dtgmatrorin = new System.Windows.Forms.DataGridView();
            this.dtgmatrinver = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmatrorin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmatrinver)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matriz Original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(19, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diagonal Invertida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(392, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diagonal Invertida:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(393, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diagonal Principal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(392, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Matriz Invertida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(19, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Diagonal Principal:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtdiagprin1
            // 
            this.txtdiagprin1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagprin1.Location = new System.Drawing.Point(24, 378);
            this.txtdiagprin1.Name = "txtdiagprin1";
            this.txtdiagprin1.Size = new System.Drawing.Size(100, 27);
            this.txtdiagprin1.TabIndex = 8;
            this.txtdiagprin1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdiagoinver
            // 
            this.txtdiagoinver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagoinver.Location = new System.Drawing.Point(398, 465);
            this.txtdiagoinver.Name = "txtdiagoinver";
            this.txtdiagoinver.Size = new System.Drawing.Size(98, 27);
            this.txtdiagoinver.TabIndex = 9;
            // 
            // txtdiagprinc
            // 
            this.txtdiagprinc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagprinc.Location = new System.Drawing.Point(398, 386);
            this.txtdiagprinc.Name = "txtdiagprinc";
            this.txtdiagprinc.Size = new System.Drawing.Size(98, 27);
            this.txtdiagprinc.TabIndex = 11;
            // 
            // txtdiaginver1
            // 
            this.txtdiaginver1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiaginver1.Location = new System.Drawing.Point(24, 465);
            this.txtdiaginver1.Name = "txtdiaginver1";
            this.txtdiaginver1.Size = new System.Drawing.Size(100, 27);
            this.txtdiaginver1.TabIndex = 13;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnregresar.FlatAppearance.BorderSize = 0;
            this.btnregresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnregresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnregresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.Color.Transparent;
            this.btnregresar.Image = global::WindowsFormsAppManejoMatrices.Properties.Resources.icons8_back_arrow_64__1_;
            this.btnregresar.Location = new System.Drawing.Point(25, 509);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(78, 56);
            this.btnregresar.TabIndex = 14;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // btnGit
            // 
            this.btnGit.BackColor = System.Drawing.Color.Transparent;
            this.btnGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGit.FlatAppearance.BorderSize = 0;
            this.btnGit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGit.Image = global::WindowsFormsAppManejoMatrices.Properties.Resources.icons8_github_50__2_;
            this.btnGit.Location = new System.Drawing.Point(624, 504);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(70, 61);
            this.btnGit.TabIndex = 15;
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnsuminvert
            // 
            this.btnsuminvert.BackColor = System.Drawing.Color.Transparent;
            this.btnsuminvert.FlatAppearance.BorderSize = 0;
            this.btnsuminvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuminvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuminvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuminvert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuminvert.Image = global::WindowsFormsAppManejoMatrices.Properties.Resources.icons8_plus_50__1_;
            this.btnsuminvert.Location = new System.Drawing.Point(319, 167);
            this.btnsuminvert.Name = "btnsuminvert";
            this.btnsuminvert.Size = new System.Drawing.Size(72, 66);
            this.btnsuminvert.TabIndex = 17;
            this.btnsuminvert.UseVisualStyleBackColor = false;
            this.btnsuminvert.Click += new System.EventHandler(this.btnsuminvert_Click);
            // 
            // dtgmatrorin
            // 
            this.dtgmatrorin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgmatrorin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmatrorin.Location = new System.Drawing.Point(24, 98);
            this.dtgmatrorin.Name = "dtgmatrorin";
            this.dtgmatrorin.RowHeadersWidth = 51;
            this.dtgmatrorin.RowTemplate.Height = 24;
            this.dtgmatrorin.Size = new System.Drawing.Size(290, 205);
            this.dtgmatrorin.TabIndex = 18;
            this.dtgmatrorin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgmatrorin_CellContentClick);
            // 
            // dtgmatrinver
            // 
            this.dtgmatrinver.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgmatrinver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmatrinver.Location = new System.Drawing.Point(397, 98);
            this.dtgmatrinver.Name = "dtgmatrinver";
            this.dtgmatrinver.RowHeadersWidth = 51;
            this.dtgmatrinver.RowTemplate.Height = 24;
            this.dtgmatrinver.Size = new System.Drawing.Size(297, 205);
            this.dtgmatrinver.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(239, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Simetrico:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 521);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 30);
            this.textBox1.TabIndex = 23;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppManejoMatrices.Properties.Resources.descarga__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgmatrinver);
            this.Controls.Add(this.dtgmatrorin);
            this.Controls.Add(this.btnsuminvert);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.txtdiaginver1);
            this.Controls.Add(this.txtdiagprinc);
            this.Controls.Add(this.txtdiagoinver);
            this.Controls.Add(this.txtdiagprin1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Matriz Invertida";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgmatrorin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmatrinver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiagprin1;
        private System.Windows.Forms.TextBox txtdiagoinver;
        private System.Windows.Forms.TextBox txtdiagprinc;
        private System.Windows.Forms.TextBox txtdiaginver1;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Button btnsuminvert;
        private System.Windows.Forms.DataGridView dtgmatrorin;
        private System.Windows.Forms.DataGridView dtgmatrinver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}