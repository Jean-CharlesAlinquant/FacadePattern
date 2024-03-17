
namespace DesignPatterns.Facade;

public class MagicSquareGenerator
{
    private Generator _generator = new Generator();
    private Splitter _splitter = new Splitter();
    private Verifier _verifier = new Verifier();

    public List<List<int>> Generate(int size)
    {
        if (size < 1)
        {
            throw new ArgumentOutOfRangeException($"{nameof(size)} mut be greater than 1");
        }

        List<List<int>> square;
        bool isMagicSquare;

        do
        {
            square = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                square.Add(_generator.Generate(size));
            }

            isMagicSquare = _verifier.Verify(_splitter.Split(square));
        } while (!isMagicSquare);

        return square;
    }
}
