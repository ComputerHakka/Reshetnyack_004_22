
namespace LastFlyCompany
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.lHelpCaption = new System.Windows.Forms.Label();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lHelpCaption
            // 
            this.lHelpCaption.AutoSize = true;
            this.lHelpCaption.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHelpCaption.Location = new System.Drawing.Point(217, 17);
            this.lHelpCaption.Name = "lHelpCaption";
            this.lHelpCaption.Size = new System.Drawing.Size(78, 18);
            this.lHelpCaption.TabIndex = 0;
            this.lHelpCaption.Text = "Справка";
            // 
            // rtbHelp
            // 
            this.rtbHelp.BackColor = System.Drawing.Color.LightCyan;
            this.rtbHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbHelp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbHelp.Location = new System.Drawing.Point(33, 46);
            this.rtbHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(434, 173);
            this.rtbHelp.TabIndex = 1;
            this.rtbHelp.TabStop = false;
            this.rtbHelp.Text = resources.GetString("rtbHelp.Text");
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(196, 223);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lDeveloper
            // 
            this.lDeveloper.AutoSize = true;
            this.lDeveloper.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lDeveloper.Location = new System.Drawing.Point(33, 188);
            this.lDeveloper.Name = "lDeveloper";
            this.lDeveloper.Size = new System.Drawing.Size(335, 17);
            this.lDeveloper.TabIndex = 3;
            this.lDeveloper.Text = "Разработчик программы: Решетняк Вячеслав";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(515, 276);
            this.Controls.Add(this.lDeveloper);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbHelp);
            this.Controls.Add(this.lHelpCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(531, 315);
            this.MinimumSize = new System.Drawing.Size(531, 315);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHelpCaption;
        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lDeveloper;
    }
}