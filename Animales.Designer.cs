
namespace EjemploTabs_2021
{
    partial class Animales
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
            this.dataGridViewAnimales = new System.Windows.Forms.DataGridView();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnimales
            // 
            this.dataGridViewAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimales.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewAnimales.Name = "dataGridViewAnimales";
            this.dataGridViewAnimales.Size = new System.Drawing.Size(776, 330);
            this.dataGridViewAnimales.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(104, 72);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(329, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(457, 21);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(173, 71);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelNombre.Location = new System.Drawing.Point(104, 21);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(329, 38);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Introduce el nombre para buscar en la base de datos:";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.dataGridViewAnimales);
            this.Name = "Animales";
            this.Text = "Animales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnimales;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelNombre;
    }
}