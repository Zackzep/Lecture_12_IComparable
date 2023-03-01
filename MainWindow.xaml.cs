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

namespace Lecture_12_IComparable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Team> nfl = new List<Team>();
        
        List<Team> mlb = new List<Team>();
        public MainWindow()
        {
            InitializeComponent();
            PreloadNFL();
            DisplayTeams(nfl, lbTeams);
            rbAscend.IsChecked= true;
            
        }

        public void DisplayTeams(List<Team> teamList, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach(Team team in teamList)
            {
                listBox.Items.Add(team);
            }
        }

        public void PreloadNFL()
        {
            nfl.Add(new Team("Seahawks", "Seattle"));
            nfl.Add(new Team("Chiefs", "Kansas City"));
            nfl.Add(new Team("49ers", "San Francisco"));
        }
        public void DisplayMLB()
        {
            mlb.Add(new Team("Giants", "San Francisco"));
            mlb.Add(new Team("Mariners", "Seattle"));
            mlb.Add(new Team("Angels", "Los Angeles"));
            //DisplayTeams(mlb, lbMLBTeams);
        }

        public void SortNFLExamples()
        {
            Team_SortBudgetDesc sortTeamDesc = new Team_SortBudgetDesc();

            Team_SortName sortByName = new Team_SortName(Team_SortName.SortingOrder.Ascending);
            nfl.Sort(sortByName);
        }
        private void btnCitySort_Click(object sender, RoutedEventArgs e)
        {
            nfl.Sort();
            DisplayNFL();
        }

        private void btnNameSort_Click(object sender, RoutedEventArgs e)
        {
            Team_SortName.SortingOrder order= Team_SortName.SortingOrder.Ascending;

            if(!rbAscend.IsChecked.Value)
            {
                order = Team_SortName.SortingOrder.Descending;
            }
            Team_SortName sortName = new Team_SortName(order);
            nfl.Sort(sortName);
            DisplayNFL();
        }

        private void btnBudgetSort_Click(object sender, RoutedEventArgs e)
        {
            Team_SortBudgetDesc budgetDesc= new Team_SortBudgetDesc();
            nfl.Sort(budgetDesc);
            DisplayNFL();
        }

        public void DisplayNFL()
        {
            DisplayTeams(nfl, lbTeams);
        }
    }
}
