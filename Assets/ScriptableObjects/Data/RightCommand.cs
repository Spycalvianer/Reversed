using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Comandos
{
    [CreateAssetMenu(fileName = "RightCommand", menuName = "Commands/RightCommand")]
    public class RightCommand : Commands
    {
        public Transform wallCheckOrigin;
        public Vector3 rayDirection;
        public float rayDistance;
        public LayerMask groundLayer;
        public Transform movingCharacter;
        public float speed, nextTileDetectionDistance;
        Transform target;
        Tile tile;
        public override void Execute()
        {
            Debug.Log("Right");
        }
        private void Staraction()
        {
            //Lanzar un rayo hacia delante para detectar una posible pared
            if (Physics.Raycast(wallCheckOrigin.position, rayDirection, rayDistance, groundLayer))
            {
                //Parar en el último tile detectado
                movingCharacter.position += Vector3.zero;
            }
            //Necesario? Se puede hacer que el personaje siga caminando, y colisione contra la pared
            //El Player puede reiniciar desde menú
            else
            {
                //Hacer otro raycast a la derecha del objeto que se mueve (Mario) de manera que:
                RaycastHit nextTile;
                Physics.Raycast(movingCharacter.position + movingCharacter.right, -movingCharacter.up, out nextTile, nextTileDetectionDistance, groundLayer);
                target = nextTile.transform;
                Vector3.Lerp(movingCharacter.position, target.position, speed * Time.deltaTime);
            }
            
             
            //switch ()
            //    {
            //    case TileType.groundtile:
            //        //hacer x accion
                      //buscar siguiente tile, y mover a ese punto
            //        return; 

            //}

        }

    }
}
