
namespace InvoiceForm
{
    partial class AddInvoice
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
            this.groupBoxInvoiceLine = new System.Windows.Forms.GroupBox();
            this.comboBoxIncomeTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxKdvRate = new System.Windows.Forms.ComboBox();
            this.textBoxAmountInFC = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxExchangeRate = new System.Windows.Forms.TextBox();
            this.comboBoxCurrencyType = new System.Windows.Forms.ComboBox();
            this.checkBoxFCInvoice = new System.Windows.Forms.CheckBox();
            this.labelIncomeTypes = new System.Windows.Forms.Label();
            this.labelKdvRate = new System.Windows.Forms.Label();
            this.labelAmountInFC = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.labelCurrencyType = new System.Windows.Forms.Label();
            this.labelFCInvoice = new System.Windows.Forms.Label();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.textBoxExplanation = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxSerino = new System.Windows.Forms.TextBox();
            this.groupBoxInvoiceLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInvoiceLine
            // 
            this.groupBoxInvoiceLine.Controls.Add(this.comboBoxIncomeTypes);
            this.groupBoxInvoiceLine.Controls.Add(this.comboBoxKdvRate);
            this.groupBoxInvoiceLine.Controls.Add(this.textBoxAmountInFC);
            this.groupBoxInvoiceLine.Controls.Add(this.textBoxTotal);
            this.groupBoxInvoiceLine.Controls.Add(this.textBoxAmount);
            this.groupBoxInvoiceLine.Controls.Add(this.textBoxUnitPrice);
            this.groupBoxInvoiceLine.Controls.Add(this.textBoxExchangeRate);
            this.groupBoxInvoiceLine.Controls.Add(this.comboBoxCurrencyType);
            this.groupBoxInvoiceLine.Controls.Add(this.checkBoxFCInvoice);
            this.groupBoxInvoiceLine.Controls.Add(this.labelIncomeTypes);
            this.groupBoxInvoiceLine.Controls.Add(this.labelKdvRate);
            this.groupBoxInvoiceLine.Controls.Add(this.labelAmountInFC);
            this.groupBoxInvoiceLine.Controls.Add(this.labelTotal);
            this.groupBoxInvoiceLine.Controls.Add(this.labelAmount);
            this.groupBoxInvoiceLine.Controls.Add(this.labelUnitPrice);
            this.groupBoxInvoiceLine.Controls.Add(this.labelExchangeRate);
            this.groupBoxInvoiceLine.Controls.Add(this.labelCurrencyType);
            this.groupBoxInvoiceLine.Controls.Add(this.labelFCInvoice);
            this.groupBoxInvoiceLine.Controls.Add(this.labelExplanation);
            this.groupBoxInvoiceLine.Controls.Add(this.textBoxExplanation);
            this.groupBoxInvoiceLine.Location = new System.Drawing.Point(22, 25);
            this.groupBoxInvoiceLine.Name = "groupBoxInvoiceLine";
            this.groupBoxInvoiceLine.Size = new System.Drawing.Size(1056, 429);
            this.groupBoxInvoiceLine.TabIndex = 0;
            this.groupBoxInvoiceLine.TabStop = false;
            this.groupBoxInvoiceLine.Text = "Invoice Line";
            // 
            // comboBoxIncomeTypes
            // 
            this.comboBoxIncomeTypes.FormattingEnabled = true;
            this.comboBoxIncomeTypes.Location = new System.Drawing.Point(408, 191);
            this.comboBoxIncomeTypes.Name = "comboBoxIncomeTypes";
            this.comboBoxIncomeTypes.Size = new System.Drawing.Size(349, 28);
            this.comboBoxIncomeTypes.TabIndex = 20;
            // 
            // comboBoxKdvRate
            // 
            this.comboBoxKdvRate.FormattingEnabled = true;
            this.comboBoxKdvRate.Location = new System.Drawing.Point(152, 370);
            this.comboBoxKdvRate.Name = "comboBoxKdvRate";
            this.comboBoxKdvRate.Size = new System.Drawing.Size(142, 28);
            this.comboBoxKdvRate.TabIndex = 19;
            // 
            // textBoxAmountInFC
            // 
            this.textBoxAmountInFC.Location = new System.Drawing.Point(152, 326);
            this.textBoxAmountInFC.Name = "textBoxAmountInFC";
            this.textBoxAmountInFC.Size = new System.Drawing.Size(142, 26);
            this.textBoxAmountInFC.TabIndex = 18;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(152, 280);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(142, 26);
            this.textBoxTotal.TabIndex = 17;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(152, 238);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(142, 26);
            this.textBoxAmount.TabIndex = 16;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            this.textBoxAmount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAmount_Validating);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(152, 193);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(142, 26);
            this.textBoxUnitPrice.TabIndex = 15;
            this.textBoxUnitPrice.TextChanged += new System.EventHandler(this.textBoxUnitPrice_TextChanged);
            // 
            // textBoxExchangeRate
            // 
            this.textBoxExchangeRate.Location = new System.Drawing.Point(152, 146);
            this.textBoxExchangeRate.Name = "textBoxExchangeRate";
            this.textBoxExchangeRate.Size = new System.Drawing.Size(142, 26);
            this.textBoxExchangeRate.TabIndex = 14;
            this.textBoxExchangeRate.TextChanged += new System.EventHandler(this.textBoxExchangeRate_TextChanged);
            // 
            // comboBoxCurrencyType
            // 
            this.comboBoxCurrencyType.FormattingEnabled = true;
            this.comboBoxCurrencyType.Location = new System.Drawing.Point(152, 101);
            this.comboBoxCurrencyType.Name = "comboBoxCurrencyType";
            this.comboBoxCurrencyType.Size = new System.Drawing.Size(142, 28);
            this.comboBoxCurrencyType.TabIndex = 13;
            this.comboBoxCurrencyType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencyType_SelectedIndexChanged);
            // 
            // checkBoxFCInvoice
            // 
            this.checkBoxFCInvoice.AutoSize = true;
            this.checkBoxFCInvoice.Location = new System.Drawing.Point(152, 66);
            this.checkBoxFCInvoice.Name = "checkBoxFCInvoice";
            this.checkBoxFCInvoice.Size = new System.Drawing.Size(68, 24);
            this.checkBoxFCInvoice.TabIndex = 12;
            this.checkBoxFCInvoice.Text = "YES";
            this.checkBoxFCInvoice.UseVisualStyleBackColor = true;
            this.checkBoxFCInvoice.Click += new System.EventHandler(this.checkBoxFCInvoice_Click);
            // 
            // labelIncomeTypes
            // 
            this.labelIncomeTypes.AutoSize = true;
            this.labelIncomeTypes.Location = new System.Drawing.Point(311, 193);
            this.labelIncomeTypes.Name = "labelIncomeTypes";
            this.labelIncomeTypes.Size = new System.Drawing.Size(112, 20);
            this.labelIncomeTypes.TabIndex = 11;
            this.labelIncomeTypes.Text = "Income Types:";
            // 
            // labelKdvRate
            // 
            this.labelKdvRate.AutoSize = true;
            this.labelKdvRate.Location = new System.Drawing.Point(6, 378);
            this.labelKdvRate.Name = "labelKdvRate";
            this.labelKdvRate.Size = new System.Drawing.Size(85, 20);
            this.labelKdvRate.TabIndex = 9;
            this.labelKdvRate.Text = "KDV Rate:";
            // 
            // labelAmountInFC
            // 
            this.labelAmountInFC.AutoSize = true;
            this.labelAmountInFC.Location = new System.Drawing.Point(6, 326);
            this.labelAmountInFC.Name = "labelAmountInFC";
            this.labelAmountInFC.Size = new System.Drawing.Size(94, 20);
            this.labelAmountInFC.TabIndex = 8;
            this.labelAmountInFC.Text = "FC Amount:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(6, 286);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(69, 20);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Amount:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(6, 244);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(72, 20);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Quantity:";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(6, 199);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(94, 20);
            this.labelUnitPrice.TabIndex = 5;
            this.labelUnitPrice.Text = "Unit Price ₺:";
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Location = new System.Drawing.Point(6, 152);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(123, 20);
            this.labelExchangeRate.TabIndex = 4;
            this.labelExchangeRate.Text = "Exchange Rate:";
            // 
            // labelCurrencyType
            // 
            this.labelCurrencyType.AutoSize = true;
            this.labelCurrencyType.Location = new System.Drawing.Point(6, 109);
            this.labelCurrencyType.Name = "labelCurrencyType";
            this.labelCurrencyType.Size = new System.Drawing.Size(72, 20);
            this.labelCurrencyType.TabIndex = 3;
            this.labelCurrencyType.Text = "FC Type:";
            // 
            // labelFCInvoice
            // 
            this.labelFCInvoice.AutoSize = true;
            this.labelFCInvoice.Location = new System.Drawing.Point(6, 70);
            this.labelFCInvoice.Name = "labelFCInvoice";
            this.labelFCInvoice.Size = new System.Drawing.Size(88, 20);
            this.labelFCInvoice.TabIndex = 2;
            this.labelFCInvoice.Text = "FC Invoice:";
            // 
            // labelExplanation
            // 
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.Location = new System.Drawing.Point(6, 31);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(96, 20);
            this.labelExplanation.TabIndex = 1;
            this.labelExplanation.Text = "Explanation:";
            // 
            // textBoxExplanation
            // 
            this.textBoxExplanation.Location = new System.Drawing.Point(152, 25);
            this.textBoxExplanation.Name = "textBoxExplanation";
            this.textBoxExplanation.Size = new System.Drawing.Size(605, 26);
            this.textBoxExplanation.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(513, 472);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 41);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Submit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(663, 472);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(135, 41);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxSerino
            // 
            this.textBoxSerino.Location = new System.Drawing.Point(475, 479);
            this.textBoxSerino.Name = "textBoxSerino";
            this.textBoxSerino.Size = new System.Drawing.Size(32, 26);
            this.textBoxSerino.TabIndex = 21;
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 543);
            this.Controls.Add(this.textBoxSerino);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxInvoiceLine);
            this.Name = "AddInvoice";
            this.Text = "Add Invoice Line";
            this.Load += new System.EventHandler(this.AddInvoice_Load);
            this.groupBoxInvoiceLine.ResumeLayout(false);
            this.groupBoxInvoiceLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInvoiceLine;
        private System.Windows.Forms.ComboBox comboBoxIncomeTypes;
        private System.Windows.Forms.ComboBox comboBoxKdvRate;
        private System.Windows.Forms.TextBox textBoxAmountInFC;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxExchangeRate;
        private System.Windows.Forms.ComboBox comboBoxCurrencyType;
        private System.Windows.Forms.CheckBox checkBoxFCInvoice;
        private System.Windows.Forms.Label labelIncomeTypes;
        private System.Windows.Forms.Label labelKdvRate;
        private System.Windows.Forms.Label labelAmountInFC;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.Label labelCurrencyType;
        private System.Windows.Forms.Label labelFCInvoice;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.TextBox textBoxExplanation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxSerino;
    }
}