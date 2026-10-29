namespace InputManWin13_Demo._12_Address
{
    partial class GcJpAddress
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.Fields.MaskPatternField maskPatternField1 = new GrapeCity.Win.Editors.Fields.MaskPatternField();
            GrapeCity.Win.Editors.Fields.MaskLiteralField maskLiteralField1 = new GrapeCity.Win.Editors.Fields.MaskLiteralField();
            GrapeCity.Win.Editors.Fields.MaskPatternField maskPatternField2 = new GrapeCity.Win.Editors.Fields.MaskPatternField();
            groupBox2 = new GroupBox();
            label12 = new Label();
            gcTextBoxOther = new GrapeCity.Win.Editors.GcTextBox(components);
            label11 = new Label();
            gcTextBoxBlock = new GrapeCity.Win.Editors.GcTextBox(components);
            label3 = new Label();
            label7 = new Label();
            gcTextBoxPref = new GrapeCity.Win.Editors.GcTextBox(components);
            label6 = new Label();
            gcTextBoxCity = new GrapeCity.Win.Editors.GcTextBox(components);
            label4 = new Label();
            gcTextBoxTown = new GrapeCity.Win.Editors.GcTextBox(components);
            gcTextBoxZipCode = new GrapeCity.Win.Editors.GcTextBox(components);
            button1 = new Button();
            gcMaskKey = new GrapeCity.Win.Editors.GcMask(components);
            label2 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            gcTextBoxClientId = new GrapeCity.Win.Editors.GcTextBox(components);
            label8 = new Label();
            gcTextBoxIpAddress = new GrapeCity.Win.Editors.GcTextBox(components);
            gcTextBoxClientSecret = new GrapeCity.Win.Editors.GcTextBox(components);
            label9 = new Label();
            gcJPAddress1 = new GrapeCity.Win.JPAddress.GcJPAddress();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxOther).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxBlock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxPref).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxCity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxTown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxZipCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcMaskKey).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxClientId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxIpAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxClientSecret).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(gcMaskKey);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(gcTextBoxOther);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(gcTextBoxBlock);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(gcTextBoxPref);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(gcTextBoxCity);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(gcTextBoxTown);
            groupBox2.Controls.Add(gcTextBoxZipCode);
            groupBox2.Location = new Point(6, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 325);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "住所情報";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 269);
            label12.Name = "label12";
            label12.Size = new Size(104, 18);
            label12.TabIndex = 21;
            label12.Text = "建物・部屋番号：";
            // 
            // gcTextBoxOther
            // 
            gcTextBoxOther.AutoSize = true;
            gcTextBoxOther.Location = new Point(8, 290);
            gcTextBoxOther.Name = "gcTextBoxOther";
            gcTextBoxOther.Size = new Size(318, 22);
            gcTextBoxOther.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 220);
            label11.Name = "label11";
            label11.Size = new Size(44, 18);
            label11.TabIndex = 19;
            label11.Text = "番地：";
            // 
            // gcTextBoxBlock
            // 
            gcTextBoxBlock.AutoSize = true;
            gcTextBoxBlock.Location = new Point(8, 241);
            gcTextBoxBlock.Name = "gcTextBoxBlock";
            gcTextBoxBlock.Size = new Size(318, 22);
            gcTextBoxBlock.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 22);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 11;
            label3.Text = "郵便番号：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 171);
            label7.Name = "label7";
            label7.Size = new Size(44, 18);
            label7.TabIndex = 17;
            label7.Text = "町名：";
            // 
            // gcTextBoxPref
            // 
            gcTextBoxPref.AutoSize = true;
            gcTextBoxPref.Location = new Point(8, 94);
            gcTextBoxPref.Name = "gcTextBoxPref";
            gcTextBoxPref.Size = new Size(318, 22);
            gcTextBoxPref.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 122);
            label6.Name = "label6";
            label6.Size = new Size(80, 18);
            label6.TabIndex = 15;
            label6.Text = "市区郡町村：";
            // 
            // gcTextBoxCity
            // 
            gcTextBoxCity.AutoSize = true;
            gcTextBoxCity.Location = new Point(8, 143);
            gcTextBoxCity.Name = "gcTextBoxCity";
            gcTextBoxCity.Size = new Size(318, 22);
            gcTextBoxCity.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 73);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 13;
            label4.Text = "都道府県：";
            // 
            // gcTextBoxTown
            // 
            gcTextBoxTown.AutoSize = true;
            gcTextBoxTown.Location = new Point(8, 192);
            gcTextBoxTown.Name = "gcTextBoxTown";
            gcTextBoxTown.Size = new Size(318, 22);
            gcTextBoxTown.TabIndex = 18;
            // 
            // gcTextBoxZipCode
            // 
            gcTextBoxZipCode.AutoSize = true;
            gcTextBoxZipCode.Location = new Point(8, 45);
            gcTextBoxZipCode.Name = "gcTextBoxZipCode";
            gcTextBoxZipCode.Size = new Size(318, 22);
            gcTextBoxZipCode.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(90, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "住所検索";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gcMaskKey
            // 
            maskPatternField1.MaxLength = 3;
            maskPatternField1.MinLength = 3;
            maskPatternField1.Pattern = "\\A\\D";
            maskLiteralField1.Text = "-";
            maskPatternField2.MaxLength = 4;
            maskPatternField2.MinLength = 4;
            maskPatternField2.Pattern = "\\A\\D";
            gcMaskKey.Fields.AddRange(new GrapeCity.Win.Editors.Fields.MaskField[] { maskPatternField1, maskLiteralField1, maskPatternField2 });
            gcMaskKey.Location = new Point(8, 29);
            gcMaskKey.Name = "gcMaskKey";
            gcMaskKey.Size = new Size(76, 22);
            gcMaskKey.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 8);
            label2.Name = "label2";
            label2.Size = new Size(176, 18);
            label2.TabIndex = 24;
            label2.Text = "郵便番号／デジタルアドレス：";
            // 
            // label10
            // 
            label10.Location = new Point(5, 8);
            label10.Name = "label10";
            label10.Size = new Size(338, 57);
            label10.TabIndex = 28;
            label10.Text = "1.API認証情報を入力します。\r\n2.郵便番号またはデジタルアドレスを入力します。\r\n3.住所検索をクリックします。";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(gcTextBoxClientId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(gcTextBoxIpAddress);
            groupBox1.Controls.Add(gcTextBoxClientSecret);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(8, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 177);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "API認証情報";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 122);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 21;
            label5.Text = "IPアドレス：";
            // 
            // gcTextBoxClientId
            // 
            gcTextBoxClientId.AutoSize = true;
            gcTextBoxClientId.Location = new Point(8, 45);
            gcTextBoxClientId.Name = "gcTextBoxClientId";
            gcTextBoxClientId.Size = new Size(318, 22);
            gcTextBoxClientId.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 73);
            label8.Name = "label8";
            label8.Size = new Size(164, 18);
            label8.TabIndex = 19;
            label8.Text = "クライアントシークレット：";
            // 
            // gcTextBoxIpAddress
            // 
            gcTextBoxIpAddress.AutoSize = true;
            gcTextBoxIpAddress.Location = new Point(8, 143);
            gcTextBoxIpAddress.Name = "gcTextBoxIpAddress";
            gcTextBoxIpAddress.Size = new Size(319, 22);
            gcTextBoxIpAddress.TabIndex = 22;
            // 
            // gcTextBoxClientSecret
            // 
            gcTextBoxClientSecret.AutoSize = true;
            gcTextBoxClientSecret.Location = new Point(8, 94);
            gcTextBoxClientSecret.Name = "gcTextBoxClientSecret";
            gcTextBoxClientSecret.Size = new Size(316, 22);
            gcTextBoxClientSecret.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 22);
            label9.Name = "label9";
            label9.Size = new Size(106, 18);
            label9.TabIndex = 17;
            label9.Text = "クライアントID：";
            // 
            // GcJpAddress
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Description = "日本郵便株式会社の郵便番号・デジタルアドレスAPIと連携して住所情報を検索できます。\nこの機能を使用するには、日本郵便の郵便番号・デジタルアドレスAPIサービスに登録し、\nAPI認証情報を取得する必要があります。";
            Name = "GcJpAddress";
            Title = "郵便番号・デジタルアドレスAPIによる住所検索";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxOther).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxBlock).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxPref).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxCity).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxTown).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxZipCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcMaskKey).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxClientId).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxIpAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcTextBoxClientSecret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label12;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxOther;
        private Label label11;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxBlock;
        private Label label3;
        private Label label7;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxPref;
        private Label label6;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxCity;
        private Label label4;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxTown;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxZipCode;
        private Label label2;
        private Button button1;
        private GrapeCity.Win.Editors.GcMask gcMaskKey;
        private Label label10;
        private GroupBox groupBox1;
        private Label label5;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxClientId;
        private Label label8;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxIpAddress;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxClientSecret;
        private Label label9;
        private GrapeCity.Win.JPAddress.GcJPAddress gcJPAddress1;
    }
}
