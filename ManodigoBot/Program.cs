using System;
using System.Collections.Generic;
using Telegram.Bot;

namespace ManodigoBot
{
    class Program
    {

        private static readonly TelegramBotClient Bot = new TelegramBotClient("483179814:AAHUa_Cb6qr9T8jS77CH9UO28zVijhS5j1Q");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnMessageEdited += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                if (e.Message.Text.ToUpper().Contains("LOL"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Bora um Aramzinho? To querendo feedar");
                    messageList.Add("Me Bota no gold, até o Benito ta gold nessa porra");
                    messageList.Add("Que lol o caralho, vamos jogar Diablo");
                    messageList.Add("Como está a Season Nova?");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("CHROMECAST"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Cara, meu chromecast desconfigurou, como instala essa porra mesmo?");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("AMIGO"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Amizade é importante né, gosto muito de vocês seus lindos");
                    messageList.Add("Ainda bem que eu tenho vocês como amigos #amizadeforever");
                    messageList.Add("Quanto mais o tempo passa, mais eu gosto de vocês!");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("PEDRO") || e.Message.Text.ToUpper().Contains("MELESCO"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Casa nova já está pronta? Vou passar 3 meses ai");
                    messageList.Add("Melesqueira está procurando colega de quarto? Candela que se cuide");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("OLA") || e.Message.Text.ToUpper().Contains("OLÁ") || e.Message.Text.ToUpper().Equals("OI"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Fala galerinha, quanto tempo!");
                    messageList.Add("Fala");
                    messageList.Add("Oi");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("OLHA QUEM APARECEU"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Vocês estão sendo os primeiros a saber, vou me mudar pro Rio! Olha que presentão de Natal");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("DIGO"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Tunt Tunt Tunt");
                    messageList.Add("Ôhhh! O ManoDigo voltou!");
                    messageList.Add("Oi, alguem me chamou?");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("VAL"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Val, saudades de ti, tu não fala mais comigo");
                    messageList.Add("E esse IDH de Jundiai?");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("VITAO") || e.Message.Text.ToUpper().Contains("VITÃO") || e.Message.Text.ToUpper().Contains("VITOR"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Vitão, vc ta puto comigo ainda? Fica assim comigo não cara");

                    SendRandomMessage(messageList, e);
                }

                if (e.Message.Text.ToUpper().Contains("BOBBY"))
                {
                    List<string> messageList = new List<string>();
                    messageList.Add("Bobby, vem jogar um lolzinho comigo, quero ser seu suporte");

                    SendRandomMessage(messageList, e);
                }
            }
        }

        private static void SendRandomMessage(List<string> messageList, Telegram.Bot.Args.MessageEventArgs e)
        {
            Random r = new Random();
            int index = r.Next(messageList.Count);

            Bot.SendTextMessageAsync(e.Message.Chat.Id, messageList[index]);
        }
    }
}
