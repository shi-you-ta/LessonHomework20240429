<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        TextBox1.Location = New Point(80, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(64, 34)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        TextBox2.Location = New Point(80, 73)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(64, 34)
        TextBox2.TabIndex = 0
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(35, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 28)
        Label1.TabIndex = 1
        Label1.Text = "x"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(35, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(22, 28)
        Label2.TabIndex = 1
        Label2.Text = "y"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(182, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 60)
        Button1.TabIndex = 2
        Button1.Text = "処理実行"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(35, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 34)
        Label3.TabIndex = 3
        Label3.Text = "足し算結果"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(35, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 34)
        Label4.TabIndex = 3
        Label4.Text = "引き算結果"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(35, 264)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 34)
        Label5.TabIndex = 3
        Label5.Text = "掛け算結果"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label6.Location = New Point(35, 324)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 34)
        Label6.TabIndex = 3
        Label6.Text = "割り算結果"
        ' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(153, 141)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 34)
        Label7.TabIndex = 3
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(153, 201)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 34)
        Label8.TabIndex = 3
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label9.Location = New Point(153, 261)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 34)
        Label9.TabIndex = 3
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label10.Location = New Point(153, 321)
        Label10.Name = "Label10"
        Label10.Size = New Size(112, 34)
        Label10.TabIndex = 3
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 411)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label

End Class
