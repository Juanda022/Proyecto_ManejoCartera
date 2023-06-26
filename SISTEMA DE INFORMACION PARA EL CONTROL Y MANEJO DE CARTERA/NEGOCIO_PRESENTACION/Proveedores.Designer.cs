namespace NEGOCIO_PRESENTACION
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.txt_Telefono_Proveedores = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Proveedores = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Proveedores = new System.Windows.Forms.TextBox();
            this.lbl_TelefonoM = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_Direccion_Proveedores = new System.Windows.Forms.TextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Razon_Proveedores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_EstadoProve = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grilla_Proveedores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(543, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 325);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_Eliminar.Location = new System.Drawing.Point(26, 257);
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
            this.btn_Consulta.Location = new System.Drawing.Point(26, 124);
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
            this.btn_Nuevo.Location = new System.Drawing.Point(26, 58);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 46);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click_1);
            // 
            // txt_Telefono_Proveedores
            // 
            this.txt_Telefono_Proveedores.Location = new System.Drawing.Point(287, 192);
            this.txt_Telefono_Proveedores.Name = "txt_Telefono_Proveedores";
            this.txt_Telefono_Proveedores.Size = new System.Drawing.Size(230, 20);
            this.txt_Telefono_Proveedores.TabIndex = 38;
            this.txt_Telefono_Proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_Proveedores_KeyPress);
            // 
            // txt_Nombre_Proveedores
            // 
            this.txt_Nombre_Proveedores.Location = new System.Drawing.Point(287, 222);
            this.txt_Nombre_Proveedores.Name = "txt_Nombre_Proveedores";
            this.txt_Nombre_Proveedores.Size = new System.Drawing.Size(230, 20);
            this.txt_Nombre_Proveedores.TabIndex = 36;
            this.txt_Nombre_Proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_Proveedores_KeyPress);
            // 
            // txt_Codigo_Proveedores
            // 
            this.txt_Codigo_Proveedores.Location = new System.Drawing.Point(287, 120);
            this.txt_Codigo_Proveedores.Name = "txt_Codigo_Proveedores";
            this.txt_Codigo_Proveedores.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_Proveedores.TabIndex = 35;
            this.txt_Codigo_Proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_Proveedores_KeyPress);
            // 
            // lbl_TelefonoM
            // 
            this.lbl_TelefonoM.AutoSize = true;
            this.lbl_TelefonoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefonoM.ForeColor = System.Drawing.Color.Black;
            this.lbl_TelefonoM.Location = new System.Drawing.Point(113, 194);
            this.lbl_TelefonoM.Name = "lbl_TelefonoM";
            this.lbl_TelefonoM.Size = new System.Drawing.Size(74, 18);
            this.lbl_TelefonoM.TabIndex = 27;
            this.lbl_TelefonoM.Text = "Telefono";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre.Location = new System.Drawing.Point(116, 222);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombre.TabIndex = 25;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(113, 122);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(62, 18);
            this.lbl_codigo.TabIndex = 24;
            this.lbl_codigo.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 40);
            this.panel2.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 105;
            this.label5.Text = "Proveedores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(607, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // txt_Direccion_Proveedores
            // 
            this.txt_Direccion_Proveedores.Location = new System.Drawing.Point(287, 157);
            this.txt_Direccion_Proveedores.Name = "txt_Direccion_Proveedores";
            this.txt_Direccion_Proveedores.Size = new System.Drawing.Size(230, 20);
            this.txt_Direccion_Proveedores.TabIndex = 37;
            this.txt_Direccion_Proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Direccion_Proveedores_KeyPress);
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.ForeColor = System.Drawing.Color.Black;
            this.lbl_Direccion.Location = new System.Drawing.Point(113, 159);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(80, 18);
            this.lbl_Direccion.TabIndex = 26;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // txt_Razon_Proveedores
            // 
            this.txt_Razon_Proveedores.Location = new System.Drawing.Point(287, 257);
            this.txt_Razon_Proveedores.Name = "txt_Razon_Proveedores";
            this.txt_Razon_Proveedores.Size = new System.Drawing.Size(230, 20);
            this.txt_Razon_Proveedores.TabIndex = 43;
            this.txt_Razon_Proveedores.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Razon_Proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Razon_Proveedores_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Razon";
            // 
            // cmb_EstadoProve
            // 
            this.cmb_EstadoProve.FormattingEnabled = true;
            this.cmb_EstadoProve.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_EstadoProve.Location = new System.Drawing.Point(287, 284);
            this.cmb_EstadoProve.Name = "cmb_EstadoProve";
            this.cmb_EstadoProve.Size = new System.Drawing.Size(230, 21);
            this.cmb_EstadoProve.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Estado";
            // 
            // Grilla_Proveedores
            // 
            this.Grilla_Proveedores.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Proveedores.Location = new System.Drawing.Point(116, 331);
            this.Grilla_Proveedores.Name = "Grilla_Proveedores";
            this.Grilla_Proveedores.Size = new System.Drawing.Size(390, 88);
            this.Grilla_Proveedores.TabIndex = 96;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(680, 459);
            this.Controls.Add(this.Grilla_Proveedores);
            this.Controls.Add(this.cmb_EstadoProve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Razon_Proveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Telefono_Proveedores);
            this.Controls.Add(this.txt_Direccion_Proveedores);
            this.Controls.Add(this.txt_Nombre_Proveedores);
            this.Controls.Add(this.txt_Codigo_Proveedores);
            this.Controls.Add(this.lbl_TelefonoM);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TextBox txt_Telefono_Proveedores;
        private System.Windows.Forms.TextBox txt_Nombre_Proveedores;
        private System.Windows.Forms.TextBox txt_Codigo_Proveedores;
        private System.Windows.Forms.Label lbl_TelefonoM;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_Direccion_Proveedores;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Razon_Proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_EstadoProve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grilla_Proveedores;
    }
}