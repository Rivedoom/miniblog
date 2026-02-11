# MiniBlog – ASP.NET Core MVC

Prosty mini-blog wykonany w ASP.NET Core MVC z wykorzystaniem Entity Framework Core.

## Opis projektu

Aplikacja umożliwia:

- Wyświetlanie listy wpisów
- Dodawanie nowego wpisu (tytuł + treść)
- Edycję wpisu
- Usuwanie wpisu
- Walidację danych (Required)
- Automatyczne tworzenie bazy danych przy użyciu migracji

Projekt został wykonany w architekturze MVC.

---

## Technologie

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB
- Bootstrap

---

## Model danych

### Post

- Id (int)
- Title (string, wymagane)
- Content (string, wymagane)
- CreatedAt (DateTime)

---

## Uruchomienie projektu

1. Otwórz projekt w Visual Studio 2022
2. Wykonaj migracje:
