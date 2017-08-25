Imports System.Data

Public Class Dictionary
    Private m_Path As String = ""
    Dim m_conn As OleDb.OleDbConnection = Nothing
    Dim m_tblSystem As New DataTable("System")
    Dim m_tblVocabulary As New DataTable("Vocabulary")

    Public ReadOnly Property Path
        Get
            Return m_Path
        End Get
    End Property

    Private ReadOnly Property ConnString
        Get
            Return "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" & m_Path
        End Get
    End Property

    Public Sub New(ByVal strPath As String)
        m_Path = strPath
    End Sub

    Public Function Open() As Boolean
        If (Not m_conn Is Nothing) Then
            Return True
        End If
        Try
            m_conn = New OleDb.OleDbConnection(ConnString)
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
