using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.ApplicationModel.Resources;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ResWDemoAppProject.WinUIClassLibrary;
public sealed partial class DemoControlFromWinUIClassLibraryWithCSharp : UserControl
{
    public static readonly ResourceLoader _resourceLoader = new();
    public DemoControlFromWinUIClassLibraryWithCSharp()
    {
        this.InitializeComponent();
    }

    public static string Title { get => _resourceLoader.GetString("Demo_Title/Text"); }

    public static string SubTitle { get => _resourceLoader.GetString("Demo_SubTitle/Text"); }
}
