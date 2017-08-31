using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JsBHO
{
    public partial class SearchForm : Form
    {
        
        Log log = new Log();
        public SearchForm()
        {
            InitializeComponent();
        }
        public string URLText
        {
            get { return this.url.Text; }
            set { this.url.Text = value; }
        }
        public string KeyWordsText
        {
            get { return this.keyWords.Text; }
            set { this.keyWords.Text = value; }
        }        
    }
}
