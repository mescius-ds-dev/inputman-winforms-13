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
            Me.components = New System.ComponentModel.Container()
            Dim MaskPatternField3 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Dim MaskLiteralField2 As GrapeCity.Win.Editors.Fields.MaskLiteralField = New GrapeCity.Win.Editors.Fields.MaskLiteralField()
            Dim MaskPatternField4 As GrapeCity.Win.Editors.Fields.MaskPatternField = New GrapeCity.Win.Editors.Fields.MaskPatternField()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.GcTextBoxTown = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.GcTextBoxZipCode = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.label4 = New System.Windows.Forms.Label()
            Me.GcTextBoxCity = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.GcTextBoxPref = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.label7 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.GcTextBoxClientId = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GcTextBoxIpAddress = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.GcTextBoxClientSecret = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.GcTextBoxOther = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.GcTextBoxBlock = New GrapeCity.Win.Editors.GcTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.GcMaskKey = New GrapeCity.Win.Editors.GcMask(Me.components)
            Me.GcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
            Me.GcJPAddress1 = New GrapeCity.Win.JPAddress.GcJPAddress()
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType(Me.GcTextBoxTown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcTextBoxZipCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcTextBoxCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcTextBoxPref, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.GcTextBoxClientId, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcTextBoxIpAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcTextBoxClientSecret, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.GcTextBoxOther, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcTextBoxBlock, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GcMaskKey, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainer1
            '
            '
            'splitContainer1.Panel1
            '
            Me.splitContainer1.Panel1.Controls.Add(Me.GcMaskKey)
            Me.splitContainer1.Panel1.Controls.Add(Me.Button1)
            Me.splitContainer1.Panel1.Controls.Add(Me.GroupBox2)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            '
            'splitContainer1.Panel2
            '
            Me.splitContainer1.Panel2.Controls.Add(Me.Label10)
            Me.splitContainer1.Panel2.Controls.Add(Me.GroupBox1)
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(5, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(176, 18)
            Me.label2.TabIndex = 1
            Me.label2.Text = "郵便番号／デジタルアドレス："
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(5, 122)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(80, 18)
            Me.label6.TabIndex = 14
            Me.label6.Text = "市区郡町村："
            '
            'GcTextBoxTown
            '
            Me.GcTextBoxTown.AutoSize = True
            Me.GcTextBoxTown.Location = New System.Drawing.Point(8, 192)
            Me.GcTextBoxTown.Name = "GcTextBoxTown"
            Me.GcTextBoxTown.Size = New System.Drawing.Size(318, 22)
            Me.GcTextBoxTown.TabIndex = 17
            '
            'GcTextBoxZipCode
            '
            Me.GcTextBoxZipCode.AutoSize = True
            Me.GcTextBoxZipCode.Location = New System.Drawing.Point(8, 45)
            Me.GcTextBoxZipCode.Name = "GcTextBoxZipCode"
            Me.GcTextBoxZipCode.Size = New System.Drawing.Size(318, 22)
            Me.GcTextBoxZipCode.TabIndex = 11
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(5, 73)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(68, 18)
            Me.label4.TabIndex = 12
            Me.label4.Text = "都道府県："
            '
            'GcTextBoxCity
            '
            Me.GcTextBoxCity.AutoSize = True
            Me.GcTextBoxCity.Location = New System.Drawing.Point(8, 143)
            Me.GcTextBoxCity.Name = "GcTextBoxCity"
            Me.GcTextBoxCity.Size = New System.Drawing.Size(318, 22)
            Me.GcTextBoxCity.TabIndex = 15
            '
            'GcTextBoxPref
            '
            Me.GcTextBoxPref.AutoSize = True
            Me.GcTextBoxPref.Location = New System.Drawing.Point(8, 94)
            Me.GcTextBoxPref.Name = "GcTextBoxPref"
            Me.GcTextBoxPref.Size = New System.Drawing.Size(318, 22)
            Me.GcTextBoxPref.TabIndex = 13
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(5, 171)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(44, 18)
            Me.label7.TabIndex = 16
            Me.label7.Text = "町名："
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(5, 22)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(68, 18)
            Me.label3.TabIndex = 10
            Me.label3.Text = "郵便番号："
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.GcTextBoxClientId)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.GcTextBoxIpAddress)
            Me.GroupBox1.Controls.Add(Me.GcTextBoxClientSecret)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 68)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(335, 177)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "API認証情報"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(5, 122)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(80, 18)
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "IPアドレス："
            '
            'GcTextBoxClientId
            '
            Me.GcTextBoxClientId.AutoSize = True
            Me.GcTextBoxClientId.Location = New System.Drawing.Point(8, 45)
            Me.GcTextBoxClientId.Name = "GcTextBoxClientId"
            Me.GcTextBoxClientId.Size = New System.Drawing.Size(319, 22)
            Me.GcTextBoxClientId.TabIndex = 17
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(5, 73)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(164, 18)
            Me.Label8.TabIndex = 18
            Me.Label8.Text = "クライアントシークレット："
            '
            'GcTextBoxIpAddress
            '
            Me.GcTextBoxIpAddress.AutoSize = True
            Me.GcTextBoxIpAddress.Location = New System.Drawing.Point(8, 143)
            Me.GcTextBoxIpAddress.Name = "GcTextBoxIpAddress"
            Me.GcTextBoxIpAddress.Size = New System.Drawing.Size(319, 22)
            Me.GcTextBoxIpAddress.TabIndex = 21
            '
            'GcTextBoxClientSecret
            '
            Me.GcTextBoxClientSecret.AutoSize = True
            Me.GcTextBoxClientSecret.Location = New System.Drawing.Point(8, 94)
            Me.GcTextBoxClientSecret.Name = "GcTextBoxClientSecret"
            Me.GcTextBoxClientSecret.Size = New System.Drawing.Size(319, 22)
            Me.GcTextBoxClientSecret.TabIndex = 19
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(5, 22)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(106, 18)
            Me.Label9.TabIndex = 16
            Me.Label9.Text = "クライアントID："
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.GcTextBoxOther)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Controls.Add(Me.GcTextBoxBlock)
            Me.GroupBox2.Controls.Add(Me.label3)
            Me.GroupBox2.Controls.Add(Me.label6)
            Me.GroupBox2.Controls.Add(Me.label7)
            Me.GroupBox2.Controls.Add(Me.GcTextBoxTown)
            Me.GroupBox2.Controls.Add(Me.GcTextBoxPref)
            Me.GroupBox2.Controls.Add(Me.GcTextBoxZipCode)
            Me.GroupBox2.Controls.Add(Me.GcTextBoxCity)
            Me.GroupBox2.Controls.Add(Me.label4)
            Me.GroupBox2.Location = New System.Drawing.Point(6, 68)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(335, 325)
            Me.GroupBox2.TabIndex = 18
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "住所情報"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(5, 269)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(104, 18)
            Me.Label12.TabIndex = 20
            Me.Label12.Text = "建物・部屋番号："
            '
            'GcTextBoxOther
            '
            Me.GcTextBoxOther.AutoSize = True
            Me.GcTextBoxOther.Location = New System.Drawing.Point(8, 290)
            Me.GcTextBoxOther.Name = "GcTextBoxOther"
            Me.GcTextBoxOther.Size = New System.Drawing.Size(318, 22)
            Me.GcTextBoxOther.TabIndex = 21
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(5, 220)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(44, 18)
            Me.Label11.TabIndex = 18
            Me.Label11.Text = "番地："
            '
            'GcTextBoxBlock
            '
            Me.GcTextBoxBlock.AutoSize = True
            Me.GcTextBoxBlock.Location = New System.Drawing.Point(8, 241)
            Me.GcTextBoxBlock.Name = "GcTextBoxBlock"
            Me.GcTextBoxBlock.Size = New System.Drawing.Size(318, 22)
            Me.GcTextBoxBlock.TabIndex = 19
            '
            'Label10
            '
            Me.Label10.Location = New System.Drawing.Point(5, 8)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(338, 57)
            Me.Label10.TabIndex = 17
            Me.Label10.Text = "1.API認証情報を入力します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.郵便番号またはデジタルアドレスを入力します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.住所検索をクリックします。"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(90, 30)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 19
            Me.Button1.Text = "住所検索"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'GcMaskKey
            '
            MaskPatternField3.MaxLength = 3
            MaskPatternField3.MinLength = 3
            MaskPatternField3.Pattern = "\A\D"
            MaskLiteralField2.Text = "-"
            MaskPatternField4.MaxLength = 4
            MaskPatternField4.MinLength = 4
            MaskPatternField4.Pattern = "\A\D"
            Me.GcMaskKey.Fields.AddRange(New GrapeCity.Win.Editors.Fields.MaskField() {MaskPatternField3, MaskLiteralField2, MaskPatternField4})
            Me.GcMaskKey.Location = New System.Drawing.Point(8, 29)
            Me.GcMaskKey.Name = "GcMaskKey"
            Me.GcShortcut1.SetShortcuts(Me.GcMaskKey, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.GcMaskKey, Object), CType(Me.GcMaskKey, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
            Me.GcMaskKey.Size = New System.Drawing.Size(76, 22)
            Me.GcMaskKey.TabIndex = 20
            '
            'GcJpAddress
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Description = _
        "日本郵便株式会社の郵便番号・デジタルアドレスAPIと連携して住所情報を検索できます。" & vbCrLf & _
        "この機能を使用するには、日本郵便の郵便番号・デジタルアドレスAPIサービスに登録し、" & vbCrLf & _
        "API認証情報を取得する必要があります。"
            Me.Name = "GcJpAddress"
            Me.Title = "郵便番号・デジタルアドレスAPIによる住所検索"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType(Me.GcTextBoxTown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcTextBoxZipCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcTextBoxCity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcTextBoxPref, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.GcTextBoxClientId, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcTextBoxIpAddress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcTextBoxClientSecret, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.GcTextBoxOther, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcTextBoxBlock, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GcMaskKey, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private WithEvents label2 As Windows.Forms.Label
        Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
        Private WithEvents label3 As Windows.Forms.Label
        Private WithEvents label6 As Windows.Forms.Label
        Private WithEvents label7 As Windows.Forms.Label
        Private WithEvents GcTextBoxTown As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents GcTextBoxPref As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents GcTextBoxZipCode As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents GcTextBoxCity As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label4 As Windows.Forms.Label
        Private WithEvents Label10 As Windows.Forms.Label
        Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
        Private WithEvents Label5 As Windows.Forms.Label
        Private WithEvents GcTextBoxClientId As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents Label8 As Windows.Forms.Label
        Private WithEvents GcTextBoxIpAddress As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents GcTextBoxClientSecret As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents Label9 As Windows.Forms.Label
        Friend WithEvents Button1 As Windows.Forms.Button
        Friend WithEvents GcMaskKey As GrapeCity.Win.Editors.GcMask
        Friend WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Friend WithEvents GcJPAddress1 As GrapeCity.Win.JPAddress.GcJPAddress
        Private WithEvents Label12 As Windows.Forms.Label
        Private WithEvents GcTextBoxOther As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents Label11 As Windows.Forms.Label
        Private WithEvents GcTextBoxBlock As GrapeCity.Win.Editors.GcTextBox
    End Class
End Namespace