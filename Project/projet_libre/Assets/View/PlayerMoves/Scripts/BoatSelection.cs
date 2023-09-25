using Assets.View.Player_moves;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSelection : MonoBehaviour
{
    #region Attributes
    public SpriteRenderer spriteRendrer;
    [SerializeField]
    public float invisibleTime, visibleTime;
    [SerializeField]
    private Sprite[] _frameArray;
    [SerializeField]
    private GridManager gridManager;

    private BoatMovement selectedBoat;
    #endregion

    #region Public methods
    public void PlaySelection(Vector3 mouseInput, int movepoints)
    {
        if (spriteRendrer == null)
        {
            return;
        }

        
        StopSelection();
        gridManager.transform.Find($"Tile {mouseInput.x} {mouseInput.y}").GetComponent<Tile>().range(movepoints, Color.gray);
        

        StartCoroutine(FlashCoroutine());
    }

    public void StopSelection()
    {
        gridManager.resetView();
        StopAllCoroutines();
        Color spriteColor = spriteRendrer.color;
        spriteColor.a = 1;
        spriteRendrer.color = spriteColor;
    }
    #endregion

    #region Private methods
    private IEnumerator FlashCoroutine()
    {
        spriteRendrer.sprite = _frameArray[0];
        yield return new WaitForSeconds(invisibleTime);

        spriteRendrer.sprite = _frameArray[1];
        yield return new WaitForSeconds(visibleTime);

        StartCoroutine(FlashCoroutine());

    }
    #endregion
}
