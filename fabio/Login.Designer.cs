using Bunifu.Framework;
using Bunifu;
using Bunifu.Framework.UI;
using WindowsFormsControlLibrary1;

namespace fabio

{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.HORA = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.control = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BTN_INGRESAR = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.BTN_SALIR = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.control.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.HORA);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 262);
            this.panel1.TabIndex = 0;
            // 
            // HORA
            // 
            this.HORA.AutoSize = true;
            this.HORA.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HORA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HORA.Location = new System.Drawing.Point(21, 212);
            this.HORA.Name = "HORA";
            this.HORA.Size = new System.Drawing.Size(133, 33);
            this.HORA.TabIndex = 0;
            this.HORA.Text = "hh:mm:ss";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::fabio.Properties.Resources.fabio_logo_grande_fondo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.control.Controls.Add(this.bunifuCustomLabel1);
            this.control.Dock = System.Windows.Forms.DockStyle.Top;
            this.control.Location = new System.Drawing.Point(182, 0);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(456, 34);
            this.control.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(220, 33);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Inicio de secion";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.control;
            this.bunifuDragControl2.Vertical = true;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_INGRESAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_INGRESAR.BackgroundImage")));
            this.BTN_INGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_INGRESAR.ButtonText = "INGRESAR";
            this.BTN_INGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_INGRESAR.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BTN_INGRESAR.ForeColorHoverState = System.Drawing.Color.White;
            this.BTN_INGRESAR.Iconimage = null;
            this.BTN_INGRESAR.IconVisible = true;
            this.BTN_INGRESAR.IconZoom = 100D;
            this.BTN_INGRESAR.ImageIconOverlay = false;
            this.BTN_INGRESAR.Location = new System.Drawing.Point(215, 212);
            this.BTN_INGRESAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(130, 37);
            this.BTN_INGRESAR.TabIndex = 4;
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_SALIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_SALIR.BackgroundImage")));
            this.BTN_SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_SALIR.ButtonText = "SALIR";
            this.BTN_SALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SALIR.ForeColor = System.Drawing.Color.Salmon;
            this.BTN_SALIR.ForeColorHoverState = System.Drawing.Color.White;
            this.BTN_SALIR.Iconimage = null;
            this.BTN_SALIR.IconVisible = true;
            this.BTN_SALIR.IconZoom = 100D;
            this.BTN_SALIR.ImageIconOverlay = false;
            this.BTN_SALIR.Location = new System.Drawing.Point(452, 208);
            this.BTN_SALIR.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(130, 37);
            this.BTN_SALIR.TabIndex = 5;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_usuario.Location = new System.Drawing.Point(191, 55);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(272, 24);
            this.txt_usuario.TabIndex = 6;
            this.txt_usuario.Text = "Usuario";
            this.txt_usuario.Click += new System.EventHandler(this.Txt_usuario_Click);
            // 
            // Txt_pass
            // 
            this.Txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_pass.Location = new System.Drawing.Point(191, 97);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.Size = new System.Drawing.Size(272, 24);
            this.Txt_pass.TabIndex = 7;
            this.Txt_pass.Text = "Contraceña";
            this.Txt_pass.Click += new System.EventHandler(this.Txt_pass_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(638, 262);
            this.Controls.Add(this.Txt_pass);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.control);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel control;
        private BunifuDragControl bunifuDragControl2;
        private BunifuThinButton BTN_INGRESAR;
        private BunifuThinButton BTN_SALIR;
        private BunifuCustomLabel HORA;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.TextBox txt_usuario;
        private BunifuCustomLabel bunifuCustomLabel1;
    }
}