//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace machidesignAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Groups()
        {
            this.Events = new HashSet<Events>();
        }
    
        public long GroupId { get; set; }
        public System.DateTime InsDate { get; set; }
        public System.DateTime UpdDate { get; set; }
        public string InsAccountId { get; set; }
        public string UpdAccountId { get; set; }
        public string YukoFlg { get; set; }
        public string GroupName { get; set; }
        public string Email { get; set; }
        public string HomePege { get; set; }
        public string ImageUrl { get; set; }
        public string GroupDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Events> Events { get; set; }
        public virtual Jichitais Jichitais { get; set; }
    }
}
