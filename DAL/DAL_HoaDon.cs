
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
using System.Configuration;
namespace DAL
{
    public class DAL_HoaDon : SqlConnectionData
    {
        
        //get toan bo nhan vien
        public DataTable GetReceipt()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Receipt", conn);
            DataTable dtReceipt = new DataTable();
            da.Fill(dtReceipt);
            return dtReceipt;
        }
        /// Thêm Nhan vien
        public bool addReceipt(DTO_Receipt em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.Receipt(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO Receipt(EmployeeID, ServiceID, MemberID, Date, Total, Note) VALUES(N'{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}')", em.ID_Employee, em.ID_Service, em.ID_Member, em.Date, em.Total, em.Note);
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
        public bool editReceipt(DTO_Receipt em)
        {
            try
            {// Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Receipt SET  EmployeeID = '{0}' ServiceID = '{1}',MemberID = '{2}', Date = '{3}', Total = '{4}', Note = N'{5}' WHERE ReceiptID='{6}'", em.ID_Employee, em.ID_Member, em.ID_Service, em.Date, em.Total, em.Note, em.ID_Receipt);
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
        public bool delReceipt(int IdReceipt)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Receipt WHERE ReceiptID ={0}", IdReceipt);
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

        public DTO_Receipt GetReceiptById(int ReceiptID)
        {
            string strcon = @"Data Source=ThienBaoDes;Initial Catalog=DataGymFinal;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(strcon))
            {
                string query = "SELECT ReceiptID, EmployeeID, ServiceID, MemberID, Date, Total, Note FROM Receipt WHERE ReceiptID = @ReceiptID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReceiptID", ReceiptID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DTO_Receipt receipt = new DTO_Receipt();
                        receipt.ID_Receipt = (int)reader["ReceiptID"];
                        receipt.ID_Employee = reader["EmployeeID"].ToString();
                        receipt.ID_Service = reader["ServiceID"].ToString();
                        receipt.ID_Member = reader["MemberID"].ToString();
                        receipt.Date = (DateTime)reader["Date"];
                    if (!reader.IsDBNull(reader.GetOrdinal("Note")))
                    {
                        receipt.Note = reader["Note"].ToString();
                    }

                    return receipt;
                }

                return null;
            }
        }
    }

    
}
