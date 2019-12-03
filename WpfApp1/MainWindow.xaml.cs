using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> allActivities = new List<Activity>();
        List<Activity> chosenActivities = new List<Activity>();
        List<Activity> filteredActivities = new List<Activity>();


        public MainWindow()
        {
            InitializeComponent();
        }


        #region extramethods

        #endregion extramethods

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create some activites
            Activity l1 = new Activity()
            {
                Name = "Treking",
                Description = "Instructor led group trek through local mountains.",
                ActivityDate = new DateTime(2019, 06, 01),
                TypeOfActivity = "Land",
                Cost = 20m
            };

            Activity l2 = new Activity()
            {
                Name = "Mountain Biking",
                Description = "Instructor led half day mountain biking.  All equipment provided.",
                ActivityDate = new DateTime(2019, 06, 02),
                TypeOfActivity = "Land",
                Cost = 30m
            };

            Activity l3 = new Activity()
            {
                Name = "Abseiling",
                Description = "Experience the rush of adrenaline as you descend cliff faces from 10-500m.",
                ActivityDate = new DateTime(2019, 06, 03),
                TypeOfActivity = "Land",
                Cost = 40m
            };

            Activity w1 = new Activity()
            {
                Name = "Kayaking",
                Description = "Half day lakeland kayak with island picnic.",
                ActivityDate = new DateTime(2019, 06, 01),
                TypeOfActivity = "Water",
                Cost = 40m
            };

            Activity w2 = new Activity()
            {
                Name = "Surfing",
                Description = "2 hour surf lesson on the wild atlantic way",
                ActivityDate = new DateTime(2019, 06, 02),
                TypeOfActivity = "Water",
                Cost = 25m
            };

            Activity w3 = new Activity()
            {
                Name = "Sailing",
                Description = "Full day lakeland kayak with island picnic.",
                ActivityDate = new DateTime(2019, 06, 03),
                TypeOfActivity = "Water",
                Cost = 50m
            };

            Activity a1 = new Activity()
            {
                Name = "Parachuting",
                Description = "Experience the thrill of free fall while you tandem jump from an airplane.",
                ActivityDate = new DateTime(2019, 06, 01),
                TypeOfActivity = "Air",
                Cost = 100m
            };

            Activity a2 = new Activity()
            {
                Name = "Hang Gliding",
                Description = "Soar on hot air currents and enjoy spectacular views of the coastal region.",
                ActivityDate = new DateTime(2019, 06, 02),
                TypeOfActivity = "Air",
                Cost = 80m
            };

            Activity a3 = new Activity()
            {
                Name = "Helicopter Tour",
                Description = "Experience the ultimate in aerial sight-seeing as you tour the area in our modern helicopters",
                ActivityDate = new DateTime(2019, 06, 03),
                TypeOfActivity = "Air",
                Cost = 200m
            };

            allActivities.Add(l1);
            allActivities.Add(l2);
            allActivities.Add(l3);
            allActivities.Add(a1);
            allActivities.Add(a2);
            allActivities.Add(a3);
            allActivities.Add(w1);
            allActivities.Add(w2);
            allActivities.Add(w3);

            //display in lisbox
            lbxAllActivities.ItemsSource = allActivities;
            lbxSelectedActivities.ItemsSource = chosenActivities;


        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Figure out what acytivity is selected
            Activity selected = lbxAllActivities.SelectedItem as Activity;

            //null check
            if (selected != null)
            {
                //Move activites from left to right
                allActivities.Remove(selected);
                chosenActivities.Add(selected);

                //Refresh the screen 
                RefreshScreen();
            }
            else
            {
                MessageBox.Show("No activity was selected");
            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            //Figure out what acytivity is selected
            Activity selected = lbxSelectedActivities.SelectedItem as Activity;

            //null check
            if (selected != null)
            {
                //Move activites from left to right
                allActivities.Add(selected);
                chosenActivities.Remove(selected);

                //Refresh the screen 
                RefreshScreen();
            }
          else
            {
                MessageBox.Show("No activity was selected");
            }

        }

        private void RefreshScreen()
        {
            lbxAllActivities.ItemsSource = null;
            lbxAllActivities.ItemsSource = allActivities;

            lbxSelectedActivities.ItemsSource = null;
            lbxSelectedActivities.ItemsSource = chosenActivities;
        }

        private void rbtn1_Click(object sender, RoutedEventArgs e)
        {
            filteredActivities.Clear();


            if (rbtn1.IsChecked == true)
            {
                //show all Activites
                RefreshScreen();
            }
            else if (rbtn2.IsChecked == true)
            {
                //show all land activities
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == "Land")
                    {
                        filteredActivities.Add(activity);
                    }
                    lbxAllActivities.ItemsSource = null;
                    lbxAllActivities.ItemsSource = filteredActivities;
                }
            }
            else if (rbtn3.IsChecked == true)
            {
                // Show all water activites
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == "Water")
                    {
                        filteredActivities.Add(activity);
                    }
                    lbxAllActivities.ItemsSource = null;
                    lbxAllActivities.ItemsSource = filteredActivities;
                }
            }
            else if (rbtn4.IsChecked == true)
            {
                // Show all Air activites
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == "Air")
                    {
                        filteredActivities.Add(activity);
                    }
                    lbxAllActivities.ItemsSource = null;
                    lbxAllActivities.ItemsSource = filteredActivities;
                }
            }


        }

        private void lbxAllActivities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what was selected
            Activity selected = lbxAllActivities.SelectedItem as Activity;
            if (selected != null)
            {
                tblkDescription.Text = selected.Description; // getting the description and displaying in text box
            }
        }
    }
}
