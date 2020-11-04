namespace PresentacionGUI
{
    partial class FrmGestionPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPersona));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPulsacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(312, 305);
            this.TxtIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(348, 38);
            this.TxtIdentificacion.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(312, 382);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(348, 38);
            this.TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(312, 453);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(348, 38);
            this.TxtEdad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "sexo";
            // 
            // TxtPulsacion
            // 
            this.TxtPulsacion.Enabled = false;
            this.TxtPulsacion.Location = new System.Drawing.Point(312, 599);
            this.TxtPulsacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPulsacion.Name = "TxtPulsacion";
            this.TxtPulsacion.Size = new System.Drawing.Size(348, 38);
            this.TxtPulsacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pulsacion";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CmbSexo.Location = new System.Drawing.Point(312, 525);
            this.CmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(348, 39);
            this.CmbSexo.TabIndex = 10;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(96, 720);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(227, 175);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 222);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(357, 731);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 164);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 1102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtPulsacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionPersona";
            this.Text = "FrmGestionPersona";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPulsacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}