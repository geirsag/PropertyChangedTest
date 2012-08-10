using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using PropertyChangedTest.NameService;

namespace PropertyChangedTest
{
    public partial class MainPage : UserControl, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public Person Person { get; set; }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NameServiceClient client = new NameServiceClient();
            client.GetRandomPersonCompleted += delegate(object o, GetRandomPersonCompletedEventArgs args)
            {
                Person = args.Result;
            };
            client.GetRandomPersonAsync();
        }

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}