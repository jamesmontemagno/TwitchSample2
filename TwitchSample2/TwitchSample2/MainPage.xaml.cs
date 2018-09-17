using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwitchSample2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if(Xamarin.Forms.DesignMode.IsDesignModeEnabled)
            {
                BindingContext = new CountViewModel();
            }
        }
    }
}
