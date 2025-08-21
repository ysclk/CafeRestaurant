using CafeRestaurant.DTOs;
using CafeRestaurant.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class ReportService
    {

        // Method to get daily total amounts from stored procedure
        /// <summary>
        /// Get daily total amounts from stored procedure asynchronously
        /// </summary>
        /// <param name="startDate">Start date of the period</param>
        /// <param name="endDate">End date of the period</param>
        /// <returns>DataTable containing OrderDate, DailyAmount, and TotalOrder</returns>
        public async Task<DataTable> GetDailyTotalAmountFromSPAsync(DateTime startDate, DateTime endDate)
        {
            using (var context = new CafeRestaurantEntities())
            {
                // Create SQL parameters for stored procedure
                var paramStart = new SqlParameter("@StartDate", startDate);
                var paramEnd = new SqlParameter("@EndDate", endDate);

                // Execute the stored procedure and map results to DTO asynchronously
                var result = await context.Database.SqlQuery<DailyTotalAmountDTO>(
                    "EXEC SP_DAILYTOTALAMOUNT @StartDate, @EndDate",
                    paramStart,
                    paramEnd
                ).ToListAsync();

                // Create DataTable and define columns
                DataTable dt = new DataTable();
                dt.Columns.Add("OrderDate", typeof(DateTime));
                dt.Columns.Add("Daily Amount", typeof(decimal));
                dt.Columns.Add("Total Order", typeof(int));

                // Fill DataTable with results
                foreach (var item in result)
                {
                    dt.Rows.Add(item.OrderDate, item.DailyAmount, item.TotalOrder);
                }

                return dt;
            }
        }

        /// <summary>
        /// Get monthly total amounts from stored procedure asynchronously
        /// </summary>
        /// <param name="year">Year for which monthly totals are calculated</param>
        /// <returns>DataTable containing Year, Month, MonthlyAmount, and TotalOrder</returns>
        public async Task<DataTable> GetMonthlyTotalAmountFromSPAsync(int year)
        {
            using (var context = new CafeRestaurantEntities())
            {
                // Create SQL parameter for stored procedure
                var paramYear = new SqlParameter("@Year", year);

                // Execute the stored procedure and map results to DTO asynchronously
                var result = await context.Database.SqlQuery<MonthlyTotalAmountDTO>(
                    "EXEC SP_MONTHLYTOTALAMOUNT @Year",
                    paramYear
                ).ToListAsync();

                // Create DataTable and define columns
                DataTable dt = new DataTable();
                dt.Columns.Add("Year", typeof(int));
                dt.Columns.Add("Month", typeof(int));
                dt.Columns.Add("Monthly Amount", typeof(decimal));
                dt.Columns.Add("Total Order", typeof(int));

                // Fill DataTable with results
                foreach (var item in result)
                {
                    dt.Rows.Add(item.Year, item.Month, item.MonthlyAmount, item.TotalOrder);
                }

                return dt;
            }
        }
    }
}

