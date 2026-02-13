<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598055/20.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4631)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml.vb))**
* [MyDocumentPreviewControl.cs](./CS/MinimalisticReportPreviewDemo/MyDocumentPreviewControl.cs) (VB: [MyDocumentPreviewControl.vb](./VB/MinimalisticReportPreviewDemo/MyDocumentPreviewControl.vb))
<!-- default file list end -->
# DocumentPreviewControl - How to override the Print and PrintDirect (Quick Print) commands


This example demonstrates how to override commands in the [Document Preview](https://docs.devexpress.com/WPF/9697/controls-and-libraries/printing-exporting/concepts/document-preview). 
Create a [DocumentPreviewControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl) descendant and override the corresponding methods, e.g., Print and PrintDirect.

For example:
```cs
public class MyDocumentPreviewControl : DocumentPreviewControl {
    public override void Print() {
        PrintTool pt = new PrintTool(Document.PrintingSystem);
        pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
        pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
        pt.PrintDialog();
    }
    public override void PrintDirect(string printerName = null) {
        PrintTool pt = new PrintTool(Document.PrintingSystem);
        pt.PrintingSystem.StartPrint += new PrintDocumentEventHandler(PrintingSystem_StartPrint);
        pt.PrintingSystem.PrintProgress += new PrintProgressEventHandler(PrintingSystem_PrintProgress);
        pt.Print();
    }
    void PrintingSystem_PrintProgress(object sender, PrintProgressEventArgs e) {

    }
    void PrintingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
    
    }
}
```

See also: [DocumentPreviewControl - How to override the Export command](https://github.com/DevExpress-Examples/Reporting_documentpreviewcontrol-how-to-override-the-export-command-e4482)

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-override-print-commands&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-override-print-commands&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
