# -------- Build Stage --------
    # ----This downloads the .NET 8 SDK image.------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build  


# creates a working folder under the container
WORKDIR /src 
# copies entire code 
COPY . . 

RUN dotnet restore "DevOpsDashboard.csproj" 
# downloads all nuget packages

# creates op for deplyment (generates files application  requirs for production

RUN dotnet publish "DevOpsDashboard.csproj" -c Release -o /app/publish 

# -------- Runtime Stage --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

 # copies the published op from build image above

COPY --from=build /app/publish .


EXPOSE 80 
 # docker run this cmd when container starts
ENTRYPOINT ["dotnet", "DevOpsDashboard.dll"]  