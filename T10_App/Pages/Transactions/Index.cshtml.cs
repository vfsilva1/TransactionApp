using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using T10_App.Data;
using T10_App.Models;

namespace T10_App.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly T10_App.Data.TransactionContext _context;

        public IndexModel(T10_App.Data.TransactionContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; }

        public async Task OnGetAsync()
        {
            Transaction = await _context.Transaction.ToListAsync();
        }
    }
}
