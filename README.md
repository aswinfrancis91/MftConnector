# MFT Connector

MFT Connector is an ASP.NET Core application designed to manage file transfers using various Managed File Transfer (MFT) solutions like GoAnywhere and MoveIt. This project provides a simple interface to add users across different MFT platforms using a common API structure. This is just POC.

## Features

- **RESTful API**: Offers endpoints for managing user accounts in MFT services.
- **Extensible Architecture**: Easily extendable to support new MFT clients.

## Technologies Used

- **ASP.NET Core**: Web framework for building the API.
- **C#**: The primary programming language used.
- **SQLite**: For local DB

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- Visual Studio or JetBrains Rider

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/mft-connector.git
   cd mft-connector
   ```

2. Build the solution:

   ```bash
   dotnet build
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

### Configuration

Ensure you configure the necessary HTTP clients in the `appsettings.json` or via dependency injection setup in `Startup.cs`.

## Usage

### REST API Endpoints

#### Add User

- **URL**: `/MftController/AddUser`
- **Method**: `POST`
- **Payload**:

  ```json
  {
  "clientType": 1,
  "firstName": "string",
  "lastName": "string",
  "username": "string",
  "password": "string",
  "email": "string",
  "copyFrom": "string"
  }
  ```

#### Example Request

For adding a user to a GoAnywhere client:

```bash
curl -X 'POST' \
  'https://localhost:7244/Mft/AddUser' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{"ClientType": 1, .....}'
```

## Developing

### Adding New MFT Clients

To add a new MFT client:

1. Implement the `IMftClient` interface in a new class.
2. Register the client in the dependency injection container.
3. Update Factory class to produce the right instances
