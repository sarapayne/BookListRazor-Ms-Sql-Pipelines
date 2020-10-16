using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Book
    {
        [Key]
        private int mId;
        
        [Required]
        private string mName;

        private string mAuthor;

        public Book()
        {

        }

        public int ID
        {
            get { return mId; }
            set { this.mId = value; }
        }

        public string Name
        {
            get { return mName; }
            set { this.mName = value; }
        }

        public string Author
        {
            get { return mAuthor; }
            set { this.mAuthor = value; }
        }

    }
}
