# OnlineWebStore

## Theme / Core idea
A ASP.NET Core MVC project that is based on the idea of web store or marketplace. Utilising Identity management.

## Back-End
Project name: `WebStore.DataAccess`
Project type: `Class library`

NuGet packages used: 
- Microsoft.EntityFrameworkCore (8.0.7)
- Microsoft.EntityFrameworkCore.SqlServer (8.0.7)
- Microsoft.EntityFrameworkCore.Tools (8.0.7)
- Serilog (4.0.0)
- Serilog.AspNetCore (8.0.1)
- Serilog.Sinks.Console (6.0.0)
- Serilog.Sinks.File (5.0.0)

> [!NOTE]
> Project responsible for server-side validations, conditional logic operations and queries to the local database using Entity Framework Core.

## Front-End
Project name: `WebStoreMVC`
Project type: `ASP.NET Core MVC`

NuGet packages used: 
- Serilog.AspNetCore (8.0.1)
- Serilog.Sinks.Console (6.0.0)
- Serilog.Sinks.File (5.0.0)

References: `WebStore.DataAccess`

> [!NOTE]
> A controller and front-end aspect regarding the project.
