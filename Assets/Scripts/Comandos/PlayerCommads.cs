using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Comandos;

public class PlayerCommads : MonoBehaviour
{
    public List<Commands> playeractions = new List<Commands>();

    int Actionnumber;
    private void Start()
    {
        DoAction();
    }
    private void DoAction()
    {
        playeractions[Actionnumber].Execute();
    }
    public void IncreaseIndex()
    {
        Actionnumber++;
        DoAction();
    }
}
