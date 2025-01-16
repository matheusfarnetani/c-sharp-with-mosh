using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows;

namespace Asynchronous
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://monkeybuzz.com.br/";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "result.html");
            //try
            //{

            //    await DownloadHtmlAsync(url, filePath);

            //    MessageBox.Show($"HTML content downloaded and saved to {filePath}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            var getHtmlTask = GetHtmlAsync(url);
            MessageBox.Show("Waiting for the task to complete");
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        public async Task DownloadHtmlAsync(string url, string filePath)
        {
            using var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            await using var streamWriter = new StreamWriter(filePath);
            await streamWriter.WriteAsync(html);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }
    }
}