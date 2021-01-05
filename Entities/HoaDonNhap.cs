﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlycuahangbangiay.DataAccess
{
    class HoaDonNhap
    {
        string maHDN;
        string maNCC;
        string nvGiao;
        string maNvNhan;
        string ngayNhan;
        double tongTien;
        string trangThai;
        double daTT;
        double conNo;
        string ghiChu;
        public HoaDonNhap(string maHDN, string maNCC, string nvGiao, string maNvNhan,string ngayNhan,double tongTien, string trangThai, double daTT, double conNo,string ghiChu)
        {
            MaHDN = maHDN;
            MaNCC = maNCC;
            NvGiao = nvGiao;
            MaNvNhan = maNvNhan;
            NgayNhan = ngayNhan;
            TongTien = tongTien;
            TrangThai = trangThai;
            DaTT = daTT;
            ConNo = conNo;
            GhiChu = ghiChu;
        }

        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string NvGiao { get => nvGiao; set => nvGiao = value; }
        public string MaNvNhan { get => maNvNhan; set => maNvNhan = value; }
        public string NgayNhan { get => ngayNhan; set => ngayNhan = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public double DaTT { get => daTT; set => daTT = value; }
        public double ConNo { get => conNo; set => conNo = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        override
            public string ToString()
        {
            return MaHDN + ";" + MaNCC + ";" + NvGiao + ";" + MaNvNhan + ";" + NgayNhan + ";" + TongTien + ";" + TrangThai + ";" + DaTT + ";" + ConNo + ";" + GhiChu;
        }
       
    }
}
