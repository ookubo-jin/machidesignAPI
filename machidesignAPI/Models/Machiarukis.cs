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
    
    public partial class Machiarukis
    {
        public long EventsId { get; set; }
        public System.DateTime InsDate { get; set; }
        public System.DateTime UpdDate { get; set; }
        public string InsAccountId { get; set; }
        public string UpdAccountId { get; set; }
        public string YukoFlg { get; set; }
        public Nullable<long> Events_EventsId { get; set; }
    }
}
