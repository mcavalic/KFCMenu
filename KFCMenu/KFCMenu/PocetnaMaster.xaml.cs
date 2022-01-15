using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFCMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PocetnaMaster : ContentPage
    {
        public ListView ListView;

        public PocetnaMaster()
        {
            InitializeComponent();

            BindingContext = new PocetnaMasterViewModel();
            ListView = MenuItemsListView;
        }

        class PocetnaMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PocetnaMasterMenuItem> MenuItems { get; set; }

            public PocetnaMasterViewModel()
            {
                MenuItems = new ObservableCollection<PocetnaMasterMenuItem>(new[]
                {
                    new PocetnaMasterMenuItem { Id = 0, Title = "Početna", TargetType=typeof(PocetnaDetail) },
                    new PocetnaMasterMenuItem { Id = 1, Title = "Meni", TargetType=typeof(Meni) },
                    new PocetnaMasterMenuItem { Id = 2, Title = "Narudžba", TargetType=typeof(Narudzba) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}