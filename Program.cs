using System;
using System.Data;

internal class Program
{
    static string CmdReader(string instruction)
    {
        Console.WriteLine(instruction);
        string cmd = Console.ReadLine();
        return cmd;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("============================客户管理系统=================================");
        Console.WriteLine("请登录");
        bool isExit = false;


        do
        {
            string uername;
            string password;
            uername = CmdReader("用户名");
            if (uername != "alex")
            { 
                Console.WriteLine("用户名错误");
                continue;
            }

            password = CmdReader("密码");
            if (password != "123456")
            { 
                Console.WriteLine("密码错误,退出登录");
                continue;
            }
            while (!isExit)
                    {
                        string selection = CmdReader("1.主菜单 \n2.客户管理 \n3.预约管理 \n4. 退出 ");
                        switch (selection)
                        {
                            case "1":
                                Console.WriteLine("主菜单");
                                break;
                            case "2":
                                Console.WriteLine("客户管理");
                                break;
                            case "3":
                                Console.WriteLine("预约管理");
                                break;
                            case "4":
                            default:
                                Console.WriteLine("退出");
                                isExit = true;
                                break;
                        }
                    }
        } while (!isExit);
        Console.Read();

        /* 代码优化二
        do
        {
            string uername;
            string password;
            Console.Write("用户名");
            uername = Console.ReadLine();
            if (uername == "alex")
            {
                Console.WriteLine("密码");
                password = Console.ReadLine();
                if (password == "123456")
                {
                    while (!isExit)
                    {
                        Console.WriteLine("1. 主菜单");
                        Console.WriteLine("2. 客户管理");
                        Console.WriteLine("3. 预约管理");
                        Console.WriteLine("4. 退出");

                        Console.WriteLine("请选择");

                        string selection = Console.ReadLine();
                        switch (selection)
                        {
                            case "1":
                                Console.WriteLine("主菜单");
                                break;
                            case "2":
                                Console.WriteLine("客户管理");
                                break;
                            case "3":
                                Console.WriteLine("预约管理");
                                break;
                            case "4":
                            default:
                                Console.WriteLine("退出");
                                isExit= true;
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("密码错误,退出登录");
                }
            }
            else
            {
                Console.WriteLine("用户名错误");
            }

        } while (!isExit);
        Console.Read();
        */


        /* 代码改进一
         string username;
         string password;

         //循环输入直至输入正确的用户名和密码
         Console.Write("用户名");
         username = Console.ReadLine();


         while (username != "alex")
         {
             Console.WriteLine("用户名错误，请重新输入");
             Console.WriteLine("用户名");
             username = Console.ReadLine();

         }
         Console.Write("密码");
         password = Console.ReadLine();
         while (username == "alex" && password != "123456")
         {
             Console.WriteLine("密码错误请重新输入");
             Console.WriteLine("密码");
             password = Console.ReadLine();
         }
         if (username == "alex" && password == "123456")
         {
             Console.WriteLine("主菜单");
             Console.WriteLine("客户管理");
             Console.WriteLine("预约管理");

             Console.ReadLine();

             string selection = Console.ReadLine();
             switch (selection)
             {
                 case "1":
                     Console.WriteLine("客户管理");
                     break;
                 case "2":
                     Console.WriteLine("预约管理");
                     break;
                 default:
                     Console.WriteLine("退出");
                     break;
             }
         } */
    }
}