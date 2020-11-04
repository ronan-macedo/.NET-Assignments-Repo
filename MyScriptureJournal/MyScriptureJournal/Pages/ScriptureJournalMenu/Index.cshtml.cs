using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.ScriptureJournalMenu
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<ScriptureJournal> ScriptureJournal { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchNotes { get; set; }
        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }
        public SelectList CreatedDate { get; set; }
        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime ScriptureCreatedDate { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from m in _context.ScriptureJournal
                                           orderby m.Book
                                           select m.Book;

            IQueryable<DateTime> dateQuery = from m in _context.ScriptureJournal
                                           orderby m.CreatedDate
                                           select m.CreatedDate;

            var scriptureJournals = from m in _context.ScriptureJournal
                                    select m;

            if (!string.IsNullOrEmpty(SearchNotes))
            {
                scriptureJournals = scriptureJournals.Where(n => n.Notes.Contains(SearchNotes));
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptureJournals = scriptureJournals.Where(b => b.Book == ScriptureBook);
            }

            if (ScriptureCreatedDate == null)
            {
                scriptureJournals = scriptureJournals.Where(d => DateTime.Parse(d.CreatedDate.ToString("d")) == DateTime.Parse(ScriptureCreatedDate.ToString("d")));
            }

            CreatedDate = new SelectList(await dateQuery.Distinct().ToListAsync());
            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
            ScriptureJournal = await scriptureJournals.ToListAsync();
        }
    }
}
