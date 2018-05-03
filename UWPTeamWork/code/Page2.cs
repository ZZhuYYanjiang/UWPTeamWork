using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using rouge;
namespace test
{
    class Usingxml
    {
        //初始化
        private void creatnew()
        {

            //创建一个XML文档
            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);//写第一行数据
            doc.AppendChild(dec);
            //创建根节点 knights
            XmlElement knights = doc.CreateElement("Knights");
            doc.AppendChild(knights);
            XmlElement knight = doc.CreateElement("Knight");
            knights.AppendChild(knight);

            //根节点下创建子节点 knightname knighthp...
            XmlElement knightname1 = doc.CreateElement("Knightname");
            knightname1.InnerText = "Saber";
            knight.AppendChild(knightname1);

            XmlElement knighthp1 = doc.CreateElement("KnightHp");
            knighthp1.InnerText = "1";
            knight.AppendChild(knighthp1);

            XmlElement knightatk1 = doc.CreateElement("KnightAtk");
            knightatk1.InnerText = "1";
            knight.AppendChild(knightatk1);

            XmlElement knightspeed1 = doc.CreateElement("Knightspeed");
            knightspeed1.InnerText = "1";
            knight.AppendChild(knightspeed1);
            doc.Save("Knights.xml");

            XmlElement knightskill1 = doc.CreateElement("Knightskill");
            knightskill1.InnerText = "1";
            knight.AppendChild(knightskill1);
            //节点创建完毕
            doc.Save("Knights.xml");
        }
        //新增人物
        private void append()
        {
            XmlDocument dad = new XmlDocument();
            if (File.Exists("Knights.xml"))
            {
                Console.WriteLine("打开成功");
                dad.Load("Knights.xml");
            }
            else
            {
                XmlDeclaration dec = dad.CreateXmlDeclaration("1", "ufb - 8", null);
                dad.AppendChild(dec);
            }

            //创建根节点 knight
            XmlElement knights = dad.DocumentElement;
            Console.WriteLine("姓名:");
            string Knight = Console.ReadLine();
            XmlElement knight2 = dad.CreateElement(Knight);
            knights.AppendChild(knight2);
            //根节点下创建子节点 knightname
            Console.WriteLine("一个酷炫的称呼：");
            XmlElement knightname2 = dad.CreateElement("Knightname");
            knightname2.InnerText = Console.ReadLine() + Knight;
            knight2.AppendChild(knightname2);

            Console.WriteLine("Hp:");

            XmlElement knighthp1 = dad.CreateElement("KnightHp");
            knighthp1.InnerText = Console.ReadLine();
            knight2.AppendChild(knighthp1);

            Console.WriteLine("Atk:");

            XmlElement knightatk1 = dad.CreateElement("KnightAtk");
            knightatk1.InnerText = Console.ReadLine();
            knight2.AppendChild(knightatk1);
            dad.Save("Knights.xml");
        }
        //删除人物
        private void remove()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Knights.xml");
            Console.WriteLine("删除这个家伙。");
            string Knight = Console.ReadLine();
            XmlNode docnode = doc.SelectSingleNode("/Knights/" + Knight);
            docnode.ParentNode.RemoveChild(docnode);
            doc.Save("Knights.xml");
        }
        //读取当前文档中的所有人物信息
        private void read()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Knights.xml");
            XmlElement knights = doc.DocumentElement;
            XmlNodeList doclist = knights.ChildNodes;
            foreach (XmlNode docnode in doclist)
            {


                Console.WriteLine(docnode.InnerText);
                XmlNodeList knightself = docnode.ChildNodes;
                
                foreach (XmlNode attribute in knightself)
                {
                    Console.WriteLine(attribute.Name + ":" + attribute.InnerText);
                   
                }
            }
            Console.ReadLine();
        }
        //将人物信息加载到Knight类，创建一个对象
        public Knight get(Knight knight)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("Knights.xml");
            Console.WriteLine("选择一个家伙。");
            string Knight = Console.ReadLine();
            XmlNode docnode = doc.SelectSingleNode("/Knights/" + Knight);
            XmlNodeList knightself = docnode.ChildNodes;
            knight.Name = knightself[0].InnerText;
            knight.Hp = int.Parse(knightself[1].InnerText);
            knight.Atk = int.Parse(knightself[2].InnerText);
            Console.WriteLine(knight.Name+":"+knight.Atk+"/"+knight.Hp);

            return knight;
            doc.Save("Knights.xml");

            }
            
        //界面
        public void set(Knight knight)
        {
            Console.WriteLine("嗨，这里是你的小伙伴们，要去看看吗？");
            var choice = Console.ReadLine();
            while
                (choice == "yes")
            {
                {
                    Console.WriteLine("嗯，就是这些家伙了，你打算干什么？");
                    var operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "creatnew":
                            Console.WriteLine("现在我要挑一个幸运的小孩。");
                            creatnew();
                            break;
                        case "append":
                            Console.WriteLine("现在我要造一个强大的小孩！");
                            append();
                            break;
                        case "remove":
                            Console.WriteLine("现在我要杀掉一个无辜的小孩~~");
                            remove();
                            break;
                        case "read":
                            Console.WriteLine("这是这个月的名单。");
                            read();
                            break;
                        case "get":
                            Console.WriteLine("你过来，过来让我康康！！");
                            get(knight);
                            break;
                    }
                    

                }
                Console.WriteLine("你你还想对他们做什么吗？");
                choice = Console.ReadLine();
            } 

        }
    }
}
