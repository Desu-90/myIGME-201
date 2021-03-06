using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    public class Schedule
    {
        public DateTime startTime;
        public DateTime endTime;
        public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
    }

    public class Course
    {
        public string courseCode;
        public string description;
        public string teacherEmail;
        public Schedule schedule;
    }

    public class Courses
    {
        public SortedList<string, Course> sortedList = new SortedList<string, Course>();
        public void Remove (string, courseCode)
        {
            if (email != null)
            {
                sortedList.Remove(email);
            }
        }
    }
}
