using System;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Prufer
{
    class Program
    {
    	public class Config
    	{
    		public string Token { get; set; }
    	}

    	public Config config { get; set; }

        public static void Main(string[] args)
        	=> new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
        	string str_config = File.ReadAllText("config.json");
        	config = JsonSerializer.Deserialize<Config>(str_config);


        }

        private Task Log(LogMessage msg)
        {
        	Console.WriteLine(msg.ToString());
        	return Task.CompletedTask;
        }
    }
}
