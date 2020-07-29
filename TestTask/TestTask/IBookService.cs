using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask
{
    interface IBookService
    {
        List<Book> ReadAll();
    }
}
