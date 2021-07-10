<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SessionReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuMonitorDataSet5 = New GuMonitor.GuMonitorDataSet5()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSessionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colULoginName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSessionid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoveName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalMoveRight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalMoveWrong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ListBoxControl2 = New DevExpress.XtraEditors.ListBoxControl()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.UserTablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuMonitorDataSet3 = New GuMonitor.GuMonitorDataSet3()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UserTablesTableAdapter = New GuMonitor.GuMonitorDataSet3TableAdapters.UserTablesTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SessionReportTableAdapter = New GuMonitor.GuMonitorDataSet5TableAdapters.SessionReportTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuMonitorDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuMonitorDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(489, 87)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "LabelStyle=Top"
        Series1.Legend = "Legend1"
        Series1.Name = "RightMoves"
        Series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "WrongMovies"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(668, 431)
        Me.Chart1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.TextBox1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.ListBoxControl2)
        Me.GroupControl1.Controls.Add(Me.ListBoxControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(451, 651)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Dispaly Report"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(314, 553)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(123, 49)
        Me.SimpleButton3.TabIndex = 19
        Me.SimpleButton3.Text = "Display Log"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 156)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(431, 336)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "GroupControl2"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SessionReportBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 23)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(427, 311)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SessionReportBindingSource
        '
        Me.SessionReportBindingSource.DataMember = "SessionReport"
        Me.SessionReportBindingSource.DataSource = Me.GuMonitorDataSet5
        '
        'GuMonitorDataSet5
        '
        Me.GuMonitorDataSet5.DataSetName = "GuMonitorDataSet5"
        Me.GuMonitorDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colUSessionDate, Me.colULoginName, Me.colSessionid, Me.colMoveName, Me.colTotalMoveRight, Me.colTotalMoveWrong})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMoveRight", "SUM={0:0.##}")})
        '
        'colUSessionDate
        '
        Me.colUSessionDate.FieldName = "USessionDate"
        Me.colUSessionDate.Name = "colUSessionDate"
        Me.colUSessionDate.Visible = True
        Me.colUSessionDate.VisibleIndex = 0
        '
        'colULoginName
        '
        Me.colULoginName.FieldName = "ULoginName"
        Me.colULoginName.Name = "colULoginName"
        Me.colULoginName.Visible = True
        Me.colULoginName.VisibleIndex = 1
        '
        'colSessionid
        '
        Me.colSessionid.FieldName = "Sessionid"
        Me.colSessionid.Name = "colSessionid"
        Me.colSessionid.Visible = True
        Me.colSessionid.VisibleIndex = 5
        '
        'colMoveName
        '
        Me.colMoveName.FieldName = "MoveName"
        Me.colMoveName.Name = "colMoveName"
        Me.colMoveName.Visible = True
        Me.colMoveName.VisibleIndex = 2
        '
        'colTotalMoveRight
        '
        Me.colTotalMoveRight.FieldName = "TotalMoveRight"
        Me.colTotalMoveRight.Name = "colTotalMoveRight"
        Me.colTotalMoveRight.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMoveRight", "SUM={0:0.##}")})
        Me.colTotalMoveRight.Visible = True
        Me.colTotalMoveRight.VisibleIndex = 3
        '
        'colTotalMoveWrong
        '
        Me.colTotalMoveWrong.FieldName = "TotalMoveWrong"
        Me.colTotalMoveWrong.Name = "colTotalMoveWrong"
        Me.colTotalMoveWrong.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalMoveWrong", "SUM={0:0.##}")})
        Me.colTotalMoveWrong.Visible = True
        Me.colTotalMoveWrong.VisibleIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(135, 39)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(113, 23)
        Me.LabelControl6.TabIndex = 17
        Me.LabelControl6.Text = "LabelControl6"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 89)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Report Type"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Users"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 509)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Report Hints"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 536)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 96)
        Me.TextBox1.TabIndex = 15
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(330, 605)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(97, 41)
        Me.SimpleButton2.TabIndex = 14
        Me.SimpleButton2.Text = "Exit"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(314, 498)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(123, 49)
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "Display Report"
        '
        'ListBoxControl2
        '
        Me.ListBoxControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxControl2.Appearance.Options.UseFont = True
        Me.ListBoxControl2.Items.AddRange(New Object() {"Movies report for specific day", "Movies summary report day’s range "})
        Me.ListBoxControl2.Location = New System.Drawing.Point(135, 85)
        Me.ListBoxControl2.Name = "ListBoxControl2"
        Me.ListBoxControl2.Size = New System.Drawing.Size(292, 27)
        Me.ListBoxControl2.TabIndex = 8
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxControl1.Appearance.Options.UseFont = True
        Me.ListBoxControl1.DataSource = Me.UserTablesBindingSource
        Me.ListBoxControl1.DisplayMember = "UName"
        Me.ListBoxControl1.Location = New System.Drawing.Point(135, 39)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(193, 27)
        Me.ListBoxControl1.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ListBoxControl1.TabIndex = 5
        Me.ListBoxControl1.ValueMember = "ULoginName"
        '
        'UserTablesBindingSource
        '
        Me.UserTablesBindingSource.DataMember = "UserTables"
        Me.UserTablesBindingSource.DataSource = Me.GuMonitorDataSet3
        '
        'GuMonitorDataSet3
        '
        Me.GuMonitorDataSet3.DataSetName = "GuMonitorDataSet3"
        Me.GuMonitorDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(706, 593)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "LabelControl1"
        '
        'UserTablesTableAdapter
        '
        Me.UserTablesTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SessionReportTableAdapter
        '
        Me.SessionReportTableAdapter.ClearBeforeFill = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 660)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Chart1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.TopMost = True
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuMonitorDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuMonitorDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ListBoxControl2 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GuMonitorDataSet3 As GuMonitorDataSet3
    Friend WithEvents UserTablesBindingSource As BindingSource
    Friend WithEvents UserTablesTableAdapter As GuMonitorDataSet3TableAdapters.UserTablesTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSessionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colULoginName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSessionid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoveName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMoveRight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalMoveWrong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GuMonitorDataSet5 As GuMonitorDataSet5
    Friend WithEvents SessionReportBindingSource As BindingSource
    Friend WithEvents SessionReportTableAdapter As GuMonitorDataSet5TableAdapters.SessionReportTableAdapter
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
