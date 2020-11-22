
namespace Clave1_Grupo6
{
    partial class InicioSesion
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
            this.components = new System.ComponentModel.Container();
            this.gBInicioSesion = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ePInicioSesion = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePInicioSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // gBInicioSesion
            // 
            this.gBInicioSesion.Controls.Add(this.btnIniciar);
            this.gBInicioSesion.Controls.Add(this.txtPassword);
            this.gBInicioSesion.Controls.Add(this.txtUsuario);
            this.gBInicioSesion.Controls.Add(this.lblPassword);
            this.gBInicioSesion.Controls.Add(this.lblUsuario);
            this.gBInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBInicioSesion.Location = new System.Drawing.Point(45, 34);
            this.gBInicioSesion.Name = "gBInicioSesion";
            this.gBInicioSesion.Size = new System.Drawing.Size(388, 196);
            this.gBInicioSesion.TabIndex = 0;
            this.gBInicioSesion.TabStop = false;
            this.gBInicioSesion.Text = "Iniciar Sesion";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(146, 140);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(158, 36);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(136, 43);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(49, 46);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // ePInicioSesion
            // 
            this.ePInicioSesion.ContainerControl = this;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(482, 272);
            this.Controls.Add(this.gBInicioSesion);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.gBInicioSesion.ResumeLayout(false);
            this.gBInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePInicioSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBInicioSesion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ErrorProvider ePInicioSesion;
    }
}