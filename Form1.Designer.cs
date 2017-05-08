namespace CreditCalculator
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
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxMonths = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxOverpay = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelMonths = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOverpay = new System.Windows.Forms.Label();
            this.textBoxPercents = new System.Windows.Forms.TextBox();
            this.labelPercents = new System.Windows.Forms.Label();
            this.checkBoxPayMore = new System.Windows.Forms.CheckBox();
            this.labelSumMore = new System.Windows.Forms.Label();
            this.textBoxSumMore = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leftover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(128, 12);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 0;
            // 
            // textBoxMonths
            // 
            this.textBoxMonths.Location = new System.Drawing.Point(128, 54);
            this.textBoxMonths.Name = "textBoxMonths";
            this.textBoxMonths.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonths.TabIndex = 1;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(128, 199);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(100, 23);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Расчитать";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Date,
            this.Leftover,
            this.Percents,
            this.ToPay});
            this.dataGridViewData.Location = new System.Drawing.Point(244, 11);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.Size = new System.Drawing.Size(498, 363);
            this.dataGridViewData.TabIndex = 3;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(128, 260);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 4;
            // 
            // textBoxOverpay
            // 
            this.textBoxOverpay.Location = new System.Drawing.Point(128, 299);
            this.textBoxOverpay.Name = "textBoxOverpay";
            this.textBoxOverpay.ReadOnly = true;
            this.textBoxOverpay.Size = new System.Drawing.Size(100, 20);
            this.textBoxOverpay.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(16, 351);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(153, 351);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(13, 18);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(44, 13);
            this.labelSum.TabIndex = 8;
            this.labelSum.Text = "Сумма:";
            // 
            // labelMonths
            // 
            this.labelMonths.AutoSize = true;
            this.labelMonths.Location = new System.Drawing.Point(13, 57);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(91, 13);
            this.labelMonths.TabIndex = 9;
            this.labelMonths.Text = "Кол-во месяцев:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(13, 263);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(87, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Итого к оплате:";
            // 
            // labelOverpay
            // 
            this.labelOverpay.AutoSize = true;
            this.labelOverpay.Location = new System.Drawing.Point(12, 302);
            this.labelOverpay.Name = "labelOverpay";
            this.labelOverpay.Size = new System.Drawing.Size(65, 13);
            this.labelOverpay.TabIndex = 11;
            this.labelOverpay.Text = "Переплата:";
            // 
            // textBoxPercents
            // 
            this.textBoxPercents.Location = new System.Drawing.Point(128, 97);
            this.textBoxPercents.Name = "textBoxPercents";
            this.textBoxPercents.Size = new System.Drawing.Size(100, 20);
            this.textBoxPercents.TabIndex = 12;
            // 
            // labelPercents
            // 
            this.labelPercents.AutoSize = true;
            this.labelPercents.Location = new System.Drawing.Point(13, 100);
            this.labelPercents.Name = "labelPercents";
            this.labelPercents.Size = new System.Drawing.Size(109, 13);
            this.labelPercents.TabIndex = 13;
            this.labelPercents.Text = "Процентная ставка:";
            // 
            // checkBoxPayMore
            // 
            this.checkBoxPayMore.AutoSize = true;
            this.checkBoxPayMore.Location = new System.Drawing.Point(16, 137);
            this.checkBoxPayMore.Name = "checkBoxPayMore";
            this.checkBoxPayMore.Size = new System.Drawing.Size(178, 17);
            this.checkBoxPayMore.TabIndex = 14;
            this.checkBoxPayMore.Text = "Хочу платить больше нужного";
            this.checkBoxPayMore.UseVisualStyleBackColor = true;
            this.checkBoxPayMore.CheckedChanged += new System.EventHandler(this.checkBoxPayMore_CheckedChanged);
            // 
            // labelSumMore
            // 
            this.labelSumMore.AutoSize = true;
            this.labelSumMore.Location = new System.Drawing.Point(13, 164);
            this.labelSumMore.Name = "labelSumMore";
            this.labelSumMore.Size = new System.Drawing.Size(84, 13);
            this.labelSumMore.TabIndex = 15;
            this.labelSumMore.Text = "Сумма оплаты:";
            // 
            // textBoxSumMore
            // 
            this.textBoxSumMore.Enabled = false;
            this.textBoxSumMore.Location = new System.Drawing.Point(128, 161);
            this.textBoxSumMore.Name = "textBoxSumMore";
            this.textBoxSumMore.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumMore.TabIndex = 16;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 25;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата платежа";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Leftover
            // 
            this.Leftover.HeaderText = "Остаток";
            this.Leftover.Name = "Leftover";
            this.Leftover.ReadOnly = true;
            // 
            // Percents
            // 
            this.Percents.HeaderText = "Сумма %";
            this.Percents.Name = "Percents";
            this.Percents.ReadOnly = true;
            // 
            // ToPay
            // 
            this.ToPay.HeaderText = "К оплате";
            this.ToPay.Name = "ToPay";
            this.ToPay.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 386);
            this.Controls.Add(this.textBoxSumMore);
            this.Controls.Add(this.labelSumMore);
            this.Controls.Add(this.checkBoxPayMore);
            this.Controls.Add(this.labelPercents);
            this.Controls.Add(this.textBoxPercents);
            this.Controls.Add(this.labelOverpay);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelMonths);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxOverpay);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxMonths);
            this.Controls.Add(this.textBoxSum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор кредита";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxMonths;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxOverpay;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelMonths;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOverpay;
        private System.Windows.Forms.TextBox textBoxPercents;
        private System.Windows.Forms.Label labelPercents;
        private System.Windows.Forms.CheckBox checkBoxPayMore;
        private System.Windows.Forms.Label labelSumMore;
        private System.Windows.Forms.TextBox textBoxSumMore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leftover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToPay;
    }
}

