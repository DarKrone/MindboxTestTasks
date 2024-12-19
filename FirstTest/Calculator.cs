namespace AreaCalculator
{
    public static class Calculator
    {
        /* Немного не ясно что значит вычисление площади фигуры без знания типа фигуры во время компиляции.
           Была идея сделать метод GetArea с перегрузками для разного количества параметров типа double,
           который сам бы определял какой тип фигуры ему нужно высчитать. Но подумал что не стоит добавлять данный метод,
           т.к. неизвестно какие ещё могут добавиться фигуры и какие у них параметры (тот же треугольник по двум сторонам и углу).

           И немного непонятно что должна представлять из себя проверка является ли треугольник прямоугольником.
           Я решил сделать обычный метод который проверяет это. Возможно требовалась перегрузка метода с добавлением out bool параметра,
           но я не стал этого делать.
        */
        public static double GetCircleArea(double radius)
        {
            return CircleCalculator.GetCircleArea(radius);
        }

        public static double GetTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            return TriangleCalculator.GetTriangleArea(firstSide, secondSide, thirdSide);
        }

        public static bool CheckIsTriangleRight(double firstSide, double secondSide, double thirdSide)
        {
            return TriangleCalculator.CheckIsTriangleRight(firstSide, secondSide, thirdSide);
        }
    }
}
