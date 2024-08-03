using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalCustomer = new DAL_KhachHang();

        public DataTable getCustomer()
        {
            return dalCustomer.GetCustomer();
        }

        public bool addCustomer(DTO_Customer customer)
        {
            return dalCustomer.addCustomer(customer);
        }

        public bool editCustomer(DTO_Customer customer)
        {
            return dalCustomer.editCustomer(customer);
        }

        public bool delCustomer(int customerId)
        {
            return dalCustomer.delCustomer(customerId);
        }
    }
}
