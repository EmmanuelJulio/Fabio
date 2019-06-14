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
            this.List_user = new System.Windows.Forms.ListBox();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bulonera2DataSet = new fabio.bulonera2DataSet();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new fabio.bulonera2DataSetTableAdapters.USUARIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bulonera2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // List_user
            // 
            this.List_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.List_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List_user.Dock = System.Windows.Forms.DockStyle.Left;
            this.List_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_user.ForeColor = System.Drawing.Color.Silver;
            this.List_user.FormattingEnabled = true;
            this.List_user.ItemHeight = 17;
            this.List_user.Location = new System.Drawing.Point(0, 24);
            this.List_user.Name = "List_user";
            this.List_user.Size = new System.Drawing.Size(120, 426);
            this.List_user.TabIndex = 1;
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_apellido.ForeColor = System.Drawing.Color.Silver;
            this.Txt_apellido.Location = new System.Drawing.Point(169, 114);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(284, 20);
            this.Txt_apellido.TabIndex = 12;
            this.Txt_apellido.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.Silver;
            this.txt_Nombre.Location = new System.Drawing.Point(169, 65);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(284, 20);
            this.txt_Nombre.TabIndex = 11;
            this.txt_Nombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(169, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Contraseña";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.Color.Silver;
            this.Txt_Usuario.Location = new System.Drawing.Point(169, 154);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(284, 20);
            this.Txt_Usuario.TabIndex = 13;
            this.Txt_Usuario.Text = "Nombre de usuario ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.comboBox1.DataSource = this.uSUARIOSBindingSource;
            this.comboBox1.DisplayMember = "nombre_usuario";
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 246);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Usuario";
            this.comboBox1.ValueMember = "nombre_usuario";
            // 
            // bulonera2DataSet
            // 
            this.bulonera2DataSet.DataSetName = "bulonera2DataSet";
            this.bulonera2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.bulonera2DataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Txt_apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.List_user);
            this.Name = "frm_AddUser";
            this.Text = "frm_AddUser";
            this.Load += new System.EventHandler(this.Frm_AddUser_Load);
            this.Controls.SetChildIndex(this.List_user, 0);
            this.Controls.SetChildIndex(this.txt_Nombre, 0);
            this.Controls.SetChildIndex(this.Txt_apellido, 0);
            this.Controls.SetChildIndex(this.Txt_Usuario, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bulonera2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_user;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private bulonera2DataSet bulonera2DataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private bulonera2DataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
    }
}