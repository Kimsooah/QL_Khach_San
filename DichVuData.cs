using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QUANLYKHACHSAN.Setting;

namespace QUANLYKHACHSAN.DataPlayer
{
    public class DichVuData
    {
        DataService ds = new DataService();
        public DataTable LayMaDichVu()
        {
            SqlCommand cmd = new SqlCommand("select * from DICH_VU");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaDSDichVu(string madv)
        {
            SqlCommand cmd = new SqlCommand("select * from DICH_VU where MaDichVu= '" + madv + "'");
            //cmd.Parameters.Add("id", SqlDbType.VarChar).Value = madv;
            ds.Load(cmd);
            return ds;
        }


        public DataTable DonGiaDichVu(string dongia)
        {
            SqlCommand cmd = new SqlCommand("SELECT DonGia FROM DICH_VU WHERE DonGia= @id");
            cmd.Parameters.Add("id", SqlDbType.Float).Value = dongia;
            ds.Load(cmd);

            return ds;
        }

        public DataTable TimMaLoaiDichVu(string maloaidichvu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DICH_VU WHERE MaLoaiDichVu = @maloaidichvu ");
            cmd.Parameters.Add("maloaidichvu", SqlDbType.VarChar).Value = maloaidichvu;
            ds.Load(cmd);

            return ds;
        }

        public DataTable TimMaDonVi(string madonvi)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DICH_VU WHERE MaDonVi = @madonvi ");
            cmd.Parameters.Add("madonvi", SqlDbType.VarChar).Value = madonvi;
            ds.Load(cmd);

            return ds;
        }


        public DataRow NewRow()
        {
            return ds.NewRow();
        }

        public void Add(DataRow row)
        {
            ds.Rows.Add(row);
        }

        public bool Save()
        {
            return (ds.ExecuteNoneQuery() > 0);
        }
    }
}
