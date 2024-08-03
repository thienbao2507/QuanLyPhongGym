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
    public partial class Equipment : Form
    {
        BUS_ThietBi busEquipment = new BUS_ThietBi();
        public Equipment()
        {
            InitializeComponent();
            LoadSupplier();
            dgvEq.DataSource = busEquipment.getEquipment(); // refresh datagridview
        }

        private void LoadSupplier()
        {
            //Chuỗi kết nối đến cơ sở dữ liệu SQL Server
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // Câu lệnh SQL để lấy dữ liệu từ bảng Service
            string sqlQuery = "SELECT Name,SupplierID FROM Suppliers";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        cbSupplier.Items.Clear();
                        while (reader.Read())
                        {
                            cbSupplier.Items.Add(string.Format("{0}:{1}", reader["SupplierID"], reader["Name"]));
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
        private void isCheckInf()
        {
            
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                try
                {
                    int quantity = int.Parse(txtQuantity.Text);
                    decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                    int IdSupplier = int.Parse(cbSupplier.Text.Trim().Split(':')[0]);


                    // Tạo DTO
                    DTO_Equipment tb = new DTO_Equipment(0, txtGrn.Text, IdSupplier, txtName.Text, quantity, unitPrice, txtMS.Text, txtDescription.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                                                                                                                                              //thEq
                    if (busEquipment.addEquipment(tb))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvEq.DataSource = (busEquipment.getEquipment()); // refresh datagridview
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
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }


        private void dgvEq_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEq.SelectedRows.Count > 0)
            {
                //lấy  phần tử được chọn
                DataGridViewRow selectedRow = dgvEq.SelectedRows[0];

                //Gắn họ tên lên textBox
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtGrn.Text = selectedRow.Cells["GrnID"].Value.ToString();
                cbSupplier.Text = selectedRow.Cells["SupplierID"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value.ToString();
                txtMS.Text = selectedRow.Cells["MaintenanceStatus"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();


            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvEq.SelectedRows.Count > 0)
            {
                if (txtName.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvEq.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                    int Quantity = Convert.ToInt16(row.Cells[2].Value.ToString());
                    int IdSupplier = int.Parse(cbSupplier.Text.Trim().Split(':')[0]);

                    //lấy các giá trị từ winform

                    // Tạo DTo
                    DTO_Equipment tb = new DTO_Equipment(ID, txtGrn.Text, IdSupplier, txtName.Text, Quantity, unitPrice, txtMS.Text, txtDescription.Text);
                    // Sửa
                    if (busEquipment.editEquipment(tb))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvEq.DataSource = busEquipment.getEquipment(); // refresh datagridview
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

        private void btDel_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra nếu có chọn table rồi
                if (dgvEq.SelectedRows.Count > 0)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvEq.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Xóa
                    if (busEquipment.delEquipment(ID))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvEq.DataSource = busEquipment.getEquipment(); // refresh datagridview
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
        }

        private void btGRN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGrnID.Text))
            {
                try
                {
                    //Mediator.SupplierID = int.Parse(cbSupplier.Text.Trim().Split(':')[0]);
                    Mediator.GrnID = int.Parse(txtGrnID.Text);
                    getSupplierID();
                    GRN form = new GRN();
                    form.Show();
                }
                catch (FormatException)
                {
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy số phiếu nhập kho");
            }
        }
        private void getSupplierID()
        {
            // Connection string to the SQL Server database
            string strCon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            // SQL query to get data from the Supplier and Equipment tables
            string sqlQuery = "SELECT GrnID, Suppliers.SupplierID FROM Suppliers JOIN Equipment ON Suppliers.SupplierID = Equipment.SupplierID WHERE GrnID = @GrnID";

            using (SqlConnection connection = new SqlConnection(strCon))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add parameter to the SQL query
                    command.Parameters.AddWithValue("@GrnID", int.Parse(txtGrnID.Text));

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Ensure there's data to read
                            {
                                Mediator.SupplierID = reader.GetInt32(reader.GetOrdinal("SupplierID"));
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified GrnID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btView_Click(object sender, EventArgs e)
        {
            GRN_view form = new GRN_view();
            form.Show();
        }

    }
}
