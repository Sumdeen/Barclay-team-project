using System;

using System.Globalization;





namespace Barclays.Wilma.Service.CUNY.Common

{

    public static class DateTimeHelper

    {

        public static DateTime DoIsoToDate(this string vIsoDate)

        {

            try

            {



                var vDate = DateTime.ParseExact(vIsoDate, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None);

                return vDate;

            }

            catch (Exception )

            {

                return DateTime.MaxValue;

            }



        }
    }
}