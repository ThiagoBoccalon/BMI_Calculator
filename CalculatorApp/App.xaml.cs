﻿using CalculatorApp.MVVM.View;

namespace CalculatorApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculatorView();
        }
    }
}
