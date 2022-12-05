namespace MyLib
{
    public abstract class Shape
    { 
        public Shape() { }

        private LinesForShape lines;

        /// <summary>
        /// Линии/стороны фигуры.
        /// Для круга - радиус
        /// </summary>
        public LinesForShape Lines
        {
            get => lines;

            set => lines = value;
        }

        public abstract double GetSquare();
    }
}