# Simple Task Manager

A basic ASP.NET Core MVC app to manage a user's own tasks with sorting and filtering functionality with the help of ASP.NET Core Identity Login & Registration.

## Features

- Add, edit, and delete tasks
- Filter by completion status
- Sort by due date
- Store task data in a database
- Login & Regustraion;

## Setup Instruction

1. Clone the repository:
   git clone https://github.com/AbdullahAlid/SimpleTaskManager.git
2. Open in Visual Studio
3. Create own database and put own database connection string on appsettings.json where the project's connection string stays.
4. In Package manager console write upgrade-database;
5. Run the project

## Technologies Used

- ### Framework: .net 9
- ### Tools: Visusal Studio
- ### Packages: Microsoft.AspNetCore.Identity.EntityFrameworkCore, Microsoft.EntityFrameworkCore" Version="9.0.5",Microsoft.EntityFrameworkCore.SqlServer", Microsoft.EntityFrameworkCore.Tools
