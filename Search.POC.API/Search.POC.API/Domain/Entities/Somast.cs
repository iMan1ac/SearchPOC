﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Search.POC.API.Domain.Entities
{
    [Table("SOMAST")]
    public partial class Somast
    {
        [Key]
        [Column("SOMKEYID")]
        public int Somkeyid { get; set; }
        [Column("SONO")]
        [StringLength(50)]
        public string Sono { get; set; }
        [Column("SOTYPE")]
        [StringLength(50)]
        public string Sotype { get; set; }
        [Column("SOSTAT")]
        [StringLength(50)]
        public string Sostat { get; set; }
        [Column("CUSTNO")]
        [StringLength(50)]
        public string Custno { get; set; }
        [Column("TERR")]
        [StringLength(50)]
        public string Terr { get; set; }
        [Column("WEB_REFERENCE")]
        [StringLength(50)]
        public string WebReference { get; set; }
        [Column("PONUM")]
        [StringLength(50)]
        public string Ponum { get; set; }
        [Column("SOURCE")]
        [StringLength(50)]
        public string Source { get; set; }
        [Column("CCLastFourDigits")]
        [StringLength(50)]
        public string CclastFourDigits { get; set; }
    }
}