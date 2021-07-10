<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AAdmin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AAdmin))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.UserTablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuMonitorDataSet = New GuMonitor.GuMonitorDataSet()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colULoginName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colUEnabled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUGDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.UserCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuMonitorDataSet1 = New GuMonitor.GuMonitorDataSet1()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.UserTablesTableAdapter = New GuMonitor.GuMonitorDataSetTableAdapters.UserTablesTableAdapter()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.User_CatTableAdapter = New GuMonitor.GuMonitorDataSet1TableAdapters.User_CatTableAdapter()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.UserTablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuMonitorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuMonitorDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.DataNavigator1)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(779, 314)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "User Adminstration"
        '
        'DataNavigator1
        '
        Me.DataNavigator1.DataSource = Me.UserTablesBindingSource
        Me.DataNavigator1.Location = New System.Drawing.Point(5, 277)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(177, 32)
        Me.DataNavigator1.TabIndex = 5
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'UserTablesBindingSource
        '
        Me.UserTablesBindingSource.DataMember = "UserTables"
        Me.UserTablesBindingSource.DataSource = Me.GuMonitorDataSet
        '
        'GuMonitorDataSet
        '
        Me.GuMonitorDataSet.DataSetName = "GuMonitorDataSet"
        Me.GuMonitorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.UserTablesBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 33)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(775, 279)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colULoginName, Me.colUName, Me.colUEmail, Me.colUType, Me.colUPassword, Me.colUEnabled, Me.colUGDate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colULoginName
        '
        Me.colULoginName.Caption = "Login Name"
        Me.colULoginName.FieldName = "ULoginName"
        Me.colULoginName.Name = "colULoginName"
        Me.colULoginName.Visible = True
        Me.colULoginName.VisibleIndex = 0
        '
        'colUName
        '
        Me.colUName.Caption = "User Name"
        Me.colUName.FieldName = "UName"
        Me.colUName.Name = "colUName"
        Me.colUName.Visible = True
        Me.colUName.VisibleIndex = 1
        '
        'colUEmail
        '
        Me.colUEmail.Caption = "E_Mail"
        Me.colUEmail.FieldName = "UEmail"
        Me.colUEmail.Name = "colUEmail"
        Me.colUEmail.Visible = True
        Me.colUEmail.VisibleIndex = 2
        '
        'colUType
        '
        Me.colUType.Caption = "User Roll"
        Me.colUType.FieldName = "UType"
        Me.colUType.Name = "colUType"
        Me.colUType.Visible = True
        Me.colUType.VisibleIndex = 3
        '
        'colUPassword
        '
        Me.colUPassword.Caption = "Password"
        Me.colUPassword.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colUPassword.FieldName = "UPassword"
        Me.colUPassword.Name = "colUPassword"
        Me.colUPassword.Visible = True
        Me.colUPassword.VisibleIndex = 4
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'colUEnabled
        '
        Me.colUEnabled.FieldName = "UEnabled"
        Me.colUEnabled.Name = "colUEnabled"
        Me.colUEnabled.Visible = True
        Me.colUEnabled.VisibleIndex = 5
        '
        'colUGDate
        '
        Me.colUGDate.FieldName = "UGDate"
        Me.colUGDate.Name = "colUGDate"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.UserCatBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "UType"
        Me.RepositoryItemLookUpEdit1.KeyMember = "Id"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'UserCatBindingSource
        '
        Me.UserCatBindingSource.DataMember = "User_Cat"
        Me.UserCatBindingSource.DataSource = Me.GuMonitorDataSet1
        '
        'GuMonitorDataSet1
        '
        Me.GuMonitorDataSet1.DataSetName = "GuMonitorDataSet1"
        Me.GuMonitorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(636, 345)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(139, 37)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Confirm Changes"
        '
        'UserTablesTableAdapter
        '
        Me.UserTablesTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(537, 345)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(83, 37)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Exit "
        '
        'User_CatTableAdapter
        '
        Me.User_CatTableAdapter.ClearBeforeFill = True
        '
        'AAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AAdmin"
        Me.TopMost = True
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.UserTablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuMonitorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuMonitorDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GuMonitorDataSet As GuMonitorDataSet
    Friend WithEvents UserTablesBindingSource As BindingSource
    Friend WithEvents UserTablesTableAdapter As GuMonitorDataSetTableAdapters.UserTablesTableAdapter
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colULoginName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colUEnabled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUGDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GuMonitorDataSet1 As GuMonitorDataSet1
    Friend WithEvents UserCatBindingSource As BindingSource
    Friend WithEvents User_CatTableAdapter As GuMonitorDataSet1TableAdapters.User_CatTableAdapter
End Class
