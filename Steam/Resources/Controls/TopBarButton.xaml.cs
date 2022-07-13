using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AuthWindows.Steam.Resources.Controls
{
    /// <summary>
    /// Логика взаимодействия для TopBarButton.xaml
    /// </summary>
    public partial class TopBarButton : UserControl
    {
        public TopBarButton()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty SourceImageProperty = DependencyProperty.Register(
            name: "SourceImage",
            propertyType: typeof(ImageSource),
            ownerType: typeof(TopBarButton),
            typeMetadata: new FrameworkPropertyMetadata(
                defaultValue: null,
                flags: FrameworkPropertyMetadataOptions.AffectsRender,
                propertyChangedCallback: null));

        public ImageSource SourceImage
        {
            get { return (ImageSource)GetValue(SourceImageProperty); }
            set { SetValue(SourceImageProperty, value); }
        }


    }
}
