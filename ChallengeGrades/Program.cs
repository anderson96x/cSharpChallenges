/*
#Challenge from Microsoft Learn

Project overview
You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

You're given the student's name and class information.
Each class has a name, the student's grade, and the number of credit hours for that class.
Your application needs to perform basic math operations to calculate the GPA for the given student.
Your application needs to output/display the student’s name, class information, and GPA.
To calculate the GPA:

Multiply the grade value for a course by the number of credit hours for that course.
Do this for each course, then add these results together.
Divide the resulting sum by the total number of credit hours.
You're provided with the following sample of a student's course information and GPA:




The goal was just to output the exactly the way this program does using Console.WriteLine and string format, but i decided to go beyond.
*/

string[] courseName = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};
int[] courseGrade = {4,3,3,3,4};
int[] courseCreditHours = {3,3,4,4,3};

Console.WriteLine("Student: Sophia Johnson\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
for (int i=0; i<5; i++) {
    if (courseName[i].Length < 12) {
        Console.WriteLine(courseName[i] + "\t\t\t" + courseGrade[i] + "\t\t" + courseCreditHours[i]);
    } else {
        int stringCout = 20 - courseName[i].Length;
        Console.Write(courseName[i]);
        for (int j=0; j<stringCout; j++) {
            Console.Write(" ");
        }
        Console.WriteLine(courseGrade[i] + "\t\t" + courseCreditHours[i]);
    }
}
Console.WriteLine();
Console.Write("Final GPA:\t\t\t");
calculateGPA();


void calculateGPA() {
    int [] gradeValue = new int [5];
    double finalGPA = 0;
    int totalCreditHours = 0;
    int sumGrades = 0;
    for (int i=0; i<5; i++) {
        gradeValue[i] = courseGrade[i] * courseCreditHours[i];
        sumGrades += gradeValue[i];
        totalCreditHours += courseCreditHours[i];
    }
    finalGPA = sumGrades / (double)totalCreditHours;
    Console.Write(finalGPA.ToString("F2"));
}




