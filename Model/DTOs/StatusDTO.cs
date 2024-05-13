using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs;
public class StatusDTO
{
    public int? StatusId { get; set; }
    public string? Titel { get; set; }
    public string? Beschrijving { get; set; }
}
