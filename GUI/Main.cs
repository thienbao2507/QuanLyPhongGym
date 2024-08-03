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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        public string nameEmployee;
        private int id;
        
        public Main(string name, int id)
        {
            InitializeComponent();
            this.nameEmployee = name;
            this.id = id;
        }

        public string getEmployeeName()
        {
            return nameEmployee;
        }
        private void Main_Load(object sender, EventArgs e)
        {

            lbNameE.Text = nameEmployee.ToString();
            lbIdEmployee.Text = id.ToString();
            lbRank.Text= busEmployee.checkRankAccount(id).ToString();   
            AccessEmployee(busEmployee.checkRankAccount(id));
        }
        //kiểm tra quyền truy cập người dùng
        BUS_NhanVien busEmployee = new BUS_NhanVien();
        private void AccessEmployee(int id)
        {
            //btEmployee.Visible = true;  
            //btEquipment.Visible = true;
            //btGymService.Visible = true;
            //btMembers.Visible = true;
            //btReceipt.Visible = true;
            //btSupplier.Visible = true;  
            
            switch (id)
            {
                case 1:
                    btEmployee.Visible = true;
                    btEquipment.Visible = true;
                    btGymService.Visible = true;
                    btMembers.Visible = true;
                    btReceipt.Visible = true;
                    btSupplier.Visible = true;
                    lb4.Visible = false;
                    break;
                case 2:
                    btEmployee.Visible = false;
                    btEquipment.Visible = true;
                    btGymService.Visible = true;
                    btMembers.Visible = true;
                    btReceipt.Visible = true;
                    btSupplier.Visible = true;
                    lb4.Visible = false;
                    break;
                case 3:
                    btEmployee.Visible = false;
                    btEquipment.Visible = false;
                    btGymService.Visible = false;
                    btMembers.Visible = true;
                    btReceipt.Visible = true;
                    btSupplier.Visible = false;
                    lb4.Visible = false;
                    break;
                case 4:
                    btEmployee.Visible = false;
                    btEquipment.Visible = false;
                    btGymService.Visible = false;
                    btMembers.Visible = false;
                    btReceipt.Visible = false;
                    btSupplier.Visible = false;
                    lb4.Visible = true;
                    break;
            }
        }
        private void btEmployee_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            // Hiển thị form mới
            form.Show();
        }

        private void btMembers_Click(object sender, EventArgs e)
        {
            Members form = new Members();
            // Hiển thị form mới
            form.Show();
        }

        private void btEquipment_Click(object sender, EventArgs e)
        {
            Equipment form = new Equipment();
            // Hiển thị form mới
            form.Show();
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            Supplier form = new Supplier(); 
            form.Show();    
        }

        private void btGymService_Click(object sender, EventArgs e)
        {
            GymService form = new GymService();
            form.Show();
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            Receipt form = new Receipt();
            form.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
