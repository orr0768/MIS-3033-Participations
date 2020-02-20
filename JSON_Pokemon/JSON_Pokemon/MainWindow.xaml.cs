using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string path = "https://pokeapi.co/api/v2/pokemon?offset=20&limit=1000";
            AllPokemonAPI PokemonAPI;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;

                PokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

            }

            foreach (var pokemon in PokemonAPI.results)
            {
                lstResults.Items.Add(pokemon);

            }

            btnBack.IsEnabled = false;
            btnFront.IsEnabled = false;



        }



        private void lstResults_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            AllPokemonResult selectedCharacterfromlist = (AllPokemonResult)lstResults.SelectedItem;

            PokieInfo PokieAPI;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(selectedCharacterfromlist.url).Result;

                PokieAPI = JsonConvert.DeserializeObject<PokieInfo>(json);

            }



            imgPokemon.Source = new BitmapImage(new Uri(PokieAPI.sprites.front_default);
            btnBack.IsEnabled = true;
            btnFront.IsEnabled = true;



        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            imgPokemon.Source = new BitmapImage(new Uri(PokieAPI.sprites.back_default));
        }

        private void BtnFront_Click(object sender, RoutedEventArgs e)
        {
            imgPokemon.Source = new BitmapImage(new Uri(PokieAPI.sprites.front_default));
        }
    }
}

