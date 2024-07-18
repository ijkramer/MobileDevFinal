using Greenhouse.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Greenhouse.Views
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