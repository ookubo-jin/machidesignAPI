﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace matidesign.Models
{
    /// <summary>
    /// イベントを表すクラス・コントロール
    /// </summary>
    public class Events
    {
        [Key]
        [DisplayName("イベントID")]
        public long EventsId { get; set; }

        [Required()]
        [DisplayName("作成日時")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime InsDate { get; set; }

        [Required()]
        [DisplayName("更新日時")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime UpdDate { get; set; }

        [StringLength(100)]
        [DisplayName("作成アカウントID")]
        public string InsAccountId { get; set; }

        [StringLength(100)]
        [DisplayName("更新アカウントID")]
        public string UpdAccountId { get; set; }

        [Required()]
        [StringLength(1)]
        [DisplayName("有効フラグ")]
        [Range(0, 1, ErrorMessage = "{0}は{1}～{2}の間で入力してください。")]
        public string YukoFlg { get; set; }

        //[StringLength(6)]
        //[DisplayName("自治体コード")]
        //public string JichitaiId { get; set; }

        //[DisplayName("自治体")]
        //public virtual Jichitai Jichitai { get; set; }

        [Required()]
        [DisplayName("グループID")]
        public long GroupId { get; set; }

        [DisplayName("グループ")]
        public virtual Group Group { get; set; }

        [Required()]
        [StringLength(400)]
        [DisplayName("イベント名")]
        public string EventName { get; set; }

        [Required()]
        [DisplayName("開催日（開始）")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",ApplyFormatInEditMode=true)]
        public DateTime KaisaiDate_Start { get; set; }

        [Required()]
        //[StringLength(4)]
        [DisplayName("開催時間（開始）")]
        public string KaisaiTime_Start { get; set; }

        [Required()]
        [DisplayName("開催日（終了）")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime KaisaiDate_End { get; set; }

        [Required()]
        //[StringLength(4)]
        [DisplayName("開催時間（終了）")]
        public string KaisaiTime_End { get; set; }

        [StringLength(2000)]
        [DisplayName("会場")]
        public string Kaijo { get; set; }

        [StringLength(2000)]
        [DisplayName("会場住所")]
        public string KaijoAdr { get; set; }

        [Url]
        [StringLength(2000)]
        [DisplayName("会場URL")]
        [DataType(DataType.Url)]
        public string KaijoUrl { get; set; }

        [Required()]
        [StringLength(4000)]
        [DisplayName("イベント概要")]
        [DataType(DataType.MultilineText)]
        public string EventDescription { get; set; }

        [Required()]
        [StringLength(4000)]
        [DisplayName("イベント詳細")]
        [DataType(DataType.MultilineText)]
        public string EventDetails { get; set; }

        [DisplayName("参加人数")]
        public int MaxNinzu { get; set; }

        [DisplayName("会費")]
        [DataType(DataType.Currency)]
        [Range(0, 9999999, ErrorMessage = "{0}は{1}～{2}の間で入力してください。")]
        [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        public decimal Kaihi { get; set; }

        [StringLength(400)]
        [DisplayName("会費備考")]
        public string KaihiBiko { get; set; }

    }
}