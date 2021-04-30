namespace EjemploTabs_2021
{
    partial class Inicio
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
            this.botonLogin = new System.Windows.Forms.Button();
            this.EtiquetaUsuario = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.EtiquetaContraseña = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.registrar = new System.Windows.Forms.Button();
            this.recContraseña = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // botonLogin
            // 
            this.botonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botonLogin.Location = new System.Drawing.Point(363, 212);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(154, 38);
            this.botonLogin.TabIndex = 0;
            this.botonLogin.Text = "Entrar";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // EtiquetaUsuario
            // 
            this.EtiquetaUsuario.AutoSize = true;
            this.EtiquetaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtiquetaUsuario.Location = new System.Drawing.Point(43, 131);
            this.EtiquetaUsuario.Name = "EtiquetaUsuario";
            this.EtiquetaUsuario.Size = new System.Drawing.Size(116, 33);
            this.EtiquetaUsuario.TabIndex = 1;
            this.EtiquetaUsuario.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(214, 131);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(303, 24);
            this.usuario.TabIndex = 2;
            // 
            // EtiquetaContraseña
            // 
            this.EtiquetaContraseña.AutoSize = true;
            this.EtiquetaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtiquetaContraseña.Location = new System.Drawing.Point(43, 164);
            this.EtiquetaContraseña.Name = "EtiquetaContraseña";
            this.EtiquetaContraseña.Size = new System.Drawing.Size(165, 33);
            this.EtiquetaContraseña.TabIndex = 3;
            this.EtiquetaContraseña.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(214, 170);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(303, 24);
            this.contraseña.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(128, 103);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // registrar
            // 
            this.registrar.ForeColor = System.Drawing.Color.Red;
            this.registrar.Location = new System.Drawing.Point(12, 286);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(166, 26);
            this.registrar.TabIndex = 6;
            this.registrar.Text = "¿No tienes usuario? Registrate";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // recContraseña
            // 
            this.recContraseña.ForeColor = System.Drawing.Color.Red;
            this.recContraseña.Location = new System.Drawing.Point(184, 286);
            this.recContraseña.Name = "recContraseña";
            this.recContraseña.Size = new System.Drawing.Size(221, 26);
            this.recContraseña.TabIndex = 7;
            this.recContraseña.Text = "¿Has olvidado tu contraseña?(no funciona)";
            this.recContraseña.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(561, 324);
            this.Controls.Add(this.recContraseña);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.EtiquetaContraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.EtiquetaUsuario);
            this.Controls.Add(this.botonLogin);
            this.Name = "Inicio";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Label EtiquetaUsuario;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label EtiquetaContraseña;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button recContraseña;
    }
}