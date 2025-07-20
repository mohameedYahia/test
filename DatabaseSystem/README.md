# Database System

This project is a database management system built using .NET. It is structured into multiple layers to promote separation of concerns and maintainability.

## Project Structure

- **src/DatabaseSystem.Api**: Contains the API layer of the application.
  - **Controllers**: Handles incoming HTTP requests and returns responses.
  - **Models**: Contains data transfer objects (DTOs) and view models.
  - **Services**: Encapsulates the business logic of the application.
  - **Program.cs**: Entry point of the API application.

- **src/DatabaseSystem.Core**: Contains the core functionality and business logic.
  - **Entities**: Represents the data models in the application.
  - **Interfaces**: Defines contracts for repositories and services.
  - **Core.cs**: Contains shared logic used across the application.

- **src/DatabaseSystem.Infrastructure**: Contains the infrastructure layer for data access.
  - **Data**: Includes the database context class and repository implementations.
  - **Migrations**: Contains migration files for managing database schema changes.
  - **Infrastructure.cs**: Configures the infrastructure layer, including database connections.

- **src/DatabaseSystem.Tests**: Contains unit tests for the application.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd DatabaseSystem
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run --project src/DatabaseSystem.Api/DatabaseSystem.Api.csproj
   ```

## Usage

Once the application is running, you can access the API endpoints at `http://localhost:5000`. Refer to the API documentation for available endpoints and their usage.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.