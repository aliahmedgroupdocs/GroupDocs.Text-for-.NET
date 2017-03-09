﻿Module Module1

    Sub Main()

        'Un-comment to apply license 
        Common.ApplyLicense()

#Region "TextExtractors"

        'Extracting email attachments
        'DocumentTextExtractor.EmailsExtractor.ExtractEmailAttachments("The butterfly effect.msg")

        'Extracting onenote text
        'DocumentTextExtractor.OneNoteDocument.ExtractOneNoteDocument("The butterfly effect.one")

        'Opening password protected one note sections
        'DocumentTextExtractor.OneNoteDocument.OpenPasswordProtectedOneNoteSection("password protected note.one")

        'Extracting pdf text
        'DocumentTextExtractor.PdfDocument.ExtractPdfDocument("The butterfly effect.pdf")

        'Extracting slides text
        'DocumentTextExtractor.PresentationDocument.ExtractPresentationDocument("The butterfly effect.pptx")

        'Extracting the entire sheet
        'DocumentTextExtractor.SpreadsheetDocument.ExtractEntireSheet("The butterfly effect.xlsx")
        'Extracting the sheet by the rows
        'DocumentTextExtractor.SpreadsheetDocument.ExtractSheetByRows("The butterfly effect.xlsx")
        'Extracting the selected columns
        'DocumentTextExtractor.SpreadsheetDocument.ExtractSelectedColumns("The butterfly effect.xlsx")
        'Extracting selected rows and columns
        'DocumentTextExtractor.SpreadsheetDocument.ExtractSelectedColumnsAndRows("The butterfly effect.xlsx") 

        'Extracting text from word page (formatted)
        'DocumentTextExtractor.TextDocument.ExtractEntireWordPage("The butterfly effect.docx")
        'Extracting formatted/tabled text from word
        'DocumentTextExtractor.TextDocument.FormattingTable("The butterfly effect.docx")
        'Extracting text with markdown text format, at the moment bullets are supported
        'DocumentTextExtractor.TextDocument.ExtractingWithMarkdown("The butterfly effect.docx")
        'Extracting text with html text format
        'DocumentTextExtractor.TextDocument.HtmlTextFormating("The butterfly effect.docx")

        'Extracting text from epub file(feature supported by version 17.02 or greater)
        'Extracts a line of characters from epub document
        'DocumentTextExtractor.Epub.ExtractALine("sample.epub")
        'Extracts all characters from epub document
        'DocumentTextExtractor.Epub.ExtractAllCharacters("sample.epub")

#End Region

#Region "MetadataExtractors"
        'Extracting metadata from cells
        'MetaDataExtractor.CellsMetadata.ExtractMetadataFromCells("The butterfly effect.xlsx")
        'Extracting metadata from slides
        'MetaDataExtractor.SlidesMetadata.ExtractMetadataFromSlides("The butterfly effect.pptx")
        'Extracting metadata from words
        'MetaDataExtractor.WordsMetaData.ExtractMetadataFromWords("The butterfly effect.docx")
        'Extracting metadata from pdf documents
        'MetaDataExtractor.PdfMetaData.ExtractMetadataFromPdf("The butterfly effect.pdf")
        'Extracting metadata from emails
        'MetaDataExtractor.EmailMetaData.ExtractMetadataFromEmails("The butterfly effect.msg")
        'Extract metadata of any supported file formatted document using extractor factory
        'MetaDataExtractor.UsingExtractorFactory("The butterfly effect.pptx")
#End Region

#Region "ContainerExtractor"
        'Extracting from OST
        'ContainerExtractor.ExtractFromOstContainer()
        'Enumerating all entities 
        'ContainerExtractor.EnumeratingAllEntities()
        'Enumerate all files in archive folder
        'ContainerExtractor.EnumerateAllArchivedFiles("zipcontainer.zip")
        'Read concrete file in a zip archive
        'ContainerExtractor.ReadConcreteFile("zipcontainer.zip")
#End Region

#Region "OtherOperations"
        'Creating a concrete extractor
        'DocumentTextExtractor.SpreadsheetDocument.ConcreteExtractor("The butterfly effect.xlsx")
        'Extract all
        'OtherOperations.ExtractAllFromCells("The butterfly effect.xlsx")
        'Pass media type and encoding to the created extractor
        'DocumentTextExtractor.PassEncodingToCreatedExtractor("The butterfly effect.xlsx")
        'Extracting Password protected documents
        'DocumentTextExtractor.PasswordProtectedDocumentExtractor("Password protected document.docx")
        'Creates a container from a file or stream
        'DocumentTextExtractor.CreatingContainerUsingExtractorFactory("The butterfly effect.xlsx")
        'Extract highlights  from documents
        'DocumentTextExtractor.ExtractHighlight("doc with highlighted text.docx")
        'DocumentTextExtractor.ExtractHighlightWithLimitedWordsCount("doc with highlighted text.docx",5)
        'DocumentTextExtractor.ExtractHighlightTillStartOrEndOfLine("doc with highlighted text.docx")
        'Search text in a document
        'DocumentTextExtractor.SearchTextInDocuments("The butterfly effect.docx")
        'Search whole word in documents
        'DocumentTextExtractor.SearchWholeWord("The butterfly effect.docx")
        'Use all highlight extraction modes with search functionality
        'DocumentTextExtractor.UseExtractionModesWithSearch("doc with highlighted text.docx")

#End Region


#Region "BusinessCases"
        'count the statistic of word's occurrences in the document
        'WordStatistic.FindMaxWordLength("The butterfly effect.xlsx", "The butterfly effect.pptx")
        'view the content of the file in Console
        'ExtractText.ViewContentInConsole("The butterfly effect.xlsx
        'Extract Password protected documents
        'DocumentTextExtractor.PasswordProtectedDocumentExtractor("Password protected document.docx")
#End Region


#Region "Tools"
        'Detecting encoding by BOM
        'Tools.EncodingDetection.ExtractEncodingByBOM("Encoding detection.txt")
        'Detecting encoding by BOM and the content (if BOM is not presented)
        'Tools.EncodingDetection.ExtractEncodingByContentAndBOM("Encoding detection.txt")
        'Implements INotificationReceiver for extractors and does amual exception handling, to test the notification provide an invalid file name or something that can throw an exception so that a message can be logged
        'Tools.logger.LoggerWithManualExceptionHandling("The butterfly effect.xlsx")
        'Implements INotificationReceiver for extractors. To test the notification provide an invalid file name or something that can throw an exception so that a message can be logged
        'Tools.logger.LoggerWithManualExceptionHandling("The butterfly effect.xlsx")
#End Region




        Console.ReadKey()

    End Sub

End Module
