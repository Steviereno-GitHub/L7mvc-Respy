//tinfo200:[2021 - 03 - 12 -< Steven28 > -dykstra]
//Now while we do have our three data models the EF needs it own little class in order to make any sence of the data
//So, we create schoolContext which is derives from DbContext: This class will take in the entities or class we have created
//we sorts out which of them are included in a the data model. 


//The data will mostly likely hold all the database data and once these EF classes work their magic in bulidng and sorting the data.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //Consturotor that calls the base but will add other functions to it mainly the Db functions
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }


        //the model bulider will have its own way of creating our data model so we override that defaut of 
        //with one of our own forcing it to use our own name conventions rather then what defualt one is used
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }

    }
}
