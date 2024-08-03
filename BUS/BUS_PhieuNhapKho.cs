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
    public class BUS_PhieuNhapKho
    {
        DAL_PhieuNhapKho dalGRN = new DAL_PhieuNhapKho();

        public DataTable getGRN()
        {
            return dalGRN.GetGRN();
        }

        public bool addGRN(DTO_GRN GRN)
        {
            return dalGRN.addGRN(GRN);
        }
        public bool editGRN(DTO_GRN GRN)
        {
            return dalGRN.editGRN(GRN);
        }
        public bool delGRN(int IdGRN)
        {
            return dalGRN.delGRN(IdGRN);
        }
        public DTO_GRN searchGRN(int IdGRN)
        {
            return dalGRN.GetGRNById(IdGRN);
        }
    }
}
