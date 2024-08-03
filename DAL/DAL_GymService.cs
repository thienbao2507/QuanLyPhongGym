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
using System.Runtime.Remoting.Metadata.W3cXsd2001;
namespace DAL
{
    public class DAL_GoiTap : SqlConnectionData
    {
        //get toan bo nhan vien
        public DataTable GetGymService()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GymService", conn);
            DataTable dtGymService = new DataTable();
            da.Fill(dtGymService);
            return dtGymService;
        }
        /// Thêm Nhan vien
        public bool addGymService(DTO_GymService em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.GymService(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO GymService(Name, Price, Description, Duration) VALUES(N'{0}', '{1}',N'{2}', N'{3}')", em.Name, em.Price, em.Description, em.Duration);
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
        public bool editGymService(DTO_GymService em)
        {
            try
            {// Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE GymService SET  Name = N'{0}', Price = '{1}',Description = N'{2}', Duration=N'{3}' WHERE ServiceID='{4}'", em.Name, em.Price, em.Description, em.Duration, em.ID_GymService);
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
        public bool delGymService(int IdGymService)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM GymService WHERE ServiceID ={0}", IdGymService);
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
        public int getNumberMonth(int id)
        {
            int duration = 0;
            try
            {
                // Mở kết nối
                conn.Open();
                string sqlQuery = "SELECT Duration FROM GymService WHERE ServiceID = @ServiceID";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@ServiceID", id);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string durationStr = reader.GetString(0); // Lấy giá trị của cột đầu tiên (Duration) dưới dạng chuỗi
                    duration = ExtractNumber(durationStr); // Trích xuất số từ chuỗi
                }
                reader.Close();
            }
            catch (Exception e)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log lỗi)
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return duration;
        }

        // Hàm hỗ trợ để trích xuất số từ chuỗi
        private int ExtractNumber(string input)
        {
            // Trích xuất các ký tự số từ chuỗi
            string numberStr = new string(input.Where(char.IsDigit).ToArray());
            // Chuyển đổi chuỗi số thành số nguyên
            if (int.TryParse(numberStr, out int number))
            {
                return number;
            }
            return 0; // Trả về 0 nếu không có số hợp lệ trong chuỗi
        }


    }
}
