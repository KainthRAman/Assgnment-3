using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Sort_DataStructure();


    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.Announcement();

        }
    }
    class Student
    {
        String Student_name;
        String StudentID;
        double StudentGPA;

        // TODO: change this implementation so that the program pulls names from a Text File:
        // to do this, you must change the container for Student Names from Array to List
        public void Announcement()
        {
            try
            {

                using (StreamReader sr = new StreamReader("U:/Users/723796/a.txt"))
                {
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        String[] names = new String[5] { "Bill", "Mary", "Laura", "Sam", "Steve" };
        Random r1;

        public Student()
        {
            r1 = new Random();
            Student_name = names[r1.Next(0, 4)];
            StudentID = Convert.ToString(r1.Next(1000, 9999));
            StudentGPA = Convert.ToDouble(r1.Next(1, 99));
        }
        public double AverageStudentGPA()
        {
            // TO DO: implement the algorithm to calculate the Students' average GPA
            return 0;
        }
    }
    public interface IDataStructure
    {
        void Sort();
    }

    class DataStructureQueue : IDataStructure
    {
        // the QUEUE holds the classes (that is classroom of students!)
        // TO DO: insert the contents of the Data File: Classroom Data Set 

        public Queue q1 = new Queue();

        Sort_DataStructure Sort1;

