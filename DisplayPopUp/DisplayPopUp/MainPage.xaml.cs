using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayPopUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = true;
        }

        protected void OnAddButtonClicked(object sender, EventArgs args)
        {
            int firstVal = Convert.ToInt32(entryFirstVal.Text);
            int secondVal = Convert.ToInt32(entrySecondVal.Text);
            lblResult.Text = Convert.ToString(firstVal + secondVal);
        }

        protected void OnCancelButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;
        }
    }
}
