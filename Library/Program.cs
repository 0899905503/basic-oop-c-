using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Library
{
    class Sach : TheLoai
    {
        private string namXB;
        private string tenSach;
        private string tacGia;
        private string maSach { get; set; }
        public Sach()
        {

        }
        public Sach(string namXB, string tenSach, string tacGia, string maSach )
        {
            this.namXB = namXB;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.maSach = maSach;
        }
        public void OutPutS()
        {
            Console.WriteLine("-  Ten Sach : " + tenSach + "  /Nam Xuat Ban : " + namXB + "  /Tac Gia : " + tacGia + " /Ma Sach : " + maSach);
        }
        public List<Sach> danhsachSach = new List<Sach>();
    }
    class TheLoai 
    {
        private string maTL { get; set; }
        private string tenTL;
        public TheLoai()
        {

        }
        public TheLoai(string maTL, string tenTL)
        {
            this.maTL = maTL;
            this.tenTL = tenTL;
        }
        public void OutPutTL()
        {
            Console.WriteLine("-  Ma the loai : " + maTL + "   /Ten the loai : " + tenTL);
        }
        public  List<TheLoai> danhsachTL = new List<TheLoai>();
        public string GetTL()
        {
            return maTL;
        }
    }
    class NhaXB
    {
        private string maNXB;
        private string tenNXB;
        private string diaChi;
        public NhaXB()
        {

        }
        public NhaXB(string maNXB, string tenNXB, string diaChi)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
            this.diaChi = diaChi;
        }
        public List<NhaXB> danhsachNXB = new List<NhaXB>();
        public string GetmaNXB()
        {
            return maNXB;
        }
    }
    class Quyen : Sach
    {
        private string maVach;
        private float giaTien;
        private int lanTaiBan;
        private string ngayThang;
        public Quyen()
        {

        }
        public Quyen(string maVach, float giaTien, int lanTaiBan, string ngayThang)
        {
            this.maVach = maVach;
            this.giaTien = giaTien;
            this.lanTaiBan = lanTaiBan;
            this.ngayThang = ngayThang;
        }
        //static void InPutQuyen(List <Quyen> listquyen)
        //{
        //    int n;
        //    Console.WriteLine("Nhap so quyen sach cua thu vien : ");
        //    n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < n; i++)
        //    {
        //       Quyen a = new Quyen();
        //        listquyen.Add(a);
        //    }
        //}
        //static void OutPutQuyen(List<Quyen> listquyen)
        //{
        //    for(int i=0;i < listquyen.Count; i++)
        //    {
        //        Console.WriteLine(listquyen[i]);
        //    }
        //}
        public void HoaDon()
        {
            Console.WriteLine("-  Ngay muon sach : " + ngayThang);
            Console.WriteLine("-  ma vach : " + maVach);
            Console.WriteLine("-  Lan tai ban : " + lanTaiBan);
            Console.WriteLine("-  Gia tien : " + giaTien);
        }
        public List<Quyen> danhsachQuyen = new List<Quyen>();
        public string GetQuyen()
        {
            return maVach;
        }
    }
    class DocGia : PhieuMuonTra
    {
        private string tenDocGia;
        private string maDocGia;
        public DocGia()
        {

        }
        public DocGia(string tenDocGia, string maDocGia)
        {
            this.tenDocGia = tenDocGia;
            this.maDocGia = maDocGia;
        }
        public void OutPutD()
        {
            Console.WriteLine("-  Ten doc gia : " + tenDocGia + "/  Ma doc gia : " + maDocGia);
        }
        public List<DocGia> danhsachDocGia = new List<DocGia>();
    }
    class PhieuMuonTra : Quyen
    {
        private string maPhieu;
        private int ngayMuon;
        private int ngayTra;
        public PhieuMuonTra()
        {

        }
        public PhieuMuonTra(string maPhieu, int ngayMuon, int ngayTra)
        {
            this.maPhieu = maPhieu;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
            Console.WriteLine("-  Phieu muon tra chi co hieu luc trong thang ");
        }
        public void ThoiGian()
        {
            if (ngayTra - ngayMuon <= 7)
            {
                Console.WriteLine("-  Tra sach dung hen !");
            }
            else
            {
                Console.WriteLine("-  Vui long tra sach dung hen");
            }
        }
        public  List<PhieuMuonTra> danhsachPhieuMuon = new List<PhieuMuonTra>();
    }
    class Test
    {
        static void Main()
        {
            //DocGia d = new DocGia("Bao", "123");
            //d.OutPutD();
            //List <DocGia> docGias = new List<DocGia>();
            //docGias.Add(d);
            ////foreach (DocGia d2 in docGias)
            ////{
            ////   Console.WriteLine(d.OutPutD);
            ////}
            //Sach s = new Sach("2003", "Lieu Trai Chi Di", "Bo Tung Linh", "456");
            //s.OutPutS();
            //List<Sach> danhsachSach = new List<Sach>();
            //danhsachSach.Add(s);
            ////foreach (Sach d3 in danhsachSach)
            ////{
            ////   Console.WriteLine(d3.OutPutS);
            ////}
            //TheLoai s1 = new TheLoai("115", "Tieu Thuyet");
            //s1.GetTL();
            //s1.OutPutTL();
            //Quyen s2 = new Quyen("11359", 18000, 2, "15/9/2003");
            //s2.HoaDon();
            //PhieuMuonTra t = new PhieuMuonTra("111", 16, 10);
            //t.ThoiGian();
            //Quyen a = new Quyen();
            //static void InPutQuyen(List<Quyen> listquyen)
            //{
            //    int n;
            //    Console.WriteLine("Nhap so quyen sach cua thu vien : ");
            //    n = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < n; i++)
            //    {
            //        Quyen a = new Quyen();
            //        listquyen.Add(a);
            //    }
            //}
            //static void OutPutQuyen(List<Quyen> listquyen)
            //{
            //    for (int i = 0; i < listquyen.Count; i++)
            //    {
            //        Console.WriteLine(listquyen[i]);
            //    }
            //}
            //Console.ReadKey();
        }
    }
}