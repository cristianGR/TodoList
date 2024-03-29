﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using todoList.Model;

namespace todoList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataStore tskList = new DataStore();
            BindingContext = tskList;
        }

        public void OnBtnClicked(object sender, EventArgs args){
            tskList.Add(TskEntry.Text);
        }
    }
}
