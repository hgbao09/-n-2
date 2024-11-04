using DoAnCK;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class KhoHang
{
    string ten_kho;
    public List<HangHoa> ds_hang_hoa = new List<HangHoa>();
    public List<NhanVien> ds_nhan_vien = new List<NhanVien>();
    public List<CuaHang> ds_cua_hang = new List<CuaHang>();
    public List<NhaCungCap> ds_ncc = new List<NhaCungCap>();
    public List<HoaDonNhap> ds_hoa_don_nhap = new List<HoaDonNhap>();
    public List<HoaDonXuat> ds_hoa_don_xuat = new List<HoaDonXuat>();

    public bool kha_dung(List<HangHoa> ds_hh)
    {
        foreach (HangHoa hh in ds_hh)
        {
            HangHoa hh_kho = ds_hang_hoa.Find(x => x.id == hh.id);
            if (hh.so_luong > hh_kho.so_luong)
            {
                return false;
            }
        }
        return true;
    }

    public void capnhatkho(List<HangHoa> ds_hh, bool isnhap)
    {
        if (isnhap)
        {
            foreach (HangHoa hanghoa in ds_hh)
            {
                HangHoa hh_kho = ds_hang_hoa.Find(x => x.id == hanghoa.id);
                hh_kho.so_luong += hanghoa.so_luong;
            }
        }
        else
        {
            foreach (HangHoa hanghoa in ds_hh)
            {
                HangHoa hh_kho = ds_hang_hoa.Find(x => x.id == hanghoa.id);
                hh_kho.so_luong -= hanghoa.so_luong;
            }
        }

        LuuDanhSachHH();
    }


    public NhanVien dang_nhap(string username, string password)
    {
        NhanVien nv = new NhanVien();
        nv = ds_nhan_vien.Find(user => user.username == username && user.password == password);
        return nv;
    }

    public void LuuDanhSachCH()
    {
        string filePath = "Resources/cua_hang.dat";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CuaHang>));
            serializer.Serialize(writer, ds_cua_hang);
        }
    }

    public void LuuDanhSachHH()
    {
        string filePath = "Resources/hang_hoa.dat";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
            serializer.Serialize(writer, ds_hang_hoa);
        }
    }

    public void LuuDanhSachNCC()
    {
        string filePath = "Resources/nha_cung_cap.dat";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<NhaCungCap>));
            serializer.Serialize(writer, ds_ncc);
        }
    }
    public void LuuDanhSachHDX()
    {
        string filePath = "Resources/hoa_don_xuat.dat";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HoaDonXuat>));
            serializer.Serialize(writer, ds_hoa_don_xuat);
        }
    }
    public void LuuDanhSachHDN()
    {
        string filePath = "Resources/hoa_don_nhap.dat";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HoaDonNhap>));
            serializer.Serialize(writer, ds_hoa_don_nhap);
        }
    }

    public void ThemHoaDonNhap(HoaDonNhap hoaDon)
    {
        ds_hoa_don_nhap.Add(hoaDon);
        LuuDanhSachHDN();
    }

    public void ThemHoaDonXuat(HoaDonXuat hoaDon)
    {
        ds_hoa_don_xuat.Add(hoaDon);
        LuuDanhSachHDX();
    }
    public void LoadData()
    {
        string filePath_hh = "Resources/hang_hoa.dat";
        using (StreamReader reader = new StreamReader(filePath_hh))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
            ds_hang_hoa = (List<HangHoa>)serializer.Deserialize(reader);
        }

        string filePath_ncc = "Resources/nha_cung_cap.dat";
        using (StreamReader reader = new StreamReader(filePath_ncc))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<NhaCungCap>));
            ds_ncc = (List<NhaCungCap>)serializer.Deserialize(reader);
        }

        string filePath_ch = "Resources/cua_hang.dat";
        using (StreamReader reader = new StreamReader(filePath_ch))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CuaHang>));
            ds_cua_hang = (List<CuaHang>)serializer.Deserialize(reader);
        }

        string filePath_hdn = "Resources/hoa_don_nhap.dat";
        using (StreamReader reader = new StreamReader(filePath_hdn))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HoaDonNhap>));
            ds_hoa_don_nhap = (List<HoaDonNhap>)serializer.Deserialize(reader);
        }

        string filePath_hdx = "Resources/hoa_don_xuat.dat";
        using (StreamReader reader = new StreamReader(filePath_hdx))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HoaDonXuat>));
            ds_hoa_don_xuat = (List<HoaDonXuat>)serializer.Deserialize(reader);
        }

        string filePath_nv = "Resources/nhan_vien.dat";
        using (StreamReader reader = new StreamReader(filePath_nv))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<NhanVien>));
            ds_nhan_vien = (List<NhanVien>)serializer.Deserialize(reader);
        }
    }

    public void them_hh(HangHoa hh)
    {
        hh.so_luong = 0;
        ds_hang_hoa.Add(hh);
        string filePath = "./Resources/hang_hoa.dat";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
            serializer.Serialize(writer, ds_hang_hoa);
        }
    }
}