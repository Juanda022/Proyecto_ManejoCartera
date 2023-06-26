namespace NEGOCIO_PRESENTACION
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.Grilla_Cliente = new System.Windows.Forms.DataGridView();
            this.txt_Telefono_Cliente = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_Telefono_Cli = new System.Windows.Forms.Label();
            this.lbl_Codigo_Cli = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Nombre_Cli = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_Identificacion_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_Identificacion_Cli = new System.Windows.Forms.Label();
            this.txt_Direccion_Cliente = new System.Windows.Forms.TextBox();
            this.lbl_Direccion_Cli = new System.Windows.Forms.Label();
            this.lbl_Genero_Cli = new System.Windows.Forms.Label();
            this.txt_Codigo_Empleado_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbm_Genero_Clien = new System.Windows.Forms.ComboBox();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Cliente
            // 
            this.Grilla_Cliente.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Cliente.Location = new System.Drawing.Point(0, 345);
            this.Grilla_Cliente.Name = "Grilla_Cliente";
            this.Grilla_Cliente.Size = new System.Drawing.Size(750, 92);
            this.Grilla_Cliente.TabIndex = 54;
            // 
            // txt_Telefono_Cliente
            // 
            this.txt_Telefono_Cliente.Location = new System.Drawing.Point(280, 199);
            this.txt_Telefono_Cliente.Name = "txt_Telefono_Cliente";
            this.txt_Telefono_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Telefono_Cliente.TabIndex = 52;
            this.txt_Telefono_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_Cliente_KeyPress);
            // 
            // txt_Nombre_Cliente
            // 
            this.txt_Nombre_Cliente.Location = new System.Drawing.Point(280, 137);
            this.txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            this.txt_Nombre_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Nombre_Cliente.TabIndex = 50;
            this.txt_Nombre_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Cliente_KeyPress);
            // 
            // txt_Codigo_Cliente
            // 
            this.txt_Codigo_Cliente.Location = new System.Drawing.Point(280, 69);
            this.txt_Codigo_Cliente.Name = "txt_Codigo_Cliente";
            this.txt_Codigo_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_Cliente.TabIndex = 49;
            this.txt_Codigo_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_Cliente_KeyPress);
            // 
            // lbl_Telefono_Cli
            // 
            this.lbl_Telefono_Cli.AutoSize = true;
            this.lbl_Telefono_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono_Cli.ForeColor = System.Drawing.Color.Black;
            this.lbl_Telefono_Cli.Location = new System.Drawing.Point(106, 198);
            this.lbl_Telefono_Cli.Name = "lbl_Telefono_Cli";
            this.lbl_Telefono_Cli.Size = new System.Drawing.Size(74, 18);
            this.lbl_Telefono_Cli.TabIndex = 46;
            this.lbl_Telefono_Cli.Text = "Telefono";
            // 
            // lbl_Codigo_Cli
            // 
            this.lbl_Codigo_Cli.AutoSize = true;
            this.lbl_Codigo_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Cli.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_Cli.Location = new System.Drawing.Point(106, 69);
            this.lbl_Codigo_Cli.Name = "lbl_Codigo_Cli";
            this.lbl_Codigo_Cli.Size = new System.Drawing.Size(62, 18);
            this.lbl_Codigo_Cli.TabIndex = 43;
            this.lbl_Codigo_Cli.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(604, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 327);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(26, 245);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(95, 46);
            this.btn_Eliminar.TabIndex = 26;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.ForeColor = System.Drawing.Color.Black;
            this.btn_Modificar.Location = new System.Drawing.Point(26, 186);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(95, 46);
            this.btn_Modificar.TabIndex = 25;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Consulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consulta.ForeColor = System.Drawing.Color.Black;
            this.btn_Consulta.Location = new System.Drawing.Point(26, 127);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(95, 46);
            this.btn_Consulta.TabIndex = 24;
            this.btn_Consulta.Text = "Consulta";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo.Location = new System.Drawing.Point(26, 70);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 46);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 45);
            this.panel2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Cliente";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(708, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Nombre_Cli
            // 
            this.lbl_Nombre_Cli.AutoSize = true;
            this.lbl_Nombre_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Cli.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre_Cli.Location = new System.Drawing.Point(106, 139);
            this.lbl_Nombre_Cli.Name = "lbl_Nombre_Cli";
            this.lbl_Nombre_Cli.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombre_Cli.TabIndex = 44;
            this.lbl_Nombre_Cli.Text = "Nombre";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 52);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // txt_Identificacion_Cliente
            // 
            this.txt_Identificacion_Cliente.Location = new System.Drawing.Point(280, 102);
            this.txt_Identificacion_Cliente.Name = "txt_Identificacion_Cliente";
            this.txt_Identificacion_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Identificacion_Cliente.TabIndex = 58;
            this.txt_Identificacion_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Identificacion_Cliente_KeyPress);
            // 
            // lbl_Identificacion_Cli
            // 
            this.lbl_Identificacion_Cli.AutoSize = true;
            this.lbl_Identificacion_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identificacion_Cli.ForeColor = System.Drawing.Color.Black;
            this.lbl_Identificacion_Cli.Location = new System.Drawing.Point(106, 102);
            this.lbl_Identificacion_Cli.Name = "lbl_Identificacion_Cli";
            this.lbl_Identificacion_Cli.Size = new System.Drawing.Size(107, 18);
            this.lbl_Identificacion_Cli.TabIndex = 57;
            this.lbl_Identificacion_Cli.Text = "Identificacion";
            // 
            // txt_Direccion_Cliente
            // 
            this.txt_Direccion_Cliente.Location = new System.Drawing.Point(280, 171);
            this.txt_Direccion_Cliente.Name = "txt_Direccion_Cliente";
            this.txt_Direccion_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Direccion_Cliente.TabIndex = 60;
            this.txt_Direccion_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Direccion_Cliente_KeyPress);
            // 
            // lbl_Direccion_Cli
            // 
            this.lbl_Direccion_Cli.AutoSize = true;
            this.lbl_Direccion_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion_Cli.ForeColor = System.Drawing.Color.Black;
            this.lbl_Direccion_Cli.Location = new System.Drawing.Point(106, 173);
            this.lbl_Direccion_Cli.Name = "lbl_Direccion_Cli";
            this.lbl_Direccion_Cli.Size = new System.Drawing.Size(80, 18);
            this.lbl_Direccion_Cli.TabIndex = 59;
            this.lbl_Direccion_Cli.Text = "Direccion";
            // 
            // lbl_Genero_Cli
            // 
            this.lbl_Genero_Cli.AutoSize = true;
            this.lbl_Genero_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero_Cli.ForeColor = System.Drawing.Color.Black;
            this.lbl_Genero_Cli.Location = new System.Drawing.Point(106, 230);
            this.lbl_Genero_Cli.Name = "lbl_Genero_Cli";
            this.lbl_Genero_Cli.Size = new System.Drawing.Size(64, 18);
            this.lbl_Genero_Cli.TabIndex = 63;
            this.lbl_Genero_Cli.Text = "Genero";
            // 
            // txt_Codigo_Empleado_Cliente
            // 
            this.txt_Codigo_Empleado_Cliente.Location = new System.Drawing.Point(280, 258);
            this.txt_Codigo_Empleado_Cliente.Name = "txt_Codigo_Empleado_Cliente";
            this.txt_Codigo_Empleado_Cliente.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_Empleado_Cliente.TabIndex = 62;
            this.txt_Codigo_Empleado_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_Empleado_Cliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Empleado";
            // 
            // cbm_Genero_Clien
            // 
            this.cbm_Genero_Clien.FormattingEnabled = true;
            this.cbm_Genero_Clien.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Indefinido"});
            this.cbm_Genero_Clien.Location = new System.Drawing.Point(280, 231);
            this.cbm_Genero_Clien.Name = "cbm_Genero_Clien";
            this.cbm_Genero_Clien.Size = new System.Drawing.Size(129, 21);
            this.cbm_Genero_Clien.TabIndex = 64;
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_Cliente.Location = new System.Drawing.Point(276, 284);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(133, 21);
            this.cmb_Cliente.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 94;
            this.label3.Text = "Estado";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(752, 437);
            this.Controls.Add(this.cmb_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbm_Genero_Clien);
            this.Controls.Add(this.lbl_Genero_Cli);
            this.Controls.Add(this.txt_Codigo_Empleado_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Direccion_Cliente);
            this.Controls.Add(this.lbl_Direccion_Cli);
            this.Controls.Add(this.txt_Identificacion_Cliente);
            this.Controls.Add(this.lbl_Identificacion_Cli);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Grilla_Cliente);
            this.Controls.Add(this.txt_Telefono_Cliente);
            this.Controls.Add(this.txt_Nombre_Cliente);
            this.Controls.Add(this.txt_Codigo_Cliente);
            this.Controls.Add(this.lbl_Telefono_Cli);
            this.Controls.Add(this.lbl_Nombre_Cli);
            this.Controls.Add(this.lbl_Codigo_Cli);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Cliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla_Cliente;
        private System.Windows.Forms.TextBox txt_Telefono_Cliente;
        private System.Windows.Forms.TextBox txt_Nombre_Cliente;
        private System.Windows.Forms.TextBox txt_Codigo_Cliente;
        private System.Windows.Forms.Label lbl_Telefono_Cli;
        private System.Windows.Forms.Label lbl_Codigo_Cli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Nombre_Cli;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_Identificacion_Cliente;
        private System.Windows.Forms.Label lbl_Identificacion_Cli;
        private System.Windows.Forms.TextBox txt_Direccion_Cliente;
        private System.Windows.Forms.Label lbl_Direccion_Cli;
        private System.Windows.Forms.Label lbl_Genero_Cli;
        private System.Windows.Forms.TextBox txt_Codigo_Empleado_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbm_Genero_Clien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label label3;
    }
}