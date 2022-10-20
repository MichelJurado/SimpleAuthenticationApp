﻿Steps to incorporate authentication 

1. Install the following
- Dapper
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

2. Create a table in SQL 

3. Edit appsettings.json with correct connection string

4. Create Authentication Folder 

5. Add CustomAuthenticationStateProvider.cs
   Add UserAccount.cs
   Add UserAccountService.cs
   Add UserSession.cs

6. Add these services to Program.cs
	builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
	builder.Services.AddAuthenticationCore();
	builder.Services.AddSingleton<UserAccountService>();

7. Create Login page

8. Edit Shared/NavMenu with Authorization Views

Videos and articles I used to help me create this project.
- https://www.youtube.com/watch?v=iq2btD9WufI (Blazor Authentication)
- https://www.youtube.com/watch?v=nsZNCr7q4gE (Using Dapper CRUD functions in Blazor)
- https://www.learndapper.com/stored-procedures (Stored procedures with dapper)

![Screenshot 2022-10-20 142414](https://user-images.githubusercontent.com/104876738/197031271-65c5c14b-251d-4149-a327-09dc030b5f6a.png)
![Screenshot 2022-10-20 142445](https://user-images.githubusercontent.com/104876738/197031275-ac3ee9e5-161d-47f6-98f8-936db2b8f19e.png)

