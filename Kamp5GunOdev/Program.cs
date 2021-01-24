using System;

namespace Kamp5GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManeger gamerManeger = new GamerManeger();

            Gamers gamer1 = new Gamers();
            gamer1.Id = 1;
            gamer1.Name = "Bekir";
            gamer1.SurNama = "Aynihan";
            gamer1.TcNo = 12345687912;
            gamer1.Birthday = "13.12.1994";
            gamer1.GamerId = 1;
            gamerManeger.Add(gamer1);

            Gamers gamer2 = new Gamers();
            gamer2.Id = 2;
            gamer2.Name = "ALi";
            gamer2.SurNama = "Veli";
            gamer2.TcNo = 24445687912;
            gamer2.Birthday = "17.10.1994";
            gamer2.GamerId = 2;
            gamerManeger.Update(gamer2);

            Gamers gamer3 = new Gamers();
            gamer3.Id = 3;
            gamer3.Name = "Mehmet";
            gamer3.SurNama = "Türk";
            gamer3.TcNo = 12345687912;
            gamer3.Birthday = "13.05.1996";
            gamer3.GamerId = 3;
            gamerManeger.Delete(gamer3);



            Games game1 = new Games();
            game1.Id = 1;
            game1.GameId = 1;
            game1.GameName = "Savaşçı";
            game1.Fiyat = 500;

            ICampaignsManeger campaignsManeger = new SupperCampaing();
            double fiyat=campaignsManeger.GamePrice(game1.Fiyat);

            GameAndGamerManeger GameBuy = new GameAndGamerManeger();
            GameBuy.GameBuying(gamer1.Id, game1.Id, game1.GameName, gamer1.Name, fiyat);



            //form aplicationda bunları böyle yapmam hocam ama consola uydurmaya calısıyorum:D


        }
    }
}
