using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYKHACHSAN.BusinessObject
{
    public class DichVuInFo
    {
        private string m_MaDichVu;
        public string MaDichVu
        {
            get { return m_MaDichVu; }
            set { m_MaDichVu = value; }
        }

        private string m_MaLoaiDichVu;
        public string MaLoaiDichVu
        {
            get { return m_MaLoaiDichVu; }
            set { m_MaLoaiDichVu = value; }
        }

        private string m_MaDonVi;
        public string MaDonVi
        {
            get { return m_MaDonVi; }
            set { m_MaDonVi = value; }
        }

        private float m_DonGia;
        public float DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }
    }
}
