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
    public class BUS_NCC
    {
        DAL_NCC dalSupplier = new DAL_NCC();

        public DataTable getSupplier()
        {
            return dalSupplier.GetSupplier();
        }

        public bool addSupplier(DTO_Supplier Supplier)
        {
            return dalSupplier.addSupplier(Supplier);
        }
        public bool editSupplier(DTO_Supplier Supplier)
        {
            return dalSupplier.editSupplier(Supplier);
        }
        public bool delSupplier(int IdSupplier)
        {
            return dalSupplier.delSupplier(IdSupplier);
        }
    }
}
