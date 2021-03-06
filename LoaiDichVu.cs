using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Controller;

namespace QUANLYKHACHSAN.UserInterface
{
    public partial class LoaiDichVu : Form
    {
        LoaiDichVuControl ctrl = new LoaiDichVuControl();
        public LoaiDichVu()
        {
            InitializeComponent();
        }

        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(dataGridViewX1, bindingNavigator1);
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            ctrl.Save();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Dich Vu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
            }
        }

        private void dataGV_Delete(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Loai Dich Vu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}