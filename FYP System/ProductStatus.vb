Imports System.Data.OleDb
Imports System.IO.Ports

Public Class ProductStatus
    Dim comport As New List(Of String)()
    Dim receivedData As String = ""
    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\rfid.accdb"
    Private Sub Deduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comport.Add(sp)
        Next

        Dim rfid2 As String = ""
        Dim product2 As String = ""
        Dim product3 As String = ""
        Dim expdate As String = DateTime.Now.ToString("dd/MM/yyyy")
        Dim expprd As String = ""
        Dim stock As String = ""
        Dim quantity As String = ""
        Using myconnection2 As New OleDbConnection(constring)
            Dim cmd8 As OleDbCommand = New OleDbCommand("SELECT * FROM [RFID] WHERE [Expiry_Date] <= Date()+30 ", myconnection2)
            myconnection2.Open()
            Dim dr As OleDbDataReader = cmd8.ExecuteReader
            Dim prdFound As Boolean = False


            While dr.Read
                prdFound = True
                rfid2 = dr(1).ToString
                product2 = dr(2).ToString
                expdate = dr(3).ToString

                expprd = "Product: " & " " & "[" & product2 & "]" & " " & "[" & rfid2 & "]" & " " & "is expiring soon" & vbCrLf
                rtbEPN.Text &= expprd

            End While

            myconnection2.Close()
        End Using

        Using myconnection2 As New OleDbConnection(constring)
            Dim cmd9 As OleDbCommand = New OleDbCommand("SELECT * FROM [Stock] WHERE [Quantity] <= 3 ", myconnection2)
            myconnection2.Open()
            Dim dr As OleDbDataReader = cmd9.ExecuteReader
            Dim prdFound As Boolean = False


            While dr.Read
                prdFound = True
                stock = dr(2).ToString
                product3 = dr(1).ToString

                quantity = "Product: " & " " & "[" & product3 & "]" & " " & " " & "stock is low, please do shelf replenishment!!!" & vbCrLf
                rtbstock.Text &= quantity
            End While
            myconnection2.Close()
        End Using

    End Sub

    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            SerialPort1.Close()
            SerialPort1.PortName = comport(0)
            SerialPort1.BaudRate = 9600
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.ReadTimeout = 10000
            SerialPort1.Open()

            SerialPort2.Close()
            SerialPort2.PortName = comport(1)
            SerialPort2.BaudRate = 9600
            SerialPort2.DataBits = 8
            SerialPort2.Parity = Parity.None
            SerialPort2.StopBits = StopBits.One
            SerialPort2.Handshake = Handshake.None
            SerialPort2.Encoding = System.Text.Encoding.Default
            SerialPort2.ReadTimeout = 10000
            SerialPort2.Open()

            connect_BTN.Text = "Dis-connect"
            Timer1.Enabled = True
            Timer_LBL.Text = "Scanner: ON"

        Else
            SerialPort1.Close()
            SerialPort2.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Scanner: OFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        rtbTag.Text &= receivedData

        receivedData = ReceiveSerialData2()
        rtbTag.Text &= receivedData
    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Function ReceiveSerialData2() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort2.ReadExisting()
            If Incoming Is Nothing Then
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtbTag.TextChanged
        Dim lastLine As String = rtbTag.Lines(rtbTag.Lines.Length - 2)
        Dim rfid As String = ""
        Dim product As String = ""
        Dim row As String = ""
        Dim deletedprd As String = ""
        Using myconnection2 As New OleDbConnection(constring)
            Dim cmd5 As OleDbCommand = New OleDbCommand("SELECT * FROM [RFID] WHERE [RFID] = '" & lastLine & "' ", myconnection2)
            myconnection2.Open()
            Dim dr2 As OleDbDataReader = cmd5.ExecuteReader
            Dim prdFound As Boolean = False


            While dr2.Read
                prdFound = True
                rfid = dr2(1).ToString
                product = dr2(2).ToString
                row = dr2(4).ToString
            End While

            If prdFound = True Then
                Dim del As String = "DELETE from [RFID] WHERE [RFID] = @rfid"
                Using cmd2 As New OleDbCommand(del, myconnection2)
                    cmd2.Parameters.AddWithValue("@rfid", rfid)
                    cmd2.ExecuteNonQuery()
                End Using

                Dim upd6 As String = "UPDATE Stock SET Quantity = Quantity-1 WHERE [Product] = @prd"
                Using cmd6 As New OleDbCommand(upd6, myconnection2)
                    cmd6.Parameters.AddWithValue("@prd", product)
                    cmd6.ExecuteNonQuery()
                End Using


                deletedprd = "Product: " & " " & "[" & product & "]" & " " & "[" & rfid & "]" & " " & "deducted from stock" & vbCrLf
                rtbSS.Text &= deletedprd
            End If
            myconnection2.Close()
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AddNewProduct.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        Main.Show()
        Me.Close()
        SerialPort1.Close()
        SerialPort2.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class