Imports System.IO
Imports Microsoft.Win32

Module Utils

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

    Public Function GetApplicationRegistryPath(Optional ByVal Company As String = "Tuyen", Optional ByVal AppName As String = "MyDict") As String
        Dim strCompany As String = Company
        Dim strAppname As String = AppName
        Dim strPath As String = Registry.CurrentUser.Name
        Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        If (Not assembly Is Nothing) Then
            Dim fileInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location)
            strCompany = fileInfo.CompanyName
            strAppname = fileInfo.ProductName
        End If
        '
        strPath = strPath & "\SOFTWARE\" & strCompany & "\" & strAppname
        Return strPath
    End Function

    Public Function GetDatabaseRecentPath(ByVal AppKey As String, ByVal ValueName As String) As String
        Dim strCompany As String = "Tuyen"
        Dim strAppname As String = "MyDict"
        Dim strPath As String = Directory.GetCurrentDirectory()
        Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        If (Not assembly Is Nothing) Then
            Dim fileInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location)
            strCompany = fileInfo.CompanyName
            strAppname = fileInfo.ProductName
            strPath = System.IO.Path.GetDirectoryName(assembly.Location)
        End If
        '
        strPath = strPath & "\" & strAppname & ".dic"
        Try
            Dim strTemp As String = My.Computer.Registry.GetValue(AppKey, ValueName, Nothing)
            If (Not strTemp Is Nothing) Then
                strPath = strTemp
            End If
        Catch ex As Exception
            '
        End Try
        Return strPath
    End Function

    Public Function SaveDatabaseRecentPath(ByVal AppKey As String, ByVal ValueName As String, ByVal strPath As String) As Boolean
        If (strPath Is Nothing) Then
            Return False
        End If
        '
        Try
            Call My.Computer.Registry.SetValue(AppKey, ValueName, strPath)
        Catch ex As Exception
            Return False
        End Try
        '
        Return True
    End Function
End Module
