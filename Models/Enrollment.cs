//tinfo200:[2021 - 03 - 12 -< Steven28 > -dykstra] - Copied the code from site into new class
//This is the second highest class of the hierarchy with it being the Enrollment class which will uses 
//Students data from the student class in order to fill in the coresponing data like studentID and Enrollment
//However in order to get grades a Enum type is created to store/assign a "grade" to the students.
namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        
        //Having a ? means it possible that the grade can be NULL
        public Grade? Grade { get; set; }

        //Getting the class type into a var of said class
        //So we can get a object type student from the lower level and put it into a var here same goes for course
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}