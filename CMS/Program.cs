using System;

namespace CMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  客户管理系统");
            Console.WriteLine("请登录");

            string username;
            string pwd;
            Console.Write("用户名：");
            username = Console.ReadLine();
            if (username == "1234567")
            {
                Console.WriteLine("主菜单");
                Console.WriteLine("项目1");
                Console.WriteLine("项目2");
                Console.WriteLine("项目3");
                Console.WriteLine("项目4");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("客户管理");
                        break;
                    case "2":
                        Console.WriteLine("预约管理");
                        break;
                    case "3":
                        Console.WriteLine("系统设置");
                        break;
                    case "4":
                        Console.WriteLine("推出");
                        break;
                }
            }
            else
            {
                Console.WriteLine("密码错误");
            }
        }
    }
}
