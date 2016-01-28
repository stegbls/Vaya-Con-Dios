#define debug 

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
        private int mousex = 0;
        private int mousey = 0;

        public MainFrame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
#if debug
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Font font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "x = " + mousex.ToString() + " : y = " + mousey.ToString(), font,
                new Rectangle(30, 20, 200, 40), Color.Black, flags);
#endif
            TextRenderer.DrawText(dc, "Press Escape to close Program", font,
                new Rectangle(30, 60, 400, 40), Color.Black, flags);
            base.OnPaint(e);
        }

        private void MainFrame_MouseMove(object sender, MouseEventArgs e)
        {
            mousex = e.X;
            mousey = e.Y;
            this.Refresh();
        }

        private void MainFrame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MainFrame_MouseMove_1(object sender, MouseEventArgs e)
        {

        }
    }
}
