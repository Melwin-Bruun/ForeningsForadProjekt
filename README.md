# FöreningsFörådProjekt

## Beskrivning

FöreningsFörådProjekt är en ASP.NET Core MVC-applikation för hantering av föreningars förråd och tillgångar. 

## Funktioner

- Hantering av förråd och föreningstillgångar.
- Användning av SQLite-databas för lagring.
- MVC-struktur med separata Controllers, Models och Views.

## Teknologier

- **ASP.NET Core MVC** – Backend och webbapplikation.
- **SQLite** – Databas.
- **Entity Framework Core** – ORM för databashantering.
- **Bootstrap/CSS** – Styling av gränssnittet.

## Installation

### Starta projektet i Visual Studio

1. **Klona repositoryt**
   ```sh
   git clone https://github.com/ditt-repository/FöreningsFörådProjekt.git
   ```
2. **Öppna projektet**
   - Dubbelklicka på `FöreningsFörådProjekt.sln` för att öppna lösningen i Visual Studio.
3. **Bygg och kör applikationen**
   - Tryck `Ctrl + F5` eller klicka på **Run** i Visual Studio.

### Starta projektet i VS Code

1. **Klona repositoryt**
   ```sh
   git clone https://github.com/ditt-repository/FöreningsFörådProjekt.git
   ```
2. **Navigera till projektmappen**
   ```sh
   cd FöreningsFörådProjekt
   ```
3. **Installera nödvändiga paket**
   ```sh
   dotnet restore
   ```
4. **Starta projektet**
   ```sh
   dotnet run
   ```

## Appens Struktur

```
FöreningsFörådProjekt/
│── Controllers/          # MVC-kontroller
│── Models/               # Datamodeller
│── Views/                # UI-vyer
│── wwwroot/              # Statisk webbplatsinnehåll
│── Program.cs            # Applikationens startpunkt
│── appsettings.json      # Konfigurationsfil
│── WebDB.db              # SQLite-databas
│── FöreningsFörådProjekt.sln  # Visual Studio-lösning
```

## Kända problem

- Se till att du har **.NET SDK** installerat.
- Om databasen inte laddas korrekt, säkerställ att `WebDB.db` finns i roten.
- Vid fel på beroenden, kör:
  ```sh
  dotnet restore
  ```

## Författare

[Melwin Bruun]

## Licens

Denna kod är öppen källkod och kan användas enligt MIT-licensen.
