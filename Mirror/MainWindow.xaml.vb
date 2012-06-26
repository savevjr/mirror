﻿Class MainWindow 

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim vb = New Core.StringBuild.VBStringBuilder
        AssBrowser.Items.Add(New Core.Element(Me.GetType.Assembly, vb))
        For Each asse In Me.GetType.Assembly.GetReferencedAssemblies()
            AssBrowser.Items.Add(New Core.Element(Reflection.Assembly.Load(asse.FullName), vb))
        Next
    End Sub
End Class
