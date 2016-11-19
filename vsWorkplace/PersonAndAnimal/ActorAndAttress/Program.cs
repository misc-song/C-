using System;
using System.
Collections.Generic;

using System.Text;


namespace Section05
{

    /// <summary>

    /// 选择演员的接口规范

    /// </summary>

    interface ISelectPlayer
    {

        /// <summary>

        /// 与其他演员进行条件比较

        /// </summary>

        /// <param name="player">对方演员</param>

        /// <returns>如果选择自己则返回结果大于0，否则选择对方演员</returns>

        Int32 CompareTo(Player player);
    }


    /// <summary>

    /// 演员基类

    /// </summary>

    class Player
    {

        /// <summary>

        /// 演员基类的构造函数

        /// </summary>

        /// <param name="name">演员姓名</param>

        public Player(string name)
        {

            this.Name = name;

        }

        /// <summary>

        /// 演员姓名

        /// </summary>

        public String Name { get; private set; }

    }


    /// <summary>

    /// 男演员类

    /// </summary>

    class Actor : Player, ISelectPlayer
    {

        /// <summary>

        /// 身高

        /// </summary>

        public Int32 Height { get; private set; }


        // it1：创建男演员类的构造函数，同时实现ISelectPlayer接口

        public Actor(string name, Int32 height)
            : base(name)
        {

            this.Height = height;

        }

        public Int32 CompareTo(Player player)
        {
            Actor a = (Actor)player;
            int result =this.Height - a.Height;
            return result;
        }

    }

    /// <summary>

    /// 女演员类

    /// </summary>

    class Actress : Player, ISelectPlayer
    {

        /// <summary>

        /// 体重

        /// </summary>

        public Int32 Weight { get; private set; }


        // it2：创建女演员类的构造函数，同时实现ISelectPlayer接口

        public Actress(string name, Int32 weight)
            : base(name)
        {

            this.Weight = weight;
        }
        public Int32 CompareTo(Player player)
        {

            Actress b = (Actress)player;
            int result = b.Weight - this.Weight ;
            return result;
        }

    }


    class Program
    {

        /// <summary>

        /// 根据对应的条件选择哪位演员

        /// </summary>

        /// <param name="playerA">演员A</param>

        /// <param name="playerB">演员B</param>

        /// <returns>选中的演员</returns>

        static Player WhoIsBetter(ISelectPlayer playerA, ISelectPlayer playerB)
        {
            Player pa = (Player)playerA;
            Player pb = (Player)playerB;
            //if(playerA)
            //return playerA;
            int a = playerA.CompareTo(pb);
            if (a < 0)
            {
                return pb;
            }
            else
            {
                return pa;
            }
        }

        // it3：调用演员的CompareTo方法进行条件比较，返回选择的演员


        static void Main(string[] args)
        {

            // 先设置一个预选名单，圈定几个预选名额

            Actor actorA = new Actor("李*峰", 180);

            Actor actorB = new Actor("王*蓝", 165);

            Actress actressA = new Actress("徐*珊", 110);

            Actress actressB = new Actress("杨*琳", 90);


            // 最终从预选名单中选择一名男主角和一名女主角

            Console.WriteLine("选择{0}作为电影的男主角", WhoIsBetter(actorA, actorB).Name);

            Console.WriteLine("选择{0}作为电影的女主角", WhoIsBetter(actressA, actressB).Name);
        }
    }
}
