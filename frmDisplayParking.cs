using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkyBox
{
    public partial class frmDisplayParking : Form
    {
        //DataTable displayParking = new DataTable();
       public static DataGridView displayView = new DataGridView();
        public frmDisplayParking()
        {
            InitializeComponent();
            //displayParking.Columns.Add(new DataColumn("Nom du parking", typeof(System.String)));
            //dgvParking.DataSource = displayParking;
        }
    }
}
