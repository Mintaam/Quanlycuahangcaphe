﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiQuanCOFFEE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class qlBHEntities : DbContext
    {
        public qlBHEntities()
            : base("name=qlBHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<CHITIETHANGHOA> CHITIETHANGHOAs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public virtual DbSet<HANGHOA> HANGHOAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THUCDON> THUCDONs { get; set; }
    }
}