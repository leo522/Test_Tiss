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
    
    public partial class Public_InfoPageContent
    {
        public int ID { get; set; }
        public string TextContent { get; set; }
        public byte[] ImageContent { get; set; }
        public Nullable<System.DateTime> FileUploadTime { get; set; }
        public Nullable<System.DateTime> TextUpdateTime { get; set; }
        public Nullable<System.DateTime> ImageUpdateTime { get; set; }
        public string VideoURL { get; set; }
        public Nullable<System.DateTime> VideoUpdateTime { get; set; }
        public string WebsiteURL { get; set; }
        public Nullable<System.DateTime> WebsiteURLUpdateTime { get; set; }
        public string UserAccount { get; set; }
        public Nullable<System.DateTime> UserLoginTime { get; set; }
    }
}
