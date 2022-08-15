# Bookshop
A solution for the tech test problem posed by LH.

## Instructions
To run this app, you must first ensure the following are installed and available:
- Needs httprepl installed. Use **dotnet tool install -g Microsoft.dotnet-httprepl**
- Open the Visual Studio solution
- Check that the Nuget Package "Microsoft.EntityFrameworkCore.InMemory" has correctly come with the solution
- Hit RUN, and then open a command line instance. Access the API by using **httprepl** commands

To see the seeded database, run the app. A Window will open at https://localhost:5001/api/bookshop, and will be available for connection via command line.
- The database is automatically seeded using a **DbInitialiser**, found in **../Components/DbInit**
- Connect using **httprepl https://localhost:5001/api/bookshop** to test
