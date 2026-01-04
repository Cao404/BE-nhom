namespace SellerHub.Api.Models.Responses;

public sealed class SanPhamListItem
{
    public int MaSanPham { get; set; }
    public string SKU { get; set; } = "";
    public string TenSanPham { get; set; } = "";
    public int MaDanhMuc { get; set; }
    public string TenDanhMuc { get; set; } = "—";
    public decimal GiaBan { get; set; }
    public int Kho { get; set; }
    public int DaBan { get; set; }
    public string TrangThai { get; set; } = "Đang bán";
}
