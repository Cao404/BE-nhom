namespace SellerHub.Api.Models.Requests;

public sealed class CreateDanhMucRequest
{
    public string? MaDanhMucCode { get; set; }
    public string TenDanhMuc { get; set; } = string.Empty;
    public int? MaDanhMucCha { get; set; }
}
