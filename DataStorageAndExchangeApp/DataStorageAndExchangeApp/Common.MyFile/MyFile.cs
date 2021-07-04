using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.MyFile
{
    public class MyFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] data { get; set; }
        public string Description { get; set; }
        public DateTime AddingDate { get; private set; }
        public int CreatorID { get; set; }
        public string Creator { get; set; }

        public MyFile(int id, string fileName, byte[] data, string description, int creatorID)
        {
            Id = id;
            FileName = fileName;
            this.data = data;
            Description = description;
            CreatorID = creatorID;
        }

        public MyFile(byte[] data)
        {
            this.data = data;
        }

        public MyFile(int id, string fileName, string description, 
            DateTime addingDate, int creatorID, string creator)
        {
            Id = id;
            FileName = fileName;
            Description = description;
            AddingDate = addingDate;
            CreatorID = creatorID;
            Creator = creator;
        }

        public MyFile() { }
    }
}
