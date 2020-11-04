using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        { 
            using (var context = new MyScriptureJournalContext (
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context.ScriptureJournal.Any())
                {
                    return;
                }

                context.ScriptureJournal.AddRange(
                    new ScriptureJournal
                    {
                        Book = "1 Nephi",
                        ChapterVerse = "3:7",
                        Notes = "The Lord will always provide the way, if we do our part.",
                        CreatedDate = DateTime.Parse("2020-11-01")
                    },
                    new ScriptureJournal
                    {
                        Book = "1 Nephi",
                        ChapterVerse = "11:21-22",
                        Notes = "The tree in the Lehi's dream is the love of the Lord.",
                        CreatedDate = DateTime.Parse("2020-11-01")
                    },
                    new ScriptureJournal
                    {
                        Book = "Alma ",
                        ChapterVerse = "32:21",
                        Notes = "Alma taught us about faith.",
                        CreatedDate = DateTime.Parse("2020-11-02")
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
