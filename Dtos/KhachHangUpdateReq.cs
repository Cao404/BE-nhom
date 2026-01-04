namespace SellerHub.Api.Dtos;

public class KhachHangUpdateReq
{
    public string HoTen { get; set; } = "";
    public string? Email { get; set; }
    public string SoDienThoai { get; set; } = "";
    public string? DiaChi { get; set; }
    public string Loai { get; set; } = "thuong";
}