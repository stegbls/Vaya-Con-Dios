using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterProject
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Main event handler/listener for game ticks.
        /// This is the heartbeat of the game, called every 100ms.
        /// Handles rendering and physics.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTime_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Overriding the method to refresh the form for displaying.
        /// Basically our renderer
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            base.OnPaint(e);
        }
    }
}
