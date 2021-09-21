/// Chapter No. 9 and 10 - Homework_Week4
/// File Name: homework_week4.java
/// @author: Rossana Palma
/// Date:  September 19, 2021
///
/// Problem Statement: Write a GUI program that calculates monthly principal, monthly interest, monthly 
/// mortgage and the outstandings balance. Assume that the annual interest is 6.39 percent.
/// 
/// Overall Plan:
/// 1) Create text boxs, labels and buttom in GUI application
/// 2) Declare variables in console application
/// 3) Convert mortgageAmount and annualInterest to double
/// 4) Calculate monthlyInterest, monthlyPrincipal, monthlyMortgage and outstandingBalance
/// 5) Display results on the screen
///

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

namespace Project1
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //Declare variables
            double mortgageAmount, annualInterest, monthlyMortgage, monthlyInterest, monthlyPrincipal, outstandingBalance;

            //Convert to double
            mortgageAmount = Convert.ToDouble(mortgageAmountTextBox.Text);
            annualInterest = Convert.ToDouble(annualInterestTextBox.Text);

            //Calculation
            monthlyInterest = mortgageAmount * ((annualInterest/100)/12);
            monthlyPrincipal = mortgageAmount / 12;
            monthlyMortgage = monthlyPrincipal + monthlyInterest;
            outstandingBalance = mortgageAmount - monthlyMortgage;
            
            // Display 
            mortgageAmountTextBox.Text = mortgageAmount.ToString("c");
            outstandingTextBox.Text = outstandingBalance.ToString("c");
            annualInterestTextBox.Text = annualInterest.ToString("");
            monthlyMortgageTextBox.Text = monthlyMortgage.ToString("c");
            interestAmountTextBox.Text = monthlyInterest.ToString("c");
            principalAmountTextBox.Text = monthlyPrincipal.ToString("c");
            
        }
    }
    }

