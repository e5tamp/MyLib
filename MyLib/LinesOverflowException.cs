namespace MyLib
{
    public class LinesOverflowException : Exception
    {
        public LinesOverflowException(string message)
        : base(message) { }
    }
}
