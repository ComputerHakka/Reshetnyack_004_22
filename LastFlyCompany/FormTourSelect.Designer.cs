
namespace LastFlyCompany
{
    partial class FormTourSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTourSelect));
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.gbClassOfFlight = new System.Windows.Forms.GroupBox();
            this.rbFirstClass = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbComfort = new System.Windows.Forms.RadioButton();
            this.rbEconom = new System.Windows.Forms.RadioButton();
            this.lDepartureDate = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.btnToPayment = new System.Windows.Forms.Button();
            this.lCaption = new System.Windows.Forms.Label();
            this.lTo = new System.Windows.Forms.Label();
            this.lFrom = new System.Windows.Forms.Label();
            this.cbReturnDate = new System.Windows.Forms.CheckBox();
            this.gbClassOfFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(28, 70);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.PlaceholderText = "Откуда";
            this.tbFrom.Size = new System.Drawing.Size(219, 23);
            this.tbFrom.TabIndex = 0;
            this.tbFrom.TabStop = false;
            this.tbFrom.TextChanged += new System.EventHandler(this.tbFrom_TextChanged);
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(394, 70);
            this.dtpDepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDepartureDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpDepartureDate.MinDate = new System.DateTime(2021, 5, 6, 18, 25, 29, 0);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(107, 23);
            this.dtpDepartureDate.TabIndex = 2;
            this.dtpDepartureDate.TabStop = false;
            this.dtpDepartureDate.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpDepartureDate_ValueChanged);
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(28, 118);
            this.comboBoxCountries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(219, 23);
            this.comboBoxCountries.TabIndex = 3;
            this.comboBoxCountries.TabStop = false;
            this.comboBoxCountries.Text = "Куда";
            this.comboBoxCountries.SelectedValueChanged += new System.EventHandler(this.comboBoxCountries_SelectedValueChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(394, 118);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReturnDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpReturnDate.MinDate = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(107, 23);
            this.dtpReturnDate.TabIndex = 4;
            this.dtpReturnDate.TabStop = false;
            this.dtpReturnDate.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            this.dtpReturnDate.Visible = false;
            // 
            // gbClassOfFlight
            // 
            this.gbClassOfFlight.BackColor = System.Drawing.Color.Transparent;
            this.gbClassOfFlight.Controls.Add(this.rbFirstClass);
            this.gbClassOfFlight.Controls.Add(this.rbBusiness);
            this.gbClassOfFlight.Controls.Add(this.rbComfort);
            this.gbClassOfFlight.Controls.Add(this.rbEconom);
            this.gbClassOfFlight.Location = new System.Drawing.Point(28, 143);
            this.gbClassOfFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClassOfFlight.Name = "gbClassOfFlight";
            this.gbClassOfFlight.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbClassOfFlight.Size = new System.Drawing.Size(279, 98);
            this.gbClassOfFlight.TabIndex = 5;
            this.gbClassOfFlight.TabStop = false;
            // 
            // rbFirstClass
            // 
            this.rbFirstClass.AutoSize = true;
            this.rbFirstClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFirstClass.Location = new System.Drawing.Point(147, 59);
            this.rbFirstClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFirstClass.Name = "rbFirstClass";
            this.rbFirstClass.Size = new System.Drawing.Size(103, 19);
            this.rbFirstClass.TabIndex = 3;
            this.rbFirstClass.Text = "Первый класс";
            this.rbFirstClass.UseVisualStyleBackColor = true;
            this.rbFirstClass.CheckedChanged += new System.EventHandler(this.rbFirstClass_CheckedChanged);
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBusiness.Location = new System.Drawing.Point(147, 20);
            this.rbBusiness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(97, 19);
            this.rbBusiness.TabIndex = 2;
            this.rbBusiness.Text = "Бизнес класс";
            this.rbBusiness.UseVisualStyleBackColor = true;
            this.rbBusiness.CheckedChanged += new System.EventHandler(this.rbBusiness_CheckedChanged);
            // 
            // rbComfort
            // 
            this.rbComfort.AutoSize = true;
            this.rbComfort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbComfort.Location = new System.Drawing.Point(15, 59);
            this.rbComfort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbComfort.Name = "rbComfort";
            this.rbComfort.Size = new System.Drawing.Size(76, 19);
            this.rbComfort.TabIndex = 1;
            this.rbComfort.Text = "Комфорт";
            this.rbComfort.UseVisualStyleBackColor = true;
            this.rbComfort.CheckedChanged += new System.EventHandler(this.rbComfort_CheckedChanged);
            // 
            // rbEconom
            // 
            this.rbEconom.AutoSize = true;
            this.rbEconom.Checked = true;
            this.rbEconom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEconom.Location = new System.Drawing.Point(15, 20);
            this.rbEconom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEconom.Name = "rbEconom";
            this.rbEconom.Size = new System.Drawing.Size(68, 19);
            this.rbEconom.TabIndex = 0;
            this.rbEconom.TabStop = true;
            this.rbEconom.Text = "Эконом";
            this.rbEconom.UseVisualStyleBackColor = true;
            this.rbEconom.CheckedChanged += new System.EventHandler(this.rbEconom_CheckedChanged);
            // 
            // lDepartureDate
            // 
            this.lDepartureDate.AutoSize = true;
            this.lDepartureDate.BackColor = System.Drawing.Color.Transparent;
            this.lDepartureDate.Location = new System.Drawing.Point(304, 73);
            this.lDepartureDate.Name = "lDepartureDate";
            this.lDepartureDate.Size = new System.Drawing.Size(77, 15);
            this.lDepartureDate.TabIndex = 6;
            this.lDepartureDate.Text = "Дата вылета:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(384, 172);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(110, 23);
            this.tbTotalPrice.TabIndex = 8;
            this.tbTotalPrice.TabStop = false;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.BackColor = System.Drawing.Color.Transparent;
            this.lTotal.Location = new System.Drawing.Point(332, 174);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(43, 15);
            this.lTotal.TabIndex = 9;
            this.lTotal.Text = "Итого:";
            // 
            // btnToPayment
            // 
            this.btnToPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToPayment.Location = new System.Drawing.Point(350, 209);
            this.btnToPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToPayment.Name = "btnToPayment";
            this.btnToPayment.Size = new System.Drawing.Size(144, 32);
            this.btnToPayment.TabIndex = 10;
            this.btnToPayment.TabStop = false;
            this.btnToPayment.Text = "Перейти к оплате";
            this.btnToPayment.UseVisualStyleBackColor = true;
            this.btnToPayment.Click += new System.EventHandler(this.btnToPayment_Click);
            // 
            // lCaption
            // 
            this.lCaption.AutoSize = true;
            this.lCaption.BackColor = System.Drawing.Color.Transparent;
            this.lCaption.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCaption.Location = new System.Drawing.Point(171, 18);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(189, 25);
            this.lCaption.TabIndex = 11;
            this.lCaption.Text = "Оформление билета";
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.BackColor = System.Drawing.Color.Transparent;
            this.lTo.Location = new System.Drawing.Point(28, 100);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(35, 15);
            this.lTo.TabIndex = 12;
            this.lTo.Text = "Куда:";
            this.lTo.Visible = false;
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.BackColor = System.Drawing.Color.Transparent;
            this.lFrom.Location = new System.Drawing.Point(28, 53);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(48, 15);
            this.lFrom.TabIndex = 13;
            this.lFrom.Text = "Откуда:";
            this.lFrom.Visible = false;
            // 
            // cbReturnDate
            // 
            this.cbReturnDate.AutoSize = true;
            this.cbReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.cbReturnDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbReturnDate.Location = new System.Drawing.Point(305, 119);
            this.cbReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReturnDate.Name = "cbReturnDate";
            this.cbReturnDate.Size = new System.Drawing.Size(77, 19);
            this.cbReturnDate.TabIndex = 14;
            this.cbReturnDate.Text = "Обратно:";
            this.cbReturnDate.UseVisualStyleBackColor = false;
            this.cbReturnDate.CheckedChanged += new System.EventHandler(this.cbReturnDate_CheckedChanged);
            // 
            // FormTourSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 277);
            this.Controls.Add(this.cbReturnDate);
            this.Controls.Add(this.lFrom);
            this.Controls.Add(this.lTo);
            this.Controls.Add(this.lCaption);
            this.Controls.Add(this.btnToPayment);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lDepartureDate);
            this.Controls.Add(this.gbClassOfFlight);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.tbFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(549, 316);
            this.MinimumSize = new System.Drawing.Size(549, 316);
            this.Name = "FormTourSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Оформление билетов";
            this.Load += new System.EventHandler(this.FormTourSelect_Load);
            this.gbClassOfFlight.ResumeLayout(false);
            this.gbClassOfFlight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.GroupBox gbClassOfFlight;
        private System.Windows.Forms.RadioButton rbFirstClass;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbComfort;
        private System.Windows.Forms.RadioButton rbEconom;
        private System.Windows.Forms.Label lDepartureDate;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Button btnToPayment;
        private System.Windows.Forms.Label lCaption;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.CheckBox cbReturnDate;
    }
}