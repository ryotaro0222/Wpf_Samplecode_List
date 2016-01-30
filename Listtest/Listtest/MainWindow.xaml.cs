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
using System.Collections.Generic;


namespace Listtest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            


            this.SymbolPairComboBox.ItemsSource = new[]
            {
                new SymbolPair {symbol = "USDCHF"},
                new SymbolPair {symbol = "GBPUSD"},
                new SymbolPair {symbol = "EURUSD"},
                new SymbolPair {symbol = "USDJPY"},
                new SymbolPair {symbol = "USDCAD"},
                new SymbolPair {symbol = "AUDUSD"},
                new SymbolPair {symbol = "EURGBP"},
                new SymbolPair {symbol = "EURAUD"},
                new SymbolPair {symbol = "EURCHF"},
                new SymbolPair {symbol = "EURJPY"},
                new SymbolPair {symbol = "GBPJPY"},
                new SymbolPair {symbol = "GBPCHF"},
                new SymbolPair {symbol = "CADJPY"},
                new SymbolPair {symbol = "GBPJPY"},
                new SymbolPair {symbol = "AUDNZD"},
                new SymbolPair {symbol = "AUDCAD"},
                new SymbolPair {symbol = "AUDCHF"},
                new SymbolPair {symbol = "AUDJPY"},
                new SymbolPair {symbol = "CHFJPY"},
                new SymbolPair {symbol = "EURNZD"},
                new SymbolPair {symbol = "EURCAD"},
                new SymbolPair {symbol = "CADCHF"},
                new SymbolPair {symbol = "NZDJPY"},
                new SymbolPair {symbol = "NZDUSD"}
            };
        }



        public void button1_Click(Object sender, EventArgs e)
        {
            string symbol = ((SymbolPair)SymbolPairComboBox.SelectedItem).symbol;
            string cmd = "Ask";


            string log = "シンボル名: " + symbol + "/ 種類 :" + cmd;

                       
            //string symbol = ((SymbolPair)SymbolPairComboBox.SelectedItem).symbol;
            List<string> strData = new List<string>();
            strData.Add(log);

            for (int i = 0; i < strData.Count; i++)
            {
                textBox.Text +=  strData[i] + "\n";
            }
        }

        /*public void button2_Click(Object sender, EventArgs e)
        {
            ui.Text = strData[2] + "\r\n";
        }*/
    }
}
