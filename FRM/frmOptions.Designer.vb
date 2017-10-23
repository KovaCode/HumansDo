<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.tabOptions = New DevExpress.XtraTab.XtraTabControl()
        Me.tabGeneralno = New DevExpress.XtraTab.XtraTabPage()
        Me.lblMin = New DevExpress.XtraEditors.LabelControl()
        Me.txtInactive = New DevExpress.XtraEditors.SpinEdit()
        Me.lblInactivePeriod = New DevExpress.XtraEditors.LabelControl()
        Me.lblSkin = New DevExpress.XtraEditors.LabelControl()
        Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        Me.chkStatusList = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.chkPopUp = New DevExpress.XtraEditors.CheckEdit()
        Me.lblsetup1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPassPol = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblPassPolicy = New DevExpress.XtraEditors.LabelControl()
        Me.tabLanguage = New DevExpress.XtraTab.XtraTabPage()
        Me.groupLang = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.groupMonth = New System.Windows.Forms.GroupBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.groupDays = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.groupCurrency = New System.Windows.Forms.GroupBox()
        Me.lblFullDate = New System.Windows.Forms.Label()
        Me.lblFormatedDate = New System.Windows.Forms.Label()
        Me.lblFormatedNum = New System.Windows.Forms.Label()
        Me.groupRegion = New System.Windows.Forms.GroupBox()
        Me.lblRegionEng = New System.Windows.Forms.Label()
        Me.lblRegionCurr = New System.Windows.Forms.Label()
        Me.lblRegionCurrEng = New System.Windows.Forms.Label()
        Me.groupCulture = New System.Windows.Forms.GroupBox()
        Me.lblCultureLangWin = New System.Windows.Forms.Label()
        Me.lblCultureLang = New System.Windows.Forms.Label()
        Me.lblCultureNameNeut = New System.Windows.Forms.Label()
        Me.lblCultureNameEng = New System.Windows.Forms.Label()
        Me.lblCultureNameNative = New System.Windows.Forms.Label()
        Me.lblCultureName = New System.Windows.Forms.Label()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOptions.SuspendLayout()
        Me.tabGeneralno.SuspendLayout()
        CType(Me.txtInactive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStatusList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPopUp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPassPol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLanguage.SuspendLayout()
        Me.groupLang.SuspendLayout()
        Me.groupMonth.SuspendLayout()
        Me.groupDays.SuspendLayout()
        Me.groupCurrency.SuspendLayout()
        Me.groupRegion.SuspendLayout()
        Me.groupCulture.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(409, 401)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(168, 23)
        Me.cmdSave.TabIndex = 33
        Me.cmdSave.Text = "&Spremi"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(583, 401)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(101, 23)
        Me.cmdExit.TabIndex = 34
        Me.cmdExit.Text = "&Izlaz"
        '
        'tabOptions
        '
        Me.tabOptions.Location = New System.Drawing.Point(12, 12)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedTabPage = Me.tabGeneralno
        Me.tabOptions.Size = New System.Drawing.Size(672, 387)
        Me.tabOptions.TabIndex = 35
        Me.tabOptions.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabGeneralno, Me.tabLanguage})
        '
        'tabGeneralno
        '
        Me.tabGeneralno.Controls.Add(Me.lblMin)
        Me.tabGeneralno.Controls.Add(Me.txtInactive)
        Me.tabGeneralno.Controls.Add(Me.lblInactivePeriod)
        Me.tabGeneralno.Controls.Add(Me.lblSkin)
        Me.tabGeneralno.Controls.Add(Me.DropDownButton1)
        Me.tabGeneralno.Controls.Add(Me.chkStatusList)
        Me.tabGeneralno.Controls.Add(Me.LabelControl1)
        Me.tabGeneralno.Controls.Add(Me.chkPopUp)
        Me.tabGeneralno.Controls.Add(Me.lblsetup1)
        Me.tabGeneralno.Controls.Add(Me.cmdBrowse)
        Me.tabGeneralno.Controls.Add(Me.cmbPassPol)
        Me.tabGeneralno.Controls.Add(Me.lblPassPolicy)
        Me.tabGeneralno.Name = "tabGeneralno"
        Me.tabGeneralno.Size = New System.Drawing.Size(667, 361)
        Me.tabGeneralno.Text = "System"
        '
        'lblMin
        '
        Me.lblMin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblMin.Location = New System.Drawing.Point(198, 197)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(25, 13)
        Me.lblMin.TabIndex = 14
        Me.lblMin.Text = "min."
        '
        'txtInactive
        '
        Me.txtInactive.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtInactive.Location = New System.Drawing.Point(118, 194)
        Me.txtInactive.Name = "txtInactive"
        Me.txtInactive.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtInactive.Size = New System.Drawing.Size(72, 20)
        Me.txtInactive.TabIndex = 13
        '
        'lblInactivePeriod
        '
        Me.lblInactivePeriod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblInactivePeriod.Location = New System.Drawing.Point(15, 184)
        Me.lblInactivePeriod.Name = "lblInactivePeriod"
        Me.lblInactivePeriod.Size = New System.Drawing.Size(110, 39)
        Me.lblInactivePeriod.TabIndex = 12
        Me.lblInactivePeriod.Text = "Vrijeme neaktivnosti nakon kojeg se izvršenje prekida:"
        '
        'lblSkin
        '
        Me.lblSkin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSkin.Location = New System.Drawing.Point(15, 248)
        Me.lblSkin.Name = "lblSkin"
        Me.lblSkin.Size = New System.Drawing.Size(83, 13)
        Me.lblSkin.TabIndex = 11
        Me.lblSkin.Text = "Tema (izgled):"
        '
        'DropDownButton1
        '
        Me.DropDownButton1.Image = CType(resources.GetObject("DropDownButton1.Image"), System.Drawing.Image)
        Me.DropDownButton1.Location = New System.Drawing.Point(118, 238)
        Me.DropDownButton1.Name = "DropDownButton1"
        Me.DropDownButton1.Size = New System.Drawing.Size(135, 23)
        Me.DropDownButton1.TabIndex = 10
        Me.DropDownButton1.Text = "Odabir teme"
        '
        'chkStatusList
        '
        Me.chkStatusList.Location = New System.Drawing.Point(120, 60)
        Me.chkStatusList.Name = "chkStatusList"
        Me.chkStatusList.Size = New System.Drawing.Size(133, 118)
        Me.chkStatusList.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(15, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 26)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Zadane postavke filtera:"
        '
        'chkPopUp
        '
        Me.chkPopUp.Location = New System.Drawing.Point(116, 288)
        Me.chkPopUp.Name = "chkPopUp"
        Me.chkPopUp.Size = New System.Drawing.Size(75, 19)
        Me.chkPopUp.TabIndex = 7
        '
        'lblsetup1
        '
        Me.lblsetup1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblsetup1.Location = New System.Drawing.Point(15, 278)
        Me.lblsetup1.Name = "lblsetup1"
        Me.lblsetup1.Size = New System.Drawing.Size(95, 39)
        Me.lblsetup1.TabIndex = 6
        Me.lblsetup1.Text = "Želim primati obavijesti i mailove putem popUp-a:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(300, 22)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(20, 20)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "..."
        '
        'cmbPassPol
        '
        Me.cmbPassPol.Location = New System.Drawing.Point(118, 22)
        Me.cmbPassPol.Name = "cmbPassPol"
        Me.cmbPassPol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPassPol.Size = New System.Drawing.Size(176, 20)
        Me.cmbPassPol.TabIndex = 1
        '
        'lblPassPolicy
        '
        Me.lblPassPolicy.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblPassPolicy.Location = New System.Drawing.Point(15, 25)
        Me.lblPassPolicy.Name = "lblPassPolicy"
        Me.lblPassPolicy.Size = New System.Drawing.Size(83, 26)
        Me.lblPassPolicy.TabIndex = 0
        Me.lblPassPolicy.Text = "Zadano pravilo lozinke:"
        '
        'tabLanguage
        '
        Me.tabLanguage.Controls.Add(Me.groupLang)
        Me.tabLanguage.Controls.Add(Me.groupMonth)
        Me.tabLanguage.Controls.Add(Me.groupDays)
        Me.tabLanguage.Controls.Add(Me.groupCurrency)
        Me.tabLanguage.Controls.Add(Me.groupRegion)
        Me.tabLanguage.Controls.Add(Me.groupCulture)
        Me.tabLanguage.Name = "tabLanguage"
        Me.tabLanguage.Size = New System.Drawing.Size(667, 361)
        Me.tabLanguage.Text = "Jezik"
        '
        'groupLang
        '
        Me.groupLang.Controls.Add(Me.ListBox1)
        Me.groupLang.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupLang.Location = New System.Drawing.Point(4, 4)
        Me.groupLang.Name = "groupLang"
        Me.groupLang.Size = New System.Drawing.Size(151, 347)
        Me.groupLang.TabIndex = 17
        Me.groupLang.TabStop = False
        Me.groupLang.Text = "Dostupni jezici"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(139, 316)
        Me.ListBox1.TabIndex = 12
        '
        'groupMonth
        '
        Me.groupMonth.Controls.Add(Me.ListBox3)
        Me.groupMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupMonth.Location = New System.Drawing.Point(505, 150)
        Me.groupMonth.Name = "groupMonth"
        Me.groupMonth.Size = New System.Drawing.Size(145, 200)
        Me.groupMonth.TabIndex = 16
        Me.groupMonth.TabStop = False
        Me.groupMonth.Text = "Month Names"
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(6, 20)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(135, 173)
        Me.ListBox3.TabIndex = 4
        '
        'groupDays
        '
        Me.groupDays.Controls.Add(Me.ListBox2)
        Me.groupDays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupDays.Location = New System.Drawing.Point(505, 3)
        Me.groupDays.Name = "groupDays"
        Me.groupDays.Size = New System.Drawing.Size(145, 141)
        Me.groupDays.TabIndex = 15
        Me.groupDays.TabStop = False
        Me.groupDays.Text = "Day Names"
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 20)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(128, 108)
        Me.ListBox2.TabIndex = 4
        '
        'groupCurrency
        '
        Me.groupCurrency.Controls.Add(Me.lblFullDate)
        Me.groupCurrency.Controls.Add(Me.lblFormatedDate)
        Me.groupCurrency.Controls.Add(Me.lblFormatedNum)
        Me.groupCurrency.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupCurrency.Location = New System.Drawing.Point(161, 261)
        Me.groupCurrency.Name = "groupCurrency"
        Me.groupCurrency.Size = New System.Drawing.Size(338, 90)
        Me.groupCurrency.TabIndex = 14
        Me.groupCurrency.TabStop = False
        Me.groupCurrency.Text = "Formatting Date and Currency"
        '
        'lblFullDate
        '
        Me.lblFullDate.AutoSize = True
        Me.lblFullDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFullDate.Location = New System.Drawing.Point(18, 21)
        Me.lblFullDate.Name = "lblFullDate"
        Me.lblFullDate.Size = New System.Drawing.Size(44, 13)
        Me.lblFullDate.TabIndex = 3
        Me.lblFullDate.Text = "Label10"
        '
        'lblFormatedDate
        '
        Me.lblFormatedDate.AutoSize = True
        Me.lblFormatedDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFormatedDate.Location = New System.Drawing.Point(18, 43)
        Me.lblFormatedDate.Name = "lblFormatedDate"
        Me.lblFormatedDate.Size = New System.Drawing.Size(44, 13)
        Me.lblFormatedDate.TabIndex = 2
        Me.lblFormatedDate.Text = "Label11"
        '
        'lblFormatedNum
        '
        Me.lblFormatedNum.AutoSize = True
        Me.lblFormatedNum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblFormatedNum.Location = New System.Drawing.Point(18, 65)
        Me.lblFormatedNum.Name = "lblFormatedNum"
        Me.lblFormatedNum.Size = New System.Drawing.Size(44, 13)
        Me.lblFormatedNum.TabIndex = 1
        Me.lblFormatedNum.Text = "Label12"
        '
        'groupRegion
        '
        Me.groupRegion.Controls.Add(Me.lblRegionEng)
        Me.groupRegion.Controls.Add(Me.lblRegionCurr)
        Me.groupRegion.Controls.Add(Me.lblRegionCurrEng)
        Me.groupRegion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupRegion.Location = New System.Drawing.Point(161, 161)
        Me.groupRegion.Name = "groupRegion"
        Me.groupRegion.Size = New System.Drawing.Size(338, 94)
        Me.groupRegion.TabIndex = 13
        Me.groupRegion.TabStop = False
        Me.groupRegion.Text = "Region Information"
        '
        'lblRegionEng
        '
        Me.lblRegionEng.AutoSize = True
        Me.lblRegionEng.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRegionEng.Location = New System.Drawing.Point(18, 71)
        Me.lblRegionEng.Name = "lblRegionEng"
        Me.lblRegionEng.Size = New System.Drawing.Size(38, 13)
        Me.lblRegionEng.TabIndex = 3
        Me.lblRegionEng.Text = "Label9"
        '
        'lblRegionCurr
        '
        Me.lblRegionCurr.AutoSize = True
        Me.lblRegionCurr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRegionCurr.Location = New System.Drawing.Point(18, 46)
        Me.lblRegionCurr.Name = "lblRegionCurr"
        Me.lblRegionCurr.Size = New System.Drawing.Size(38, 13)
        Me.lblRegionCurr.TabIndex = 2
        Me.lblRegionCurr.Text = "Label8"
        '
        'lblRegionCurrEng
        '
        Me.lblRegionCurrEng.AutoSize = True
        Me.lblRegionCurrEng.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblRegionCurrEng.Location = New System.Drawing.Point(18, 23)
        Me.lblRegionCurrEng.Name = "lblRegionCurrEng"
        Me.lblRegionCurrEng.Size = New System.Drawing.Size(38, 13)
        Me.lblRegionCurrEng.TabIndex = 1
        Me.lblRegionCurrEng.Text = "Label7"
        '
        'groupCulture
        '
        Me.groupCulture.Controls.Add(Me.lblCultureLangWin)
        Me.groupCulture.Controls.Add(Me.lblCultureLang)
        Me.groupCulture.Controls.Add(Me.lblCultureNameNeut)
        Me.groupCulture.Controls.Add(Me.lblCultureNameEng)
        Me.groupCulture.Controls.Add(Me.lblCultureNameNative)
        Me.groupCulture.Controls.Add(Me.lblCultureName)
        Me.groupCulture.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupCulture.Location = New System.Drawing.Point(161, 3)
        Me.groupCulture.Name = "groupCulture"
        Me.groupCulture.Size = New System.Drawing.Size(338, 152)
        Me.groupCulture.TabIndex = 12
        Me.groupCulture.TabStop = False
        Me.groupCulture.Text = "Culture Information"
        '
        'lblCultureLangWin
        '
        Me.lblCultureLangWin.AutoSize = True
        Me.lblCultureLangWin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCultureLangWin.Location = New System.Drawing.Point(18, 130)
        Me.lblCultureLangWin.Name = "lblCultureLangWin"
        Me.lblCultureLangWin.Size = New System.Drawing.Size(38, 13)
        Me.lblCultureLangWin.TabIndex = 5
        Me.lblCultureLangWin.Text = "Label6"
        '
        'lblCultureLang
        '
        Me.lblCultureLang.AutoSize = True
        Me.lblCultureLang.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCultureLang.Location = New System.Drawing.Point(18, 108)
        Me.lblCultureLang.Name = "lblCultureLang"
        Me.lblCultureLang.Size = New System.Drawing.Size(38, 13)
        Me.lblCultureLang.TabIndex = 4
        Me.lblCultureLang.Text = "Label5"
        '
        'lblCultureNameNeut
        '
        Me.lblCultureNameNeut.AutoSize = True
        Me.lblCultureNameNeut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCultureNameNeut.Location = New System.Drawing.Point(18, 86)
        Me.lblCultureNameNeut.Name = "lblCultureNameNeut"
        Me.lblCultureNameNeut.Size = New System.Drawing.Size(38, 13)
        Me.lblCultureNameNeut.TabIndex = 3
        Me.lblCultureNameNeut.Text = "Label4"
        '
        'lblCultureNameEng
        '
        Me.lblCultureNameEng.AutoSize = True
        Me.lblCultureNameEng.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCultureNameEng.Location = New System.Drawing.Point(18, 64)
        Me.lblCultureNameEng.Name = "lblCultureNameEng"
        Me.lblCultureNameEng.Size = New System.Drawing.Size(38, 13)
        Me.lblCultureNameEng.TabIndex = 2
        Me.lblCultureNameEng.Text = "Label3"
        '
        'lblCultureNameNative
        '
        Me.lblCultureNameNative.AutoSize = True
        Me.lblCultureNameNative.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCultureNameNative.Location = New System.Drawing.Point(18, 42)
        Me.lblCultureNameNative.Name = "lblCultureNameNative"
        Me.lblCultureNameNative.Size = New System.Drawing.Size(38, 13)
        Me.lblCultureNameNative.TabIndex = 1
        Me.lblCultureNameNative.Text = "Label2"
        '
        'lblCultureName
        '
        Me.lblCultureName.AutoSize = True
        Me.lblCultureName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCultureName.Location = New System.Drawing.Point(18, 20)
        Me.lblCultureName.Name = "lblCultureName"
        Me.lblCultureName.Size = New System.Drawing.Size(38, 13)
        Me.lblCultureName.TabIndex = 0
        Me.lblCultureName.Text = "Label1"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(12, 400)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(137, 23)
        Me.cmdNew.TabIndex = 37
        Me.cmdNew.Text = "&Novi unos"
        Me.cmdNew.Visible = False
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 429)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.tabOptions)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOptions"
        CType(Me.tabOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOptions.ResumeLayout(False)
        Me.tabGeneralno.ResumeLayout(False)
        CType(Me.txtInactive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStatusList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPopUp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPassPol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLanguage.ResumeLayout(False)
        Me.groupLang.ResumeLayout(False)
        Me.groupMonth.ResumeLayout(False)
        Me.groupDays.ResumeLayout(False)
        Me.groupCurrency.ResumeLayout(False)
        Me.groupCurrency.PerformLayout()
        Me.groupRegion.ResumeLayout(False)
        Me.groupRegion.PerformLayout()
        Me.groupCulture.ResumeLayout(False)
        Me.groupCulture.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabOptions As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabGeneralno As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLanguage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents groupCurrency As System.Windows.Forms.GroupBox
    Friend WithEvents lblFullDate As System.Windows.Forms.Label
    Friend WithEvents lblFormatedDate As System.Windows.Forms.Label
    Friend WithEvents lblFormatedNum As System.Windows.Forms.Label
    Friend WithEvents groupRegion As System.Windows.Forms.GroupBox
    Friend WithEvents lblRegionEng As System.Windows.Forms.Label
    Friend WithEvents lblRegionCurr As System.Windows.Forms.Label
    Friend WithEvents lblRegionCurrEng As System.Windows.Forms.Label
    Friend WithEvents groupCulture As System.Windows.Forms.GroupBox
    Friend WithEvents lblCultureLangWin As System.Windows.Forms.Label
    Friend WithEvents lblCultureLang As System.Windows.Forms.Label
    Friend WithEvents lblCultureNameNeut As System.Windows.Forms.Label
    Friend WithEvents lblCultureNameEng As System.Windows.Forms.Label
    Friend WithEvents lblCultureNameNative As System.Windows.Forms.Label
    Friend WithEvents lblCultureName As System.Windows.Forms.Label
    Friend WithEvents groupMonth As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents groupDays As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents groupLang As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblPassPolicy As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbPassPol As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkPopUp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblsetup1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkStatusList As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents lblSkin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInactive As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblInactivePeriod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
End Class
