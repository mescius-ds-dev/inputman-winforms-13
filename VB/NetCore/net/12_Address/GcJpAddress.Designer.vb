Namespace _12_Address
    Partial Class GcJpAddress
        Inherits InputManWin13_Demo.DemoBase_settings

        'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Windows フォーム デザイナーで必要です。
        Private components As System.ComponentModel.IContainer

        'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
        'Windows フォーム デザイナーを使用して変更できます。  
        'コード エディターを使って変更しないでください。
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim MaskPatternField1 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim MaskLiteralField1 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField2 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            GroupBox1 = New System.Windows.Forms.GroupBox()
            GcTextBoxOther = New GrapeCity.Win.Editors.GcTextBox(components)
            Label8 = New System.Windows.Forms.Label()
            GcTextBoxBlock = New GrapeCity.Win.Editors.GcTextBox(components)
            Label7 = New System.Windows.Forms.Label()
            GcTextBoxTown = New GrapeCity.Win.Editors.GcTextBox(components)
            Label6 = New System.Windows.Forms.Label()
            GcTextBoxCity = New GrapeCity.Win.Editors.GcTextBox(components)
            Label5 = New System.Windows.Forms.Label()
            GcTextBoxPref = New GrapeCity.Win.Editors.GcTextBox(components)
            Label4 = New System.Windows.Forms.Label()
            GcTextBoxZipCode = New GrapeCity.Win.Editors.GcTextBox(components)
            Label3 = New System.Windows.Forms.Label()
            GroupBox2 = New System.Windows.Forms.GroupBox()
            GcTextBoxIpAddress = New GrapeCity.Win.Editors.GcTextBox(components)
            Label11 = New System.Windows.Forms.Label()
            GcTextBoxClientSecret = New GrapeCity.Win.Editors.GcTextBox(components)
            Label10 = New System.Windows.Forms.Label()
            GcTextBoxClientId = New GrapeCity.Win.Editors.GcTextBox(components)
            Label9 = New System.Windows.Forms.Label()
            Label2 = New System.Windows.Forms.Label()
            GcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(components)
            GcMaskKey = New GrapeCity.Win.Editors.GcMask(components)
            Label12 = New System.Windows.Forms.Label()
            GcjpAddress1 = New GrapeCity.Win.JPAddress.GcJPAddress()
            Button1 = New System.Windows.Forms.Button()
            CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
            splitContainer1.Panel1.SuspendLayout()
            splitContainer1.Panel2.SuspendLayout()
            splitContainer1.SuspendLayout()
            GroupBox1.SuspendLayout()
            CType(GcTextBoxOther, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxBlock, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxTown, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxCity, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxPref, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxZipCode, ComponentModel.ISupportInitialize).BeginInit()
            GroupBox2.SuspendLayout()
            CType(GcTextBoxIpAddress, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxClientSecret, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcTextBoxClientId, ComponentModel.ISupportInitialize).BeginInit()
            CType(GcMaskKey, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            ' 
            ' splitContainer1.Panel1
            ' 
            splitContainer1.Panel1.Controls.Add(Button1)
            splitContainer1.Panel1.Controls.Add(GcMaskKey)
            splitContainer1.Panel1.Controls.Add(Label2)
            splitContainer1.Panel1.Controls.Add(GroupBox1)
            ' 
            ' splitContainer1.Panel2
            ' 
            splitContainer1.Panel2.Controls.Add(Label12)
            splitContainer1.Panel2.Controls.Add(GroupBox2)
            ' 
            ' GroupBox1
            ' 
            GroupBox1.Controls.Add(GcTextBoxOther)
            GroupBox1.Controls.Add(Label8)
            GroupBox1.Controls.Add(GcTextBoxBlock)
            GroupBox1.Controls.Add(Label7)
            GroupBox1.Controls.Add(GcTextBoxTown)
            GroupBox1.Controls.Add(Label6)
            GroupBox1.Controls.Add(GcTextBoxCity)
            GroupBox1.Controls.Add(Label5)
            GroupBox1.Controls.Add(GcTextBoxPref)
            GroupBox1.Controls.Add(Label4)
            GroupBox1.Controls.Add(GcTextBoxZipCode)
            GroupBox1.Controls.Add(Label3)
            GroupBox1.Location = New System.Drawing.Point(6, 68)
            GroupBox1.Name = "GroupBox1"
            GroupBox1.Size = New System.Drawing.Size(335, 325)
            GroupBox1.TabIndex = 0
            GroupBox1.TabStop = False
            GroupBox1.Text = "住所情報"
            ' 
            ' GcTextBoxOther
            ' 
            GcTextBoxOther.Location = New System.Drawing.Point(8, 290)
            GcTextBoxOther.Name = "GcTextBoxOther"
            GcShortcut1.SetShortcuts(GcTextBoxOther, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxOther}, New String() {"ShortcutClear"}))
            GcTextBoxOther.Size = New System.Drawing.Size(318, 22)
            GcTextBoxOther.TabIndex = 13
            ' 
            ' Label8
            ' 
            Label8.AutoSize = True
            Label8.Location = New System.Drawing.Point(5, 269)
            Label8.Name = "Label8"
            Label8.Size = New System.Drawing.Size(104, 18)
            Label8.TabIndex = 12
            Label8.Text = "建物・部屋番号："
            ' 
            ' GcTextBoxBlock
            ' 
            GcTextBoxBlock.Location = New System.Drawing.Point(8, 241)
            GcTextBoxBlock.Name = "GcTextBoxBlock"
            GcShortcut1.SetShortcuts(GcTextBoxBlock, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxBlock}, New String() {"ShortcutClear"}))
            GcTextBoxBlock.Size = New System.Drawing.Size(318, 22)
            GcTextBoxBlock.TabIndex = 11
            ' 
            ' Label7
            ' 
            Label7.AutoSize = True
            Label7.Location = New System.Drawing.Point(5, 220)
            Label7.Name = "Label7"
            Label7.Size = New System.Drawing.Size(44, 18)
            Label7.TabIndex = 10
            Label7.Text = "番地："
            ' 
            ' GcTextBoxTown
            ' 
            GcTextBoxTown.Location = New System.Drawing.Point(8, 192)
            GcTextBoxTown.Name = "GcTextBoxTown"
            GcShortcut1.SetShortcuts(GcTextBoxTown, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxTown}, New String() {"ShortcutClear"}))
            GcTextBoxTown.Size = New System.Drawing.Size(318, 22)
            GcTextBoxTown.TabIndex = 9
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Location = New System.Drawing.Point(5, 171)
            Label6.Name = "Label6"
            Label6.Size = New System.Drawing.Size(44, 18)
            Label6.TabIndex = 8
            Label6.Text = "町名："
            ' 
            ' GcTextBoxCity
            ' 
            GcTextBoxCity.Location = New System.Drawing.Point(8, 143)
            GcTextBoxCity.Name = "GcTextBoxCity"
            GcShortcut1.SetShortcuts(GcTextBoxCity, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxCity}, New String() {"ShortcutClear"}))
            GcTextBoxCity.Size = New System.Drawing.Size(318, 22)
            GcTextBoxCity.TabIndex = 7
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Location = New System.Drawing.Point(5, 122)
            Label5.Name = "Label5"
            Label5.Size = New System.Drawing.Size(80, 18)
            Label5.TabIndex = 6
            Label5.Text = "市区郡町村："
            ' 
            ' GcTextBoxPref
            ' 
            GcTextBoxPref.Location = New System.Drawing.Point(8, 94)
            GcTextBoxPref.Name = "GcTextBoxPref"
            GcShortcut1.SetShortcuts(GcTextBoxPref, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxPref}, New String() {"ShortcutClear"}))
            GcTextBoxPref.Size = New System.Drawing.Size(318, 22)
            GcTextBoxPref.TabIndex = 5
            ' 
            ' Label4
            ' 
            Label4.AutoSize = True
            Label4.Location = New System.Drawing.Point(5, 73)
            Label4.Name = "Label4"
            Label4.Size = New System.Drawing.Size(68, 18)
            Label4.TabIndex = 4
            Label4.Text = "都道府県："
            ' 
            ' GcTextBoxZipCode
            ' 
            GcTextBoxZipCode.Location = New System.Drawing.Point(8, 45)
            GcTextBoxZipCode.Name = "GcTextBoxZipCode"
            GcShortcut1.SetShortcuts(GcTextBoxZipCode, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxZipCode}, New String() {"ShortcutClear"}))
            GcTextBoxZipCode.Size = New System.Drawing.Size(318, 22)
            GcTextBoxZipCode.TabIndex = 3
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New System.Drawing.Point(5, 22)
            Label3.Name = "Label3"
            Label3.Size = New System.Drawing.Size(68, 18)
            Label3.TabIndex = 2
            Label3.Text = "郵便番号："
            ' 
            ' GroupBox2
            ' 
            GroupBox2.Controls.Add(GcTextBoxIpAddress)
            GroupBox2.Controls.Add(Label11)
            GroupBox2.Controls.Add(GcTextBoxClientSecret)
            GroupBox2.Controls.Add(Label10)
            GroupBox2.Controls.Add(GcTextBoxClientId)
            GroupBox2.Controls.Add(Label9)
            GroupBox2.Location = New System.Drawing.Point(8, 68)
            GroupBox2.Name = "GroupBox2"
            GroupBox2.Size = New System.Drawing.Size(335, 177)
            GroupBox2.TabIndex = 0
            GroupBox2.TabStop = False
            GroupBox2.Text = "API認証情報"
            ' 
            ' GcTextBoxIpAddress
            ' 
            GcTextBoxIpAddress.Location = New System.Drawing.Point(8, 143)
            GcTextBoxIpAddress.Name = "GcTextBoxIpAddress"
            GcShortcut1.SetShortcuts(GcTextBoxIpAddress, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxIpAddress}, New String() {"ShortcutClear"}))
            GcTextBoxIpAddress.Size = New System.Drawing.Size(318, 22)
            GcTextBoxIpAddress.TabIndex = 9
            ' 
            ' Label11
            ' 
            Label11.AutoSize = True
            Label11.Location = New System.Drawing.Point(5, 122)
            Label11.Name = "Label11"
            Label11.Size = New System.Drawing.Size(80, 18)
            Label11.TabIndex = 8
            Label11.Text = "IPアドレス："
            ' 
            ' GcTextBoxClientSecret
            ' 
            GcTextBoxClientSecret.Location = New System.Drawing.Point(8, 94)
            GcTextBoxClientSecret.Name = "GcTextBoxClientSecret"
            GcShortcut1.SetShortcuts(GcTextBoxClientSecret, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxClientSecret}, New String() {"ShortcutClear"}))
            GcTextBoxClientSecret.Size = New System.Drawing.Size(318, 22)
            GcTextBoxClientSecret.TabIndex = 7
            ' 
            ' Label10
            ' 
            Label10.AutoSize = True
            Label10.Location = New System.Drawing.Point(5, 73)
            Label10.Name = "Label10"
            Label10.Size = New System.Drawing.Size(164, 18)
            Label10.TabIndex = 6
            Label10.Text = "クライアントシークレット："
            ' 
            ' GcTextBoxClientId
            ' 
            GcTextBoxClientId.Location = New System.Drawing.Point(8, 45)
            GcTextBoxClientId.Name = "GcTextBoxClientId"
            GcShortcut1.SetShortcuts(GcTextBoxClientId, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {GcTextBoxClientId}, New String() {"ShortcutClear"}))
            GcTextBoxClientId.Size = New System.Drawing.Size(318, 22)
            GcTextBoxClientId.TabIndex = 5
            ' 
            ' Label9
            ' 
            Label9.AutoSize = True
            Label9.Location = New System.Drawing.Point(5, 22)
            Label9.Name = "Label9"
            Label9.Size = New System.Drawing.Size(106, 18)
            Label9.TabIndex = 4
            Label9.Text = "クライアントID："
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New System.Drawing.Point(5, 8)
            Label2.Name = "Label2"
            Label2.Size = New System.Drawing.Size(176, 18)
            Label2.TabIndex = 1
            Label2.Text = "郵便番号／デジタルアドレス："
            ' 
            ' GcMaskKey
            ' 
            MaskPatternField1.MaxLength = 3
            MaskPatternField1.MinLength = 3
            MaskPatternField1.Pattern = "\A\D"
            MaskLiteralField1.Text = "-"
            MaskPatternField2.MaxLength = 4
            MaskPatternField2.MinLength = 4
            MaskPatternField2.Pattern = "\A\D"
            GcMaskKey.Fields.AddRange(New GrapeCity.Win.Editors.Fields.MaskField() {MaskPatternField1, MaskLiteralField1, MaskPatternField2})
            GcMaskKey.Location = New System.Drawing.Point(8, 29)
            GcMaskKey.Name = "GcMaskKey"
            GcShortcut1.SetShortcuts(GcMaskKey, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Enter}, New Object() {GcMaskKey, GcMaskKey}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            GcMaskKey.Size = New System.Drawing.Size(76, 22)
            GcMaskKey.TabIndex = 2
            ' 
            ' Label12
            ' 
            Label12.Location = New System.Drawing.Point(5, 8)
            Label12.Name = "Label12"
            Label12.Size = New System.Drawing.Size(338, 57)
            Label12.TabIndex = 5
            Label12.Text = "1.API認証情報を入力します。" & vbCrLf & "2.郵便番号またはデジタルアドレスを入力します。" & vbCrLf & "3.住所検索をクリックします。"
            ' 
            ' Button1
            ' 
            Button1.Location = New System.Drawing.Point(90, 30)
            Button1.Name = "Button1"
            Button1.Size = New System.Drawing.Size(75, 23)
            Button1.TabIndex = 3
            Button1.Text = "住所検索"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' GcJpAddress
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 18.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Description = _
        "日本郵便株式会社の郵便番号・デジタルアドレスAPIと連携して住所情報を検索できます。" & vbCrLf & _
        "この機能を使用するには、日本郵便の郵便番号・デジタルアドレスAPIサービスに登録し、" & vbCrLf & _
        "API認証情報を取得する必要があります。"
            Name = "GcJpAddress"
            Title = "郵便番号・デジタルアドレスAPIによる住所検索"
            splitContainer1.Panel1.ResumeLayout(False)
            splitContainer1.Panel1.PerformLayout()
            splitContainer1.Panel2.ResumeLayout(False)
            CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
            splitContainer1.ResumeLayout(False)
            GroupBox1.ResumeLayout(False)
            GroupBox1.PerformLayout()
            CType(GcTextBoxOther, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxBlock, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxTown, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxCity, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxPref, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxZipCode, ComponentModel.ISupportInitialize).EndInit()
            GroupBox2.ResumeLayout(False)
            GroupBox2.PerformLayout()
            CType(GcTextBoxIpAddress, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxClientSecret, ComponentModel.ISupportInitialize).EndInit()
            CType(GcTextBoxClientId, ComponentModel.ISupportInitialize).EndInit()
            CType(GcMaskKey, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GcTextBoxOther As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxBlock As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxTown As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxCity As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxPref As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxZipCode As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GcTextBoxIpAddress As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxClientSecret As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents GcTextBoxClientId As GrapeCity.Win.Editors.GcTextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents GcjpAddress1 As GrapeCity.Win.JPAddress.GcJPAddress
        Friend WithEvents GcMaskKey As GrapeCity.Win.Editors.GcMask
        Friend WithEvents Button1 As System.Windows.Forms.Button

    End Class
End Namespace