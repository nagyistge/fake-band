﻿using FakeBand.Fakes;
using AutoMapper;
using FakeBandClientTestApp.ViewModels;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FakeBandClientTestApp.Views
{
    public sealed partial class ContactUserControl : UserControl
    {
        public BandDeviceContactViewModel BandDeviceContactViewModel { get; set; } = new BandDeviceContactViewModel();

        public ContactUserControl()
        {
            Mapper.CreateMap<FakeBandDeviceContactReading, BandDeviceContactViewModel>();
            this.InitializeComponent();
        }
    }
}
