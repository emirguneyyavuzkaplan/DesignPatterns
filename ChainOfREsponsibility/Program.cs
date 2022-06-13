using ChainOfResponsibility.Abstract;
using ChainOfResponsibility.Concrete;
using ChainOfResponsibility.Lab2.Concrete;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;

namespace ChainOfREsponsibility
{
    internal class Program
    {
        public static object Mp3Player { get; private set; }

        static void Main(string[] args)
        {
            #region ornek1 
            //zincirin halkalarıni tanimlayalim
            //PlayerHandler mp3Player = new Mp3Handler();
            //PlayerHandler mp4 = new Mp4Player();
            //PlayerHandler avi = new AviHandler();

            ////bu halkalri birbirine baglayalim
            //mp3Player.NextHandler = avi;
            //avi.NextHandler = mp4;
            ////istekleri zincirin ilk halkasina gondereilim
            //mp3Player.Player("video.avi");
            //mp3Player.Player("video.mp3");
            //mp3Player.Player("video.xxx");
            //mp3Player.Player("video.mp4");

            #endregion

            #region  ornek2

            Yonetici yonetici = new Yonetici();
            GenelMudur genelMudur = new GenelMudur();
            CEO ceo = new CEO();
            yonetici.MasrafMErkezi(genelMudur);
            genelMudur.MasrafMErkezi(ceo);

            List<Masraf> masraflar = new List<Masraf>
            {
                new Masraf{Tutar=70},
                new Masraf{Tutar=250},
                new Masraf{Tutar=4999},
                new Masraf{Tutar=50070},
            };
            foreach (Masraf masraf in masraflar)
            {
                yonetici.MasrafYonetimi(masraf);
            }





            #endregion


        }
    }
}
