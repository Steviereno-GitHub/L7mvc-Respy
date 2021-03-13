//tinfo200:[2021 - 03 - 12 -< Steven28 > -dykstra] - The Course class is the highest level of the data hieracrly for this
//web page database since it holds enrollments which in turns holds all the students. Meaning it can access all the 
//data in this little hierachy. However, for this class when we create our database we specifialy use the DatabaseGenOption.None
//to make it so that the Course ID isn't generated along with the rest of the elements present (meaning only the Title and credits will be used)
//Finally we have a collection of Enrollment going back to the idea of having the all the data be accessed by this class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //This DataBaseGenerated attribute will make it so that the line of code immentily after it isn't part of
        //the database. 
        //Ulitmaly we will use our only unqiue PK for the course ID so the following command will not create one for it
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Storing objects of type enrollment into a var named enrollment 
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
