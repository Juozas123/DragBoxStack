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
using DragBoxStack.Things;

namespace DragBoxStack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PalletDef _palletDef = new PalletDef();
        Rectangle _palletDrawing;

        double _scalingValue = 0.33;

        public MainWindow()
        {
            InitializeComponent();
            _palletDef.DimensionsChanged += new EventHandler(PalletChanged);
        }

        private void btnAddPallet_Click(object sender, RoutedEventArgs e)
        {
            windowAddPallet wnd = new windowAddPallet(_palletDef);
            wnd.ShowDialog();
        }

        private void PalletChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Pallet has been changed!");
        }

        private void DrawPallet()
        {
            _palletDrawing = new Rectangle();
            _palletDrawing.Width = _palletDef.Width * _scalingValue;
            _palletDrawing.Height = _palletDef.Length * _scalingValue;
            _palletDrawing.Fill = new SolidColorBrush(Colors.Gray);
            
            DrawingArea.Children.Add(_palletDrawing);
        }

        private void btnDrawPallet_Click(object sender, RoutedEventArgs e)
        {
            DrawPallet();
        }

        private void btnClearCanvas_Click(object sender, RoutedEventArgs e)
        {
            DrawingArea.Children.Clear();
            var tmp = new Border();
            tmp.Background = new SolidColorBrush(Colors.White);
            tmp.BorderBrush = new SolidColorBrush(Colors.Black);
            tmp.BorderThickness = new Thickness(1);
            DrawingArea.Children.Add(tmp);
        }
    }
}
