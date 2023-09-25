using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float directionalSpeed = 10f;
    [SerializeField] float scrollSpeed = 2000f;
    // Start is called before the first frame update
    void Start()
    {  
       GetComponent<Camera>().orthographicSize = 8;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float cameraSize = GetComponent<Camera>().orthographicSize;

        if (Input.GetKey("z") )
        {
            pos.y += directionalSpeed * Time.deltaTime;
        }
        if (Input.GetKey("q"))
        {
            pos.x -= directionalSpeed * Time.deltaTime;
            
        }
        if (Input.GetKey("s"))
        {
            pos.y -= directionalSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += directionalSpeed * Time.deltaTime;
        }
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        
        cameraSize -= scroll * scrollSpeed * Time.deltaTime;
        transform.position = pos;
        GetComponent<Camera>().orthographicSize = cameraSize;
    }
}
