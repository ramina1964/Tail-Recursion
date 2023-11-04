namespace TailRecursion.Models;

public class Factorial
{
    /**************************** Constants ******************************/
    public const int MinInput = 0;
    public const int MaxInput = 25;

    /*************************** Constructors ****************************/
    public Factorial(int input)
    {
        InputValue = input;
    }

    /**************************** Properties *****************************/
    public int InputValue
    {
        get { return _inputValue; }

        set
        {
            if (MinInput > value || value > MaxInput)
            {
                var msg = "Input argument must be in the range: " + $"[{MinInput}, {MaxInput}";
                throw new ArgumentOutOfRangeException(msg);
            }

            _inputValue = value;
        }
    }

    /************************** Public Methods ***************************/
    public override string ToString()
    {
        var factList = Enumerable.Range(0, InputValue + 1)
                                 .Select(item => CalculateFactorial(item))
                                 .ToList();

        var sb = new StringBuilder().AppendLine("Factorial:");
        for (var i = MinInput; i <= InputValue; i++)
        {
            var result = factList[i];
            sb.AppendLine($"{i,2}! = {result,10}");
        }

        return sb.AppendLine().ToString();
    }

    /************************** Private Methods **************************/
    public long CalculateFactorial(int nFact)
    {
        return CalculateFactorial(nFact, 1);
    }

    private long CalculateFactorial(int nFact, long acc)
    {
        return nFact < 2 ?
          acc :
          CalculateFactorial(nFact - 1, nFact * acc);
    }

    /************************** Private Fields ***************************/
    private int _inputValue;
}
