using Assets.View.Player_moves;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LifeHandler : MonoBehaviour
{
    public void SetLife(Boat boat)
    {
        GetComponent<Text>().text = "HP : " + boat.GetHp().ToString() + "/" + boat.GetMaxHp().ToString();
    }
}
