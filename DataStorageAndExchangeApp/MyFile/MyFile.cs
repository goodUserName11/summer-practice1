using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFile
{
    class MyFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] data { get; set; }
        public string Description { get; set; }
        public DateTime AddingDate { get; private set; }
        public int CreatorID { get; set; }
        public DateTime LastModified { get; private set; }
        public int TimesDowloaded { get; private set; }

        public MyFile(int id, string fileName, byte[] data, string description, DateTime addingDate,
            int creatorID, DateTime lastModified, int timesDowloaded)
        {
            Id = id;
            FileName = fileName;
            this.data = data;
            Description = description;
            AddingDate = addingDate;
            CreatorID = creatorID;
            LastModified = lastModified;
            TimesDowloaded = timesDowloaded;
        }

        public MyFile(int id, string fileName, string description, DateTime addingDate, 
            int creatorID, DateTime lastModified, int timesDowloaded)
        {
            Id = id;
            FileName = fileName;
            Description = description;
            AddingDate = addingDate;
            CreatorID = creatorID;
            LastModified = lastModified;
            TimesDowloaded = timesDowloaded;
        }

        public MyFile(int id, string fileName, byte[] data, string description, int creatorID)
        {
            Id = id;
            FileName = fileName;
            this.data = data;
            Description = description;
            CreatorID = creatorID;
        }

        public MyFile() { }
    }
}
