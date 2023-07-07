using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Comandos
{
    public abstract class Commands : ScriptableObject
    {
        [SerializeField] public Sprite icon;
        public abstract void Execute();
    } 
}
