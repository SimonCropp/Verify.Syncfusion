﻿using Syncfusion.XlsIO;
using Syncfusion.XlsIORenderer;

namespace VerifyTests;

public static partial class VerifySyncfusion
{
    static ConversionResult ConvertExcel(Stream stream, IReadOnlyDictionary<string, object> settings)
    {
        var engine = new ExcelEngine
        {
            Excel =
            {
                XlsIORenderer = new XlsIORenderer()
            }
        };
        var workbook = engine.Excel.Workbooks.Open(stream);
        return ConvertExcel(workbook, settings);
    }

    static ConversionResult ConvertExcel(IWorkbook book, IReadOnlyDictionary<string, object> settings)
    {
        var info = GetInfo(book);
        return new(info, GetExcelStreams(book).ToList());
    }

    static object GetInfo(IWorkbook book)
    {
        return new
        {
            book.Author,
            book.CodeName,
            book.Date1904,
            book.HasMacros,
            book.DisableMacrosStart,
            book.DetectDateTimeInValue,
            book.ArgumentsSeparator,
            book.DisplayWorkbookTabs,
            book.DisplayedTab,
            book.ActiveSheetIndex,
            book.IsRightToLeft,
            book.IsWindowProtection,
            book.Version,
            book.IsCellProtection,
            book.ReadOnly,
            book.ReadOnlyRecommended,
            book.StandardFont,
            book.StandardFontSize,
            book.MaxColumnCount,
            book.MaxRowCount,
        };
    }

    static IEnumerable<Target> GetExcelStreams(IWorkbook book)
    {
        foreach (var sheet in book.Worksheets)
        {
            var stream = new MemoryStream();
            sheet.SaveAs(stream, ",", Encoding.UTF8);
            stream.Position = 0;
            var reader = new StreamReader(stream);
            yield return new("csv", reader.ReadToEnd());
        }
    }
}