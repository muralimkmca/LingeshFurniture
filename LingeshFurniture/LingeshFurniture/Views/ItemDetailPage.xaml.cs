using LingeshFurniture.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LingeshFurniture.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}