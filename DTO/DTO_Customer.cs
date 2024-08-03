using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class DTO_Customer
    {
        private int MemID;
        private string fName;
        private string lName;
        private DateTime dob;
        private string gender;
        private string address;
        private string phone;
        private DateTime jd;
        private string memberStatus;
        private int SerID;
        private DateTime eD;

        public int Member_ID
        {
            get { return MemID; }
            set { MemID = value; }
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
            set { dob = value; }
        }
        public string genDer
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phone; }
            set { phone = value; }
        }
        public DateTime JoiningDate
        {
            get { return jd; }
            set { jd = value; }
        }
        public string MemberStatus
        {
            get { return memberStatus; }
            set { memberStatus = value; }
        }
        public int ServiceID
        {
            get { return SerID; }
            set { SerID = value; }
        }
        public DateTime endDate
        {
            get { return eD; }
            set { eD = value; } 
        }
        public DTO_Customer() { }
        public DTO_Customer(string firstName, string lastName)
        {
            this.fName = firstName;
            this.lName = lastName;
        }
        public DTO_Customer(int memberID, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string gender, string address,  DateTime joiningDate, string memberStatus, int serviceID, DateTime endDate)
        {
            MemID = memberID;
            fName = firstName;
            lName = lastName;
            dob = dateOfBirth;
            this.gender = gender;
            this.address = address;
            phone = phoneNumber;
            jd = joiningDate;
            this.memberStatus = memberStatus;
            SerID = serviceID;
            eD = endDate;
        }
        
    }
}
