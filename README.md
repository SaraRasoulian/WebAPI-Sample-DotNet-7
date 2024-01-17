## ASP.NETCore Web API Sample

This repository is a sample ASP.NET Core Web API (.NET 7) project.

## Features & Technologies
- ASP.NET Core Web API
- Entity Framework Core
- Clean Architecture
- Unit Of Work Pattern
- Repository Service Pattern
- TDD
- PostgreSQL
- Docker

## Get started

#### 1. Clone the repository

```
git clone https://github.com/SaraRasoulian/WebAPI-Sample.git
```
#### 2. Start with docker compose

Make sure [docker](https://docs.docker.com/get-docker/) is installed on your machine.

Run the following command in project directory:

```
docker-compose up -d # build images, create and run containers in background
```

Docker compose in this project includes: web api application, postgres and pgadmin4.

- Web api application will be running and listening at `http://localhost:5000`

- Postgres at `http://localhost:5433`

- Pgadmin4 at `http://localhost:8080`


#### 3. Run the migrations

Open Sample.sln file in visual studio, then in package manager console tab, run:

```
update-database
```

This command will generate the database schema in postgres container.

## Contributions
Contributions are welcomed! If you identify areas for improvement, please feel free to raise an issue or submit a pull request.
