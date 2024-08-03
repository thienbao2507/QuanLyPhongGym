using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Globalization;
using System.CodeDom.Compiler;
using System.Security.Policy;

namespace GUI
{
    public partial class GRN : Form
    {
        DateTime currentDate = DateTime.Now;
        BUS_PhieuNhapKho busGRN = new BUS_PhieuNhapKho();
        //Chuỗi kết nối đến cơ sở dữ liệu SQL Server
        string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";
        public GRN()
        {
            InitializeComponent();
            LoadEquipment(Mediator.GrnID);
            LoadSupplier(Mediator.SupplierID);
            LoadDate();
            lbTotal.Text = NumberToText(TongTien()).ToString();

        }
        private void LoadSupplier(int SupplierID)
        {
            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT Name FROM Suppliers WHERE SupplierID = @SupplierID";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", SupplierID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            lbSupplier.Text = reader["Name"].ToString(); 
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dịch vụ với ID đã cho.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
        }
        private void LoadDate()
        {

            // Extract day, month, and year
            int day = currentDate.Day;
            int month = currentDate.Month;
            int year = currentDate.Year;

            lbDate.Text = "Ngày " + day + " tháng " + month + " năm " + year;
            lbDate1.Text = "Ngày " + day + " tháng " + month + " năm " + year;
        }
        private void LoadEquipment(int GrnID)
        {

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT EquipmentID, GrnID, Name, Quantity, UnitPrice, MaintenanceStatus, Description FROM Equipment WHERE GrnID = @GrnID";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@GrnID", GrnID);
                    try
                    {
                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dgvEq.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private decimal TongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvEq.Rows)
            {
                try
                {
                    // Check if the cells are not null and are not new rows (header/footer)
                    if (row.Cells["UnitPrice"].Value != null && row.Cells["Quantity"].Value != null && !row.IsNewRow)
                    {
                        // Safely convert UnitPrice and Quantity to their respective types
                        decimal unitPrice;
                        int quantity;

                        bool unitPriceParsed = decimal.TryParse(row.Cells["UnitPrice"].Value.ToString(), out unitPrice);
                        bool quantityParsed = int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity);

                        // Ensure both values are successfully parsed before performing the calculation
                        if (unitPriceParsed && quantityParsed)
                        {
                            total += unitPrice * quantity;
                        }
                        else
                        {
                            // Handle the case where parsing fails, e.g., log the error or show a message
                            MessageBox.Show("Invalid data in UnitPrice or Quantity. UnitPrice: " + row.Cells["UnitPrice"].Value + ", Quantity: " + row.Cells["Quantity"].Value);
                        }
                    }
                    else
                    {
                        //// Handle the case where cell values are null
                        //MessageBox.Show("UnitPrice or Quantity is missing in one of the rows.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any unexpected exceptions
                    MessageBox.Show("Error processing row: " + ex.Message);
                }
            }
            txtTongTien.Text = total.ToString();
            return total;
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo DTO
                DTO_GRN tb = new DTO_GRN(0, Mediator.SupplierID, currentDate, TongTien(), txtNote.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                                                                                                                                          //thEq
                if (busGRN.addGRN(tb))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadEquipment(Mediator.GrnID); ; // refresh datagridview
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là một số nguyên.");
            }
        }

        public static string NumberToText(decimal inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }

        private void btView_Click(object sender, EventArgs e)
        {
            GRN_view form = new GRN_view();
            form.Show();
        }

        //private static string CapitalizeFirstLetter(string input)
        //{
        //    if (string.IsNullOrEmpty(input)) return input;
        //    return char.ToUpper(input[0]) + input.Substring(1);
        //}


    }
}
