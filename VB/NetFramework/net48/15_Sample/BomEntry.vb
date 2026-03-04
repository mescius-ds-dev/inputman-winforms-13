Imports GrapeCity.Win.Editors
Imports GrapeCity.Win.Editors.Fields
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace _15_Sample

    Public Class BomEntry
        Inherits InputManWin13_Demo.DemoBase

        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub

        Private Sub InitializeForm()
            '
            ' 商品情報 - コード
            '
            gcCharMask1.ContentAlignment = ContentAlignment.MiddleLeft
            gcCharMask1.ExitOnLastChar = True
            gcCharMask1.Format = "A9"

            ' キャラクタボックスの設定
            Dim charBoxBorder1 As New CharBoxBorder()
            Dim charBoxBorder2 As New CharBoxBorder()
            Dim charBoxBorder3 As New CharBoxBorder()
            Dim charBoxBorder4 As New CharBoxBorder()
            Dim charBoxBorder5 As New CharBoxBorder()
            Dim charBoxBorder6 As New CharBoxBorder()
            Dim charBoxBorder7 As New CharBoxBorder()
            Dim charBoxBorder8 As New CharBoxBorder()
            Dim charBoxBorder9 As New CharBoxBorder()
            gcCharMask1.CharBoxes.AddRange(New CharBox() {
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder1, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder2, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder3, Nothing, ContentAlignment.MiddleCenter),
                New LiteralBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder4, Nothing, ContentAlignment.MiddleCenter, "-"),
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder5, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder6, Nothing, ContentAlignment.MiddleCenter),
                New LiteralBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder7, Nothing, ContentAlignment.MiddleCenter, "-"),
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder8, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(20, 25), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder9, Nothing, ContentAlignment.MiddleCenter)
            })

            ' ショートカットキーの設定
            Dim sc1 As New ShortcutCollection()
            sc1.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcCharMask1, sc1)

            ' バルーンチップのスタイル
            Dim balloonTipInformation1 As New BalloonTipInformation()
            balloonTipInformation1.BalloonTipStyle = BalloonTipStyle.Windows
            balloonTipInformation1.TextFont = New Font("メイリオ", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))

            ' バルーンチップの設定
            Dim gcBalloonTipNotify1 As New GcBalloonTipNotify()
            gcBalloonTipNotify1.BalloonTipInformation = balloonTipInformation1
            gcBalloonTipNotify1.UseFading = True
            gcCommonValidator1.GetValidateActions(gcCharMask1).AddRange(New ValidateAction() {gcBalloonTipNotify1})

            ' 検証の設定
            Dim textLength1 As New TextLength()
            textLength1.InvalidMessage = "ハイフンを除いて5桁以上で入力してください。"
            textLength1.MinimumLength = 6
            textLength1.NullIsValid = False
            gcCommonValidator1.GetValidateItems(gcCharMask1).AddRange(New Object() {textLength1})


            '
            ' 商品情報 - 名称
            '
            gcTextBox1.PlaceHolder.Enable = True
            gcTextBox1.PlaceHolder.NormalStyle.ContentAlignment = ContentAlignment.MiddleLeft
            gcTextBox1.PlaceHolder.Text = "例）ボディ、フレーム（必須）"

            ' ショートカットキーの設定
            Dim sc2 As New ShortcutCollection()
            sc2.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcTextBox1, sc2)

            ' バルーンチップのスタイル
            Dim balloonTipInformation2 As New BalloonTipInformation()
            balloonTipInformation2.BalloonTipStyle = BalloonTipStyle.Windows
            balloonTipInformation2.TextFont = New Font("メイリオ", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))

            ' バルーンチップの設定
            Dim gcBalloonTipNotify2 As New GcBalloonTipNotify()
            gcBalloonTipNotify2.BalloonTipInformation = balloonTipInformation2
            gcBalloonTipNotify2.UseFading = True
            gcCommonValidator1.GetValidateActions(gcTextBox1).AddRange(New ValidateAction() {gcBalloonTipNotify2})

            ' 検証の設定
            Dim emptyText1 As New EmptyText()
            emptyText1.InvalidMessage = "［名称］の入力は省略できません。"
            gcCommonValidator1.GetValidateItems(gcTextBox1).AddRange(New Object() {emptyText1})


            ' 
            ' 商品情報 - 区分
            ' 
            gcComboBox1.PlaceHolder.Enable = True
            gcComboBox1.PlaceHolder.NormalStyle.ContentAlignment = ContentAlignment.MiddleLeft
            gcComboBox1.PlaceHolder.Text = "例）パーツ、プロダクツ（必須）"

            ' コンボコントロールのアイテムの設定
            gcComboBox1.ListColumns.AddRange(New ListColumn() {New ListColumn("名称"), New ListColumn("コード")})
            gcComboBox1.Items.AddRange(New ListItem() {
                New ListItem(New SubItem() {New SubItem("パーツ"), New SubItem("01")}),
                New ListItem(New SubItem() {New SubItem("プロダクト"), New SubItem("02")})
            })

            ' ショートカットキーの設定
            Dim sc3 As New ShortcutCollection()
            sc3.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcComboBox1, sc3)

            ' バルーンチップのスタイル
            Dim balloonTipInformation3 As New BalloonTipInformation()
            balloonTipInformation3.BalloonTipStyle = BalloonTipStyle.Windows
            balloonTipInformation3.TextFont = New Font("メイリオ", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))

            ' バルーンチップの設定
            Dim gcBalloonTipNotify3 As New GcBalloonTipNotify()
            gcBalloonTipNotify3.BalloonTipInformation = balloonTipInformation3
            gcBalloonTipNotify3.UseFading = True
            gcCommonValidator1.GetValidateActions(gcComboBox1).AddRange(New ValidateAction() {gcBalloonTipNotify3})

            ' 検証の設定
            Dim emptyText2 As New EmptyText()
            emptyText2.InvalidMessage = "［区分］の入力は省略できません。"
            gcCommonValidator1.GetValidateItems(gcComboBox1).AddRange(New Object() {emptyText2})


            ' 
            ' 商品情報 - 発注数
            ' 
            gcNumber1.MinValue = 1
            gcNumber1.MaxValue = 48
            gcNumber1.Fields.SignSuffix.PositivePattern = "円"
            gcNumber1.PlaceHolder.Enable = True
            gcNumber1.PlaceHolder.NormalStyle.ContentAlignment = ContentAlignment.MiddleLeft
            gcNumber1.PlaceHolder.Text = "発注数（1 ～ 48）（必須）"

            ' サイドボタンの設定
            Dim dropDownButton1 As New DropDownButton()
            gcNumber1.SideButtons.AddRange(New SideButtonBase() {dropDownButton1})

            ' スライダーの設定
            gcNumber1.DropDown.DropDownType = NumberDropDownType.Slider
            gcNumber1.DropDownSlider.Marks = New Decimal() {1, 2, 8, 24, 48}
            gcNumber1.DropDownSlider.ValueChangeMode = SliderValueChangeMode.ThumbMove

            ' ショートカットキーの設定
            Dim sc4 As New ShortcutCollection()
            sc4.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcNumber1, sc4)

            ' バルーンチップのスタイル
            Dim balloonTipInformation4 As New BalloonTipInformation()
            balloonTipInformation4.BalloonTipStyle = BalloonTipStyle.Windows
            balloonTipInformation4.TextFont = New Font("メイリオ", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))

            ' バルーンチップの設定
            Dim gcBalloonTipNotify4 As New GcBalloonTipNotify()
            gcBalloonTipNotify4.BalloonTipInformation = balloonTipInformation4
            gcBalloonTipNotify4.UseFading = True
            gcCommonValidator1.GetValidateActions(gcNumber1).AddRange(New ValidateAction() {gcBalloonTipNotify4})

            ' 検証の設定
            Dim emptyText3 As New EmptyText()
            emptyText3.InvalidMessage = "［発注数］の入力は省略できません。"
            gcCommonValidator1.GetValidateItems(gcNumber1).AddRange(New Object() {emptyText3})

            ' 初期値
            gcNumber1.Value = Nothing


            ' 
            ' 商品情報 - 単価
            ' 
            gcNumber2.MinValue = 0
            gcNumber2.MaxValue = 50000
            gcNumber2.Fields.SignSuffix.PositivePattern = "個"
            gcNumber2.PlaceHolder.Enable = True
            gcNumber2.PlaceHolder.NormalStyle.ContentAlignment = ContentAlignment.MiddleLeft
            gcNumber2.PlaceHolder.Text = "単価（1 ～ 50000）（必須）"

            ' サイドボタンの設定
            Dim spinButton1 As New SpinButton()
            gcNumber2.SideButtons.AddRange(New SideButtonBase() {spinButton1})

            ' ショートカットキーの設定
            Dim sc5 As New ShortcutCollection()
            sc5.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcNumber2, sc5)

            ' バルーンチップのスタイル
            Dim balloonTipInformation5 As New BalloonTipInformation()
            balloonTipInformation5.BalloonTipStyle = BalloonTipStyle.Windows
            balloonTipInformation5.TextFont = New Font("メイリオ", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))

            ' バルーンチップの設定
            Dim gcBalloonTipNotify5 As New GcBalloonTipNotify()
            gcBalloonTipNotify5.BalloonTipInformation = balloonTipInformation4
            gcBalloonTipNotify5.UseFading = True
            gcCommonValidator1.GetValidateActions(gcNumber2).AddRange(New ValidateAction() {gcBalloonTipNotify5})

            ' 検証の設定
            Dim emptyText4 As New EmptyText()
            emptyText4.InvalidMessage = "［単価］の入力は省略できません。"
            gcCommonValidator1.GetValidateItems(gcNumber2).AddRange(New Object() {emptyText4})

            ' 初期値
            gcNumber2.Value = Nothing


            ' 
            ' サプライヤ - 名称
            ' 
            gcTextBox2.PlaceHolder.Enable = True
            gcTextBox2.PlaceHolder.NormalStyle.ContentAlignment = ContentAlignment.MiddleLeft
            gcTextBox2.PlaceHolder.Text = "名称"

            ' ショートカットキーの設定
            Dim sc6 As New ShortcutCollection()
            sc6.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcTextBox2, sc6)


            ' 
            ' サプライヤ - コード
            ' 
            gcCharMask2.ContentAlignment = ContentAlignment.MiddleLeft
            gcCharMask2.ExitOnLastChar = True
            gcCharMask2.Format = "A9"

            ' キャラクタボックスの設定
            Dim charBoxBorder10 As New CharBoxBorder()
            Dim charBoxBorder11 As New CharBoxBorder()
            Dim charBoxBorder12 As New CharBoxBorder()
            Dim charBoxBorder13 As New CharBoxBorder()
            gcCharMask2.CharBoxes.AddRange(New CharBox() {
                New InputBox(False, New Size(25, 30), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder10, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(25, 30), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder11, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(25, 30), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder12, Nothing, ContentAlignment.MiddleCenter),
                New InputBox(False, New Size(25, 30), Color.Transparent, Color.Empty, CharBoxStyle.Normal, New Padding(0), New Padding(1), charBoxBorder13, Nothing, ContentAlignment.MiddleCenter)
            })

            ' ショートカットキーの設定
            Dim sc7 As New ShortcutCollection()
            sc7.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcCharMask2, sc7)


            ' 
            ' 発注日
            ' 

            ' 表示書式
            Dim dateEraDisplayField1 As New DateEraDisplayField()
            Dim dateEraYearDisplayField1 As New DateEraYearDisplayField()
            dateEraYearDisplayField1.ShowTraditionalFirstYear = True
            Dim dateLiteralDisplayField1 As New DateLiteralDisplayField()
            dateLiteralDisplayField1.Text = "年"
            Dim dateMonthDisplayField1 As New DateMonthDisplayField()
            dateMonthDisplayField1.ShowLeadingZero = True
            Dim dateLiteralDisplayField2 As New DateLiteralDisplayField()
            dateLiteralDisplayField2.Text = "月"
            Dim dateDayDisplayField1 As New DateDayDisplayField()
            dateDayDisplayField1.ShowLeadingZero = True
            Dim dateLiteralDisplayField3 As New DateLiteralDisplayField()
            dateLiteralDisplayField3.Text = "日"
            gcDate1.DisplayFields.AddRange(New DateDisplayField() {
                dateEraDisplayField1,
                dateEraYearDisplayField1,
                dateLiteralDisplayField1,
                dateMonthDisplayField1,
                dateLiteralDisplayField2,
                dateDayDisplayField1,
                dateLiteralDisplayField3
            })

            ' 入力書式
            Dim dateYearField1 As New DateYearField()
            Dim dateLiteralField1 As New DateLiteralField()
            dateLiteralField1.Text = "/"
            Dim dateMonthField1 As New DateMonthField()
            Dim dateLiteralField2 As New DateLiteralField()
            dateLiteralField2.Text = "/"
            Dim dateDayField1 As New DateDayField()
            gcDate1.Fields.AddRange(New DateField() {
                dateYearField1,
                dateLiteralField1,
                dateMonthField1,
                dateLiteralField2,
                dateDayField1
            })

            gcDate1.ExitOnLastChar = True
            gcDate1.PlaceHolder.Enable = True
            gcDate1.PlaceHolder.Text = "発注日"

            ' ショートカットキーの設定
            Dim sc8 As New ShortcutCollection()
            sc8.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcDate1, sc8)

            Dim dropDownButton2 As New DropDownButton()
            gcDate1.SideButtons.AddRange(New SideButtonBase() {dropDownButton2})

            ' 初期値
            gcDate1.Value = Nothing

            ' 
            ' 出荷日
            ' 

            ' 表示書式
            Dim dateEraDisplayField2 As New DateEraDisplayField()
            Dim dateEraYearDisplayField2 As New DateEraYearDisplayField()
            dateEraYearDisplayField2.ShowTraditionalFirstYear = True
            Dim dateLiteralDisplayField4 As New DateLiteralDisplayField()
            dateLiteralDisplayField4.Text = "年"
            Dim dateMonthDisplayField2 As New DateMonthDisplayField()
            dateMonthDisplayField2.ShowLeadingZero = True
            Dim dateLiteralDisplayField5 As New DateLiteralDisplayField()
            dateLiteralDisplayField5.Text = "月"
            Dim dateDayDisplayField2 As New DateDayDisplayField()
            dateDayDisplayField2.ShowLeadingZero = True
            Dim dateLiteralDisplayField6 As New DateLiteralDisplayField()
            dateLiteralDisplayField6.Text = "日"
            gcDate2.DisplayFields.AddRange(New DateDisplayField() {
                dateEraDisplayField2,
                dateEraYearDisplayField2,
                dateLiteralDisplayField4,
                dateMonthDisplayField2,
                dateLiteralDisplayField5,
                dateDayDisplayField2,
                dateLiteralDisplayField6
            })

            ' 入力書式
            Dim dateYearField2 As New DateYearField()
            Dim dateLiteralField3 As New DateLiteralField()
            dateLiteralField3.Text = "/"
            Dim dateMonthField2 As New DateMonthField()
            Dim dateLiteralField4 As New DateLiteralField()
            dateLiteralField4.Text = "/"
            Dim dateDayField2 As New DateDayField()
            gcDate2.Fields.AddRange(New DateField() {
                dateYearField2,
                dateLiteralField3,
                dateMonthField2,
                dateLiteralField4,
                dateDayField2
            })

            gcDate2.ExitOnLastChar = True
            gcDate2.PlaceHolder.Enable = True
            gcDate2.PlaceHolder.NormalStyle.ContentAlignment = ContentAlignment.MiddleLeft
            gcDate2.PlaceHolder.Text = "出荷日"

            ' ショートカットキーの設定
            Dim sc9 As New ShortcutCollection()
            sc9.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcDate2, sc9)

            Dim dropDownButton3 As New DropDownButton()
            gcDate2.SideButtons.AddRange(New SideButtonBase() {dropDownButton3})

            ' 初期値
            gcDate2.Value = Nothing


            ' 
            ' 備考
            ' 
            gcTextBox3.GridLine = New Line(LineStyle.Dotted, SystemColors.ControlDark)
            gcTextBox3.Multiline = True

            ' ショートカットキーの設定
            Dim sc10 As New ShortcutCollection()
            sc10.Add(Keys.Return, gcShortcut1, "NextControl")
            gcShortcut1.SetShortcuts(gcTextBox3, sc10)
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
            ' エラーを保持しているコントロールのリストを取得
            Dim invalidControlList1 As List(Of Control) = gcCommonValidator1.GetInvalidControls()

            If invalidControlList1.Contains(gcCharMask1) Then
                MessageBox.Show("［商品情報］ - ［コード］はハイフンを除いて5桁以上で入力してください。", "部品入力／編集")
                gcCharMask1.Select()
                Return
            End If

            If invalidControlList1.Contains(gcTextBox1) Then
                MessageBox.Show("［商品情報］ - ［名称］の入力は省略できません。", "部品入力／編集")
                gcTextBox1.Select()
                Return
            End If

            If invalidControlList1.Contains(gcComboBox1) Then
                MessageBox.Show("［商品情報］ - ［区分］の入力は省略できません。", "部品入力／編集")
                gcComboBox1.Select()
                Return
            End If

            If invalidControlList1.Contains(gcNumber1) Then
                MessageBox.Show("［商品情報］ - ［発注数］の入力は省略できません。", "部品入力／編集")
                gcNumber1.Select()
                Return
            End If

            If invalidControlList1.Contains(gcNumber2) Then
                MessageBox.Show("［商品情報］ - ［単価］の入力は省略できません。", "部品入力／編集")
                gcNumber2.Select()
                Return
            End If

            MessageBox.Show("登録しました。", "部品入力／編集", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' コントロールの値をクリア
            gcCharMask1.Clear()
            gcTextBox1.Clear()
            gcComboBox1.Clear()
            gcNumber1.Clear()
            gcNumber2.Clear()
            gcTextBox2.Clear()
            gcCharMask2.Clear()
            gcDate1.Clear()
            gcDate2.Clear()
            gcTextBox3.Clear()
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
            If MessageBox.Show("キャンセルしますか？", "部品入力／編集", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Me.Close()
            End If
        End Sub
    End Class
End Namespace
