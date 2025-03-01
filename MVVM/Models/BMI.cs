using PropertyChanged;

namespace MAUI_EasyBMI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public string ResultText
        {
            get
            {
                string template = "BMI: #";
                if (Result <= 16)
                {
                    return template.Replace("#", "Grave magrezza");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return template.Replace("#", "Magrezza moderata");
                }
                else if (Result > 17 && Result <= 18.5)
                {
                    return template.Replace("#", "Magrezza lieve");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return template.Replace("#", "Normale");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return template.Replace("#", "Sovrappeso");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return template.Replace("#", "Obesità Classe I");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return template.Replace("#", "Obesità Classe II");
                }
                else
                {
                    return template.Replace("#", "Obesità Classe III");
                }
            }
        }
        public float Result
        {
            get
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }
    }
}
