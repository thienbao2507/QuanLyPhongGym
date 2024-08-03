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


namespace GUI
{
    public partial class Employee : Form
    {
        //Chuỗi kết nối đến cơ sở dữ liệu SQL Server
        string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";
        BUS_NhanVien busEmployee=new BUS_NhanVien();
        public Employee()
        {
            InitializeComponent();
            LoadRole();
            LoadRank();
            //Console.OutputEncoding = Encoding.UTF8;
            dgvEM.DataSource = busEmployee.getEmployee(); // refresh datagridview
        }
        private void LoadRole()
        {
  
           

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT RoleName,RoleID FROM Role";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Xóa tất cả các mục hiện có trong ComboBox trước khi thêm mới
                        cbRole.Items.Clear();

                        // Duyệt qua các dòng dữ liệu từ SqlDataReader và thêm vào ComboBox
                        while (reader.Read())
                        {
                            //comboBox1.Items.Add(reader["IdService"].ToString());
                            cbRole.Items.Add(string.Format("{0}:{1}", reader["RoleID"], reader["RoleName"]));
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
        private void LoadRank()
        {

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT Name,IdRank FROM RankControl";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Xóa tất cả các mục hiện có trong ComboBox trước khi thêm mới
                        cbRanking.Items.Clear();
                        // Duyệt qua các dòng dữ liệu từ SqlDataReader và thêm vào ComboBox
                        while (reader.Read())
                        {
                            //comboBox1.Items.Add(reader["IdService"].ToString());
                            cbRanking.Items.Add(string.Format("{0}:{1}", reader["IdRank"], reader["Name"]));
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
        string[] daysOfWeek = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật" };
        string dayWorkCode;
        string str;
        private bool isAccount()
        {
            if (txtTK.Text != "" && txtMk.Text != "")
            {
                //xử lý 
                string tk = txtTK.Text.Trim();
                string mk = txtMk.Text.Trim();
                if (busEmployee.checkAccount(tk, mk) == true)
                {
                    MessageBox.Show("Tài khoản đã bị tồn tại vui lòng nhập tạo lại!!!");
                    return true; 
                }
                return false;
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ tài khoản mật khẩu");
                return true;
            }
        }
        private bool isCheckInf()
        {
            if (cbRole.ToString() == null)
            {
                MessageBox.Show("Vui lòng chọn Công Việc!!");
                return false;
            }
                
            if (txtHo.Text == "" && txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đầy đủ!!");
                return false;
            }
            if (txtPhone.Text[0] != '0' || txtPhone.Text.Trim().Length != 10)
            {

                MessageBox.Show("Vui lòng nhập số điện thoại đủ số!!");
                return false;
            }
            string[] arr = txtPhone.Text.Trim().ToCharArray().Select(c => c.ToString()).ToArray();

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
        private void btSubmit_Click(object sender, EventArgs e)
        {
            
            if (isAccount()==false&&isCheckInf()==true)
            {
                //lấy các giá trị từ winform
                string txtIdRole = cbRole.Text.Trim().Split(':')[0];
                DateTime txtDOB = dateOfBirth.Value;
                string txtGender= rdMale.Checked ? "Male" : "Female";

                dayWorkCode = "";
                str = "";
                dayWorkCode += (cbt2.Checked) ? "1" : "0";
                dayWorkCode += (cbt3.Checked) ? "1" : "0";
                dayWorkCode += (cbt4.Checked) ? "1" : "0";
                dayWorkCode += (cbt5.Checked) ? "1" : "0";
                dayWorkCode += (cbt6.Checked) ? "1" : "0";
                dayWorkCode += (cbt7.Checked) ? "1" : "0";
                dayWorkCode += (cbCn.Checked) ? "1" : "0";
                
                char[] chars = dayWorkCode.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == '1')
                    {
                        str += daysOfWeek[i];
                        str += "-";
                    }
                }
                string shiftWork = str.Trim('-');
                int txtRank = int.Parse(cbRanking.Text.Trim().Split(':')[0]);
                // Tạo DTO
                DTO_Employee tv = new DTO_Employee(0,txtIdRole, txtHo.Text, txtTen.Text, txtDOB,txtGender,txtAddress.Text,txtPhone.Text, shiftWork,txtTK.Text,txtMk.Text,txtRank); // Vì ID tự tăng nên để ID số gì cũng dc
                //them
                if (busEmployee.addEmployee(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvEM.DataSource = busEmployee.getEmployee(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                //MessageBox.Show("Thêm thành viên thất bại");
                
            }
        }
        
        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvEM.SelectedRows.Count > 0)
            {
                if (isCheckInf() == true)
                {

                    // Lấy row hiện tại
                    DataGridViewRow row = dgvEM.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xử lý tài khoản mật khẩu
                    if(row.Cells["Account"].Value.ToString()!=txtTK.Text||row.Cells["PassWord"].Value.ToString() != txtMk.Text)
                    {
                        if (isAccount() == true)
                        {
                            return;
                        }
                    }


                    //lấy các giá trị từ winform
                    string txtIdRole = cbRole.Text.Trim().Split(':')[0];
                    DateTime txtDOB = dateOfBirth.Value;
                    string txtGender = rdMale.Checked ? "Male" : "Female";

                    dayWorkCode = "";
                    str = "";
                    dayWorkCode += (cbt2.Checked) ? "1" : "0";
                    dayWorkCode += (cbt3.Checked) ? "1" : "0";
                    dayWorkCode += (cbt4.Checked) ? "1" : "0";
                    dayWorkCode += (cbt5.Checked) ? "1" : "0";
                    dayWorkCode += (cbt6.Checked) ? "1" : "0";
                    dayWorkCode += (cbt7.Checked) ? "1" : "0";
                    dayWorkCode += (cbCn.Checked) ? "1" : "0";

                    char[] chars = dayWorkCode.ToCharArray();
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (chars[i] == '1')
                        {
                            str += daysOfWeek[i];
                            str += "-";
                        }
                    }
                    string shiftWork = str.Trim('-');
                    int txtRank = int.Parse(cbRanking.Text.Trim().Split(':')[0]);
                    // Tạo DTo
                    DTO_Employee tv = new DTO_Employee(ID,txtIdRole, txtHo.Text, txtTen.Text, txtDOB, txtGender, txtAddress.Text, txtPhone.Text, shiftWork, txtTK.Text, txtMk.Text,txtRank);
                    // Sửa
                    if (busEmployee.editEmployee(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvEM.DataSource = busEmployee.getEmployee(); // refresh datagridview
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
        private void dgvEM_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEM.SelectedRows.Count > 0)
            {
                //lấy  phần tử được chọn
                DataGridViewRow selectedRow = dgvEM.SelectedRows[0];

                string str_Role = selectedRow.Cells["RoleID"].Value.ToString();
                cbRole.Text = str_Role;
                string txtRank = selectedRow.Cells["Ranking"].Value.ToString();
                cbRanking.Text = txtRank.ToString();
                //Gắn họ tên lên textBox
                txtHo.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtTen.Text = selectedRow.Cells["LastName"].Value.ToString();
                //gắn giá trị cho DateTimePicker-Ngày sinh
                string dateString = selectedRow.Cells["DateOfBirth"].Value.ToString();
                dateOfBirth.Value = DateTime.TryParse(dateString, out DateTime date) ? date : dateOfBirth.Value;

                string genDer = selectedRow.Cells["Gender"].Value.ToString();
                //Gán giá trị cho RadioButton
                if (genDer.Trim() == "Male")
                {
                    rdMale.Checked = true;
                }
                else if (genDer.Trim() == "Female")
                {
                    rdFemale.Checked = true;
                }
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                string shiftWorkValue = selectedRow.Cells["Shift_Work"].Value.ToString();
                string[] arrs = shiftWorkValue.Split('-');

                if (arrs.Length > 0)
                {
                    cbt2.Checked = false;
                    cbt3.Checked = false;
                    cbt4.Checked = false;
                    cbt5.Checked = false;
                    cbt6.Checked = false;
                    cbt7.Checked = false;
                    cbCn.Checked = false;
                    foreach (string arr in arrs)
                    {
                        if (arr == "Thứ 2") cbt2.Checked = true;
                        if (arr == "Thứ 3") cbt3.Checked = true;
                        if (arr == "Thứ 4") cbt4.Checked = true;
                        if (arr == "Thứ 5") cbt5.Checked = true;
                        if (arr == "Thứ 6") cbt6.Checked = true;
                        if (arr == "Thứ 7") cbt7.Checked = true;
                        if (arr == "Chủ Nhật") cbCn.Checked = true;
                    }
                }
                txtTK.Text = selectedRow.Cells["Account"].Value.ToString();
                txtMk.Text= selectedRow.Cells["PassWord"].Value.ToString();

            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvEM.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvEM.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                if (busEmployee.delEmployee(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvEM.DataSource = busEmployee.getEmployee(); // refresh datagridview
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

        private void btFindID_Click(object sender, EventArgs e)
        {

            // Lấy dữ liệu hiện tại từ DataGridView
            DataTable dataTable = dgvEM.DataSource as DataTable;

            if (dataTable != null)
            {
                // Tạo một DataView để lọc dữ liệu
                DataView dataView = new DataView(dataTable);
                dataView.RowFilter = $"LastName LIKE '%{txtFindName.Text.Trim()}%'";

                // Cập nhật DataGridView với dữ liệu đã lọc
                dgvEM.DataSource = dataView;
            }

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtFindName.Text = "";
            dgvEM.DataSource = busEmployee.getEmployee(); // refresh datagridview
        }
    }
}
