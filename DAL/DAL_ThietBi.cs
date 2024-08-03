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
    public class DAL_ThietBi : SqlConnectionData
    {
        //get toan bo nhan vien
        public DataTable GetEquipment()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Equipment", conn);
            DataTable dtEquipment = new DataTable();
            da.Fill(dtEquipment);
            return dtEquipment;
        }
        /// Thêm Nhan vien
        public bool addEquipment(DTO_Equipment em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.Equipment(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO Equipment(GrnID, SupplierID, Name, Quantity, UnitPrice, MaintenanceStatus, Description) VALUES(N'{0}', '{1}',N'{2}', '{3}', '{4}',N'{5}', N'{6}')", em.ID_GRN, em.ID_Supplier, em.Name, em.Quantity, em.UnitPrice, em.MaintenanceStatus, em.Description);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                //Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            //catch (Exception e)
            //{ }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        //SỬA NHÂN VIÊN
        public bool editEquipment(DTO_Equipment em)
        {
            try
            {// Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Equipment SET GrnID = '{0}', SupplierId = {1}, Name = N'{2}', Quantity = '{3}', UnitPrice = '{4}', MaintenanceStatus = N'{5}', Description=N'{6}' WHERE EquipmentID='{7}'", em.ID_GRN, em.ID_GRN, em.Name, em.Quantity, em.UnitPrice, em.MaintenanceStatus, em.Description, em.ID_Equipment);
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
        public bool delEquipment(int IdEquipment)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Equipment WHERE EquipmentID ={0}", IdEquipment);
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
        public bool addGRN(DTO_GRN em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.GRN(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO GoodReceiveNote(GrnID, InputDay, SupplierID, Total, Note ) VALUES(N'{0}', '{1}', '{2}', N'{3}')", em.ID_GRN, em.InputDay, em.ID_Supplier, em.Total, em.Note);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                //Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            //catch (Exception e)
            //{ }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

    }
}
