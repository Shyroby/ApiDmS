using System.Collections.Generic;

namespace ApiDmS.Models
{
    public class Priority
    {
        public int priorityID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
                
        //relationship
        public List<Document> documents { get; set; }

        //navigation properties
        public Document Document { get; set; }
    }
}