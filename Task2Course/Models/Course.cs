namespace Task2Course.Models
{
    class Course
    {
        string _courseName;
        string _code;
        string _instructorName;

        public Course() { }

        public Course(string courseName, string code, string instructorName)
        {
            _courseName = courseName;
            _code = code;
            _instructorName = instructorName;
        }


        public override string ToString()
        {
            return $@"
Course Name     : {_courseName}
Code            : {_code}
InstructorName  : {_instructorName}";
        }
    }
}
