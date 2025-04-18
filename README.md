# Employee-Management-System
*Group Coursework for CST2550 Software Engineering Management and Development* <br><br>
📌 Employee Management System <br>
🚀 A simple and efficient Employee Management System to manage employee records, attendance, payroll, and performance in an organization.

### 🔹 Features
✅ Employee Information Management (Personal & Job Details) <br>
✅ Attendance & Time Management <br>
✅ Payroll Management (Salary, Bonuses, Deductions) <br>
✅ Recruitment and Onboarding <br>
✅ Leave and Benefits Management <br>
✅ Document Management <br>


### 🛠 Tech Stack
- Backend: C#
- Database: SQL
- Frontend: Windows Forms (C#)

### 🔧 Requirements
Windows OS
.NET Framework (version 4.x or above)
Visual Studio (recommended)

🛠️ How to Compile & Run
Open Project:

Open EmployeeViewer.sln (or your solution file) in Visual Studio.

Build the Project:

Go to Build > Build Solution or press Ctrl+Shift+B.

Run the Program:

Press F5 or click the green play button in the toolbar.

🧑‍💼 How to Use the Program
When the program starts, it automatically connects to the Employee database.

It loads and displays the first employee’s details:

ID, First Name, Last Name, Role, Address, Postcode, Email


To update data:

Make changes in the text boxes and use a button (not shown here) to call UpdateDatabase() with the modified DataSet.

⚠️ Notes
Ensure your database connection string and SQL query are correctly set in:

Properties > Settings.settings file

The SQL query should match your database structure (e.g., selecting all columns from the EmployeeTable).

