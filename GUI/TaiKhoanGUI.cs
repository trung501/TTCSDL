using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using GUI.Properties;
using DTO;
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class TaiKhoanGUI : UserControl
    {
        private string maQT;
        private string pass;
        public static TaiKhoanGUI _instance;
        public static TaiKhoanGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TaiKhoanGUI("", "");
                }
                return _instance;
            }
        }
        BUS_ThemTK busTaiKhoan = new BUS_ThemTK();
        BUS_BacSi busBacSi = new BUS_BacSi();
        BUS_ThuNgan busThuNgan = new BUS_ThuNgan();
        BUS_QuanKho busQuanKho = new BUS_QuanKho();
        BUS_QuanTri BusQuanTri = new BUS_QuanTri();
        public TaiKhoanGUI(string maQT, string pass)
        {
            InitializeComponent();
            cbChucVu.SelectedIndex = 0;
            deNgaySinh.Text = DateTime.Now.ToString("MM/dd/yyyy");
            gridView2.RowClick += gridcDanhSachTK_Click;
            GridLocalizer.Active = new MyGridLocalizer();
            this.setVerified(maQT, pass);
        }
        public void setVerified(string maQT, string pass)
        {
            if (maQT.StartsWith("QT"))
            {
                this.maQT = maQT;
                this.pass = pass;
            }
            else
            {
                this.maQT = "";
                this.pass = "";
            }
        }
        public void RefreshGrid()
        {
            gridcDanhSachTK.DataSource = busTaiKhoan.GetAllGeneralInfoTaiKhoan(maQT, pass);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }

        private void displayFollowChucVu(string chucVu)
        {
            if (chucVu == "Bác sĩ")
            {
                lbBangCap.Visible = true;
                teBangCap.Visible = true;
                lbChuyenKhoa.Visible = true;
                teChuyenKhoa.Visible = true;
            }
            else
            {
                lbBangCap.Visible = false;
                teBangCap.Visible = false;
                lbChuyenKhoa.Visible = false;
                teChuyenKhoa.Visible = false;
            }

        }



        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridcDanhSachTK_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void teHoTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tePassWord_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void teDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void teSDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridcDanhSachTK_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            teHoTen.Text = null;
            teMaThanhVien.Text = null;
            tePassWord.Text = null;
            teSDT.Text = null;
            teDiaChi.Text = null;
            teBangCap.Text = null;
            teChuyenKhoa.Text = null;
            deNgaySinh.Text = DateTime.Now.ToString("MM/dd/yyyy");
            cbChucVu.Text = null;
            cbChucVu.Enabled = true;
            cbChucVu.SelectedIndex = 0;
            teMaThanhVien.Enabled = true;
            RefreshGrid();
        }

        private void teHoTen_Properties_Leave(object sender, EventArgs e)
        {

        }

        private void teMaThanhVien_Properties_Leave(object sender, EventArgs e)
        {
            teMaThanhVien.Text = teMaThanhVien.Text.ToUpper();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cbChucVu.Enabled = false;
            teMaThanhVien.Enabled = false;
            tePassWord.Enabled = true;
            DataRow rowSelected = busTaiKhoan.GetFullInfoTaiKhoan(gridView2.GetRowCellValue(e.RowHandle, "MA").ToString().Trim());
            cbChucVu.Text = rowSelected[5].ToString().Trim();
            teHoTen.Text = rowSelected[1].ToString().Trim();
            deNgaySinh.Text = rowSelected[2].ToString().Split(' ')[0];
            teDiaChi.Text = rowSelected[4].ToString().Trim();
            teSDT.Text = rowSelected[3].ToString().Trim();
            teMaThanhVien.Text = rowSelected[0].ToString().Trim();
            teBangCap.Text = rowSelected[7].ToString().Trim();
            teChuyenKhoa.Text = rowSelected[6].ToString().Trim();
            tePassWord.Text = "";
            displayFollowChucVu(cbChucVu.Text.Trim());

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void gcThongtinTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcThaoTac_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayFollowChucVu(cbChucVu.Text.Trim());
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
