using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;


namespace CafeRestaurant.DTOs
{
    public class Dashboards
    {

        public void WelcomeDate(DateTime date, System.Windows.Forms.Label lblDate, System.Windows.Forms.Label lblClock)
        {
            lblDate.Text = date.DayOfWeek.ToString() + ", " +
                           date.ToString("MMMM", CultureInfo.InvariantCulture) + " " +
                           date.Day.ToString() + ", " +
                           date.Year.ToString();

            lblClock.Text = date.ToString("HH:mm");
        }
    }
    
}
