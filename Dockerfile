FROM node:19-alpine3.16 as nodeBuild
WORKDIR /app
COPY . .
WORKDIR /app/Blazor/Blazor
RUN npx tailwindcss -i ./Css/app.css -o ./wwwroot/css/app.css --minify


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS dotnetBuild
ARG BuildConfiguration=Release
WORKDIR /app
COPY --from=nodeBuild /app .
WORKDIR /app/Blazor/Blazor
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet restore
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet publish -c ${BuildConfiguration} -o /publish


FROM nginx:1.23.3-alpine AS webserver
ARG BuildConfiguration=Release
WORKDIR /app
COPY --from=dotnetBuild /publish/wwwroot /usr/share/nginx/html
#COPY --from=dotnetBuild /app/publish/wwwroot/appsettings.${BuildConfiguration}.json /usr/share/nginx/html/appsettings.json
EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_ENVIRONMENT=$BuildConfiguration