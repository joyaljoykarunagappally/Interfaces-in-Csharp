using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface  IChatSystem              //Base class1
    {
        void SendMessage();
        void ReceiveMessage();
    }
    interface IVoiceChat                //Base Class2
    {
        void SendVoiceMessage();
        void ReceiveVoiceMessage();
    }
    class Whatsaap : IChatSystem            //Derived class1
    {
        public void SendMessage()
        {
            Console.WriteLine("Message send via WhatsApp!");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Message receive via WhatsApp!");
        }
    }
    class Telegram : IChatSystem, IVoiceChat        //Multiple inheritence done using Interface
    {
        public void SendMessage()
        {
            Console.WriteLine("Message send via Telegram!");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Message receive via Telegram!");
        }
        public void SendVoiceMessage()
        {
            Console.WriteLine("Voice Message send via Telegram!");
        }
        public void ReceiveVoiceMessage()
        {
            Console.WriteLine("Voice Message receive via Telegram!");
        }
    }
}
