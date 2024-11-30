namespace Antlr4Library.Models;

public class CSV
{
    public List<string> Header { get; set; } = [];
    public List<List<string>> Rows { get; set; } = [];
}
