using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQL
{
    public class CustomerDAL : DBConnection
    {
        public List<CustomerBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            // Chú ý: bảng 'areas' có chữ 's' ở cuối như script SQL bro vừa chạy
            string query = "SELECT c.id, c.name, a.name AS AreaName " +
                           "FROM customer c " +
                           "INNER JOIN areas a ON c.id_area = a.id";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CustomerBEL> lstCus = new List<CustomerBEL>();

            while (reader.Read())
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(reader["id"].ToString()!);
                cus.Name = reader["name"].ToString()!;
                cus.AreaName = reader["AreaName"].ToString()!;
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where id = @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            // Liệt kê rõ các cột để tránh nhầm lẫn
            SqlCommand cmd = new SqlCommand("insert into customer (id, name, id_area) values(@id, @name, @id_area)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            // PHẢI dùng IdArea (kiểu int)
            cmd.Parameters.Add(new SqlParameter("@id_area", cus.IdArea));

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set name=@name, id_area=@id_area where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            // PHẢI dùng IdArea (kiểu int)
            cmd.Parameters.Add(new SqlParameter("@id_area", cus.IdArea));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}