using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT3_MediaPlayer_V1
{
    class Song
    {
        // song varibles
        private string name;
        private string genre;
        private string artist;
        private string album;

        // constructor for song class
        public Song(string name, string genre, string artist, string album){
            this.name = name;
            this.genre = genre;
            this.artist = artist;
            this.album = album;
        }
        public Song()
        {

        }

        // getters and setters for Song Class 
        public void setName(string name)
        {
            this.name = name;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public void setArt(string artist)
        {
            this.artist = artist;
        }

        public void setAlb(string album)
        {
            this.album = album;
        }

        public string getName()
        {
            return name;
        }

        public string getGenre()
        {
            return genre;
        }

        public string getArtist()
        {
            return artist;
        }
        public string getAlbum()
        {
            return album;
        }
    }
    
}
