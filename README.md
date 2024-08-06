Title: To Do List Application

Description: 
  + User can read, create, edit and delete notes
  + User can Search to find notes easily and sort by date to track notes comfortably
  + The apearence's application is user-friendly
  + Easy to control
  + Portable and light-weight
    
How to Install and Run the Project:
1. Press the Fork button (top right the page) to save copy of this project on your account.
2. Download the repository files (project) from the download section or clone this project by typing in the bash the following command:
git clone https://github.com/Pluvio-phile8/ToDoList_Manager.git
3. Imported it in Visual Studio or any other C# IDE.
4. Install .NET Framework
5. Open SQL Server and run db script in Database folder
6. Install all the neccessary packages for dao project. You can use the following commands:
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet ef dbcontext scaffold "server =(local); database = ToDoList;uid=username;pwd=password;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models
8. Modify appsettings.json:
{
  "ConnectionStrings": {
    "DBDefault": "Server=(local);uid=username;pwd=password;database=ToDoList; Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
9. Run the application and enjoy!
Screen Shots:
![image](https://github.com/user-attachments/assets/463c6f73-d6fd-4624-bba2-dcf994539d8a)
![image](https://github.com/user-attachments/assets/bc1a0b1a-aee3-4407-bd0e-813d8f069593)

Thank you!
