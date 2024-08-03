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
    public partial class GymService : Form
    {
        BUS_GoiTap busGymService = new BUS_GoiTap();
        public GymService()
        {
            InitializeComponent();
            dgvGs.DataSource = busGymService.getGymService(); // refresh datagridview
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                try
                {
                    int price = int.Parse(txtPrice.Text);

                    // Tạo DTO
                    DTO_GymService tb = new DTO_GymService(0, txtName.Text, price, txtDescription.Text, txtDuration.Text); // Vì ID tự tăng nên để ID số gì cũng dc
                                                                                                                      //thEq
                    if (busGymService.addGymService(tb))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvGs.DataSource = (busGymService.getGymService()); // refresh datagridview
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


        private void dgvGs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGs.SelectedRows.Count > 0)
            {
                //lấy  phần tử được chọn
                DataGridViewRow selectedRow = dgvGs.SelectedRows[0];

                //Gắn họ tên lên textBox
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtDuration.Text = selectedRow.Cells["Duration"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();


            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvGs.SelectedRows.Count > 0)
            {
                if (txtName.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvGs.SelectedRows[0];
                    int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    int Price = Convert.ToInt32(row.Cells[2].Value.ToString());

                    //lấy các giá trị từ winform

                    // Tạo DTo
                    DTO_GymService tb = new DTO_GymService(ID, txtName.Text, Price, txtDescription.Text, txtDuration.Text);
                    // Sửa
                    if (busGymService.editGymService(tb))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvGs.DataSource = busGymService.getGymService(); // refresh datagridview
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
                if (dgvGs.SelectedRows.Count > 0)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvGs.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Xóa
                    if (busGymService.delGymService(ID))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvGs.DataSource = busGymService.getGymService(); // refresh datagridview
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
