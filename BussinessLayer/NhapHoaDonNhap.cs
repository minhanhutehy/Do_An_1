﻿using Quanlycuahangbangiay.Bussiness.Interface;
using Quanlycuahangbangiay.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quanlycuahangbangiay.Bussiness
{
    class NhapHoaDonNhap:HoaDonNhapBLL
    {
        public ArrayList hoadonnhaps = new ArrayList();
        public void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập hóa đơn nhập                 |");
            Console.WriteLine("|_____________________________________________________|");
            Console.Write("|                   Nhập mã hóa đơn nhập: ");
            string maHDN=Console.ReadLine();
            Console.Write("|                    mã nhân viên: ");
            string maNCC=Console.ReadLine();
            Console.Write("|                    mã nhân viên giao: ");
            string nvGiao=Console.ReadLine();
            Console.Write("|                   Nhập mã nhân viên nhận: ");
            string maNvNhan=Console.ReadLine();
            Console.Write("|                   Nhập ngày nhận: ");
            string ngayNhan=Console.ReadLine();
            Console.Write("|                   Nhập tổng tiền: ");
            double tongTien=double.Parse(Console.ReadLine());
            Console.Write("|                   Nhập trạng thái: ");
            string trangThai=Console.ReadLine();
            Console.Write("|                   Nhập số tiền đã thanh toán: ");
            double daTT=double.Parse(Console.ReadLine());
            double conNo=tongTien-daTT;
            Console.Write("|                   Nhập ghi chú: ");
            string ghiChu=Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            HoaDonNhap hdn = new HoaDonNhap(maHDN,maNCC,nvGiao,maNvNhan,ngayNhan,tongTien,trangThai,daTT,conNo,ghiChu);
            hoadonnhaps.Add(hdn);
            HoaDonNhapDAL.Ghifile(hoadonnhaps);
        }
        public void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}|{7,15}", "Mã HDN","Ma NvGiao","Ma NvNhan","NgayNhan","Tong tien","Trang thai","Thanh toan","Ghi chu");
            foreach(HoaDonNhap hdn in hoadonnhaps)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}|{7,15}", hdn.MaHDN,hdn.NvGiao,hdn.MaNvNhan,hdn.NgayNhan,hdn.TongTien,hdn.TrangThai,hdn.DaTT,hdn.GhiChu);
            }    

        }

    }
}
