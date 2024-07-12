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






// Exercise - Format the decimal output
// Completed
// 100 XP
// 10 minutes
// In this exercise, you'll calculate the final GPA and modify the console output to achieve the desired reporting format. The GPA is equal to the sum of the total grade points divided by the sum of the total credit hours.

// Calculate the final GPA
// In the .NET Editor, locate the Console.WriteLine() statements that are used to display the course information.

// Remove the following code from the previous exercise:

// C#

// Copy
// Console.WriteLine($"{totalGradePoints} {totalCreditHours}");
// Since you've verified your values are correct, this line is no longer needed.

// Create a blank code line above the Console.WriteLine() statements.

// On the blank code line that you created, to initialize a variable that will store the final GPA, enter the following code:

// C#

// Copy
// decimal gradePointAverage = totalGradePoints/totalCreditHours;

// Take a moment to consider the data types you're dividing.

// When you want the result of a division calculation to be a decimal value, either the dividend or divisor must be of type decimal (or both). When you use integer variables in the calculation, you need to use the cast operator to temporarily convert an integer to a decimal.

// To retrieve a decimal value from the division, update your code as follows:

// C#

// Copy
// decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

// Navigate to the last Console.WriteLine() statement and create a new blank code line after the last statement.

// To display the final GPA, enter the following code:

// C#

// Copy
// Console.WriteLine($"Final GPA: {gradePointAverage}");
// To view the results, select Run.

// Compare your application's output with the following output:


// Copy
// English 101 4 3
// Algebra 101 3 3
// Biology 101 3 4
// Computer Science I 3 4
// Psychology 101 4 3
// Final GPA: 3.3529411764705882352941176471
// Format the decimal output
// You might have noticed that decimal result contains many more digits than a standard GPA. In this task, you'll manipulate the decimal GPA value so that only three digits are displayed.

// Ultimately, you want to display the first digit of the GPA, a decimal point, followed by the first two digits after the decimal. You can achieve this format by using variables to store the leading and trailing digits respectively, and then printing them together using Console.WriteLine(). You can use the math operations you learned to extract the leading and trailing digits.

//  Note

// As you continue your developer journey, you'll discover built-in operations that can automatically apply formatting to your data. For now, this is a great opportunity to solidify what you've learned so far.

// Navigate to the top of the Console.WriteLine() statements.

// Create a blank code line above the Console.WriteLine() statements.

// On the blank code line that you created, to initialize a variable that will store the leading digit of the GPA, enter the following code:

// C#

// Copy
// int leadingDigit = (int) gradePointAverage;

// Notice that to extract the leading digit from the decimal, you're casting it to an integer value. This is a simple and reliable method because casting a fractional value will never round up the result. Meaning if the GPA is 2.99, casting the decimal value to an int will result in 2.

// To initialize a variable that will store the first two digits after the decimal, enter the following code:

// C#

// Copy
// int firstDigit = (int) (gradePointAverage * 10) % 10;
// In the first half of this operation, you move the decimal one place to the right and cast it to an integer. In the second half, you use the remainder, or modulo, operator to get the remainder of division by 10, which isolates the last digit in the integer. Here's an example:

// Suppose gradePointAverage = 2.994573 Then, performing the operation on these values would result in the following steps:

// C#

// Copy
// int firstDigit = (int) (2.994573 * 10) % 10;
// int firstDigit = 29 % 10;
// int firstDigit = 9;
// And the resulting value of firstDigit is 9.

// Next, you'll apply the same operation to retrieve the second digit.

// On a new blank code line, enter the following code:

// C#

// Copy
// int secondDigit = (int) (gradePointAverage * 100 ) % 10;
// In this line, you move the decimal two places and use the modulo operator to retrieve the last digit.

// To correct the final GPA output, update the last Console.WriteLine() statement as follows:

// C#

// Copy
// Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
// Check Your Work
// In this task, you'll run the code and verify that the output is correct.

// Check that your code is similar to the following:

// C#

// Copy
// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

// int leadingDigit = (int) gradePointAverage;
// int firstDigit = (int) (gradePointAverage * 10 ) % 10;
// int secondDigit = (int) (gradePointAverage * 100 ) % 10;

// Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
// Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
// Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
// Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
// Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

// Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
// To run your code and display the formatted output, select Run.

// To verify that your code is working as expected, compare the output of your application with the following output:

// Output

// Copy
// English 101 4 3
// Algebra 101 3 3
// Biology 101 3 4
// Computer Science I 3 4
// Psychology 101 4 3
// Final GPA: 3.35
// If your code displays different results, you'll need to review your code to find your error and make updates. Run the code again to see if you've fixed the problem. Continue updating and running your code until your code produces the expected results.