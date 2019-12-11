using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject.Views
{
    public partial class TipCalc: ContentPage
    {
        public TipCalc()
        {
            InitializeComponent();
            BindingContext = new TipCalcViewModel();
        }
    }
}