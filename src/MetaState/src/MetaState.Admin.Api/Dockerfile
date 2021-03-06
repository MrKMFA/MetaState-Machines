FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/MetaState.Admin.Api/MetaState.Admin.Api.csproj", "src/MetaState.Admin.Api/"]
COPY ["src/MetaState.Admin.EntityFramework.Shared/MetaState.Admin.EntityFramework.Shared.csproj", "src/MetaState.Admin.EntityFramework.Shared/"]
COPY ["src/MetaState.Admin.EntityFramework.SqlServer/MetaState.Admin.EntityFramework.SqlServer.csproj", "src/MetaState.Admin.EntityFramework.SqlServer/"]
COPY ["src/MetaState.Admin.EntityFramework.PostgreSQL/MetaState.Admin.EntityFramework.PostgreSQL.csproj", "src/MetaState.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/MetaState.Shared/MetaState.Shared.csproj", "src/MetaState.Shared/"]
COPY ["src/MetaState.Admin.EntityFramework.MySql/MetaState.Admin.EntityFramework.MySql.csproj", "src/MetaState.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/MetaState.Admin.Api/MetaState.Admin.Api.csproj"
COPY . .
WORKDIR "/src/src/MetaState.Admin.Api"
RUN dotnet build "MetaState.Admin.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MetaState.Admin.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "MetaState.Admin.Api.dll"]