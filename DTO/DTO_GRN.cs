using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GRN
    {
        private int IdGRN;
        private int IdSupplier;
        private DateTime inputDay;
        private string note;
        private decimal total;

        public int ID_GRN
        {
            get { return IdGRN; }
            set { IdGRN = value; }
        }
        public int ID_Supplier
        {
            get { return IdSupplier; }
            set { IdSupplier = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        public DateTime InputDay
        {
            get { return inputDay; }
            set { inputDay = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
       

        public DTO_GRN() { }
        public DTO_GRN(int idGRN, int idSupplier, DateTime inputDay, decimal total, string note)
        {

            this.ID_GRN = idGRN;
            this.ID_Supplier = idSupplier;
            this.InputDay = inputDay;
            this.Total = total;
            this.Note = note;
        }
    }

}
