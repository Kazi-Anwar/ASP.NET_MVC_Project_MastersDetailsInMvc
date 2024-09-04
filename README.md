# ASP.NET MVC Project: Masters and Details Management

This repository contains an ASP.NET MVC web application designed to manage "Masters" and "Details" data. The project showcases a practical implementation of the ASP.NET MVC framework for creating, reading, updating, and deleting records, with a focus on demonstrating a common use case in web applications.

## Features

- **CRUD Operations**: Complete Create, Read, Update, and Delete functionality for both Masters and Details entities.
- **MVC Architecture**: Implements the Model-View-Controller (MVC) design pattern to separate concerns.
- **Entity Framework**: Utilizes Entity Framework for data access and ORM (Object-Relational Mapping).
- **Bootstrap Integration**: Uses Bootstrap for responsive and modern UI design.
- **Validation**: Includes server-side validation for data integrity.

## Getting Started

### Prerequisites

- **.NET Framework**: Ensure you have the .NET Framework installed. This project is built on ASP.NET MVC, which requires the .NET Framework.
- **IDE**: Use Visual Studio for development and running the application.

### Installation

1. **Clone the Repository**

   ```sh
   git clone https://github.com/Kazi-Anwar/ASP.NET_MVC_Project_MastersDetailsInMvc.git
   ```

2. **Navigate to the Project Directory**

   ```sh
   cd ASP.NET_MVC_Project_MastersDetailsInMvc
   ```

3. **Open the Solution**

   Open the `.sln` file with Visual Studio.

4. **Restore NuGet Packages**

   If you're using Visual Studio, it will typically restore the necessary NuGet packages automatically. Otherwise, run:

   ```sh
   dotnet restore
   ```

5. **Build the Project**

   Build the solution to ensure everything is set up correctly:

   ```sh
   dotnet build
   ```

6. **Update Database**

   Apply any pending migrations to the database:

   ```sh
   dotnet ef database update
   ```

7. **Run the Application**

   Start the application from Visual Studio by pressing `F5` or using the `dotnet run` command if you're using the command line.

## Usage

After running the application, you can use the web interface to manage Masters and Details records:

1. **Manage Masters**: Create, view, update, and delete master records.
2. **Manage Details**: Create, view, update, and delete details associated with each master record.
3. **Validation**: Input data validation is enforced on both the client-side

and server-side to ensure data integrity.

## Project Structure

- **Models**: Contains the classes that represent the data structure and business logic.
- **Views**: Contains Razor view files (.cshtml) for rendering HTML and presenting data to users.
- **Controllers**: Contains classes that handle user input, interact with models, and return views.
- **Data**: Contains the Entity Framework DbContext and migration files.
- **Scripts**: Contains JavaScript files for client-side functionality.
- **Content**: Contains CSS and other static files used for styling.

## Configuration

- **Database Connection**: Configure your database connection string in `Web.config`. Ensure that the connection string matches your database setup.

  ```xml
  <connectionStrings>
    <add name="DefaultConnection" connectionString="Your_Connection_String" providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```

- **Entity Framework**: Ensure Entity Framework is set up correctly and migrations are applied to the database.

## Contributing

Contributions to this project are welcome. Please follow these steps to contribute:

1. **Fork the Repository**
2. **Create a New Branch**
3. **Make Your Changes**
4. **Commit Your Changes**
5. **Push to Your Fork**
6. **Open a Pull Request**

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Contact

For any questions or issues, please [contact me on GitHub](https://github.com/Kazi-Anwar).
