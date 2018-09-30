using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HeronCalculator.Entity;
using HeronCalculator.Utilities.validate;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HeronCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Validate validate = new Validate();
        Triangle triangle;
        public MainPage()
        {
            this.InitializeComponent();
            this.triangle = new Triangle();
        }

        private void btnSubmitClick(object sender, RoutedEventArgs e)
        {
            string firstSide = txtFirstSide.Text;
            string secondSide = txtSecondSide.Text;
            string thirdSide = txtThirdSide.Text;

            string validatedFirstSide = validate.ValidateFirstSide(firstSide);
            if (validatedFirstSide == null)
            {
                if (txtErrorFirstSide != null)
                {
                    txtErrorFirstSide.Text = String.Empty;
                }
                this.triangle.firstSide = double.Parse(firstSide);
            }
            else
            {
                txtErrorFirstSide.Foreground = new SolidColorBrush(Colors.Red);
                txtErrorFirstSide.Text = validatedFirstSide;
            }

            string validatedSecondSide = validate.ValidateSecondSide(secondSide);
            if (validatedSecondSide == null)
            {
                if (txtErrorSecondSide != null)
                {
                    txtErrorSecondSide.Text = String.Empty;
                }
                this.triangle.secondSide = double.Parse(secondSide);
            }
            else
            {
                txtErrorSecondSide.Foreground = new SolidColorBrush(Colors.Red);
                txtErrorSecondSide.Text = validatedSecondSide;
            }

            string validatedThirdSide = validate.ValidateThirdSide(thirdSide);
            if (validatedThirdSide == null)
            {
                if (txtErrorThirdSide != null)
                {
                    txtErrorThirdSide.Text = String.Empty;
                }
                this.triangle.thirdSide = double.Parse(thirdSide);
            }
            else
            {
                txtErrorThirdSide.Foreground = new SolidColorBrush(Colors.Red);
                txtErrorThirdSide.Text = validatedThirdSide;
            }

            if (validatedThirdSide == null && validatedSecondSide == null && validatedFirstSide == null)
            {
                string jsonTriangle = JsonConvert.SerializeObject(this.triangle);
                Debug.WriteLine(jsonTriangle);
                try
                {
                    txtResult.Text = "Result calculator display";
                    HttpClient httpClient = new HttpClient();
                    var content = new StringContent(jsonTriangle, Encoding.UTF8, "application/json");
                    var result = httpClient.PostAsync("https://daokhanh-201004.appspot.com/_api/v1/triangle/heron/", content)
                        .Result;
                    var resultHeron = result.Content.ReadAsStringAsync().Result;
                    txtResult.Text = resultHeron;
                }
                catch (Exception exception)
                {
                    txtError.Foreground = new SolidColorBrush(Colors.Red);
                    txtError.Text = "Can not connect to API";
                }
            }
            else
            {
                txtResult.Text = "Result calculator display";
            }
        }

        private void btnResetClick(object sender, RoutedEventArgs e)
        {
            if (txtFirstSide.Text != null || txtSecondSide.Text != null || txtThirdSide.Text != null)
            {
                txtFirstSide.Text = String.Empty;
                txtSecondSide.Text = String.Empty;
                txtThirdSide.Text = String.Empty;
                txtResult.Text = "Result calculator display";
            }
        }
    }
}
