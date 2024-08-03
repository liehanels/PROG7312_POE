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
            InitializeComponent();
            picBoxView.Image = image;
            this.Size = image.Size;
            picBoxView.Size = image.Size;
        }

        private void picBoxView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
