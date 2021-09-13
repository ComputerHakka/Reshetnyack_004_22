using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LastFlyCompany
{
    public partial class FormPayment : Form
    {
        public TextBox tbFromC;
        public ComboBox comboBoxCountriesC;
        public TextBox tbTotalPriceC;
        public DateTimePicker dtpDepartureDateC;
        public DateTimePicker dtpReturnDateC;
        public RadioButton CheckedRadio;
        public CheckBox cbReturnDateC;

        public void TotalPriceChange()
        {
            string fixPrice = tbTotalPriceC.Text.Trim(new char[] { 'р', 'у', 'б', '.' });
            if (cbLunch.Checked && cbLasFlySet.Checked == false)
            {
                double addService = Convert.ToDouble(fixPrice);
                addService += 500;
                tbTotalPayable.Text = Convert.ToString(addService) + " руб.";
            }
            else if (cbLasFlySet.Checked && cbLunch.Checked == false)
            {              
                double addService = Convert.ToDouble(fixPrice);
                addService += 400;
                tbTotalPayable.Text = Convert.ToString(addService) + " руб.";
            }
            else if (cbLunch.Checked && cbLasFlySet.Checked)
            {
                double addService = Convert.ToDouble(fixPrice);
                addService += 900;
                tbTotalPayable.Text = Convert.ToString(addService) + " руб.";
            }
            else
            {
                tbTotalPayable.Text = Convert.ToString(fixPrice) + " руб.";
            }
        }

        bool ValidCharFound(string str)
        {
            bool valid = true;
            foreach (char c in str)
            {
                string bfr = c.ToString();
                if (Regex.IsMatch(bfr, @"[а-я А-Я a-z A-Z]"))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        public void ActivateStars()
        {
            lStarFirstName.Visible = true;
            lStarLastName.Visible = true;
            lStarPatronymic.Visible = true;
            lStarPhone.Visible = true;
            lStarCard.Visible = true;
        }

        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            tbTotalPayable.Text = tbTotalPriceC.Text;
            dtpBirthdayDate.MaxDate = DateTime.Today;
        }

        private void cbLunch_CheckedChanged(object sender, EventArgs e)
        {
            TotalPriceChange();
        }

        private void cbLasFlySet_CheckedChanged(object sender, EventArgs e)
        {
            TotalPriceChange();
        }

        private void btnFinalPay_Click(object sender, EventArgs e)
        {
            bool FIO = false;
            bool phone = false;
            bool card = false;

            if(tbFirstName.Text != "" && tbFirstName.Text != null && tbLastName.Text != "" && tbLastName.Text != null && tbPatronymic.Text != "" && tbPatronymic.Text != null)
            {
                if (ValidCharFound(tbFirstName.Text) && ValidCharFound(tbLastName.Text) && ValidCharFound(tbPatronymic.Text))
                {
                    FIO = true;
                } 
                else
                {
                    MessageBox.Show("Некорректно введены данные ФИО, проверьте, нет ли там лишних символов", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          

            if (mtbPhone.MaskCompleted == true)
            {
                phone = true;
            } 
           
            if (mtbBankCard.MaskCompleted == true)
            {
                card = true;
            }

            if (FIO && phone && card)
            {
                Random rand = new Random();
                int ticketNumber = rand.Next(100200, 999999);
                string gender = "М";
                string includeDisabled = "✖";
                string includeLunch = "✖";
                string includeLFSet = "✖";
                string returnDate;

                if (rbFemale.Checked)
                {
                    gender = "Ж";
                }

                if (cbDisabled.Checked)
                {
                    includeDisabled = "✔";
                }

                if (cbLasFlySet.Checked)
                {
                    includeLFSet = "✔";
                }

                if (cbLunch.Checked)
                {
                    includeLunch = "✔";
                }

                if (dtpReturnDateC.Text == "" || dtpReturnDateC.Text == null)
                {
                    returnDate = "✖";
                }
                else
                {
                    returnDate = dtpReturnDateC.Text;
                }

                SaveFileDialog saveFileDialogCheck = new SaveFileDialog 
                {
                    FileName = $"Билет_{tbFromC.Text}—{comboBoxCountriesC.Text}",
                    Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*",
                    Title = "Сохранить чек"
                };
                if (saveFileDialogCheck.ShowDialog() == DialogResult.Cancel)
                    return;

                string fileName = saveFileDialogCheck.FileName;
                System.IO.File.WriteAllText(fileName, "OOO LastFly airlines / BOARDING PASS" + Environment.NewLine + $"Билет №{ticketNumber}\t\t" + $"     {tbFromC.Text} - {comboBoxCountriesC.Text} {dtpDepartureDateC.Text}" +
                    Environment.NewLine + $"\t\t\t     {comboBoxCountriesC.Text} - {tbFromC.Text} {returnDate}" + Environment.NewLine + "------------------------------------------------------------------" + Environment.NewLine + 
                    Environment.NewLine + $"Пассажир: {tbLastName.Text} {tbFirstName.Text} {tbPatronymic.Text}" +
                    Environment.NewLine + $"Пол: {gender}" + Environment.NewLine + $"Класс: {CheckedRadio.Text}" + Environment.NewLine +
                    $"Ланч: {includeLunch}" + Environment.NewLine + $"Сопровождение иналида: {includeDisabled}" + Environment.NewLine + $"LastFly набор: {includeLFSet}" + Environment.NewLine +
                    Environment.NewLine + "------------------------------------------------------------------" + Environment.NewLine + $"Стоимость билета: {tbTotalPayable.Text}\t\t Состояние: оплачено" + Environment.NewLine);     
                DialogResult dialog = MessageBox.Show("Билет успешно оформлен и сохранен. Отличного полета!", "Спасибо за покупку!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }  
            }
            else if (FIO == false && phone && card)
            {
                MessageBox.Show("Заполните ФИО полностью!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActivateStars();
            }
            else if (FIO && phone == false && card)
            {
                MessageBox.Show("Введите номер телефона для нашего контакта с вами!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActivateStars();
            }
            else if (FIO && phone && card == false)
            {
                MessageBox.Show("Введите номер банковской карты, с которой будет производиться оплата!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActivateStars();
            }
            else
            {
                MessageBox.Show("Не все данные внесены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActivateStars();
            }
        }
    }
}
