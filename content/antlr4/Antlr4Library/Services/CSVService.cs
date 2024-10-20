using Antlr4.Runtime;
using Antlr4Library.Models;

namespace Antlr4Library.Services;

public class CSVService
{
    public CSV Parse(string csvInput)
    {
        // add extra newline to ensure last row is parsed if it doesn't end with a newline
        if (!csvInput.EndsWith('\n'))
        {
            csvInput += "\n";
        }

        var inputStream = new AntlrInputStream(csvInput);
        var lexer = new CSVLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new CSVParser(commonTokenStream);

        var context = parser.file();
        var visitor = new CSVVisitor();

        // Use the visitor to traverse the parse tree and build the CSV object
        var csv = visitor.VisitFile(context);
        return csv;
    }
    
    public CSV ParseWithDemoData()
    {
        // This example come from Terence Parr's book "The Definitive ANTLR 4 Reference"
        const string csvInput =
            """"
            Details,Month,Amount
            Mid Bonus,June,"$2,000"
            ,January,"""zippo"""
            Total Bonuses,"","$5,000"
            """";

        var csv = Parse(csvInput);
        
        // After parsing, you can print the CSV data to the console for demonstration purposes
        // WriteLine(string.Join(", ", csv.Header));
        // WriteLine("---------------------");
        //
        // foreach (var row in csv.Rows)
        // {
        //     WriteLine(string.Join(", ", row));
        // }
        
        return csv;
    }
}