//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniOBS
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciNot
    {
        public int OgrenciNotID { get; set; }
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public string SinavTuru { get; set; }
        public string SinavNotu { get; set; }
    
        public virtual Ders Ders { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}