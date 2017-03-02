using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RollDice
{
    public partial class HistoryPage : ContentPage
    {
        

        public HistoryPage()
        {
            this.Title = "History";
            InitializeComponent();
            RollView.ItemsSource = MainPage.rolledHistorylList;
        }

        private void BtnRemoveHistory_OnClicked(object sender, EventArgs e)
        {
            MainPage.rolledHistorylList.Clear();
        }
    }
}
