using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMGYavuz
{
    public partial class View : Form, IView
    {
        private IModel model;
        private IController controller;

        public View()
        {
            InitializeComponent();
        }

        public void setModel(IModel model)
        {
            this.model = model;
        }

        public void setController(IController controller)
        {
            this.controller = controller;
        }

        private void buttonGGTBerechnen_Click(object sender, EventArgs e)
        {
            int zahl1 = int.Parse(textBoxZahl2.Text);
            int zahl2 = int.Parse(textBoxZahl1.Text);

            controller.gGTBestimmen(zahl1, zahl2);
        }

        public void anzeigen(int ggt)
        {
            textBoxGGT.Text = ggt.ToString();
        }
    }
}