using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour { 
    [SerializeField] private float _width, _height;
    [SerializeField] private Tile _tile;
    [SerializeField] private Transform _cam;

    
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid() {
        for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_tile, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
                spawnedTile.transform.parent = this.transform;

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);
            }
        }
       _cam.transform.position = new Vector3(_width / 2 - 0.5f,_height / 2 - 0.5f, -10);
    }
    public void resetView()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                transform.Find($"Tile {x} {y}").gameObject.GetComponent<Tile>().Init(isOffset);
            }
        }
    }

    public float  getHeight()
    {
        return _height;
    }
    public float getWidth()
    {
        return _width;
    }

    public bool MouseInGrid(Vector3 mouseInput)
    {
        return (mouseInput.x >= 0 && mouseInput.x <= _width && mouseInput.y >= 0 && mouseInput.y <= _height);
    }

}
