Imports System
Imports System.Data.OleDb
Imports System.IO.Ports



Public Class AddNewProduct

    Dim comPORT As String
    Dim receivedData As String = ""
    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\rfid.accdb"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
    End Sub


    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If

        If (comPort_ComboBox.SelectedItem.ToString = "COM3") Then
            lblrow.Text = "A"
        End If

        If (comPort_ComboBox.SelectedItem.ToString = "COM5") Then
            lblrow.Text = "B"
        End If
    End Sub

    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                btnadd.Enabled = True
                Timer_LBL.Text = "Scanner: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            btnadd.Enabled = False
            Timer_LBL.Text = "Scanner: OFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
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



    Private Sub clear_BTN_Click(sender As Object, e As EventArgs) Handles clear_BTN.Click
        rtbTag.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If rtbTag.Text = "" Then
            MsgBox("Please enter new product name or scan a RFID tag in order to add", vbSystemModal + vbExclamation, "RFID")
        Else
            Dim row As String = ""
            Dim lastLine As String = rtbTag.Lines(rtbTag.Lines.Length - 2)

            Using myconnection2 As New OleDbConnection(constring)
                Dim cmd5 As OleDbCommand = New OleDbCommand("SELECT * FROM [Stock] WHERE [Product] = '" & txtproduct.Text & "' ", myconnection2)
                myconnection2.Open()
                Dim dr2 As OleDbDataReader = cmd5.ExecuteReader
                Dim prdFound As Boolean = False
                Dim rowcheck As Boolean = False


                While dr2.Read
                    prdFound = True
                    row = dr2(3).ToString
                End While

                If prdFound = True And row = lblrow.Text Then

                    Using myconnection3 As New OleDbConnection(constring)
                        Dim cmd7 As OleDbCommand = New OleDbCommand("SELECT * FROM [RFID] WHERE [RFID] = '" & lastLine & "' ", myconnection3)
                        myconnection3.Open()
                        Dim dr As OleDbDataReader = cmd7.ExecuteReader
                        Dim rfidFound As Boolean = False

                        While dr.Read
                            rfidFound = True
                        End While

                        myconnection3.Close()

                        If rfidFound = True Then
                            MsgBox("rfid already exist!", vbSystemModal + vbExclamation, "RFID")
                        Else

                            Using myconnection As New OleDbConnection(constring)
                                myconnection.Open()

                                Dim rfid As String = "INSERT INTO [RFID] ([RFID],[Product],[Expiry_Date],[Row]) VALUES (@rfid,@product,@date,@row)"
                                Using cmd3 As New OleDbCommand(rfid, myconnection)
                                    cmd3.Parameters.AddWithValue("@rfid", lastLine)
                                    cmd3.Parameters.AddWithValue("@product", txtproduct.Text)
                                    cmd3.Parameters.AddWithValue("@date", dtpDate)
                                    cmd3.Parameters.AddWithValue("@row", lblrow.Text)
                                    cmd3.ExecuteNonQuery()
                                End Using
                                myconnection.Close()
                            End Using

                            Dim upd6 As String = "UPDATE Stock SET Quantity = Quantity+1 WHERE [Product] = @prd"
                            Using cmd6 As New OleDbCommand(upd6, myconnection2)
                                cmd6.Parameters.AddWithValue("@prd", txtproduct.Text)
                                cmd6.ExecuteNonQuery()
                            End Using
                            MsgBox("Successfully added!", vbSystemModal + vbExclamation, "RFID")
                        End If
                    End Using

                    myconnection2.Close()

                ElseIf prdFound = True And row <> lblrow.Text Then
                    MsgBox("Misplaced item!", vbSystemModal + vbExclamation, "RFID")
                Else
                    Using myconnection3 As New OleDbConnection(constring)
                        Dim cmd7 As OleDbCommand = New OleDbCommand("SELECT * FROM [RFID] WHERE [RFID] = '" & lastLine & "' ", myconnection3)
                        myconnection3.Open()
                        Dim dr As OleDbDataReader = cmd7.ExecuteReader
                        Dim rfidFound As Boolean = False

                        While dr.Read
                            rfidFound = True

                        End While

                        myconnection3.Close()

                        If rfidFound = True Then
                            MsgBox("rfid already exist!", vbSystemModal + vbExclamation, "RFID")
                        Else


                            'Dim constring1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\rfid.accdb"
                            Using myconnection1 As New OleDbConnection(constring)
                                myconnection1.Open()
                                Dim stock As String = "INSERT INTO [Stock] ([Product],[Row]) VALUES (@product,@row)"
                                Using cmd4 As New OleDbCommand(stock, myconnection1)
                                    cmd4.Parameters.AddWithValue("@product", txtproduct.Text)
                                    cmd4.Parameters.AddWithValue("@row", lblrow.Text)
                                    cmd4.ExecuteNonQuery()
                                End Using

                                Dim upd As String = "UPDATE Stock SET Quantity = Quantity+1 WHERE [Product] = @prd"
                                Using cmd2 As New OleDbCommand(upd, myconnection1)
                                    cmd2.Parameters.AddWithValue("@prd", txtproduct.Text)
                                    cmd2.ExecuteNonQuery()
                                End Using

                                myconnection1.Close()

                                MsgBox("Successfully added!", vbSystemModal + vbExclamation, "RFID")

                            End Using
                        End If
                    End Using

                    Using myconnection As New OleDbConnection(constring)
                        myconnection.Open()

                        Dim rfid As String = "INSERT INTO [RFID] ([RFID],[Product],[Expiry_Date],[Row]) VALUES (@rfid,@product,@date,@row)"
                        Using cmd3 As New OleDbCommand(rfid, myconnection)
                            cmd3.Parameters.AddWithValue("@rfid", lastLine)
                            cmd3.Parameters.AddWithValue("@product", txtproduct.Text)
                            cmd3.Parameters.AddWithValue("@date", dtpDate)
                            cmd3.Parameters.AddWithValue("@row", lblrow.Text)
                            cmd3.ExecuteNonQuery()
                        End Using
                        myconnection.Close()
                    End Using
                End If
            End Using
        End If
    End Sub

    Private Sub dtpDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpDate.Validating
        If dtpDate.Value < Date.Today Then
            MessageBox.Show("Date cannot be before today.")
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        Main.Show()
        Me.Close()
        SerialPort1.Close()
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
