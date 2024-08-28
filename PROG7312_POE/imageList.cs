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
        //code attribute:
        //Title              : ImageList Class
        //Author             : Microsoft Learn
        //Date               : 27 Aug 2024
        //Version            : 4.8.1
        //Availability(link) : https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.imagelist?view=windowsdesktop-8.0

        //variables
        private List<Image> _images;
        private ListView ListV;
        private ImageList ListImg;
        public imgList(List<Image> images)
        {
            //initial load
            InitializeComponent();
            //creates the new list and view
            ListV = new ListView();
            ListImg = new ImageList();
            //import the images list to local list
            _images = images;
            //sets the images size
            ListImg.ImageSize = new Size(128, 128);
            //adds the images to the image list
            foreach (Image image in _images)
            {
                ListImg.Images.Add(image);
            }
            //set the list view
            ListV.LargeImageList = ListImg;
            //adds the images to the list view with titles
            int c = 0;
            foreach (Image image in _images)
            {
                ListV.Items.Add(new ListViewItem($"Image {c + 1}", c));
                c++;
            }
            //adds an event handler for selected index changed
            ListV.SelectedIndexChanged += new EventHandler(ListV_SelectedIndexChanged);
            //sets the list view to fill the page
            ListV.Dock = DockStyle.Fill;
            //adds the list view to the form
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

        private void imgList_Load(object sender, EventArgs e)
        {
        }
    }
}
