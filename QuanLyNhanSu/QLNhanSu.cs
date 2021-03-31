using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frm_NhanSu : Form
    {
        LopDungChung lopchung = new LopDungChung();
        public frm_NhanSu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Them nhan vien
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into NHANSU values ('"+ txt_MaNV.Text +"','"+ txt_HoTen.Text + "','" + TextBox_DiaChi.Text + "')";

            int ketqua = lopchung.ThemSuaXoa(sqlThem);

            if (ketqua >= 1)
            {
                MessageBox.Show("Thêm nhân sự thành công");
            } else MessageBox.Show("Thêm nhân sự thất bại.......hãy thử lại!!!!");
        }

        //Xoa nhan vien
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng không thể rống mã số nhân viên");
            }
            string sqlXoa = "delete from NHANSU where MSNV = '" + txt_MaNV.Text +"' ";

            int ketqua = lopchung.ThemSuaXoa(sqlXoa);

            if (ketqua >= 1)
            {
                MessageBox.Show("Xóa dữ liệu thành công");
            }
            else MessageBox.Show("Xóa dữ liệu thất bại.......hãy thử lại!!!!");
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "" || txt_HoTen.Text == "" || TextBox_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng không thể rống!!!");
            }
            string sqlCapNhap = "update NHANSU set HOTEN = N'"+ txt_HoTen.Text + "' ,DIACHI = N'"+ TextBox_DiaChi.Text + "' where MSNV = '" + txt_MaNV.Text + "' ";

            int ketqua = lopchung.ThemSuaXoa(sqlCapNhap);

            if (ketqua >= 1)
            {
                MessageBox.Show("Cập Nhật dữ liệu thành công");
            }
            else MessageBox.Show("Cập Nhật dữ liệu thất bại.......hãy thử lại!!!!");
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sqlDem = "select count (*) from NHANSU";
            int ketqua = lopchung.Dem(sqlDem);
            txt_SLNhanVien.Text = ketqua.ToString();
                    
        }
    }
}
