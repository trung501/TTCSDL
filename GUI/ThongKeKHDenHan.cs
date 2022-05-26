using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class ThongKeKHDenHan : DevExpress.XtraEditors.XtraUserControl
    {
       
        public static ThongKeKHDenHan _instance;

        public static ThongKeKHDenHan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThongKeKHDenHan();
                }
                return _instance;
            }
        }
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public ThongKeKHDenHan()
        {
            InitializeComponent();
            dateEditCuoi.EditValue = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd");
            dateEditDau.EditValue = DateTime.Now.AddDays(-10).ToString("yyyy-MM-dd");
            Refresh();
        }

        private void Refresh()
        {
            string NgayDau = dateEditDau.DateTime.ToString("yyyy-MM-dd");
            string NgayCuoi = dateEditCuoi.DateTime.ToString("yyyy-MM-dd");
            gridKH.DataSource = busThongKe.GetKhachHangDenHanINTIME(NgayDau, NgayCuoi);
        }

        private void dateEditDau_EditValueChanged(object sender, EventArgs e)
        {
            Refresh();
            
        }

        private void dateEditCuoi_EditValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string NgayDau = dateEditDau.DateTime.ToString("yyyy-MM-dd");
            string NgayCuoi = dateEditCuoi.DateTime.ToString("yyyy-MM-dd");
            ThongKeKHDenHan_Provider KHDenHanRP = new ThongKeKHDenHan_Provider(NgayDau,NgayCuoi);
            KHDenHanRP.ShowReport();
        }
    }
}
