using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Radio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new ViewModel();

            this.DataContext = ViewModel;

        }
    }


    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _IsExperienceNav;

        public bool IsExperienceNav
        {
            get { return _IsExperienceNav; }
            set { _IsExperienceNav = value; OnPropertyChanged(nameof(IsExperienceNav)); }
        }

        private bool _IsSomeNav;

        public bool IsSomeNav
        {
            get { return _IsSomeNav; }
            set { _IsSomeNav = value; OnPropertyChanged(nameof(IsSomeNav)); }
        }

        private bool _IsUniqueNav;

        public bool IsUniqueNav
        {
            get { return _IsUniqueNav; }
            set { _IsUniqueNav = value; OnPropertyChanged(nameof(IsUniqueNav)); }
        }


        private bool _IsRadioNav;

        public bool IsRadioNav
        {
            get { return _IsRadioNav; }
            set { _IsRadioNav = value; OnPropertyChanged(nameof(IsRadioNav)); }
        }

        private bool _IsButtonsNav;

        public bool IsButtonsNav
        {
            get { return _IsButtonsNav; }
            set { _IsButtonsNav = value; OnPropertyChanged(nameof(IsButtonsNav)); }
        }

        private bool _IsCodeVert;

        public bool IsCodeVert
        {
            get { return _IsCodeVert; }
            set { _IsCodeVert = value; OnPropertyChanged(nameof(IsCodeVert)); }
        }

        private bool _IsOnMyVert;

        public bool IsOnMyVert
        {
            get { return _IsOnMyVert; }
            set { _IsOnMyVert = value; OnPropertyChanged(nameof(IsOnMyVert)); }
        }

        private bool _IsGitHubVert;

        public bool IsGitHubVert
        {
            get { return _IsGitHubVert; }
            set { _IsGitHubVert = value; OnPropertyChanged(nameof(IsGitHubVert)); }
        }

        private bool _IsPageVert;

        public bool IsPageVert
        {
            get { return _IsPageVert; }
            set { _IsPageVert = value; OnPropertyChanged(nameof(IsPageVert)); }
        }

        private bool _IsCheckTran;

        public bool IsCheckTran
        {
            get { return _IsCheckTran; }
            set { _IsCheckTran = value; OnPropertyChanged(nameof(IsCheckTran)); }
        }

        private bool _IsThisTran;

        public bool IsThisTran
        {
            get { return _IsThisTran; }
            set { _IsThisTran = value; OnPropertyChanged(nameof(IsThisTran)); }
        }

        private bool _IsVideosTran;

        public bool IsVideosTran
        {
            get { return _IsVideosTran; }
            set { _IsVideosTran = value; OnPropertyChanged(nameof(IsVideosTran)); }
        }

        private bool _IsDescriptionTran;

        public bool IsDescriptionTran
        {
            get { return _IsDescriptionTran; }
            set { _IsDescriptionTran = value; OnPropertyChanged(nameof(IsDescriptionTran)); }
        }


    }

}