using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torrent_Pirate
{
    class TorrentPirate
    {
        static void Main(string[] args)
        {
            int mBytesDownload = int.Parse(Console.ReadLine());
            int priceCinema = int.Parse(Console.ReadLine());
            int moneySpendPerHour = int.Parse(Console.ReadLine());
            double downloadTime = (((mBytesDownload / 2.00) / 60.00) / 60.00);
            double priceDownload = downloadTime * moneySpendPerHour;
            double numMovies = mBytesDownload / 1500.00;
            double cinemaCost = numMovies * priceCinema;
            if(cinemaCost < priceDownload)
            {
                Console.WriteLine("cinema -> {0:F2}lv",cinemaCost);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv",priceDownload);
            }

        }
    }
}
