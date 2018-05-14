using System;
using System.Web.Services;

namespace WebService_Task11
{
    /// <summary>
    /// This class conains method to calculate count of day from Anno Domini to the entered date.
    /// </summary>
    [WebService(Namespace = "http://www.days_calculator.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class DaysADCounter : WebService
    {
        /// <summary>
        /// Method calculates count of day from Anno Domini to the entered date.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        [WebMethod]
        public int CalculateDaysFromAD(int day, int month, int year)
        {
            DateTime date;
            DateTime firstDate = new DateTime(1, 1, 1);
            string dateToString = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            if (DateTime.TryParse(dateToString, out date))
            {
                date = new DateTime(year,month,day);
                return (date - firstDate).Days;         
            }
            else
            {
                throw new FormatException("Error! Wrong date format.");
            }
        }
    }
}
