using DevExpress.Pdf;

namespace PDFPasswordProtection {
    class Program {
        static void Main(string[] args) {

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
                encryptionOptions.OwnerPasswordString = "OwnerPassword";
                encryptionOptions.UserPasswordString = "UserPassword";

                // Specify the 256-bit AES encryption algorithm.
                encryptionOptions.Algorithm = PdfEncryptionAlgorithm.AES256;

                // Save the protected document with encryption settings.  
                pdfDocumentProcessor.SaveDocument("..\\..\\ProtectedDocument.pdf", new PdfSaveOptions() { EncryptionOptions = encryptionOptions });
            }
        }
    }
}

