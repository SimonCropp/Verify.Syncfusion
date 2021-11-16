# <img src="/src/icon.png" height="30px"> Verify.Aspose

[![Build status](https://ci.appveyor.com/api/projects/status/7k8hh0guut2ioak2?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Aspose)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Aspose.svg)](https://www.nuget.org/packages/Verify.Aspose/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of documents via [Aspose](https://www.aspose.com/).

Converts documents (pdf, docx, xslx, and pptx) to png for verification.

An [Aspose License](https://purchase.aspose.com/policies/license-types) is required to use this tool.

<a href='https://dotnetfoundation.org' alt='Part of the .NET Foundation'><img src='https://raw.githubusercontent.com/VerifyTests/Verify/master/docs/dotNetFoundation.svg' height='30px'></a><br>
Part of the <a href='https://dotnetfoundation.org' alt=''>.NET Foundation</a>


## NuGet package

https://nuget.org/packages/Verify.Aspose/


## Usage


### Enable Verify.Aspose

<!-- snippet: ModuleInitializer.cs -->
<a id='snippet-ModuleInitializer.cs'></a>
```cs
using VerifyTests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifySyncfusion.Initialize();
    }
}
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L1-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-ModuleInitializer.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### PDF


#### Verify a file

<!-- snippet: VerifyPdf -->
<a id='snippet-verifypdf'></a>
```cs
[Test]
public Task VerifyPdf()
{
    return Verifier.VerifyFile("sample.pdf");
}
```
<sup><a href='/src/Tests/Samples.cs#L8-L16' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifypdf' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Verify a Stream

<!-- snippet: VerifyPdfStream -->
<a id='snippet-verifypdfstream'></a>
```cs
[Test]
public Task VerifyPdfStream()
{
    return Verifier.Verify(File.OpenRead("sample.pdf"))
        .UseExtension("pdf");
}
```
<sup><a href='/src/Tests/Samples.cs#L25-L34' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifypdfstream' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Result

<!-- snippet: Samples.VerifyPdf.00.verified.txt -->
<a id='snippet-Samples.VerifyPdf.00.verified.txt'></a>
```txt
{
  PageCount: 2,
  Author: ,
  CreationDate: DateTime_1,
  Creator: RAD PDF,
  CustomMetadata: [],
  Keywords: ,
  ModificationDate: DateTime_2,
  Producer: RAD PDF 3.9.0.0 - http://www.radpdf.com,
  Subject: ,
  Title: 
}
```
<sup><a href='/src/Tests/Samples.VerifyPdf.00.verified.txt#L1-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-Samples.VerifyPdf.00.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

[Samples.VerifyPdf.01.verified.png](/src/Tests/Samples.VerifyPdf.01.verified.png):

<img src="/src/Tests/Samples.VerifyPdf.01.verified.png" width="200px">


### Excel


#### Verify a file

<!-- snippet: VerifyExcel -->
<a id='snippet-verifyexcel'></a>
```cs
[Test]
public Task VerifyExcel()
{
    return Verifier.VerifyFile("sample.xlsx");
}
```
<sup><a href='/src/Tests/Samples.cs#L61-L69' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifyexcel' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Verify a Stream

<!-- snippet: VerifyExcelStream -->
<a id='snippet-verifyexcelstream'></a>
```cs
[Test]
public Task VerifyExcelStream()
{
    return Verifier.Verify(File.OpenRead("sample.xlsx"))
        .UseExtension("xlsx");
}
```
<sup><a href='/src/Tests/Samples.cs#L71-L80' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifyexcelstream' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Result

<!-- snippet: Samples.VerifyExcel.00.verified.txt -->
<a id='snippet-Samples.VerifyExcel.00.verified.txt'></a>
```txt
{
  Author: ascropp,
  CodeName: ThisWorkbook,
  DetectDateTimeInValue: true,
  ArgumentsSeparator: ,,
  DisplayWorkbookTabs: true,
  Version: Xlsx,
  StandardFont: Arial,
  StandardFontSize: 10.0,
  MaxColumnCount: 16384,
  MaxRowCount: 1048576
}
```
<sup><a href='/src/Tests/Samples.VerifyExcel.00.verified.txt#L1-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-Samples.VerifyExcel.00.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

[Samples.VerifyExcel.01.verified.png](/src/Tests/Samples.VerifyExcel.01.verified.png):

<img src="/src/Tests/Samples.VerifyExcel.01.verified.png" width="200px">


### Word


#### Verify a file

<!-- snippet: VerifyWord -->
<a id='snippet-verifyword'></a>
```cs
[Test]
public Task VerifyWord()
{
    return Verifier.VerifyFile("sample.docx");
}
```
<sup><a href='/src/Tests/Samples.cs#L82-L90' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifyword' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Verify a Stream

<!-- snippet: VerifyWordStream -->
<a id='snippet-verifywordstream'></a>
```cs
[Test]
public Task VerifyWordStream()
{
    return Verifier.Verify(File.OpenRead("sample.docx"))
        .UseExtension("docx");
}
```
<sup><a href='/src/Tests/Samples.cs#L92-L101' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifywordstream' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Result

<!-- snippet: Samples.VerifyWord.00.verified.txt -->
<a id='snippet-Samples.VerifyWord.00.verified.txt'></a>
```txt
{
  LastAuthor: Simon Cropp,
  Company: ,
  LinesCount: 44,
  ParagraphCount: 40,
  WordCount: 909,
  PageCount: 4,
  ApplicationName: Microsoft Office Word,
  CreateDate: DateTime_1,
  RevisionNumber: 2
}
```
<sup><a href='/src/Tests/Samples.VerifyWord.00.verified.txt#L1-L11' title='Snippet source file'>snippet source</a> | <a href='#snippet-Samples.VerifyWord.00.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

[Samples.VerifyWord.01.verified.png](/src/Tests/Samples.VerifyWord.01.verified.png):

<img src="/src/Tests/Samples.VerifyWord.01.verified.png" width="200px">


### PowerPoint


#### Verify a file

<!-- snippet: VerifyPowerPoint -->
<a id='snippet-verifypowerpoint'></a>
```cs
[Test]
public Task VerifyPowerPoint()
{
    return Verifier.VerifyFile("sample.pptx");
}
```
<sup><a href='/src/Tests/Samples.cs#L38-L46' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifypowerpoint' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Verify a Stream

<!-- snippet: VerifyPowerPointStream -->
<a id='snippet-verifypowerpointstream'></a>
```cs
[Test]
public Task VerifyPowerPointStream()
{
    return Verifier.Verify(File.OpenRead("sample.pptx"))
        .UseExtension("pptx");
}
```
<sup><a href='/src/Tests/Samples.cs#L48-L57' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifypowerpointstream' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


#### Result

<!-- snippet: Samples.VerifyPowerPoint.00.verified.txt -->
<a id='snippet-Samples.VerifyPowerPoint.00.verified.txt'></a>
```txt
{
  AppVersion: 16.0000,
  NameOfApplication: Microsoft Office PowerPoint,
  Company: ,
  Manager: ,
  PresentationFormat: Custom,
  ApplicationTemplate: ,
  Title: Lorem ipsum,
  Subject: ,
  Author: simon,
  Keywords: ,
  Comments: ,
  Category: ,
  CreatedTime: DateTime_1,
  LastSavedTime: DateTime_2,
  LastPrinted: DateTime_3,
  LastSavedBy: Simon Cropp,
  RevisionNumber: 1,
  ContentStatus: ,
  ContentType: ,
  HyperlinkBase: 
}
```
<sup><a href='/src/Tests/Samples.VerifyPowerPoint.00.verified.txt#L1-L22' title='Snippet source file'>snippet source</a> | <a href='#snippet-Samples.VerifyPowerPoint.00.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

[Samples.VerifyPowerPoint.01.verified.svg](/src/Tests/Samples.VerifyPowerPoint.01.verified.svg):


## File Samples

http://file-examples.com/



## Icon

[Swirl](https://thenounproject.com/term/swirl/1568686/) designed by [creativepriyanka](https://thenounproject.com/creativepriyanka) from [The Noun Project](https://thenounproject.com/).
