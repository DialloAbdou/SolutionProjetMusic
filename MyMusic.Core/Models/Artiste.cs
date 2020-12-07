using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyMusic.Core.Models
{
    public class Artiste
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Music> Musics { get; set; }

        public Artiste()
        {
            Musics = new Collection<Music>();
        }


    }
}
