using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Tabpage
{
    public partial class PageA : ContentPage
    {
        public PageA()
        {
            InitializeComponent();
        }

        private async void PopToRoot(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void PushPageB(object sender, EventArgs e)
        {
            var pageB = new PageB();
            await Navigation.PushAsync(pageB);
        }
    }
}
