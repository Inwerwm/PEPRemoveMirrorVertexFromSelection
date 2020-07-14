using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEPExtensions;

namespace RemoveMirrorVertexFromSelection
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;
        IPXPmx pmx;

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
            Format();
        }

        public void Format()
        {
            pmx = args.Host.Connector.Pmx.GetCurrentState();
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void SelectedVertexIndicesHalfer(Func<float,bool> compare)
        {
            PEPlugin.View.IPXPmxViewConnector viewCon = args.Host.Connector.View.PmxView;
            viewCon.SetSelectedVertexIndices(viewCon.GetSelectedVertexIndices().Where(i => compare(pmx.Vertex[i].Position.X)).ToArray());
            viewCon.UpdateView();
        }

        private void buttonOpenNegative_Click(object sender, EventArgs e)
        {
            SelectedVertexIndicesHalfer(f => 0 <= f);
        }

        private void buttonOpenPositive_Click(object sender, EventArgs e)
        {
            SelectedVertexIndicesHalfer(f => 0 >= f);
        }

        private void buttonCloseNegative_Click(object sender, EventArgs e)
        {
            SelectedVertexIndicesHalfer(f => 0 < f);
        }

        private void buttonClosePositive_Click(object sender, EventArgs e)
        {
            SelectedVertexIndicesHalfer(f => 0 > f);
        }
    }
}