using CafeRestaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class ReportsForm : Form
    {
        // Service responsible for fetching report data
        private readonly ReportService _reportService = new ReportService();

        // DataTable to hold the report data for the grid
        private DataTable _dataReport = new DataTable();

        public ReportsForm()
        {
            InitializeComponent();

            // Load initial daily report for today
            LoadDailyReport(DateTime.Now, DateTime.Now);

            // Fill the year selection combo box
            FillYearComboBox();
        }

        /// <summary>
        /// Loads daily report data between the given start and end dates.
        /// </summary>
        private void LoadDailyReport(DateTime startDate, DateTime endDate)
        {
            _dataReport = _reportService.GetDailyTotalAmountFromSP(startDate, endDate);
            dgReport.DataSource = _dataReport;
        }

        /// <summary>
        /// Handles the Daily Report button click.
        /// Loads data based on the selected start and end dates from the date pickers.
        /// </summary>
        private void btnDaylieReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            LoadDailyReport(startDate, endDate);
        }

        /// <summary>
        /// Populates the year combo box with the last 10 years including the current year.
        /// </summary>
        private void FillYearComboBox()
        {
            int currentYear = DateTime.Now.Year;

            cmbYears.Items.Clear();
            for (int year = currentYear; year >= currentYear - 10; year--)
            {
                cmbYears.Items.Add(year);
            }

            cmbYears.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the Monthly Report button click.
        /// Loads monthly aggregated data based on the selected year.
        /// </summary>
        private void btnMonthly_Click(object sender, EventArgs e)
        {
            if (cmbYears.SelectedItem == null) return;

            int selectedYear = (int)cmbYears.SelectedItem;
            DataTable monthlyReport = _reportService.GetMonthlyTotalAmountFromSP(selectedYear);

            dgReport.DataSource = monthlyReport;
        }
    }
}

