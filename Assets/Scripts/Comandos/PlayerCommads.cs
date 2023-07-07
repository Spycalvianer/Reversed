using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Comandos;
using UnityEngine.UI;

public class PlayerCommads : MonoBehaviour
{
    public List<Commands> playeractions = new List<Commands>();
    private GameObject prefab;
    int Actionnumber;
    private void Start()
    {
        for (int i = 0; i < playeractions.Count; i++)
        {
            GameObject go = prefab;//Instanciar prefab en el tranform que toca

            Image icon = go.GetComponent<Image>();
            icon.sprite = playeractions[i].icon;
        }
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
