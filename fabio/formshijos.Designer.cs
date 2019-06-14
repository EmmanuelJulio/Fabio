namespace fabio
{
    partial class formshijos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formshijos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.btn_MaximiseWindow = new System.Windows.Forms.PictureBox();
            this.btn_normalWindow = new System.Windows.Forms.PictureBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_modulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.pnl_nav.Controls.Add(this.lbl_modulo);
            this.pnl_nav.Controls.Add(this.btn_MinimizeWindow);
            this.pnl_nav.Controls.Add(this.btn_MaximiseWindow);
            this.pnl_nav.Controls.Add(this.btn_normalWindow);
            this.pnl_nav.Controls.Add(this.btn_CloseForm);
            this.pnl_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_nav.Location = new System.Drawing.Point(0, 0);
            this.pnl_nav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(1200, 26);
            this.pnl_nav.TabIndex = 0;
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_MinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_MinimizeWindow.Image")));
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(1116, 0);
            this.btn_MinimizeWindow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_MinimizeWindow.Name = "btn_MinimizeWindow";
            this.btn_MinimizeWindow.Size = new System.Drawing.Size(21, 26);
            this.btn_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_MinimizeWindow.TabIndex = 18;
            this.btn_MinimizeWindow.TabStop = false;
            this.btn_MinimizeWindow.Click += new System.EventHandler(this.Btn_MinimizeWindow_Click);
            // 
            // btn_MaximiseWindow
            // 
            this.btn_MaximiseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_MaximiseWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MaximiseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_MaximiseWindow.Image")));
            this.btn_MaximiseWindow.Location = new System.Drawing.Point(1137, 0);
            this.btn_MaximiseWindow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_MaximiseWindow.Name = "btn_MaximiseWindow";
            this.btn_MaximiseWindow.Size = new System.Drawing.Size(21, 26);
            this.btn_MaximiseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_MaximiseWindow.TabIndex = 17;
            this.btn_MaximiseWindow.TabStop = false;
            this.btn_MaximiseWindow.Visible = false;
            this.btn_MaximiseWindow.Click += new System.EventHandler(this.Btn_MaximiseWindow_Click);
            // 
            // btn_normalWindow
            // 
            this.btn_normalWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_normalWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_normalWindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_normalWindow.Image")));
            this.btn_normalWindow.Location = new System.Drawing.Point(1158, 0);
            this.btn_normalWindow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_normalWindow.Name = "btn_normalWindow";
            this.btn_normalWindow.Size = new System.Drawing.Size(21, 26);
            this.btn_normalWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_normalWindow.TabIndex = 16;
            this.btn_normalWindow.TabStop = false;
            this.btn_normalWindow.Click += new System.EventHandler(this.Btn_normalWindow_Click);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseForm.Image")));
            this.btn_CloseForm.Location = new System.Drawing.Point(1179, 0);
            this.btn_CloseForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(21, 26);
            this.btn_CloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_CloseForm.TabIndex = 15;
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.Btn_CloseForm_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_nav;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbl_modulo
            // 
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modulo.ForeColor = System.Drawing.Color.Silver;
            this.lbl_modulo.Location = new System.Drawing.Point(4, 6);
            this.lbl_modulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(116, 17);
            this.lbl_modulo.TabIndex = 20;
            this.lbl_modulo.Text = "Modulo Principal";
            // 
            // formshijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnl_nav);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formshijos";
            this.Text = "formshijos";
            this.Load += new System.EventHandler(this.Formshijos_Load);
            this.pnl_nav.ResumeLayout(false);
            this.pnl_nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.PictureBox btn_MinimizeWindow;
        private System.Windows.Forms.PictureBox btn_MaximiseWindow;
        private System.Windows.Forms.PictureBox btn_normalWindow;
        private System.Windows.Forms.PictureBox btn_CloseForm;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_modulo;
    }
}