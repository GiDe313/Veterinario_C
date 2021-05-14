namespace EjemploTabs_2021
{
    partial class AñadirUsuario
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPASS = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.logoVetivir = new System.Windows.Forms.PictureBox();
            this.insertaUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoVetivir)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(82, 12);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(220, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxPASS
            // 
            this.textBoxPASS.Location = new System.Drawing.Point(82, 118);
            this.textBoxPASS.Name = "textBoxPASS";
            this.textBoxPASS.Size = new System.Drawing.Size(220, 20);
            this.textBoxPASS.TabIndex = 7;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(82, 65);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(220, 20);
            this.textBoxDNI.TabIndex = 10;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(10, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 20);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPass
            // 
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(3, 118);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(73, 20);
            this.labelPass.TabIndex = 13;
            this.labelPass.Text = "Contraseña";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDNI
            // 
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.ForeColor = System.Drawing.Color.White;
            this.labelDNI.Location = new System.Drawing.Point(12, 64);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(66, 20);
            this.labelDNI.TabIndex = 14;
            this.labelDNI.Text = "DNI";
            this.labelDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoVetivir
            // 
            this.logoVetivir.Image = global::EjemploTabs_2021.Properties.Resources.vetivirlogo_rbg;
            this.logoVetivir.Location = new System.Drawing.Point(308, 1);
            this.logoVetivir.Name = "logoVetivir";
            this.logoVetivir.Size = new System.Drawing.Size(179, 150);
            this.logoVetivir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoVetivir.TabIndex = 15;
            this.logoVetivir.TabStop = false;
            // 
            // insertaUsuario
            // 
            this.insertaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertaUsuario.Location = new System.Drawing.Point(82, 161);
            this.insertaUsuario.Name = "insertaUsuario";
            this.insertaUsuario.Size = new System.Drawing.Size(172, 43);
            this.insertaUsuario.TabIndex = 16;
            this.insertaUsuario.Text = "Añadir";
            this.insertaUsuario.UseVisualStyleBackColor = true;
            this.insertaUsuario.Click += new System.EventHandler(this.insertaUsuario_Click);
            // 
            // AñadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(487, 229);
            this.Controls.Add(this.insertaUsuario);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxPASS);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.logoVetivir);
            this.Name = "AñadirUsuario";
            this.Text = "AltaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.logoVetivir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPASS;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.PictureBox logoVetivir;
        private System.Windows.Forms.Button insertaUsuario;
    }
}