namespace MyLib
{
    public class LinesForShape : List<double>
    {
        private int linesMaxCount;

        public int LinesMaxCount
        {
            get => linesMaxCount;
            set => linesMaxCount = value;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"> максимальное кол-во линий в фигуре </param>
        public LinesForShape(int count) : base() { linesMaxCount = count; }
        public new void Add(double item)
        {
            if (linesMaxCount != Count)
                base.Add(item);
            else
                throw new LinesOverflowException("Установлено максимальное количество сторон!");
        }
    }
}
