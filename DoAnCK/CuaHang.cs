using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

[Serializable]
public class CuaHang : ISerializable
{
    public string id_ch;
    public string ten_ch;
    public string dia_chi_ch;

    public CuaHang()
    {

    }
    public CuaHang(string id_ch, string ten_ch, string dia_chi_ch)
    {
        this.id_ch = id_ch;
        this.ten_ch = ten_ch;
        this.dia_chi_ch = dia_chi_ch;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id_ch", id_ch);
        info.AddValue("ten_ch", ten_ch);
        info.AddValue("dia_chi_ch", dia_chi_ch);
    }

    public CuaHang(SerializationInfo info, StreamingContext context)
    {
        id_ch = info.GetString("id_ch");
        ten_ch = info.GetString("ten_ch");
        dia_chi_ch = info.GetString("dia_chi_ch");
    }
}