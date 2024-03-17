using DesignPatterns.Facade;

var generator = new MagicSquareGenerator();
var matrix = generator.Generate(3);
DisplayMatrix(matrix);

static void DisplayMatrix(List<List<int>> matrix)
{
    string output = string.Empty;
    foreach (List<int> row in matrix)
    {
        output += "[" + string.Join(",", row) + "]\n";
    }
    Console.WriteLine(output);
}