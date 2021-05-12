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
            this.tabAnimales = new System.Windows.Forms.TabPage();
            this.buttonIAnimal = new System.Windows.Forms.Button();
            this.buttonEAnimal = new System.Windows.Forms.Button();
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
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.tabRevision = new System.Windows.Forms.TabPage();
            this.buttonIRevision = new System.Windows.Forms.Button();
            this.buttonERevision = new System.Windows.Forms.Button();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.tabBasedatos = new System.Windows.Forms.TabPage();
            this.logo3 = new System.Windows.Forms.PictureBox();
            this.buttonRevisiones = new System.Windows.Forms.Button();
            this.buttonAnimales = new System.Windows.Forms.Button();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.tabControl.SuspendLayout();
            this.tabAnimales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.tabRevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.tabBasedatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAnimales);
            this.tabControl.Controls.Add(this.tabRevision);
            this.tabControl.Controls.Add(this.tabBasedatos);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.listaImagenes;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(611, 547);
            this.tabControl.TabIndex = 0;
            // 
            // tabAnimales
            // 
            this.tabAnimales.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.tabAnimales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAnimales.Controls.Add(this.buttonIAnimal);
            this.tabAnimales.Controls.Add(this.buttonEAnimal);
            this.tabAnimales.Controls.Add(this.textBoxObservaciones);
            this.tabAnimales.Controls.Add(this.textBoxDueño);
            this.tabAnimales.Controls.Add(this.textBoxEspecie);
            this.tabAnimales.Controls.Add(this.textBoxGenero);
            this.tabAnimales.Controls.Add(this.textBoxNacimiento);
            this.tabAnimales.Controls.Add(this.textBoxNombre);
            this.tabAnimales.Controls.Add(this.labelDueño);
            this.tabAnimales.Controls.Add(this.labelNacimiento);
            this.tabAnimales.Controls.Add(this.labelGenero);
            this.tabAnimales.Controls.Add(this.labelEspecie);
            this.tabAnimales.Controls.Add(this.labelObservaciones);
            this.tabAnimales.Controls.Add(this.labelNombre);
            this.tabAnimales.Controls.Add(this.logo1);
            this.tabAnimales.ImageIndex = 0;
            this.tabAnimales.Location = new System.Drawing.Point(4, 39);
            this.tabAnimales.Name = "tabAnimales";
            this.tabAnimales.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimales.Size = new System.Drawing.Size(603, 504);
            this.tabAnimales.TabIndex = 0;
            this.tabAnimales.Text = "Registrar animales";
            this.tabAnimales.UseVisualStyleBackColor = true;
            // 
            // buttonIAnimal
            // 
            this.buttonIAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIAnimal.Location = new System.Drawing.Point(353, 439);
            this.buttonIAnimal.Name = "buttonIAnimal";
            this.buttonIAnimal.Size = new System.Drawing.Size(183, 51);
            this.buttonIAnimal.TabIndex = 15;
            this.buttonIAnimal.Text = "Introducir registro";
            this.buttonIAnimal.UseVisualStyleBackColor = true;
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
            this.buttonEAnimal.Click += new System.EventHandler(this.buttonEAnimal_Click);
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(183, 355);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(353, 78);
            this.textBoxObservaciones.TabIndex = 13;
            // 
            // textBoxDueño
            // 
            this.textBoxDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueño.Location = new System.Drawing.Point(183, 155);
            this.textBoxDueño.Name = "textBoxDueño";
            this.textBoxDueño.Size = new System.Drawing.Size(353, 24);
            this.textBoxDueño.TabIndex = 12;
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEspecie.Location = new System.Drawing.Point(183, 303);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(353, 24);
            this.textBoxEspecie.TabIndex = 11;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenero.Location = new System.Drawing.Point(183, 251);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(353, 24);
            this.textBoxGenero.TabIndex = 10;
            // 
            // textBoxNacimiento
            // 
            this.textBoxNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNacimiento.Location = new System.Drawing.Point(183, 200);
            this.textBoxNacimiento.Name = "textBoxNacimiento";
            this.textBoxNacimiento.Size = new System.Drawing.Size(353, 24);
            this.textBoxNacimiento.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(183, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(353, 24);
            this.textBoxNombre.TabIndex = 8;
            // 
            // labelDueño
            // 
            this.labelDueño.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueño.ForeColor = System.Drawing.Color.White;
            this.labelDueño.Location = new System.Drawing.Point(46, 153);
            this.labelDueño.Name = "labelDueño";
            this.labelDueño.Size = new System.Drawing.Size(131, 26);
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
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.logo1.Image = global::EjemploTabs_2021.Properties.Resources.vetivir_rbg;
            this.logo1.Location = new System.Drawing.Point(8, 6);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(587, 66);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            // 
            // tabRevision
            // 
            this.tabRevision.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondodepantalla;
            this.tabRevision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabRevision.Controls.Add(this.buttonIRevision);
            this.tabRevision.Controls.Add(this.buttonERevision);
            this.tabRevision.Controls.Add(this.textBoxFecha);
            this.tabRevision.Controls.Add(this.textBoxMotivo);
            this.tabRevision.Controls.Add(this.textBoxNombre2);
            this.tabRevision.Controls.Add(this.labelFecha);
            this.tabRevision.Controls.Add(this.labelMotivo);
            this.tabRevision.Controls.Add(this.labelNombre2);
            this.tabRevision.Controls.Add(this.logo2);
            this.tabRevision.ImageIndex = 1;
            this.tabRevision.Location = new System.Drawing.Point(4, 39);
            this.tabRevision.Name = "tabRevision";
            this.tabRevision.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevision.Size = new System.Drawing.Size(603, 504);
            this.tabRevision.TabIndex = 1;
            this.tabRevision.Text = "Añadir revisiones";
            this.tabRevision.UseVisualStyleBackColor = true;
            // 
            // buttonIRevision
            // 
            this.buttonIRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIRevision.Location = new System.Drawing.Point(353, 323);
            this.buttonIRevision.Name = "buttonIRevision";
            this.buttonIRevision.Size = new System.Drawing.Size(183, 51);
            this.buttonIRevision.TabIndex = 24;
            this.buttonIRevision.Text = "Introducir registro";
            this.buttonIRevision.UseVisualStyleBackColor = true;
            // 
            // buttonERevision
            // 
            this.buttonERevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonERevision.ForeColor = System.Drawing.Color.Red;
            this.buttonERevision.Location = new System.Drawing.Point(49, 353);
            this.buttonERevision.Name = "buttonERevision";
            this.buttonERevision.Size = new System.Drawing.Size(181, 33);
            this.buttonERevision.TabIndex = 23;
            this.buttonERevision.Text = "Eliminar un registro";
            this.buttonERevision.UseVisualStyleBackColor = true;
            this.buttonERevision.Click += new System.EventHandler(this.buttonRRevision_Click);
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(183, 155);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(353, 24);
            this.textBoxFecha.TabIndex = 22;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMotivo.Location = new System.Drawing.Point(183, 200);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(353, 117);
            this.textBoxMotivo.TabIndex = 20;
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre2.Location = new System.Drawing.Point(183, 103);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.Size = new System.Drawing.Size(353, 24);
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
            // labelMotivo
            // 
            this.labelMotivo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotivo.ForeColor = System.Drawing.Color.White;
            this.labelMotivo.Location = new System.Drawing.Point(46, 198);
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
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.logo2.Image = global::EjemploTabs_2021.Properties.Resources.vetivir_rbg;
            this.logo2.Location = new System.Drawing.Point(8, 6);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(587, 66);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 1;
            this.logo2.TabStop = false;
            // 
            // tabBasedatos
            // 
            this.tabBasedatos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabBasedatos.BackgroundImage = global::EjemploTabs_2021.Properties.Resources.fondoBBDD;
            this.tabBasedatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBasedatos.Controls.Add(this.logo3);
            this.tabBasedatos.Controls.Add(this.buttonRevisiones);
            this.tabBasedatos.Controls.Add(this.buttonAnimales);
            this.tabBasedatos.Controls.Add(this.buttonUsuarios);
            this.tabBasedatos.ImageIndex = 2;
            this.tabBasedatos.Location = new System.Drawing.Point(4, 39);
            this.tabBasedatos.Name = "tabBasedatos";
            this.tabBasedatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasedatos.Size = new System.Drawing.Size(603, 504);
            this.tabBasedatos.TabIndex = 2;
            this.tabBasedatos.Text = "Buscar en la base de datos";
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
            // buttonRevisiones
            // 
            this.buttonRevisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevisiones.Location = new System.Drawing.Point(111, 310);
            this.buttonRevisiones.Name = "buttonRevisiones";
            this.buttonRevisiones.Size = new System.Drawing.Size(363, 77);
            this.buttonRevisiones.TabIndex = 2;
            this.buttonRevisiones.Text = "Revisiones";
            this.buttonRevisiones.UseVisualStyleBackColor = true;
            this.buttonRevisiones.Click += new System.EventHandler(this.revisiones_Click);
            // 
            // buttonAnimales
            // 
            this.buttonAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimales.Location = new System.Drawing.Point(111, 207);
            this.buttonAnimales.Name = "buttonAnimales";
            this.buttonAnimales.Size = new System.Drawing.Size(363, 77);
            this.buttonAnimales.TabIndex = 1;
            this.buttonAnimales.Text = "Animales";
            this.buttonAnimales.UseVisualStyleBackColor = true;
            this.buttonAnimales.Click += new System.EventHandler(this.animales_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.Location = new System.Drawing.Point(111, 104);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(363, 77);
            this.buttonUsuarios.TabIndex = 0;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.usuarios_Click);
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "iconoMascota.png");
            this.listaImagenes.Images.SetKeyName(1, "iconoRevision.png");
            this.listaImagenes.Images.SetKeyName(2, "iconoBasededatos.png");
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
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
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAnimales.ResumeLayout(false);
            this.tabAnimales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.tabRevision.ResumeLayout(false);
            this.tabRevision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.tabBasedatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAnimales;
        private System.Windows.Forms.TabPage tabRevision;
        private System.Windows.Forms.TabPage tabBasedatos;
        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox logo2;
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
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelMotivo;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Button buttonRevisiones;
        private System.Windows.Forms.Button buttonAnimales;
        private System.Windows.Forms.Button buttonUsuarios;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.PictureBox logo3;
        private System.Windows.Forms.Button buttonEAnimal;
        private System.Windows.Forms.Button buttonERevision;
        private System.Windows.Forms.Button buttonIAnimal;
        private System.Windows.Forms.Button buttonIRevision;
    }
}

