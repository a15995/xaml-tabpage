﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tabpage
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void PushPage2(object sender, EventArgs e)
        {
            var page2 = new Page2();
            await Navigation.PushAsync(page2);
        }
    }
}
