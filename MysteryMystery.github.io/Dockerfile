# Build Time
FROM mcr.microsoft.com/dotnet/sdk:8.0.404-bookworm-slim-amd64 as Build 
WORKDIR /app

# System Dependencies
RUN apt update 
RUN apt upgrade -y
RUN apt install nodejs npm -y

COPY . . 

# App Dependencies
RUN dotnet workload restore MysteryMystery.github.io/MysteryMystery.github.io.csproj
RUN dotnet restore MysteryMystery.github.io/MysteryMystery.github.io.csproj
RUN npm install 

# Test
RUN dotnet test MysteryMystery.github.io/MysteryMystery.github.io.csproj

# Publish
RUN dotnet publish MysteryMystery.github.io/MysteryMystery.github.io.csproj -c Release -o publish

# Runtime
FROM nginx:1.27.3-alpine-slim as Publish 
COPY --from=Build app/publish/wwwroot /usr/share/nginx/html

EXPOSE 80
