using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PilotbackBar
{
    public partial class MainPage : CoolContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenPageButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2(), false);
        }
    }
}
