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
    public partial class GRN_view : Form
    {
        BUS_PhieuNhapKho busGRN = new BUS_PhieuNhapKho();
        public GRN_view()
        {
            InitializeComponent();
            dgvGrn.DataSource = busGRN.getGRN(); // refresh datagridview
        }
        protected void GUI_GRN_Load(object sender, EventArgs e)
        {
            dgvGrn.DataSource = busGRN.getGRN(); // get Nhân viên
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            {
                // Kiểm tra nếu có chọn table rồi
                if (dgvGrn.SelectedRows.Count > 0)
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvGrn.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Xóa
                    if (busGRN.delGRN(ID))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvGrn.DataSource = busGRN.getGRN(); // refresh datagridview
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
