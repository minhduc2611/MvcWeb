I. First commit 

1. Set up Docker environment 

        docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd@123' -p 1433:1433 microsoft/mssql-server-linux
2. Run MSSQL 
        
        localhost
        sa
        reallyStrongPwd@123

3. Add ConnectionString in appsetting.json
    
        "ConnectionStrings": {
        "eStoreMac": "server=localhost;database=eStore20;user=sa;password=reallyStrongPwd@123"
        },

4. Add Nuget 
        FROM : https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools.DotNet/2.0.0 
    
        dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.0
        
        dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.1.1
        
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 2.1.1

5. scaffold ( database first )

---  add CLI

    dotnet ef dbcontext scaffold "server=localhost;database=eStore20;user=sa;password=reallyStrongPwd@123" Microsoft.EntityFrameworkCore.SqlServer -o Models -c MyDbContext

--- add service in startup.cs: 
    
    services.AddDbContext<MyDbContext>(options => {
    options.UseSqlServer(Configuration.GetConnectionString("eStoreMac"));
    });

6.( No Database Added ) Migration and database update
    
        dotnet ef migrations add InitialCreate
        dotnet ef database update

