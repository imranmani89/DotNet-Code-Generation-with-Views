# Sample Project using DotNet Code Generator with Views

## Packages Required
We used a database-first approach to scaffold and generate models and dbContext files using Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.Tools, Microsoft.EntityFrameworkCore.SqlServer and Micrsoft.EntityFrameworkCore.Design Libraries.

## Steps:
1. After Creating the table. Copy the Database Connection String to the appSettings.json file.
Now use the following command in Nuget Package Manager:
> Scaffold-DbContext "YourConnectionString" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -v
2. Add the following code in program.cs file after "builder.Services.AddControllersWithViews();" line.
> builder.Services.AddDbContext&lt;TestDBContext&gt;();
3. Install AspNet.CodeGenerator library using the following command in cmd
> dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.0
4. install AspNet.CodeGenerator.Design library using the following command in cmd
> dotnet tool install --global  Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.0
5. Finally Apply the following command and it will create the controller along with views
>  dotnet aspnet-codegenerator controller -name YourControllerName -m YourModelName -dc YourDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --force


voila! Happy Coding :relaxed:
