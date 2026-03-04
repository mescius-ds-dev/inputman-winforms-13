namespace InputManWin13_Demo._12_Address
{
    partial class GcJpAddress
    {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            GrapeCity.Win.Editors.Fields.MaskPatternField maskPatternField1 = new GrapeCity.Win.Editors.Fields.MaskPatternField();
            GrapeCity.Win.Editors.Fields.MaskLiteralField maskLiteralField1 = new GrapeCity.Win.Editors.Fields.MaskLiteralField();
            GrapeCity.Win.Editors.Fields.MaskPatternField maskPatternField2 = new GrapeCity.Win.Editors.Fields.MaskPatternField();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcTextBoxTown = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTextBoxZipCode = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.gcTextBoxCity = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTextBoxPref = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gcMaskKey = new GrapeCity.Win.Editors.GcMask(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gcTextBoxClientId = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.gcTextBoxClientSecret = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.gcTextBoxIpAddress = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.gcJPAddress1 = new GrapeCity.Win.JPAddress.GcJPAddress();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gcTextBoxOther = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.gcTextBoxBlock = new GrapeCity.Win.Editors.GcTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxPref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaskKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxClientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxClientSecret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxIpAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.gcMaskKey);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "市区郡町村：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "郵便番号／デジタルアドレス：";
            // 
            // gcTextBoxTown
            // 
            this.gcTextBoxTown.AutoSize = true;
            this.gcTextBoxTown.Location = new System.Drawing.Point(8, 192);
            this.gcTextBoxTown.Name = "gcTextBoxTown";
            this.gcTextBoxTown.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxTown.TabIndex = 21;
            // 
            // gcTextBoxZipCode
            // 
            this.gcTextBoxZipCode.AutoSize = true;
            this.gcTextBoxZipCode.Location = new System.Drawing.Point(8, 45);
            this.gcTextBoxZipCode.Name = "gcTextBoxZipCode";
            this.gcTextBoxZipCode.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxZipCode.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "都道府県：";
            // 
            // gcTextBoxCity
            // 
            this.gcTextBoxCity.AutoSize = true;
            this.gcTextBoxCity.Location = new System.Drawing.Point(8, 143);
            this.gcTextBoxCity.Name = "gcTextBoxCity";
            this.gcTextBoxCity.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxCity.TabIndex = 19;
            // 
            // gcTextBoxPref
            // 
            this.gcTextBoxPref.AutoSize = true;
            this.gcTextBoxPref.Location = new System.Drawing.Point(8, 94);
            this.gcTextBoxPref.Name = "gcTextBoxPref";
            this.gcTextBoxPref.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxPref.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "町名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "郵便番号：";
            // 
            // gcMaskKey
            // 
            this.gcMaskKey.AutoSize = true;
            maskPatternField1.MaxLength = 3;
            maskPatternField1.MinLength = 3;
            maskPatternField1.Pattern = "\\A\\D";
            maskLiteralField1.Text = "-";
            maskPatternField2.MaxLength = 4;
            maskPatternField2.MinLength = 4;
            maskPatternField2.Pattern = "\\A\\D";
            this.gcMaskKey.Fields.AddRange(new GrapeCity.Win.Editors.Fields.MaskField[] {
            maskPatternField1,
            maskLiteralField1,
            maskPatternField2});
            this.gcMaskKey.Location = new System.Drawing.Point(8, 29);
            this.gcMaskKey.Name = "gcMaskKey";
            this.gcMaskKey.Size = new System.Drawing.Size(76, 22);
            this.gcMaskKey.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "住所検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gcTextBoxClientId
            // 
            this.gcTextBoxClientId.AutoSize = true;
            this.gcTextBoxClientId.Location = new System.Drawing.Point(8, 45);
            this.gcTextBoxClientId.Name = "gcTextBoxClientId";
            this.gcTextBoxClientId.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxClientId.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "クライアントID：";
            // 
            // gcTextBoxClientSecret
            // 
            this.gcTextBoxClientSecret.AutoSize = true;
            this.gcTextBoxClientSecret.Location = new System.Drawing.Point(8, 94);
            this.gcTextBoxClientSecret.Name = "gcTextBoxClientSecret";
            this.gcTextBoxClientSecret.Size = new System.Drawing.Size(316, 22);
            this.gcTextBoxClientSecret.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "クライアントシークレット：";
            // 
            // gcTextBoxIpAddress
            // 
            this.gcTextBoxIpAddress.AutoSize = true;
            this.gcTextBoxIpAddress.Location = new System.Drawing.Point(8, 143);
            this.gcTextBoxIpAddress.Name = "gcTextBoxIpAddress";
            this.gcTextBoxIpAddress.Size = new System.Drawing.Size(319, 22);
            this.gcTextBoxIpAddress.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "IPアドレス：";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 57);
            this.label10.TabIndex = 22;
            this.label10.Text = "1.API認証情報を入力します。\r\n2.郵便番号またはデジタルアドレスを入力します。\r\n3.住所検索をクリックします。";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gcTextBoxClientId);
            this.groupBox1.Controls.Add(this.gcTextBoxIpAddress);
            this.groupBox1.Controls.Add(this.gcTextBoxClientSecret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(8, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 177);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API認証情報";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.gcTextBoxOther);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.gcTextBoxBlock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.gcTextBoxPref);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gcTextBoxCity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gcTextBoxTown);
            this.groupBox2.Controls.Add(this.gcTextBoxZipCode);
            this.groupBox2.Location = new System.Drawing.Point(6, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 325);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "住所情報";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "建物・部屋番号：";
            // 
            // gcTextBoxOther
            // 
            this.gcTextBoxOther.AutoSize = true;
            this.gcTextBoxOther.Location = new System.Drawing.Point(8, 290);
            this.gcTextBoxOther.Name = "gcTextBoxOther";
            this.gcTextBoxOther.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxOther.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "番地：";
            // 
            // gcTextBoxBlock
            // 
            this.gcTextBoxBlock.AutoSize = true;
            this.gcTextBoxBlock.Location = new System.Drawing.Point(8, 241);
            this.gcTextBoxBlock.Name = "gcTextBoxBlock";
            this.gcTextBoxBlock.Size = new System.Drawing.Size(318, 22);
            this.gcTextBoxBlock.TabIndex = 23;
            // 
            // GcJpAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Description = "日本郵便株式会社の郵便番号・デジタルアドレスAPIと連携して住所情報を検索できます。\nこの機能を使用するには、日本郵便の郵便番号・デジタルアドレスAPIサービスに登録し、\nAPI認証情報を取得する必要があります。";
            this.Name = "GcJpAddress";
            this.Title = "郵便番号・デジタルアドレスAPIによる住所検索";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxPref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaskKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxClientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxClientSecret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxIpAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTextBoxBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxTown;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxZipCode;
        private System.Windows.Forms.Label label4;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxCity;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxPref;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private GrapeCity.Win.Editors.GcMask gcMaskKey;
        private System.Windows.Forms.Button button1;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxIpAddress;
        private System.Windows.Forms.Label label9;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxClientSecret;
        private System.Windows.Forms.Label label8;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxClientId;
        private System.Windows.Forms.Label label5;
        private GrapeCity.Win.JPAddress.GcJPAddress gcJPAddress1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxOther;
        private System.Windows.Forms.Label label11;
        private GrapeCity.Win.Editors.GcTextBox gcTextBoxBlock;
    }
}
