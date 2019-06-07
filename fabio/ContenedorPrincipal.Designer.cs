using Bunifu.Framework.UI;

namespace fabio
{
    partial class ContenedorPrincipal
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
            this.PNL_BarraControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNL_Contenedor = new System.Windows.Forms.Panel();
            this.PNL_Modulos = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_BarraControl
            // 
            this.PNL_BarraControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.PNL_BarraControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_BarraControl.ForeColor = System.Drawing.Color.MediumBlue;
            this.PNL_BarraControl.Location = new System.Drawing.Point(0, 0);
            this.PNL_BarraControl.Name = "PNL_BarraControl";
            this.PNL_BarraControl.Size = new System.Drawing.Size(800, 35);
            this.PNL_BarraControl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PNL_Contenedor);
            this.panel1.Controls.Add(this.PNL_Modulos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 415);
            this.panel1.TabIndex = 2;
            // 
            // PNL_Contenedor
            // 
            this.PNL_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Contenedor.Location = new System.Drawing.Point(200, 0);
            this.PNL_Contenedor.Name = "PNL_Contenedor";
            this.PNL_Contenedor.Size = new System.Drawing.Size(600, 415);
            this.PNL_Contenedor.TabIndex = 1;
            // 
            // PNL_Modulos
            // 
            this.PNL_Modulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PNL_Modulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_Modulos.Location = new System.Drawing.Point(0, 0);
            this.PNL_Modulos.Name = "PNL_Modulos";
            this.PNL_Modulos.Size = new System.Drawing.Size(200, 415);
            this.PNL_Modulos.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PNL_BarraControl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ContenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PNL_BarraControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContenedorPrincipal";
            this.Text = "ContenedorPrincipal";
            this.Load += new System.EventHandler(this.ContenedorPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel PNL_BarraControl;
       
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PNL_Contenedor;
        private System.Windows.Forms.Panel PNL_Modulos;
        private BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}