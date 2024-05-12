using CalculatorApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorApp.MVVM.ViewModel
{
    public class BMIViewModel : INotifyPropertyChanged
    {
        private Color SELECTED = Colors.Gray;
        private Color UNSELECTED = Colors.White;

        private Color _genderMale;
        private Color _genderFamale;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Color GenderFamale
        {
            get => _genderFamale;
            set
            {
                _genderFamale = value;
                _genderMale = UNSELECTED;

                OnPropertyChanged(nameof(GenderFamale));
                OnPropertyChanged(nameof(GenderMale));
            }
        }

        public Color GenderMale
        {
            get => _genderMale;
            set
            {
                _genderFamale = UNSELECTED;
                _genderMale = value;

                OnPropertyChanged(nameof(GenderFamale));
                OnPropertyChanged(nameof(GenderMale));
            }            
        }

        public ICommand SelectedGenderAsMale {  get; }
        public ICommand SelectedGenderAsFamale { get; }
        public BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new BMI();
            BMI.Height = 180;
            BMI.Weight = 73;
            GenderMale = SELECTED;           
            SelectedGenderAsFamale = new Command(ExecuteSelectGenderAsFamale);
            SelectedGenderAsMale = new Command(ExecuteSelectGenderAsMale);
        }

        private void ExecuteSelectGenderAsMale()
        {
            GenderMale = SELECTED;
        }

        private void ExecuteSelectGenderAsFamale()
        {
            GenderFamale = SELECTED;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
