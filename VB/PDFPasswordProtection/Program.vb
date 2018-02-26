Imports DevExpress.Pdf

Namespace PDFPasswordProtection
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

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
                encryptionOptions.OwnerPasswordString = "OwnerPassword"
                encryptionOptions.UserPasswordString = "UserPassword"

                ' Specify the 256-bit AES encryption algorithm.
                encryptionOptions.Algorithm = PdfEncryptionAlgorithm.AES256

                ' Save the protected document with encryption settings.  
                pdfDocumentProcessor.SaveDocument("..\..\ProtectedDocument.pdf", New PdfSaveOptions() With {.EncryptionOptions = encryptionOptions})
            End Using
        End Sub
    End Class
End Namespace

