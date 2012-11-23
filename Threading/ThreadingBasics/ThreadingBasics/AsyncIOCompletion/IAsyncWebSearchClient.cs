using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ThreadingBasics.AsyncIOCompletion
{
    interface IAsyncWebSearchClient
    {
        IList<string> GetTopGoogleSearchFor(Uri urlLink, uint topSearches);
        
    }
}
