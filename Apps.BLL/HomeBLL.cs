﻿using Apps.IBLL;
using Apps.IDAL;
using Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace Apps.BLL
{
    public class HomeBLL: IHomeBLL
    {
        [Dependency]
        public IHomeRepository HomeRepository { get; set; }
        public List<SysModule> GetMenuByPersonId(string moduleId)
        {
            return HomeRepository.GetMenuByPersonId(moduleId);
        }
    }
}