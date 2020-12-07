using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MIPT.BotApi.Handlers
{
    public abstract class CommandHandler
    {
        protected readonly IServiceScopeFactory Factory;
        protected readonly TelegramBotClient Bot;
        protected readonly string Command;

        protected CommandHandler(IServiceScopeFactory factory, TelegramBotClient bot, string command)
        {
            this.Factory = factory;
            this.Bot = bot;
            this.Command = command;
        }

        protected abstract string Response(Message message);

        public Task Handle(Message message)
        {
            if (message.Text.StartsWith(this.Command, StringComparison.InvariantCultureIgnoreCase))
                return Bot.SendTextMessageAsync(message.Chat.Id, Response(message));
            else
                return Task.CompletedTask;
        }
    }
}