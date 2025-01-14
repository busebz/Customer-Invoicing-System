using OfficeOpenXml;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace InvoiceForm
{
    public partial class MainPage : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public static int serino;
        public static string explanation;
        public static string currency_type;
        public static double exchange_rate;
        public static double unit_price;
        public static int amount;
        public static double totalAmount;
        public static double totalInFC;
        public static int kdv_rate;
        public static string incomeType;

        public MainPage()
        {
            InitializeComponent(); 
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            AddDataToTable();
            this.Height = 450;
            textBoxSerino.Visible = false;
            CalculateInvoiceAmounts();
            this.ControlBox = true; 
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.SuspendLayout();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddInvoice AddInvoiceForm = new AddInvoice();
            AddInvoiceForm.Show();
            this.Hide();
        }

        void AddDataToTable()
{
    string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        try
        {
            conn.Open();
            da = new SqlDataAdapter();
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Invoice", conn);

            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Invoice");
            dataGridView1.DataSource = ds.Tables["Invoice"];
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row is valid (not the header row)
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                // Debugging: Print out the selected row data
                Console.WriteLine($"Selected Row Index: {index}");
                Console.WriteLine($"Serino: {selectedRow.Cells[0].Value}");
                Console.WriteLine($"Amount: {selectedRow.Cells[1].Value}");

                // Extracting data for the selected row
                serino = int.Parse(selectedRow.Cells[0].Value.ToString());
                amount = int.Parse(selectedRow.Cells[1].Value.ToString());
                explanation = selectedRow.Cells[2].Value.ToString();
                totalAmount = double.Parse(selectedRow.Cells[3].Value.ToString());
                currency_type = selectedRow.Cells[4].Value.ToString();
                totalInFC = double.Parse(selectedRow.Cells[5].Value.ToString());
                kdv_rate = int.Parse(selectedRow.Cells[6].Value.ToString());
                incomeType = selectedRow.Cells[7].Value.ToString();

                // Update the textbox with selected serino value
                textBoxSerino.Text = selectedRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Invalid row selection!");
            }
        }


        private void buttonGetAccount_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    comboBoxAccount.Items.Clear();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand("SELECT Account.account_code, Account.account_name, AccountAddress.account_address_name, AccountContract.account_contract_name " +
                                                   "FROM Account " +
                                                   "INNER JOIN AccountAddress ON AccountAddress.account_id = Account.account_id " +
                                                   "INNER JOIN AccountContract ON AccountContract.account_address_id = AccountAddress.account_address_id " +
                                                   "WHERE account_code = @accountCode", conn);

                    cmd.Parameters.AddWithValue("@accountCode", textBoxAccountCode.Text);  // Using parameterized query to prevent SQL injection

                    conn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxAccount.Items.Add(dr["account_name"]);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public void AmountInvoiceLineCalculation(int totalIndex, int kdvIndex)
        {
            double totalAmount = 0;
            double totalKdv = 0;
            double grandTotal;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    totalAmount += double.Parse(row.Cells[totalIndex].Value.ToString());
                    textBoxTotalAmount.Text = totalAmount.ToString();

                    totalKdv += (double.Parse(row.Cells[totalIndex].Value.ToString()) * double.Parse(row.Cells[kdvIndex].Value.ToString())) / 100;
                    textBoxKdv.Text = totalKdv.ToString();

                    grandTotal = totalAmount + totalKdv;
                    textBoxGrandTotal.Text = grandTotal.ToString();
                }
            }

        }

        public void FCAmountInvoiceLineCalculation(int totalIndex, int kdvIndex)
        {
            double totalAmountFC = 0;
            double totalKdvFC = 0;
            double grandTotalFC;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    totalAmountFC += double.Parse(row.Cells[totalIndex].Value.ToString());
                    textBoxTotalAmountFC.Text = totalAmountFC.ToString();

                    totalKdvFC += (double.Parse(row.Cells[totalIndex].Value.ToString()) * double.Parse(row.Cells[kdvIndex].Value.ToString())) / 100;
                    textBoxKdvFC.Text = totalKdvFC.ToString();

                    grandTotalFC = totalAmountFC + totalKdvFC;
                    textBoxGrandTotalFC.Text = grandTotalFC.ToString();
                }
            }

        }

        //public void FCAmountInvoiceLineCalculationExcel(int totalIndex, int currencyIndex, int kdvIndex)
        //{
        //    double totalAmountFC = 0;
        //    double totalKdvFC = 0;
        //    double grandTotalFC;

        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (!row.IsNewRow)
        //        {
        //            totalAmountFC += double.Parse(row.Cells[totalIndex].Value.ToString()) / double.Parse(row.Cells[currencyIndex].Value.ToString());
        //            textBoxTotalAmountFC.Text = totalAmountFC.ToString();

        //            totalKdvFC += (double.Parse(row.Cells[totalIndex].Value.ToString()) * double.Parse(row.Cells[kdvIndex].Value.ToString())) / 100;
        //            textBoxKdvFC.Text = totalKdvFC.ToString();

        //            grandTotalFC = totalAmountFC + totalKdvFC;
        //            textBoxGrandTotalFC.Text = grandTotalFC.ToString();
        //        }
        //    }

        //}
        public void CalculateInvoiceAmounts()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[4].Value.ToString() == "TL")
                    {
                        AmountInvoiceLineCalculation(3, 6);

                        textBoxTotalAmountFC.Text = "0";
                        textBoxKdvFC.Text = "0";
                        textBoxGrandTotalFC.Text = "0";
                    }
                    else
                    {
                        FCAmountInvoiceLineCalculation(5, 6);
                        AmountInvoiceLineCalculation(3, 6);
                    }
                }
            }
        }
        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                SqlDataReader dr;

                string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("select AccountAddress.account_address_name from Account " +
                                                "inner join AccountAddress on AccountAddress.account_id = Account.account_id " +
                                                "where account_name = @accountName", conn);

                        cmd.Parameters.Add(new SqlParameter("@accountName", SqlDbType.NVarChar)).Value = comboBoxAccount.SelectedItem.ToString();

                        conn.Open();
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            comboBoxAddress.Items.Add(dr["account_address_name"]);
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }

        private void comboBoxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                SqlDataReader dr;

                string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("select AccountContract.account_contract_name from AccountAddress " +
                                                "inner join AccountContract on AccountContract.account_address_id = AccountAddress.account_address_id " +
                                                "where account_address_name = @accountAddressName", conn);

                        cmd.Parameters.Add(new SqlParameter("@accountAddressName", SqlDbType.NVarChar)).Value = comboBoxAddress.SelectedItem.ToString();

                        conn.Open();
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            comboBoxContract.Items.Add(dr["account_contract_name"]);
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }         
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string add = "Delete from Invoice where serino = @serino";
            SqlCommand command = new SqlCommand(add, conn);

            command.Parameters.AddWithValue("@serino", int.Parse(textBoxSerino.Text));

            command.ExecuteNonQuery();

            conn.Close();
            AddDataToTable();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            AddInvoice addInvoicePage = new AddInvoice();
            this.Hide();
            addInvoicePage.ShowDialog();
        }

        private bool CheckIfColumnIsEmpty(string filePath, int columnIndex)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Invoice"];

                int rowCount = worksheet.Dimension.Rows;
                for (int row = 1; row <= rowCount; row++)
                {
                    var cellValue = worksheet.Cells[row, columnIndex].Text;
                    if (!string.IsNullOrWhiteSpace(cellValue))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void buttonPullExcell_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
            o.Title = "Select File";
            if (o.ShowDialog() == DialogResult.OK)
            {
                int count = 0;
                OleDbConnection connect;
                connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + o.FileName + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                connect.Open();
                OleDbDataAdapter adap = new OleDbDataAdapter("Select * from [Invoice$]", connect);
                OleDbCommand command = new OleDbCommand("SELECT COUNT(Para_Birimi) FROM[Invoice$]", connect);
                OleDbCommand command1 = new OleDbCommand("SELECT Para_Birimi FROM[Invoice$]", connect);
                count = Convert.ToInt32(command.ExecuteScalar());

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (!row.IsNewRow)
                //    {
                //        using (OleDbDataReader reader = command.ExecuteReader())
                //        {
                //            while (reader.Read())
                //            {
                //                for(int i = 1; i <= count; i++)
                //                {
                //                    for(int j = 1; j <= row.Cells.Count; j++)
                //                    {
                //                        if (reader[i].ToString() != row.Cells[4].Value.ToString())
                //                        {
                //                            MessageBox.Show("Değerleri eşitle", "Input error");
                //                            return;
                //                        }
                //                        else
                //                        {
                                            
                //                        }
                //                    }
                //                }
                //            }
                //        }
                        
                //    }
                //}
                        //if (adap1 == null)
                        //{
                        //    AmountInvoiceLineCalculation(1, 2);

                        //    textBoxTotalAmountFC.Text = "0";
                        //    textBoxKdvFC.Text = "0";
                        //    textBoxGrandTotalFC.Text = "0";
                        //}
                        //else
                        //{
                        //    FCAmountInvoiceLineCalculationExcel(1, 6, 2);
                        //    AmountInvoiceLineCalculation(1, 2);
                        //}

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                connect.Close();
            } 
        }
    }

}


