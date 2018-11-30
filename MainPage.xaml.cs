using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace Arvestus_Erki_Ivar_Orm_Heinsoo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int counter = 0;
            public MainPage()
            {
                this.InitializeComponent();

            }

        public int Counter { get => counter; set => counter = value; }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string username = "user";
            string password = "SecretPassword";

            //kontrollin kas user ja pw on sisestatud korrektselt
            if (counter <= 3)
            {

                if (userBox.Text == username && passwordBox.Password == password)
                {
                    resultBlock.Text = "Sisselogimine õnnestus! ";
                    this.Frame.Navigate(typeof(Content));
                }
                else
                {
                    resultBlock.Text = "Sisselogimine ebaõnnestus!";
                    counter++;
                }
            }
            else
            {
                resultBlock.Text  = "Sisselogimine ebaõnnestus." + Environment.NewLine +"Rohkem katseid sisenemiseks ei ole!";
                button1.IsEnabled = false;
            }
        }
    }
}
