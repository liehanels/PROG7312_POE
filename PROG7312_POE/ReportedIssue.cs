﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    internal class ReportedIssue
    {
        private string location;
        private string category;
        private string description;
        private string attachedFile;

        public ReportedIssue() { }
        public void attachUserFile(string attachFile) { this.attachedFile = attachFile; }
        public void setLocation(string location) { this.location = location; }
        public void setCategory(string category) { this.category = category; }
        public void setDescription(string description) { this.description = description; }
        public string getLocation() { return this.location; }
        public string getCategory() { return this.category; }
        public string getDescription() { return this.description; }
        public string getAttachedFile() { return this.attachedFile; }
    }
}
