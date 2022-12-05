namespace MyLib
{
    public class Circle : Shape
    {
        public Circle() { Lines = new LinesForShape(1); }

        public override double GetSquare()
        {
            if (Lines.Count() == 1)
                return Math.PI * Lines[0] * Lines[0];
            else return 0;
        }
    }
}
