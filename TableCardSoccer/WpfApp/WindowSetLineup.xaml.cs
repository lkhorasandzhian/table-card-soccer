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
using System.Windows.Shapes;
using WpfApp.Positions;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для WindowSetLineup.xaml
    /// </summary>
    public partial class WindowSetLineup : Window
    {
        public WindowSetLineup()
        {
            InitializeComponent();

        }

        private List<StackPanel> _Forwards = new();
        private List<StackPanel> _Midfield = new();
        private List<StackPanel> _Defenders = new();
        private StackPanel _Goalkeeper;
        private List<Forward> __Forwards = new();
        private List<Midfielder> __Midfielders = new();
        private List<Defender> __Defenders = new();
        private Goalkeeper __Goalkeeper;
        StackPanel SelectedPanel;

        private void Panel1_Clicked(object sender, EventArgs e)
        {
            SelectedPanel = sender as StackPanel;
            //PlayersList.Children.Clear();

        }

        private void Panel2_Clicked(object sender, EventArgs e)
        {
            SelectedPanel = sender as StackPanel;
        }

        private void Panel3_Clicked(object sender, EventArgs e)
        {
            SelectedPanel = sender as StackPanel;
        }

        private void Panel4_Clicked(object sender, EventArgs e)
        {
            SelectedPanel = sender as StackPanel;
        }

        private void ComboBoxLineup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Forwards.Children.Clear();
            _Forwards.Clear();
            for (int i = 0; i < int.Parse((ComboBoxLineup.SelectedItem as ComboBoxItem).Content.ToString()[0].ToString()); i++)
            {
                StackPanel sp = new StackPanel();
                __Forwards.Add(new Forward());
                sp.Background = Brushes.Red;
                sp.MouseDown += Panel1_Clicked;
                sp.Width = 20;
                sp.Height = 20;
                _Forwards.Add(sp);
                Forwards.Children.Add(sp);
            }

            Midfielders.Children.Clear();
            _Midfield.Clear();
            for (int i = 0; i < int.Parse((ComboBoxLineup.SelectedItem as ComboBoxItem).Content.ToString()[2].ToString()); i++)
            {
                __Midfielders.Add(new Midfielder());
                StackPanel sp = new StackPanel();
                sp.Background = Brushes.Red;
                sp.MouseDown += Panel2_Clicked;
                sp.Width = 20;
                sp.Height = 20;
                _Midfield.Add(sp);
                Midfielders.Children.Add(sp);
            }

            Defenders.Children.Clear();
            _Defenders.Clear();
            for (int i = 0; i < int.Parse((ComboBoxLineup.SelectedItem as ComboBoxItem).Content.ToString()[4].ToString()); i++)
            {
                __Defenders.Add(new Defender());
                StackPanel sp = new StackPanel();
                sp.Background = Brushes.Red;
                sp.MouseDown += Panel3_Clicked;
                sp.Width = 20;
                sp.Height = 20;
                _Defenders.Add(sp);
                Defenders.Children.Add(sp);
            }

            __Goalkeeper = new Goalkeeper();
            Goalkeeper.Children.Clear();
            StackPanel _sp = new StackPanel();
            _sp.Background = Brushes.Red;
            _sp.MouseDown += Panel4_Clicked;
            _sp.Width = 20;
            _sp.Height = 20;
            _Goalkeeper = _sp;
            Goalkeeper.Children.Add(_sp);
        }
    }
}
