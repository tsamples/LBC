﻿using System;

using LBC.Views;
using Xamarin.Forms;

namespace LBC
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            //MainPage = new NavigationPage(new ItemsPage());
            MainPage = new NavigationPage(new MyTabbedPage1());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

