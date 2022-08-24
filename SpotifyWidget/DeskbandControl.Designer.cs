namespace SpotifyWidget
{
    partial class DeskbandControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeskbandControl));
            this.trackTitleLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackTitleLabel
            // 
            this.trackTitleLabel.AutoEllipsis = true;
            this.trackTitleLabel.AutoSize = true;
            this.trackTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.trackTitleLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackTitleLabel.ForeColor = System.Drawing.Color.White;
            this.trackTitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trackTitleLabel.Location = new System.Drawing.Point(130, 0);
            this.trackTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.trackTitleLabel.MaximumSize = new System.Drawing.Size(177, 23);
            this.trackTitleLabel.MinimumSize = new System.Drawing.Size(0, 23);
            this.trackTitleLabel.Name = "trackTitleLabel";
            this.trackTitleLabel.Size = new System.Drawing.Size(70, 23);
            this.trackTitleLabel.TabIndex = 0;
            this.trackTitleLabel.Text = "Initializing...";
            this.trackTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trackTitleLabel.UseMnemonic = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // iconBox
            // 
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(107, 0);
            this.iconBox.Margin = new System.Windows.Forms.Padding(0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(23, 23);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconBox);
            this.panel1.Controls.Add(this.trackTitleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 2;
            // 
            // DeskbandControl
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeskbandControl";
            this.Size = new System.Drawing.Size(200, 23);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label trackTitleLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Panel panel1;
    }
}
