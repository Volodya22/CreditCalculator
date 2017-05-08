using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalculator
{
    public partial class Form1 : Form
    {
        private double _beginSum;
        private double _sum;
        private double _months;
        private double _percents;
        private double _perMonth;
        private double _total;
        private double _overpay;
        private double _payMore;

        public Form1()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            _beginSum = 0;
            _sum = 0;
            _months = 0;
            _percents = 0;
            _perMonth = 0;
            _total = 0;
            _overpay = 0;
            _payMore = 0;

            dataGridViewData.Rows.Clear();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Init();

            if (HasErrors())
            {
                return;
            }

            _percents /= 100;
            _beginSum = _sum;
            _perMonth = _sum / _months;

            for (var i = 0; i < _months; i++)
            {
                var dateBegin = DateTime.Today.AddMonths(i);
                var dateEnd = DateTime.Today.AddMonths(i + 1);
                var percentSum = _sum * _percents * (dateEnd - dateBegin).Days / 365;
                var total = _perMonth + percentSum;
                var diff = _payMore - total > 0 ? (_payMore - total) : 0;

                var paramsArray = new object[]
                {
                    i + 1,
                    dateEnd.ToString("dd.MM.yyyy"),
                    _sum.ToString("N"),
                    percentSum.ToString("N"),
                    total.ToString("N")
                };

                dataGridViewData.Rows.Add(paramsArray);

                _sum -= _perMonth + diff;
                _total += total + diff;

                if (_sum <= 0) break;
            }

            _overpay = _total - _beginSum;

            textBoxTotal.Text = _total.ToString("N");
            textBoxOverpay.Text = _overpay.ToString("N");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();

            Init();
        }

        private void Reset()
        {
            textBoxMonths.Clear();
            textBoxOverpay.Clear();
            textBoxSum.Clear();
            textBoxTotal.Clear();
            textBoxPercents.Clear();
            textBoxSumMore.Clear();

            checkBoxPayMore.Checked = false;
            textBoxSumMore.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool HasErrors()
        {
            if (!double.TryParse(textBoxSum.Text, out _sum))
            {
                MessageBox.Show(@"Сумма должна быть числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (!double.TryParse(textBoxMonths.Text, out _months))
            {
                MessageBox.Show(@"Количество месяцев должно быть числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            var percents = textBoxPercents.Text.Replace('.', ',');
            if (!double.TryParse(percents, out _percents))
            {
                MessageBox.Show(@"Процентная ставка должна быть числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (checkBoxPayMore.Checked && !double.TryParse(textBoxSumMore.Text, out _payMore))
            {
                MessageBox.Show(@"Сумма оплаты должна быть числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (_sum <= 0)
            {
                MessageBox.Show(@"Сумма должна быть положительным числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (_months <= 0)
            {
                MessageBox.Show(@"Количество месяцев должно быть положительным числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (_percents <= 0)
            {
                MessageBox.Show(@"Процентная ставка должна быть положительным числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (checkBoxPayMore.Checked && _payMore <= 0)
            {
                MessageBox.Show(@"Сумма оплаты быть положительным числом", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private void checkBoxPayMore_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSumMore.Enabled = checkBoxPayMore.Checked;
        }
    }
}
