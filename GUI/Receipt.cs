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


namespace GUI
{
    public partial class Receipt : Form
    {
        BUS_HoaDon busReceipt = new BUS_HoaDon();
        private int soHD = 1;
        public Receipt()
        {
            InitializeComponent();
            LoadMember();
            LoadGymService();
            LoadEmployee();
            Mediator.Date = dateHD.Value;
            //Console.OutputEncoding = Encoding.UTF8;
            dgvHd.DataSource = busReceipt.getReceipt(); // refresh datagridview
        }
        private void GUI_Receipt_Load(object sender, EventArgs e)
        {
            dgvHd.DataSource = busReceipt.getReceipt(); // get Nhân viên
        }
        private void LoadGymService()
        {
            //Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT Name,ServiceID FROM GymService";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Xóa tất cả các mục hiện có trong ComboBox trước khi thêm mới
                        cbGS.Items.Clear();
                        // Duyệt qua các dòng dữ liệu từ SqlDataReader và thêm vào ComboBox
                        while (reader.Read())
                        {
                            //comboBox1.Items.Add(reader["IdService"].ToString());
                            cbGS.Items.Add(string.Format("{0}:{1}", reader["ServiceID"], reader["Name"]));
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
        private void LoadMember()
        {
            //Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT MemberID, LastName, FirstName FROM Member";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Xóa tất cả các mục hiện có trong ComboBox trước khi thêm mới
                        cbMember.Items.Clear();
                        // Duyệt qua các dòng dữ liệu từ SqlDataReader và thêm vào ComboBox
                        while (reader.Read())
                        {
                            //comboBox1.Items.Add(reader["IdService"].ToString());
                            cbMember.Items.Add(string.Format("{0}:{1} {2}", reader["MemberID"], reader["FirstName"], reader["LastName"]));
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
        private void LoadTotal(string ServiceID)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT Price FROM GymService WHERE ServiceID = @ServiceID";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@ServiceID", ServiceID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc giá trị từ SqlDataReader
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            Mediator.ThanhTien = price;
                            // Gán giá trị vào một control trên form, ví dụ như một Label
                            lbTotal.Text = price.ToString(); // Giả sử lblPrice là một Label trên form
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
        private void LoadInfor(string MemberID)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu lệnh SQL để lấy địa chỉ từ bảng Member
            string sqlQueryAddress = "SELECT Address FROM Member WHERE MemberID = @MemberID";

            // Câu lệnh SQL để lấy số điện thoại từ bảng Member
            string sqlQueryPhoneNumber = "SELECT PhoneNumber FROM Member WHERE MemberID = @MemberID";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Lấy địa chỉ
                using (SqlCommand commandAddress = new SqlCommand(sqlQueryAddress, connection))
                {
                    commandAddress.Parameters.AddWithValue("@MemberID", MemberID);
                    try
                    {
                        connection.Open();
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
        public void LoadEmployee()
        {
            lbEmployee.Text = Mediator.NameEmployee;
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (cbMember.Text != "" && cbGS.Text != "")
            {
                //lấy các giá trị từ winform
                //string txtIdRole = cbRole.Text.Trim().Split(':')[0];
                DateTime txtHD = dateHD.Value;
                string EmployeeID = lbEmployee.Text.Trim().Split(':')[0];
                string GsID = cbGS.Text.Trim().Split(':')[0];
                string MemberID = cbMember.Text.Trim().Split(':')[0];
                int total = int.Parse(lbTotal.Text);

                // Tạo DTO
                DTO_Receipt tv = new DTO_Receipt(0, EmployeeID, GsID, MemberID, txtHD, total, txtNote.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                //them
                if (busReceipt.addReceipt(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHd.DataSource = busReceipt.getReceipt(); // refresh datagridview
                    soHD++;
                    Mediator.SoHD = soHD;
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvHd.SelectedRows.Count > 0)
            {
                if (cbMember.Text != "" && cbGS.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvHd.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //lấy các giá trị từ winform
                    string EmployeeID = lbEmployee.Text.Trim().Split(':')[0];
                    string GsID = cbGS.Text.Trim().Split(':')[0];
                    string MemberID = cbMember.Text.Trim().Split(':')[0];
                    int total = int.Parse(lbTotal.Text);
                    DateTime txtHD = dateHD.Value;

                  
                    DTO_Receipt tv = new DTO_Receipt(ID, EmployeeID, GsID, MemberID, txtHD, total, txtNote.Text);
                    // Sửa
                    if (busReceipt.editReceipt(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvHd.DataSource = busReceipt.getReceipt(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }
        //khi click vào 1 dòng trên dgv sẽ hiện lên lại các thông tin của dòng đó
        public void dgvHd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHd.SelectedRows.Count > 0)
            {
                //lấy  phần tử được chọn
                DataGridViewRow selectedRow = dgvHd.SelectedRows[0];

                lbEmployee.Text = selectedRow.Cells["EmployeeID"].Value.ToString() ;
                string str_GymService = selectedRow.Cells["ServiceID"].Value.ToString();
                cbGS.Text = str_GymService;
                string str_Member = selectedRow.Cells["MemberID"].Value.ToString();
                cbMember.Text = str_GymService;
                //Gắn họ tên lên textBox
                lbTotal.Text = selectedRow.Cells["Total"].Value.ToString();
                //gắn giá trị cho DateTimePicker-Ngày sinh
                string dateString = selectedRow.Cells["Date"].Value.ToString();
                dateHD.Value = DateTime.TryParse(dateString, out DateTime date) ? date : dateHD.Value;

                txtNote.Text = selectedRow.Cells["Note"].Value.ToString();

            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvHd.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvHd.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busReceipt.delReceipt(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHd.DataSource = busReceipt.getReceipt(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void cbGS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGS.SelectedItem != null)
            {
                Mediator.GoiTap = cbGS.Text.ToString().Split(':')[1];
                LoadTotal(cbGS.SelectedItem.ToString().Split(':')[0]);
            }
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            Preview preview = new Preview();
            preview.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMember.SelectedItem != null)
            {
                LoadInfor(cbMember.SelectedItem.ToString().Split(':')[0]);
                Mediator.MemberID = cbMember.Text.Trim().Split(':')[0];
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            int receiptId;
            if (int.TryParse(this.txtSoHD.Text, out receiptId))
            {
                DTO_Receipt receipt = busReceipt.searchReceipt(receiptId);
                // Lấy dữ liệu hiện tại từ DataGridView
                DataTable dataTable = dgvHd.DataSource as DataTable;

                if (receipt != null)
                {
                    this.lbEmployee.Text = receipt.ID_Employee;
                    this.cbGS.Text = receipt.ID_Service;
                    this.cbMember.Text = receipt.ID_Member;
                    this.dateHD.Value = receipt.Date;
                    this.txtNote.Text =receipt.Note;

                    // Tạo một DataView để lọc dữ liệu
                    DataView dataView = new DataView(dataTable);
                    dataView.RowFilter = $"ReceiptID = '{receiptId}'";

                    // Cập nhật DataGridView với dữ liệu đã lọc
                    dgvHd.DataSource = dataView;
                }
                else
                {
                    MessageBox.Show("Receipt not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Invalid Receipt ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMember_TextChanged(object sender, EventArgs e)
        {
            LoadInfor(cbMember.Text.ToString().Split(':')[0]);
            Mediator.MemberID = cbMember.Text.Trim().Split(':')[0];
        }

        private void cbGS_TextChanged(object sender, EventArgs e)
        {
            Mediator.GoiTap = cbGS.Text;
            LoadTotal(cbGS.Text.ToString().Split(':')[0]);
        }
    }
}
