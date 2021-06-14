Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Form1


    Dim MySqlConnection As MySqlConnection

    Dim opfile As New OpenFileDialog
    Dim filename As String
    Dim full_file_name As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '//This will open a diolog box for us to select our file for upload
        If opfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = opfile.FileName
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opfile.FileName = Nothing
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '// this code will save our file to sqlserver database
        full_file_name = TextBox1.Text
        full_file_name.Split("\")
        filename = full_file_name.Last.ToString

        Dim con As MySqlConnection = New MySqlConnection("SERVER = localhost; DATABASE = kullanıcılar; UID = root; PWD = Yaren.7030*")
        Dim cmd As MySqlCommand = New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = ("insert into new (file_name,[content]) values(@file_name,,@file)")
        With cmd.Parameters
            .AddWithValue("file_name,", filename)
            .AddWithValue("file", MySqlDbType.VarBinary).Value = File.ReadAllBytes(TextBox1.Text)
        End With
        con.Open()
        'cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("File Saved")
        TextBox1.Clear()

    End Sub
End Class
