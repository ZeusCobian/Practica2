namespace MySQLconexion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnconectar = new Button();
            txtUsuario = new TextBox();
            txtcontrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtbasededatos = new TextBox();
            txthost = new TextBox();
            label5 = new Label();
            txtpuerto = new TextBox();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnconectar
            // 
            btnconectar.BackColor = Color.Turquoise;
            btnconectar.ImageAlign = ContentAlignment.BottomCenter;
            btnconectar.Location = new Point(284, 303);
            btnconectar.Name = "btnconectar";
            btnconectar.Size = new Size(120, 45);
            btnconectar.TabIndex = 0;
            btnconectar.Text = "Conectar";
            btnconectar.UseVisualStyleBackColor = false;
            btnconectar.Click += btnconectar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.LightSalmon;
            txtUsuario.Location = new Point(218, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(186, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(218, 77);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(186, 27);
            txtcontrasena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(136, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(112, 77);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(93, 181);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 8;
            label3.Text = "Base de datos: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Location = new Point(148, 131);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "Host: ";
            // 
            // txtbasededatos
            // 
            txtbasededatos.Location = new Point(218, 174);
            txtbasededatos.Name = "txtbasededatos";
            txtbasededatos.Size = new Size(186, 27);
            txtbasededatos.TabIndex = 6;
            // 
            // txthost
            // 
            txthost.Location = new Point(218, 128);
            txthost.Name = "txthost";
            txthost.Size = new Size(186, 27);
            txthost.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Location = new Point(136, 234);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 10;
            label5.Text = "Puerto: ";
            // 
            // txtpuerto
            // 
            txtpuerto.BackColor = Color.FromArgb(192, 255, 255);
            txtpuerto.Location = new Point(218, 227);
            txtpuerto.Name = "txtpuerto";
            txtpuerto.Size = new Size(186, 27);
            txtpuerto.TabIndex = 9;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.OliveDrab;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(480, 34);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.Size = new Size(520, 229);
            dgvDatos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 371);
            Controls.Add(dgvDatos);
            Controls.Add(label5);
            Controls.Add(txtpuerto);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtbasededatos);
            Controls.Add(txthost);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcontrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnconectar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Actividad 2";
            Load += btnconectar_Click;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconectar;
        private TextBox txtUsuario;
        private TextBox txtcontrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbasededatos;
        private TextBox txthost;
        private Label label5;
        private TextBox txtpuerto;
        private DataGridView dgvDatos;
    }
}