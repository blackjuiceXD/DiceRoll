using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RollDice
{
    public partial class MainPage : ContentPage
    {
        private int diceNumber;
        private int rollingNumber;
        private int rolledNumber;
        
        public static ObservableCollection<string> rolledHistorylList;

        public MainPage()
        {
            InitializeComponent();
            this.Title = "Dice Cup";
            MainImage.Source = "Terninger.jpg";
            rolledHistorylList = new ObservableCollection<string>();

        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }

        private void RollButton_OnClicked(object sender, EventArgs e)
        {
            rolledNumber = Convert.ToInt32(Rolling().ToString());
            lblRolled.Text = rolledNumber.ToString();
            if (rolledHistorylList != null)
            {
                rolledHistorylList.Add(rolledNumber.ToString());
            }
        }

        private void BtnPlus_OnClicked(object sender, EventArgs e)
        {
            diceNumber = Convert.ToInt32(lblDiceNumber.Text);

            if (diceNumber != 6)
            {
                diceNumber++;
                lblDiceNumber.Text = diceNumber.ToString();
            }
        }

        private void BtnMinus_OnClicked(object sender, EventArgs e)
        {
            diceNumber = Convert.ToInt32(lblDiceNumber.Text);
            
            if (diceNumber != 1)
            {
                diceNumber--;
                lblDiceNumber.Text = diceNumber.ToString();
            } 

        }

        private int Rolling()
        {
            
            diceNumber = Convert.ToInt32(lblDiceNumber.Text);
            Random rnd = new Random();
            switch (diceNumber)
            {
                case 1:
                    rollingNumber = rnd.Next(1, 7);
                    break;
                case 2:
                    rollingNumber = rnd.Next(2, 13);
                    break;
                case 3:
                    rollingNumber = rnd.Next(3, 19);
                    break;
                case 4:
                    rollingNumber = rnd.Next(4, 25);
                    break;
                case 5:
                    rollingNumber = rnd.Next(5, 31);
                    break;
                case 6:
                    rollingNumber = rnd.Next(6, 37);
                    break;
            }
            return rollingNumber; 
        }
    }
}
