using GrapeCity.Win.Editors;
using GrapeCity.Win.Editors.Fields;
using InputManWin13_Demo._02_Format;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace InputManWin13_Demo._15_Sample
{
    public partial class BomEntry : InputManWin13_Demo.DemoBase
    {
        public BomEntry()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            //
            // 商品情報 - コード
            //
            gcCharMask1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcCharMask1.ExitOnLastChar = true;
            gcCharMask1.Format = "A9";

            // キャラクタボックスの設定
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder1 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder2 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder3 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder4 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder5 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder6 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder7 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder8 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder9 = new GrapeCity.Win.Editors.CharBoxBorder();
            gcCharMask1.CharBoxes.AddRange(new GrapeCity.Win.Editors.CharBox[] {
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder1, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder2, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder3, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.LiteralBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder4, null, System.Drawing.ContentAlignment.MiddleCenter, "-"),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder5, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder6, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.LiteralBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder7, null, System.Drawing.ContentAlignment.MiddleCenter, "-"),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder8, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(20, 25), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder9, null, System.Drawing.ContentAlignment.MiddleCenter)
            });

            // ショートカットキーの設定
            ShortcutCollection sc1 = new ShortcutCollection();
            sc1.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcCharMask1, sc1);

            // バルーンチップのスタイル
            GrapeCity.Win.Editors.BalloonTipInformation balloonTipInformation1 = new GrapeCity.Win.Editors.BalloonTipInformation();
            balloonTipInformation1.BalloonTipStyle = GrapeCity.Win.Editors.BalloonTipStyle.Windows;
            balloonTipInformation1.TextFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // バルーンチップの設定
            GrapeCity.Win.Editors.GcBalloonTipNotify gcBalloonTipNotify1 = new GrapeCity.Win.Editors.GcBalloonTipNotify();
            gcBalloonTipNotify1.BalloonTipInformation = balloonTipInformation1;
            gcBalloonTipNotify1.UseFading = true;
            gcCommonValidator1.GetValidateActions(gcCharMask1).AddRange(new GrapeCity.Win.Editors.ValidateAction[] { gcBalloonTipNotify1 });

            // 検証の設定
            GrapeCity.Win.Editors.TextLength textLength1 = new GrapeCity.Win.Editors.TextLength();
            textLength1.InvalidMessage = "ハイフンを除いて5桁以上で入力してください。";
            textLength1.MinimumLength = 6;
            textLength1.NullIsValid = false;
            gcCommonValidator1.GetValidateItems(gcCharMask1).AddRange(new object[] { textLength1 });


            //
            // 商品情報 - 名称
            //
            gcTextBox1.PlaceHolder.Enable = true;
            gcTextBox1.PlaceHolder.NormalStyle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcTextBox1.PlaceHolder.Text = "例）ボディ、フレーム（必須）";

            // ショートカットキーの設定
            ShortcutCollection sc2 = new ShortcutCollection();
            sc2.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcTextBox1, sc2);

            // バルーンチップのスタイル
            GrapeCity.Win.Editors.BalloonTipInformation balloonTipInformation2 = new GrapeCity.Win.Editors.BalloonTipInformation();
            balloonTipInformation2.BalloonTipStyle = GrapeCity.Win.Editors.BalloonTipStyle.Windows;
            balloonTipInformation2.TextFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // バルーンチップの設定
            GrapeCity.Win.Editors.GcBalloonTipNotify gcBalloonTipNotify2 = new GrapeCity.Win.Editors.GcBalloonTipNotify();
            gcBalloonTipNotify2.BalloonTipInformation = balloonTipInformation2;
            gcBalloonTipNotify2.UseFading = true;
            gcCommonValidator1.GetValidateActions(gcTextBox1).AddRange(new GrapeCity.Win.Editors.ValidateAction[] { gcBalloonTipNotify2 });

            // 検証の設定
            GrapeCity.Win.Editors.EmptyText emptyText1 = new GrapeCity.Win.Editors.EmptyText();
            emptyText1.InvalidMessage = "［名称］の入力は省略できません。";
            gcCommonValidator1.GetValidateItems(gcTextBox1).AddRange(new object[] { emptyText1 });


            // 
            // 商品情報 - 区分
            // 
            gcComboBox1.PlaceHolder.Enable = true;
            gcComboBox1.PlaceHolder.NormalStyle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcComboBox1.PlaceHolder.Text = "例）パーツ、プロダクツ（必須）";

            // コンボコントロールのアイテムの設定
            gcComboBox1.ListColumns.AddRange(new ListColumn[] { new ListColumn("名称"), new ListColumn("コード") });
            gcComboBox1.Items.AddRange(new ListItem[] {
                new ListItem(new SubItem[] {new SubItem("パーツ"), new SubItem("01")}),
                new ListItem(new SubItem[] {new SubItem("プロダクト"), new SubItem("02")}),
                });

            // ショートカットキーの設定
            ShortcutCollection sc3 = new ShortcutCollection();
            sc3.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcComboBox1, sc3);

            // バルーンチップのスタイル
            GrapeCity.Win.Editors.BalloonTipInformation balloonTipInformation3 = new GrapeCity.Win.Editors.BalloonTipInformation();
            balloonTipInformation3.BalloonTipStyle = GrapeCity.Win.Editors.BalloonTipStyle.Windows;
            balloonTipInformation3.TextFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // バルーンチップの設定
            GrapeCity.Win.Editors.GcBalloonTipNotify gcBalloonTipNotify3 = new GrapeCity.Win.Editors.GcBalloonTipNotify();
            gcBalloonTipNotify3.BalloonTipInformation = balloonTipInformation3;
            gcBalloonTipNotify3.UseFading = true;
            gcCommonValidator1.GetValidateActions(gcComboBox1).AddRange(new GrapeCity.Win.Editors.ValidateAction[] { gcBalloonTipNotify3 });

            // 検証の設定
            GrapeCity.Win.Editors.EmptyText emptyText2 = new GrapeCity.Win.Editors.EmptyText();
            emptyText2.InvalidMessage = "［区分］の入力は省略できません。";
            gcCommonValidator1.GetValidateItems(gcComboBox1).AddRange(new object[] { emptyText2 });


            // 
            // 商品情報 - 発注数
            // 
            gcNumber1.MinValue = 1;
            gcNumber1.MaxValue = 48;
            gcNumber1.Fields.SignSuffix.PositivePattern = "円";
            gcNumber1.PlaceHolder.Enable = true;
            gcNumber1.PlaceHolder.NormalStyle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcNumber1.PlaceHolder.Text = "発注数（1 ～ 48）（必須）";

            // サイドボタンの設定
            GrapeCity.Win.Editors.DropDownButton dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            gcNumber1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { dropDownButton1 });

            // スライダーの設定
            gcNumber1.DropDown.DropDownType = GrapeCity.Win.Editors.NumberDropDownType.Slider;
            gcNumber1.DropDownSlider.Marks = new decimal[] { 1, 2, 8, 24, 48 };
            gcNumber1.DropDownSlider.ValueChangeMode = GrapeCity.Win.Editors.SliderValueChangeMode.ThumbMove;

            // ショートカットキーの設定
            ShortcutCollection sc4 = new ShortcutCollection();
            sc4.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcNumber1, sc4);

            // バルーンチップのスタイル
            GrapeCity.Win.Editors.BalloonTipInformation balloonTipInformation4 = new GrapeCity.Win.Editors.BalloonTipInformation();
            balloonTipInformation4.BalloonTipStyle = GrapeCity.Win.Editors.BalloonTipStyle.Windows;
            balloonTipInformation4.TextFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // バルーンチップの設定
            GrapeCity.Win.Editors.GcBalloonTipNotify gcBalloonTipNotify4 = new GrapeCity.Win.Editors.GcBalloonTipNotify();
            gcBalloonTipNotify4.BalloonTipInformation = balloonTipInformation4;
            gcBalloonTipNotify4.UseFading = true;
            gcCommonValidator1.GetValidateActions(gcNumber1).AddRange(new GrapeCity.Win.Editors.ValidateAction[] { gcBalloonTipNotify4 });

            // 検証の設定
            GrapeCity.Win.Editors.EmptyText emptyText3 = new GrapeCity.Win.Editors.EmptyText();
            emptyText3.InvalidMessage = "［発注数］の入力は省略できません。";
            gcCommonValidator1.GetValidateItems(gcNumber1).AddRange(new object[] { emptyText3 });

            // 初期値
            gcNumber1.Value = null;


            // 
            // 商品情報 - 単価
            // 
            gcNumber2.MinValue = 0;
            gcNumber2.MaxValue = 50000;
            gcNumber2.Fields.SignSuffix.PositivePattern = "個";
            gcNumber2.PlaceHolder.Enable = true;
            gcNumber2.PlaceHolder.NormalStyle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcNumber2.PlaceHolder.Text = "単価（1 ～ 50000）（必須）";

            // サイドボタンの設定
            GrapeCity.Win.Editors.SpinButton spinButton1 = new GrapeCity.Win.Editors.SpinButton();
            gcNumber2.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { spinButton1 });

            // ショートカットキーの設定
            ShortcutCollection sc5 = new ShortcutCollection();
            sc5.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcNumber2, sc5);

            // バルーンチップのスタイル
            GrapeCity.Win.Editors.BalloonTipInformation balloonTipInformation5 = new GrapeCity.Win.Editors.BalloonTipInformation();
            balloonTipInformation5.BalloonTipStyle = GrapeCity.Win.Editors.BalloonTipStyle.Windows;
            balloonTipInformation5.TextFont = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // バルーンチップの設定
            GrapeCity.Win.Editors.GcBalloonTipNotify gcBalloonTipNotify5 = new GrapeCity.Win.Editors.GcBalloonTipNotify();
            gcBalloonTipNotify5.BalloonTipInformation = balloonTipInformation4;
            gcBalloonTipNotify5.UseFading = true;
            gcCommonValidator1.GetValidateActions(gcNumber2).AddRange(new GrapeCity.Win.Editors.ValidateAction[] { gcBalloonTipNotify5 });

            // 検証の設定
            GrapeCity.Win.Editors.EmptyText emptyText4 = new GrapeCity.Win.Editors.EmptyText();
            emptyText4.InvalidMessage = "［単価］の入力は省略できません。";
            gcCommonValidator1.GetValidateItems(gcNumber2).AddRange(new object[] { emptyText4 });

            // 初期値
            gcNumber2.Value = null;


            // 
            // サプライヤ - 名称
            // 
            gcTextBox2.PlaceHolder.Enable = true;
            gcTextBox2.PlaceHolder.NormalStyle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcTextBox2.PlaceHolder.Text = "名称";

            // ショートカットキーの設定
            ShortcutCollection sc6 = new ShortcutCollection();
            sc6.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcTextBox2, sc6);


            // 
            // サプライヤ - コード
            // 
            gcCharMask2.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcCharMask2.ExitOnLastChar = true;
            gcCharMask2.Format = "A9";

            // キャラクタボックスの設定
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder10 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder11 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder12 = new GrapeCity.Win.Editors.CharBoxBorder();
            GrapeCity.Win.Editors.CharBoxBorder charBoxBorder13 = new GrapeCity.Win.Editors.CharBoxBorder();
            gcCharMask2.CharBoxes.AddRange(new GrapeCity.Win.Editors.CharBox[] {
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(25, 30), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder10, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(25, 30), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder11, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(25, 30), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder12, null, System.Drawing.ContentAlignment.MiddleCenter),
                new GrapeCity.Win.Editors.InputBox(false, new System.Drawing.Size(25, 30), System.Drawing.Color.Transparent, System.Drawing.Color.Empty, GrapeCity.Win.Editors.CharBoxStyle.Normal, new System.Windows.Forms.Padding(0), new System.Windows.Forms.Padding(1), charBoxBorder13, null, System.Drawing.ContentAlignment.MiddleCenter)
            });

            // ショートカットキーの設定
            ShortcutCollection sc7 = new ShortcutCollection();
            sc7.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcCharMask2, sc7);


            // 
            // 発注日
            // 

            // 表示書式
            GrapeCity.Win.Editors.Fields.DateEraDisplayField dateEraDisplayField1 = new GrapeCity.Win.Editors.Fields.DateEraDisplayField();
            GrapeCity.Win.Editors.Fields.DateEraYearDisplayField dateEraYearDisplayField1 = new GrapeCity.Win.Editors.Fields.DateEraYearDisplayField();
            dateEraYearDisplayField1.ShowTraditionalFirstYear = true;
            GrapeCity.Win.Editors.Fields.DateLiteralDisplayField dateLiteralDisplayField1 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
            dateLiteralDisplayField1.Text = "年";
            GrapeCity.Win.Editors.Fields.DateMonthDisplayField dateMonthDisplayField1 = new GrapeCity.Win.Editors.Fields.DateMonthDisplayField();
            dateMonthDisplayField1.ShowLeadingZero = true;
            GrapeCity.Win.Editors.Fields.DateLiteralDisplayField dateLiteralDisplayField2 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
            dateLiteralDisplayField2.Text = "月";
            GrapeCity.Win.Editors.Fields.DateDayDisplayField dateDayDisplayField1 = new GrapeCity.Win.Editors.Fields.DateDayDisplayField();
            dateDayDisplayField1.ShowLeadingZero = true;
            GrapeCity.Win.Editors.Fields.DateLiteralDisplayField dateLiteralDisplayField3 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
            dateLiteralDisplayField3.Text = "日";
            gcDate1.DisplayFields.AddRange(new GrapeCity.Win.Editors.Fields.DateDisplayField[] {
                dateEraDisplayField1,
                dateEraYearDisplayField1,
                dateLiteralDisplayField1,
                dateMonthDisplayField1,
                dateLiteralDisplayField2,
                dateDayDisplayField1,
                dateLiteralDisplayField3
            });

            // 入力書式
            GrapeCity.Win.Editors.Fields.DateYearField dateYearField1 = new GrapeCity.Win.Editors.Fields.DateYearField();
            GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField1 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
            dateLiteralField1.Text = "/";
            GrapeCity.Win.Editors.Fields.DateMonthField dateMonthField1 = new GrapeCity.Win.Editors.Fields.DateMonthField();
            GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField2 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
            dateLiteralField2.Text = "/";
            GrapeCity.Win.Editors.Fields.DateDayField dateDayField1 = new GrapeCity.Win.Editors.Fields.DateDayField();
            gcDate1.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] {
                dateYearField1,
                dateLiteralField1,
                dateMonthField1,
                dateLiteralField2,
                dateDayField1
            });

            gcDate1.ExitOnLastChar = true;
            gcDate1.PlaceHolder.Enable = true;
            gcDate1.PlaceHolder.Text = "発注日";

            // ショートカットキーの設定
            ShortcutCollection sc8 = new ShortcutCollection();
            sc8.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcDate1, sc8);

            GrapeCity.Win.Editors.DropDownButton dropDownButton2 = new GrapeCity.Win.Editors.DropDownButton();
            gcDate1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { dropDownButton2 });

            // 初期値
            gcDate1.Value = null;

            // 
            // 出荷日
            // 

            // 表示書式
            GrapeCity.Win.Editors.Fields.DateEraDisplayField dateEraDisplayField2 = new GrapeCity.Win.Editors.Fields.DateEraDisplayField();
            GrapeCity.Win.Editors.Fields.DateEraYearDisplayField dateEraYearDisplayField2 = new GrapeCity.Win.Editors.Fields.DateEraYearDisplayField();
            dateEraYearDisplayField2.ShowTraditionalFirstYear = true;
            GrapeCity.Win.Editors.Fields.DateLiteralDisplayField dateLiteralDisplayField4 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
            dateLiteralDisplayField4.Text = "年";
            GrapeCity.Win.Editors.Fields.DateMonthDisplayField dateMonthDisplayField2 = new GrapeCity.Win.Editors.Fields.DateMonthDisplayField();
            dateMonthDisplayField2.ShowLeadingZero = true;
            GrapeCity.Win.Editors.Fields.DateLiteralDisplayField dateLiteralDisplayField5 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
            dateLiteralDisplayField5.Text = "月";
            GrapeCity.Win.Editors.Fields.DateDayDisplayField dateDayDisplayField2 = new GrapeCity.Win.Editors.Fields.DateDayDisplayField();
            dateDayDisplayField2.ShowLeadingZero = true;
            GrapeCity.Win.Editors.Fields.DateLiteralDisplayField dateLiteralDisplayField6 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
            dateLiteralDisplayField6.Text = "日";
            gcDate2.DisplayFields.AddRange(new GrapeCity.Win.Editors.Fields.DateDisplayField[] {
                dateEraDisplayField2,
                dateEraYearDisplayField2,
                dateLiteralDisplayField4,
                dateMonthDisplayField2,
                dateLiteralDisplayField5,
                dateDayDisplayField2,
                dateLiteralDisplayField6
            });

            // 入力書式
            GrapeCity.Win.Editors.Fields.DateYearField dateYearField2 = new GrapeCity.Win.Editors.Fields.DateYearField();
            GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField3 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
            dateLiteralField3.Text = "/";
            GrapeCity.Win.Editors.Fields.DateMonthField dateMonthField2 = new GrapeCity.Win.Editors.Fields.DateMonthField();
            GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField4 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
            dateLiteralField4.Text = "/";
            GrapeCity.Win.Editors.Fields.DateDayField dateDayField2 = new GrapeCity.Win.Editors.Fields.DateDayField();
            gcDate2.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] {
                dateYearField2,
                dateLiteralField3,
                dateMonthField2,
                dateLiteralField4,
                dateDayField2
            });

            gcDate2.ExitOnLastChar = true;
            gcDate2.PlaceHolder.Enable = true;
            gcDate2.PlaceHolder.NormalStyle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gcDate2.PlaceHolder.Text = "出荷日";

            // ショートカットキーの設定
            ShortcutCollection sc9 = new ShortcutCollection();
            sc9.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcDate2, sc9);

            GrapeCity.Win.Editors.DropDownButton dropDownButton3 = new GrapeCity.Win.Editors.DropDownButton();
            gcDate2.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { dropDownButton3 });

            // 初期値
            gcDate2.Value = null;


            // 
            // 備考
            // 
            gcTextBox3.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Dotted, System.Drawing.SystemColors.ControlDark);
            gcTextBox3.Multiline = true;

            // ショートカットキーの設定
            ShortcutCollection sc10 = new ShortcutCollection();
            sc10.Add(Keys.Return, gcShortcut1, "NextControl");
            gcShortcut1.SetShortcuts(gcTextBox3, sc10);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // エラーを保持しているコントロールのリストを取得
            List<Control> invalidControlList1 = gcCommonValidator1.GetInvalidControls();

            if (invalidControlList1.Contains(gcCharMask1))
            {
                MessageBox.Show("［商品情報］ - ［コード］はハイフンを除いて5桁以上で入力してください。", "部品入力／編集");
                gcCharMask1.Select();
                return;
            }

            if (invalidControlList1.Contains(gcTextBox1))
            {
                MessageBox.Show("［商品情報］ - ［名称］の入力は省略できません。", "部品入力／編集");
                gcTextBox1.Select();
                return;
            }

            if (invalidControlList1.Contains(gcComboBox1))
            {
                MessageBox.Show("［商品情報］ - ［区分］の入力は省略できません。", "部品入力／編集");
                gcComboBox1.Select();
                return;
            }

            if (invalidControlList1.Contains(gcNumber1))
            {
                MessageBox.Show("［商品情報］ - ［発注数］の入力は省略できません。", "部品入力／編集");
                gcNumber1.Select();
                return;
            }

            if (invalidControlList1.Contains(gcNumber2))
            {
                MessageBox.Show("［商品情報］ - ［単価］の入力は省略できません。", "部品入力／編集");
                gcNumber2.Select();
                return;
            }

            MessageBox.Show("登録しました。", "部品入力／編集", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // コントロールの値をクリア
            gcCharMask1.Clear();
            gcTextBox1.Clear();
            gcComboBox1.Clear();
            gcNumber1.Clear();
            gcNumber2.Clear();
            gcTextBox2.Clear();
            gcCharMask2.Clear();
            gcDate1.Clear();
            gcDate2.Clear();
            gcTextBox3.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("キャンセルしますか？", "部品入力／編集", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();
            }
        }
    }
}
