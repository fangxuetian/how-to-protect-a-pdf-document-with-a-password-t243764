Imports DevExpress.Pdf
Imports System.Security

Namespace PDFPasswordProtection
    Friend Class Program
        Shared Sub Main(ByVal args() As String)
            Const ownerPasswordText As String = "OwnerPassword"
            Const userPasswordText As String = "UserPassword"

            Using pdfDocumentProcessor As New PdfDocumentProcessor()

                ' Load a PDF document.
                pdfDocumentProcessor.LoadDocument("..\..\Demo.pdf")

                ' Specify printing, data extraction, modification, and interactivity permissions. 
                Dim encryptionOptions As New PdfEncryptionOptions()
                encryptionOptions.PrintingPermissions = PdfDocumentPrintingPermissions.Allowed
                encryptionOptions.DataExtractionPermissions = PdfDocumentDataExtractionPermissions.NotAllowed
                encryptionOptions.ModificationPermissions = PdfDocumentModificationPermissions.DocumentAssembling
                encryptionOptions.InteractivityPermissions = PdfDocumentInteractivityPermissions.Allowed

                ' Specify the owner and user passwords for the document.  
                encryptionOptions.OwnerPassword = EncryptPassword(ownerPasswordText)
                encryptionOptions.UserPassword = EncryptPassword(userPasswordText)

                ' Save the protected document with encryption settings.  
                pdfDocumentProcessor.SaveDocument("..\..\ProtectedDocument.pdf", New PdfSaveOptions() With {.EncryptionOptions = encryptionOptions})
            End Using
        End Sub

        Private Shared Function EncryptPassword(ByVal passwordText As String) As SecureString
            Dim password As New SecureString()
            For Each c As Char In passwordText
                password.AppendChar(c)
            Next c
            Return password
        End Function
    End Class
End Namespace

