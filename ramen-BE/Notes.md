## Build Steps

- **I think this has been replaced by Startup.cs** Add Routing Table (default in App/WebApiConfig.cs):
    app.UseMVC might be an alternative to route tables
- Add Controller
- Add Models 
- Add Views (*optional) It's a C#-Html hybrid.
- Build it!: "Ctrl+Shift+B" or "dotnet add package Microsoft.AspNet.WebApi.Cors --version 5.2.7 "


## Deployment Steps

- Deploy to local dedicated server using IIS (Internet Information Services).
- Be sure to have CORS: " Install-Package Microsoft.AspNet.WebApi.Cors ":
    -- Enable app.UseCors() in Startup.cs

