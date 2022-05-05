using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Properties;
using BUS;
using DTO;
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class ThanhToanGUI : UserControl
    {
        BUS_GiamHo busGH = new BUS_GiamHo();
        BUS_HoaDon busHD = new BUS_HoaDon();
        BUS_Vaccine busVC = new BUS_Vaccine();
        BUS_PhieuTiem busPT = new BUS_PhieuTiem();
        

        //List<DTO_Vaccine> listVC = new List<DTO_Vaccine>();
        DataTable listVC = new DataTable();

        DTO_ThuNgan thuNgan;

        public ThanhToanGUI(DTO_ThuNgan thuNgan)
        {
            InitializeComponent();

            this.thuNgan = thuNgan;

            dtpNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView2.RowClick += GridView2_RowClick;

            GridLocalizer.Active = new MyGridLocalizer();
        }

        private void GridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tbMaGH.Text = gridView2.GetRowCellValue(e.RowHandle, "MAGH").ToString().Trim();
            tbTenNGH.Text = gridView2.GetRowCellValue(e.RowHandle, "HOTEN").ToString().Trim();
            tbDiaChiNGH.Text = gridView2.GetRowCellValue(e.RowHandle, "DIACHI").ToString().Trim();
            tbSdtNGH.Text = gridView2.GetRowCellValue(e.RowHandle, "SDT").ToString().Trim();
        }

        private void tbMaPT_Leave(object sender, EventArgs e)
        {
            if (tbMaPT.Text == "") return;

            int tongTien = 0;

            //listVC = busPT.GetVCFromPHIEUTIEM(tbMaPT.Text);
            //DataTable dtb = new DataTable();
            //dtb.Columns.Add("MAVACCINE");
            //dtb.Columns.Add("TENVACCINE");
            //dtb.Columns.Add("NHASX");
            //dtb.Columns.Add("LOAIVC");
            //dtb.Columns.Add("DONGIA");
            //for (int i = 0; i < listVC.Count; i++)
            //{
            //    DataRow dr = dtb.NewRow();
            //    dr["MAVACCINE"] = listVC[i].MAVACCINE;
            //    dr["TENVACCINE"] = listVC[i].TENVACCINE;
            //    dr["NHASX"] = listVC[i].NHASX;
            //    dr["LOAIVC"] = listVC[i].LOAIVACCINE;
            //    dr["DONGIA"] = listVC[i].DONGIA;
            //    dtb.Rows.Add(dr);
            //    tongTien += listVC[i].DONGIA;
            //}

            listVC = busPT.GetVCFromPHIEUTIEM(tbMaPT.Text);
            for (int i = 0; i < listVC.Rows.Count; i++)
            {
                tongTien += Convert.ToInt32(listVC.Rows[i][7]) * (int)Math.Ceiling(Convert.ToDouble(listVC.Rows[i][5])); // cot 7 la DONGIA, cot 5 la LIEULUONG
            }

            gridVC.DataSource = busPT.GetVCFromPHIEUTIEM(tbMaPT.Text);
            gridView1.BestFitColumns();
            tbTenKH.Text = busPT.GetTenKHFromPHIEUTIEM(tbMaPT.Text);

            tbTongTien.Text = tongTien.ToString();
        }

        private void ThanhToanGUI_Load(object sender, EventArgs e)
        {
            dtpNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridNGH.DataSource = busGH.GetAllNGH();
            gridView2.Columns["MAGH"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }

        private void tbChieuKhau_Leave(object sender, EventArgs e)
        {
            if (tbTongTien.Text != "")
            {
                tbPhaiTra.Text = (Convert.ToInt32(tbTongTien.Text) - Convert.ToInt32(tbTongTien.Text) * Convert.ToDouble(tbChieuKhau.Text)).ToString();
            }
            else return;
        }

        private void tbKhachDua_Leave(object sender, EventArgs e)
        {
            if (tbKhachDua.Text != "" && tbPhaiTra.Text != "")
            {
                tbTraLai.Text = (Convert.ToInt32(tbKhachDua.Text) - Convert.ToInt32(tbPhaiTra.Text)).ToString();
            }
            else return;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMaGH.Text = "";
            tbTenNGH.Text = "";
            tbDiaChiNGH.Text = "";
            tbSdtNGH.Text = "";
            tbMaPT.Text = "";
            dtpNgayTao.Text = "";
            tbTenKH.Text = "";
            gridVC.DataSource = null;
            tbTongTien.Text = "";
            tbChieuKhau.Text = "";
            tbPhaiTra.Text = "";
            tbKhachDua.Text = "";
            tbTraLai.Text = "";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (tbTenNGH.Text != "" && tbDiaChiNGH.Text != "" && tbSdtNGH.Text != "" && tbMaPT.Text != "" && tbChieuKhau.Text != "" && dtpNgayTao.Text != "" && tbTongTien.Text != "" && tbPhaiTra.Text != "" && tbKhachDua.Text != "" && tbTraLai.Text != "")
            {
                if (tbMaGH.Text == "")
                {
                    tbMaGH.Text = busGH.NextMaGH();
                }
                if (!busGH.IsMaGHExists(tbMaGH.Text))
                {
                    busGH.InsertNGH(new DTO_GiamHo(tbMaGH.Text, tbTenNGH.Text, tbDiaChiNGH.Text, tbSdtNGH.Text));
                }

                //Lấy mã Hóa đơn:
                string NextMaHD = busHD.NextMaHD();

                busHD.InsertHD(new DTO_HoaDon(NextMaHD, Convert.ToDouble(tbChieuKhau.Text), dtpNgayTao.DateTime.ToString("yyyy-MM-dd"), Convert.ToInt32(tbTongTien.Text), this.thuNgan.MATHUNGAN, tbMaGH.Text, tbMaPT.Text));

                busGH.AddMaGHtoKH(tbMaGH.Text);
                MessageBoxEx.Show("Thanh toán thành công");

                //Xuất Hóa đơn ra file:
                HoaDonCreator HoaDonCreator = new HoaDonCreator(NextMaHD);
                HoaDonCreator.ShowReportHoaDon();
            }
            else
            {
                MessageBoxEx.Show("Bạn chưa nhập đủ thông tin");
            }

            

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ThanhToanLIST ttList = new ThanhToanLIST();
            ttList.ShowDialog();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            if (tbMaPT.Text != "")
            {
                if (busPT.CheckExistance(tbMaPT.Text))
                {
                    if (busPT.CheckPaymentStatus(tbMaPT.Text))
                    {
                        MessageBoxEx.Show("Đã thanh toán");
                    }
                    else MessageBoxEx.Show("Chưa thanh toán");
                }
                else MessageBoxEx.Show("Phiếu tiêm không tồn tại");
            }
            else MessageBoxEx.Show("Chưa nhập thông tin");
        }

        private void tbMaGH_Enter(object sender, EventArgs e)
        {
            lbNewNGH.Visible = true;
        }

        private void tbMaGH_Leave(object sender, EventArgs e)
        {
            lbNewNGH.Visible = false;
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridNGH_Click(object sender, EventArgs e)
        {

        }
    }
}
