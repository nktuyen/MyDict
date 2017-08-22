Imports System.IO


Module Utils
    Private stdHeader() As Byte = {0, 1, 0, 0, 83, 116, 97, 110, 100, 97, 114, 100, 32, 65, 67, 69, 32, 68, 66, 0, 2, 0, 0, 0, 181, 110, 3, 98, 96, 9, 194, 85}

    Public Function IsDecryptedDictionary(ByVal strPath As String) As Boolean
        If (strPath Is Nothing) Then
            Return False
        End If
        '
        If (strPath.Length <= 0) Then
            Return False
        End If
        '
        Dim dicFile As FileStream = Nothing
        Try
            dicFile = New FileStream(strPath, FileMode.Open, FileAccess.Read)
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
            Return False
        End If
        '
        Dim dicHeader() As Byte = reader.ReadBytes(stdHeader.Length)
        If (dicHeader.Length <= 0) Then
            Return False
        End If
        '
        If (dicHeader.Length <> stdHeader.Length) Then
            Return False
        End If
        '
        For i As Integer = 0 To stdHeader.Length - 1
            If (dicHeader(i) <> stdHeader(i)) Then
                Return False
            End If
        Next i
        '
        reader.Close()
        dicFile.Close()
        Return True
    End Function

    Public Function EncryptDictionary(ByVal strPath As String) As Boolean
        If (strPath Is Nothing) Then
            Return False
        End If
        '
        If (strPath.Length <= 0) Then
            Return False
        End If
        '

    End Function

    Public Function DecryptDictionary(ByVal strPath As String) As Boolean
        If (strPath Is Nothing) Then
            Return False
        End If
        '
        If (strPath.Length <= 0) Then
            Return False
        End If
        '

    End Function
End Module
