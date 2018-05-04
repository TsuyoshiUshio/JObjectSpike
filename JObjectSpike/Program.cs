using Newtonsoft.Json.Linq;
using System;

namespace JObjectSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var json = System.IO.File.ReadAllText("sample.json");
            var target = JObject.Parse(json);
            foreach(var element in target)
            {
                Console.WriteLine($"{element.Key}: endpoint: {element.Value.Value<JToken>("endpoint")}");
            }
            Console.ReadLine();
        }
    }
}
