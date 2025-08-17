using CafeRestaurant.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class ReportService
    {

            // Method to get daily total amounts from stored procedure
            public DataTable GetDailyTotalAmountFromSP(DateTime startDate, DateTime endDate)
            {
                using (var context = new CafeRestaurantEntities())
                {
                    // Create SQL parameters for stored procedure
                    var paramStart = new SqlParameter("@StartDate", startDate);
                    var paramEnd = new SqlParameter("@EndDate", endDate);

                    // Execute the stored procedure and map results to DTO
                    var result = context.Database.SqlQuery<DailyTotalAmountDTO>(
                        "EXEC SP_DAILYTOTALAMOUNT @StartDate, @EndDate",
                        paramStart,
                        paramEnd
                    ).ToList();

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

            // Method to get monthly total amounts from stored procedure
            public DataTable GetMonthlyTotalAmountFromSP(int year)
            {
                using (var context = new CafeRestaurantEntities())
                {
                    // Create SQL parameter for stored procedure
                    var paramYear = new SqlParameter("@Year", year);

                    // Execute the stored procedure and map results to DTO
                    var result = context.Database.SqlQuery<MonthlyTotalAmountDTO>(
                        "EXEC SP_MONTHLYTOTALAMOUNT @Year",
                        paramYear
                    ).ToList();

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

