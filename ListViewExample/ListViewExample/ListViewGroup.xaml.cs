using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Uni> Unis { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();

            Unis = new ObservableCollection<Uni>
            {
                new Uni("Estudiantes de Priner ciclo")
                {
                    new Alumn { Name = "Juan", lastname = "Garcia", cycle = "I ciclo" },
                    new Alumn { Name = "Sofia", lastname = "Martinez", cycle = "I ciclo" },
                },
                new Uni("Estudiantes de Segundo ciclo")
                {
                    new Alumn { Name = "Luis", lastname = "Hernandez", cycle = "II ciclo" },
                    new Alumn { Name = "Maria", lastname = "Rodriguez", cycle = "II ciclo" },
                },
                new Uni("Estudiantes de Tercer ciclo")
                {
                    new Alumn { Name = "Alejandro", lastname = "Sanchez", cycle = "III ciclo" },
                    new Alumn { Name = "Laura", lastname = "Gonzales", cycle = "III ciclo" },
                },
            };
                UniView.ItemsSource = Unis;

        }
    }

}