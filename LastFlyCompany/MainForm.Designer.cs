
namespace LastFlyCompany
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnProgramInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lLastFlyTitle = new System.Windows.Forms.Label();
            this.pbMainLogo = new System.Windows.Forms.PictureBox();
            this.btnInfoAboutFirm = new System.Windows.Forms.Button();
            this.lSlogan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTickets.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTickets.Location = new System.Drawing.Point(52, 164);
            this.btnTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(149, 38);
            this.btnTickets.TabIndex = 0;
            this.btnTickets.TabStop = false;
            this.btnTickets.Text = "Билеты";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnProgramInfo
            // 
            this.btnProgramInfo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnProgramInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramInfo.Location = new System.Drawing.Point(685, 379);
            this.btnProgramInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProgramInfo.Name = "btnProgramInfo";
            this.btnProgramInfo.Size = new System.Drawing.Size(31, 22);
            this.btnProgramInfo.TabIndex = 1;
            this.btnProgramInfo.TabStop = false;
            this.btnProgramInfo.Text = "?";
            this.btnProgramInfo.UseVisualStyleBackColor = false;
            this.btnProgramInfo.Click += new System.EventHandler(this.btnProgramInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(52, 290);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lLastFlyTitle
            // 
            this.lLastFlyTitle.AutoSize = true;
            this.lLastFlyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lLastFlyTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lLastFlyTitle.Location = new System.Drawing.Point(34, 64);
            this.lLastFlyTitle.Name = "lLastFlyTitle";
            this.lLastFlyTitle.Size = new System.Drawing.Size(156, 57);
            this.lLastFlyTitle.TabIndex = 3;
            this.lLastFlyTitle.Text = "LastFly";
            // 
            // pbMainLogo
            // 
            this.pbMainLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbMainLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbMainLogo.Image")));
            this.pbMainLogo.Location = new System.Drawing.Point(175, 48);
            this.pbMainLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMainLogo.Name = "pbMainLogo";
            this.pbMainLogo.Size = new System.Drawing.Size(68, 68);
            this.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainLogo.TabIndex = 4;
            this.pbMainLogo.TabStop = false;
            // 
            // btnInfoAboutFirm
            // 
            this.btnInfoAboutFirm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInfoAboutFirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoAboutFirm.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfoAboutFirm.Location = new System.Drawing.Point(52, 228);
            this.btnInfoAboutFirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfoAboutFirm.Name = "btnInfoAboutFirm";
            this.btnInfoAboutFirm.Size = new System.Drawing.Size(149, 38);
            this.btnInfoAboutFirm.TabIndex = 5;
            this.btnInfoAboutFirm.TabStop = false;
            this.btnInfoAboutFirm.Text = "О нас";
            this.btnInfoAboutFirm.UseVisualStyleBackColor = false;
            this.btnInfoAboutFirm.Click += new System.EventHandler(this.btnInfoAboutFirm_Click);
            // 
            // lSlogan
            // 
            this.lSlogan.AutoSize = true;
            this.lSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lSlogan.Font = new System.Drawing.Font("Candara", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lSlogan.Location = new System.Drawing.Point(121, 118);
            this.lSlogan.Name = "lSlogan";
            this.lSlogan.Size = new System.Drawing.Size(174, 18);
            this.lSlogan.TabIndex = 6;
            this.lSlogan.Text = "Мы с вами до конца пути";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.lSlogan);
            this.Controls.Add(this.btnInfoAboutFirm);
            this.Controls.Add(this.pbMainLogo);
            this.Controls.Add(this.lLastFlyTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProgramInfo);
            this.Controls.Add(this.btnTickets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(744, 451);
            this.MinimumSize = new System.Drawing.Size(744, 451);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnProgramInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lLastFlyTitle;
        private System.Windows.Forms.PictureBox pbMainLogo;
        private System.Windows.Forms.Button btnInfoAboutFirm;
        private System.Windows.Forms.Label lSlogan;
    }
}

