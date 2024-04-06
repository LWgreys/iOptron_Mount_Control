using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iOptron_Mount_Control
{
    public partial class Sidereal_Form : Form
    {
        const double sec_SolarYear = 31556952;          // 365.2425 * 24 * 60 * 60
        const double sec_SiderealYear = 31558149.504;   // 366.2422 days in a year (day = 23h 56m 4.0916s)
        const double siderealMultiplyer = days_SolarYear / days_SiderealYear;
        private double _st_;

        public Sidereal_Form()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            timer_Sidereal.Stop();
            Close();
        }

        private void Sidereal_Form_Load(object sender, EventArgs e)
        {
            timer_Sidereal.Start();
        }

        private void readSiderealTime(object sender, EventArgs e)
        {
            _st_ = MainControlForm.UTC_sidereal_time;
            _st_ -=(int)_st_;
            utc_sidereal.Text = MainControlForm.RetTimeString(_st_);
            _st_ = MainControlForm.Local_sidereal_time;
            _st_ -=(int)_st_;
            local_sidereal.Text = MainControlForm.RetTimeString(_st_);
        }
    }
}
