namespace LibraryManager.Models
{
    public class Books
    {
        //Constructors
        public Books(int? id, string title, int? pageCount, string author, int? createdBy)
        {
            this.id = id;
            this.title = title;
            this.pageCount = pageCount;
            this.author = author;
            this.createdBy = createdBy;
        }

        public Books(string title, int? pageCount, string author, int? createdBy)
        {
            this.title = title;
            this.pageCount = pageCount;
            this.author = author;
            this.createdBy = createdBy;
        }

        public Books(int? id, string title, int? pageCount, string author)
        {
            this.id = id;
            this.title = title;
            this.pageCount = pageCount;
            this.author = author;
        }

        public Books( string title, int? pageCount, string author)
        {
            this.title = title;
            this.pageCount = pageCount;
            this.author = author;
        }

        public int? id { get; set; }
        public string title { get; set; }
        public int? pageCount { get; set; } = 0;
        public string author { get; set; }
        public int? createdBy { get; set; }



    }
}
