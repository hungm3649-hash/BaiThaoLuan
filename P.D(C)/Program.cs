using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.D_C_
{
    internal class Program
    {
        static Random rd = new Random();
        static int[] TaoMang(int n)
        {
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
                a[i] = rd.Next(-100, 101);

            return a;
        }
        static void XuatMang(int[] a)
        {
            Console.WriteLine(string.Join(" ", a));
        }
        static void TimMaxMin(int[] a)
        {
            int max = a[0], min = a[0];
            int vtMax = 0, vtMin = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    vtMax = i;
                }

                if (a[i] < min)
                {
                    min = a[i];
                    vtMin = i;
                }
            }

            Console.WriteLine($"Max = {max}, vi tri = {vtMax}");
            Console.WriteLine($"Min = {min}, vi tri = {vtMin}");
        }
        static void DemSo(int[] a)
        {
            int duong = 0, am = 0, khong = 0;

            foreach (int x in a)
            {
                if (x > 0) duong++;
                else if (x < 0) am++;
                else khong++;
            }

            Console.WriteLine("So duong: " + duong);
            Console.WriteLine("So am: " + am);
            Console.WriteLine("So 0: " + khong);
        }
        static void KiemTraX(int[] a, int x)
        {
            if (Array.IndexOf(a, x) >= 0)
                Console.WriteLine("Co x trong mang");
            else
                Console.WriteLine("Khong co x trong mang");
        }
        static void TimDuongAm(int[] a)
        {
            int? duongMin = null;
            int? amMax = null;

            foreach (int x in a)
            {
                if (x > 0 && (duongMin == null || x < duongMin))
                    duongMin = x;

                if (x < 0 && (amMax == null || x > amMax))
                    amMax = x;
            }

            Console.WriteLine("So duong nho nhat: " +
                (duongMin.HasValue ? duongMin.ToString() : "Khong co"));

            Console.WriteLine("So am lon nhat: " +
                (amMax.HasValue ? amMax.ToString() : "Khong co"));
        }
        static void SapXepGiam(int[] a)
        {
            Array.Sort(a);
            Array.Reverse(a);

            Console.WriteLine("Mang giam dan:");
            XuatMang(a);
        }

        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Nhap N (1 <= N < 20): ");
            }
            while (!int.TryParse(Console.ReadLine(), out n)
                   || n < 1 || n >= 20);

            int[] a = TaoMang(n);

            Console.WriteLine("\nMang ngau nhien:");
            XuatMang(a);

            Console.WriteLine("\nA. Tim Max, Min:");
            TimMaxMin(a);

            Console.WriteLine("\nB. Dem so:");
            DemSo(a);

            Console.Write("\nNhap x can tim: ");
            int x;

            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Nhap lai x: ");

            KiemTraX(a, x);

            Console.WriteLine("\nD. Tim so duong nho nhat, so am lon nhat:");
            TimDuongAm(a);

            Console.WriteLine("\nE. Sap xep giam dan:");
            SapXepGiam(a);

            Console.ReadKey();
        }
    }
}