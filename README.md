# ChessboardRankings Blazor Application

This Blazor WebAssembly application displays real-time chess leaderboards from the Chess.com API.

## Features

- Fetches and displays top players for various chess formats (Daily, Rapid, Blitz, Bullet, Tactics).
- Presents player information including rank, rating, username, name, title, and game statistics (wins, losses, draws).
- Responsive design for optimal viewing on different devices.
- Tabbed navigation for easy switching between leaderboard categories.

## How to Run Locally

1.  **Prerequisites:** Ensure you have the .NET SDK (version 8.0 or later) installed.
2.  **Clone the repository:** (If applicable, otherwise, assume the project is already in the current directory)
3.  **Navigate to the project directory:**
    ```bash
    cd ChessboardRankings
    ```
    4.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```
5.  **Build the application:**
    ```bash
    dotnet build
    ```
6.  **Run the application:**
    ```bash
    dotnet run
    ```
    The application will typically run on `http://localhost:5000` or a similar port.

## Project Structure

-   `Data/LeaderboardData.cs`: Defines the C# models for deserializing the Chess.com API response.
-   `Services/LeaderboardService.cs`: Handles fetching data from the Chess.com API.
-   `Pages/Leaderboards.razor`: The main Blazor component responsible for displaying the leaderboards and handling UI interactions.
-   `Pages/Home.razor`: The application's home page.
-   `Layout/NavMenu.razor`: The navigation menu component.
-   `wwwroot/index.html`: The main HTML page that hosts the Blazor application.
-   `wwwroot/css/app.css`: Custom CSS for the application's styling.
-   `wwwroot/css/bootstrap/bootstrap.min.css`: Bootstrap CSS framework for responsive design and basic styling.

## API Reference

This application uses the public Chess.com API, specifically the leaderboards endpoint: `https://api.chess.com/pub/leaderboards`.
