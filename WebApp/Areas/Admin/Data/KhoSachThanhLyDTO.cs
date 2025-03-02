﻿namespace WebApp.Areas.Admin.Data
{

    public class SachNhapKhoDTO
    {
        public int MaSachKho { get; set; }
        public int SoLuongKhoTL { get; set; }

        public List<DTO_CT_cuonsach> listCT_cuonsach { get; set; }

        public SachNhapKhoDTO()
        {
            listCT_cuonsach = new List<DTO_CT_cuonsach>();
        }
    }
    public class DTO_CT_cuonsach
    {
        public string MaCuonSach { get; set; }
    }
    public class KhoSachThanhLyDTO
    {
        public int MaSachKho { get; set; }

        public string TenSach { get; set; }
        public int SoLuongKhoTL { get; set; }
        public decimal GiaSachTL { get; set; }
    }

    public class DTO_DonViTL
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public string DiaChiDV { get; set; }
        public string SDTDV { get; set; }
    }
    public class DTO_Sach_Tl
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuong { get; set; }

        public decimal GiaSach { get; set; }
    }

    public class DTO_Tao_Phieu_TL
    {
        public int MaNhanVien { get; set; }
        public int MaDonVi { get; set; }
        //public DateTime NgayTL { get; set; } = DateTime.Now;
        public DateOnly? NgayTL { get; set; }

        public List<DTO_Sach_Tl> listSachTL { get; set; }

        public DTO_Tao_Phieu_TL()
        {
            listSachTL = new List<DTO_Sach_Tl>();
        }
    }

    public class DTO_Sach_Nhap_Kho
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongHienTai { get; set; }

        public decimal GiaSach { get; set; }
        public List<DTO_CTSach_Nhap_Kho> listSachNhapKho { get; set; }

        public DTO_Sach_Nhap_Kho()
        {
            listSachNhapKho = new List<DTO_CTSach_Nhap_Kho>();
        }
    }
    public class DTO_CTSach_Nhap_Kho
    {
        public string MaCuonSach { get; set; }
        public int? TinhTrang { get; set; }
    }
}
