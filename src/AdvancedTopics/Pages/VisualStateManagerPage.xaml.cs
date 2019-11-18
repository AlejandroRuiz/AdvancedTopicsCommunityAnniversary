using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace AdvancedTopics.Pages
{
    public partial class VisualStateManagerPage : ContentPage
    {
        public VisualStateManagerPage()
        {
            InitializeComponent();
            GoToState(false);
        }

        void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            bool isValid = Regex.IsMatch(args.NewTextValue, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
            GoToState(isValid);
        }

        void GoToState(bool isValid)
        {
            string visualState = isValid ? "Valid" : "Invalid";
            VisualStateManager.GoToState(btnLogin, visualState);
        }

        private void OnClicked(object sender, EventArgs args)
        {
            emailEntry.IsEnabled = !emailEntry.IsEnabled;
        }
    }
}
