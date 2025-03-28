﻿using Microsoft.Azure.Devices.Client;
using SharedUWPLibrary.Models;
using SharedUWPLibrary.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_IoT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Messages messages = new Messages();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            messages.Add(new Msg(tbWriteMessage.Text));
            ConsolApp.SendMessageToCloud();
        }

        private void btnComboMessage_Click(object sender, RoutedEventArgs e)
        {
            messages.Add(new Msg(cmbChooseMessage.SelectedItem.ToString()));
            ConsolApp.SendMessageToCloud();
        }
    }
}