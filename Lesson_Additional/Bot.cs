using System;
using System.Linq;

namespace Lesson_Additional
{
    public class Bot
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Console.WriteLine($"Bot name changed! {name} -> {value}");
                name = value;
            }
        }

        public Bot(string name)
        {
            this.name = name;
        }

        public string ResponseToUser(string userMessage)
        {
            return ReverseMessage(userMessage);
        }

        private string ReverseMessage(string message)
        {
            return new string(message.Reverse().ToArray());
        }
    }
}
