using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace rouge
{
    //没写好，不用看
    class Map
    {
        private int Long = 0;//道路总长
        private int n = 0;//道路数量
        private int m = 0;

        private int[,] Road = new int[2, 10];//路劲长度，终点情况分支路数量<=10
        private int MonsterNum;//怪物总数
        public void Create()//随机生成所有private型的值
  
        {

            Random ro = new Random();
            this.n = ro.Next(1, 10);//分支路数量
            for (m = 0; m <  n; m++)//统计道路总长
            {
                this.Road[0, m] = ro.Next(1, 10);
                this.Long += this.Road[0, m];

            }
            this.MonsterNum = this.Long / 3;//怪物总数
            for (m = 0; m < n;m += 2)
            {
                this.Road[1, m] = ro.Next(0, 2);
                int a = m+1;
                this.Road[1, a] =3 - this.Road[1, m];
                
            }
            Console.WriteLine("道路数量："+n);
            Console.WriteLine("道路总长：" + Long);
            Console.WriteLine("道路终点标号：" + this.Road[1,--n]);
            Console.WriteLine("怪物数量：" + this.MonsterNum);

        }

        public void Trap(Knight knight)
        {
            
            int  fight = 0;
            m = -1;
            Console.WriteLine("面前出现了两条道路，现在你要踏上哪条呢？");
            Console.WriteLine("1.左边这条      2.右边这条 ");
            int n1= int.Parse(Console.ReadLine());

            do
            {
                for (m += n1; this.Road[0, m] >= 1;)//选择的道路
                {
                    //这里你们写段程序，每走一步this.Road[0, m]-1，代替下面这句

                    if (this.Road[0, m] > 0)
                    {
                        this.Road[0, m]--;
                        Random random = new Random();
                        fight = random.Next(0, 2);
                        if (fight == 1 && knight.Hp > 0 && this.MonsterNum > 0)
                        {
                            Monster mon = new Monster();
                            mon.set();
                            do
                            {
                                knight = Knight.Fightwith(knight, mon);

                            } while (mon.Hp > 0 && knight.Hp > 0);
                            Console.WriteLine("打倒了一只怪物。");
                            this.MonsterNum--;
                        }

                        else if (fight == 2 || knight.Hp <= 0 || this.MonsterNum < 0)
                        {
                            Console.WriteLine("角色死亡,探险失败！");
                        }
                    }
                    if (this.Road[0, m] == 0)
                    {
                        fight = 2;
                        Console.WriteLine("这条路已经走到了尽头，现在在你面前的是:");
                        switch (this.Road[1, m])
                        {
                            case 0:
                                Console.WriteLine("面前出现了两条道路，现在你要踏上哪条呢？");
                                Console.WriteLine("1.左边这条      2.右边这条 ");
                                n1= int.Parse(Console.ReadLine());
                                break;
                            case 1:
                                Console.WriteLine("这里什么也没有，你只好原路返回，探索新的道路");
                                m -= n1;
                                break;

                        }
                    }

                }

            } while (m != n);


        }
    }
    class Knight
    {
        public static Knight player = new Knight();
        public string Name = "NewPlayer";
        public int t = 10;
        public int hp = 1;
        public int atk = 1;
        public int Hp = 1;
        public int Atk = 1;
        public int Speed = 1;
        public int Skill = 1;
        
        public static Knight Fightwith(Knight knight, Monster monster)
        {
            monster.Hp = monster.Hp - knight.Atk;
            knight.Hp = knight.Hp - monster.Atk;
            return knight;
        }
    }
    class Monster
    {
        public static Monster monster = new Monster();
        public int Hp = 1;
        public int Atk = 1;
        
        public void set()
        {
            Random random = new Random();
            this.Hp = random.Next(Knight.player.hp/2,Knight.player.hp);
            this.Atk = random.Next(Knight.player.atk/2, Knight.player.atk);

        }
    }
    
}


