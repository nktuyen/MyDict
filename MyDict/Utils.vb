Imports System.IO


Module Utils
    Private stdHeader() As Byte = {0, 1, 0, 0, 83, 116, 97, 110, 100, 97, 114, 100, 32, 65, 67, 69, 32, 68, 66, 0, 2, 0, 0, 0, 181, 110, 3, 98, 96, 9, 194, 85, 233, 169, 103, 114, 64, 63, 0, 156, 126, 159, 144, 255, 133, 154, 49, 197, 121, 186, 237, 48, 188, 223, 204, 157, 99, 217, 228, 195, 159, 70, 251, 138, 188, 78}

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

    Public Function StdDatabaseHeader(ByVal strPath1 As String, ByVal strPath2 As String) As Integer
        If (strPath1 Is Nothing) Or (strPath2 Is Nothing) Then
            Return 0
        End If
        '
        If (strPath1.Length <= 0) Or (strPath2.Length <= 0) Then
            Return 0
        End If
        '
        Dim res As Integer = 0
        Dim str As String = ""
        Try
            Dim data1() As Byte = File.ReadAllBytes(strPath1)
            Dim data2() As Byte = File.ReadAllBytes(strPath2)
            Dim nMax As Integer = IIf(data1.Length > data2.Length, data2.Length, data1.Length)

            str = "{"
            For res = 0 To nMax - 1
                If (data1(res) <> data2(res)) Then
                    Exit For
                End If
                str = str & data1(res)
                str = str & ","
            Next
        Catch ex As Exception

        End Try

        str = str & "}"
        Debug.Print(str)
        Return res
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
        Dim dicFile As FileStream = Nothing
        Try
            dicFile = New FileStream(strPath, FileMode.Open, FileAccess.Write)
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

    Public Function DecryptDictionary(ByVal strPath As String) As Boolean
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
            dicFile = New FileStream(strPath, FileMode.Open, FileAccess.Write)
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
End Module
