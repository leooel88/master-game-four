using Assets.View.Player_moves;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoatAttack : MonoBehaviour
{
    #region Attributes
    private Boat selectedBoat;
    private Vector3 boatPosition;

    public UnityEvent<bool> OnAttack;
    public UnityEvent OnAttackEnd;
    public bool isAttacking = false;

    [SerializeField]
    private GridManager gridManager;
    public UnityEvent<Boat, Vector3> OnHandleMouseClick;

    #endregion

    #region Public methods
    public void HandleSelectBoat(Boat selectedBoat, Vector3 mouseInput)
    {
        this.HandleDeselectBoat();
        this.selectedBoat = selectedBoat;
        this.boatPosition = mouseInput;
    }

    public void HandleDeselectBoat()
    {
        this.selectedBoat = null;
        this.boatPosition = Vector3.zero;
        OnAttack?.Invoke(false);
        this.isAttacking = false;
    }

    public void HandleClickAttack()
    {
        if (this.selectedBoat != null)
        {
            if (isAttacking)
            {
                gridManager.resetView();
                OnHandleMouseClick?.Invoke(selectedBoat, boatPosition);
                isAttacking = false;
            } else
            {
                isAttacking = true;
                PlaySelectAttack();
            }
        }
    }

    public void BoatAttackBoat(Boat attackingBoat, Boat attackedBoat, Vector3 mouseInput)
    {
        attackingBoat.HandleAttack(attackedBoat, mouseInput);
        OnAttackEnd?.Invoke();
    }

    public void PlaySelectAttack()
    {
        OnAttack?.Invoke(true);
        gridManager.resetView();
        selectedBoat.playSelectAttack(gridManager, boatPosition);
    }
    #endregion
}
