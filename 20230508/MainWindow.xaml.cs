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

namespace _20230508
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            1
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }
        } 

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
