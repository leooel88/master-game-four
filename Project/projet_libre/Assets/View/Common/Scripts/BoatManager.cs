using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.View.Player_moves;

public class BoatManager: MonoBehaviour
{
    [SerializeField] private GridManager gridManager;
    [SerializeField] private Boat[] _allyBoats;
    [SerializeField] private Boat[] _enemyBoats;

    void Start()
    {
        GenerateBoat();
        checkGameOver();
    }
    void GenerateBoat()
    {
        var gridWidth = gridManager.getWidth() - 1;
        
        for(int i = 0; i < _enemyBoats.Length; i++)
        { 
            var spawnedBoat = Instantiate(_enemyBoats[i], new Vector3(gridWidth, i), Quaternion.identity);
            spawnedBoat.transform.parent = this.transform;
            spawnedBoat.transform.name = $"Enemy Boat n°{i}";
            spawnedBoat.transform.gameObject.SetActive(true);

        }

        for (int i = 0; i < _allyBoats.Length; i++)
        {
            var spawnedBoat = Instantiate(_allyBoats[i], new Vector3(0, i), Quaternion.identity);
            spawnedBoat.transform.parent = this.transform;
            spawnedBoat.transform.name = $"Ally Boat n°{i}";
            spawnedBoat.transform.gameObject.SetActive(true);

        }
    }
    
    void checkGameOver()
    {
        for (int i = 0; i < _allyBoats.Length; i++)
        {
            
        }
    }
    
}