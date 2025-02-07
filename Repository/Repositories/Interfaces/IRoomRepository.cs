﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IRoomRepository : IBaseRepository<Room>
    {
        Task<IEnumerable<Room>> GetByName(string name);
        Task<IEnumerable<Room>> SortBySeatCount(string message);
        Task<IEnumerable<Room>> SortByName(string message);
    }
}
