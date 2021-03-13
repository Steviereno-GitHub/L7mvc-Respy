using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
       //tinfo200:[2021-03-12-<Steven28>-dykstra] - Began the data relationship from Course -> Enrollement -> Student
       //This is the student class where a ID, First/last Name, EnrollmentDate and a List or collection is created for storing and 
       //getting their data

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
