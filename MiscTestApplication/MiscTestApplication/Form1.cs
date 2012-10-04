using System;
using System.Linq;
using System.Windows.Forms;
using MiscTestApplication.DataAdapter;

namespace MiscTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityModelContainer container = new EntityModelContainer();

            MessageBox.Show(container.MainEntity1.First().Name);

        }
    }
}
