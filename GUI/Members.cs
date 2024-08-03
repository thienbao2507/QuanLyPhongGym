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
using System.Runtime.InteropServices.ComTypes;


namespace GUI
{
    public partial class Members : Form
    {
        BUS_KhachHang busCus = new BUS_KhachHang();
        BUS_GoiTap tap = new BUS_GoiTap();  
        public Members()
        {
            InitializeComponent();
            LoadGymService();
            dgvCus.DataSource = busCus.getCustomer(); // refresh datagridview
        }
        private void GUI_ManMem_Load(object sender, EventArgs e)
        {
            dgvCus.DataSource = busCus.getCustomer(); // get Nhân viên
        }
        private bool isCheckInf()
        {
            if (cbSer.ToString() == null)
            {
                MessageBox.Show("Vui lòng chọn Công Việc!!");
                return false;
            }

            if (txtHoKH.Text == "" && txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đầy đủ!!");
                return false;
            }
            if (txtPhoneKH.Text[0] != '0' || txtPhoneKH.Text.Trim().Length != 10)
            {

                MessageBox.Show("Vui lòng nhập số điện thoại đủ số!!");
                return false;
            }
            string[] arr = txtPhoneKH.Text.Trim().ToCharArray().Select(c => c.ToString()).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i], 0))
                {
                    MessageBox.Show("số không thể có ký tự khác");
                    return false;

                }
            }
            return true;
        }
        //public DateTime EndDate(int serID)
        //{
        //    switch (serID)
        //    {
        //        case 1:
        //            Mediator.ed = joiningDate.Value.AddMonths(3); 
        //            break;
        //        case 2:
        //            Mediator.ed = joiningDate.Value.AddMonths(3);
        //            break;
        //        case 3:
        //            Mediator.ed = joiningDate.Value.AddMonths(3);
        //            break;
        //        case 4:
        //            Mediator.ed = joiningDate.Value.AddMonths(3);
        //            break;
        //        case 5:
        //            Mediator.ed = joiningDate.Value.AddMonths(3);
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException("Unknown service ID");
        //    }
        //}
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (isCheckInf()==true)
            {
                DateTime txtDOB = dOBKH.Value;
                string txtGender = rdMaleKH.Checked ? "Male" : "Female";
                DateTime txtDJ = joiningDate.Value;
                string txtSerID = cbSer.Text;
                string []arr= txtSerID.Split(':');
                int serID = int.Parse(arr[0]);
                DateTime txtED= DateTime.MinValue;

                Mediator.ed = joiningDate.Value.AddMonths(tap.getTime(serID));
                //switch (serID)
                //{
                //    case 1:
                //        Mediator.ed = joiningDate.Value.AddMonths(3);
                //        break;
                //    case 2:
                //        Mediator.ed = joiningDate.Value.AddMonths(3);
                //        break;
                //    case 3:
                //        Mediator.ed = joiningDate.Value.AddMonths(3);
                //        break;
                //    case 4:
                //        Mediator.ed = joiningDate.Value.AddMonths(3);
                //        break;
                //    case 5:
                //        Mediator.ed = joiningDate.Value.AddMonths(3);
                //        break;
                //    default:
                //        throw new ArgumentOutOfRangeException("Unknown service ID");
                //}


                // Tạo DTO
                DTO_Customer kh = new DTO_Customer(0, txtHoKH.Text, txtTenKH.Text, txtDOB, txtPhoneKH.Text, txtGender,  txtAddressKH.Text, txtDJ, txtMS.Text, serID,Mediator.ed);
                if (busCus.addCustomer(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvCus.DataSource = busCus.getCustomer(); // refresh datagridview
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
            if (dgvCus.SelectedRows.Count > 0)
            {
                if (isCheckInf() == true)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvCus.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //lấy các giá trị từ winform
                    DateTime txtDOB = dOBKH.Value;
                    string txtGender = rdMaleKH.Checked ? "Male" : "Female";
                    DateTime txtjD = joiningDate.Value;
                    string txtSerID = cbSer.Text;
                    int serID = int.Parse(txtSerID.Trim().Split(':')[0]);
                    Mediator.ed = joiningDate.Value.AddMonths(tap.getTime(serID));
                    // Tạo DTo
                    DTO_Customer kh = new DTO_Customer(ID, txtHoKH.Text, txtTenKH.Text, txtDOB, txtPhoneKH.Text, txtGender,  txtAddressKH.Text,  txtjD, txtMS.Text, serID,Mediator.ed);
                    // Sửa
                    if (busCus.editCustomer(kh))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvCus.DataSource = busCus.getCustomer(); // refresh datagridview
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

        private void dgvCus_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCus.SelectedRows.Count > 0)
            {
                //lấy  phần tử được chọn
                DataGridViewRow selectedRow = dgvCus.SelectedRows[0];

                txtHoKH.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtTenKH.Text = selectedRow.Cells["LastName"].Value.ToString();
                //gắn giá trị cho DateTimePicker-Ngày sinh
                string dateString = selectedRow.Cells["DateOfBirth"].Value.ToString();
                dOBKH.Value = DateTime.TryParse(dateString, out DateTime date) ? date : dOBKH.Value;

                string txtGender = selectedRow.Cells["GenDer"].Value.ToString();
                //Gán giá trị cho RadioButton
                if (txtGender.Trim() == "Male")
                {
                    rdMaleKH.Checked = true;
                }
                else if (txtGender.Trim() == "Female")
                {
                    rdFemaleKH.Checked = true;
                }
                txtAddressKH.Text = selectedRow.Cells["Address"].Value.ToString();
                txtPhoneKH.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();

                string dateString1 = selectedRow.Cells["JoiningDate"].Value.ToString();
                joiningDate.Value = DateTime.TryParse(dateString1, out DateTime date1) ? date1 : joiningDate.Value;
                
                txtMS.Text = selectedRow.Cells["MemberStatus"].Value.ToString();

                string str_SerID = selectedRow.Cells["ServiceID"].Value.ToString();
                cbSer.Text = str_SerID;
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgvCus.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvCus.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busCus.delCustomer(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvCus.DataSource = busCus.getCustomer(); // refresh datagridview
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
        private void LoadGymService()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu truy vấn SQL
            string query = "SELECT ServiceID,Name FROM GymService";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        cbSer.Items.Clear();
                        while (reader.Read())
                        {
                            cbSer.Items.Add(string.Format("{0}:{1}", reader["ServiceID"], reader["Name"]));
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

        private void btFindID_Click(object sender, EventArgs e)
        {       

                // Lấy dữ liệu hiện tại từ DataGridView
                DataTable dataTable = dgvCus.DataSource as DataTable;

                if (dataTable != null)
                {
                    // Tạo một DataView để lọc dữ liệu
                    DataView dataView = new DataView(dataTable);
                    dataView.RowFilter = $"LastName LIKE '%{txtFindName.Text.Trim()}%'";

                    // Cập nhật DataGridView với dữ liệu đã lọc
                    dgvCus.DataSource = dataView;
                }
            
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            dgvCus.DataSource = busCus.getCustomer(); // refresh datagridview
            txtFindName.Text = "";
        }
    }
}
