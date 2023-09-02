# ASP.NETCore Web API Sample

This repository contains a sample project showcasing the implementation of an ASP.NET Core Web API using the latest version of .NET (7). The project follows best practices for clean architecture, utilizes Entity Framework for data access, and employs various design patterns to ensure maintainability and scalability.

# Features & Technologies 🛠️
- ASP.NET Core Web API (.NET 7)
- Entity Framework
- Clean Architecture
- Unit Of Work
- Non-Generic Repository
- Service
- TDD
- Code First Database
- Postgresql

# Database 💾
The project uses PostgreSQL as the database engine. The database schema is generated using the Code-First approach through Entity Framework migrations. Make sure to update the connection string in the 
 _appsettings.json_ file before running the migrations.

# How to use
- Open the solution file Sample.sln in Visual Studio
- update the connection string in the _appsettings.json_ file
- run command update-database
- build/run

# Contributions 🤝
Contributions are welcomed! If you identify areas for improvement, please feel free to raise an issue or submit a pull request.

# License ⚖️
This project is licensed under the MIT License.

