using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void sldPercentage_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CalcTotal();
        }

        private void txtTotalBill_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CalcTotal();
        }

        private void CalcTotal()
        {
            double totalBill = 0;
            double tipAmount = 0;
            double totalAmount = 0;
            double StepValue = 1;

            var newStep = Math.Round(this.sldPercentage.Value / StepValue);
            sldPercentage.Value = newStep * StepValue;

            double.TryParse(this.txtTotalBill.Text, out totalBill);
            tipAmount = totalBill * this.sldPercentage.Value / 100;
            totalAmount = totalBill + tipAmount;

            this.lblTip.Text = tipAmount.ToString("C");
            this.lblTotalAmount.Text = totalAmount.ToString("C");
        }
    }
}
