Imports System.Data
Imports System.IO

Public Class Dictionary
    Private stdHeader() As Byte = {0, 1, 0, 0, 83, 116, 97, 110, 100, 97, 114, 100, 32, 65, 67, 69, 32, 68, 66, 0, 2, 0, 0, 0, 181, 110, 3, 98, 96, 9, 194, 85, 233, 169, 103, 114, 64, 63, 0, 156, 126, 159, 144, 255, 133, 154, 49, 197, 121, 186, 237, 48, 188, 223, 204, 157, 99, 217, 228, 195, 159, 70, 251, 138, 188, 78}
    Private m_Path As String = ""
    Dim m_conn As OleDb.OleDbConnection = Nothing
    Private m_tblSystem As New DataTable("System")
    Private m_tblVocabulary As New DataTable("Vocabulary")

    Public Function IsDecryptedDictionary() As Boolean
        If (Path Is Nothing) Then
            Return False
        End If
        '
        If (Path.Length <= 0) Then
            Return False
        End If
        '
        Dim dicFile As FileStream = Nothing
        Try
            dicFile = New FileStream(Path, FileMode.Open, FileAccess.Read)
        Catch
            dicFile = Nothing
        End Try
        If (dicFile Is Nothing) Then
            Return False
        End If
        '
        Dim reader As BinaryReader
        Try
            reader = New BinaryReader(dicFile)
        Catch ex As Exception
            reader = Nothing
        End Try
        '
        If (reader Is Nothing) Then
            dicFile.Close()
            Return False
        End If
        '
        Dim dicHeader() As Byte = reader.ReadBytes(stdHeader.Length)
        If (dicHeader.Length <= 0) Then
            reader.Close()
            dicFile.Close()
            Return False
        End If
        '
        If (dicHeader.Length <> stdHeader.Length) Then
            reader.Close()
            dicFile.Close()
            Return False
        End If
        '
        For i As Integer = 0 To stdHeader.Length - 1
            If (dicHeader(i) <> stdHeader(i)) Then
                reader.Close()
                dicFile.Close()
                Return False
            End If
        Next i
        '
        reader.Close()
        dicFile.Close()
        Return True
    End Function

    Public Function EncryptDictionary() As Boolean
        If (Path Is Nothing) Then
            Return False
        End If
        '
        If (Path.Length <= 0) Then
            Return False
        End If
        '
        Dim dicFile As FileStream = Nothing
        Try
            dicFile = New FileStream(Path, FileMode.Open, FileAccess.Write)
        Catch
            dicFile = Nothing
        End Try
        If (dicFile Is Nothing) Then
            Return False
        End If
        '
        Dim writer As BinaryWriter
        Try
            writer = New BinaryWriter(dicFile)
        Catch ex As Exception
            writer = Nothing
        End Try
        '
        If (writer Is Nothing) Then
            Return False
        End If
        '
        Dim dicHeader(stdHeader.Length) As Byte
        For i As Integer = 0 To stdHeader.Length - 1
            dicHeader(i) = stdHeader(i) Xor 183
        Next
        writer.Write(dicHeader)
        writer.Close()
        dicFile.Close()
        '
        Return True
    End Function

    Public Function DecryptDictionary() As Boolean
        If (Path Is Nothing) Then
            Return False
        End If
        '
        If (Path.Length <= 0) Then
            Return False
        End If
        '
        Dim dicFile As FileStream = Nothing
        Try
            dicFile = New FileStream(Path, FileMode.Open, FileAccess.Write)
        Catch ex As Exception
            dicFile = Nothing
        End Try
        If (dicFile Is Nothing) Then
            Return False
        End If
        '
        Dim writer As BinaryWriter
        Try
            writer = New BinaryWriter(dicFile)
        Catch ex As Exception
            writer = Nothing
        End Try
        '
        If (writer Is Nothing) Then
            Return False
        End If
        '
        writer.Write(stdHeader)
        writer.Close()
        dicFile.Close()
        '
        Return True
    End Function

    Public Property Path
        Set(value)
            If (Not m_conn Is Nothing) Then
                If (m_conn.State <> ConnectionState.Closed) Then
                    m_conn.Close()
                    m_tblSystem.Clear()
                    m_tblVocabulary.Clear()
                End If
            End If
            '
            m_Path = value
        End Set
        Get
            Return m_Path
        End Get
    End Property

    Private ReadOnly Property ConnString
        Get
            Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & m_Path
        End Get
    End Property

    Public Sub New(ByVal strPath As String)
        m_Path = strPath
    End Sub

    Public Sub New()
        m_Path = ""
    End Sub

    Public Function Open(Optional ByVal Password As String = Nothing) As Boolean
        If (Not m_conn Is Nothing) Then
            Return True
        End If
        Try
            Dim strConn As String = ConnString
            If (Not Password Is Nothing) Then
                If (Password.Length > 0) Then
                    strConn = strConn & ";Persist Security Info=True;Jet OLEDB:Database Password=" & Password
                End If
            End If
            m_conn = New OleDb.OleDbConnection(strConn)
            m_conn.Open()
        Catch ex As Exception
            m_conn = Nothing
            Return False
        End Try
        Return True
    End Function

    Public Sub Close()
        If (m_conn Is Nothing) Then
            Return
        End If
        '
        If (m_conn.State <> ConnectionState.Closed) Then
            m_conn.Close()
        End If
        m_conn = Nothing
    End Sub

    Public Sub Load()
        Dim cmd As New OleDb.OleDbCommand()

        cmd.CommandText = "SELECT * FROM " & m_tblSystem.TableName
        cmd.Connection = m_conn
        m_tblSystem.Clear()
        m_tblSystem.Load(cmd.ExecuteReader())

        cmd.CommandText = "SELECT * FROM " & m_tblVocabulary.TableName
        cmd.Connection = m_conn
        m_tblVocabulary.Clear()
        m_tblVocabulary.Load(cmd.ExecuteReader())
    End Sub
End Class
