using System;
using System.Linq.Expressions;
using EFLibrary;

namespace BusProject.Data
{
    public class BusDao : SingleKeyDao<Bus, int>
    {
        protected override Expression<Func<Bus, bool>> IsKey(int key)
        {
            return x => x.OperationId == key;
        }

        protected override Expression<Func<Bus, int>> KeySelector
        {
            get
            {
                return x => x.OperationId;
            }
        }
    }
}