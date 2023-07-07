using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Comandos
{
    public abstract class Commands : ScriptableObject
    {
        public abstract void Execute();
    } 
}
