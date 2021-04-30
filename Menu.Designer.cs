namespace EjemploTabs_2021
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabrevision = new System.Windows.Forms.TabPage();
            this.tabbasedatos = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabanimales = new System.Windows.Forms.TabPage();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.logo3 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabrevision.SuspendLayout();
            this.tabbasedatos.SuspendLayout();
            this.tabanimales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabanimales);
            this.tabControl.Controls.Add(this.tabrevision);
            this.tabControl.Controls.Add(this.tabbasedatos);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(611, 448);
            this.tabControl.TabIndex = 0;
            // 
            // tabrevision
            // 
            this.tabrevision.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.tabrevision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabrevision.Controls.Add(this.logo2);
            this.tabrevision.ImageIndex = 17;
            this.tabrevision.Location = new System.Drawing.Point(4, 39);
            this.tabrevision.Name = "tabrevision";
            this.tabrevision.Padding = new System.Windows.Forms.Padding(3);
            this.tabrevision.Size = new System.Drawing.Size(603, 405);
            this.tabrevision.TabIndex = 1;
            this.tabrevision.Text = "Añadir revisiones";
            this.tabrevision.UseVisualStyleBackColor = true;
            // 
            // tabbasedatos
            // 
            this.tabbasedatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabbasedatos.Controls.Add(this.logo3);
            this.tabbasedatos.Controls.Add(this.dateTimePicker1);
            this.tabbasedatos.ImageIndex = 1;
            this.tabbasedatos.Location = new System.Drawing.Point(4, 39);
            this.tabbasedatos.Name = "tabbasedatos";
            this.tabbasedatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabbasedatos.Size = new System.Drawing.Size(603, 405);
            this.tabbasedatos.TabIndex = 2;
            this.tabbasedatos.Text = "Buscar en la base de datos";
            this.tabbasedatos.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(414, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_business.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_dog_leash.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_dog_pooping.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_doggy_bag.ico");
            this.imageList1.Images.SetKeyName(4, "icons8_heart_outline.ico");
            this.imageList1.Images.SetKeyName(5, "icons8_horse.ico");
            this.imageList1.Images.SetKeyName(6, "icons8_maintenance.ico");
            this.imageList1.Images.SetKeyName(7, "icons8_pig.ico");
            this.imageList1.Images.SetKeyName(8, "icons8_pig_1.ico");
            this.imageList1.Images.SetKeyName(9, "icons8_print.ico");
            this.imageList1.Images.SetKeyName(10, "icons8_pug.ico");
            this.imageList1.Images.SetKeyName(11, "icons8_queen_bee.ico");
            this.imageList1.Images.SetKeyName(12, "icons8_sheep.ico");
            this.imageList1.Images.SetKeyName(13, "icons8_shiba_inu.ico");
            this.imageList1.Images.SetKeyName(14, "icons8_sparrowhawk.ico");
            this.imageList1.Images.SetKeyName(15, "icons8_user.ico");
            this.imageList1.Images.SetKeyName(16, "icons8_user_1.ico");
            this.imageList1.Images.SetKeyName(17, "icons8_veterinarian.ico");
            this.imageList1.Images.SetKeyName(18, "icons8_whatsapp.ico");
            // 
            // tabanimales
            // 
            this.tabanimales.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.tabanimales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabanimales.Controls.Add(this.logo1);
            this.tabanimales.ImageIndex = 13;
            this.tabanimales.Location = new System.Drawing.Point(4, 39);
            this.tabanimales.Name = "tabanimales";
            this.tabanimales.Padding = new System.Windows.Forms.Padding(3);
            this.tabanimales.Size = new System.Drawing.Size(603, 405);
            this.tabanimales.TabIndex = 0;
            this.tabanimales.Text = "Registrar animales";
            this.tabanimales.UseVisualStyleBackColor = true;
            // 
            // logo1
            // 
            this.logo1.Location = new System.Drawing.Point(8, 6);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(250, 110);
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.Location = new System.Drawing.Point(8, 6);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(250, 110);
            this.logo2.TabIndex = 1;
            this.logo2.TabStop = false;
            // 
            // logo3
            // 
            this.logo3.Location = new System.Drawing.Point(8, 6);
            this.logo3.Name = "logo3";
            this.logo3.Size = new System.Drawing.Size(250, 110);
            this.logo3.TabIndex = 1;
            this.logo3.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 448);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabrevision.ResumeLayout(false);
            this.tabbasedatos.ResumeLayout(false);
            this.tabanimales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabanimales;
        private System.Windows.Forms.TabPage tabrevision;
        private System.Windows.Forms.TabPage tabbasedatos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox logo3;
    }
}

