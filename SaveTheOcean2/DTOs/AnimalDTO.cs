using System;

namespace SaveTheOcean2.DTO
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string? Species { get; set; }
        public double? Weight { get; set; }
        public int CalculateNewGradeAfectation(bool heal)
        {
            Random random = new Random();
            int GradeAfectation = random.Next(100);
            int x = 15;
            int newgade = ((2 * GradeAfectation + 3) - ((GradeAfectation - 20) * 2) - x);
            return newgade < 0 ? 0 : newgade;
        }
    }
}
