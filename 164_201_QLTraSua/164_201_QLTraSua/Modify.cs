﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _164_201_QLTraSua
{
    internal class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh insert, update, delete,...
        SqlDataReader dataReader; //dung de doc du lieu trong bang
        //public List<TaiKhoan> TaiKhoans (string query)
        //{
        //    List<TaiKhoan> TaiKhoans = new List<TaiKhoan>();
        //    using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        //    {
        //        sqlConnection.Open();
        //        sqlCommand = new SqlCommand(query, sqlConnection);
        //        dataReader = sqlCommand.ExecuteReader();
        //        while (dataReader.Read())
        //        {
        //            TaiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
        //        }
        //        sqlConnection.Close();
        //    }    
        //    return TaiKhoans;
        //}

        public void Command(string query) //dung de dang ky tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thuc thi cau truy van
                
                sqlConnection.Close();
            }
        }

    }
    
}