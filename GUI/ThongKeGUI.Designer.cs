namespace GUI
{
     partial class ThongKeGUI
     {
          /// <summary> 
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary> 
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedAreaSeriesView stackedAreaSeriesView1 = new DevExpress.XtraCharts.StackedAreaSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.dateEditCuoi = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControlDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tedTongDoanhThu = new DevExpress.XtraEditors.TextEdit();
            this.ButtonReportTK = new DevExpress.XtraEditors.SimpleButton();
            this.chartControlLoaiVC = new DevExpress.XtraCharts.ChartControl();
            this.chartControlMostVC = new DevExpress.XtraCharts.ChartControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditVCDau = new DevExpress.XtraEditors.DateEdit();
            this.dateEditVCCuoi = new DevExpress.XtraEditors.DateEdit();
            this.simpleButtonGiam = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonTang = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbBoxEditSoMostVC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timerGiam = new System.Windows.Forms.Timer(this.components);
            this.timerTang = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTongDoanhThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlLoaiVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMostVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCCuoi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCCuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBoxEditSoMostVC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditCuoi
            // 
            this.dateEditCuoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditCuoi.EditValue = null;
            this.dateEditCuoi.Location = new System.Drawing.Point(342, 14);
            this.dateEditCuoi.Name = "dateEditCuoi";
            this.dateEditCuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCuoi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCuoi.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEditCuoi.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditCuoi.Size = new System.Drawing.Size(172, 24);
            this.dateEditCuoi.TabIndex = 4;
            this.dateEditCuoi.EditValueChanged += new System.EventHandler(this.dateEdit2_EditValueChanged);
            // 
            // dateEditDau
            // 
            this.dateEditDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditDau.EditValue = null;
            this.dateEditDau.Location = new System.Drawing.Point(133, 14);
            this.dateEditDau.Name = "dateEditDau";
            this.dateEditDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDau.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEditDau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditDau.Size = new System.Drawing.Size(172, 24);
            this.dateEditDau.TabIndex = 3;
            this.dateEditDau.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(311, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(46, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thống kê từ";
            // 
            // chartControlDoanhThu
            // 
            this.chartControlDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlDoanhThu.Diagram = xyDiagram1;
            this.chartControlDoanhThu.Legend.Name = "Default Legend";
            this.chartControlDoanhThu.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlDoanhThu.Location = new System.Drawing.Point(0, 42);
            this.chartControlDoanhThu.Name = "chartControlDoanhThu";
            series1.Name = "BDDoanhThu";
            stackedAreaSeriesView1.Transparency = ((byte)(135));
            series1.View = stackedAreaSeriesView1;
            this.chartControlDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlDoanhThu.Size = new System.Drawing.Size(1054, 354);
            this.chartControlDoanhThu.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "Thống kê doanh thu";
            this.chartControlDoanhThu.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(524, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Có tổng doanh thu:";
            // 
            // tedTongDoanhThu
            // 
            this.tedTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tedTongDoanhThu.Location = new System.Drawing.Point(657, 14);
            this.tedTongDoanhThu.Name = "tedTongDoanhThu";
            this.tedTongDoanhThu.Properties.ReadOnly = true;
            this.tedTongDoanhThu.Size = new System.Drawing.Size(170, 24);
            this.tedTongDoanhThu.TabIndex = 6;
            this.tedTongDoanhThu.ToolTip = "Click để Copy";
            this.tedTongDoanhThu.DoubleClick += new System.EventHandler(this.tedTongDoanhThu_DoubleClick);
            // 
            // ButtonReportTK
            // 
            this.ButtonReportTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReportTK.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.ButtonReportTK.Appearance.Options.UseBackColor = true;
            this.ButtonReportTK.Location = new System.Drawing.Point(866, 11);
            this.ButtonReportTK.Name = "ButtonReportTK";
            this.ButtonReportTK.Size = new System.Drawing.Size(143, 29);
            this.ButtonReportTK.TabIndex = 7;
            this.ButtonReportTK.Text = "Xuất báo cáo";
            this.ButtonReportTK.Click += new System.EventHandler(this.ButtonReportTK_Click);
            // 
            // chartControlLoaiVC
            // 
            this.chartControlLoaiVC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartControlLoaiVC.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chartControlLoaiVC.Legend.Name = "Default Legend";
            this.chartControlLoaiVC.Legend.Tag = "";
            this.chartControlLoaiVC.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlLoaiVC.Location = new System.Drawing.Point(0, 395);
            this.chartControlLoaiVC.Name = "chartControlLoaiVC";
            doughnutSeriesLabel1.TextPattern = "{A}:{V}";
            series2.Label = doughnutSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "BDLoaiVC";
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series2.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            series2.ToolTipPointPattern = "{A}: {V}";
            doughnutSeriesView1.HoleRadiusPercent = 40;
            seriesTitle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seriesTitle1.Text = "Tỷ trọng vaccine theo từng loại";
            seriesTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            doughnutSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series2.View = doughnutSeriesView1;
            this.chartControlLoaiVC.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControlLoaiVC.Size = new System.Drawing.Size(497, 379);
            this.chartControlLoaiVC.TabIndex = 0;
            // 
            // chartControlMostVC
            // 
            this.chartControlMostVC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.Rotated = true;
            this.chartControlMostVC.Diagram = xyDiagram2;
            this.chartControlMostVC.Legend.Name = "Default Legend";
            this.chartControlMostVC.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlMostVC.Location = new System.Drawing.Point(497, 395);
            this.chartControlMostVC.Name = "chartControlMostVC";
            series3.Name = "BDCmostVC";
            series3.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series3.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            this.chartControlMostVC.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControlMostVC.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.chartControlMostVC.Size = new System.Drawing.Size(557, 351);
            this.chartControlMostVC.TabIndex = 8;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle2.Text = "Top Vaccine dùng nhiều";
            this.chartControlMostVC.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl4.Location = new System.Drawing.Point(524, 750);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 18);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Thống kê từ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl5.Location = new System.Drawing.Point(742, 750);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "đến";
            // 
            // dateEditVCDau
            // 
            this.dateEditVCDau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateEditVCDau.EditValue = null;
            this.dateEditVCDau.Location = new System.Drawing.Point(611, 747);
            this.dateEditVCDau.Name = "dateEditVCDau";
            this.dateEditVCDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVCDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVCDau.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEditVCDau.Size = new System.Drawing.Size(125, 24);
            this.dateEditVCDau.TabIndex = 11;
            this.dateEditVCDau.EditValueChanged += new System.EventHandler(this.dateEditVCDau_EditValueChanged);
            // 
            // dateEditVCCuoi
            // 
            this.dateEditVCCuoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateEditVCCuoi.EditValue = null;
            this.dateEditVCCuoi.Location = new System.Drawing.Point(773, 747);
            this.dateEditVCCuoi.Name = "dateEditVCCuoi";
            this.dateEditVCCuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVCCuoi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVCCuoi.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateEditVCCuoi.Size = new System.Drawing.Size(125, 24);
            this.dateEditVCCuoi.TabIndex = 12;
            this.dateEditVCCuoi.EditValueChanged += new System.EventHandler(this.dateEditVCCuoi_EditValueChanged);
            // 
            // simpleButtonGiam
            // 
            this.simpleButtonGiam.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButtonGiam.Appearance.Options.UseFont = true;
            this.simpleButtonGiam.Location = new System.Drawing.Point(0, 42);
            this.simpleButtonGiam.Name = "simpleButtonGiam";
            this.simpleButtonGiam.Size = new System.Drawing.Size(35, 35);
            this.simpleButtonGiam.TabIndex = 13;
            this.simpleButtonGiam.Text = "<";
            this.simpleButtonGiam.Click += new System.EventHandler(this.simpleButtonGiam_Click);
            this.simpleButtonGiam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleButtonGiam_MouseDown);
            this.simpleButtonGiam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simpleButtonGiam_MouseUp);
            // 
            // simpleButtonTang
            // 
            this.simpleButtonTang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonTang.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButtonTang.Appearance.Options.UseFont = true;
            this.simpleButtonTang.Location = new System.Drawing.Point(1020, 42);
            this.simpleButtonTang.Name = "simpleButtonTang";
            this.simpleButtonTang.Size = new System.Drawing.Size(35, 35);
            this.simpleButtonTang.TabIndex = 14;
            this.simpleButtonTang.Text = ">";
            this.simpleButtonTang.Click += new System.EventHandler(this.simpleButtonTang_Click);
            this.simpleButtonTang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.simpleButtonTang_MouseDown);
            this.simpleButtonTang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.simpleButtonTang_MouseUp);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl6.Location = new System.Drawing.Point(904, 750);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 18);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Hiển thị";
            // 
            // cbBoxEditSoMostVC
            // 
            this.cbBoxEditSoMostVC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbBoxEditSoMostVC.Location = new System.Drawing.Point(958, 747);
            this.cbBoxEditSoMostVC.Name = "cbBoxEditSoMostVC";
            this.cbBoxEditSoMostVC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBoxEditSoMostVC.Properties.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbBoxEditSoMostVC.Size = new System.Drawing.Size(62, 24);
            this.cbBoxEditSoMostVC.TabIndex = 16;
            this.cbBoxEditSoMostVC.SelectedIndexChanged += new System.EventHandler(this.cbBoxEditSoMostVC_SelectedIndexChanged);
            // 
            // timerGiam
            // 
            this.timerGiam.Tick += new System.EventHandler(this.timerGiam_Tick);
            // 
            // timerTang
            // 
            this.timerTang.Tick += new System.EventHandler(this.timerTang_Tick);
            // 
            // ThongKeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbBoxEditSoMostVC);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.simpleButtonTang);
            this.Controls.Add(this.simpleButtonGiam);
            this.Controls.Add(this.dateEditVCCuoi);
            this.Controls.Add(this.dateEditVCDau);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.chartControlMostVC);
            this.Controls.Add(this.chartControlLoaiVC);
            this.Controls.Add(this.ButtonReportTK);
            this.Controls.Add(this.tedTongDoanhThu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateEditCuoi);
            this.Controls.Add(this.chartControlDoanhThu);
            this.Controls.Add(this.dateEditDau);
            this.Controls.Add(this.labelControl2);
            this.Name = "ThongKeGUI";
            this.Size = new System.Drawing.Size(1055, 774);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTongDoanhThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlLoaiVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMostVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCCuoi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVCCuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBoxEditSoMostVC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControlDoanhThu;
        private DevExpress.XtraEditors.SimpleButton ButtonReportTK;
        private DevExpress.XtraEditors.TextEdit tedTongDoanhThu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraCharts.ChartControl chartControlLoaiVC;
        private DevExpress.XtraCharts.ChartControl chartControlMostVC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEditVCDau;
        private DevExpress.XtraEditors.DateEdit dateEditVCCuoi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGiam;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTang;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbBoxEditSoMostVC;
        private System.Windows.Forms.Timer timerGiam;
        private System.Windows.Forms.Timer timerTang;
        public DevExpress.XtraEditors.DateEdit dateEditCuoi;
        public DevExpress.XtraEditors.DateEdit dateEditDau;
    }
}
