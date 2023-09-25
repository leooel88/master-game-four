using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.View.Common.Scripts.Models;

public class Archer : AdvancedCharacter
{

    public Archer()
    {
        this.SetLife(100);
        this.SetMaxLife(100);

        this.SetStamina(5);
        this.SetMaxStamina(5);

        this.SetRegenLife(1);
        this.SetRegenStamina(1);
        this.SetTimeBeforeRegenLife(10);
        this.SetTimeBeforeRegenStamina(10);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
