using System.Diagnostics;

namespace TextBasedAdventureGame
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Game object that has map
        /// </summary>
        Map game;

        public MainPage()
        {
            InitializeComponent();
            game = new Map();
            DisplayLocation();
        }

        /// <summary>
        /// Tells the player where they are.
        /// </summary>
        private void DisplayLocation()
        {
            LocationDescriptionLabel.Text = game.PlayerLocation.Description;
            TravelOptionsListView.ItemsSource = game.PlayerLocation.TravelOptions;
        }

        /// <summary>
        /// Click a travel option to move to a new location on the map.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TravelOptionsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            TravelOption to = (TravelOption)TravelOptionsListView.SelectedItem;
            game.PlayerLocation = to.Location;
            DisplayLocation();
        }
    }

}
