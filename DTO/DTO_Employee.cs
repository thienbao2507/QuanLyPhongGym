using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        private int IdEmployee;
        private string idRole;
        private string fName;
        private string lName;
        private DateTime dob;
        private string gender;
        private string adress;
        private string phone;
        private string shiftWork;
        private string tk;
        private string mk;
        private int IdRank;
        
        public int ID_Employee
        {
            get { return IdEmployee; }
            set { IdEmployee = value; }
        }
        public string ID_Role
        {
            get { return idRole; }
            set {  idRole = value; }    
        }
        public string firstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string lastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public DateTime DayOfBirth
        {
            get { return dob; }
            set {  dob = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; } 
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string ShiftWork
        {
            get { return shiftWork; }
            set {  shiftWork = value; } 
        }
        public string taiKhoan
        {
            get { return tk;}
            set { tk = value; }
        }
        public string matKhau
        {
            get { return mk; }
            set {  mk = value; }
        }
        public int Id_Rank
        {
            get { return IdRank; }
            set {  IdRank = value; }
        }

        public DTO_Employee(string tk,string mk)
        { 
            this.tk = tk;
            this.mk = mk; 
        }

        public DTO_Employee(int idEmployee,string idRole, string fName, string lName, DateTime dob, string gender, string adress, string phone, string shiftWork, string tk, string mk,int idRank)
        {
            this.ID_Employee= idEmployee;
            this.idRole = idRole;
            this.fName = fName;
            this.lName = lName;
            this.dob = dob;
            this.gender = gender;
            this.adress = adress;
            this.phone = phone;
            this.shiftWork = shiftWork;
            this.tk = tk;
            this.mk = mk;
            this.IdRank = idRank;
        }
    }

}
