Imports System.Text.RegularExpressions

Public Class Form1


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'TextBox1に入力された文字を取得する変数を宣言
        Dim inputNumber1 As String = TextBox1.Text
        '正規表現を使って電話番号パターンを表示
        'メタ文字[]で0～9と-以外のパターン
        '0～9と-を含む[0-9-]とすると途中で0～9と-以外の文字を打ち込んでも背景が変わらない
        Dim strPattern As String = "[^0-9-]"
        'Regexクラスにインスタンスを生成する
        Dim regex As New Regex(strPattern)

        'inputNumberが正規表現パターンに一致している場合
        If regex.IsMatch(inputNumber1) Then
            'パターン以外が入力された時に薄い赤色に背景を変更
            TextBox1.BackColor = Color.LightPink
        Else
            '背景はデフォルト
            TextBox1.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputNumber2 As String = TextBox1.Text

        MessageBox.Show("電話番号が入力されました" & vbCrLf &
        inputNumber2 & vbCrLf &
        "間違いありませんか", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If DialogResult.No Then
            TextBox1.Clear()
        End If
    End Sub
End Class
