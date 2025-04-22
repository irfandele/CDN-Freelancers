# CDN Freelancers Management System

A web-based freelancer management system built with ASP.NET Core, allowing you to manage freelancer profiles, track their skills, and maintain their contact information.

## Features

- 📝 Create and manage freelancer profiles
- 🔍 Search and filter freelancers
- 📊 View freelancer details in a clean, organized table
- ✏️ Edit existing freelancer information
- 🗑️ Delete freelancer records
- 📱 Responsive design for all devices
- 🔄 Real-time status tracking (Active/Inactive)

## Prerequisites

Before you begin, ensure you have the following installed:
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (recommended) or [Visual Studio Code](https://code.visualstudio.com/)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/CDNFreelancers.git
   cd CDNFreelancers
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Access the application:
   - Main application: http://localhost:5002
   - View Freelancers: http://localhost:5002/view.html
   - Add Freelancer: http://localhost:5002/create.html
   - API Documentation: http://localhost:5002/swagger

## Project Structure

```
CDNFreelancers/
├── Controllers/
│   └── UserController.cs      # API endpoints for user management
├── Data/
│   └── ApplicationDbContext.cs # Database context and configuration
├── Models/
│   └── User.cs                # User model definition
├── wwwroot/
│   ├── create.html            # Add new freelancer page
│   └── view.html             # View freelancers page
├── Program.cs                 # Application entry point
└── appsettings.json          # Configuration settings
```

## Database Schema

The `User` table contains the following fields:
- `Id` (int): Primary key
- `Username` (string): Freelancer's username
- `Email` (string): Contact email address
- `PhoneNumber` (string): Contact phone number
- `Skillsets` (string): Freelancer's skills
- `Hobby` (string, nullable): Optional hobby
- `IsActive` (bool): Account status

## API Endpoints

### User Management
- `GET /api/user` - Get all freelancers
- `GET /api/user/{id}` - Get specific freelancer
- `POST /api/user` - Create new freelancer
- `PUT /api/user/{id}` - Update freelancer
- `DELETE /api/user/{id}` - Delete freelancer

### Example API Usage

Create a new freelancer:
```http
POST /api/user
Content-Type: application/json

{
    "username": "john_doe",
    "email": "john@example.com",
    "phoneNumber": "1234567890",
    "skillsets": "C#, JavaScript, React",
    "hobby": "Reading"
}
```

## Development

### Adding New Features
1. Create necessary model changes in `Models/`
2. Add migrations: `dotnet ef migrations add MigrationName`
3. Apply migrations: `dotnet ef database update`
4. Update controllers and views as needed

### Running Tests
```bash
dotnet test
```

## Troubleshooting

### Common Issues

1. **Database Connection Error**
   - Ensure SQL Server LocalDB is installed
   - Check connection string in `appsettings.json`
   - Verify database exists: `dotnet ef database update`

2. **Port Already in Use**
   - Change port in `Program.cs` or
   - Kill process using the port: `taskkill /F /PID <process_id>`

3. **Migration Errors**
   - Remove migrations: `dotnet ef migrations remove`
   - Drop database: `dotnet ef database drop -f`
   - Recreate migrations: `dotnet ef migrations add InitialCreate`

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- ASP.NET Core team
- Entity Framework Core
- Bootstrap
- SQL Server LocalDB

## Contact
irfanhaneef10@gmail.com
Project Link: [https://github.com/irfandele/CDNFreelancers]
