using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        #region Propiedades

        private List<Elemento> _lstElemento;

        #endregion //Propeidades

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _lstElemento = new List<Elemento>();

            _lstElemento.Add(new Elemento("Elemento1", 1));
            _lstElemento.Add(new Elemento("Elemento2", 2));
            _lstElemento.Add(new Elemento("Elemento3", 3));
            _lstElemento.Add(new Elemento("Elemento4", 4));

            this.bsElemento.DataSource = _lstElemento;
        }
    }
}
