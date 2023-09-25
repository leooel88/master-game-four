using Assets.View.Player_moves;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HandlePlayerInput : MonoBehaviour
{
    #region Attributes

    public Camera currentCamera;
    public LayerMask layerMask;

    [SerializeField]
    public Boat boat;

    public UnityEvent<GameObject, Vector3> OnHandleMouseClick;
    public UnityEvent<Vector3> OnHandleMouseFinishDragging;

    #endregion


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    HandleMouseClick();
        //}

        if (Input.GetMouseButtonUp(0))
        {
            HandleMouseClick();
        }
    }

    #region Private methods
    private void HandleMouseClick()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Vector3 mouseInput = GetMousePosition();
            Collider2D colider = Physics2D.OverlapPoint(mouseInput, layerMask);
            GameObject selectedObject = colider == null ? null : colider.gameObject;


            OnHandleMouseClick?.Invoke(selectedObject, mouseInput);
        }
        
    }

    private void HandleMouseUp()
    {
        Vector3 mouseInput = GetMousePosition();

    }

    private Vector3 GetMousePosition()
    {
        Vector3 mouseInput = currentCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseInput.z = 0f;
        return mouseInput;
    }
    #endregion
}
