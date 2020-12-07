using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MIPT.Dal;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MIPT.BotApi.Handlers
{
    public class TablesHandler : CommandHandler
    {
        public TablesHandler(IServiceScopeFactory factory, TelegramBotClient bot)
            : base(factory, bot, "/tables")
        {
        }

        protected override string Response(Message message)
        {
            var response = new StringBuilder();
            response.AppendLine("Group, Subject, Start, Finish");
            
            using (var scope = base.Factory.CreateScope())
            using (var context = scope.ServiceProvider.GetService<TimeTableDb>())
            {
                var query = context.TimeTable
                    .Include(table => table.GroupRef)
                    .Include(table => table.SubjectRef)
                    .ToArray();
                
                foreach (var timeTable in query)
                {
                    response.AppendFormat("{0} {1} {2} {3}",
                        timeTable.GroupRef.Name,
                        timeTable.SubjectRef.Title,
                        timeTable.StartAt,
                        timeTable.FinishAt);
                }
            }

            return response.ToString();
        }
    }
}