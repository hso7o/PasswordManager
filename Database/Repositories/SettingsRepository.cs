﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Context;
using Database.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class SettingsRepository : GenericRepository<Settings>, ISettingsRepository
    {
        public SettingsRepository(PasswordManagerDBContext context) : base(context)
        {
        }
    }
}
