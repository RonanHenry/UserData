using System.Linq;
using System.Windows;
using DataInput.Views;

namespace DataInput.ViewModels
{
    public class DataViewModel
    {
        private DataView dataView;

        public DataViewModel()
        {
            dataView = new DataView();
            dataView.DataContext = this;

            Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive).Content = dataView;
        }
    }
}
