using Assets.View.Player_moves;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    #region Attributes
    Boat selectedBoat;
    bool isEnemyTurn;
    bool isAttacking;
    [SerializeField]
    private GridManager gridManager;

    public UnityEvent<Boat, Vector3> OnHandleMouseClick, OnSelectBoat;
    public UnityEvent<Boat> OnSeletBoatDisplayLife;
    public UnityEvent<Boat, Boat, Vector3> OnAttackBoat;
    public UnityEvent OnDeselectBoat;
    #endregion

    #region Public methods
    public void PlaySelection(Boat selectedBoat, Vector3 mouseInput)
    {
        selectedBoat.GetComponent<BoatSelection>().PlaySelection(mouseInput, selectedBoat.GetMovePoints());
    }

    public void HandleSelection(GameObject detectedColider, Vector3 mouseInput)
    {
        mouseInput.x = Mathf.Round(mouseInput.x);
        mouseInput.y = Mathf.Round(mouseInput.y);
        mouseInput.z = Mathf.Round(mouseInput.z);


        if (detectedColider == null)
        {
          
            if (!gridManager.MouseInGrid(mouseInput))
            {
                return;
            }
            if (gridManager.transform.Find($"Tile {mouseInput.x} {mouseInput.y}").gameObject.GetComponent<Tile>().IsHighlithed())
            {
                if (selectedBoat == null)
                {
                    return;
                } else
                {
                    if (selectedBoat.IsEnemy().Equals(isEnemyTurn))
                    {
                        OnHandleMouseClick?.Invoke(selectedBoat, mouseInput);
                        DeselectOldObject();
                    }
                }
            }
            

        } else
        {
            if (isAttacking)
            {
                OnAttackBoat?.Invoke(this.selectedBoat, detectedColider.GetComponent<Boat>(), mouseInput);
            } else
            {
                DeselectOldObject();
                selectedBoat = detectedColider.GetComponent<Boat>();
                if (selectedBoat.IsEnemy() == this.isEnemyTurn)
                {
                    selectedBoat.GetComponent<BoatSelection>().PlaySelection(mouseInput, selectedBoat.GetMovePoints());
                    OnSelectBoat?.Invoke(selectedBoat, mouseInput);
                }
                OnSeletBoatDisplayLife?.Invoke(selectedBoat);
            }
            
        }
    }

    public void SetIsEnemyTurn(bool _isEnemyTurn)
    {
        this.isEnemyTurn = _isEnemyTurn;
    }

    public Boat GetSelectedBoat()
    {
        return this.selectedBoat;
    }

    public void SetIsAttacking(bool isAttacking)
    {
        this.isAttacking = isAttacking;
    }
    #endregion

    #region Private methods
    public void DeselectOldObject()
    {
        if (selectedBoat == null)
        {
            return;
        }
        selectedBoat.GetComponent<BoatSelection>().StopSelection();
        selectedBoat = null;
        OnDeselectBoat?.Invoke();
    }
    #endregion
}
