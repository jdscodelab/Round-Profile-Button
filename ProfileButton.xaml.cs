using System;
using System.Collections.Generic;
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

namespace RoundProfileButton
{
    /// <summary>
    /// Interaction logic for ProfileButton.xaml
    /// </summary>
    public partial class ProfileButton : UserControl
    {
        public ProfileButton()
        {
            InitializeComponent();
        }



        public ImageSource ProfileImageSource
        {
            get { return (ImageSource)GetValue(ProfileImageSourceProperty); }
            set { SetValue(ProfileImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProfileImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProfileImageSourceProperty =
            DependencyProperty.Register("ProfileImageSource", typeof(ImageSource), typeof(ProfileButton));


        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserNameProperty =
            DependencyProperty.Register("UserName", typeof(string), typeof(ProfileButton));



        public string Availability
        {
            get { return (string)GetValue(AvailabilityProperty); }
            set { SetValue(AvailabilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Availability.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AvailabilityProperty =
            DependencyProperty.Register("Availability", typeof(string), typeof(ProfileButton));


    }
}
