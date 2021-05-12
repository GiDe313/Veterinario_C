
namespace EjemploTabs_2021
{
    partial class Aviso
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAviso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 241);
            this.label1.TabIndex = 39;
            this.label1.Text = "¡¡AVISO!! Esta pantalla no funciona, es una posibilidad que se inplementara en el" +
    " futuro si hay mas tiempo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAviso
            // 
            this.buttonAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAviso.Location = new System.Drawing.Point(41, 277);
            this.buttonAviso.Name = "buttonAviso";
            this.buttonAviso.Size = new System.Drawing.Size(496, 51);
            this.buttonAviso.TabIndex = 38;
            this.buttonAviso.Text = "Cerrar aviso";
            this.buttonAviso.UseVisualStyleBackColor = true;
            this.buttonAviso.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // Aviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAviso);
            this.Name = "Aviso";
            this.Text = "Aviso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAviso;
    }
}