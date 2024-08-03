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
    public class DAL_KhachHang:SqlConnectionData
    {
        public DataTable GetCustomer()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Member", conn);
            DataTable dtCustomer = new DataTable();
            da.Fill(dtCustomer);
            return dtCustomer;
        }
        //Them
        public bool addCustomer(DTO_Customer c)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo chuỗi truy vấn
                string SQL = string.Format("INSERT INTO Member(FirstName, LastName, DateOfBirth, PhoneNumber, GenDer, Address, JoiningDate, MemberStatus, ServiceID,EndDate) VALUES(N'{0}', N'{1}','{2}','{3}',N'{4}',N'{5}',N'{6}','{7}','{8}','{9}')", c.firstName, c.lastName, c.DayOfBirth, c.PhoneNumber, c.genDer, c.Address, c.JoiningDate, c.MemberStatus, c.ServiceID,c.endDate);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        //Xoa
        public bool delCustomer(int IdCustomer)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo chuỗi truy vấn xóa nhân viên với ID tương ứng
                string SQL = string.Format("DELETE FROM Member WHERE MemberID = {0}", IdCustomer);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                // Xử lý ngoại lệ nếu cần
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }

            return false;
        }
        //Sua
        public bool editCustomer(DTO_Customer c)
        {
            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo chuỗi truy vấn cập nhật thông tin khách hàng
                string SQL = string.Format("UPDATE Member SET FirstName = N'{0}', LastName = N'{1}', DateOfBirth = '{2}',PhoneNumber = N'{3}', GenDer = N'{4}', Address = N'{5}',  JoiningDate = '{6}', MemberStatus = N'{7}', ServiceID = '{8}', EndDate = '{9}' Where MemberID = '{10}'",  c.firstName, c.lastName, c.DayOfBirth, c.PhoneNumber, c.genDer, c.Address,  c.JoiningDate, c.MemberStatus, c.ServiceID,c.endDate,c.Member_ID);

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand(SQL, conn);

                // Thực thi truy vấn và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            //catch (Exception e)
            //{
            //    // Xử lý ngoại lệ nếu cần
            //}
            finally
            {
                // Đóng kết nối
                conn.Close();
            }

            return false;
        }
   

    }
}
