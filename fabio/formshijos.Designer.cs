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
            this.lbl_modulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.btn_MaximiseWindow = new System.Windows.Forms.PictureBox();
            this.btn_normalWindow = new System.Windows.Forms.PictureBox();
            this.btn_CloseForm = new System.Windows.Forms.PictureBox();
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
            resources.ApplyResources(this.pnl_nav, "pnl_nav");
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.pnl_nav.Controls.Add(this.lbl_modulo);
            this.pnl_nav.Controls.Add(this.btn_MinimizeWindow);
            this.pnl_nav.Controls.Add(this.btn_MaximiseWindow);
            this.pnl_nav.Controls.Add(this.btn_normalWindow);
            this.pnl_nav.Controls.Add(this.btn_CloseForm);
            this.pnl_nav.Name = "pnl_nav";
            // 
            // lbl_modulo
            // 
            resources.ApplyResources(this.lbl_modulo, "lbl_modulo");
            this.lbl_modulo.ForeColor = System.Drawing.Color.Silver;
            this.lbl_modulo.Name = "lbl_modulo";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_nav;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_MinimizeWindow
            // 
            resources.ApplyResources(this.btn_MinimizeWindow, "btn_MinimizeWindow");
            this.btn_MinimizeWindow.Name = "btn_MinimizeWindow";
            this.btn_MinimizeWindow.TabStop = false;
            this.btn_MinimizeWindow.Click += new System.EventHandler(this.Btn_MinimizeWindow_Click);
            // 
            // btn_MaximiseWindow
            // 
            resources.ApplyResources(this.btn_MaximiseWindow, "btn_MaximiseWindow");
            this.btn_MaximiseWindow.Name = "btn_MaximiseWindow";
            this.btn_MaximiseWindow.TabStop = false;
            this.btn_MaximiseWindow.Click += new System.EventHandler(this.Btn_MaximiseWindow_Click);
            // 
            // btn_normalWindow
            // 
            resources.ApplyResources(this.btn_normalWindow, "btn_normalWindow");
            this.btn_normalWindow.Name = "btn_normalWindow";
            this.btn_normalWindow.TabStop = false;
            this.btn_normalWindow.Click += new System.EventHandler(this.Btn_normalWindow_Click);
            // 
            // btn_CloseForm
            // 
            resources.ApplyResources(this.btn_CloseForm, "btn_CloseForm");
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.TabStop = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.Btn_CloseForm_Click);
            // 
            // formshijos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.pnl_nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formshijos";
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
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_modulo;
        public System.Windows.Forms.Panel pnl_nav;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.PictureBox btn_MinimizeWindow;
        public System.Windows.Forms.PictureBox btn_MaximiseWindow;
        public System.Windows.Forms.PictureBox btn_normalWindow;
        public System.Windows.Forms.PictureBox btn_CloseForm;
    }
}