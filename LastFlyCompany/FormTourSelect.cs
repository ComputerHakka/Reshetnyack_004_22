using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LastFlyCompany
{
    public partial class FormTourSelect : Form
    {
        public FormTourSelect()
        {
            InitializeComponent();
            int i;
            for(i = 0; i<4; i++)
            {
                comboBoxCountries.Items.Add(countries[i]);
            }
        }

        public void TotalChange()
        {
            tbTotalPrice.Text = "";
            double flight = 0;
            switch (comboBoxCountries.Text)
            {
                case "Самарканд":
                    flight += 31982;
                    tbTotalPrice.Text = Convert.ToString(flight);
                    break;
                case "Бали":
                    flight += 35260;
                    tbTotalPrice.Text = Convert.ToString(flight);
                    break;
                case "Рио-Де-Жанейро":
                    flight += 41560;
                    tbTotalPrice.Text = Convert.ToString(flight);
                    break;
                case "Прага":
                    flight += 14954;
                    tbTotalPrice.Text = Convert.ToString(flight);
                    break;
            }          

            if (tbTotalPrice.Text != null && tbTotalPrice.Text != "")
            {
                if (cbReturnDate.Checked)
                {
                    double comclass = Convert.ToDouble(tbTotalPrice.Text);
                    comclass *= 1.84;
                    tbTotalPrice.Text = Convert.ToString(Math.Round(comclass, 2));
                }

                if (rbEconom.Checked)
                {
                    double comclass = Convert.ToDouble(tbTotalPrice.Text);
                    comclass *= 1;
                    tbTotalPrice.Text = Convert.ToString(Math.Round(comclass, 2)) + " руб.";
                }
                else if (rbComfort.Checked)
                {
                    double comclass = Convert.ToDouble(tbTotalPrice.Text);
                    comclass *= 1.15;
                    tbTotalPrice.Text = Convert.ToString(Math.Round(comclass, 2)) + " руб.";
                }
                else if (rbBusiness.Checked)
                {
                    double comclass = Convert.ToDouble(tbTotalPrice.Text);
                    comclass *= 1.25;
                    tbTotalPrice.Text = Convert.ToString(Math.Round(comclass, 2)) + " руб.";
                }
                else if (rbFirstClass.Checked)
                {
                    double comclass = Convert.ToDouble(tbTotalPrice.Text);
                    comclass *= 1.5;
                    tbTotalPrice.Text = Convert.ToString(Math.Round(comclass, 2)) + " руб.";
                }
            }         
        }

        string[] countries =
        {"Самарканд",
         "Бали",
         "Рио-Де-Жанейро",
         "Прага"
        };

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.MinDate = dtpDepartureDate.Value;
        }

        private void FormTourSelect_Load(object sender, EventArgs e)
        {
            dtpDepartureDate.MinDate = DateTime.Today;
            dtpDepartureDate.Value = DateTime.Today;
        }

        private void tbFrom_TextChanged(object sender, EventArgs e)
        {
            if (tbFrom.Text != null && tbFrom.Text != "")
            {
                lFrom.Visible = true;
            } 
            else
            {
                lFrom.Visible = false;
            }         
        }

        private void comboBoxCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCountries.Text != "Куда")
            {
                lTo.Visible = true;
            }
            TotalChange();      
        }

        private void btnToPayment_Click(object sender, EventArgs e)
        {
            if (tbFrom.Text != null && tbFrom.Text != "" && comboBoxCountries.Text != "Куда" && comboBoxCountries.Text != tbFrom.Text)
            {
                if (ValidCharFound(tbFrom.Text))
                {
                    if (comboBoxCountries.Text == "Самарканд" || comboBoxCountries.Text == "Бали" || comboBoxCountries.Text == "Рио-Де-Жанейро" || comboBoxCountries.Text == "Прага")
                    {
                        FormPayment payment = new FormPayment();
                        payment.tbFromC = this.tbFrom;
                        payment.comboBoxCountriesC = this.comboBoxCountries;
                        payment.tbTotalPriceC = this.tbTotalPrice;
                        payment.dtpDepartureDateC = this.dtpDepartureDate;
                        payment.dtpReturnDateC = this.dtpReturnDate;

                        if (rbEconom.Checked)
                        {
                            payment.CheckedRadio = this.rbEconom;
                        }
                        else if (rbComfort.Checked)
                        {
                            payment.CheckedRadio = this.rbComfort;
                        }
                        else if (rbBusiness.Checked)
                        {
                            payment.CheckedRadio = this.rbBusiness;
                        }
                        else if (rbFirstClass.Checked)
                        {
                            payment.CheckedRadio = this.rbFirstClass;
                        }

                        if (cbReturnDate.Checked)
                        {
                            payment.cbReturnDateC = this.cbReturnDate;
                        }

                        payment.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("К сожалению, полет в город, куда вы хотели отправиться, в данный момент недоступен. Выберите любой другой город из предложенного списка", "Полет недоступен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }   
                else
                {
                    MessageBox.Show("Название города отправления некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxCountries.Text == tbFrom.Text)
            {
                MessageBox.Show("Введите разные города!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxCountries.Text != "Куда")
            {
                MessageBox.Show("Внесите город, откуда будет осуществляться отправление!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbFrom.Text != null && tbFrom.Text != "")
            {
                MessageBox.Show("Не указан город, в который вы хотите отправиться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Укажите город отправления и город, куда хотите отправиться", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool ValidCharFound(string str)
        {
            bool valid = true;
            foreach (char c in str)
            {
                string bfr = c.ToString();
                if (Regex.IsMatch(bfr, @"[а-я А-Я a-z A-Z -]"))
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

        private void rbBusiness_CheckedChanged(object sender, EventArgs e)
        {
            TotalChange();
        }

        private void rbFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            TotalChange();
        }

        private void rbComfort_CheckedChanged(object sender, EventArgs e)
        {
            TotalChange();
        }

        private void rbEconom_CheckedChanged(object sender, EventArgs e)
        {
            TotalChange();
        }

        private void cbReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReturnDate.Checked)
            {
                dtpReturnDate.Visible = true;
            }
            else
            {
                dtpReturnDate.Visible = false;
            }
            TotalChange();
        }
    }
}
