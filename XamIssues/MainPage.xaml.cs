using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamIssues
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Color BkClr { get; set; } = Color.Red;

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            BkClr = (BkClr == Color.Red) ? Color.Black : Color.Red;
            NotifyPropertyChanged("BkClr");
        }

        public new event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
