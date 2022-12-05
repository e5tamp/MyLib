namespace MyLib
{
    public class Triangle: Shape
    {
        public Triangle() { Lines = new LinesForShape(3); }

        public bool IsRectangular()
        {
            return Lines[0] * Lines[0] == Lines[1] * Lines[1] + Lines[2] * Lines[2] ||
                    Lines[1] * Lines[1] == Lines[0] * Lines[0] + Lines[2] * Lines[2] ||
                    Lines[2] * Lines[2] == Lines[0] * Lines[0] + Lines[1] * Lines[1];
            
        }

        public bool Exists()
        {
            return Lines[0] < Lines[1] + Lines[2] &&
                    Lines[1] < Lines[2] + Lines[0] &&
                    Lines[2] < Lines[1] + Lines[0];
        }

        public override double GetSquare()
        {
            if (Lines.Count() == 3)
            {
                double pp = (Lines[0] + Lines[1] + Lines[2]) / 2;
                double a = pp * (pp - Lines[0]) * (pp - Lines[1]) * (pp - Lines[2]);
                return Math.Sqrt(a);
            }
            else return 0;
        }
    }
}
