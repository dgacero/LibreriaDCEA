using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDCEA.Shared.Models;

public class Book {
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Editorial { get; set; } = "";
    public string ISBN { get; set; } = "";
    public string Edition { get; set; } = "";
    public float Price { get; set; }
    public string Image { get; set; } = "";
}