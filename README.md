

# Formula Blazor

![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg)

**Formula Blazor** is a simple app made in **.NET 7** and **Blazor** to display certain Formula 1 information about drivers, teams, circuits, standings and race calendar in every season. 
The App is developed in Blazor, with the use of MudBlazor material design components with "features folder architecture" in mind. 
All data is fetched from Ergast F1 API and Wikipedia using a simple HTTPClient.

* Design is not finalized yet, and focus was mainly on backend aspect.

## Dashboard Index layout
* More screenshots can be found in assets folder

## Libraries

- [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [MudBlazor](https://mudblazor.com/)
- [Ergast API](https://ergast.com/)
- [Wikipedia API](https://en.wikipedia.org/api/rest_v1/)

## Setup and Deployment
- Clone the repository
- Build and run, should work out of the box
- **Azure Deployment**
  - Follow [Host and deploy Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/server?view=aspnetcore-7.0) to deploy, it should already be okay right out of the box.

- **Docker**
  - Deployment with Docker should also work thanks to .NET 7 new [container support Microsoft.NET.Build.Containers](https://devblogs.microsoft.com/dotnet/announcing-builtin-container-support-for-the-dotnet-sdk/)
    - dotnet publish --os linux --arch x64 -c Release -p:PublishProfile=DefaultContainer
    - docker run -it --rm -p 5010:80 FormulaBlazor:1.0.0

## Resources

The app is using data from [Ergast API](http://ergast.com/mrd/) and [Wikipedia API](https://en.wikipedia.org/api/rest_v1/)
