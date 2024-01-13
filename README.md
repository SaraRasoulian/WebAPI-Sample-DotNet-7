## ASP.NETCore Web API Sample

This repository is a sample ASP.NET Core Web API (.NET 7) project.

## Features & Technologies
- ASP.NET Core Web API
- Entity Framework Core
- Clean Architecture
- Unit Of Work Pattern
- Repository Service Pattern
- TDD
- Docker

## Get started

#### 1. Clone the repository

`git clone https://github.com/SaraRasoulian/ASP.NETCore-WebAPI-Sample.git`


#### 2. Run the app within Docker

Make sure [Docker](https://docs.docker.com/get-docker/) is installed on your machine.

To start local development, run:

`docker compose up`

The application will be running and listening at `http://localhost:5000`

#### 3. Run the migrations

Open the `Sample.sln` in visual studio and in the Package Manager Console tab, run:

`update-database`

This command will generate the database schema in the postgres container

## Contributions
Contributions are welcomed! If you identify areas for improvement, please feel free to raise an issue or submit a pull request.
