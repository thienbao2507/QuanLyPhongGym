using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Receipt
    {
        private int IdReceipt;
        private string IdEmployee;
        private string IdService;
        private string IdMember;
        private DateTime date;
        private int total;
        private string note;

        public int ID_Receipt
        {
            get { return IdReceipt; }
            set { IdReceipt = value; }
        }
        public string ID_Employee
        {
            get { return IdEmployee; }
            set { IdEmployee = value; }
        }
        public string ID_Service
        {
            get { return IdService; }
            set { IdService = value; }
        }
        public string ID_Member
        {
            get { return IdMember; }
            set { IdMember = value; }
        }
        public DateTime Date
        { 
            get { return date; }
            set { date = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
   

        public DTO_Receipt() { }
        public DTO_Receipt(int idReceipt, string idEmployee, string idService, string idMember, DateTime date, int total, string note) { 
        
            this.ID_Receipt = idReceipt;
            this.ID_Employee = idEmployee;
            this.ID_Service = idService;    
            this.ID_Member = idMember;
            this.Date = date;
            this.Total = total;
            this.Note = note;   
        }
    }

}
