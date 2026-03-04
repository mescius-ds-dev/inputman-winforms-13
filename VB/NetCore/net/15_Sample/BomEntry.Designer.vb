Namespace _15_Sample
    Partial Class BomEntry

        'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
            gcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(components)
            gcAddress1 = New GrapeCity.Win.Editors.GcAddress()
            gcIme1 = New GrapeCity.Win.Editors.GcIme()
            gcDateTimeValidator1 = New GrapeCity.Win.Editors.GcDateTimeValidator()
            gcDateValidator1 = New GrapeCity.Win.Editors.GcDateValidator()
            gcTimeValidator1 = New GrapeCity.Win.Editors.GcTimeValidator()
            gcTimeSpanValidator1 = New GrapeCity.Win.Editors.GcTimeSpanValidator()
            gcNumberValidator1 = New GrapeCity.Win.Editors.GcNumberValidator()
            gcCommonValidator1 = New GrapeCity.Win.Editors.GcCommonValidator()
            gcFieldStyler1 = New GrapeCity.Win.Editors.GcFieldStyler(components)
            gcSoftKeyboard1 = New GrapeCity.Win.Editors.GcSoftKeyboard(components)
            gcCustomValidator1 = New GrapeCity.Win.Editors.GcCustomValidator()
            gcCommonValidator2 = New GrapeCity.Win.Editors.GcCommonValidator()
            label11 = New System.Windows.Forms.Label()
            gcDate1 = New GrapeCity.Win.Editors.GcDate(components)
            label10 = New System.Windows.Forms.Label()
            dropDownButton5 = New GrapeCity.Win.Editors.DropDownButton()
            gcTextBox3 = New GrapeCity.Win.Editors.GcTextBox(components)
            gcDate2 = New GrapeCity.Win.Editors.GcDate(components)
            groupBox1 = New System.Windows.Forms.GroupBox()
            gcNumber2 = New GrapeCity.Win.Editors.GcNumber(components)
            gcNumber1 = New GrapeCity.Win.Editors.GcNumber(components)
            gcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(components)
            gcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(components)
            gcCharMask1 = New GrapeCity.Win.Editors.GcCharMask(components)
            label8 = New System.Windows.Forms.Label()
            Label2 = New System.Windows.Forms.Label()
            Label5 = New System.Windows.Forms.Label()
            Label4 = New System.Windows.Forms.Label()
            Label3 = New System.Windows.Forms.Label()
            gcShortcut2 = New GrapeCity.Win.Editors.GcShortcut(components)
            gcCharMask2 = New GrapeCity.Win.Editors.GcCharMask(components)
            gcTextBox2 = New GrapeCity.Win.Editors.GcTextBox(components)
            label6 = New System.Windows.Forms.Label()
            label7 = New System.Windows.Forms.Label()
            label9 = New System.Windows.Forms.Label()
            groupBox2 = New System.Windows.Forms.GroupBox()
            Button2 = New System.Windows.Forms.Button()
            Button1 = New System.Windows.Forms.Button()
            dropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
            label12 = New System.Windows.Forms.Label()
            panel1.SuspendLayout()
            CType(gcDate1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcTextBox3, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcDate2, ComponentModel.ISupportInitialize).BeginInit()
            groupBox1.SuspendLayout()
            CType(gcNumber2, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcNumber1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcComboBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcTextBox1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcCharMask1, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcCharMask2, ComponentModel.ISupportInitialize).BeginInit()
            CType(gcTextBox2, ComponentModel.ISupportInitialize).BeginInit()
            groupBox2.SuspendLayout()
            SuspendLayout()
            ' 
            ' panel1
            ' 
            panel1.Controls.Add(label11)
            panel1.Controls.Add(gcDate1)
            panel1.Controls.Add(label10)
            panel1.Controls.Add(gcTextBox3)
            panel1.Controls.Add(gcDate2)
            panel1.Controls.Add(groupBox1)
            panel1.Controls.Add(label9)
            panel1.Controls.Add(groupBox2)
            panel1.Controls.Add(Button2)
            panel1.Controls.Add(Button1)
            panel1.Controls.Add(label12)
            panel1.Location = New Drawing.Point(20, 102)
            panel1.Size = New Drawing.Size(686, 415)
            panel1.TabIndex = 3
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Location = New Drawing.Point(315, 255)
            label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(56, 18)
            label11.TabIndex = 29
            label11.Text = "出荷日："
            ' 
            ' gcDate1
            ' 
            gcDate1.Location = New Drawing.Point(378, 195)
            gcDate1.Name = "gcDate1"
            gcDate1.Size = New Drawing.Size(200, 40)
            gcDate1.TabIndex = 28
            gcDate1.Value = New Date(2025, 1, 27, 0, 0, 0, 0)
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Location = New Drawing.Point(315, 205)
            label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(56, 18)
            label10.TabIndex = 27
            label10.Text = "発注日："
            ' 
            ' dropDownButton5
            ' 
            dropDownButton5.Name = "dropDownButton5"
            ' 
            ' gcTextBox3
            ' 
            gcTextBox3.Location = New Drawing.Point(378, 295)
            gcTextBox3.Name = "gcTextBox3"
            gcTextBox3.Size = New Drawing.Size(200, 40)
            gcTextBox3.TabIndex = 32
            ' 
            ' gcDate2
            ' 
            gcDate2.Location = New Drawing.Point(378, 245)
            gcDate2.Name = "gcDate2"
            gcDate2.Size = New Drawing.Size(200, 40)
            gcDate2.TabIndex = 30
            gcDate2.Value = New Date(2025, 1, 27, 0, 0, 0, 0)
            ' 
            ' groupBox1
            ' 
            groupBox1.Controls.Add(gcNumber2)
            groupBox1.Controls.Add(gcNumber1)
            groupBox1.Controls.Add(gcComboBox1)
            groupBox1.Controls.Add(gcTextBox1)
            groupBox1.Controls.Add(gcCharMask1)
            groupBox1.Controls.Add(label8)
            groupBox1.Controls.Add(Label2)
            groupBox1.Controls.Add(Label5)
            groupBox1.Controls.Add(Label4)
            groupBox1.Controls.Add(Label3)
            groupBox1.Location = New Drawing.Point(12, 75)
            groupBox1.Name = "groupBox1"
            groupBox1.Size = New Drawing.Size(280, 269)
            groupBox1.TabIndex = 24
            groupBox1.TabStop = False
            groupBox1.Text = "商品情報"
            ' 
            ' gcNumber2
            ' 
            gcNumber2.Location = New Drawing.Point(69, 220)
            gcNumber2.Name = "gcNumber2"
            gcNumber2.Size = New Drawing.Size(200, 40)
            gcNumber2.TabIndex = 11
            ' 
            ' gcNumber1
            ' 
            gcNumber1.Location = New Drawing.Point(69, 170)
            gcNumber1.Name = "gcNumber1"
            gcNumber1.Size = New Drawing.Size(200, 40)
            gcNumber1.TabIndex = 9
            ' 
            ' gcComboBox1
            ' 
            gcComboBox1.ListHeaderPane.Height = 25
            gcComboBox1.Location = New Drawing.Point(69, 120)
            gcComboBox1.Name = "gcComboBox1"
            gcComboBox1.Size = New Drawing.Size(200, 40)
            gcComboBox1.TabIndex = 7
            ' 
            ' gcTextBox1
            ' 
            gcTextBox1.Location = New Drawing.Point(69, 70)
            gcTextBox1.Name = "gcTextBox1"
            gcTextBox1.Size = New Drawing.Size(200, 40)
            gcTextBox1.TabIndex = 5
            ' 
            ' gcCharMask1
            ' 
            gcCharMask1.Location = New Drawing.Point(69, 20)
            gcCharMask1.Name = "gcCharMask1"
            gcCharMask1.Size = New Drawing.Size(200, 40)
            gcCharMask1.TabIndex = 3
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New Drawing.Point(6, 30)
            label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(56, 18)
            label8.TabIndex = 2
            label8.Text = "コード："
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New Drawing.Point(6, 80)
            Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Label2.Name = "Label2"
            Label2.Size = New Drawing.Size(44, 18)
            Label2.TabIndex = 4
            Label2.Text = "名称："
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Location = New Drawing.Point(6, 130)
            Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Label5.Name = "Label5"
            Label5.Size = New Drawing.Size(44, 18)
            Label5.TabIndex = 6
            Label5.Text = "区分："
            ' 
            ' Label4
            ' 
            Label4.AutoSize = True
            Label4.Location = New Drawing.Point(6, 230)
            Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Label4.Name = "Label4"
            Label4.Size = New Drawing.Size(44, 18)
            Label4.TabIndex = 10
            Label4.Text = "単価："
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New Drawing.Point(6, 180)
            Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Label3.Name = "Label3"
            Label3.Size = New Drawing.Size(56, 18)
            Label3.TabIndex = 8
            Label3.Text = "発注数："
            ' 
            ' gcCharMask2
            ' 
            gcCharMask2.Location = New Drawing.Point(70, 70)
            gcCharMask2.Name = "gcCharMask2"
            gcCharMask2.Size = New Drawing.Size(200, 40)
            gcCharMask2.TabIndex = 15
            ' 
            ' gcTextBox2
            ' 
            gcTextBox2.Location = New Drawing.Point(70, 20)
            gcTextBox2.Name = "gcTextBox2"
            gcTextBox2.Size = New Drawing.Size(200, 40)
            gcTextBox2.TabIndex = 13
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Location = New Drawing.Point(7, 30)
            label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(44, 18)
            label6.TabIndex = 12
            label6.Text = "名称："
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Location = New Drawing.Point(7, 80)
            label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(56, 18)
            label7.TabIndex = 14
            label7.Text = "コード："
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Location = New Drawing.Point(315, 305)
            label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(44, 18)
            label9.TabIndex = 31
            label9.Text = "備考："
            ' 
            ' groupBox2
            ' 
            groupBox2.Controls.Add(gcCharMask2)
            groupBox2.Controls.Add(gcTextBox2)
            groupBox2.Controls.Add(label6)
            groupBox2.Controls.Add(label7)
            groupBox2.Location = New Drawing.Point(308, 75)
            groupBox2.Name = "groupBox2"
            groupBox2.Size = New Drawing.Size(280, 115)
            groupBox2.TabIndex = 26
            groupBox2.TabStop = False
            groupBox2.Text = "サプライヤ"
            ' 
            ' Button2
            ' 
            Button2.AutoSize = True
            Button2.Location = New Drawing.Point(293, 356)
            Button2.Name = "Button2"
            Button2.Size = New Drawing.Size(106, 33)
            Button2.TabIndex = 34
            Button2.Text = "キャンセル"
            Button2.UseVisualStyleBackColor = True
            ' 
            ' Button1
            ' 
            Button1.AutoSize = True
            Button1.Location = New Drawing.Point(181, 356)
            Button1.Name = "Button1"
            Button1.Size = New Drawing.Size(106, 33)
            Button1.TabIndex = 33
            Button1.Text = "新規登録"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' dropDownButton1
            ' 
            dropDownButton1.Name = "dropDownButton1"
            ' 
            ' label12
            ' 
            label12.BackColor = Drawing.Color.DeepSkyBlue
            label12.Dock = System.Windows.Forms.DockStyle.Top
            label12.Font = New Drawing.Font("メイリオ", 14.25F)
            label12.Location = New Drawing.Point(0, 0)
            label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(686, 35)
            label12.TabIndex = 25
            label12.Text = "部品入力／編集"
            label12.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' BomEntry
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7.0F, 18.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Description = "部品表のアプリケーションに対して新規データの入力と既存データの編集を行う画面を想定しています。"
            Name = "BomEntry"
            Size = New Drawing.Size(724, 523)
            Title = "部品入力／編集"
            panel1.ResumeLayout(False)
            panel1.PerformLayout()
            CType(gcDate1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcTextBox3, ComponentModel.ISupportInitialize).EndInit()
            CType(gcDate2, ComponentModel.ISupportInitialize).EndInit()
            groupBox1.ResumeLayout(False)
            groupBox1.PerformLayout()
            CType(gcNumber2, ComponentModel.ISupportInitialize).EndInit()
            CType(gcNumber1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcComboBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcTextBox1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcCharMask1, ComponentModel.ISupportInitialize).EndInit()
            CType(gcCharMask2, ComponentModel.ISupportInitialize).EndInit()
            CType(gcTextBox2, ComponentModel.ISupportInitialize).EndInit()
            groupBox2.ResumeLayout(False)
            groupBox2.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private WithEvents gcAddress1 As GrapeCity.Win.Editors.GcAddress
        Private WithEvents gcShortcut1 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents gcIme1 As GrapeCity.Win.Editors.GcIme
        Private WithEvents gcDateTimeValidator1 As GrapeCity.Win.Editors.GcDateTimeValidator
        Private WithEvents gcDateValidator1 As GrapeCity.Win.Editors.GcDateValidator
        Private WithEvents gcTimeValidator1 As GrapeCity.Win.Editors.GcTimeValidator
        Private WithEvents gcNumberValidator1 As GrapeCity.Win.Editors.GcNumberValidator
        Private WithEvents gcTimeSpanValidator1 As GrapeCity.Win.Editors.GcTimeSpanValidator
        Private WithEvents gcFieldStyler1 As GrapeCity.Win.Editors.GcFieldStyler
        Private WithEvents gcCommonValidator1 As GrapeCity.Win.Editors.GcCommonValidator
        Private WithEvents gcSoftKeyboard1 As GrapeCity.Win.Editors.GcSoftKeyboard
        Private WithEvents gcCustomValidator1 As GrapeCity.Win.Editors.GcCustomValidator
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents gcDate1 As GrapeCity.Win.Editors.GcDate
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents gcTextBox3 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents gcDate2 As GrapeCity.Win.Editors.GcDate
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents gcNumber2 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents gcNumber1 As GrapeCity.Win.Editors.GcNumber
        Private WithEvents gcComboBox1 As GrapeCity.Win.Editors.GcComboBox
        Private WithEvents gcTextBox1 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents gcCharMask1 As GrapeCity.Win.Editors.GcCharMask
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents Label2 As System.Windows.Forms.Label
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents Label3 As System.Windows.Forms.Label
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents gcCharMask2 As GrapeCity.Win.Editors.GcCharMask
        Private WithEvents gcTextBox2 As GrapeCity.Win.Editors.GcTextBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents Button2 As System.Windows.Forms.Button
        Private WithEvents Button1 As System.Windows.Forms.Button
        Private WithEvents label12 As System.Windows.Forms.Label
        Private WithEvents gcCommonValidator2 As GrapeCity.Win.Editors.GcCommonValidator
        Private WithEvents dropDownButton5 As GrapeCity.Win.Editors.DropDownButton
        Private WithEvents gcShortcut2 As GrapeCity.Win.Editors.GcShortcut
        Private WithEvents dropDownButton1 As GrapeCity.Win.Editors.DropDownButton
    End Class
End Namespace
