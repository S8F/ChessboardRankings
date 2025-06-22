# ChessboardRankings Blazor Application

This Blazor WebAssembly application displays real-time chess leaderboards from the Chess.com API.

## Features

- Fetches and displays top 10 players for various chess formats (Daily, Rapid, Blitz, Bullet, Tactics).
- Presents player information including rank, rating, username, name, title, and game statistics (wins, losses, draws).
- Responsive design.
- Tabbed navigation for switching between leaderboard categories.

## How to Run Locally

1.  **Prerequisites:** .net sdk 8 or later
2.  **Navigate to the project directory:**
    ```bash
    cd ChessboardRankings
    ```
3.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```
4.  **Build the application:**
    ```bash
    dotnet build
    ```
5.  **Run the application:**
    ```bash
    dotnet run
    ```
    The application typically runs on `http://localhost:5000`.

## Project Structure

-   `Data/LeaderboardData.cs`: Defines the C# models for deserializing the Chess.com API response.
-   `Services/LeaderboardService.cs`: Handles fetching data from API.
-   `Pages/Leaderboards.razor`: The main Blazor component responsible for displaying the leaderboards.
-   `Pages/Home.razor`: The application's home page.
-   `Layout/NavMenu.razor`: The navigation menu component (Not used in this project).
-   `wwwroot/index.html`: The main HTML page that hosts the Blazor application.
-   `wwwroot/css/app.css`: Custom CSS for the application's styling.
-   `wwwroot/css/bootstrap/bootstrap.min.css`: Bootstrap CSS framework for responsive design and basic styling.

## API Reference

`https://api.chess.com/pub/leaderboards`.
