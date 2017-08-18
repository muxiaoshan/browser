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
        public SearchForm()
        {
            InitializeComponent();
        }
        public string InputText
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }
    }
}
