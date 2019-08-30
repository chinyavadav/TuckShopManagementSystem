Module DBConnection
    Public con As New OleDb.OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; Data Source=" + dir + "\tuckshop.mdb")
    Public cmd As New OleDb.OleDbCommand("", con)
    Public MyAdapter As New OleDb.OleDbDataAdapter
    Public Table As New DataTable
End Module
