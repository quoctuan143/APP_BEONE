﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEONE.Dialog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageBox : ContentView
    {
        public MessageBox()
        {
            InitializeComponent();
        }
    }
}