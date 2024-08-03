
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
    public class DAL_PhieuNhapKho : SqlConnectionData
    {

        //get toan bo nhan vien
        public DataTable GetGRN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GoodReceiveNote", conn);
            DataTable dtGRN = new DataTable();
            da.Fill(dtGRN);
            return dtGRN;
        }
        /// Thêm Nhan vien
        public bool addGRN(DTO_GRN em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.GRN(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO GoodReceiveNote(InputDay, SupplierID, Total, Note ) VALUES(N'{0}', '{1}', '{2}', N'{3}')", em.InputDay, em.ID_Supplier, em.Total, em.Note);
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
        public bool editGRN(DTO_GRN em)
        {
            try
            {// Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE GoodReceiveNote SET  InputDay = '{0}', SupplierID = '{1}',Total = '{2}', Note = N'{3}' WHERE GrnID='{4}'", em.InputDay, em.ID_Supplier, em.Total, em.Note, em.ID_GRN);
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
        public bool delGRN(int IdGRN)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM GoodReceiveNote WHERE GrnID ={0}", IdGRN);
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

        public DTO_GRN GetGRNById(int GrnID)
        {
            string strcon = @"Data Source=DESKTOP-C9D3CVA\SQLEXPRESS;Initial Catalog=DataGym;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(strcon))
            {
                string query = "SELECT GrnID, SupplierID, InputDay, Total, Note FROM GoodReceiveNote WHERE GrnID = @GrnID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GrnID", GrnID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DTO_GRN GRN = new DTO_GRN();
                    GRN.ID_GRN = (int)reader["GrnID"];
                    GRN.ID_Supplier = (int)reader["SupplierID"];
                    GRN.InputDay = (DateTime)reader["InputDay"];
                    GRN.Total = (decimal)reader["Total"];
                    GRN.Note = reader["Note"].ToString();
                    return GRN;
                }

                return null;
            }
        }
    }


}
