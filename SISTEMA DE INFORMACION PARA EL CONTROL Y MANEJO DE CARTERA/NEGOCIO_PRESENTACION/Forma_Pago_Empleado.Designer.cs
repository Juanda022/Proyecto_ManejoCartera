namespace NEGOCIO_PRESENTACION
{
    partial class Forma_Pago_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Pago_Empleado));
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Consulta_FormaPG = new System.Windows.Forms.Button();
            this.btn_Nuevo_FormaPG = new System.Windows.Forms.Button();
            this.Grilla_FormaPG = new System.Windows.Forms.DataGridView();
            this.txt_Nombre_FormaPG2 = new System.Windows.Forms.TextBox();
            this.txt_Codigo_FormaPG2 = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_FormaPG = new System.Windows.Forms.Label();
            this.lbl_Codigo_FormaPG = new System.Windows.Forms.Label();
            this.cmb_EstadoFP2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_FormaPG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(2, 49);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(62, 61);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 96;
            this.pictureBox7.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 42);
            this.panel3.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 104;
            this.label2.Text = "Forma Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(646, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(688, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btn_Consulta_FormaPG);
            this.panel1.Controls.Add(this.btn_Nuevo_FormaPG);
            this.panel1.Location = new System.Drawing.Point(610, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 377);
            this.panel1.TabIndex = 94;
            // 
            // btn_Consulta_FormaPG
            // 
            this.btn_Consulta_FormaPG.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Consulta_FormaPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consulta_FormaPG.ForeColor = System.Drawing.Color.Black;
            this.btn_Consulta_FormaPG.Location = new System.Drawing.Point(15, 199);
            this.btn_Consulta_FormaPG.Name = "btn_Consulta_FormaPG";
            this.btn_Consulta_FormaPG.Size = new System.Drawing.Size(95, 53);
            this.btn_Consulta_FormaPG.TabIndex = 24;
            this.btn_Consulta_FormaPG.Text = "Consulta";
            this.btn_Consulta_FormaPG.UseVisualStyleBackColor = false;
            this.btn_Consulta_FormaPG.Click += new System.EventHandler(this.btn_Consulta_FormaPG_Click);
            // 
            // btn_Nuevo_FormaPG
            // 
            this.btn_Nuevo_FormaPG.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Nuevo_FormaPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo_FormaPG.ForeColor = System.Drawing.Color.Black;
            this.btn_Nuevo_FormaPG.Location = new System.Drawing.Point(15, 111);
            this.btn_Nuevo_FormaPG.Name = "btn_Nuevo_FormaPG";
            this.btn_Nuevo_FormaPG.Size = new System.Drawing.Size(95, 52);
            this.btn_Nuevo_FormaPG.TabIndex = 23;
            this.btn_Nuevo_FormaPG.Text = "Nuevo";
            this.btn_Nuevo_FormaPG.UseVisualStyleBackColor = false;
            this.btn_Nuevo_FormaPG.Click += new System.EventHandler(this.btn_Nuevo_FormaPG_Click);
            // 
            // Grilla_FormaPG
            // 
            this.Grilla_FormaPG.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Grilla_FormaPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla_FormaPG.Location = new System.Drawing.Point(134, 270);
            this.Grilla_FormaPG.Name = "Grilla_FormaPG";
            this.Grilla_FormaPG.Size = new System.Drawing.Size(341, 87);
            this.Grilla_FormaPG.TabIndex = 93;
            // 
            // txt_Nombre_FormaPG2
            // 
            this.txt_Nombre_FormaPG2.Location = new System.Drawing.Point(282, 178);
            this.txt_Nombre_FormaPG2.Name = "txt_Nombre_FormaPG2";
            this.txt_Nombre_FormaPG2.Size = new System.Drawing.Size(230, 20);
            this.txt_Nombre_FormaPG2.TabIndex = 92;
            this.txt_Nombre_FormaPG2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_FormaPG2_KeyPress);
            // 
            // txt_Codigo_FormaPG2
            // 
            this.txt_Codigo_FormaPG2.Location = new System.Drawing.Point(281, 125);
            this.txt_Codigo_FormaPG2.Name = "txt_Codigo_FormaPG2";
            this.txt_Codigo_FormaPG2.Size = new System.Drawing.Size(230, 20);
            this.txt_Codigo_FormaPG2.TabIndex = 91;
            this.txt_Codigo_FormaPG2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_FormaPG2_KeyPress);
            // 
            // lbl_Nombre_FormaPG
            // 
            this.lbl_Nombre_FormaPG.AutoSize = true;
            this.lbl_Nombre_FormaPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_FormaPG.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nombre_FormaPG.Location = new System.Drawing.Point(108, 180);
            this.lbl_Nombre_FormaPG.Name = "lbl_Nombre_FormaPG";
            this.lbl_Nombre_FormaPG.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombre_FormaPG.TabIndex = 90;
            this.lbl_Nombre_FormaPG.Text = "Nombre";
            // 
            // lbl_Codigo_FormaPG
            // 
            this.lbl_Codigo_FormaPG.AutoSize = true;
            this.lbl_Codigo_FormaPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Codigo_FormaPG.ForeColor = System.Drawing.Color.Black;
            this.lbl_Codigo_FormaPG.Location = new System.Drawing.Point(108, 127);
            this.lbl_Codigo_FormaPG.Name = "lbl_Codigo_FormaPG";
            this.lbl_Codigo_FormaPG.Size = new System.Drawing.Size(62, 18);
            this.lbl_Codigo_FormaPG.TabIndex = 89;
            this.lbl_Codigo_FormaPG.Text = "Codigo";
            // 
            // cmb_EstadoFP2
            // 
            this.cmb_EstadoFP2.FormattingEnabled = true;
            this.cmb_EstadoFP2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_EstadoFP2.Location = new System.Drawing.Point(277, 215);
            this.cmb_EstadoFP2.Name = "cmb_EstadoFP2";
            this.cmb_EstadoFP2.Size = new System.Drawing.Size(234, 21);
            this.cmb_EstadoFP2.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "Estado";
            // 
            // Forma_Pago_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(732, 394);
            this.Controls.Add(this.cmb_EstadoFP2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grilla_FormaPG);
            this.Controls.Add(this.txt_Nombre_FormaPG2);
            this.Controls.Add(this.txt_Codigo_FormaPG2);
            this.Controls.Add(this.lbl_Nombre_FormaPG);
            this.Controls.Add(this.lbl_Codigo_FormaPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Forma_Pago_Empleado";
            this.Text = "Forma_Pago_Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla_FormaPG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Consulta_FormaPG;
        private System.Windows.Forms.Button btn_Nuevo_FormaPG;
        private System.Windows.Forms.DataGridView Grilla_FormaPG;
        private System.Windows.Forms.TextBox txt_Nombre_FormaPG2;
        private System.Windows.Forms.TextBox txt_Codigo_FormaPG2;
        private System.Windows.Forms.Label lbl_Nombre_FormaPG;
        private System.Windows.Forms.Label lbl_Codigo_FormaPG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_EstadoFP2;
        private System.Windows.Forms.Label label1;

    }
}