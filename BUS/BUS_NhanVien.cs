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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalEmployee = new DAL_NhanVien(); 
        
        public DataTable getEmployee()
        {
            return dalEmployee.GetEmployee();
        }

        public bool addEmployee(DTO_Employee employee)
        {
            return dalEmployee.addEmployee(employee);
        }
        public bool editEmployee(DTO_Employee employee)
        {
            return dalEmployee.editNhanVien(employee);
        }
        public bool delEmployee(int IdEmployee)
        {
            return dalEmployee.delEmployee(IdEmployee);
        }
        public string findAccountName(string tk, string mk)
        {
            return dalEmployee.GetEmployeeName(tk, mk);
        }
        public int findAccountID(string tk, string mk)
        {
            return dalEmployee.GetEmployeeID(tk, mk);
        }
        public bool checkAccount(string tk, string mk)
        {
            return dalEmployee.checkAccount(tk, mk);
        }
        public int checkRankAccount(int id)
        {
            return dalEmployee.getRankEmployee(id);   
        }
    }
}
