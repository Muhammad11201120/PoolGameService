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
    public partial class ctrPool : UserControl
    {
        private static int _instanceNumber = 0;
        private int _Seconds;
        private string _TablePlayer = "Player";
        private float _HourlyRate = 10.00F;

        public ctrPool()
        {
            _instanceNumber++;

            InitializeComponent();
            lblTableTitle.Text = "Table " + _instanceNumber.ToString();
        }
        public class TableCompletedEventArgs : EventArgs
        {
            public string TableTitle { get; }
            public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float RatePerHour { get; }
            public float TotalFees { get; }
            public TableCompletedEventArgs( string tableTitle, string timeText, int timeInSeconds, float ratePerHour, float totalFees )
            {
                TableTitle = tableTitle;
                TimeText = timeText;
                TimeInSeconds = timeInSeconds;
                RatePerHour = ratePerHour;
                TotalFees = totalFees;
            }
        }
        public event EventHandler<TableCompletedEventArgs> OnTableCompleted;
        protected virtual void RaiseOnTableCompleted( TableCompletedEventArgs e )
        {
            OnTableCompleted?.Invoke( this, e );
        }



        [
        Category( "Pool Config" ),
        Description( "The Player Name." )
        ]

        public string TablePlayer
        {
            get
            {
                return _TablePlayer;
            }
            set
            {
                _TablePlayer = value;

                lblName.Text = value;

                // The Invalidate method calls the OnPaint method, which redraws
                // the control.  
                Invalidate();
            }
        }


        [
        Category( "Pool Config" ),
        Description( "Rate Per Hour." )
        ]
        public float HourlyRate
        {
            get
            {
                return _HourlyRate;
            }
            set
            {
                _HourlyRate = value;

            }
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            _Seconds++;
            TimeSpan time = TimeSpan.FromSeconds( _Seconds );
            string str = time.ToString( @"hh\:mm\:ss" );
            lblTime.Text = str;
            lblTime.Refresh();
        }

        private void ctrPool_Load( object sender, EventArgs e )
        {
            lblName.Text = _TablePlayer;
        }

        private void btnStartStop_Click( object sender, EventArgs e )
        {
            if ( btnStartStop.Text == "Start" )
            {
                btnStartStop.Text = "Stop";
                btnStartStop.ForeColor = Color.Red;
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                btnStartStop.ForeColor = Color.Green;
                timer1.Stop();
            }
        }

        private void btnEnd_Click( object sender, EventArgs e )
        {
            timer1.Stop();
            float TotalFees = ( ( float ) _Seconds / 60 / 60 ) * _HourlyRate;
            RaiseOnTableCompleted( new TableCompletedEventArgs( lblTableTitle.Text, lblTime.Text, _Seconds, _HourlyRate, TotalFees ) );
            lblName.Text = "Player";
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            btnStartStop.ForeColor = Color.Green;
            _Seconds = 0;
        }
    }
}