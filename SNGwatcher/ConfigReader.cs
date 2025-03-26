using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public class ConfigReader
    {

        private readonly string _path;

        public ConfigReader(string path)
            => _path = path;

        public Config Read()
        {
            string json = File.ReadAllText(_path);
            return JsonSerializer.Deserialize<Config>(json);
        }

    }
}
