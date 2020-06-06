using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QUANLYKHACHSAN.Setting;

namespace QUANLYKHACHSAN.DataPlayer
{
    public class DanhSachSuDungDichVuData
    {
        DataService ds = new DataService();
        public DataTable LayMaSuDungDichVu()
        {
            SqlCommand cmd = new SqlCommand("select * from DANH_SACH_SU_DUNG_DICH_VU");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaDSSuDungDichVu(string masddv)
        {
            SqlCommand cmd = new SqlCommand("select * from DANH_SACH_SU_DUNG_DICH_VU where MaSuDungDvu = @id ");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = masddv;
            ds.Load(cmd);
            return ds;
        }

        public DataTable TimMaDichVu(string madichvu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DANH_SACH_SU_DUNG_DICH_VU WHERE MaDichVu = @madichvu ");
            cmd.Parameters.Add("madichvu", SqlDbType.VarChar).Value = madichvu;
            ds.Load(cmd);

            return ds;
        }

        public DataTable TimMaPhieuNhan(string phieunhanphong)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DANH_SACH_SU_DUNG_DICH_VU WHERE MaNhanPhong = @phieunhanphong ");
            cmd.Parameters.Add("phieunhanphong", SqlDbType.VarChar).Value = phieunhanphong;
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
