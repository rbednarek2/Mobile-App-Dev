using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Dot_Clicked(object sender, System.EventArgs e)
        {
            current.Text = current.Text + ".";
        }

        void Dash_Clicked(object sender, System.EventArgs e)
        {
            current.Text = current.Text + "-";
        }

        void Space_Clicked(object sender, System.EventArgs e)
        {
            var input = current.Text.ToString();
            if (input != "")
            {
                current.Text = "";
                output.Text = output.Text + Morse.MorseCoder(input).ToString();
            } else
            {
                output.Text = output.Text + " ";
            }

            

        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            output.Text = "";
        }
    }

 }