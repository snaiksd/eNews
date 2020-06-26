﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNews.Data.SqlServer.Repository
{
    public interface IUnitOfWork
    {
        void CommitTransaction();
        void RollBackTransaction();
    }
}
