using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

using MvvmHelpers;

namespace TwitchSample2
{
    public class CountViewModel : BaseViewModel
    {
        public CountViewModel()
        {
            IncreaseCountCommand = new Command(IncreaseCount);

            if (Xamarin.Forms.DesignMode.IsDesignModeEnabled)
            {
                Count = 10;
                CountInfo = $"You clicked {Count} times!";
            }
        }
        int count = 0;
        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }

        string countInfo = string.Empty;
        public string CountInfo
        {
            get => countInfo;
            set => SetProperty(ref countInfo, value);
        }

        public Command IncreaseCountCommand { get; }

        void IncreaseCount()
        {
            Count++;
            CountInfo = $"You clicked {Count} times!";
        }

    }
}
