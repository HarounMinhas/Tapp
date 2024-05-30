namespace Model.DTOs;

public class TaakDTO
{
    public int TaakId { get; set; }
    public StatusDTO? Status { get; set; }
    public DatumUurDTO? DatumUur { get; set; }
    public string Titel { get; set; }
    public string Beschrijving { get; set; }
    public ICollection<ToDoDTO>? ToDos { get; set; }
    public LabelDTO? Label { get; set; }
}