using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyApp.Views.UserControls
{
    /// <summary>
    /// Interaction logic for BreifInfo.xaml
    /// </summary>
    public partial class BreifInfo : UserControl, INotifyPropertyChanged
    {    
        public string CurrencyName
        {
            get 
            { 
                return CurrencyName; 
            }
            set 
            {
                CurrencyName = value; 
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("CurrencyName"));
            }
        }
        public string Sign 
        { 
            get 
            { 
                return Sign; 
            } 
            set 
            { 
                Sign = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sign"));

            }
        } 
        public string CurrencyType 
        {
            get
            {
                return CurrencyType;
            }
            set 
            {
                CurrencyType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrencyType"));

            }
        }
        public string USDValue
        {
            get
            {
                return USDValue;
            }
            set
            {
                USDValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("USDValue"));

            }
        }

        public BreifInfo()
        {
            InitializeComponent();
            DataContext=this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
