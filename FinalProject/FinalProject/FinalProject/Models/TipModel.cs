using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinalProject.Models
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal _totalTip;
        private decimal _totalWithTip;
        private decimal _tipByPerson;
        private decimal _totalByPerson;

        public decimal Total { get; set; }

        public int Tip { get; set; }

        public int PersonNumber { get; set; }

        public decimal TotalTip
        {
            get => _totalTip;
            set
            {
                _totalTip = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalWithTip
        {
            get => _totalWithTip;
            set
            {
                _totalWithTip = value;
                OnPropertyChanged();
            }
        }

        public decimal TipByPerson
        {
            get => _tipByPerson;
            set
            {
                _tipByPerson = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalByPerson
        {
            get => _totalByPerson;
            set
            {
                _totalByPerson = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}