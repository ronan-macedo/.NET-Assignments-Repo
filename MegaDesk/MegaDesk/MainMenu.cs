using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAll = new ViewAllQuotes();
            viewAll.Tag = this;
            viewAll.Show(this);
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
