﻿namespace PCConf.Models.Parts
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Brand")]
    public class Brand : Nomenclature
    {
        public string Logo { get; set; }
    }
}
