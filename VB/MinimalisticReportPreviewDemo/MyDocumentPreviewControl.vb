Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraPrinting

Namespace DXSample

    Public Class MyDocumentPreviewControl
        Inherits DocumentPreviewControl

        Public Overrides Sub Print()
            Dim pt As PrintTool = New PrintTool(Document.PrintingSystem)
            AddHandler pt.PrintingSystem.StartPrint, New PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)
            AddHandler pt.PrintingSystem.PrintProgress, New PrintProgressEventHandler(AddressOf PrintingSystem_PrintProgress)
            pt.PrintDialog()
        End Sub

        Public Overrides Sub PrintDirect(ByVal Optional printerName As String = Nothing)
            Dim pt As PrintTool = New PrintTool(Document.PrintingSystem)
            AddHandler pt.PrintingSystem.StartPrint, New PrintDocumentEventHandler(AddressOf PrintingSystem_StartPrint)
            AddHandler pt.PrintingSystem.PrintProgress, New PrintProgressEventHandler(AddressOf PrintingSystem_PrintProgress)
            pt.Print()
        End Sub

        Private Sub PrintingSystem_PrintProgress(ByVal sender As Object, ByVal e As PrintProgressEventArgs)
        End Sub

        Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
        End Sub
    End Class
End Namespace
