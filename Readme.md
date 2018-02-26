# How to protect a PDF document with a password


This example shows how a PDF document can be protected using both the owner and user passwords.<br><br>A user password is used to protect opening a document. After a document is opened with the user password, a user has access to the document with the specified permissions.<br><br>To get full access to the document (permissions are not taken into account in this case), this document must be opened with the owner password.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information. <br><br><br> 
<p> </p>


<h3>Description</h3>

To accomplish this task, do the following: <br><br>Create a PDF document processor.<br>&nbsp;Load a PDF file from a file using the <strong>PdfDocumentProcessor.LoadDocument</strong> method.<br>To access the PDF&nbsp;encryption options, create a <strong>PdfEncryptionOptions</strong> object using the<strong> PdfSaveOptions.EncryptionOptions</strong> property.&nbsp;<br>To specify the owner password and, if necessary, the user password use the <strong>PdfEncryptionOptions.OwnerPassword</strong> and <strong>PdfEncryptionOptions.UserPassword</strong> properties.&nbsp;
<p>In addition,&nbsp; you can specify the following printing permissions using the <strong>PdfEncryptionOptions.PrintingPermissions</strong> property: Allowed, LowQuality and NotAllowed.</p>
<p>To specify data extraction permission, use the <strong>PdfEncryptionOptions.DataExtractionPermissions</strong>. The available values are: Allowed, Accessibility and NotAllowed.</p>
<p>To specify modification permission, use the <strong>PdfEncryptionOptions.ModificationPermissions</strong> property. The available values are: Allowed, DocumentAssembling and NotAllowed.</p>
<p>The interactivity permission can be specified using the <strong>PdfEncryptionOptions.InteractivityPermissions</strong> property. The following values are supported: Allowed, FormFillingAndSigning and NowAllowed.</p>
<p>The final step is to&nbsp;save document with permission settings and a user and owner passwords. To do this,&nbsp; call the <strong>PdfDocumentProcessor.SaveDocument&nbsp;</strong>method with a file name and encryption options.</p>

<br/>


