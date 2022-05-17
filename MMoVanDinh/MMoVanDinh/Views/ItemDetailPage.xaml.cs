using MMoVanDinh.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MMoVanDinh.Views
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