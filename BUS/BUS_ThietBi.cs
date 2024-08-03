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
    public class BUS_ThietBi
    {
        DAL_ThietBi dalEquipment = new DAL_ThietBi();

        public DataTable getEquipment()
        {
            return dalEquipment.GetEquipment();
        }

        public bool addEquipment(DTO_Equipment Equipment)
        {
            return dalEquipment.addEquipment(Equipment);
        }
        public bool editEquipment(DTO_Equipment Equipment)
        {
            return dalEquipment.editEquipment(Equipment);
        }
        public bool delEquipment(int IdEquipment)
        {
            return dalEquipment.delEquipment(IdEquipment);
        }
        public bool addGRN(DTO_GRN GN)
        {
            return dalEquipment.addGRN(GN);
        }
    }
}
