<h1 align="center">
  <strong>CRUD-ASP.NET-.NET-C#</strong>
</h1>

<h2 align="center">
  CRUD operations; created with ASP.NET, .NET and C#
</h2>

<div align="center">
  <img src="https://img.shields.io/github/license/gabrielpenteado/crud-aspnet-dotnet-csharp?style=flat-square&color=informational" alt="license"/>

  <img src="https://img.shields.io/static/v1?label=.Net&message=8.0.101&color=informational&style=flat-square" alt="dot net version">
</div>

<br>

### Build with

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQLite](https://img.shields.io/badge/Sqlite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)

### Requirements

- C# 
- ASP.NET (Razor Pages; ASP.NET Identity)
- .NET (v8.0.101)
- [Entity Framework](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

### Instalattion

1. to create a new project.<br>
   `dotnet new razor -o <projectName> --auth Individual` 

2. Install Entity Framework package for SQLite.<br>
   `dotnet add package Microsoft.EntityFrameworkCore.SQLite`

3. Install dotnet-ef.<br>
   `dotnet tool install --global dotnet-ef`

4. Create migrations.<br>
   `dotnet ef migrations add <migrationsName>`

5. Update database.<br>
   `dotnet ef database update`

6. Scaffolding (creating controllers and views with one command).<br>
   `dotnet tool install -g dotnet-aspnet-codegenerator`

7. Generate the code based on Entity Framework.<br>
   `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`

#### To generate the code pages CREATE, EDIT, READ, DETAILS, DELETE for the Student model
`dotnet aspnet-codegenerator razorpage Create Create -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students`<br>
`dotnet aspnet-codegenerator razorpage Edit Edit -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students`<br>
`dotnet aspnet-codegenerator razorpage Index List -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students`<br>
`dotnet aspnet-codegenerator razorpage Details Details -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students`<br>
`dotnet aspnet-codegenerator razorpage Delete Delete -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students`<br>

#### To generate the code pages CREATE, EDIT, READ, DETAILS, DELETE for the Subscrition model
`dotnet aspnet-codegenerator razorpage Create Create -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions`<br>
`dotnet aspnet-codegenerator razorpage Edit Edit -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions`<br>
`dotnet aspnet-codegenerator razorpage Index List -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions`<br>
`dotnet aspnet-codegenerator razorpage Details Details -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions`<br>
`dotnet aspnet-codegenerator razorpage Delete Delete -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions`<br>


- **to run this project:**

1. Clone the repository.<br>
`dotnet tool install --global dotnet-ef`

2. Run Application.<br>
   `dotnet run`
   <br>


## 🤝 Contributions

[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)<br>
The foundation of the open source community are the contributions, them inspire us to learn and create. Any contributions are greatly appreciated.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE.md](https://github.com/gabrielpenteado/crud-aspnet-dotnet-csharp/blob/main/LICENSE.md) file for details.
<br>
<br>

<div align="center">
  <img src="https://images.weserv.nl/?url=avatars.githubusercontent.com/u/63300269?v=4&h=100&w=100&fit=cover&mask=circle&maxage=7d" />
  <h1>Gabriel Penteado</h1>
  <strong>Full Stack Developer</strong>
  <br/>
  <br/>

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/gabriel-penteado)
[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/gabrielpenteado)
[![Gmail](https://img.shields.io/badge/gabripenteado@gmail.com-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:gabripenteado@gmail.com)
<br />
<br />

</div>