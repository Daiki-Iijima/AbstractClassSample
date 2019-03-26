using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Interface_abstract_sample
{
    class Program
    {
        static void Main(string[] args)
        {

            BigBird bigBird = new BigBird();
            LittleBird littleBird = new LittleBird();

            //普通の呼び方
            Console.Write(bigBird.Fly());
            Console.Write(littleBird.Fly());

            Console.Write("==================\n");

            //連続処理もできる
            Bird[] birds = new Bird[] { bigBird, littleBird };

            foreach (var bird in birds)
            {
                Console.Write(bird.Walk());
            }
            //すぐにウィンドウが閉じないように
            Console.ReadLine();

        }
    }

    /// <summary>
    /// 鳥のアクションを定義したインターフェス
    /// </summary>
    interface IBirdAction
    {
        string Fly();//飛ぶ
        string Walk();//歩く
        string Sleep();//寝る
    }

    /// <summary>
    /// 鳥のアクションの処理と名前の取得を強制させる抽象クラス
    /// </summary>
    abstract class Bird : IBirdAction
    {
        //IBirdActionにを継承することによって
        //Fly(),Walk(),Sleep()の3つの処理の実装はしなければならない
        public string Fly()
        {
            string getSt = GetName();

            return getSt + "は飛ぶ\n";
        }

        public string Sleep()
        {
            string getSt = GetName();

            return getSt + "は寝る\n";
        }

        public string Walk()
        {
            string getSt = GetName();

            return getSt + "は歩く\n";
        }


        //このクラスBirdを継承したクラスはGetNameを継承する必要がある
        protected abstract string GetName();
    }

    /// <summary>
    /// 大きい鳥クラス
    /// </summary>
    class BigBird : Bird
    {
        //Birdを継承したのでGetName()の処理の実装を強制させることができる
        protected override string GetName()
        {
            return "私、大きい鳥";
        }
    }

    /// <summary>
    /// 小さい鳥クラス
    /// </summary>
    class LittleBird : Bird
    {
        //Birdを継承したのでGetName()の処理の実装を強制させることができる
        protected override string GetName()
        {
            return "私、小さい鳥";
        }
    }
}

