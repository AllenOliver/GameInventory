using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {

            var relativePath = Path.Combine("Sound", "errorSound.wav");
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var absolutePath = Path.Combine(baseDirectory, relativePath);


            System.Media.SoundPlayer player = new System.Media.SoundPlayer(absolutePath);

            player.Play();
            WaitSomeTime();
        }

        public async void WaitSomeTime()
        {
            await Task.Delay(8000);
            this.Close();
        }

    }
}
