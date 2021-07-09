using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSongGenerator
{
    public partial class CoreWindow : Form
    {


        public CoreWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MIDIHandler.CreateHeaderChunk();

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
