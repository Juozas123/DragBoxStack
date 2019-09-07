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
using DragBoxStack.Things;

namespace DragBoxStack
{
    /// <summary>
    /// Interaction logic for windowAddPallet.xaml
    /// </summary>
    public partial class windowAddPallet : Window
    {
        PalletDef _palletDef;
        public windowAddPallet(PalletDef pltDef)
        {
            InitializeComponent();
            _palletDef = pltDef;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            float tmpWidth = 0.0F;
            float tmpLength = 0.0F;
            float tmpHeight = 0.0F;

            var opOk = float.TryParse(tbPltWidth.Text, out tmpWidth) &&
                float.TryParse(tbPltLenght.Text, out tmpLength) &&
                float.TryParse(tbPltHeight.Text, out tmpHeight);

            if (!opOk)
            {
                MessageBox.Show("Incorrect values entered!");
                return;
            }
            else
            {
                _palletDef.UpdateDimensions(tmpWidth, tmpLength, tmpHeight);
                this.Close();
            }
            
        }
    }
}
