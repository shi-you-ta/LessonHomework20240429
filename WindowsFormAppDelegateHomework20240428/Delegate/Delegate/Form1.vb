
'デリゲートを作成
Imports System.DirectoryServices

Public Delegate Function ArithmeticOperation(ByVal x As Double,
                                             ByVal y As Double
                                             ) As Double
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'テキストボックス内に入力された値を格納する変数
        Dim x As Double
        Dim y As Double

        'テキストボックス内の文字列を倍精度浮動小数点数型に変換する
        '変換できない場合はエラーでボックス内をクリアする
        If Double.TryParse(TextBox1.Text, x) And
            Double.TryParse(TextBox2.Text, y) Then
            Test()
        Else
            MessageBox.Show("入力に誤りがあります。", "エラー")
            TextBox1.Clear()
            TextBox2.Clear()
        End If

    End Sub

    'デリゲートを使用したTestメソッドと作成
    Protected Sub Test()
        '足し算
        DelegateTest(TextBox1.Text, TextBox2.Text, AddressOf Add)
        '引き算
        DelegateTest(TextBox1.Text, TextBox2.Text, AddressOf Subtract)
        '掛け算
        DelegateTest(TextBox1.Text, TextBox2.Text, AddressOf Multiply)
        '割り算
        DelegateTest(TextBox1.Text, TextBox2.Text, AddressOf Divide)
    End Sub

    'デリゲートをパラメーターとして取るメソッドを作成
    Sub DelegateTest(ByVal x As Double,
                     ByVal y As Double,
                     ByVal ao As ArithmeticOperation)
        'デリゲート型として宣言しているaoからアクセスし、同じDouble型の変数に代入
        'シグネチャが一致しているのでArithmeticOperationを使い、
        'Add,Subtract,Multiply,Divideメソッドへの参照が可能
        Dim ret As Double = ao.Invoke(x, y)
        'どの四則演算を行って取得した値かを照合するために
        '再度四則演算を行い一致した場合
        'そのラベルに結果を表示する
        Select Case ret
            Case Add(x, y)
                Label7.Text = ret
            Case Subtract(x, y)
                Label8.Text = ret
            Case Multiply(x, y)
                Label9.Text = ret
            Case Divide(x, y)
                Label10.Text = ret
            Case Else
                MessageBox.Show("ありえません")
        End Select
    End Sub


    'Addメソッド：ArithmeticOperationと一致するパラメータと戻り値を持つ
    Private Function Add(ByVal x As Double, ByVal y As Double) As Double
        Return x + y
    End Function

    'Subtractメソッド：ArithmeticOperationと一致するパラメータと戻り値を持つ
    Private Function Subtract(ByVal x As Double, ByVal y As Double) As Double
        Return x - y
    End Function

    'Multiplyメソッド：ArithmeticOperationと一致するパラメータと戻り値を持つ
    Private Function Multiply(ByVal x As Double, ByVal y As Double) As Double
        Return x * y
    End Function

    'Divideメソッド：ArithmeticOperationと一致するパラメータと戻り値を持つ
    Private Function Divide(ByVal x As Double, ByVal y As Double) As Double
        If y = 0 Then
            MessageBox.Show("0で割ることは出来ません。", "エラー")
            Return 0
        Else
            Return x / y
        End If
    End Function


End Class
