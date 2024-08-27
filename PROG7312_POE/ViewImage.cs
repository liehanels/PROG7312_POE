using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class ViewImage : Form
    {
        public ViewImage(Image image)
        {
            //initial load
            InitializeComponent();
            //sets the size to the image size
            picBoxView.Image = image;
            picBoxView.Size = image.Size;
            this.Size = image.Size;
        }
        //allows the user to click the image to close it
        private void picBoxView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
