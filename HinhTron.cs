using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class HinhTron
    {
        private ToaDo tam;

        public ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        public HinhTron()
        {

        }
        public HinhTron(ToaDo tam,double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        public double ChuVi()
        {
            return 2 * 3.14 * banKinh;
        }
        public double DienTich()
        {
            return 3.14 * banKinh * banKinh;
        }
        public void Xuat()
        {
            Console.WriteLine("Hinh tron co tam {0}({1},{2}) voi ban kinh {3} co dien tich va chu vi lan luot la {4} va {5}",tam.Ten,tam.X,tam.Y,banKinh,DienTich(),ChuVi());
        }
    }
}
