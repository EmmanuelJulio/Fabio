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
            this.components = new System.ComponentModel.Container();
            this.pnl_Permisos = new System.Windows.Forms.Panel();
            this.btn_guardarPermisos = new System.Windows.Forms.Button();
            this.Modulos = new System.Windows.Forms.CheckedListBox();
            this.mODULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_UserDat = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.pnl_Permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mODULOSBindingSource)).BeginInit();
            this.pnl_UserDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Permisos
            // 
            this.pnl_Permisos.Controls.Add(this.btn_guardarPermisos);
            this.pnl_Permisos.Controls.Add(this.Modulos);
            this.pnl_Permisos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Permisos.Location = new System.Drawing.Point(388, 26);
            this.pnl_Permisos.Name = "pnl_Permisos";
            this.pnl_Permisos.Size = new System.Drawing.Size(494, 600);
            this.pnl_Permisos.TabIndex = 19;
            // 
            // btn_guardarPermisos
            // 
            this.btn_guardarPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btn_guardarPermisos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btn_guardarPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_guardarPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btn_guardarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarPermisos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_guardarPermisos.Location = new System.Drawing.Point(236, 285);
            this.btn_guardarPermisos.Name = "btn_guardarPermisos";
            this.btn_guardarPermisos.Size = new System.Drawing.Size(183, 40);
            this.btn_guardarPermisos.TabIndex = 21;
            this.btn_guardarPermisos.Text = "Guardar";
            this.btn_guardarPermisos.UseVisualStyleBackColor = false;
            // 
            // Modulos
            // 
            this.Modulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Modulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Modulos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mODULOSBindingSource, "NOMBRE_MOD", true));
            this.Modulos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Modulos.ForeColor = System.Drawing.Color.Silver;
            this.Modulos.FormattingEnabled = true;
            this.Modulos.Location = new System.Drawing.Point(0, 0);
            this.Modulos.Name = "Modulos";
            this.Modulos.Size = new System.Drawing.Size(195, 600);
            this.Modulos.TabIndex = 0;
            // 
            // mODULOSBindingSource
            // 
            this.mODULOSBindingSource.DataMember = "MODULOS";
            // 
            // pnl_UserDat
            // 
            this.pnl_UserDat.Controls.Add(this.btnlogin);
            this.pnl_UserDat.Controls.Add(this.txt_pass2);
            this.pnl_UserDat.Controls.Add(this.comboBox1);
            this.pnl_UserDat.Controls.Add(this.txt_pass);
            this.pnl_UserDat.Controls.Add(this.Txt_Usuario);
            this.pnl_UserDat.Controls.Add(this.Txt_apellido);
            this.pnl_UserDat.Controls.Add(this.txt_Nombre);
            this.pnl_UserDat.Controls.Add(this.shapeContainer1);
            this.pnl_UserDat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_UserDat.Location = new System.Drawing.Point(0, 26);
            this.pnl_UserDat.Name = "pnl_UserDat";
            this.pnl_UserDat.Size = new System.Drawing.Size(342, 600);
            this.pnl_UserDat.TabIndex = 20;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnlogin.Location = new System.Drawing.Point(68, 285);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(173, 40);
            this.btnlogin.TabIndex = 25;
            this.btnlogin.Text = "Guardar";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // txt_pass2
            // 
            this.txt_pass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_pass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass2.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass2.Location = new System.Drawing.Point(16, 187);
            this.txt_pass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.Size = new System.Drawing.Size(290, 20);
            this.txt_pass2.TabIndex = 24;
            this.txt_pass2.Text = "Repetir contraceña";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.comboBox1.DisplayMember = "nombre_usuario";
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 231);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Sector";
            this.comboBox1.ValueMember = "nombre_usuario";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass.Location = new System.Drawing.Point(13, 146);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(290, 20);
            this.txt_pass.TabIndex = 22;
            this.txt_pass.Text = "Contraseña";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.Txt_Usuario.Location = new System.Drawing.Point(13, 106);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(290, 20);
            this.Txt_Usuario.TabIndex = 21;
            this.Txt_Usuario.Text = "Nombre de usuario ";
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.ForeColor = System.Drawing.Color.Silver;
            this.Txt_apellido.Location = new System.Drawing.Point(13, 67);
            this.Txt_apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(290, 20);
            this.Txt_apellido.TabIndex = 20;
            this.Txt_apellido.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.Silver;
            this.txt_Nombre.Location = new System.Drawing.Point(13, 27);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(290, 20);
            this.txt_Nombre.TabIndex = 19;
            this.txt_Nombre.Text = "Nombre";
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
            this.shapeContainer1.Size = new System.Drawing.Size(342, 600);
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
            this.lineShape5.X1 = 6;
            this.lineShape5.X2 = 288;
            this.lineShape5.Y1 = 213;
            this.lineShape5.Y2 = 213;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape4.Tag = "0; 150; 240";
            this.lineShape4.X1 = 8;
            this.lineShape4.X2 = 290;
            this.lineShape4.Y1 = 171;
            this.lineShape4.Y2 = 171;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape3.Tag = "0; 150; 240";
            this.lineShape3.X1 = 7;
            this.lineShape3.X2 = 289;
            this.lineShape3.Y1 = 134;
            this.lineShape3.Y2 = 134;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape2.Tag = "0; 150; 240";
            this.lineShape2.X1 = 7;
            this.lineShape2.X2 = 289;
            this.lineShape2.Y1 = 95;
            this.lineShape2.Y2 = 95;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.lineShape1.Tag = "0; 150; 240";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 290;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 626);
            this.Controls.Add(this.pnl_UserDat);
            this.Controls.Add(this.pnl_Permisos);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frm_AddUser";
            this.Text = "frm_AddUser";
            this.Controls.SetChildIndex(this.pnl_Permisos, 0);
            this.Controls.SetChildIndex(this.pnl_UserDat, 0);
            this.pnl_Permisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mODULOSBindingSource)).EndInit();
            this.pnl_UserDat.ResumeLayout(false);
            this.pnl_UserDat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Permisos;
        private System.Windows.Forms.Button btn_guardarPermisos;
        private System.Windows.Forms.CheckedListBox Modulos;
        
        private System.Windows.Forms.BindingSource mODULOSBindingSource;
        
        private System.Windows.Forms.Panel pnl_UserDat;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}