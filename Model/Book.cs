//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookmaster_Tolmachev.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public Book()
        {
            this.BookAuthor = new HashSet<BookAuthor>();
            this.BookCover = new HashSet<BookCover>();
            this.BookSubject = new HashSet<BookSubject>();
        }
    
        public int Bookid { get; set; }
        public string Title { get; set; }
        public string Subttle { get; set; }
        public System.DateTime FirstPublicDate { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        public virtual ICollection<BookCover> BookCover { get; set; }
        public virtual ICollection<BookSubject> BookSubject { get; set; }
    }
}
