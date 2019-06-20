namespace fabio.Configuraciones.UserConfig
{
    partial class frm_asignacion
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).BeginInit();
            this.pnl_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(1116, 0);
            // 
            // btn_MaximiseWindow
            // 
            this.btn_MaximiseWindow.Location = new System.Drawing.Point(1137, 0);
            // 
            // btn_normalWindow
            // 
            this.btn_normalWindow.Location = new System.Drawing.Point(1158, 0);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Location = new System.Drawing.Point(1179, 0);
            // 
            // pnl_nav
            // 
            this.pnl_nav.Size = new System.Drawing.Size(1200, 23);
            // 
            // btn_desacoplar
            // 
            this.btn_desacoplar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_desacoplar.Location = new System.Drawing.Point(974, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(249, 227);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frm_asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_asignacion";
            this.Text = "frm_asignacion";
            this.Load += new System.EventHandler(this.Frm_asignacion_Load);
            this.Controls.SetChildIndex(this.pnl_nav, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btn_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MaximiseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            this.pnl_nav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}