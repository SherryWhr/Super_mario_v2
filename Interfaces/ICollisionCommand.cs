﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario.Interfaces
{
    public interface ICollisionCommand
    {
        void Execute(IGameObject gameObject1, IGameObject gameObject2);
    }
}
