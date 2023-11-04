namespace TailRecursion.Models;

public class Fibonacci : IEnumerable<long>
{
    /**************************** Constants ******************************/
    public const int MinInput = 0;
    public const int MaxInput = 92;
    public const int FstInitialValue = 0;
    public const int SndInitialValue = 1;

    /*************************** Constructors ****************************/
    public Fibonacci(int input)
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
    public IEnumerator<long> GetEnumerator()
    {
        for (var i = 0; i < InputValue; i++)
        { yield return CalculateFibonacci(i); }
    }

    IEnumerator IEnumerable.GetEnumerator()
    { return GetEnumerator(); }

    public override string ToString()
    {
        var fibList = Enumerable.Range(0, InputValue + 1)
                                .Select(CalculateFibonacci)
                                .ToList();

        var sb = new StringBuilder().AppendLine("Fibonacci:");
        for (var i = MinInput; i <= InputValue; i++)
        {
            var result = fibList[i];
            sb.AppendLine($"Fib({i}) = {result,15}");
        }

        return sb.AppendLine().ToString();
    }

    /************************** Private Methods ***************************/
    private long CalculateFibonacci(int n)
    { return CalculateFibonacci(n, FstInitialValue, SndInitialValue); }

    private long CalculateFibonacci(int n, long fstValue, long sndValue)
    {
        return n == 0 ?
            fstValue :

            n == 1 ?
            sndValue :

            CalculateFibonacci(n - 1, sndValue, fstValue + sndValue);
    }

    /************************** Private Fields ***************************/
    private int _inputValue;

}
