using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarDtos;

public class UpdateCarDto
{
    public int CarId { get; set; }
    public int BrandId { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Km { get; set; } //kilometre sayacı
    public string Transmission { get; set; } //vites türü
    public byte Seat { get; set; } //koltuk sayısı
    public byte Luggage { get; set; } //bagaj sayısı
    public string Fuel { get; set; } //yakıt türü
    public string BigImageUrl { get; set; } //aracın büyük görseli
}
