using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT3_MediaPlayer_V1
{
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }
        string sortP;
        private void Sort_Load(object sender, EventArgs e)
        {
            string[] sortP = { "Name", "Genre", "Artist", "Album" };
            sortParam.Items.AddRange(sortP);
        }

        private void sortParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortP = sortParam.SelectedItem.ToString();
        }

        public string getSortParam()
        {
            return sortP;
        }
    }
}
