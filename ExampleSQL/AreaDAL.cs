using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ExampleSQL
{
    public class AreaDAL : DBConnection
    {
        // 1. Hàm lấy toàn bộ danh sách khu vực (Dùng cho ComboBox)
        public List<AreaBEL> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from areas", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<AreaBEL> lstArea = new List<AreaBEL>();
            while (reader.Read())
            {
                AreaBEL area = new AreaBEL();
                area.Id = int.Parse(reader["id"].ToString());
                area.Name = reader["name"].ToString();
                lstArea.Add(area);
            }
            conn.Close();
            return lstArea;
        }

        // 2. Hàm lấy 1 khu vực theo ID (Dùng để hiển thị tên khu vực lên bảng)
        public AreaBEL ReadArea(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from areas where id=" + id, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            AreaBEL area = new AreaBEL();
            if (reader.HasRows && reader.Read())
            {
                area.Id = int.Parse(reader["id"].ToString());
                area.Name = reader["name"].ToString();
            }
            conn.Close();
            return area;
        }
    }
}