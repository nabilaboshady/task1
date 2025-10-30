
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

class Program
{

    static void Main()
    {
        

        Console.WriteLine("enter the number of sudents :");
        int student_number = int.Parse(Console.ReadLine());
        string[] name = new string[student_number];
        int[] grade = new int[student_number];



        for (int i = 0; i < student_number; i++)
        {
            string student_name = name_fun();
            name[i] = student_name;
            int student_grade = grade_fun();
            grade[i] = student_grade;
        }
        int large_grade = grade[0];
        string Students_above_average = name[0];

        for (int i = 0; i < grade.Length; i++)
        {
            if (grade[i] > large_grade)
            {
                large_grade = grade[i];
                Students_above_average = name[i];
            }
        }
        Console.WriteLine("Student with highest grade is: " + Students_above_average);
    }
    static string name_fun()
    {
        Console.WriteLine("enter studen name ");
        string name = Console.ReadLine();
        return name;


    }
    static int grade_fun()
    {
        Console.WriteLine("enter the grade of student ");
        int grade = int.Parse(Console.ReadLine());
        return grade;

    }
}
