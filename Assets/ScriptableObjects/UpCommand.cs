using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Comandos
{
    [CreateAssetMenu(fileName = "UpCommand", menuName = "Commands/UpCommands")]
    public class UpCommand : Commands
    {
        public override void Execute()
        {
            Debug.Log("up");
        }
    }

}