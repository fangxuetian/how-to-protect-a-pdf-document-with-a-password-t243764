using DevExpress.Pdf;
using System.Security;

namespace PDFPasswordProtection {
    class Program {
        static void Main(string[] args) {
            const string ownerPasswordText = "OwnerPassword";
            const string userPasswordText = "UserPassword";

            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor()) {

                // Load a PDF document.
                pdfDocumentProcessor.LoadDocument("..\\..\\Demo.pdf");

                // Specify printing, data extraction, modification, and interactivity permissions. 
                PdfEncryptionOptions encryptionOptions = new PdfEncryptionOptions();
                encryptionOptions.PrintingPermissions = PdfDocumentPrintingPermissions.Allowed;
                encryptionOptions.DataExtractionPermissions = PdfDocumentDataExtractionPermissions.NotAllowed;
                encryptionOptions.ModificationPermissions = PdfDocumentModificationPermissions.DocumentAssembling;
                encryptionOptions.InteractivityPermissions = PdfDocumentInteractivityPermissions.Allowed;
                
                // Specify the owner and user passwords for the document.  
                encryptionOptions.OwnerPassword = EncryptPassword(ownerPasswordText);
                encryptionOptions.UserPassword = EncryptPassword(userPasswordText);

                // Save the protected document with encryption settings.  
                pdfDocumentProcessor.SaveDocument("..\\..\\ProtectedDocument.pdf", new PdfSaveOptions() { EncryptionOptions = encryptionOptions });
            }
        }

        static SecureString EncryptPassword(string passwordText) {
            SecureString password = new SecureString();
            foreach (char c in passwordText)
                password.AppendChar(c);
            return password;
        }
    }
}

