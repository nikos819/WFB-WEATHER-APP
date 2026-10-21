
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace PogodaPoznan
{
    public partial class MainWindow : Window
    {
        // Konstruktor okna aplikacji
        public MainWindow()
        {
            // Inicjalizuje elementy interfejsu z pliku XAML
            InitializeComponent();
        }

        // Metoda wywoływana po kliknięciu przycisku
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Pobiera aktualne dane pogodowe
            await PobierzPogode();
        }

        // Metoda pobierająca pogodę z API Open-Meteo
        private async System.Threading.Tasks.Task PobierzPogode()
        {
            try
            {
                // Adres API z koordynatami lokalizacji
                // oraz informacjami o temperaturze i kodzie pogody
                string url = "https://api.open-meteo.com/v1/forecast?latitude=51.426&longitude=17.933&current=temperature_2m,weather_code";

                // Tworzy klienta HTTP do komunikacji z API
                using HttpClient client = new HttpClient();

                // Wysyła zapytanie i pobiera odpowiedź w formacie JSON
                string json = await client.GetStringAsync(url);

                // Odczytuje dane JSON
                using JsonDocument dane = JsonDocument.Parse(json);

                // Pobiera sekcję zawierającą aktualną pogodę
                var pogoda = dane.RootElement.GetProperty("current");

                // Odczytuje temperaturę w stopniach Celsjusza
                double temperatura = pogoda.GetProperty("temperature_2m").GetDouble();

                // Odczytuje kod opisujący aktualne warunki pogodowe
                int kod = pogoda.GetProperty("weather_code").GetInt32();

                // Wyświetla temperaturę w interfejsie aplikacji
                Temperatura.Text = "Temperatura: " + temperatura + " °C";

                // Sprawdza kod pogody i wyświetla odpowiedni opis
                if (kod == 0)
                    Opis.Text = "Pogoda: słonecznie";

                // Kody od 1 do 3 oznaczają różne stopnie zachmurzenia
                else if (kod <= 3)
                    Opis.Text = "Pogoda: pochmurno";

                // Kody od 51 do 82 oznaczają opady
                else if (kod >= 51 && kod <= 82)
                    Opis.Text = "Pogoda: opady";

                // Kody od 95 wzwyż oznaczają burze
                else if (kod >= 95)
                    Opis.Text = "Pogoda: burza";

                // Opis dla pozostałych kodów pogodowych
                else
                    Opis.Text = "Pogoda: możliwe zachmurzenie";

                // Informuje użytkownika, skąd pochodzą dane
                Status.Text = "Dane z Open-Meteo";
            }
            catch
            {
                // Wyświetla komunikat, jeśli pobieranie danych się nie powiedzie
                Status.Text = "Brak połączenia z Internetem.";
            }
        }
    }
}
