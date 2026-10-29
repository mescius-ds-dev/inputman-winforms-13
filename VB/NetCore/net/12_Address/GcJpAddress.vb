Imports System.Windows.Forms
Imports GrapeCity.Win.JPAddress

Namespace _12_Address
    Public Class GcJpAddress
        Inherits InputManWin13_Demo.DemoBase_settings
        Public Sub New()
            InitializeComponent()
            InitializeForm()
        End Sub
        Private Sub InitializeForm()
            ' ***** 初期設定
            GcMaskKey.Clear()
            GcTextBoxZipCode.Clear()
            GcTextBoxPref.Clear()
            GcTextBoxCity.Clear()
            GcTextBoxTown.Clear()
            GcTextBoxBlock.Clear()
            GcTextBoxOther.Clear()
            GcTextBoxClientId.Clear()
            GcTextBoxClientSecret.Clear()
            GcTextBoxIpAddress.Clear()

            GcTextBoxZipCode.Enabled = False
            GcTextBoxPref.Enabled = False
            GcTextBoxCity.Enabled = False
            GcTextBoxTown.Enabled = False
            GcTextBoxBlock.Enabled = False
            GcTextBoxOther.Enabled = False
            GcTextBoxZipCode.DisabledForeColor = System.Drawing.Color.Black
            GcTextBoxPref.DisabledForeColor = System.Drawing.Color.Black
            GcTextBoxCity.DisabledForeColor = System.Drawing.Color.Black
            GcTextBoxTown.DisabledForeColor = System.Drawing.Color.Black
            GcTextBoxBlock.DisabledForeColor = System.Drawing.Color.Black
            GcTextBoxOther.DisabledForeColor = System.Drawing.Color.Black
        End Sub

        Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            ' 住所情報をクリア
            GcTextBoxZipCode.Clear()
            GcTextBoxPref.Clear()
            GcTextBoxCity.Clear()
            GcTextBoxTown.Clear()
            GcTextBoxBlock.Clear()
            GcTextBoxOther.Clear()

            ' 入力チェック
            If String.IsNullOrEmpty(GcTextBoxClientId.Text) Then
                GcTextBoxClientId.Focus()
                MessageBox.Show("クライアントIDを入力してください。")
                Return
            End If

            If String.IsNullOrEmpty(GcTextBoxClientSecret.Text) Then
                GcTextBoxClientSecret.Focus()
                MessageBox.Show("クライアントシークレットを入力してください。")
                Return
            End If

            If String.IsNullOrEmpty(GcTextBoxIpAddress.Text) Then
                GcTextBoxIpAddress.Focus()
                MessageBox.Show("IPアドレスを入力してください。")
                Return
            End If

            If String.IsNullOrEmpty(GcMaskKey.Text) Then
                GcMaskKey.Focus()
                MessageBox.Show("郵便番号またはデジタルアドレスを入力してください。")
                Return
            End If

            If GcMaskKey.Text = "___-____" Then
                GcMaskKey.Focus()
                MessageBox.Show("郵便番号またはデジタルアドレスを入力してください。")
                Return
            End If

            ' 入力値の取得
            Dim clientId As String = GcTextBoxClientId.Text
            Dim clientSecret As String = GcTextBoxClientSecret.Text
            Dim ipAddress As String = GcTextBoxIpAddress.Text
            Dim key As String = GcMaskKey.Text

            ' JapanPostApiCredentialに認証情報を設定
            With GcjpAddress1.JapanPostApiCredential
                .ClientId = clientId
                .SecretKey = clientSecret
                .IPAddress = ipAddress
            End With

            Try
                ' 郵便番号・デジタルアドレスAPIを使用して住所情報を取得
                Dim response As SearchCodeResponse = Await GcjpAddress1.SearchCodeAsync(key)

                ' 住所情報を表示
                For Each address As SearchCodeResponse.AddressInfo In response.Addresses
                    GcTextBoxZipCode.Text = address.ZipCode ' 郵便番号
                    GcTextBoxPref.Text = address.PrefName   ' 都道府県
                    GcTextBoxCity.Text = address.CityName   ' 市区郡町村
                    GcTextBoxTown.Text = address.TownName   ' 町名
                    GcTextBoxBlock.Text = address.BlockName ' 番地
                    GcTextBoxOther.Text = address.OtherName ' 建物・部屋番号
                Next

            Catch apiException As JapanPostApiException
                ' APIサーバーからエラー応答があった場合
                MessageBox.Show(apiException.ApiError.Message)

            Catch ex As Exception
                ' その他エラー
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
End Namespace