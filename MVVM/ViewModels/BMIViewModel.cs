using MAUI_EasyBMI.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_EasyBMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new BMI();
            BMI.Height = 180;
            BMI.Weight = 80;
        }
    }
}
