Module connection
    Public adapter As OleDb.OleDbDataAdapter
    Public conn As New OleDb.OleDbConnection
    Public dataset As New DataSet
    Public dir As String = My.Application.Info.DirectoryPath

    Public Function connect() As Boolean
        Dim con_string As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source=" + dir + "\tuckshop.mdb"
        If conn.State = ConnectionState.Open Then
            Return True
            'ok
        Else
            Try
                conn.ConnectionString = con_string
                conn.Open()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
    End Function
    Public Function disconnect()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Return True
    End Function
    Public Function query(statement As String)
        Try
            If conn.State = ConnectionState.Closed Or conn.State = ConnectionState.Broken Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand
            With cmd
                .CommandText = statement
                .Connection = conn
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function querySelect(statement As String, table As String)
        Try
            If conn.State = ConnectionState.Closed Or conn.State = ConnectionState.Broken Then
                conn.Open()
            End If
            dataset.Clear()
            adapter = New OleDb.OleDbDataAdapter(statement, conn)
            adapter.Fill(dataset, table)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function LAST_INSERT_ID()
        Try
            If conn.State = ConnectionState.Closed Or conn.State = ConnectionState.Broken Then
                conn.Open()
            End If
            Dim cmd As OleDb.OleDbCommand = conn.CreateCommand()
            cmd.CommandText = "SELECT @@IDENTITY"
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            Return vbNull
        End Try
    End Function
End Module
