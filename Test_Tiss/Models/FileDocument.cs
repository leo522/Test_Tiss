//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Tiss.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FileDocument
    {
        public int ID { get; set; }
        public Nullable<int> PId { get; set; }
        public string DocumentName { get; set; }
        public Nullable<System.DateTime> UploadTime { get; set; }
        public string Creator { get; set; }
        public string DocumentType { get; set; }
        public Nullable<int> FileSize { get; set; }
        public Nullable<System.DateTime> LastModifiedTime { get; set; }
    }
}
