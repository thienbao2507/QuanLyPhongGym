using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Supplier
    {
        private int IdSupplier;
        private string name;
        private string phoneNumber;
        private string address;


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
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public DTO_Supplier() { }
        public DTO_Supplier(string Name)
        {
            this.Name = Name;
        }

        public DTO_Supplier(int idSupplier, string name, string phoneNumber, string address)
        {
            this.ID_Supplier = idSupplier;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
    }

}
