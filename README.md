========================================
e-Shift Household Goods Shifting Application
CS6004ES Application Development Coursework
=========================================

Student Name: [Liyanage Siinali Dhanodya Jayarathna]
Student ID: [Your Student ID]
Module Leader: Mr. Migara
Assignment No: 001
Module: CS6004ES Application Development

📌 Description:
This Windows Forms application automates household goods shifting operations for e-Shift. It allows customers to request transport jobs while providing admin functionalities for managing customers, employees, jobs, payments, products, and generating reports.


💻 Requirements:
- Windows OS
- Visual Studio 2015 or later
- .NET Framework 4.5 or later
- Microsoft SQL Server (2014 or later)


🛠️ How to Run:
1️⃣ Open the project folder in Visual Studio 2015.
2️⃣ Restore any missing NuGet packages if prompted.
3️⃣ Ensure SQL Server is running on your machine.
4️⃣ Create the database:
    - Use the provided `eShiftDB.sql` script to create tables in SQL Server.
    - Update the `connectionString` in `DatabaseManager.cs` to match your server details.
5️⃣ Build the project (Ctrl + Shift + B).
6️⃣ Run the project (F5) to launch the application.


🔑 Default Login Credentials:
Admin:
    Username: adminUser
    Password: admin123

You may register customers via the Admin dashboard or directly using SQL Insert statements for testing.


📈 Features:
✅ Admin can:
    - Manage customers, jobs, employees, products, and payments
    - Assign jobs to employees
    - Generate operational and financial reports
✅ Customers can:
    - Register and log in
    - Submit transport job requests
    - View job status
✅ Dynamic cost calculation for transport jobs
✅ Clear dashboards using Windows Forms and DataGridViews
✅ Role-based access control
✅ Data validation and basic exception handling


📂 Included in this Submission:
- Visual Studio project folder:
    - Source code (.cs files)
    - Form designs
    - Compiled executable (.exe in \bin\Debug)
- `eShiftDB.sql` for database creation
- Reflective Essay (Word document)
- Architecture Diagram (PNG)
- Screenshots (optional, for documentation)
- This README.txt


🛡️ Notes:
- Ensure SQL Server authentication is correctly configured.
- If connection issues occur, check `connectionString` values in your code.
- All login and password management are handled directly within the Windows Forms code using SQL queries.

===========================================================
📧 Contact:
[sinalidanodya5@gmail.com]

===========================================================
