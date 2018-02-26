using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aikalaskuri
{
    public partial class TimeFilling : Form
    {
        string EventID;
        public TimeFilling(string inEventID)
        {
            InitializeComponent();

            EventID = inEventID;
            this.Text = "Aikojen syöttäminen";

        }
    }
}
