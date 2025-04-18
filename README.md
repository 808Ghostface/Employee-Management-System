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




# 📘 Project Documentation: Employee Management System
## 🔖 Project Title
### Employee Management System using Windows Forms and SQL Server

### 📝 Description
This project is a basic desktop application built in C# with Windows Forms and a SQL Server database. It allows users to view and manage employee information through a graphical interface connected to a local database.

### 📁 Project Structure
Forms: EmployeeView.cs – UI for displaying employee data.

Database Layer: DatabaseConnection.cs – Handles database connection, retrieval, and updates.

Database File: EmployeeDB.mdf – LocalDB file included in the project.

SQL Script: CreateDatabase.sql – Script to recreate database structure and stored procedures.

### 🔧 Features
Load and display employee data from WorkersInfo table.

Join with ManagementInfo for additional details like comments and hire date.

View employee information row by row.

Stored procedures for efficient queries:

ComWorkandManage – Combines employee and management info.

GetWorkerByID – Gets specific worker details.

ViewID – Lists all workers.

### 🧑‍💻 How to Run
Open the solution in Visual Studio.

Ensure the .mdf database file is correctly attached.

Build the solution (Ctrl+Shift+B).

Run the project (F5).

The form will display data from the database automatically.

### 🧾 How to Use
On load, employee data is fetched and displayed.

Users can navigate between employees (you can extend this with navigation buttons).

To update data, make changes in the form and call the UpdateDatabase() method (e.g., via a Save button – to be implemented).

### 🧪 Testing
The form was tested with sample data in WorkersInfo.

Connection and data loading are wrapped in try-catch blocks to handle exceptions.

Verify that SQL queries match the database structure.

### 📂 Files Included
EmployeeView.cs – Main form logic

DatabaseConnection.cs – Database operations

CreateDatabase.sql – SQL script for creating tables and procedures

README.md – Instructions for compiling and using the application
