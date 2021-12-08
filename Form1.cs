using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        masterEntities db = new masterEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataPizza.DataSource = db.CLIENT.ToList();


            List<CLIENT> ListC = new List<CLIENT>();
            ListC.AddRange(db.CLIENT.ToList());
            comboClient.ValueMember = "NumClient";
            comboClient.DisplayMember = "NomClient";
            comboClient.DataSource = ListC;
        }

    }
}
