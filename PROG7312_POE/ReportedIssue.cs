using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    public class ReportedIssue
    {
        //class variables
        private string location;
        private string category;
        private string description;
        private List<Image> attachedFiles;
        //initializer
        public ReportedIssue() { attachedFiles = new List<Image>(); }
        //set methods
        public void attachUserFile(Image attachFile) { this.attachedFiles.Add(attachFile); }
        public void setLocation(string location) { this.location = location; }
        public void setCategory(string category) { this.category = category; }
        public void setDescription(string description) { this.description = description; }
        //get methods
        public string getLocation() { return this.location; }
        public string getCategory() { return this.category; }
        public string getDescription() { return this.description; }
        public List<Image> getAttachedFiles() { return this.attachedFiles; }
    }
}
