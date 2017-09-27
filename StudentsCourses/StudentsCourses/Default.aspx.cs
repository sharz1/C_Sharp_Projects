using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentsCourses
{
    public partial class Default : System.Web.UI.Page
    {
        static List<Student> students = new List<Student>()
            {
                new Student{ StudentId = 192837465, Name = "Sarah Gold", Courses = new List<Course>()},
                new Student{ StudentId = 192837412, Name = "Taylor Smith", Courses = new List<Course>()},
                new Student{ StudentId = 192837450, Name = "Billy Madison", Courses = new List<Course>()},
                new Student{ StudentId = 192837428, Name = "Debbie Reynolds", Courses = new List<Course>()},
                new Student{ StudentId = 192837440, Name = "Greg Fox", Courses = new List<Course>()},
                new Student{ StudentId = 192837430, Name = "Hank Truman", Courses = new List<Course>()},
                new Student{ StudentId = 192837487, Name = "Jennifer Swift", Courses = new List<Course>()}
            };
        List<Course> courses = new List<Course>()
            {
                new Course {CourseId = 10155, Name = "Biology 101", Students = new List<Student>()
                    {students.ElementAt(1), students.ElementAt(2), students.ElementAt(5)}},
                new Course {CourseId = 20192, Name = "Writing 201", Students = new List<Student>()
                    {students.ElementAt(3), students.ElementAt(4), students.ElementAt(6)}},
                new Course {CourseId = 10160, Name = "History 101", Students = new List<Student>()
                    {students.ElementAt(5), students.ElementAt(6), students.ElementAt(0)}},
                new Course {CourseId = 20144, Name = "Finance 201", Students = new List<Student>()
                    {students.ElementAt(1), students.ElementAt(2), students.ElementAt(0)}},
            };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                foreach (Student student in students)
                {
                    int st_id = student.StudentId;
                    foreach (Course course in courses)
                    {
                        if (course.Students.Exists(p => p.StudentId == st_id))
                        {
                            student.Courses.Add(course);

                        }
                    }
                }
            }
        }
        Random random = new Random();

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            string result = "";
            foreach (Course course in courses)
            {
                result += String.Format("<br /><br />Course: {0}-{1}<br />", course.CourseId, course.Name);
                foreach (Student student in students)
                {
                    /* Check courses list to see if student is in that class in order to 
                    display student names in result label */
                    int st_id = student.StudentId;
                    if (course.Students.Exists(p => p.StudentId == st_id))
                    {
                        result += String.Format("<li>{0} {1}</li>", student.StudentId, student.Name);
                    }

                }
                resultLabel.Text = result;
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            //Convert students list to a dictionary
            Dictionary<int, Student> studentdict = new Dictionary<int, Student>();

            foreach (Student student in students)
            {
                studentdict.Add(student.StudentId, student);
            }
            //Display students and their courses to the resultLabel
            string result = "";

            foreach (KeyValuePair<int, Student> entry in studentdict)
            {
                result += String.Format("<br /><br />Student ID: {0} Name: {1}", entry.Key, entry.Value.Name);

                foreach (Course course in entry.Value.Courses)
                {
                    result += String.Format("<li>{0} {1}</li>", course.CourseId, course.Name);
                }

            }
            resultLabel.Text = result;
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            //Populate student grades Dictionary, randomly from students list

            foreach (Student student in students)
            {
                List<Course> studentcourselist = student.Courses;
                Dictionary<Course, Grade> studentcoursedict = new Dictionary<Course, Grade>();
                foreach (Course course in studentcourselist)
                {
                    int grade = random.Next(50, 101);
                    Grade c_grade = new Grade() { Percent = grade };
                    studentcoursedict.Add(course, c_grade);
                }
                student.Coursegrades = studentcoursedict;
            }
            //display students and their courses and grades
            string result = "";
            foreach (Student student in students)
            {
                result += String.Format("<br /><br />Student ID: {0} Name: {1}", student.StudentId, student.Name);

                foreach (KeyValuePair<Course, Grade> entry in student.Coursegrades)
                {
                    result += String.Format("<li>Course: {0} {1} Grade: {2}</li>",
                        entry.Key.CourseId, entry.Key.Name, entry.Value.Percent);
                }
            }
            resultLabel.Text = result;
        }
    }
}