using System;
using System.ComponentModel.DataAnnotations;

public class PitchDTO
{
    public int Id { get; set; }
    public string PitchType { get; set; }
    public string PitchSize { get; set; }
    public string PostCode { get; set; }
    public string Address { get; set; }
    public string Note { get; set; }
}
