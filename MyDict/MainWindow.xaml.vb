Class MainWindow
    Private m_bPlaceHolderKeyword As Boolean = False
    Private m_EV As New Dictionary("EV.accdb")

    Private Function ViewVocabulary(ByVal strVocabulary As String) As Boolean
        Return False
    End Function

    Private Sub GridSplitter_DragCompleted(sender As Object, e As Primitives.DragCompletedEventArgs)
    End Sub

    Private Sub btnNext_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnNext.MouseLeftButtonUp

    End Sub

    Private Sub btnPrev_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnPrev.MouseLeftButtonUp

    End Sub

    Private Sub cboFilter_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cboFilter.SelectionChanged
        Dim strVocabulary As String = ""
        If (lstWords.SelectedItem Is Nothing) Then
            Return
        End If
        strVocabulary = CStr(lstWords.SelectedItem)
        m_bPlaceHolderKeyword = False
        txtKeyword.Text = strVocabulary
        Call ViewVocabulary(strVocabulary)
    End Sub

    Private Sub txtKeyword_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtKeyword.TextChanged

    End Sub

    Private Sub btnAdd_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnAdd.MouseLeftButtonUp

    End Sub

    Private Sub btnDelete_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnDelete.MouseLeftButtonUp

    End Sub

    Private Sub btnPrint_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnPrint.MouseLeftButtonUp

    End Sub

    Private Sub btnEdit_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnEdit.MouseLeftButtonUp

    End Sub

    Private Sub btnSettings_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles btnSettings.MouseLeftButtonUp

    End Sub

    Private Sub wndMain_Closed(sender As Object, e As EventArgs) Handles wndMain.Closed
        m_EV.Close()
        If (IsDecryptedDictionary("EV.accdb")) Then
            Call EncryptDictionary("EV.accdb")
        End If
    End Sub

    Private Sub wndMain_Loaded(sender As Object, e As RoutedEventArgs) Handles wndMain.Loaded
        If (Not IsDecryptedDictionary("EV.accdb")) Then
            Call DecryptDictionary("EV.accdb")
        End If
        m_EV.Open()
    End Sub

    Private Sub txtKeyword_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtKeyword.GotFocus
        If (m_bPlaceHolderKeyword) Then
            m_bPlaceHolderKeyword = False
            txtKeyword.Text = ""
        Else
            txtKeyword.SelectAll()
        End If
    End Sub

    Private Sub txtKeyword_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtKeyword.LostFocus
        If (txtKeyword.Text.Length <= 0) Then
            txtKeyword.Text = "Nhập vào từ khóa..."
            m_bPlaceHolderKeyword = True
        End If
    End Sub
End Class
