using GrapeCity.Win.JPAddress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputManWin13_Demo._12_Address
{
    public partial class GcJpAddress : InputManWin13_Demo.DemoBase_settings
    {
        public GcJpAddress()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // ***** 初期設定
            gcMaskKey.Clear();
            gcTextBoxZipCode.Clear();
            gcTextBoxPref.Clear();
            gcTextBoxCity.Clear();
            gcTextBoxTown.Clear();
            gcTextBoxBlock.Clear();
            gcTextBoxOther.Clear();
            gcTextBoxClientId.Clear();
            gcTextBoxClientSecret.Clear();
            gcTextBoxIpAddress.Clear();

            gcTextBoxZipCode.Enabled = false;
            gcTextBoxPref.Enabled = false;
            gcTextBoxCity.Enabled = false;
            gcTextBoxTown.Enabled = false;
            gcTextBoxBlock.Enabled = false;
            gcTextBoxOther.Enabled = false;
            gcTextBoxZipCode.DisabledForeColor = System.Drawing.Color.Black;
            gcTextBoxPref.DisabledForeColor = System.Drawing.Color.Black;
            gcTextBoxCity.DisabledForeColor = System.Drawing.Color.Black;
            gcTextBoxTown.DisabledForeColor = System.Drawing.Color.Black;
            gcTextBoxBlock.DisabledForeColor = System.Drawing.Color.Black;
            gcTextBoxOther.DisabledForeColor = System.Drawing.Color.Black;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 住所情報をクリア
            gcTextBoxZipCode.Clear();
            gcTextBoxPref.Clear();
            gcTextBoxCity.Clear();
            gcTextBoxTown.Clear();
            gcTextBoxBlock.Clear();
            gcTextBoxOther.Clear();

            // 入力チェック
            if (string.IsNullOrEmpty(gcTextBoxClientId.Text))
            {
                gcTextBoxClientId.Focus();
                MessageBox.Show("クライアントIDを入力してください。");
                return;
            }

            if (string.IsNullOrEmpty(gcTextBoxClientSecret.Text))
            {
                gcTextBoxClientSecret.Focus();
                MessageBox.Show("クライアントシークレットを入力してください。");
                return;
            }

            if (string.IsNullOrEmpty(gcTextBoxIpAddress.Text))
            {
                gcTextBoxIpAddress.Focus();
                MessageBox.Show("IPアドレスを入力してください。");
                return;
            }

            if (string.IsNullOrEmpty(gcMaskKey.Text))
            {
                gcMaskKey.Focus();
                MessageBox.Show("郵便番号またはデジタルアドレスを入力してください。");
                return;
            }

            if (gcMaskKey.Text == "___-____")
            {
                gcMaskKey.Focus();
                MessageBox.Show("郵便番号またはデジタルアドレスを入力してください。");
                return;
            }

            // 入力値の取得
            var clientId = gcTextBoxClientId.Text;
            var clientSecret = gcTextBoxClientSecret.Text;
            var ipAddress = gcTextBoxIpAddress.Text;
            var key = gcMaskKey.Text;

            // JapanPostApiCredentialに認証情報を設定
            gcJPAddress1.JapanPostApiCredential.ClientId = clientId;
            gcJPAddress1.JapanPostApiCredential.SecretKey = clientSecret;
            gcJPAddress1.JapanPostApiCredential.IPAddress = ipAddress;

            try
            {
                // 郵便番号・デジタルアドレスAPIを使用して住所情報を取得
                var response = await gcJPAddress1.SearchCodeAsync(key);

                // 住所情報を表示
                foreach (var address in response.Addresses)
                {
                    gcTextBoxZipCode.Text = address.ZipCode;  // 郵便番号
                    gcTextBoxPref.Text = address.PrefName;    // 都道府県
                    gcTextBoxCity.Text = address.CityName;    // 市区郡町村
                    gcTextBoxTown.Text = address.TownName;    // 町名
                    gcTextBoxBlock.Text = address.BlockName;  // 番地
                    gcTextBoxOther.Text = address.OtherName;  // 建物・部屋番号
                }
            }
            catch (JapanPostApiException apiException)
            {
                // APIサーバーからエラー応答があった場合にメッセージを表示
                MessageBox.Show(apiException.ApiError.Message);
            }
            catch (Exception ex)
            {
                // その他エラーをメッセージに表示
                MessageBox.Show(ex.Message);
            }
        }
    }
}
