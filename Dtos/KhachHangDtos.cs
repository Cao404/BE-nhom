namespace SellerHub.Api.Dtos;

public class KhachHangDto
{
    public int MaKhachHang { get; set; }
    public string HoTen { get; set; } = "";
    public string? Email { get; set; }
    public string SoDienThoai { get; set; } = "";
    public string? DiaChi { get; set; }
    public string Loai { get; set; } = "thuong";

    public DateTime NgayThamGia { get; set; }
    public decimal TongChiTieu { get; set; }
    public DateTime? DonGanNhat { get; set; }
    public int SoDon { get; set; }
    public decimal DanhGia { get; set; }
    public bool TrangThai { get; set; }
}
