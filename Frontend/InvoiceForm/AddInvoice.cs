using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InvoiceForm
{
    public partial class AddInvoice : Form
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
        public AddInvoice()
        {
            InitializeComponent();
            textBoxExchangeRate.KeyPress += NumericTextBox_KeyPress;
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {
            AddCurrencyTypeToCombobox();
            AddIncomeTypesToCombobox();
            AddKdvRate();
            DetailInvoice();
            textBoxSerino.Visible = false;
            textBoxTotal.Enabled = false;
            textBoxAmountInFC.Enabled = false;
            comboBoxCurrencyType.Enabled = false;
            textBoxExchangeRate.Text = "0";
            textBoxExchangeRate.Enabled = false;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.SuspendLayout();
        }

        public void DetailInvoice()
        {
            textBoxSerino.Text = MainPage.serino.ToString();
            textBoxExplanation.Text = MainPage.explanation;
            comboBoxCurrencyType.SelectedItem = MainPage.currency_type;
            textBoxExchangeRate.Text = (MainPage.totalAmount / MainPage.totalInFC).ToString();
            textBoxUnitPrice.Text = MainPage.totalAmount.ToString();
            textBoxAmount.Text = MainPage.amount.ToString();
            textBoxTotal.Text = MainPage.totalAmount.ToString();
            textBoxAmountInFC.Text = MainPage.totalInFC.ToString();
            comboBoxKdvRate.SelectedItem = MainPage.kdv_rate;
            comboBoxIncomeTypes.SelectedItem = MainPage.incomeType;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage main_page = new MainPage();
            main_page.Show();
        }

        public void AddCurrencyTypeToCombobox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CurrencyType", conn);
                    command.CommandType = CommandType.Text;

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxCurrencyType.Items.Add(dr["currency_name"]);
                    }
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


        public void AddIncomeTypesToCombobox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LovIncomeType", conn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxIncomeTypes.Items.Add(dr["incometype_name"]);
                    }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query;
                    SqlCommand command;

                    command = new SqlCommand("", conn);

                    command.Parameters.AddWithValue("@quantity", int.Parse(textBoxAmount.Text));
                    command.Parameters.AddWithValue("@explanation", textBoxExplanation.Text);
                    command.Parameters.AddWithValue("@amount", int.Parse(textBoxTotal.Text));
                    command.Parameters.AddWithValue("@fc_type", comboBoxCurrencyType.SelectedItem?.ToString() ?? "TL");
                    command.Parameters.AddWithValue("@fc_amount", double.TryParse(textBoxAmountInFC.Text, out double fcAmount) ? fcAmount : 0);
                    command.Parameters.AddWithValue("@kdv_rate", int.Parse(comboBoxKdvRate.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@income_type", comboBoxIncomeTypes.SelectedItem?.ToString() ?? "Default");

                    if (textBoxSerino.Text == "0")
                    {
                        query = "INSERT INTO Invoice(quantity, explanation, amount, fc_type, fc_amount, kdv_rate, income_type) " +
                                "VALUES (@quantity, @explanation, @amount, @fc_type, @fc_amount, @kdv_rate, @income_type)";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        query = "UPDATE Invoice SET quantity = @quantity, explanation = @explanation, amount = @amount, " +
                                "fc_type = @fc_type, fc_amount = @fc_amount, kdv_rate = @kdv_rate, income_type = @income_type " +
                                "WHERE serialno = @serino";
                        command.Parameters.AddWithValue("@serino", int.Parse(textBoxSerino.Text));
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }

                    conn.Close();
                    this.Hide();
                    MainPage main_page = new MainPage();
                    main_page.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void AddKdvRate()
        {
            comboBoxKdvRate.Items.Add(10);
            comboBoxKdvRate.Items.Add(20);
        }

        private void checkBoxFCInvoice_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "SELECT COUNT(*) FROM Invoice WHERE fc_type = 'TL'";
                    SqlCommand command = new SqlCommand(add, conn);
                    command.ExecuteNonQuery();
                    int count = (int)command.ExecuteScalar();
                    if (count >= 1)
                    {
                        comboBoxCurrencyType.Enabled = false;
                        textBoxExchangeRate.Enabled = false;
                    }
                    else
                    {
                        comboBoxCurrencyType.Enabled = true;
                        textBoxExchangeRate.Enabled = true;
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

        public double FCTotalCalculation()
        {
            double totalInFC;
            double unitPrice;
            double exchangeRate;

            if (Double.TryParse(textBoxUnitPrice.Text, out unitPrice) && Double.TryParse(textBoxExchangeRate.Text, out exchangeRate))
            {
                if (unitPrice == 0 || exchangeRate == 0)
                {
                    totalInFC = 0;
                }
                else
                {
                    totalInFC = unitPrice / exchangeRate;
                    totalInFC = Math.Round(totalInFC, 2);
                }
            }
            else
            {
                totalInFC = 0;
            }

            return totalInFC;
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            AmountCalculation();
        }

        public void AmountCalculation()
        {
            if (double.TryParse(textBoxAmount.Text, out double amount))
            {
                if (double.TryParse(textBoxAmountInFC.Text, out double totalInFC) &&
                    double.TryParse(textBoxTotal.Text, out double total))
                {
                    totalInFC *= amount;
                    total *= amount;

                    textBoxAmountInFC.Text = totalInFC.ToString();
                    textBoxTotal.Text = total.ToString();
                }
                else
                {

                }
            }
            else
            {

            }

        }

        private void textBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxUnitPrice.Text;
            textBoxAmountInFC.Text = FCTotalCalculation().ToString();
        }

        private void textBoxExchangeRate_TextChanged(object sender, EventArgs e)
        {
            textBoxAmountInFC.Text = FCTotalCalculation().ToString();
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ',' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Döviz Kurunu Düzgün Formatta Girin!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (((TextBox)sender).Text.Contains(","))
            {
                string[] parts = ((TextBox)sender).Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 4)
                {
                    e.Handled = true;
                    MessageBox.Show("Daha fazla sayı giremezsin!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        


        private void textBoxAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void comboBoxCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCurrencyType.SelectedItem != null)
            {
                string selectedValue = comboBoxCurrencyType.SelectedItem.ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Invoice WHERE fc_type = @SelectedValue", conn);
                        command.Parameters.AddWithValue("@SelectedValue", selectedValue);
                        conn.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count <= 0)
                        {
                            MessageBox.Show("You must select a currency type that appears earlier in the invoice lines.", "Input Error");
                            comboBoxCurrencyType.SelectedIndex = comboBoxCurrencyType.SelectedIndex > 0 ? 0 : 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error");
                    }
                }
            }
        }


    }
}

