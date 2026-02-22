🎓 Student CRUD Application  ASP.NET Core & Entity Framework Core (Database First)
📌 Project Overview
I am currently learning **ASP.NET Core and Entity Framework Core**, and this project was developed using the **Database First Approach** to connect an existing SQL Server database with an ASP.NET Core application.
This project demonstrates how to generate models and DbContext from an existing database and implement **CRUD operations** in a web application. It is part of my hands-on learning journey to apply theoretical concepts to real-world applications.
 
 🚀 Features
✅ Create new student records
✅ View all students data
✅ Update student information
✅ Delete student records
✅ Database integration using **Database First** approach
✅ Structured MVC-based application

---
 🛠️ Technologies Used

* **C#**
* **ASP.NET Core MVC**
* **.NET**
* **Entity Framework Core (Database First)**
* **SQL Server**
* **HTML, CSS, Bootstrap**
* **Visual Studio**

---
 🧱 Project Architecture
The application follows the **Model–View–Controller (MVC)** pattern:
* **Models** → Auto-generated from the existing database using EF Core Scaffold-DbContext
* **Views** → User interface for CRUD operations
* **Controllers** → Handle requests and application logic

---
🗄️ Database Information

Database Name: `CodeFirstDB` 
The `Students` table already exists in the database.
Students Table Structure

| Column Name   | Description                        |
| ------------- | ---------------------------------- |
| StudentId     | Unique identifier for each student |
| StudentName   | Name of the student                |
| StudentAge    | Age of the student                 |
| StudentGender | Gender of the student              |

---
 ⚙️ Setup Instructions
 1️⃣ Clone the Repository

```bash
git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
```
2️⃣ Open the Project

Open the solution (`.sln`) file using **Visual Studio**.
3️⃣ Configure Connection String

Update `appsettings.json`:

```json
"ConnectionStrings": {
  "dbcs": "Server=localhost;Database=CodeFirstDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
4️⃣ Scaffold Database Models (if not already included)

Open **Package Manager Console** and run:

```powershell
Scaffold-DbContext "Server=localhost;Database=CodeFirstDB;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context DatabaseFirstDBContext
```
This command generates the **DbContext** and **entity classes** from the existing database.
5️⃣ Run the Application
Press:

```
Ctrl + F5
```

or run the project from Visual Studio.

---
🎯 Learning Objectives
Through this project, I practiced and learned:
* Connecting an **existing database** using EF Core (Database First)
* ASP.NET Core MVC workflow
* CRUD operations implementation
* SQL Server integration with .NET applications
* Scaffold-DbContext command and auto-generated models

---
👩‍💻 Author

**Nida Arshad**
Computer Science Student | Learning ASP.NET Core & Backend Development

---
🌱 Learning Journey

This repository is part of my continuous learning journey in backend and web development, focusing on practical implementation of real-world databases with .NET.

---
⭐ Future Improvements

* Search and filtering functionality
* Pagination support
* Authentication & authorization
* REST API development
* UI enhancements

---
📄 License
This project is created for educational and learning purposes.
