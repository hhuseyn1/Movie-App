using Microsoft.VisualBasic.Devices;
using Movie_App.MyControls;
using System.ComponentModel.Design;
using System.Net.Http;
using System.Text.Json;
#nullable disable
namespace Movie_App
{
    public partial class Form1 : Form
    {
        List<MovieControl> Movies;
        public Form1()
        {
            InitializeComponent();
            LoadMovies();
        }
        const string _apikey = "38c756b8";
        const string _url = $"http://www.omdbapi.com/?apikey={_apikey}&";
        private  async void LoadMovies()
        {
            
            
            Movies = new List<MovieControl>()
            {
            new MovieControl()
                {
                    Name="Thor",
                    Language="English",
                    Genre="Action Adventure"
                },
                new MovieControl()
                {
                    Name="Baby Driver",
                    Language="English",
                    Genre="Action"
                },
                new MovieControl()
                {
                    Name="Central Intelligence",
                    Language="English",
                    Genre="Action Adventure"
                }



            };
            foreach (MovieControl item in Movies)
            {          
                flwLayPanel_Movies.Controls.Add(item);
            }

            for (int i = 0; i < Movies.Count; i++)
            {
                string searchLoad = $"{_url}t={Movies[i].Name}";
                using HttpClient httpClient = new HttpClient();
                var jsonResult = await httpClient.GetStringAsync(searchLoad);
                var movie = JsonSerializer.Deserialize<MovieControl>(jsonResult);
                Movies[i].pctBox_Movie.Load(movie?.Poster);
            }

        }

       

        private async void MovieSearch_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(MovieSearch_txtbox.Text) || string.IsNullOrWhiteSpace(MovieSearch_txtbox.Text))
            {
                MessageBox.Show("Invalid movie name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                flwLayPanel_Movies.Controls.Clear();
                string searchName = $"{_url}t={MovieSearch_txtbox.Text}";
                using HttpClient httpClient = new HttpClient();
                var jsonResult = await httpClient.GetStringAsync(searchName);
                var movie = JsonSerializer.Deserialize<MovieControl>(jsonResult);
                MovieControl mc=new MovieControl()
                {
                    Name = MovieSearch_txtbox.Text,
                    Genre = movie.Genre,
                    Language = movie.Language
                };
                mc.pctBox_Movie.Load(movie?.Poster);
                flwLayPanel_Movies.Controls.Add(mc);

            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MovieSearch_txtbox.Text = null;
            flwLayPanel_Movies.Controls.Clear();
            LoadMovies();
        }
    }
}