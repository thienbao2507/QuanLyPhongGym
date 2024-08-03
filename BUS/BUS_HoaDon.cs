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
    public class BUS_HoaDon
    {
        DAL_HoaDon dalReceipt = new DAL_HoaDon();

        public DataTable getReceipt()
        {
            return dalReceipt.GetReceipt();
        }

        public bool addReceipt(DTO_Receipt Receipt)
        {
            return dalReceipt.addReceipt(Receipt);
        }
        public bool editReceipt(DTO_Receipt Receipt)
        {
            return dalReceipt.editReceipt(Receipt);
        }
        public bool delReceipt(int IdReceipt)
        {
            return dalReceipt.delReceipt(IdReceipt);
        }
        public DTO_Receipt searchReceipt(int IdReceipt)
        {
            return dalReceipt.GetReceiptById(IdReceipt);
        }
    }
}
