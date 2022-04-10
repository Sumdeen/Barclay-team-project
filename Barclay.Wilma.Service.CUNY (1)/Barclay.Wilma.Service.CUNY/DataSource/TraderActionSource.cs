using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Barclays.Wilma.Service.CUNY.Entities;

using Barclays.Wilma.Service.CUNY.Common;




namespace Barclays.Wilma.Service.CUNY.DataSource

{





    internal class TraderActionSource

    {

        internal List<TraderActionEntities> GetTraderActions(int traderId)

        {

            var lTraderAction = new List<TraderActionEntities>();

            var t1 = GetTraderAction_20211231();

            lTraderAction.Add(t1);



            //lTraderAction.Add(t1);

            lTraderAction.Add(GetTraderAction_20220113_01());

            lTraderAction.Add(GetTraderAction_20211231_2());
            lTraderAction.Add(GetTraderAction_20220113_02());
            
            lTraderAction.Add (GetTraderAction_20211231_3());
            lTraderAction.Add(GetTraderAction_20220113_03());
            
            lTraderAction.Add(GetTraderAction_20211231_4());
            lTraderAction.Add(GetTraderAction_20220113_04());
           
            lTraderAction.Add(GetTraderAction_20211231_5());

            lTraderAction.Add(GetTraderAction_20220113_05());

         



            return lTraderAction;

        }



        private TraderActionEntities GetTraderAction_20211231()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;

            var isoDate = "20211231";

            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "AAPL";

            oTraderAction.InstrumentName = "APPLE Inc.";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 172.19;



            return oTraderAction;

        }

        

        private TraderActionEntities GetTraderAction_20220113_01()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20220113";

            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "AAPL";

            oTraderAction.InstrumentName = "APPLE Inc.";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 177.57;



            return oTraderAction;

        }



        private TraderActionEntities GetTraderAction_20211231_2()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20211231";

            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "MSFT";

            oTraderAction.InstrumentName = "Microsoft Corp";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 336.32;



            return oTraderAction;

        }

        private TraderActionEntities GetTraderAction_20220113_02()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20220113";

            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "MSFT";

            oTraderAction.InstrumentName = "Microsoft Corp";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 304.80;



            return oTraderAction;

        }

        private TraderActionEntities GetTraderAction_20211231_3()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20211231";
            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "AMZN";

            oTraderAction.InstrumentName = "Amazon.com";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price =  3334.34;



            return oTraderAction;

        }

        private TraderActionEntities GetTraderAction_20220113_03()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20220113";

            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "AMZN";

            oTraderAction.InstrumentName = "Amazon.com";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 3224.28;



            return oTraderAction;

        }

        private TraderActionEntities GetTraderAction_20211231_4()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20211231";
            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "NFLX";

            oTraderAction.InstrumentName = "Netflix Inc";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 612.09;



            return oTraderAction;

        }


        private TraderActionEntities GetTraderAction_20220113_04()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20220113";
            oTraderAction.TradeDate = isoDate.DoIsoToDate();



            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "NFLX";

            oTraderAction.InstrumentName = "Netflix Inc";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 602.44;



            return oTraderAction;

        }



        private TraderActionEntities GetTraderAction_20211231_5()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20211231";

            oTraderAction.TradeDate = isoDate.DoIsoToDate();

            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "GOOGL";

            oTraderAction.InstrumentName = "Alphabet Inc.";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 2920.05;



            return oTraderAction;

        }

 
        

        private TraderActionEntities GetTraderAction_20220113_05()

        {

            var oTraderAction = new TraderActionEntities();



            oTraderAction.TraderId = 0117;
            var isoDate = "20220113";
            oTraderAction.TradeDate = isoDate.DoIsoToDate();


            oTraderAction.TraderName = "Summer Aberdeen";

            oTraderAction.InstrumentId = "GOOGL";

            oTraderAction.InstrumentName = "Alphabet Inc.";

            oTraderAction.InstrumentType = "Equity";

            oTraderAction.Quantity = 100;

            oTraderAction.Price = 2782.62;



            return oTraderAction;

        }
        
    }

}



