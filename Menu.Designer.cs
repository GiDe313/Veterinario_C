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
            this.tabanimales = new System.Windows.Forms.TabPage();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.textBoxDueño = new System.Windows.Forms.TextBox();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxNacimiento = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDueño = new System.Windows.Forms.Label();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.tabrevision = new System.Windows.Forms.TabPage();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabbasedatos = new System.Windows.Forms.TabPage();
            this.revisiones = new System.Windows.Forms.Button();
            this.animales = new System.Windows.Forms.Button();
            this.usuarios = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.logo3 = new System.Windows.Forms.PictureBox();
            this.buttonEAnimal = new System.Windows.Forms.Button();
            this.buttonRRevision = new System.Windows.Forms.Button();
            this.buttonIntroducirA = new System.Windows.Forms.Button();
            this.buttonIntroducirR = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabanimales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.tabrevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabbasedatos.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(611, 547);
            this.tabControl.TabIndex = 0;
            // 
            // tabanimales
            // 
            this.tabanimales.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.tabanimales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabanimales.Controls.Add(this.buttonIntroducirA);
            this.tabanimales.Controls.Add(this.buttonEAnimal);
            this.tabanimales.Controls.Add(this.textBoxObservaciones);
            this.tabanimales.Controls.Add(this.textBoxDueño);
            this.tabanimales.Controls.Add(this.textBoxEspecie);
            this.tabanimales.Controls.Add(this.textBoxGenero);
            this.tabanimales.Controls.Add(this.textBoxNacimiento);
            this.tabanimales.Controls.Add(this.textBoxNombre);
            this.tabanimales.Controls.Add(this.labelDueño);
            this.tabanimales.Controls.Add(this.labelNacimiento);
            this.tabanimales.Controls.Add(this.labelGenero);
            this.tabanimales.Controls.Add(this.labelEspecie);
            this.tabanimales.Controls.Add(this.labelObservaciones);
            this.tabanimales.Controls.Add(this.labelNombre);
            this.tabanimales.Controls.Add(this.logo2);
            this.tabanimales.ImageIndex = 13;
            this.tabanimales.Location = new System.Drawing.Point(4, 39);
            this.tabanimales.Name = "tabanimales";
            this.tabanimales.Padding = new System.Windows.Forms.Padding(3);
            this.tabanimales.Size = new System.Drawing.Size(603, 504);
            this.tabanimales.TabIndex = 0;
            this.tabanimales.Text = "Registrar animales";
            this.tabanimales.UseVisualStyleBackColor = true;
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(183, 355);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(303, 78);
            this.textBoxObservaciones.TabIndex = 13;
            // 
            // textBoxDueño
            // 
            this.textBoxDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueño.Location = new System.Drawing.Point(183, 155);
            this.textBoxDueño.Name = "textBoxDueño";
            this.textBoxDueño.Size = new System.Drawing.Size(303, 24);
            this.textBoxDueño.TabIndex = 12;
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEspecie.Location = new System.Drawing.Point(183, 303);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(303, 24);
            this.textBoxEspecie.TabIndex = 11;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenero.Location = new System.Drawing.Point(183, 251);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(303, 24);
            this.textBoxGenero.TabIndex = 10;
            // 
            // textBoxNacimiento
            // 
            this.textBoxNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNacimiento.Location = new System.Drawing.Point(183, 200);
            this.textBoxNacimiento.Name = "textBoxNacimiento";
            this.textBoxNacimiento.Size = new System.Drawing.Size(303, 24);
            this.textBoxNacimiento.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(183, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(303, 24);
            this.textBoxNombre.TabIndex = 8;
            // 
            // labelDueño
            // 
            this.labelDueño.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueño.ForeColor = System.Drawing.Color.White;
            this.labelDueño.Location = new System.Drawing.Point(49, 153);
            this.labelDueño.Name = "labelDueño";
            this.labelDueño.Size = new System.Drawing.Size(128, 26);
            this.labelDueño.TabIndex = 6;
            this.labelDueño.Text = "Dueño";
            this.labelDueño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimiento.ForeColor = System.Drawing.Color.White;
            this.labelNacimiento.Location = new System.Drawing.Point(46, 198);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(131, 26);
            this.labelNacimiento.TabIndex = 5;
            this.labelNacimiento.Text = "Fecha de nacimiento";
            this.labelNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGenero
            // 
            this.labelGenero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.ForeColor = System.Drawing.Color.White;
            this.labelGenero.Location = new System.Drawing.Point(46, 249);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(131, 26);
            this.labelGenero.TabIndex = 4;
            this.labelGenero.Text = "Género";
            this.labelGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEspecie
            // 
            this.labelEspecie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecie.ForeColor = System.Drawing.Color.White;
            this.labelEspecie.Location = new System.Drawing.Point(46, 301);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(131, 26);
            this.labelEspecie.TabIndex = 3;
            this.labelEspecie.Text = "Raza / especie";
            this.labelEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservaciones.ForeColor = System.Drawing.Color.White;
            this.labelObservaciones.Location = new System.Drawing.Point(46, 353);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(131, 26);
            this.labelObservaciones.TabIndex = 2;
            this.labelObservaciones.Text = "Observaciones";
            this.labelObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(46, 101);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(131, 26);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.logo2.Image = global::EjemploTabs_2021.Properties.Resources.vetivir_rbg;
            this.logo2.Location = new System.Drawing.Point(8, 6);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(587, 66);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 0;
            this.logo2.TabStop = false;
            // 
            // tabrevision
            // 
            this.tabrevision.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.tabrevision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabrevision.Controls.Add(this.buttonIntroducirR);
            this.tabrevision.Controls.Add(this.buttonRRevision);
            this.tabrevision.Controls.Add(this.textBoxFecha);
            this.tabrevision.Controls.Add(this.textBoxMotivo);
            this.tabrevision.Controls.Add(this.textBoxHora);
            this.tabrevision.Controls.Add(this.textBoxNombre2);
            this.tabrevision.Controls.Add(this.labelFecha);
            this.tabrevision.Controls.Add(this.labelHora);
            this.tabrevision.Controls.Add(this.labelMotivo);
            this.tabrevision.Controls.Add(this.labelNombre2);
            this.tabrevision.Controls.Add(this.pictureBox1);
            this.tabrevision.ImageIndex = 17;
            this.tabrevision.Location = new System.Drawing.Point(4, 39);
            this.tabrevision.Name = "tabrevision";
            this.tabrevision.Padding = new System.Windows.Forms.Padding(3);
            this.tabrevision.Size = new System.Drawing.Size(603, 504);
            this.tabrevision.TabIndex = 1;
            this.tabrevision.Text = "Añadir revisiones";
            this.tabrevision.UseVisualStyleBackColor = true;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(183, 155);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(303, 24);
            this.textBoxFecha.TabIndex = 22;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMotivo.Location = new System.Drawing.Point(183, 251);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(303, 117);
            this.textBoxMotivo.TabIndex = 20;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHora.Location = new System.Drawing.Point(183, 200);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(303, 24);
            this.textBoxHora.TabIndex = 19;
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre2.Location = new System.Drawing.Point(183, 103);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(303, 24);
            this.textBoxNombre2.TabIndex = 18;
            // 
            // labelFecha
            // 
            this.labelFecha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(46, 153);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(131, 26);
            this.labelFecha.TabIndex = 17;
            this.labelFecha.Text = "Fecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHora
            // 
            this.labelHora.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.White;
            this.labelHora.Location = new System.Drawing.Point(46, 198);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(131, 26);
            this.labelHora.TabIndex = 16;
            this.labelHora.Text = "Hora";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMotivo
            // 
            this.labelMotivo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotivo.ForeColor = System.Drawing.Color.White;
            this.labelMotivo.Location = new System.Drawing.Point(46, 249);
            this.labelMotivo.Name = "labelMotivo";
            this.labelMotivo.Size = new System.Drawing.Size(131, 26);
            this.labelMotivo.TabIndex = 15;
            this.labelMotivo.Text = "Motivo";
            this.labelMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombre2
            // 
            this.labelNombre2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.ForeColor = System.Drawing.Color.White;
            this.labelNombre2.Location = new System.Drawing.Point(46, 101);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(131, 26);
            this.labelNombre2.TabIndex = 13;
            this.labelNombre2.Text = "Nombre";
            this.labelNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pictureBox1.Image = global::EjemploTabs_2021.Properties.Resources.vetivir_rbg;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabbasedatos
            // 
            this.tabbasedatos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabbasedatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabbasedatos.Controls.Add(this.logo3);
            this.tabbasedatos.Controls.Add(this.revisiones);
            this.tabbasedatos.Controls.Add(this.animales);
            this.tabbasedatos.Controls.Add(this.usuarios);
            this.tabbasedatos.ImageIndex = 1;
            this.tabbasedatos.Location = new System.Drawing.Point(4, 39);
            this.tabbasedatos.Name = "tabbasedatos";
            this.tabbasedatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabbasedatos.Size = new System.Drawing.Size(603, 504);
            this.tabbasedatos.TabIndex = 2;
            this.tabbasedatos.Text = "Buscar en la base de datos";
            // 
            // revisiones
            // 
            this.revisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revisiones.Location = new System.Drawing.Point(111, 310);
            this.revisiones.Name = "revisiones";
            this.revisiones.Size = new System.Drawing.Size(363, 77);
            this.revisiones.TabIndex = 2;
            this.revisiones.Text = "Revisiones";
            this.revisiones.UseVisualStyleBackColor = true;
            this.revisiones.Click += new System.EventHandler(this.revisiones_Click);
            // 
            // animales
            // 
            this.animales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animales.Location = new System.Drawing.Point(111, 207);
            this.animales.Name = "animales";
            this.animales.Size = new System.Drawing.Size(363, 77);
            this.animales.TabIndex = 1;
            this.animales.Text = "Animales";
            this.animales.UseVisualStyleBackColor = true;
            this.animales.Click += new System.EventHandler(this.animales_Click);
            // 
            // usuarios
            // 
            this.usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios.Location = new System.Drawing.Point(111, 104);
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(363, 77);
            this.usuarios.TabIndex = 0;
            this.usuarios.Text = "Usuarios";
            this.usuarios.UseVisualStyleBackColor = true;
            this.usuarios.Click += new System.EventHandler(this.usuarios_Click);
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
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // logo3
            // 
            this.logo3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.logo3.Image = global::EjemploTabs_2021.Properties.Resources.vetivir_rbg;
            this.logo3.Location = new System.Drawing.Point(6, 6);
            this.logo3.Name = "logo3";
            this.logo3.Size = new System.Drawing.Size(587, 66);
            this.logo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo3.TabIndex = 3;
            this.logo3.TabStop = false;
            // 
            // buttonEAnimal
            // 
            this.buttonEAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEAnimal.ForeColor = System.Drawing.Color.Red;
            this.buttonEAnimal.Location = new System.Drawing.Point(49, 463);
            this.buttonEAnimal.Name = "buttonEAnimal";
            this.buttonEAnimal.Size = new System.Drawing.Size(181, 33);
            this.buttonEAnimal.TabIndex = 14;
            this.buttonEAnimal.Text = "Eliminar un registro";
            this.buttonEAnimal.UseVisualStyleBackColor = true;
            // 
            // buttonRRevision
            // 
            this.buttonRRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRRevision.ForeColor = System.Drawing.Color.Red;
            this.buttonRRevision.Location = new System.Drawing.Point(49, 463);
            this.buttonRRevision.Name = "buttonRRevision";
            this.buttonRRevision.Size = new System.Drawing.Size(181, 33);
            this.buttonRRevision.TabIndex = 23;
            this.buttonRRevision.Text = "Eliminar un registro";
            this.buttonRRevision.UseVisualStyleBackColor = true;
            // 
            // buttonIntroducirA
            // 
            this.buttonIntroducirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntroducirA.Location = new System.Drawing.Point(303, 439);
            this.buttonIntroducirA.Name = "buttonIntroducirA";
            this.buttonIntroducirA.Size = new System.Drawing.Size(183, 51);
            this.buttonIntroducirA.TabIndex = 15;
            this.buttonIntroducirA.Text = "Introducir registro";
            this.buttonIntroducirA.UseVisualStyleBackColor = true;
            // 
            // buttonIntroducirR
            // 
            this.buttonIntroducirR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntroducirR.Location = new System.Drawing.Point(303, 374);
            this.buttonIntroducirR.Name = "buttonIntroducirR";
            this.buttonIntroducirR.Size = new System.Drawing.Size(183, 51);
            this.buttonIntroducirR.TabIndex = 24;
            this.buttonIntroducirR.Text = "Introducir registro";
            this.buttonIntroducirR.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 547);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabanimales.ResumeLayout(false);
            this.tabanimales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.tabrevision.ResumeLayout(false);
            this.tabrevision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabbasedatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabanimales;
        private System.Windows.Forms.TabPage tabrevision;
        private System.Windows.Forms.TabPage tabbasedatos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDueño;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelEspecie;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.TextBox textBoxDueño;
        private System.Windows.Forms.TextBox textBoxEspecie;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.TextBox textBoxNacimiento;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelMotivo;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Button revisiones;
        private System.Windows.Forms.Button animales;
        private System.Windows.Forms.Button usuarios;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.PictureBox logo3;
        private System.Windows.Forms.Button buttonEAnimal;
        private System.Windows.Forms.Button buttonRRevision;
        private System.Windows.Forms.Button buttonIntroducirA;
        private System.Windows.Forms.Button buttonIntroducirR;
    }
}

