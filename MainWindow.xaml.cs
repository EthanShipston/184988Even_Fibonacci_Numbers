/* Ethan Shipston
 * ICS4U
 * June 17, 2019
 * A program which calculates the sum of every even fibbonaci number below 4,000,000.
 */
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

namespace _184988Even_Fibonacci_Numbers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] nums = new int[100];
        int[] evenNums = new int[50];
        public MainWindow()
        {
            InitializeComponent();
            int prev = 1;
            nums[1] = 1;
            nums[0] = 1;
            for (int i = 1; i < 1000; i++)
            {
                nums[i + 1] = nums[i] + prev;
                prev = nums[i];

                if (nums[i] % 2 == 0)
                    evenNums[i] = nums[i];

                Console.WriteLine(i);

                if (nums[i + 1] > 4000000)
                {
                    nums[i + 1] = 0;
                    i = 10000;
                }
            }
            MessageBox.Show(evenNums.Sum().ToString());
        }
    }
}
