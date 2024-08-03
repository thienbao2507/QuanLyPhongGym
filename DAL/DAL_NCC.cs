using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Policy;
using System.Security.Principal;
namespace DAL
{
    public class DAL_NCC : SqlConnectionData
    {
        //get toan bo nhan vien
        public DataTable GetSupplier()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Suppliers", conn);
            DataTable dtSupplier = new DataTable();
            da.Fill(dtSupplier);
            return dtSupplier;
        }
        /// Thêm Nhan vien
        public bool addSupplier(DTO_Supplier em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.Supplier(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO Suppliers(Name, PhoneNumber, Address) VALUES(N'{0}', '{1}',N'{2}')", em.Name, em.PhoneNumber, em.Address);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                //Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            { }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        //SỬA NHÂN VIÊN
        public bool editSupplier(DTO_Supplier em)
        {
            try
            {// Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Suppliers SET  Name = N'{0}',PhoneNumber = '{1}', Address= N'{2}' WHERE SupplierID='{3}'", em.Name, em.PhoneNumber, em.Address, em.ID_Supplier);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            { }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        //XÓA NHÂN VIÊN
        public bool delSupplier(int IdSupplier)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Suppliers WHERE SupplierID ={0}", IdSupplier);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            { }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

    }
}
