namespace fabio.Configuraciones.UserConfig
{
    partial class frm_AddUser
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
            this.pnl_UserDat = new System.Windows.Forms.Panel();
            this.combo_seccion = new System.Windows.Forms.ComboBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.pnl_UserDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_nav
            // 
            this.pnl_nav.Size = new System.Drawing.Size(882, 22);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(798, 0);
            this.btn_MinimizeWindow.Size = new System.Drawing.Size(21, 22);
            // 
            // btn_MaximiseWindow
            // 
            this.btn_MaximiseWindow.Location = new System.Drawing.Point(819, 0);
            this.btn_MaximiseWindow.Size = new System.Drawing.Size(21, 22);
            // 
            // btn_normalWindow
            // 
            this.btn_normalWindow.Location = new System.Drawing.Point(840, 0);
            this.btn_normalWindow.Size = new System.Drawing.Size(21, 22);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Location = new System.Drawing.Point(861, 0);
            this.btn_CloseForm.Size = new System.Drawing.Size(21, 22);
            // 
            // pnl_UserDat
            // 
            this.pnl_UserDat.Controls.Add(this.combo_seccion);
            this.pnl_UserDat.Controls.Add(this.btnlogin);
            this.pnl_UserDat.Controls.Add(this.txt_pass2);
            this.pnl_UserDat.Controls.Add(this.txt_pass);
            this.pnl_UserDat.Controls.Add(this.Txt_Usuario);
            this.pnl_UserDat.Controls.Add(this.Txt_apellido);
            this.pnl_UserDat.Controls.Add(this.txt_Nombre);
            this.pnl_UserDat.Controls.Add(this.shapeContainer1);
            this.pnl_UserDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_UserDat.Location = new System.Drawing.Point(0, 22);
            this.pnl_UserDat.Name = "pnl_UserDat";
            this.pnl_UserDat.Size = new System.Drawing.Size(882, 541);
            this.pnl_UserDat.TabIndex = 20;
            // 
            // combo_seccion
            // 
            this.combo_seccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.combo_seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_seccion.ForeColor = System.Drawing.Color.Silver;
            this.combo_seccion.FormattingEnabled = true;
            this.combo_seccion.Location = new System.Drawing.Point(305, 256);
            this.combo_seccion.Name = "combo_seccion";
            this.combo_seccion.Size = new System.Drawing.Size(283, 28);
            this.combo_seccion.TabIndex = 27;
            this.combo_seccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Nombre_KeyDown);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnlogin.Location = new System.Drawing.Point(367, 299);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(173, 36);
            this.btnlogin.TabIndex = 25;
            this.btnlogin.Text = "Guardar";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // txt_pass2
            // 
            this.txt_pass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_pass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass2.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass2.Location = new System.Drawing.Point(306, 215);
            this.txt_pass2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.Size = new System.Drawing.Size(290, 19);
            this.txt_pass2.TabIndex = 23;
            this.txt_pass2.Text = "Repetir contraceña";
            this.txt_pass2.Click += new System.EventHandler(this.Txt_Nombre_Click);
            this.txt_pass2.Enter += new System.EventHandler(this.Txt_Nombre_Enter);
            this.txt_pass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NombreUs_KeyDown);
            this.txt_pass2.Leave += new System.EventHandler(this.Txt_Nombre_Leave);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass.Location = new System.Drawing.Point(307, 179);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(290, 19);
            this.txt_pass.TabIndex = 22;
            this.txt_pass.Text = "Contraseña";
            this.txt_pass.Click += new System.EventHandler(this.Txt_Nombre_Click);
            this.txt_pass.Enter += new System.EventHandler(this.Txt_Nombre_Enter);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NombreUs_KeyDown);
            this.txt_pass.Leave += new System.EventHandler(this.Txt_Nombre_Leave);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.Txt_Usuario.Location = new System.Drawing.Point(308, 142);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(290, 19);
            this.Txt_Usuario.TabIndex = 21;
            this.Txt_Usuario.Text = "Nombre de usuario ";
            this.Txt_Usuario.Click += new System.EventHandler(this.Txt_Nombre_Click);
            this.Txt_Usuario.Enter += new System.EventHandler(this.Txt_Nombre_Enter);
            this.Txt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NombreUs_KeyDown);
            this.Txt_Usuario.Leave += new System.EventHandler(this.Txt_Nombre_Leave);
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.ForeColor = System.Drawing.Color.Silver;
            this.Txt_apellido.Location = new System.Drawing.Point(307, 105);
            this.Txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(290, 19);
            this.Txt_apellido.TabIndex = 20;
            this.Txt_apellido.Text = "Apellido";
            this.Txt_apellido.Click += new System.EventHandler(this.Txt_Nombre_Click);
            this.Txt_apellido.Enter += new System.EventHandler(this.Txt_Nombre_Enter);
            this.Txt_apellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Nombre_KeyDown);
            this.Txt_apellido.Leave += new System.EventHandler(this.Txt_Nombre_Leave);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.Silver;
            this.txt_Nombre.Location = new System.Drawing.Point(308, 68);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(290, 19);
            this.txt_Nombre.TabIndex = 19;
            this.txt_Nombre.Text = "Nombre";
            this.txt_Nombre.Click += new System.EventHandler(this.Txt_Nombre_Click);
            this.txt_Nombre.Enter += new System.EventHandler(this.Txt_Nombre_Enter);
            this.txt_Nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Nombre_KeyDown);
            this.txt_Nombre.Leave += new System.EventHandler(this.Txt_Nombre_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(882, 541);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape5.Tag = "0; 150; 240";
            this.lineShape5.X1 = 301;
            this.lineShape5.X2 = 583;
            this.lineShape5.Y1 = 237;
            this.lineShape5.Y2 = 237;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape4.Tag = "0; 150; 240";
            this.lineShape4.X1 = 301;
            this.lineShape4.X2 = 583;
            this.lineShape4.Y1 = 200;
            this.lineShape4.Y2 = 200;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape3.Tag = "0; 150; 240";
            this.lineShape3.X1 = 301;
            this.lineShape3.X2 = 583;
            this.lineShape3.Y1 = 163;
            this.lineShape3.Y2 = 163;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape2.Tag = "0; 150; 240";
            this.lineShape2.X1 = 301;
            this.lineShape2.X2 = 583;
            this.lineShape2.Y1 = 126;
            this.lineShape2.Y2 = 126;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape1.Tag = "0; 150; 240";
            this.lineShape1.X1 = 301;
            this.lineShape1.X2 = 583;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 89;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(115, 18);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Agregar Usuario";
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 563);
            this.Controls.Add(this.pnl_UserDat);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frm_AddUser";
            this.Text = "frm_AddUser";
            this.Load += new System.EventHandler(this.Frm_AddUser_Load);
            this.Controls.SetChildIndex(this.pnl_nav, 0);
            this.Controls.SetChildIndex(this.pnl_UserDat, 0);
            this.pnl_nav.ResumeLayout(false);
            this.pnl_nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.pnl_UserDat.ResumeLayout(false);
            this.pnl_UserDat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
      //  private System.Windows.Forms.BindingSource mODULOSBindingSource;
        
        private System.Windows.Forms.Panel pnl_UserDat;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox combo_seccion;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}