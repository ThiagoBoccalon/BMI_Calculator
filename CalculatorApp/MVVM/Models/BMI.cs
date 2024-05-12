using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace CalculatorApp.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        float result;
        public float Height { get; set; }
        public float Weight { get; set; }

        public float Result
        {
            get
            {
                float convertHeightInKilograms = Weight;
                float convertHeightInMeters = Height / 100;
                return (convertHeightInKilograms / (float) Math.Pow(convertHeightInMeters, 2));
            }
        }

        public string ResultText
        {
            get
            {
                string template = "BMI: #";
                if (Result <= 18.5)
                {
                    return template.Replace("#", "Underweight");
                }
                else if (Result > 18.5 && Result <= 24.9)
                {
                    return template.Replace("#", "Normal");
                }
                else if (Result > 25 && Result <= 29.9)
                {
                    return template.Replace("#", "Overweight");
                }
                else
                {
                    return template.Replace("#", "Obese");
                }
            }
        }

        public BMI() { }
    }
}
