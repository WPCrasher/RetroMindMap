﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroMindMap
{
    public interface IToolbar
    {
        void AddToolbarItem(IToolbarItem toolbarItem);
        void AddSeparator();
    }
}
