using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYKHACHSAN.BusinessObject
{
    public class DanhSachSuDungDichVuInFo
    {
        private string m_MaSuDungDVu;
        public string MaSuDungDVu
        {
            get { return m_MaSuDungDVu; }
            set { m_MaSuDungDVu = value; }
        }

        private string m_MaDichVu;
        public string MaDichVu
        {
            get { return m_MaDichVu; }
            set { m_MaDichVu = value; }
        }

        private PhieuNhanPhongInFo m_MaNhanPhong;
        public PhieuNhanPhongInFo MaNhanPhong
        {
            get { return m_MaNhanPhong; }
            set { m_MaNhanPhong = value; }
        }

        private int m_SoLuong;
        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }       
    }
}
