# Apoptoosi

## How do I drive this?
Seuraa linkin ohjeita.

    https://www.microsoft.com/net/learn/get-started-with-dotnet-tutorial#linuxubuntu

Asennetaan EnityFramework slqitelle

    >>dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    >>dotnet add package Microsoft.EntityFrameworkCore.Design

Ajetaan db käyttöön 

    >>dotnet ef migrations add InitialCreate
    >>dotnet ef database update

Komentoriviltä

    ../Apoptoosi/apoptoosi>>dotnet run

Voilá! Nettisivun pitäisi löytyä toimintakuntoisena komentorivillä lukevassa osoitteessa.

Esimerkiksi

    ...
    Now listening on: https://localhost:5001
    Now listening on: http://localhost:5000
    ...

API kutsuja voi kokeilla esimerkiksi tekemällä kutsun

    http://localhost:5000/api/registrationData/registrations

