using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MIPT.BotApi.Handlers
{
    public class StartHandler : CommandHandler
    {
        public StartHandler(IServiceScopeFactory factory, TelegramBotClient bot)
            : base(factory, bot, "/start")
        {
        }

        protected override string Response(Message message)
        {
            return "Available commands:\n" +
                   "/start - start bot\n" +
                   "/groups - list of all groups\n" +
                   "/subjects - list of all subjects\n" +
                   "/tables - list of all schedules.";
        }
    }
}