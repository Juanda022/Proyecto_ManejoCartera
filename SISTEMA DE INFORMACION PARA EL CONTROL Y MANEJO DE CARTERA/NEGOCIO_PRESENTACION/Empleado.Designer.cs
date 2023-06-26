namespace NEGOCIO_PRESENTACION
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.lbl_Identidicación = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_TelefonoM = new System.Windows.Forms.Label();
            this.lbl_FechaN = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_Telefono_Emple = new System.Windows.Forms.TextBox();
            this.dtp_FeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbm_Estado_Empleado = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Grilla_Empleado = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txt_Codigo_Emple = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Emple = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Usuario_Emple = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cod_Proveedores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cargo_Emple = new System.Windows.Forms.TextBox();
            this.cbm_Genero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Salario_Emple = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Identidicación
            // 
            this.lbl_Identidicación.AutoSize = true;
            this.lbl_Identidicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Identidicación.Location = new System.Drawing.Point(12, 89);
            this.lbl_Identidicación.Name = "lbl_Identidicación";
            this.lbl_Identidicación.Size = new System.Drawing.Size(111, 18);
            this.lbl_Identidicación.TabIndex = 0;
            this.lbl_Identidicación.Text = "Identidicación";
            this.lbl_Identidicación.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(12, 117);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombres.TabIndex = 1;
            this.lbl_Nombres.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(9, 146);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(168, 18);
            this.lbl_Direccion.TabIndex = 2;
            this.lbl_Direccion.Text = "Dirección Residencia";
            this.lbl_Direccion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_TelefonoM
            // 
            this.lbl_TelefonoM.AutoSize = true;
            this.lbl_TelefonoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelefonoM.Location = new System.Drawing.Point(9, 181);
            this.lbl_TelefonoM.Name = "lbl_TelefonoM";
            this.lbl_TelefonoM.Size = new System.Drawing.Size(74, 18);
            this.lbl_TelefonoM.TabIndex = 3;
            this.lbl_TelefonoM.Text = "Telefono";
            this.lbl_TelefonoM.Click += new System.EventHandler(this.lbl_TelefonoM_Click);
            // 
            // lbl_FechaN
            // 
            this.lbl_FechaN.AutoSize = true;
            this.lbl_FechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaN.Location = new System.Drawing.Point(9, 220);
            this.lbl_FechaN.Name = "lbl_FechaN";
            this.lbl_FechaN.Size = new System.Drawing.Size(141, 18);
            this.lbl_FechaN.TabIndex = 5;
            this.lbl_FechaN.Text = "Fecha nacimiento";
            this.lbl_FechaN.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(9, 337);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(61, 18);
            this.lbl_Estado.TabIndex = 9;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.Location = new System.Drawing.Point(9, 308);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(64, 18);
            this.lbl_Genero.TabIndex = 10;
            this.lbl_Genero.Text = "Genero";
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Location = new System.Drawing.Point(185, 87);
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(144, 20);
            this.txt_identificacion.TabIndex = 11;
            this.txt_identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(186, 115);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(143, 20);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(185, 144);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(144, 20);
            this.txt_direccion.TabIndex = 13;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // txt_Telefono_Emple
            // 
            this.txt_Telefono_Emple.Location = new System.Drawing.Point(186, 179);
            this.txt_Telefono_Emple.Name = "txt_Telefono_Emple";
            this.txt_Telefono_Emple.Size = new System.Drawing.Size(143, 20);
            this.txt_Telefono_Emple.TabIndex = 14;
            this.txt_Telefono_Emple.TextChanged += new System.EventHandler(this.txt_Telefono_Emple_TextChanged);
            this.txt_Telefono_Emple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_Emple_KeyPress);
            // 
            // dtp_FeNacimiento
            // 
            this.dtp_FeNacimiento.Location = new System.Drawing.Point(185, 220);
            this.dtp_FeNacimiento.Name = "dtp_FeNacimiento";
            this.dtp_FeNacimiento.Size = new System.Drawing.Size(144, 20);
            this.dtp_FeNacimiento.TabIndex = 17;
            this.dtp_FeNacimiento.ValueChanged += new System.EventHandler(this.dtp_FeNacimiento_ValueChanged);
            // 
            // cbm_Estado_Empleado
            // 
            this.cbm_Estado_Empleado.FormattingEnabled = true;
            this.cbm_Estado_Empleado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbm_Estado_Empleado.Location = new System.Drawing.Point(91, 337);
            this.cbm_Estado_Empleado.Name = "cbm_Estado_Empleado";
            this.cbm_Estado_Empleado.Size = new System.Drawing.Size(86, 21);
            this.cbm_Estado_Empleado.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Consulta);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Location = new System.Drawing.Point(615, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 346);
            this.panel1.TabIndex = 22;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Location = new System.Drawing.Point(26, 243);
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
            this.btn_Modificar.Location = new System.Drawing.Point(26, 175);
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
            this.btn_Consulta.Location = new System.Drawing.Point(26, 102);
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
            this.btn_Nuevo.Location = new System.Drawing.Point(26, 27);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(95, 46);
            this.btn_Nuevo.TabIndex = 23;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 35);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(714, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Grilla_Empleado
            // 
            this.Grilla_Empleado.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_Empleado.Location = new System.Drawing.Point(0, 377);
            this.Grilla_Empleado.Name = "Grilla_Empleado";
            this.Grilla_Empleado.Size = new System.Drawing.Size(749, 107);
            this.Grilla_Empleado.TabIndex = 24;
            this.Grilla_Empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_Empleado_CellContentClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(452, 55);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(144, 144);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // txt_Codigo_Emple
            // 
            this.txt_Codigo_Emple.Location = new System.Drawing.Point(185, 57);
            this.txt_Codigo_Emple.Name = "txt_Codigo_Emple";
            this.txt_Codigo_Emple.Size = new System.Drawing.Size(144, 20);
            this.txt_Codigo_Emple.TabIndex = 26;
            this.txt_Codigo_Emple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_Emple_KeyPress);
            // 
            // lbl_Codigo_Emple
            // 
            this.lbl_Codigo_Emple.AutoSize = true;
            this.lbl_Codigo_Emple.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_Emple.Location = new System.Drawing.Point(12, 59);
            this.lbl_Codigo_Emple.Name = "lbl_Codigo_Emple";
            this.lbl_Codigo_Emple.Size = new System.Drawing.Size(62, 18);
            this.lbl_Codigo_Emple.TabIndex = 25;
            this.lbl_Codigo_Emple.Text = "Codigo";
            this.lbl_Codigo_Emple.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cargo";
            this.label1.Click += new System.EventHandler(this.label1_Click_6);
            // 
            // txt_Usuario_Emple
            // 
            this.txt_Usuario_Emple.Location = new System.Drawing.Point(91, 276);
            this.txt_Usuario_Emple.Name = "txt_Usuario_Emple";
            this.txt_Usuario_Emple.Size = new System.Drawing.Size(144, 20);
            this.txt_Usuario_Emple.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Usuario";
            // 
            // txt_Cod_Proveedores
            // 
            this.txt_Cod_Proveedores.Location = new System.Drawing.Point(367, 335);
            this.txt_Cod_Proveedores.Name = "txt_Cod_Proveedores";
            this.txt_Cod_Proveedores.Size = new System.Drawing.Size(144, 20);
            this.txt_Cod_Proveedores.TabIndex = 33;
            this.txt_Cod_Proveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cod_Proveedores_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Codigo Proveedores";
            // 
            // txt_Cargo_Emple
            // 
            this.txt_Cargo_Emple.Location = new System.Drawing.Point(258, 309);
            this.txt_Cargo_Emple.Name = "txt_Cargo_Emple";
            this.txt_Cargo_Emple.Size = new System.Drawing.Size(144, 20);
            this.txt_Cargo_Emple.TabIndex = 34;
            this.txt_Cargo_Emple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cargo_Emple_KeyPress);
            // 
            // cbm_Genero
            // 
            this.cbm_Genero.FormattingEnabled = true;
            this.cbm_Genero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Indefinido"});
            this.cbm_Genero.Location = new System.Drawing.Point(90, 307);
            this.cbm_Genero.Name = "cbm_Genero";
            this.cbm_Genero.Size = new System.Drawing.Size(87, 21);
            this.cbm_Genero.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Salario";
            // 
            // txt_Salario_Emple
            // 
            this.txt_Salario_Emple.Location = new System.Drawing.Point(90, 248);
            this.txt_Salario_Emple.Name = "txt_Salario_Emple";
            this.txt_Salario_Emple.Size = new System.Drawing.Size(144, 20);
            this.txt_Salario_Emple.TabIndex = 37;
            this.txt_Salario_Emple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salario_Emple_KeyPress);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(748, 496);
            this.Controls.Add(this.txt_Salario_Emple);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbm_Genero);
            this.Controls.Add(this.txt_Cargo_Emple);
            this.Controls.Add(this.txt_Cod_Proveedores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Usuario_Emple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Codigo_Emple);
            this.Controls.Add(this.lbl_Codigo_Emple);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grilla_Empleado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbm_Estado_Empleado);
            this.Controls.Add(this.dtp_FeNacimiento);
            this.Controls.Add(this.txt_Telefono_Emple);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_identificacion);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_FechaN);
            this.Controls.Add(this.lbl_TelefonoM);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_Identidicación);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Identidicación;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_TelefonoM;
        private System.Windows.Forms.Label lbl_FechaN;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_Telefono_Emple;
        private System.Windows.Forms.DateTimePicker dtp_FeNacimiento;
        private System.Windows.Forms.ComboBox cbm_Estado_Empleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grilla_Empleado;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Codigo_Emple;
        private System.Windows.Forms.Label lbl_Codigo_Emple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Usuario_Emple;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cod_Proveedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cargo_Emple;
        private System.Windows.Forms.ComboBox cbm_Genero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Salario_Emple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Consulta;
    }
}