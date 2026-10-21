# Pogoda Poznań

## Opis projektu

Pogoda Poznań to prosta aplikacja desktopowa napisana w języku C# z wykorzystaniem technologii WPF. Aplikacja pobiera aktualne dane pogodowe z API Open-Meteo i wyświetla temperaturę oraz opis warunków atmosferycznych.

## Funkcje

- Pobieranie aktualnej temperatury w stopniach Celsjusza.
- Wyświetlanie opisu aktualnych warunków pogodowych.
- Pobieranie danych z API Open-Meteo.
- Obsługa błędów połączenia z Internetem.
- Prosty interfejs graficzny z przyciskiem do pobierania pogody.

## Technologie

- C#
- WPF (Windows Presentation Foundation)
- .NET
- HttpClient
- System.Text.Json
- Open-Meteo API

## Źródło danych

Aplikacja korzysta z darmowego API pogodowego Open-Meteo.

https://open-meteo.com/

Dane pogodowe pobierane są na podstawie współrzędnych geograficznych zapisanych w adresie API.

## Uruchomienie projektu

1. Sklonuj repozytorium na swój komputer.
2. Otwórz projekt w Visual Studio.
3. Upewnij się, że masz zainstalowane środowisko .NET obsługujące WPF.
4. Uruchom aplikację za pomocą przycisku Start lub klawisza F5.
5. Kliknij przycisk w aplikacji, aby pobrać aktualne dane pogodowe.

## Jak działa aplikacja?

1. Użytkownik klika przycisk w interfejsie.
2. Aplikacja wysyła zapytanie HTTP do API Open-Meteo.
3. Otrzymana odpowiedź w formacie JSON jest analizowana.
4. Program odczytuje temperaturę i kod pogody.
5. Na ekranie wyświetlana jest temperatura oraz opis warunków pogodowych.
6. W przypadku błędu wyświetlany jest komunikat o braku połączenia z Internetem.

## Możliwości rozwoju

- Dodanie możliwości wyboru miasta.
- Wyświetlanie prędkości wiatru i wilgotności.
- Dodanie prognozy pogody na kolejne dni.
- Ulepszenie wyglądu interfejsu graficznego.
- Dodanie ikon przedstawiających warunki pogodowe.

## Autor

Projekt edukacyjny wykonany w języku C# z wykorzystaniem technologii WPF.

## Licencja

Projekt udostępniony do celów edukacyjnych.
