using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class AuditLogsView : Form
    {
        private Panel parentPanel;

        public AuditLogsView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
        }
    }
}
