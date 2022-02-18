using System;
using System.Collections.Generic;
using System.Text;

namespace MobilApp.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}