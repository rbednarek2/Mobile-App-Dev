using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Models;
using Xamarin.Forms;

namespace FinalProject.ViewModels
{
    class TipCalcViewModel
    {
        public Command OperationsCommand { get; set; }
        public TipModel TipModel { get; set; }

        public TipCalcViewModel()
        {
            OperationsCommand = new Command(DoOperations);

            TipModel = new TipModel
            {
                Tip = 5,
                PersonNumber = 2
            };
        }

        private void DoOperations()
        {
            TipModel.TotalTip = ((TipModel.Total * TipModel.Tip) / 100);
            TipModel.TotalWithTip = TipModel.TotalTip + TipModel.Total;
            TipModel.TipByPerson = TipModel.TotalTip / TipModel.PersonNumber;
            TipModel.TotalByPerson = ((TipModel.Total + TipModel.TotalTip) / TipModel.PersonNumber);
        }
    }
}
