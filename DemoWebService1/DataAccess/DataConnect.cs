using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;


namespace DataAccess
{
   public class DataConnect
    {
         DataTable dt;
    
    //   [WebMethod]
       public SqlConnection GetConnect()
       {
           return new SqlConnection (@"Server=.;Initial Catalog=PointOfSale;Persist Security Info=True;User ID=sa;Password=123456");
         
       }

     //  [WebMethod]
       public DataTable GetTable(string sql)
       {
           //using (SqlConnection con = GetConnect())
           //{
           //    dt = new DataTable();
           //    SqlDataAdapter da = new SqlDataAdapter();
           //    da.Fill(dt);
           //    return dt;
           //}
           //Khai báo đối tượng vận chuyển dữ liệu (sql) từ kết nối (conn)
           SqlConnection con = GetConnect();
           SqlDataAdapter da = new SqlDataAdapter(sql, con);
           // Đổ dữ liệu vào DataSet
           DataSet ds = new DataSet();
           da.Fill(ds);
           //Lấy
           DataTable dt = new DataTable();
           dt = ds.Tables[0];
           return dt;
       }

//[WebMethod]
       public int ExcuteNonQuery(string sql)
       {
           using (SqlConnection con = GetConnect())
           {
               using (SqlCommand cmd = new SqlCommand(sql, con))
               {
                   con.Open();
                   cmd.CommandText = sql;
                   var result = cmd.ExecuteNonQuery();
                   cmd.Dispose();
                   con.Close();

                   return result;
               }               
           }
      
       }

    //   [WebMethod]
       public bool CheckExistValue(string nameTable, string nameFiled, string value)
       {
           string sql = "SELECT * FROM " + nameTable + " WHERE " + nameFiled + " = '" + value + "'";
           GetTable(sql);
           // Đếm số dòng trả về, nếu > 0  tức tồn tại value
           if (dt != null && dt.Rows.Count > 0)
           {
               return true;
           }
           return false;
       }

       // Lấy mã cuối cùng
       public string GetLastID(string nameTable, string nameFiled)
       {
           string sql = "SELECT TOP 1 " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
           // thực hiện câu truy vấn trên
           GetTable (sql);
           return dt.Rows[0][nameFiled].ToString();
       }
    }
}
