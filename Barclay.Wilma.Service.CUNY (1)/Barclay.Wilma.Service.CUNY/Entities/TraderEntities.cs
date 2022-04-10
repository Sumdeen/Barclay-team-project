using System;





namespace Barclays.Wilma.Service.CUNY.Entities

{

    public class TraderEntities

    {



        public int Pkid { get; set; }

        public int TraderId { get; set; }

        public string TraderName { get; set; }

    }



    public class TraderActionEntities : TraderEntities

    {

        public DateTime TradeDate { get; set; }

        public string InstrumentId { get; set; }

        public string InstrumentName { get; set; }

        public string InstrumentType { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

    }





}