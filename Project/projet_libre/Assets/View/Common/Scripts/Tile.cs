using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _color, _otherColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    [SerializeField] private Sprite[] _frameArray;
    [SerializeField] private float _waveSpeed;

    private int _currentFrame;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _waveSpeed){
            _timer -= _waveSpeed;
            _currentFrame++;
            int size = _frameArray.Length;
            _renderer.sprite = _frameArray[_currentFrame%size];
        }
    }

    public void Init(bool isOffset)
    {
       _renderer.color = isOffset ? _otherColor : _color;

    }
    void OnMouseEnter()
    {
        _highlight.SetActive(true);
     
    }
    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    public bool IsHighlithed()
    {
        return _highlight.activeSelf;
    }

   
    private void SetColor(Color color)
    {
        _renderer.color = color;
    }
    public void range(int size, Color color)
    {
        Transform parent = this.transform.parent;
        float height = parent.gameObject.GetComponent<GridManager>().getHeight();
        float width = parent.gameObject.GetComponent<GridManager>().getWidth();
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {

                if((Mathf.Abs(x - j) + Mathf.Abs(y - i)) <= size)
                {
                    parent.transform.Find($"Tile {j} {i}").gameObject.GetComponent<Tile>().SetColor(color);
                }
            }
        }
    }

    public void circle(int min, int max, Color color)
    {
        Transform parent = this.transform.parent;
        float height = parent.gameObject.GetComponent<GridManager>().getHeight();
        float width = parent.gameObject.GetComponent<GridManager>().getWidth();
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((Mathf.Abs(x - j) + Mathf.Abs(y - i)) >= min && ((Mathf.Abs(x - j) + Mathf.Abs(y - i)) <= max))
                {
                    parent.transform.Find($"Tile {j} {i}").gameObject.GetComponent<Tile>().SetColor(color);
                }
            }
        }
    }
}
