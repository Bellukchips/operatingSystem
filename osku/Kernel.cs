using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace osku
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Lukman Os");
            Console.WriteLine("-name\t -nim\t -tgllhr");
            Console.WriteLine("-alamat\t -noHp\t -tanggal");
            Console.WriteLine("-cita-cita\t -jam\t -shutdown");
            Console.WriteLine("-hobby");

        }

        protected override void Run()
        {
            string name = "Muh Lukman AKbar P";
            string nim = "A11.2019.11985";
            string tgllhr = "Tegal, 12 Oktober 2001";
            string alamat = "Kabupaten Tegal";
            string citaCita = "Mobile Developer";
            string noHp = "+628227918234";
            string hobby = "Bermain Game Online";
            string subMenu =
                "-nama       -nim     -tgllhr\n" +
                "-alamat     -noHp    -tanggal\n" +
                "-cita-cita  -jam     -shutdown\n" +
                "-hobby";

            DateTime time = DateTime.Now;
            DateTime date = DateTime.Today;

            while (true)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "name":
                        {
                            Console.WriteLine("Nama : " + name);
                            break;
                        }
                    case "nim":
                        {
                            Console.WriteLine("NIM : " + nim);
                            break;
                        }
                    case "tgllhr":
                        {
                            Console.WriteLine("Tanggal Lahir : " + tgllhr);
                            break;
                        }
                    case "alamat":
                        {
                            Console.WriteLine("Alamat : " + alamat);
                            break;
                        }
                    case "noHp":
                        {
                            Console.WriteLine("Nomor Hp : " + noHp);
                            break;
                        }
                    case "cita-cita":
                        {
                            Console.WriteLine("Cita-Cita : " + citaCita);
                            break;
                        }
                    case "tanggal":
                        {
                            Console.WriteLine("Tanggal : " + date);
                            break;
                        }
                    case "jam":
                        {
                            Console.WriteLine("Jam : " + time);
                            break;
                        }
                    case "shutdown":
                        {
                            Cosmos.System.Power.Shutdown();
                            break;
                        }
                    case "hobby":
                        {
                            Console.WriteLine("Lagu Favorite : " + hobby);
                            break;
                        }
                }
            }

        }
    }
}

