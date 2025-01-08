using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter How many Students : ");
            int size= Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[size];
            CreateArray(student);
            PrintInfo(student);
            RevrseArray(student);

        }
        public static void CreateArray(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student " + i + " Details");
                student[i] = new Student();
                student[i].AcceptDetails();
            }
        }

        public static void PrintInfo(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine(student[i].PrintDetails());
            }
        }

        public static void RevrseArray(Student[] student)
        {
            int j = 0;
            Student[] student2 = new Student[student.Length];
            for (int i = student.Length-1; i>=0 ; i--)
            {
                student2[j++] = student[i];
            }


            Console.WriteLine("Student In Reverse Order");

            for (int i = 0; i < student2.Length; i++)
            {
                Console.WriteLine(student2[i].PrintDetails());
            }
        }
    }
    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender { 
            get { return gender; } 
            set { gender = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Std { get { return std; } set { std = value; } }
        public char Div { get { return div; } set { div = value; } }
        public double Marks { get { return marks; } set {marks = value; } }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name");
            name=Console.ReadLine();
            Console.WriteLine("Enter Gender : ");
            gender=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Age : ");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Std : ");
            std=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Division : ");
            div=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Marks : ");
            marks=Convert.ToDouble(Console.ReadLine());
        }
        public String PrintDetails()
        {
            string gen;
            if (gender == true)
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }
            return name+" " +gen+" "+age+" "+ std+" "+div+" "+marks ;
        }

    }

}
