using System.Text;
using System.Runtime.Serialization;
using DoAnCK;
using System;

[Serializable]
public class HoaDonXuat : HoaDon
{
    CuaHang cua_hang;
    public HoaDonXuat()
    {

    }
    public HoaDonXuat(string ma_don_hang, QuanLyNhapXuat ds_hang_hoa, NhanVien nv_lap, CuaHang cua_hang) : base(ma_don_hang, ds_hang_hoa, nv_lap)
    {
        ngay_tao_don = DateTime.Now;
        this.cua_hang = cua_hang;
    }


    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("cua_hang", cua_hang);
    }

    public HoaDonXuat(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        cua_hang = (CuaHang)info.GetValue("cua_hang", typeof(CuaHang));
    }

}