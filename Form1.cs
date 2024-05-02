using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrPool_OnTableCompleted( object sender, ctrPool.TableCompletedEventArgs e )
        {
            string TableResults = $"Table Title:   ( {e.TableTitle} )";
            TableResults += "\n\nTime Consumed = " + e.TimeText;
            TableResults += "\n\nTotal Seconds = " + e.TimeInSeconds;
            TableResults += "\n\nHourlyRate = " + e.RatePerHour.ToString() + " $";
            TableResults += "\n\nTotal Fees = " + e.TotalFees.ToString() + " $";

            MessageBox.Show( TableResults );
        }
    }
}
