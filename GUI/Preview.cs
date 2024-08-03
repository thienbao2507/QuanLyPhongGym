using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            LoadInforMember(Mediator.MemberID);
            LoadInforGS(Mediator.MemberID);
        }

        private void LoadInforGS(string MemberID)
        {
            lbGS.Text = Mediator.GoiTap.ToString();
            lbTotal.Text = Mediator.ThanhTien.ToString();
            lbSHD.Text = Mediator.SoHD.ToString();
            lbDate.Text = Mediator.Date.ToString();
        }
        private void LoadInforMember(string MemberID)
        {

            // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu lệnh SQL để lấy địa chỉ từ bảng Member
            string sqlQueryAddress = "SELECT Address FROM Member WHERE MemberID = @MemberID";

            // Câu lệnh SQL để lấy số điện thoại từ bảng Member
            string sqlQueryPhoneNumber = "SELECT PhoneNumber FROM Member WHERE MemberID = @MemberID";

            string sqlQueryName = "SELECT LastName,FirstName FROM Member WHERE MemberID = @MemberID";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand commandName = new SqlCommand(sqlQueryName, connection))
                {
                    commandName.Parameters.AddWithValue("@MemberID", MemberID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = commandName.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc giá trị từ SqlDataReader
                            string name = reader["FirstName"].ToString() +" "+ reader["LastName"].ToString();

                            // Gán giá trị vào một control trên form
                            txtName.Text = name;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin họ tên cho thành viên có ID này.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                // Lấy địa chỉ
                using (SqlCommand commandAddress = new SqlCommand(sqlQueryAddress, connection))
                {
                    commandAddress.Parameters.AddWithValue("@MemberID", MemberID);
                    try
                    {
                        SqlDataReader reader = commandAddress.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc giá trị từ SqlDataReader
                            string address = reader["Address"].ToString();

                            // Gán giá trị vào một control trên form
                            txtAddress.Text = address;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin địa chỉ cho thành viên có ID này.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                // Lấy số điện thoại
                using (SqlCommand commandPhoneNumber = new SqlCommand(sqlQueryPhoneNumber, connection))
                {
                    commandPhoneNumber.Parameters.AddWithValue("@MemberID", MemberID);
                    try
                    {
                        SqlDataReader reader = commandPhoneNumber.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc giá trị từ SqlDataReader
                            string phoneNumber = reader["PhoneNumber"].ToString();

                            // Gán giá trị vào một control trên form
                            txtPhoneNum.Text = phoneNumber;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin số điện thoại cho thành viên có ID này.");
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
    }
}
