using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }

    public partial class SchoolDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            //Configurar Cadena de Conexión
            var oraConn = "User Id=hr;Password=hr;Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522)))(CONNECT_DATA =(SERVICE_NAME = xe)))";
            optionsBuilder.UseOracle(oraConn);
        }
    }
}
