using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
[Serializable]
public class NhaCungCap : ISerializable
{
    public string id_ncc;
    public string ten_ncc;
    public string dia_chi_ncc;

    public NhaCungCap()
    {

    }
    public NhaCungCap(string id_ncc, string ten_ncc, string dia_chi_ncc)
    {
        this.id_ncc = id_ncc;
        this.ten_ncc = ten_ncc;
        this.dia_chi_ncc = dia_chi_ncc;
    }
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id_ncc", id_ncc);
        info.AddValue("ten_ncc", ten_ncc);
        info.AddValue("dia_chi_ncc", dia_chi_ncc);
    }

    public NhaCungCap(SerializationInfo info, StreamingContext context)
    {
        id_ncc = info.GetString("id_ncc");
        ten_ncc = info.GetString("ten_ncc");
        dia_chi_ncc = info.GetString("dia_chi_ncc");
    }
}