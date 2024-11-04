using DoAnCK;
using System;
using System.Runtime.Serialization;
using System.Drawing;

[Serializable]
public class DienTu : HangHoa
{
    public DienTu()
    {

    }

    public DienTu(string id, string ten_hang, uint so_luong, ulong don_gia, string img) : base(id, ten_hang, so_luong, don_gia, img)
    {

    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    public DienTu(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}