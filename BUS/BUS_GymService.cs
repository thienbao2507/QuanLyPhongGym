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
    public class BUS_GoiTap
    {
        DAL_GoiTap dalGymService = new DAL_GoiTap();

        public DataTable getGymService()
        {
            return dalGymService.GetGymService();
        }

        public bool addGymService(DTO_GymService GymService)
        {
            return dalGymService.addGymService(GymService);
        }
        public bool editGymService(DTO_GymService GymService)
        {
            return dalGymService.editGymService(GymService);
        }
        public bool delGymService(int IdGymService)
        {
            return dalGymService.delGymService(IdGymService);
        }
        public int getTime(int serID)
        {
            return dalGymService.getNumberMonth(serID);
        }
    }
}
