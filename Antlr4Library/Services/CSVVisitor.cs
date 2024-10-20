using Antlr4Library.Models;

namespace Antlr4Library.Services;

public class CSVVisitor : CSVBaseVisitor<object>
{
    public override CSV VisitFile(CSVParser.FileContext context)
    {
        var csv = new CSV
        {
            Header = VisitHdr(context.hdr())
        };

        foreach (var rowContext in context.row())
        {
            csv.Rows.Add(VisitRow(rowContext));
        }

        return csv;
    }

    public override List<string> VisitHdr(CSVParser.HdrContext context)
    {
        return VisitRow(context.row());
    }

    public override List<string> VisitRow(CSVParser.RowContext context)
    {
        var fields = new List<string>(context.field().Length);
        
        foreach (var fieldContext in context.field())
        {
            fields.Add(VisitField(fieldContext));
        }
        
        return fields;
    }

    public override string VisitField(CSVParser.FieldContext context)
    {
        if (context.TEXT() != null)
        {
            return context.TEXT().GetText();
        }

        if (context.STRING() != null)
        {
            // Remove the surrounding quotes and unescape double quotes
            var text = context.STRING().GetText();
            text = text.Substring(1, text.Length - 2).Replace("\"\"", "\"");
            return text;
        }

        return string.Empty; // Empty field
    }
}