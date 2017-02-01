using System.Windows;
using System.Windows.Controls;
using Classes.Models;
using DataInput.Views;

namespace DataInput.ViewModels
{
    public class CreateUserViewModel
    {
        private CreateUserView createUserView;
        private User user;

        public CreateUserViewModel(Frame contentFrame)
        {
            createUserView = new CreateUserView();
            createUserView.DataContext = this;
            user = new User();
            createUserView.CreateUserBtn.Click += CreateUserBtn_OnClick;
            contentFrame.Content = createUserView;
        }

        private void CreateUserBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
