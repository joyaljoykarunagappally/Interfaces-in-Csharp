using Interfaces;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Whatsaap w = new Whatsaap();
            Telegram t = new Telegram();
            w.SendMessage();
            w.ReceiveMessage();
            t.SendMessage();
            t.ReceiveMessage();
            t.SendVoiceMessage();
            t.ReceiveVoiceMessage();
        }
    }
}