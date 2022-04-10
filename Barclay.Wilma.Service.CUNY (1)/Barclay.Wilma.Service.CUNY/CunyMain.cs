using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Barclays.Wilma.Service.CUNY.DataSource;

using Barclays.Wilma.Service.CUNY.Entities;



namespace Barclays.Wilma.Service.CUNY

{

    public class CunyMain

    {

        public List<TraderActionEntities> GetTraderActions(int traderId)

        {

            var oTraderActionSource = new TraderActionSource();

            var lTradeActions = oTraderActionSource.GetTraderActions(traderId);

            return lTradeActions;

        }

    }

}