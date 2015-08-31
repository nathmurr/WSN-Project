Imports MySql.Data.MySqlClient

Public Class Database_functions

    Public dr As MySqlDataReader       'object which mysql uses to put retrieved values
    Dim dt As New DataTable         'table created to store values from mysql
    Dim dr2 As MySqlDataReader       'object which mysql uses to put retrieved values
    Dim dt2 As New DataTable         'table created to store values from mysql
    Dim db_conn_str As String
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
    Dim cmd As New MySqlCommand             'defined to build mysql command 


    Public Shared Sub database_insert_single_column(ByVal dbcommand As String, ByVal dbpointer As String, ByVal dbdata As String)

        Dim db_conn_str As String
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 

        db_conn_str = "server=localhost;" _
                           & "uid=root;" _
                           & "pwd=root;" _
                           & "database=wsn_network;"

        Try
            conn.ConnectionString = db_conn_str      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = dbcommand  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            cmd.Parameters.AddWithValue(dbpointer, dbdata)
            cmd.ExecuteNonQuery()           'execute mysql command

        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

    End Sub

    Public Shared Function database_row_numbers(ByVal dbcommand As String) As Integer

        Dim db_conn_str As String
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 
        Dim rownum As Object
        Dim rownumber As Integer
        Dim rowcount As Integer
        db_conn_str = "server=localhost;" _
                           & "uid=root;" _
                           & "pwd=root;" _
                           & "database=wsn_network;"

        Try
            conn.ConnectionString = db_conn_str      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = dbcommand  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            'Dim rowCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            rownum = cmd.ExecuteScalar()
            rownumber = Val(rownum)

        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

        Return rownumber
    End Function
    Public Shared Sub transfer_received_data(ByVal tr_timestamp As DateTime, ByVal tr_serial As Integer, tr_sensdata As Integer, tr_ms As Integer)

        Dim db_conn_str As String
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 
        Dim rownum As Object
        Dim rownumber As Integer
        Dim rowcount As Integer
        Dim timestamp As String
        Dim dbcommand As String
        Dim dbpointer As String
        Dim dbdata As String
        timestamp = tr_timestamp.ToString("yyyy-MM-dd HH:mm:ss")

        db_conn_str = "server=localhost;" _
                           & "uid=root;" _
                           & "pwd=root;" _
                           & "database=wsn_network;"

        Try
            conn.ConnectionString = db_conn_str      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = "DELETE FROM sensor_received_data WHERE d_timestamp='" & timestamp & "' AND d_milliseconds='" & tr_ms & "';"
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            'Dim rowCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            rownum = cmd.ExecuteScalar()
            rownumber = Val(rownum)
        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'add to sensor_received_data_history
        Try
            'conn.ConnectionString = db_conn_str      'build connectionstring
            'conn.Open()                                     'open database connection
            'cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = "INSERT INTO sensor_received_data_history (d_timestamp,d_sensor_serial,d_sensor_data,d_milliseconds) VALUES('" & timestamp & "','" & tr_serial & "','" & tr_sensdata & "','" & tr_ms & "');"
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            'Dim rowCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            rownum = cmd.ExecuteScalar()
            rownumber = Val(rownum)


        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try


    End Sub
    Public Shared Sub database_insert_man_location(ByVal dbcommand As String)

        Dim db_conn_str As String
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 

        db_conn_str = "server=localhost;" _
                           & "uid=root;" _
                           & "pwd=root;" _
                           & "database=wsn_network;"

        Try
            conn.ConnectionString = db_conn_str      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = dbcommand  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            cmd.ExecuteNonQuery()           'execute mysql command

        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

    End Sub
    
    Public Shared Sub database_update(ByVal dbcommand As String)

        Dim db_conn_str As String
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 

        db_conn_str = "server=localhost;" _
                           & "uid=root;" _
                           & "pwd=root;" _
                           & "database=wsn_network;"

        Try
            conn.ConnectionString = db_conn_str      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = dbcommand  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            'cmd.Parameters.AddWithValue(dbpointer, dbdata)
            cmd.ExecuteNonQuery()           'execute mysql command

        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

    End Sub
    Public Shared Function database_getall_single_column(ByVal dbcommand As String) As DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection 'define mysql connection
        Dim cmd As New MySqlCommand     'defined to build mysql command
        Dim dr As MySqlDataReader       'object which mysql uses to put retrieved values
        Dim dt As New DataTable         'table created to store values from mysql
        Dim db_conn_str As String

        db_conn_str = "server=localhost;" _
                          & "uid=root;" _
                          & "pwd=root;" _
                          & "database=wsn_network;"

        Try             'connect to database
            conn.ConnectionString = db_conn_str
            conn.Open()
            cmd.Connection = conn
        Catch ex As Exception
        End Try

        cmd.CommandText = dbcommand
        dr = cmd.ExecuteReader()
        dt.Load(dr)

        Try     'close database connection
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try

        Return dt

    End Function

    Public Shared Sub database_remove_single_row(ByVal dbcommand As String)

        Dim db_conn_str As String
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 

        db_conn_str = "server=localhost;" _
                           & "uid=root;" _
                           & "pwd=root;" _
                           & "database=wsn_network;"

        Try
            conn.ConnectionString = db_conn_str      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = dbcommand  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            cmd.ExecuteNonQuery()           'execute mysql command

        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

    End Sub

End Class
