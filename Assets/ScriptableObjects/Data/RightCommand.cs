using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Comandos
{
    [CreateAssetMenu(fileName = "RightCommand", menuName = "Commands/RightCommand")]
    public class RightCommand : Commands
    {
        public override void Execute()
        {
            Debug.Log("Right");

        }
        private void Staraction()
        {
          
            //switch ()
            //    {
            //    case TileType.groundtile:
            //        //hacer x accion
            //        return;

            //}

        }

    }
}
