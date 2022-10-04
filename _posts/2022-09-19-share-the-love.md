---
layout: post
date:   2022-09-19 13:26:53 +0100
categories: projects

avatar_url: /img/share-the-love.png
title: Share the Love
lead: A C# backend paired with a React frontend and deployed to a raspberry pi using docker-compose.
description: This project is currently private. I can add you as a collaborator on request.
website_url: https://github.com/MysteryMystery/share-the-love
---

# Share the Love

Share the love is a simple web app made for sharing embed links from sites such as youtube and vimeo, and storing them all in one place. This application comprises of a React.js frontend, Dotnet Core 6 backend using Entity Framework to facilitate the data access layer and scaffold migrations which are applied to the SQL Server database. Due to licensing issues I am currently in the process of migrating this to Postgres SQL so that the database server can be containerised on the arm32v7 architecture. 