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
    
    public partial class Subject
    {
        public Subject()
        {
            this.BookSubject = new HashSet<BookSubject>();
        }
    
        public int Subjectld { get; set; }
        public string Subject1 { get; set; }
    
        public virtual ICollection<BookSubject> BookSubject { get; set; }
    }
}
