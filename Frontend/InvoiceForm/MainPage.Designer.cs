namespace InvoiceForm
{
    partial class MainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMüsteriBilgileri = new System.Windows.Forms.GroupBox();
            this.buttonGetAccount = new System.Windows.Forms.Button();
            this.textBoxAccountCode = new System.Windows.Forms.TextBox();
            this.comboBoxContract = new System.Windows.Forms.ComboBox();
            this.labelAgreements = new System.Windows.Forms.Label();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.labelCurrentAccount = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerCode = new System.Windows.Forms.Label();
            this.groupBoxFaturaBilgisi = new System.Windows.Forms.GroupBox();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.groupBoxInvoiceLines = new System.Windows.Forms.GroupBox();
            this.buttonPullExcell = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxInvoiceTotal = new System.Windows.Forms.GroupBox();
            this.textBoxGrandTotalFC = new System.Windows.Forms.TextBox();
            this.textBoxKdvFC = new System.Windows.Forms.TextBox();
            this.labelgrandTotalFC = new System.Windows.Forms.Label();
            this.labelKdvFC = new System.Windows.Forms.Label();
            this.labelTotalAmountFC = new System.Windows.Forms.Label();
            this.textBoxTotalAmountFC = new System.Windows.Forms.TextBox();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.textBoxKdv = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelKdv = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.textBoxSerino = new System.Windows.Forms.TextBox();
            this.groupBoxMüsteriBilgileri.SuspendLayout();
            this.groupBoxFaturaBilgisi.SuspendLayout();
            this.groupBoxInvoiceLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInvoiceTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMüsteriBilgileri
            // 
            this.groupBoxMüsteriBilgileri.Controls.Add(this.buttonGetAccount);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.textBoxAccountCode);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.comboBoxContract);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.labelAgreements);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.comboBoxAddress);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.comboBoxAccount);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.labelCurrentAccount);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.labelCustomerName);
            this.groupBoxMüsteriBilgileri.Controls.Add(this.labelCustomerCode);
            this.groupBoxMüsteriBilgileri.Location = new System.Drawing.Point(56, 12);
            this.groupBoxMüsteriBilgileri.Name = "groupBoxMüsteriBilgileri";
            this.groupBoxMüsteriBilgileri.Size = new System.Drawing.Size(1112, 177);
            this.groupBoxMüsteriBilgileri.TabIndex = 0;
            this.groupBoxMüsteriBilgileri.TabStop = false;
            this.groupBoxMüsteriBilgileri.Text = "Customer Information";
            // 
            // buttonGetAccount
            // 
            this.buttonGetAccount.Location = new System.Drawing.Point(478, 28);
            this.buttonGetAccount.Name = "buttonGetAccount";
            this.buttonGetAccount.Size = new System.Drawing.Size(116, 34);
            this.buttonGetAccount.TabIndex = 7;
            this.buttonGetAccount.Text = "Get Account";
            this.buttonGetAccount.UseVisualStyleBackColor = true;
            this.buttonGetAccount.Click += new System.EventHandler(this.buttonGetAccount_Click);
            // 
            // textBoxAccountCode
            // 
            this.textBoxAccountCode.HideSelection = false;
            this.textBoxAccountCode.Location = new System.Drawing.Point(181, 29);
            this.textBoxAccountCode.Name = "textBoxAccountCode";
            this.textBoxAccountCode.Size = new System.Drawing.Size(291, 26);
            this.textBoxAccountCode.TabIndex = 1;
            // 
            // comboBoxContract
            // 
            this.comboBoxContract.FormattingEnabled = true;
            this.comboBoxContract.Location = new System.Drawing.Point(181, 137);
            this.comboBoxContract.Name = "comboBoxContract";
            this.comboBoxContract.Size = new System.Drawing.Size(878, 28);
            this.comboBoxContract.TabIndex = 4;
            // 
            // labelAgreements
            // 
            this.labelAgreements.AutoSize = true;
            this.labelAgreements.Location = new System.Drawing.Point(6, 145);
            this.labelAgreements.Name = "labelAgreements";
            this.labelAgreements.Size = new System.Drawing.Size(100, 20);
            this.labelAgreements.TabIndex = 3;
            this.labelAgreements.Text = "Agreements:";
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(181, 101);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(878, 28);
            this.comboBoxAddress.TabIndex = 6;
            this.comboBoxAddress.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddress_SelectedIndexChanged);
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(181, 65);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(878, 28);
            this.comboBoxAccount.TabIndex = 5;
            this.comboBoxAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccount_SelectedIndexChanged);
            // 
            // labelCurrentAccount
            // 
            this.labelCurrentAccount.AutoSize = true;
            this.labelCurrentAccount.Location = new System.Drawing.Point(6, 109);
            this.labelCurrentAccount.Name = "labelCurrentAccount";
            this.labelCurrentAccount.Size = new System.Drawing.Size(129, 20);
            this.labelCurrentAccount.TabIndex = 2;
            this.labelCurrentAccount.Text = "Current Account:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(6, 73);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(128, 20);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // labelCustomerCode
            // 
            this.labelCustomerCode.AutoSize = true;
            this.labelCustomerCode.Location = new System.Drawing.Point(6, 35);
            this.labelCustomerCode.Name = "labelCustomerCode";
            this.labelCustomerCode.Size = new System.Drawing.Size(124, 20);
            this.labelCustomerCode.TabIndex = 0;
            this.labelCustomerCode.Text = "Customer Code:";
            // 
            // groupBoxFaturaBilgisi
            // 
            this.groupBoxFaturaBilgisi.Controls.Add(this.labelExplanation);
            this.groupBoxFaturaBilgisi.Controls.Add(this.textBox2);
            this.groupBoxFaturaBilgisi.Controls.Add(this.dateTimePicker1);
            this.groupBoxFaturaBilgisi.Controls.Add(this.labelInvoiceDate);
            this.groupBoxFaturaBilgisi.Location = new System.Drawing.Point(56, 195);
            this.groupBoxFaturaBilgisi.Name = "groupBoxFaturaBilgisi";
            this.groupBoxFaturaBilgisi.Size = new System.Drawing.Size(1112, 146);
            this.groupBoxFaturaBilgisi.TabIndex = 1;
            this.groupBoxFaturaBilgisi.TabStop = false;
            this.groupBoxFaturaBilgisi.Text = "Invoice Information";
            // 
            // labelExplanation
            // 
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.Location = new System.Drawing.Point(6, 82);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(96, 20);
            this.labelExplanation.TabIndex = 2;
            this.labelExplanation.Text = "Explanation:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(888, 26);
            this.textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(6, 41);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(102, 20);
            this.labelInvoiceDate.TabIndex = 0;
            this.labelInvoiceDate.Text = "Invoice Date:";
            // 
            // groupBoxInvoiceLines
            // 
            this.groupBoxInvoiceLines.Controls.Add(this.buttonPullExcell);
            this.groupBoxInvoiceLines.Controls.Add(this.buttonDelete);
            this.groupBoxInvoiceLines.Controls.Add(this.buttonAdd);
            this.groupBoxInvoiceLines.Controls.Add(this.buttonDetail);
            this.groupBoxInvoiceLines.Controls.Add(this.dataGridView1);
            this.groupBoxInvoiceLines.Location = new System.Drawing.Point(46, 347);
            this.groupBoxInvoiceLines.Name = "groupBoxInvoiceLines";
            this.groupBoxInvoiceLines.Size = new System.Drawing.Size(1122, 203);
            this.groupBoxInvoiceLines.TabIndex = 2;
            this.groupBoxInvoiceLines.TabStop = false;
            this.groupBoxInvoiceLines.Text = "Invoice Lines";
            // 
            // buttonPullExcell
            // 
            this.buttonPullExcell.Location = new System.Drawing.Point(376, 154);
            this.buttonPullExcell.Name = "buttonPullExcell";
            this.buttonPullExcell.Size = new System.Drawing.Size(176, 34);
            this.buttonPullExcell.TabIndex = 6;
            this.buttonPullExcell.Text = "Import from Excel";
            this.buttonPullExcell.UseVisualStyleBackColor = true;
            this.buttonPullExcell.Click += new System.EventHandler(this.buttonPullExcell_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(254, 154);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 34);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(132, 154);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 34);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(10, 154);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(116, 34);
            this.buttonDetail.TabIndex = 3;
            this.buttonDetail.Text = "Detail...";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 123);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBoxInvoiceTotal
            // 
            this.groupBoxInvoiceTotal.Controls.Add(this.textBoxGrandTotalFC);
            this.groupBoxInvoiceTotal.Controls.Add(this.textBoxKdvFC);
            this.groupBoxInvoiceTotal.Controls.Add(this.labelgrandTotalFC);
            this.groupBoxInvoiceTotal.Controls.Add(this.labelKdvFC);
            this.groupBoxInvoiceTotal.Controls.Add(this.labelTotalAmountFC);
            this.groupBoxInvoiceTotal.Controls.Add(this.textBoxTotalAmountFC);
            this.groupBoxInvoiceTotal.Controls.Add(this.textBoxGrandTotal);
            this.groupBoxInvoiceTotal.Controls.Add(this.textBoxKdv);
            this.groupBoxInvoiceTotal.Controls.Add(this.textBoxTotalAmount);
            this.groupBoxInvoiceTotal.Controls.Add(this.labelGrandTotal);
            this.groupBoxInvoiceTotal.Controls.Add(this.labelKdv);
            this.groupBoxInvoiceTotal.Controls.Add(this.labelTotalAmount);
            this.groupBoxInvoiceTotal.Location = new System.Drawing.Point(46, 556);
            this.groupBoxInvoiceTotal.Name = "groupBoxInvoiceTotal";
            this.groupBoxInvoiceTotal.Size = new System.Drawing.Size(1122, 135);
            this.groupBoxInvoiceTotal.TabIndex = 7;
            this.groupBoxInvoiceTotal.TabStop = false;
            this.groupBoxInvoiceTotal.Text = "Invoice Amounts";
            // 
            // textBoxGrandTotalFC
            // 
            this.textBoxGrandTotalFC.Location = new System.Drawing.Point(376, 76);
            this.textBoxGrandTotalFC.Name = "textBoxGrandTotalFC";
            this.textBoxGrandTotalFC.Size = new System.Drawing.Size(136, 26);
            this.textBoxGrandTotalFC.TabIndex = 15;
            // 
            // textBoxKdvFC
            // 
            this.textBoxKdvFC.Location = new System.Drawing.Point(376, 46);
            this.textBoxKdvFC.Name = "textBoxKdvFC";
            this.textBoxKdvFC.Size = new System.Drawing.Size(136, 26);
            this.textBoxKdvFC.TabIndex = 14;
            // 
            // labelgrandTotalFC
            // 
            this.labelgrandTotalFC.AutoSize = true;
            this.labelgrandTotalFC.Location = new System.Drawing.Point(176, 79);
            this.labelgrandTotalFC.Name = "labelgrandTotalFC";
            this.labelgrandTotalFC.Size = new System.Drawing.Size(118, 20);
            this.labelgrandTotalFC.TabIndex = 13;
            this.labelgrandTotalFC.Text = "Grand Amount:";
            // 
            // labelKdvFC
            // 
            this.labelKdvFC.AutoSize = true;
            this.labelKdvFC.Location = new System.Drawing.Point(176, 52);
            this.labelKdvFC.Name = "labelKdvFC";
            this.labelKdvFC.Size = new System.Drawing.Size(43, 20);
            this.labelKdvFC.TabIndex = 12;
            this.labelKdvFC.Text = "Kdv: ";
            // 
            // labelTotalAmountFC
            // 
            this.labelTotalAmountFC.AutoSize = true;
            this.labelTotalAmountFC.Location = new System.Drawing.Point(176, 22);
            this.labelTotalAmountFC.Name = "labelTotalAmountFC";
            this.labelTotalAmountFC.Size = new System.Drawing.Size(194, 20);
            this.labelTotalAmountFC.TabIndex = 11;
            this.labelTotalAmountFC.Text = "Foreign Currency Amount:";
            // 
            // textBoxTotalAmountFC
            // 
            this.textBoxTotalAmountFC.Location = new System.Drawing.Point(376, 16);
            this.textBoxTotalAmountFC.Name = "textBoxTotalAmountFC";
            this.textBoxTotalAmountFC.Size = new System.Drawing.Size(136, 26);
            this.textBoxTotalAmountFC.TabIndex = 10;
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Location = new System.Drawing.Point(676, 76);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new System.Drawing.Size(148, 26);
            this.textBoxGrandTotal.TabIndex = 9;
            // 
            // textBoxKdv
            // 
            this.textBoxKdv.Location = new System.Drawing.Point(676, 46);
            this.textBoxKdv.Name = "textBoxKdv";
            this.textBoxKdv.Size = new System.Drawing.Size(148, 26);
            this.textBoxKdv.TabIndex = 8;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(676, 16);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(148, 26);
            this.textBoxTotalAmount.TabIndex = 7;
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Location = new System.Drawing.Point(534, 82);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(118, 20);
            this.labelGrandTotal.TabIndex = 2;
            this.labelGrandTotal.Text = "Grand Amount:";
            // 
            // labelKdv
            // 
            this.labelKdv.AutoSize = true;
            this.labelKdv.Location = new System.Drawing.Point(534, 52);
            this.labelKdv.Name = "labelKdv";
            this.labelKdv.Size = new System.Drawing.Size(39, 20);
            this.labelKdv.TabIndex = 1;
            this.labelKdv.Text = "Kdv:";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(534, 22);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(108, 20);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Total Amount:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(726, 697);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 34);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Location = new System.Drawing.Point(604, 697);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(116, 34);
            this.buttonInvoice.TabIndex = 9;
            this.buttonInvoice.Text = "Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            // 
            // textBoxSerino
            // 
            this.textBoxSerino.Location = new System.Drawing.Point(559, 701);
            this.textBoxSerino.Name = "textBoxSerino";
            this.textBoxSerino.Size = new System.Drawing.Size(39, 26);
            this.textBoxSerino.TabIndex = 3;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 743);
            this.Controls.Add(this.textBoxSerino);
            this.Controls.Add(this.buttonInvoice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxInvoiceTotal);
            this.Controls.Add(this.groupBoxInvoiceLines);
            this.Controls.Add(this.groupBoxFaturaBilgisi);
            this.Controls.Add(this.groupBoxMüsteriBilgileri);
            this.Name = "MainPage";
            this.Text = "Customer Invoicing System";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBoxMüsteriBilgileri.ResumeLayout(false);
            this.groupBoxMüsteriBilgileri.PerformLayout();
            this.groupBoxFaturaBilgisi.ResumeLayout(false);
            this.groupBoxFaturaBilgisi.PerformLayout();
            this.groupBoxInvoiceLines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInvoiceTotal.ResumeLayout(false);
            this.groupBoxInvoiceTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMüsteriBilgileri;
        private System.Windows.Forms.Label labelCustomerCode;
        private System.Windows.Forms.ComboBox comboBoxContract;
        private System.Windows.Forms.Label labelAgreements;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.Label labelCurrentAccount;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxAccountCode;
        private System.Windows.Forms.GroupBox groupBoxFaturaBilgisi;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxInvoiceLines;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPullExcell;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.GroupBox groupBoxInvoiceTotal;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelKdv;
        private System.Windows.Forms.TextBox textBoxGrandTotal;
        private System.Windows.Forms.TextBox textBoxKdv;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.Button buttonGetAccount;
        private System.Windows.Forms.TextBox textBoxSerino;
        private System.Windows.Forms.TextBox textBoxGrandTotalFC;
        private System.Windows.Forms.TextBox textBoxKdvFC;
        private System.Windows.Forms.Label labelgrandTotalFC;
        private System.Windows.Forms.Label labelKdvFC;
        private System.Windows.Forms.Label labelTotalAmountFC;
        private System.Windows.Forms.TextBox textBoxTotalAmountFC;
    }
}

