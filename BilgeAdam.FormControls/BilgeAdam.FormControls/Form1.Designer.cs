namespace BilgeAdam.FormControls
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.stsMenu = new System.Windows.Forms.StatusStrip();
            this.lblPointerLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yüklenmedi";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            // 
            // cmbCities
            // 
            this.cmbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(113, 20);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(190, 21);
            this.cmbCities.TabIndex = 1;
            this.cmbCities.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            // 
            // stsMenu
            // 
            this.stsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPointerLocation});
            this.stsMenu.Location = new System.Drawing.Point(0, 149);
            this.stsMenu.Name = "stsMenu";
            this.stsMenu.Size = new System.Drawing.Size(325, 22);
            this.stsMenu.TabIndex = 2;
            this.stsMenu.Text = "statusStrip1";
            // 
            // lblPointerLocation
            // 
            this.lblPointerLocation.Name = "lblPointerLocation";
            this.lblPointerLocation.Size = new System.Drawing.Size(139, 17);
            this.lblPointerLocation.Text = "Pointer Location : NotSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 171);
            this.Controls.Add(this.stsMenu);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Şehir Bilgisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.stsMenu.ResumeLayout(false);
            this.stsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.StatusStrip stsMenu;
        private System.Windows.Forms.ToolStripStatusLabel lblPointerLocation;
    }
}

