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

namespace SandwichCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            int totalSandwiches = BreadBox.SelectedItems.Count * MeatBox.SelectedItems.Count * CheeseBox.SelectedItems.Count 
                                * CondimentBox.SelectedItems.Count * VeggiesBox.SelectedItems.Count * SpicesBox.SelectedItems.Count;
            string sandwiches = "";


            for(int i = 0; i < BreadBox.SelectedItems.Count; i++)
            {
                for(int j = 0; j < MeatBox.SelectedItems.Count; j++)
                {
                    for(int k = 0; k < CheeseBox.SelectedItems.Count; k++)
                    {
                        for(int l = 0; l < CondimentBox.SelectedItems.Count; l++)
                        {
                            for(int m = 0; m < VeggiesBox.SelectedItems.Count; m++)
                            {
                                for(int n = 0; n < SpicesBox.SelectedItems.Count; n++)
                                {
                                    sandwiches += BreadBox.SelectedItems[i] + ", " + MeatBox.SelectedItems[j] + ", " + CheeseBox.SelectedItems[k] + ", " +
                                         CondimentBox.SelectedItems[l] + ", " + VeggiesBox.SelectedItems[m] + ", " + SpicesBox.SelectedItems[n] + "\n";
                                }
                            }
                        }
                        
                    }
                }
            }



            if (totalSandwiches == 0)
            {
                MessageBox.Show("Please choose at least one bread, meat, and cheese.");
            }
            else
            {
                MessageBox.Show("Order has been made! You have ordered: " + totalSandwiches + " sandwiches." + "\n" + sandwiches);
            }
            

        }
    }
}
