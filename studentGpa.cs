// Project overview
// You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

// You're given the student's name and class information.
// Each class has a name, the student's grade, and the number of credit hours for that class.
// Your application needs to perform basic math operations to calculate the GPA for the given student.
// Your application needs to output/display the student’s name, class information, and GPA.
// To calculate the GPA:

// Multiply the grade value for a course by the number of credit hours for that course.
// Do this for each course, then add these results together.
// Divide the resulting sum by the total number of credit hours.
// You're provided with the following sample of a student's course information and GPA:

// Output

// Copy
// Student: Sophia Johnson

// Course          Grade   Credit Hours	
// English 101         4       3
// Algebra 101         3       3
// Biology 101         3       4
// Computer Science I  3       4
// Psychology 101      4       3

// Final GPA:          3.35

// Define the student's name
string studentName = "Sophia Johnson";

// Define the names of the courses
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// Define the credit hours for each course
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Define the numerical values for letter grades
int gradeA = 4;
int gradeB = 3;

// Define the grades for each course
int course1Grade = gradeA;  // English 101 grade
int course2Grade = gradeB;  // Algebra 101 grade
int course3Grade = gradeB;  // Biology 101 grade
int course4Grade = gradeB;  // Computer Science I grade
int course5Grade = gradeA;  // Psychology 101 grade

// Calculate the total number of credit hours
int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Calculate the total grade points
int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// Calculate the grade point average (GPA)
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

// Extract the individual digits of the GPA for formatting
int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

// Print the student's name
Console.WriteLine($"Student: {studentName}\n");

// Print the course information: course name, grade, and credit hours
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// Print the final GPA
Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");



// Let's break down the code line by line:

// ```csharp
// Define the student's name
// string studentName = "Sophia Johnson";

// Define the names of the courses
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// Define the credit hours for each course
// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// Define the numerical values for letter grades
// int gradeA = 4;
// int gradeB = 3;

// Define the grades for each course
// int course1Grade = gradeA;  // English 101 grade
// int course2Grade = gradeB;  // Algebra 101 grade
// int course3Grade = gradeB;  // Biology 101 grade
// int course4Grade = gradeB;  // Computer Science I grade
// int course5Grade = gradeA;  // Psychology 101 grade

// Calculate the total number of credit hours
// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// Calculate the total grade points
// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// Calculate the grade point average (GPA)
// decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

// Extract the individual digits of the GPA for formatting
// int leadingDigit = (int)gradePointAverage;
// int firstDigit = (int)(gradePointAverage * 10) % 10;
// int secondDigit = (int)(gradePointAverage * 100) % 10;

// Print the student's name
// Console.WriteLine($"Student: {studentName}\n");

// Print the course information: course name, grade, and credit hours
// Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
// Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// Print the final GPA
// Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
// ```

// ### Explanation:

// 1. **Define Variables for Student and Courses:**
//    - `studentName` stores the student's name.
//    - `course1Name` to `course5Name` store the names of the five courses.

// 2. **Define Credit Hours for Each Course:**
//    - `course1Credit` to `course5Credit` store the number of credit hours for each course.

// 3. **Define Numerical Values for Letter Grades:**
//    - `gradeA` and `gradeB` store the numerical equivalents of the letter grades A and B.

// 4. **Assign Grades to Courses:**
//    - `course1Grade` to `course5Grade` store the grades received in each course, represented by the numerical equivalents defined earlier.

// 5. **Calculate Total Credit Hours:**
//    - `totalCreditHours` is initialized to 0.
//    - The credit hours for each course are added to `totalCreditHours`.

// 6. **Calculate Total Grade Points:**
//    - `totalGradePoints` is initialized to 0.
//    - The grade points for each course (credit hours multiplied by the grade) are added to `totalGradePoints`.

// 7. **Calculate GPA:**
//    - `gradePointAverage` is calculated by dividing `totalGradePoints` by `totalCreditHours`.

// 8. **Extract Digits for Formatting GPA:**
//    - `leadingDigit` stores the integer part of the GPA.
//    - `firstDigit` and `secondDigit` store the first and second decimal places of the GPA, respectively.

// 9. **Print Student's Information:**
//    - The student's name is printed.
//    - The course information (name, grade, credit hours) is printed in a tabulated format.
//    - The final GPA is printed with two decimal places for clarity.