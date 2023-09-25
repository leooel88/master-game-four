using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.View.Player_moves;

public class BoatMovement : MonoBehaviour
{
    #region Attributes
    public float threshold = 1f;

    private Boat selectedBoat;
    #endregion

    #region Public methods
    public void HandleSelection(GameObject detectedObject, Vector3 mouseInput)
    {
        if (detectedObject == null)
        {
            this.selectedBoat = null;
            return;
        }

        this.selectedBoat = detectedObject.GetComponent<Boat>();
    }

    public Boat getBoat()
    {
        return selectedBoat;
    }

    public void HandleMovement(Boat boat, Vector3 endPosition)
    {
        if (selectedBoat == null)
        {
            if (boat == null)
            {
                return;
            } else
            {
                this.selectedBoat = boat;
                if (selectedBoat.CanStillMove() == false)
                {
                    return;
                }
                else
                {
                    selectedBoat.HandleMovement(endPosition);
                }
            }
        }

        
        
        
    }
    #endregion
}
