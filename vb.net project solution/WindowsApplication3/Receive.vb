'Code Starts here ….
'Import Systems which we are gonna use in our code
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports MySql.Data.MySqlClient


'frmMain is the name of our form ….
'Here starts our main form code …..
Public Class frmMain
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Dim node1_timestamp As Date
    Dim node2_timestamp As Date
    Dim node3_timestamp As Date
    Dim main_timestamp As Date
    Dim received_dat As Integer
    Dim byte_count = 0
    Dim byte_array(100) As Byte
    Dim numBytes As Integer
    Dim buf() As Byte
    Dim buf_process() As Byte
    Dim num_bytes_process As Integer
    Dim myConnectionString As String        'Database Parameters
    Dim zone As String                      'used as a variable
    Dim objects As String                      'used as a variable
    Dim snumbers As Int64
    Dim dbcommand As String
    Dim dbpointer As String
    Dim dbdata As String




    'Page Load Code Starts Here….
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        cmbBaud.Items.Add(9600)
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)
        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)
        cmbBaud.Text = cmbBaud.Items.Item(0)
        btnDisconnect.Enabled = False
    End Sub

    'Page Load Code Ends Here ….

    'Connect Button Code Starts Here ….
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text
        SerialPort1.BaudRate = cmbBaud.Text
        'SerialPort1.PortName = "COM1" added for debug only
        'SerialPort1.BaudRate = 9600 added for debug only
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Open()
        btnConnect.Enabled = False
        btnDisconnect.Enabled = True
    End Sub
    'Connect Button Code Ends Here ….

    'Disconnect Button Code Starts Here ….
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
    End Sub
    'Disconnect Button Code Ends Here ….


    'Serial Port Receiving Code Starts Here ….
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        main_timestamp = Now
        System.Threading.Thread.Sleep(20)
        'ReceivedText(SerialPort1.ReadByte())
        Dim numBytes As Integer = SerialPort1.BytesToRead 'get # of bytes available  
        Dim buf(numBytes - 1) As Byte 'allocate a buffer  
        SerialPort1.Read(buf, 0, numBytes) 'read the bytes  
        buf_process = buf       'do this to minimise timing problems related to buf if it's being used in another thread
        num_bytes_process = numBytes 'also do this to stop any timing issues with next data received
        buf_process = buf
        For Each b As Byte In buf
        Next
        'http://www.dreamincode.net/forums/topic/312544-total-newb-trying-to-read-incoming-serial-port-data-in-hex/
        SerialPort1.DiscardInBuffer() 'empty the buffer ready to receive next message

        Call buffer_process_data()
    End Sub
    Private Sub buffer_process_data()
        Dim sensor_serial As Integer = buf_process(0)   'get first byte of buffer
        Dim temp_serial As Integer
        Dim data(10) As Integer
        Dim lux As Double
        Dim ch0 As Long
        Dim ch1 As Long
        Dim ratio As Single
        Dim lux_result_integer As Integer
        Dim timeStamp As DateTime = DateTime.Now
        Dim timestamp_str As String
        Dim milliseconds As Integer
        Dim sensor_type As String
        'get sensor serial number

        sensor_serial = (sensor_serial << 8) + buf_process(1) 'bit shift first byte to merge with second byte which will make the original serial number
        sensor_type = sensor_serial.ToString().Substring(0, 2)
        'get sensor data
        Dim count As Integer = 0

        While ((buf_process(count)) And (buf_process(count + 1))) <> &HFF 'do until two consequitive 0xFF found in data
            data(count) = buf_process(count + 2)    'data count offset by two as first two btes is serial number
            count += 1      'increment count
            If count > 10 Then      'two consequitive 0xFF not found and data invalid
                GoTo invalid        'goto invalid to bomb out of process
            End If
        End While

        Select Case sensor_type
            Case "12" 'if sensor is light sensor
                ' If count = 6 Then   'correct number of bytes for light sensor (0:3 = 4)
                'byte 1 = DATA0LOW byte 2 = DATA0HIGH byte 3 = DATA1LOW byte 4 = DATA1 HIGH 
                Dim ch0_low As Integer = buf_process(2)
                Dim ch0_high As Integer = buf_process(3)
                Dim ch1_low As Integer = buf_process(4)
                Dim ch1_high As Integer = buf_process(5)

                ch0 = (ch0_high << 8) + ch0_low  'concatatenate Data0 register of light sensor 
                ch1 = (ch1_high << 8) + ch1_low 'concatatenate Data1 register of light sensor 

                'perform algorithm in TLS2561 March 2009 datasheet page 23
                ratio = ch1 / ch0
                Select Case True
                    Case (ratio >= 0 AndAlso ratio <= 0.5)
                        lux = 0.0304 * ch0 - 0.062 * ch0 * ((ratio) ^ 1.4)
                    Case (ratio > 0.5 AndAlso ratio <= 0.61)
                        lux = 0.0224 * ch0 - 0.031 * ch1
                    Case (ratio > 0.61 AndAlso ratio <= 0.8)
                        lux = 0.0128 * ch0 - 0.0153 * ch1
                    Case (ratio > 0.8 AndAlso ratio <= 1.3)
                        lux = 0.00146 * ch0 - 0.00112 * ch1
                    Case (ratio > 1.3 AndAlso ratio <= 100)
                        lux = 0
                End Select

                'Send to database as received data
                lux_result_integer = lux
                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & lux & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

            Case "10" 'if sensor is motion sensor
                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & "1" & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

            Case "11" 'if sensor is Hall node
                Dim hall_data As Integer = buf_process(2)
                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & hall_data & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

            Case "13" 'if sensor is temp sensor
                Dim MSB As Integer = buf_process(2)
                Dim LSB As Integer = buf_process(3)
                Dim MSB_and_LSB = (MSB << 8) + LSB
                Dim temperature As Integer

                temperature = -46.85 + 175.72 * (MSB_and_LSB / 65536)
                'Datasheet HTU21D(F) October 2013 algorithm on page 15
                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & temperature & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

            Case "14" 'if sensor is humidity sensor
                ' If count = 6 Then   'correct number of bytes for light sensor (0:3 = 4)
                'byte 1 = DATA0LOW byte 2 = DATA0HIGH byte 3 = DATA1LOW byte 4 = DATA1 HIGH 
                Dim MSB As Integer = buf_process(2)
                Dim LSB As Integer = buf_process(3)
                Dim MSB_and_LSB = (MSB << 8) + LSB
                Dim humidity As Integer

                humidity = -6 + 125 * (MSB_and_LSB / 65536)

                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & humidity & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
            Case "15" 'if sensor is accelerometer sensor

                Dim x_MSB As Byte = buf_process(2)
                Dim x_LSB As Byte = buf_process(3)
                Dim y_MSB As Byte = buf_process(4)
                Dim y_LSB As Byte = buf_process(5)
                Dim z_MSB As Byte = buf_process(6)
                Dim z_LSB As Byte = buf_process(7)
                Dim x_MSB_and_LSB As Integer = (x_MSB * 255) + x_LSB
                Dim y_MSB_and_LSB As Integer = (y_MSB * 255) + y_LSB
                Dim z_MSB_and_LSB As Integer = (z_MSB * 255) + z_LSB

                'perform 2s complement
                If (x_MSB_and_LSB <= 65535) And (x_MSB_and_LSB >= 32768) Then
                    x_MSB_and_LSB = -((Not x_MSB) * 255) + (Not x_LSB) + 1
                End If

                If (y_MSB_and_LSB <= 65535) And (y_MSB_and_LSB >= 32768) Then
                    y_MSB_and_LSB = -((Not y_MSB) * 255) + (Not y_LSB) + 1
                End If

                If (z_MSB_and_LSB <= 65535) And (z_MSB_and_LSB >= 32768) Then
                    z_MSB_and_LSB = -((Not z_MSB) * 255) + (Not z_LSB) + 1
                End If

                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & "1" & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
            Case "19" 'if sensor is noise sensor
                Dim noise_data As Integer = buf_process(2)
                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & noise_data & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
            Case "20" 'if sensor is electricity sensor

                Dim x_MSB As Byte = buf_process(2)
                Dim x_LSB As Byte = buf_process(3)
                Dim x_MSB_and_LSB As Integer = (x_MSB * 176) + x_LSB
                Dim batt_perc As Integer = buf_process(6)
                Dim watts As Double

                'perform 2s complement
                x_MSB_and_LSB = (x_MSB_and_LSB >> 4)
                If (x_MSB_and_LSB <= 4096) And (x_MSB_and_LSB >= 2048) Then
                    x_MSB_and_LSB = -((Not x_MSB) * 176) + (Not x_LSB) + 1
                End If

                If x_MSB_and_LSB < 95 Then
                    watts = 0
                Else
                    watts = x_MSB_and_LSB * 15.385
                End If
                'result 91 when nothing connected
                'result 125 when ambient monitoring of house
                'result 255 with 2kW load
                '12 bit ADC referenced to 1.24V therefore (255-125)/2000 = 15.385watts per bit

                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & watts & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

                'insert battery percentage to database
                dbcommand = "UPDATE t_node_hw SET d_batt_perc='" & batt_perc & "' WHERE d_serialno = '" & sensor_serial & "';"
                Call Database_functions.database_remove_single_row(dbcommand)


            Case "23" 'if sensor is on off temp sensor
                Dim MSB As Integer = buf_process(2)
                Dim LSB As Integer = buf_process(3)
                Dim MSB_and_LSB = (MSB << 8) + LSB
                Dim temperature As Integer

                temperature = -46.85 + 175.72 * (MSB_and_LSB / 65536)
                'Datasheet HTU21D(F) October 2013 algorithm on page 15
                milliseconds = timeStamp.Millisecond

                timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
                dbdata = timestamp_str
                'message = serial_no_int & data_int

                dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & sensor_serial & "','" & temperature & "','" & milliseconds & "',DEFAULT,DEFAULT);"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        End Select

invalid:
    End Sub


    Private Sub ReceivedText(ByVal [text] As Integer)

        received_dat = [text]
        byte_array(byte_count) = received_dat
        byte_count += 1

    End Sub
    'Serial Port Receiving Code(Invoke) Ends Here ….

    'Com Port Change Warning Code Starts Here ….
    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
    'Com Port Change Warning Code Ends Here ….

    'Baud Rate Change Warning Code Starts Here ….
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        USER_GUI.Show()
    End Sub

    Private Sub ObjectDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
'Whole Code Ends Here ….
