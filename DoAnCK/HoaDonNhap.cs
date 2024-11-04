using DoAnCK;
using System;
using System.Runtime.Serialization;
using System.Text;

[Serializable]
public class HoaDonNhap : HoaDon
{
    NhaCungCap nha_cung_cap;
    public HoaDonNhap()
    {

    }
    public HoaDonNhap(string ma_don_hang, QuanLyNhapXuat ds_hang_hoa, NhanVien nv_lap, NhaCungCap nha_cung_cap) : base(ma_don_hang, ds_hang_hoa, nv_lap)
    {
        this.nha_cung_cap = nha_cung_cap;
        ngay_tao_don = DateTime.Now;
    }
   

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("nha_cung_cap", nha_cung_cap);
    }

    public HoaDonNhap(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        nha_cung_cap = (NhaCungCap)info.GetValue("nha_cung_cap", typeof(NhaCungCap));
    }

}