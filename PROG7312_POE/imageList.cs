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
    public partial class imgList : Form
    {
        private List<Image> _images;
        private ListView ListV;
        private ImageList ListImg;
        public imgList(List<Image> images)
        {
            InitializeComponent();
            ListV = new ListView();
            ListImg = new ImageList();
            _images = images;
            ListImg.ImageSize = new Size(128, 128);
            foreach (Image image in _images)
            {
                ListImg.Images.Add(image);
            }
            ListV.LargeImageList = ListImg;
            int c = 0;
            foreach (Image image in _images)
            {
                ListV.Items.Add(new ListViewItem($"Image {c + 1}", c));
                c++;
            }
            ListV.SelectedIndexChanged += new EventHandler(ListV_SelectedIndexChanged);
            ListV.Dock = DockStyle.Fill;
            this.Controls.Add(ListV);
        }
        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListV.SelectedItems.Count > 0)
            {
                int selectedIndex = ListV.SelectedItems[0].ImageIndex;
                //opens the picture in a larger view
                Image img = _images[selectedIndex];
                ViewImage viewImage = new ViewImage(img);
                viewImage.Size = img.Size;
                //centres picture box on parent
                viewImage.StartPosition = FormStartPosition.CenterParent;
                viewImage.ShowDialog();
            }
        }
    }
}
