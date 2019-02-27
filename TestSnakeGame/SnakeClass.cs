using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSnakeGame
{
    class SnakeClass
    {
        class Snake
        {
            public List<Point> SnakeBody = new List<Point>();//蛇的身体
            Forward Fangxiang;
            public enum Forward
            {
                Up=1,
                Down=2,
                Left=3,
                Right=4
            }

            public Snake()
            {
                SnakeBody.Add(new Point(5,3));
                SnakeBody.Add(new Point(5,4));
                SnakeBody.Add(new Point(5,5));
                Fangxiang = Forward.Down;
            }

            public Forward GetFangxiang()
            {
                return Fangxiang;
            }

            //自动前进
            public void AutoMove()
            {

            }

        }

        //zuobiao 
        class Point
        {
            public Point(int x,int y)
            {
                X = x;
                Y = y;
            }
            public int X{ get; set; }
            public int Y{ get; set; }
        }

        public SnakeClass()
        {
            Init();
        }

       int MaxX=10,MaxY=10;
        bool IsEndGame = false;
        
        //Map
        int[,] Map = new int[10,10];
        //初始化
        void Init()
        {
            
        }

        //开始游戏主逻辑
        public void StartRun()
        {
            while (!IsEndGame)
            {

            }
        }

        //生成新的球
        void CreatNewBall()
        {
            poing
        }
    }
}
