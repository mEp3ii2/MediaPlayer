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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<Song> songs = new LinkedList<Song>();
        Song song1 = new Song("1", "quaa", "metal", "punk");
        Song song2 = new Song("2", "fdgdfgg", "metal", "gdfgdfgg");
        Song song3 = new Song("3", "dgdgdfg", "gdfdff", "punk");
        
        public void Sorting(String type)
        {
            Song[] songTemp = songs.ToArray();

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public void Searching()
        {
            

            Song[] songTemp = songs.ToArray();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            songs.AddLast(song1);
            songs.AddLast(song2);
            songs.AddLast(song3);
            listSongs();
            Search searchPage = new Search();
            DialogResult dialog = searchPage.ShowDialog();

            if(dialog == DialogResult.Cancel)
            {
                searchPage.Close();
            }
            else if (dialog == DialogResult.OK)
            {
                string[] searchCriteria = searchPage.getSelItems();
                searchedSongs(searchCriteria);
            }
        }
        public void searchedSongs(string[] searchCriteria)
        {
            List<Song> songTemp = songs.ToList();
            List<Song> songTemp2 = songs.ToList();

            if (searchCriteria[0] != null)
            {
                foreach(Song song in songTemp)
                {
                    if(song.getName() != searchCriteria[0])
                    {
                        songTemp2.Remove(song);
                    }
                }
            }
            if (searchCriteria[1] != null)
            {
                foreach (Song song in songTemp)
                {
                    if (song.getGenre() != searchCriteria[1])
                    {
                        songTemp2.Remove(song);
                    }
                }
            }
            if (searchCriteria[2] != null)
            {
                foreach (Song song in songTemp)
                {
                    if (song.getArt() != searchCriteria[2])
                    {
                        songTemp2.Remove(song);
                    }
                }
            }
            if (searchCriteria[3] != null)
            {
                foreach (Song song in songTemp)
                {
                    if (song.getAlb() != searchCriteria[3])
                    {
                        songTemp2.Remove(song);
                    }
                }
            }
            listSongFiltered(songTemp2); 
        }
        private void listSongs()
        {
            songList.Items.Clear();
            songList.Items.Add("Name    Genre   Artist  Album");
            foreach(Song song in songs)
            {
                songList.Items.Add(song.getName() + "    " + song.getGenre() + "  " + song.getArt() + "   " + song.getAlb());
            }
        }

        private void listSongFiltered(List<Song> songs)
        {
            songList.Items.Clear();
            songList.Items.Add("Name    Genre   Artist  Album");
            foreach(Song song in songs)
            {
                songList.Items.Add(song.getName() +"    "+ song.getGenre() + "  " + song.getArt() + "   " + song.getAlb());
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            Sort sortPage = new Sort();
            DialogResult dialog = sortPage.ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                sortPage.Close();
            }
            else if(dialog == DialogResult.OK)
            {
                string sortP = sortPage.getSortParam();
                Sorting(sortP);
            }
        }

        
    }
}
