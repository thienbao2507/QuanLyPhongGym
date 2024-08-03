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
    public partial class Supplier : Form
    {
        BUS_NCC busSupplier = new BUS_NCC();
        public Supplier()
        {
            InitializeComponent();
            dgvSup.DataSource = busSupplier.getSupplier(); // refresh datagridview
        }
        protected void GUI_Supplier_Load(object sender, EventArgs e)
        {
            dgvSup.DataSource = busSupplier.getSupplier(); // get Nhân viên
        }


        private void dgvEM_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSup.SelectedRows.Count > 0)
            {
                //lấy  phần tử được chọn
                DataGridViewRow selectedRow = dgvSup.SelectedRows[0];
                //Gắn họ tên lên textBox
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtSdt.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            {
                {
                    if (txtName.Text != "")
                    {
                        //lấy các giá trị từ winform

                        // Tạo DTO
                        DTO_Supplier ncc = new DTO_Supplier(0, txtName.Text, txtSdt.Text, txtAddress.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                                                                                                            //them
                        if (busSupplier.addSupplier(ncc))
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvSup.DataSource = (busSupplier.getSupplier()); // refresh datagridview
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

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu có chọn table rồi
            if (dgvSup.SelectedRows.Count > 0)
            {
                if (txtName.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvSup.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //lấy các giá trị từ winform

                    // Tạo DTo
                    DTO_Supplier ncc = new DTO_Supplier(ID, txtName.Text, txtSdt.Text, txtAddress.Text);
                    // Sửa
                    if (busSupplier.editSupplier(ncc))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvSup.DataSource = busSupplier.getSupplier(); // refresh datagridview
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
                if (dgvSup.SelectedRows.Count > 0)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvSup.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Xóa
                    if (busSupplier.delSupplier(ID))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvSup.DataSource = busSupplier.getSupplier(); // refresh datagridview
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
    }
}
