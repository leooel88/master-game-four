using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaAnimator : MonoBehaviour
{
    [SerializeField] private Sprite[] FrameArray;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = FrameArray[0];
    }
}
