using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertAndActionSheetPopUp : ContentPage
    {
        public AlertAndActionSheetPopUp()
        {
            InitializeComponent();
        }
        void OnClickedAlert(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "You have 5 unread messages", "OK");
        }
        async void OnClickedRespond(object sender, EventArgs e)
        {
            bool answer=await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            
        }
        async void OnClickedActionSheet(object sender, EventArgs e)
        {
            string answer = await DisplayActionSheet("ActionSheet: What will You Do", "Cancel",null, "Delete", "Share", "Like");
        }
    }
}