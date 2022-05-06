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
    public partial class TaiKhoanGUI : DevExpress.XtraEditors.XtraUserControl
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
                    _instance = new TaiKhoanGUI("","");
                }
                return _instance;
            }
        }
        BUS_ThemTK busTaiKhoan = new BUS_ThemTK();
        public TaiKhoanGUI(string maQT, string pass)
        {
            InitializeComponent();

            deNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy");
            gridView2.RowClick += gridcDanhSachTK_Click;
            GridLocalizer.Active = new MyGridLocalizer();
            this.setVerified(maQT, pass);
            InitAutoCompeteTextBox();
        }
        public void setVerified(string maQT,string pass)
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
            gridcDanhSachTK.DataSource = busTaiKhoan.getAllTaiKhoan(maQT, pass);
            //gridView2.Columns["MATHANHVIEN"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }
        private void InitAutoCompeteTextBox()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            DataTable dt = busTaiKhoan.getAllTaiKhoan(maQT, pass);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                collection.Add(dt.Rows[i][0].ToString().Trim());
            }
            /*
            tbMaVC.MaskBox.AutoCompleteCustomSource = collection;
            tbMaVC.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbMaVC.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;*/
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcThongtinTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            switch (cbChucVu.SelectedIndex)
            {
                case 0:
                    if (teMaThanhVien.Text != ""&&teHoTen.Text!=""&&teDiaChi.Text!=""&&tePassWord.Text!=""&&teSDT.Text!=""&&teChuyenKhoa.Text!=""&&teBangCap.Text!=""&&deNgaySinh.Text!="")
                    {

                    }
                    break;
                case 1:
                case 2:
                    if (teMaThanhVien.Text != "" && teHoTen.Text != "" && teDiaChi.Text != "" && tePassWord.Text != "" && teSDT.Text != "" && deNgaySinh.Text != "")
                    {

                    }
                    break;
                default:

                    break;
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChucVu.SelectedIndex)
            {
                case 0:
                    lbBangCap.Visible = true;
                    teBangCap.Visible = true;
                    lbChuyenKhoa.Visible = true;
                    teChuyenKhoa.Visible = true;
                    break;
                case 1:
                    lbBangCap.Visible = false;
                    teBangCap.Visible = false;
                    lbChuyenKhoa.Visible = false;
                    teChuyenKhoa.Visible = false;
                    break;
                case 2:
                    lbBangCap.Visible = false;
                    teBangCap.Visible = false;
                    lbChuyenKhoa.Visible = false;
                    teChuyenKhoa.Visible = false;
                    break;
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

        private void gcThaoTac_Paint(object sender, PaintEventArgs e)
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
            deNgaySinh.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
            cbChucVu.Text = null;
            gridcDanhSachTK.DataSource = null;
        }

        private void teMaThanhVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void teHoTen_Properties_Leave(object sender, EventArgs e)
        {

        }

        private void teMaThanhVien_Properties_Leave(object sender, EventArgs e)
        {
            teMaThanhVien.Text = teMaThanhVien.Text.ToUpper();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {/*
            if (gridView2.GetRowCellValue(e.RowHandle, "MAKH"))
            {
                tbMaKH.Text = gridView2.GetRowCellValue(e.RowHandle, "MAKH").ToString().Trim();
                tbTenKH.Text = gridView2.GetRowCellValue(e.RowHandle, "TENKH").ToString().Trim();
                dtpNgaySinh.Text = gridView2.GetRowCellValue(e.RowHandle, "NGAYSINH").ToString().Split(' ')[0];
                cbGioiTinh.Text = gridView2.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
                tbTienSu.Text = gridView2.GetRowCellValue(e.RowHandle, "TIEUSU").ToString().Trim();
            }*/
        }
    }
}
