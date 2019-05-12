namespace Task2Course.Models
{
    class Student
    {
        string _studentName;
        int _age;
        int _level;
        Course _enrolledCourse;
        string _grade;
        
        
        
        
        public Student() { }

        public Student(string studentName, int age, int level)
        {
            _studentName = studentName;
            _age = age;
            _level = level;
        }

        //method for enroll
        public bool Enroll(Course course)
        {
            _enrolledCourse = course;
            _grade = "";
            return true;

        }
        public bool Withdraw()
        {
            if (_enrolledCourse != null)
            {
                _enrolledCourse = null;
                return true;
            }
            return false;
        }

        public string PersonalData()
        {
            return "\n  1)Student name:  " + _studentName +
                   "\n  2)Age:           " + _age +
                   "\n  3)Level:         " + _level;
        }

        public override string ToString()
        {
            string text = PersonalData() +
                "\n  4)Course status: " + IsEnrolled();
            if (IsEnrolled())
            {
                text += _enrolledCourse.ToString();
                text += $"\n  5)Course grade: {_grade}";
            }

            return text;
        }

        public string AssignGrade(int i)
        {
            string grade;
            switch (i)
            {
                case int n when (n > 100):
                    grade = "wrong number";
                    break;
                case int n when (n <= 100 && n >= 80):
                    grade = "A";
                    break;
                case int n when (n >= 70):
                    grade = "B";
                    break;
                case int n when (n >= 60):
                    grade = "C";
                    break;
                case int n when (n >= 50):
                    grade = "D";
                    break;
                case int n when (n >= 0):
                    grade = "F";
                    break;
                default:
                    grade = "wrong number";
                    break;
            }
            _grade = grade;
            return grade;
        }

        public bool IsEnrolled()
        {
            return _enrolledCourse != null;
        }
    }
}
