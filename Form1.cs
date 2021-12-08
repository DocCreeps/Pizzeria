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
            ListePizza.DataSource = db.CataloguePizza.ToList();


            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(db.CataloguePizza.ToList());
            comboClient.ValueMember = "NumPizza";
            comboClient.DisplayMember = "NomPizza";
            comboClient.DataSource = ListC;
        }
    }
}
