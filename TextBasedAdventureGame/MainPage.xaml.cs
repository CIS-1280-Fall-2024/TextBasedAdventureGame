using System.Diagnostics;

namespace TextBasedAdventureGame
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Game object that has map
        /// </summary>
        Map map;
        Player player;

        public MainPage()
        {
            InitializeComponent();
            map = new Map();
            player = new Player(map.Locations[0]);
            UpdateDisplay();
            Debug.WriteLine("Main page start");
        }

        private void UpdateDisplay()
        {
            //Update display
            LocationDescriptionLabel.Text = player.Location.Description;
            TravelOptionsListView.ItemsSource = null;
            TravelOptionsListView.ItemsSource = player.Location.TravelOptions;
            InventoryListView.ItemsSource = null;
            InventoryListView.ItemsSource = player.Inventory;
            ItemsListView.ItemsSource = null;
            ItemsListView.ItemsSource = player.Location.Items;
        }

        /// <summary>
        /// Click a travel option to move to a new location on the map.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TravelOptionsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            TravelOption to = (TravelOption)TravelOptionsListView.SelectedItem;
            player.Location = to.Location;
            UpdateDisplay();
        }

        private void ItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           // TakeItem();
        }

        private void TakeButton_Clicked(object sender, EventArgs e)
        {
            TakeItem();
        }
        private void TakeItem()
        {
            if (ItemsListView.SelectedItem is IPortable)
            {
                if (player.AddInventoryItem((IPortable)ItemsListView.SelectedItem))
                {
                    player.Location.Items.Remove((GameObject)ItemsListView.SelectedItem);
                }
                else
                {
                    GameStatusLabel.Text = "No more room in inventory.";
                }
                UpdateDisplay();
            }
            else
            {
                GameStatusLabel.Text = "You can't lift that!";
            }
            UpdateDisplay();
        }


        private void InventoryListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DropItem();
        }
        private void DropInventoryItemButton_Clicked(object sender, EventArgs e)
        {
            DropItem();
        }

        private void DropItem()
        {
            player.Location.Items.Add((GameObject)InventoryListView.SelectedItem);
            player.RemoveInventoryItem((IPortable)InventoryListView.SelectedItem);
            UpdateDisplay();
        }

        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            if (ItemsListView.SelectedItem is IHidingPlace)
            {
                IHidingPlace hidingPlace = (IHidingPlace)ItemsListView.SelectedItem;
                GameObject foundItem = hidingPlace.Search();
                if (foundItem != null)
                {
                    player.Location.Items.Add(foundItem);
                    UpdateDisplay();
                }
                else
                {
                    GameStatusLabel.Text = "Nothing found.";
                }
            }
            UpdateDisplay();
        }
    }

}
