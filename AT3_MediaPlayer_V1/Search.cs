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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        LinkedList<Song> songs = new LinkedList<Song>();
        Song song1 = new Song("1", "quaa", "metal", "punk");
        Song song2 = new Song("2", "fdgdfgg", "metal", "gdfgdfgg");
        Song song3 = new Song("3", "dgdgdfg", "gdfdff", "punk");
        
        string nameSel;
        string genreSel;
        string artSel;
        string albSel;
        private void Search_Load(object sender, EventArgs e)
        {
            songs.AddLast(song1);
            songs.AddLast(song2);
            songs.AddLast(song3);

            List<string> names = new List<string>();
            List<string> artist = new List<string>();
            List<string> genres = new List<string>();
            List<string> album = new List<string>();

            foreach (Song song in songs)
            {
                names.Add(song.getName());
                names = names.Distinct().ToList();
                
                artist.Add(song.getArt());
                artist = artist.Distinct().ToList();

                genres.Add(song.getGenre());
                genres = genres.Distinct().ToList();

                album.Add(song.getAlb());
                album = album.Distinct().ToList();
            }
            albList.Items.AddRange(album.ToArray());
            nameList.Items.AddRange(names.ToArray());
            genreList.Items.AddRange(genres.ToArray());
            artList.Items.AddRange(artist.ToArray());            

        }
          
        // grabs the selected option from the combo box;
        private void nameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameSel = nameList.SelectedItem.ToString();
        }

        private void genreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreSel = genreList.SelectedItem.ToString();
        }

        private void artList_SelectedIndexChanged(object sender, EventArgs e)
        {
            artSel = artList.SelectedItem.ToString(); 
        }

        private void albList_SelectedIndexChanged(object sender, EventArgs e)
        {
            albSel = albList.SelectedItem.ToString(); 
        }

        public string[] getSelItems()
        {
            string[] searchItems = { nameSel, genreSel, artSel, albSel };
            return searchItems;
        }

        
    }
}
