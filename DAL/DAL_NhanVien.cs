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
using System.Net.NetworkInformation;
namespace DAL
{
    public class DAL_NhanVien:SqlConnectionData
    {
        //get toan bo nhan vien
        public DataTable GetEmployee()
        {
            SqlDataAdapter da= new SqlDataAdapter("SELECT * FROM Employee",conn);
            DataTable dtEmployee= new DataTable();
            da.Fill(dtEmployee);
            return dtEmployee;
        }
        /// Thêm Nhan vien
        public bool addEmployee(DTO_Employee em)
        {
            try
            {
                //Ket noi
                conn.Open();
                //Query string -vì SV_ID là identity(giá trị tự tăng dần) nên ko cần phải insert ID
                //INSERT INTO dbo.Employee(IdRole, FirstName, LastName, DateOfBirth, Gender, Adress, Phone, Shift_work, Account, Password, lvl)
                string SQL = string.Format("INSERT INTO Employee(RoleID, FirstName, LastName, DateOfBirth, Gender, Address, Phone, Shift_Work, Account, Password,Ranking) VALUES('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}','{10}')", em.ID_Role, em.firstName, em.lastName,em.DayOfBirth,em.Gender,em.Adress,em.Phone,em.ShiftWork,em.taiKhoan,em.matKhau,em.Id_Rank);
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
        public bool editNhanVien(DTO_Employee em)
        {
            try
            {// Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Employee SET  RoleID = '{0}',FirstName = N'{1}', LastName=N'{2}', DateOfBirth='{3}', Gender=N'{4}', Address=N'{5}', Phone='{6}',Shift_Work=N'{7}',Account='{8}',PassWord='{9}',Ranking='{10}' WHERE EmployeeID='{11}'", em.ID_Role, em.firstName, em.lastName, em.DayOfBirth,em.Gender,em.Adress,em.Phone,em.ShiftWork,em.taiKhoan,em.matKhau,em.Id_Rank,em.ID_Employee);
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
        public bool delEmployee(int IdEmployee)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM Employee WHERE EmployeeID ={0}", IdEmployee);
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
        public bool checkAccount(string tk, string mk)
  {
            try
            {
                // Mở kết nối
                conn.Open();

                // Câu lệnh SQL
                string SQL = string.Format("SELECT EmployeeID FROM Employee WHERE Account = '{0}' AND Password = '{1}'", tk, mk);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và nhận kết quả
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu trả về hay không
                    if (reader.Read())
                    {
                        // Đọc giá trị ID từ kết quả truy vấn
                        int employeeID = reader.GetInt32(0);

                        // Đóng kết nối
                        conn.Close();

                        // Trả về ID nếu truy vấn thành công
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                // Xử lý các ngoại lệ nếu có
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi hoàn thành
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            // Trả về -1 nếu truy vấn không thành công hoặc không có dữ liệu trả về
            return false;
        }

        public int GetEmployeeID(string tk, string mk)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Câu lệnh SQL
                string SQL = string.Format("SELECT EmployeeID FROM Employee WHERE Account = '{0}' AND Password = '{1}'", tk, mk);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và nhận kết quả
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu trả về hay không
                    if (reader.Read())
                    {
                        // Đọc giá trị ID từ kết quả truy vấn
                        int employeeID = reader.GetInt32(0);

                        // Đóng kết nối
                        conn.Close();

                        // Trả về ID nếu truy vấn thành công
                        return employeeID;
                    }
                }
            }
            catch (Exception e)
            {
                // Xử lý các ngoại lệ nếu có
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi hoàn thành
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            // Trả về -1 nếu truy vấn không thành công hoặc không có dữ liệu trả về
            return -1;
        }
        public int getRankEmployee(int id)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Câu lệnh SQL
                string SQL = string.Format("SELECT Ranking FROM Employee WHERE EmployeeID = '{0}'", id);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và nhận kết quả
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu trả về hay không
                    if (reader.Read())
                    {
                        // Đọc giá trị ID từ kết quả truy vấn
                        int idRank = reader.GetInt32(0);

                        // Đóng kết nối
                        conn.Close();

                        // Trả về ID nếu truy vấn thành công
                        return idRank;
                    }
                }
            }
            //catch (Exception e)
            //{
            //    // Xử lý các ngoại lệ nếu có
            //}
            finally
            {
                // Đảm bảo đóng kết nối sau khi hoàn thành
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            // Trả về -1 nếu truy vấn không thành công hoặc không có dữ liệu trả về
            return -1;
        }
        public string GetEmployeeName(string tk, string mk)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Câu lệnh SQL
                string SQL = string.Format("SELECT FirstName, LastName FROM Employee WHERE Account = '{0}' AND Password = '{1}'", tk, mk);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và nhận kết quả
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu trả về hay không
                    if (reader.Read())
                    {
                        // Đọc giá trị của FirstName và LastName từ kết quả truy vấn
                        string firstName = reader.GetString(0);
                        string lastName = reader.GetString(1);

                        // Ghép FirstName và LastName thành một chuỗi
                        string employeeName = firstName.Trim() + " " + lastName.Trim();

                        // Đóng kết nối
                        conn.Close();

                        // Trả về tên nhân viên nếu truy vấn thành công
                        return employeeName;
                    }
                }
            }
            catch (Exception e)
            {
                // Xử lý các ngoại lệ nếu có
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi hoàn thành
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            // Trả về null nếu truy vấn không thành công hoặc không có dữ liệu trả về
            return null;
        }

 
    }
}
