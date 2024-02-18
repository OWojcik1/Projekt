namespace Projekt.Models
{
    public class Student
    {
        private static int _nextStudentNumber = 1;
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public bool IsPresent { get; set; }

        public int TimesSinceLastPicked { get; set; }

        public Student()
        {
            StudentNumber = _nextStudentNumber++;
        }

        public static void DecrementNextStudentNumber()
        {
            _nextStudentNumber--;
        }
    }
}
