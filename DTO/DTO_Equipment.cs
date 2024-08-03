using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Equipment
    {
        private int IdEquipment;
        private string IdGRN;
        private int IdSupplier;
        private string name;
        private int quantity;
        private decimal unitPrice;
        private string Maintenance;
        private string description;

        public int ID_Equipment
        {
            get { return IdEquipment; }
            set { IdEquipment = value; }
        }
        public string ID_GRN
        {
            get { return IdGRN; }
            set { IdGRN = value; }
        }
        public int ID_Supplier
        {
            get { return IdSupplier; }
            set { IdSupplier = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public string MaintenanceStatus
        {
            get { return Maintenance; }
            set { Maintenance = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public DTO_Equipment() { }
        public DTO_Equipment(int idEquipment, string idGRN, int idSupplier, string name,int quantity, decimal unitPrice, string maintanence, string description)
        {
            this.ID_Equipment = idEquipment;
            this.ID_GRN = idGRN;
            this.ID_Supplier = idSupplier;
            this.Name = name;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.MaintenanceStatus = maintanence;
            this.Description = description;
        }
    }

}
