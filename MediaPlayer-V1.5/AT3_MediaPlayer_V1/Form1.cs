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
            string param = "get" + type+"()";
            songList.Items.Add(param);
            Song[] songTemp = songs.ToArray();
            Song key;
            
            insertionSort(songTemp);

            void insertionSort(Song[] sortSong)
            {
                
                int n = sortSong.Length;
                for(int i = 1; i < n; i++)
                {
                    key = sortSong[i];
                    int j = i - 1;
                    string boi = sortSong[j].getName();
                    string boi2 = key.getName();
                    
                    switch (type)
                    {
                        case "Name":
                            boi = sortSong[j].getName();
                            boi2 = key.getName();
                            break;
                        case "Genre":
                            boi = sortSong[j].getGenre();
                            boi2 = key.getGenre();
                            break;
                        case "Artist":
                            boi = sortSong[j].getArtist();
                            boi2 = key.getArtist();
                            break;
                        case "Album":
                            boi = sortSong[j].getAlbum();
                            boi2 = key.getAlbum();
                            break;
                        default:
                            boi = sortSong[j].getName();
                            boi2 = key.getName();
                            break;
                    }
                    
                    while (j >= 0 && string.Compare(boi, boi2) > 0) 
                    {
                        sortSong[j + 1] = sortSong[j];
                        j = j - 1;
                    }
                    sortSong[j + 1] = key;
                }
                List<Song> sortedSongs = sortSong.ToList();
                listSongFiltered(sortedSongs);
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
                    if (song.getArtist() != searchCriteria[2])
                    {
                        songTemp2.Remove(song);
                    }
                }
            }
            if (searchCriteria[3] != null)
            {
                foreach (Song song in songTemp)
                {
                    if (song.getAlbum() != searchCriteria[3])
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
                songList.Items.Add(song.getName() + "    " + song.getGenre() + "  " + song.getArtist() + "   " + song.getAlbum());
            }
        }

        private void listSongFiltered(List<Song> songs)
        {
            songList.Items.Clear();
            songList.Items.Add("Name    Genre   Artist  Album");
            foreach(Song song in songs)
            {
                songList.Items.Add(song.getName() +"    "+ song.getGenre() + "  " + song.getArtist() + "   " + song.getAlbum());
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
