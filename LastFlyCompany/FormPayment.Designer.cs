
namespace LastFlyCompany
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.tbTotalPayable = new System.Windows.Forms.TextBox();
            this.lTotalPayable = new System.Windows.Forms.Label();
            this.gbAdditionalServices = new System.Windows.Forms.GroupBox();
            this.cbLasFlySet = new System.Windows.Forms.CheckBox();
            this.cbDisabled = new System.Windows.Forms.CheckBox();
            this.cbLunch = new System.Windows.Forms.CheckBox();
            this.lCardNumber = new System.Windows.Forms.Label();
            this.btnFinalPay = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthdayDate = new System.Windows.Forms.DateTimePicker();
            this.lLastName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lPersonalDataCaption = new System.Windows.Forms.Label();
            this.mtbBankCard = new System.Windows.Forms.MaskedTextBox();
            this.lBirthDayDate = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lGender = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lPatronymic = new System.Windows.Forms.Label();
            this.lStarLastName = new System.Windows.Forms.Label();
            this.lStarFirstName = new System.Windows.Forms.Label();
            this.lStarPatronymic = new System.Windows.Forms.Label();
            this.lStarPhone = new System.Windows.Forms.Label();
            this.lStarCard = new System.Windows.Forms.Label();
            this.gbAdditionalServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTotalPayable
            // 
            this.tbTotalPayable.Location = new System.Drawing.Point(412, 188);
            this.tbTotalPayable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalPayable.Name = "tbTotalPayable";
            this.tbTotalPayable.ReadOnly = true;
            this.tbTotalPayable.Size = new System.Drawing.Size(110, 23);
            this.tbTotalPayable.TabIndex = 0;
            this.tbTotalPayable.TabStop = false;
            // 
            // lTotalPayable
            // 
            this.lTotalPayable.AutoSize = true;
            this.lTotalPayable.BackColor = System.Drawing.Color.Transparent;
            this.lTotalPayable.Location = new System.Drawing.Point(302, 190);
            this.lTotalPayable.Name = "lTotalPayable";
            this.lTotalPayable.Size = new System.Drawing.Size(96, 15);
            this.lTotalPayable.TabIndex = 1;
            this.lTotalPayable.Text = "Итого к оплате: ";
            // 
            // gbAdditionalServices
            // 
            this.gbAdditionalServices.BackColor = System.Drawing.Color.Transparent;
            this.gbAdditionalServices.Controls.Add(this.cbLasFlySet);
            this.gbAdditionalServices.Controls.Add(this.cbDisabled);
            this.gbAdditionalServices.Controls.Add(this.cbLunch);
            this.gbAdditionalServices.Location = new System.Drawing.Point(306, 49);
            this.gbAdditionalServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAdditionalServices.Name = "gbAdditionalServices";
            this.gbAdditionalServices.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAdditionalServices.Size = new System.Drawing.Size(224, 121);
            this.gbAdditionalServices.TabIndex = 2;
            this.gbAdditionalServices.TabStop = false;
            this.gbAdditionalServices.Text = "Дополнительные услуги";
            // 
            // cbLasFlySet
            // 
            this.cbLasFlySet.AutoSize = true;
            this.cbLasFlySet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLasFlySet.Location = new System.Drawing.Point(15, 86);
            this.cbLasFlySet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLasFlySet.Name = "cbLasFlySet";
            this.cbLasFlySet.Size = new System.Drawing.Size(161, 19);
            this.cbLasFlySet.TabIndex = 3;
            this.cbLasFlySet.Text = "Набор LastFly (+400 руб)";
            this.cbLasFlySet.UseVisualStyleBackColor = true;
            this.cbLasFlySet.CheckedChanged += new System.EventHandler(this.cbLasFlySet_CheckedChanged);
            // 
            // cbDisabled
            // 
            this.cbDisabled.AutoSize = true;
            this.cbDisabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDisabled.Location = new System.Drawing.Point(15, 26);
            this.cbDisabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDisabled.Name = "cbDisabled";
            this.cbDisabled.Size = new System.Drawing.Size(171, 19);
            this.cbDisabled.TabIndex = 1;
            this.cbDisabled.Text = "Сопровождение инвалида";
            this.cbDisabled.UseVisualStyleBackColor = true;
            // 
            // cbLunch
            // 
            this.cbLunch.AutoSize = true;
            this.cbLunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLunch.Location = new System.Drawing.Point(15, 56);
            this.cbLunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLunch.Name = "cbLunch";
            this.cbLunch.Size = new System.Drawing.Size(114, 19);
            this.cbLunch.TabIndex = 0;
            this.cbLunch.Text = "Ланч (+500 руб)";
            this.cbLunch.UseVisualStyleBackColor = true;
            this.cbLunch.CheckedChanged += new System.EventHandler(this.cbLunch_CheckedChanged);
            // 
            // lCardNumber
            // 
            this.lCardNumber.AutoSize = true;
            this.lCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lCardNumber.Location = new System.Drawing.Point(32, 235);
            this.lCardNumber.Name = "lCardNumber";
            this.lCardNumber.Size = new System.Drawing.Size(128, 15);
            this.lCardNumber.TabIndex = 4;
            this.lCardNumber.Text = "Введите номер карты:";
            // 
            // btnFinalPay
            // 
            this.btnFinalPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalPay.Location = new System.Drawing.Point(417, 229);
            this.btnFinalPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalPay.Name = "btnFinalPay";
            this.btnFinalPay.Size = new System.Drawing.Size(105, 26);
            this.btnFinalPay.TabIndex = 5;
            this.btnFinalPay.TabStop = false;
            this.btnFinalPay.Text = "Оплатить";
            this.btnFinalPay.UseVisualStyleBackColor = true;
            this.btnFinalPay.Click += new System.EventHandler(this.btnFinalPay_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(107, 83);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(137, 23);
            this.tbFirstName.TabIndex = 6;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(107, 56);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(137, 23);
            this.tbLastName.TabIndex = 7;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMale.Location = new System.Drawing.Point(109, 138);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(36, 19);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "М";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemale.Location = new System.Drawing.Point(161, 138);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(36, 19);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Ж";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdayDate
            // 
            this.dtpBirthdayDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBirthdayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdayDate.Location = new System.Drawing.Point(141, 190);
            this.dtpBirthdayDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthdayDate.MaxDate = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            this.dtpBirthdayDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdayDate.Name = "dtpBirthdayDate";
            this.dtpBirthdayDate.Size = new System.Drawing.Size(103, 23);
            this.dtpBirthdayDate.TabIndex = 11;
            this.dtpBirthdayDate.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.BackColor = System.Drawing.Color.Transparent;
            this.lLastName.Location = new System.Drawing.Point(36, 56);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(61, 15);
            this.lLastName.TabIndex = 13;
            this.lLastName.Text = "Фамилия:";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lFirstName.Location = new System.Drawing.Point(66, 85);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(34, 15);
            this.lFirstName.TabIndex = 14;
            this.lFirstName.Text = "Имя:";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.BackColor = System.Drawing.Color.Transparent;
            this.lPhone.Location = new System.Drawing.Point(39, 164);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(58, 15);
            this.lPhone.TabIndex = 15;
            this.lPhone.Text = "Телефон:";
            // 
            // lPersonalDataCaption
            // 
            this.lPersonalDataCaption.AutoSize = true;
            this.lPersonalDataCaption.BackColor = System.Drawing.Color.Transparent;
            this.lPersonalDataCaption.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPersonalDataCaption.Location = new System.Drawing.Point(161, 9);
            this.lPersonalDataCaption.Name = "lPersonalDataCaption";
            this.lPersonalDataCaption.Size = new System.Drawing.Size(242, 25);
            this.lPersonalDataCaption.TabIndex = 17;
            this.lPersonalDataCaption.Text = "Заполните личные данные";
            // 
            // mtbBankCard
            // 
            this.mtbBankCard.Location = new System.Drawing.Point(179, 232);
            this.mtbBankCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbBankCard.Mask = "0000 0000 0000 0000";
            this.mtbBankCard.Name = "mtbBankCard";
            this.mtbBankCard.Size = new System.Drawing.Size(134, 23);
            this.mtbBankCard.TabIndex = 18;
            // 
            // lBirthDayDate
            // 
            this.lBirthDayDate.AutoSize = true;
            this.lBirthDayDate.BackColor = System.Drawing.Color.Transparent;
            this.lBirthDayDate.Location = new System.Drawing.Point(32, 192);
            this.lBirthDayDate.Name = "lBirthDayDate";
            this.lBirthDayDate.Size = new System.Drawing.Size(93, 15);
            this.lBirthDayDate.TabIndex = 19;
            this.lBirthDayDate.Text = "Дата рождения:";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(107, 162);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPhone.Mask = "+7 (999) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(137, 23);
            this.mtbPhone.TabIndex = 20;
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.BackColor = System.Drawing.Color.Transparent;
            this.lGender.Location = new System.Drawing.Point(67, 138);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(33, 15);
            this.lGender.TabIndex = 21;
            this.lGender.Text = "Пол:";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(107, 111);
            this.tbPatronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(137, 23);
            this.tbPatronymic.TabIndex = 22;
            // 
            // lPatronymic
            // 
            this.lPatronymic.AutoSize = true;
            this.lPatronymic.BackColor = System.Drawing.Color.Transparent;
            this.lPatronymic.Location = new System.Drawing.Point(37, 112);
            this.lPatronymic.Name = "lPatronymic";
            this.lPatronymic.Size = new System.Drawing.Size(61, 15);
            this.lPatronymic.TabIndex = 23;
            this.lPatronymic.Text = "Отчество:";
            // 
            // lStarLastName
            // 
            this.lStarLastName.AutoSize = true;
            this.lStarLastName.ForeColor = System.Drawing.Color.Red;
            this.lStarLastName.Location = new System.Drawing.Point(246, 55);
            this.lStarLastName.Name = "lStarLastName";
            this.lStarLastName.Size = new System.Drawing.Size(12, 15);
            this.lStarLastName.TabIndex = 24;
            this.lStarLastName.Text = "*";
            this.lStarLastName.Visible = false;
            // 
            // lStarFirstName
            // 
            this.lStarFirstName.AutoSize = true;
            this.lStarFirstName.ForeColor = System.Drawing.Color.Red;
            this.lStarFirstName.Location = new System.Drawing.Point(247, 82);
            this.lStarFirstName.Name = "lStarFirstName";
            this.lStarFirstName.Size = new System.Drawing.Size(12, 15);
            this.lStarFirstName.TabIndex = 25;
            this.lStarFirstName.Text = "*";
            this.lStarFirstName.Visible = false;
            // 
            // lStarPatronymic
            // 
            this.lStarPatronymic.AutoSize = true;
            this.lStarPatronymic.ForeColor = System.Drawing.Color.Red;
            this.lStarPatronymic.Location = new System.Drawing.Point(247, 110);
            this.lStarPatronymic.Name = "lStarPatronymic";
            this.lStarPatronymic.Size = new System.Drawing.Size(12, 15);
            this.lStarPatronymic.TabIndex = 26;
            this.lStarPatronymic.Text = "*";
            this.lStarPatronymic.Visible = false;
            // 
            // lStarPhone
            // 
            this.lStarPhone.AutoSize = true;
            this.lStarPhone.ForeColor = System.Drawing.Color.Red;
            this.lStarPhone.Location = new System.Drawing.Point(246, 162);
            this.lStarPhone.Name = "lStarPhone";
            this.lStarPhone.Size = new System.Drawing.Size(12, 15);
            this.lStarPhone.TabIndex = 27;
            this.lStarPhone.Text = "*";
            this.lStarPhone.Visible = false;
            // 
            // lStarCard
            // 
            this.lStarCard.AutoSize = true;
            this.lStarCard.BackColor = System.Drawing.Color.Transparent;
            this.lStarCard.ForeColor = System.Drawing.Color.Red;
            this.lStarCard.Location = new System.Drawing.Point(315, 233);
            this.lStarCard.Name = "lStarCard";
            this.lStarCard.Size = new System.Drawing.Size(12, 15);
            this.lStarCard.TabIndex = 28;
            this.lStarCard.Text = "*";
            this.lStarCard.Visible = false;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 291);
            this.Controls.Add(this.lStarCard);
            this.Controls.Add(this.lStarPhone);
            this.Controls.Add(this.lStarPatronymic);
            this.Controls.Add(this.lStarFirstName);
            this.Controls.Add(this.lStarLastName);
            this.Controls.Add(this.lPatronymic);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.lBirthDayDate);
            this.Controls.Add(this.mtbBankCard);
            this.Controls.Add(this.lPersonalDataCaption);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.dtpBirthdayDate);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnFinalPay);
            this.Controls.Add(this.lCardNumber);
            this.Controls.Add(this.gbAdditionalServices);
            this.Controls.Add(this.lTotalPayable);
            this.Controls.Add(this.tbTotalPayable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(593, 330);
            this.MinimumSize = new System.Drawing.Size(593, 330);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.gbAdditionalServices.ResumeLayout(false);
            this.gbAdditionalServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTotalPayable;
        private System.Windows.Forms.Label lTotalPayable;
        private System.Windows.Forms.GroupBox gbAdditionalServices;
        private System.Windows.Forms.CheckBox cbDisabled;
        private System.Windows.Forms.CheckBox cbLunch;
        private System.Windows.Forms.Label lCardNumber;
        private System.Windows.Forms.Button btnFinalPay;
        private System.Windows.Forms.CheckBox cbLasFlySet;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpBirthdayDate;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lPersonalDataCaption;
        private System.Windows.Forms.MaskedTextBox mtbBankCard;
        private System.Windows.Forms.Label lBirthDayDate;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lPatronymic;
        private System.Windows.Forms.Label lStarLastName;
        private System.Windows.Forms.Label lStarFirstName;
        private System.Windows.Forms.Label lStarPatronymic;
        private System.Windows.Forms.Label lStarPhone;
        private System.Windows.Forms.Label lStarCard;
    }
}