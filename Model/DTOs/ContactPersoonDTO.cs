﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs;
public class ContactPersoonDTO
{
    public int ContactpersoonId { get; set; }
    public string Familienaam { get; set; }
    public string Voornaam { get; set; }
    public string Email { get; set; }
    public string GSMNummer { get; set; }
    public string TelefoonNummer { get; set; }
}
