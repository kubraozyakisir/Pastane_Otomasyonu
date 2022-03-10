namespace Pastane_Projesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üRÜNLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATIŞLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üRÜNLERToolStripMenuItem,
            this.sATIŞLARToolStripMenuItem,
            this.mÜŞTERİLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üRÜNLERToolStripMenuItem
            // 
            this.üRÜNLERToolStripMenuItem.Name = "üRÜNLERToolStripMenuItem";
            this.üRÜNLERToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.üRÜNLERToolStripMenuItem.Text = "ÜRÜNLER";
            this.üRÜNLERToolStripMenuItem.Click += new System.EventHandler(this.üRÜNLERToolStripMenuItem_Click);
            // 
            // sATIŞLARToolStripMenuItem
            // 
            this.sATIŞLARToolStripMenuItem.Name = "sATIŞLARToolStripMenuItem";
            this.sATIŞLARToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.sATIŞLARToolStripMenuItem.Text = "SATIŞLAR";
            this.sATIŞLARToolStripMenuItem.Click += new System.EventHandler(this.sATIŞLARToolStripMenuItem_Click);
            // 
            // mÜŞTERİLERToolStripMenuItem
            // 
            this.mÜŞTERİLERToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mÜŞTERİLERToolStripMenuItem.Name = "mÜŞTERİLERToolStripMenuItem";
            this.mÜŞTERİLERToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.mÜŞTERİLERToolStripMenuItem.Text = "MÜŞTERİLER";
            this.mÜŞTERİLERToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİLERToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(241, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "GİRİŞ ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATIŞLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİLERToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

