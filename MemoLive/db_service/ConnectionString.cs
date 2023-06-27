using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MemoLive;
using System.Windows;

namespace MemoLive.db_service
{
    static class ConnectionString
    {
        public static string? cString;
        static ConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("config.json");
            var config = builder.Build();

            cString =   "Host = "         +   config["dbHost"]        + 
                      "; Database = "   +   config["dbName"]        +
                      "; Password = "   +   config["uPassword"]     +
                      "; Username = "   +   config["dbUser"]         +
                      "; Port = "       +   config["dbPort"];

            MessageBox.Show(cString);
        }
    }
}
