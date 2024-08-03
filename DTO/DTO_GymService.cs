using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GymService
    {
        private int IdGymService;
        private string name;
        private int price;
        private string description;
        private string duration;

        public int ID_GymService
        {
            get { return IdGymService; }
            set { IdGymService = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public DTO_GymService() { }
        public DTO_GymService(int idGymService, string name, int price, string description, string duration)
        {
            this.ID_GymService = idGymService;
            this.Name = name;
            this.Price = price;
            this.Duration = duration;
            this.Description = description;
        }
    }

}
