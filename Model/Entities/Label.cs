﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;
public class Label
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LabelId { get; set; } //PK
    
    [Required(ErrorMessage = "Dit moet ingevuld zijn.")]
    [MinLength(1, ErrorMessage = "Dit moet ingevuld zijn.")]
    public string Titel { get; set; }

    [Required(ErrorMessage = "Dit moet ingevuld zijn.")]
    [MinLength(1, ErrorMessage = "Dit moet ingevuld zijn.")]
    public string Beschrijving { get; set; }
}