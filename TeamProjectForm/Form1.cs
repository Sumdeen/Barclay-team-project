using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Barclays.Wilma.Service.CUNY.Bond;
using Barclays.Wilma.Service.CUNY.Mac.Bonds;
using Barclays.Wilma.Service.CUNY.Mac.Entities;
using Barclays.Wilma.Service.CUNY;

namespace TeamProjectForm
{
    public partial class Form1 : Form
    {
        int timesClicked = 0;
       
        List<TraderBondsEntities> _traders = new List<TraderBondsEntities>();
        public Form1()
        {
            InitializeComponent();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxSecurityType.Text = String.Empty;
            txtBoxTradeId.Text = String.Empty;
            txtBoxTraderName.Text = String.Empty;
            txtBoxIssuerName.Text = String.Empty;
            txtBoxFaceValue.Text = String.Empty;
            txtBoxQuantity.Text = String.Empty;
            txtBoxNumberOfYears.Text = String.Empty;
            txtBoxNumOfYears.Text = String.Empty;
            txtBoxAnnualRate.Text = String.Empty;
            txtBoxTotalValue.Text = String.Empty;
        }



        

        

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (_traders != null)
            {

                var oCunyMainB = new CunyMainB();
                var oReturnValue = oCunyMainB.GetBondCalcMultipleBond(_traders);
            }
            else
            {
                var traderId = Int32.Parse(txtBoxTradeId.Text.ToString());
                var quantity = Double.Parse(txtBoxQuantity.Text.ToString());
                var faceValue = Double.Parse(txtBoxFaceValue.Text.ToString());
                var NumberOfYears = Double.Parse(txtBoxNumberOfYears.Text.ToString());
                var Years = Decimal.Parse(txtBoxNumOfYears.Text.ToString());
                var Coupon = Double.Parse(txtBoxAnnualRate.Text.ToString());
              
                var oCunyMainB = new CunyMainB();
                var oReturnValue = oCunyMainB.GetBondCalcSingleBond(traderId, txtBoxTraderName.ToString(), string.Empty, faceValue, quantity, NumberOfYears, 0, Years);

                //GetBondCalcSingleBond(int traderId, string traderName, string issuer, double faceValue, double quantity, double numOfPeriod, double interest, decimal numOfYears)

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            timesClicked = timesClicked + 1;
           lblItem.Text = "You have added " + timesClicked.ToString() + "Item  ";

            
            
            int traderId = Int32.Parse(txtBoxTradeId.Text.ToString());
            var traderName = txtBoxTraderName.Text.ToString();
            var issuerName = txtBoxIssuerName.Text.ToString();
            var faceValue = Double.Parse(txtBoxFaceValue.Text.ToString());
            var quantity = Double.Parse(txtBoxQuantity.Text.ToString());
            var NumberOfYears = Double.Parse(txtBoxNumberOfYears.Text.ToString());
            var NumOfYears = Decimal.Parse(txtBoxNumOfYears.Text.ToString());
            var AnnualRate = Double.Parse(txtBoxAnnualRate.Text.ToString());


            
            _traders.Add(new TraderBondsEntities
            {

                TraderId = traderId,
                TraderName = traderName,
                IssuerName = issuerName,
                FaceValue = faceValue,
                Quantity = quantity,
                Years = NumOfYears,
                Coupon = AnnualRate
            }
            );


            txtBoxTradeId.Text = String.Empty;
            txtBoxTraderName.Text = String.Empty;
            txtBoxIssuerName.Text = String.Empty;
            txtBoxFaceValue.Text = String.Empty;
            txtBoxQuantity.Text = String.Empty;
            txtBoxNumberOfYears.Text = String.Empty;
            txtBoxNumOfYears.Text = String.Empty;
            txtBoxAnnualRate.Text = String.Empty;
            txtBoxTotalValue.Text = String.Empty;
        }

        //Code to discuss in demo  -- Code to call either the Bond or Equity Valuation Library
        private void button2_Click(object sender, EventArgs e)
        {

            if (txtBoxSecurityType.Text.ToString() == "Equity")
            {
                var traderId = Int32.Parse(txtBoxTradeId.Text.ToString());
                var quantity = Double.Parse(txtBoxQuantity.Text.ToString());
                var issuerName = txtBoxIssuerName.Text.ToString();
                var faceValue = Double.Parse(txtBoxFaceValue.Text.ToString());
                var NumberOfYears = Double.Parse(txtBoxNumberOfYears.Text.ToString());
                var Years = Decimal.Parse(txtBoxNumOfYears.Text.ToString());
                var Coupon = Double.Parse(txtBoxAnnualRate.Text.ToString());

                //Equity Valuation Library
                //var oCunyMainB = new oCunyMainEsc();

               // var oReturnValue = oCunyMainEsc.GetTraderAction(traderId, txtBoxTraderName.ToString(), string.Empty, faceValue, quantity, 1, 1, 1);
               // txtBoxTotalValue.Text = oReturnValue.TotalValue.ToString();
            }
            
           else //Demo called Bond Valuation Library
            {
                var traderId = Int32.Parse(txtBoxTradeId.Text.ToString());
                var quantity = Double.Parse(txtBoxQuantity.Text.ToString());
                var issuerName = txtBoxIssuerName.Text.ToString();
                var faceValue = Double.Parse(txtBoxFaceValue.Text.ToString());
                var NumberOfYears = Double.Parse(txtBoxNumberOfYears.Text.ToString());
                var Years = Decimal.Parse(txtBoxNumOfYears.Text.ToString());
                var Coupon = Double.Parse(txtBoxAnnualRate.Text.ToString());
                
                var oCunyMainB = new CunyMainB(); //Bond Valuation Library
             
                var oReturnValue = oCunyMainB.GetBondCalcSingleBond(traderId, txtBoxTraderName.ToString(), string.Empty, faceValue, quantity, 1, 1, 1);
                txtBoxTotalValue.Text = oReturnValue.TotalValue.ToString();
            }
        }



        private void btnCalculate3_Click(object sender, EventArgs e)
        {
            if (_traders != null)
            {

                var oCunyMainB = new CunyMainB();
                var oReturnValue = oCunyMainB.GetBondCalcMultipleBond(_traders);
            }
            else
            {

            }
        }



    }
}

