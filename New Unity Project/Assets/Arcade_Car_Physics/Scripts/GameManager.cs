using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Create the game manager and make it visible from other scripts
    private static GameManager _Instance = null;
    public static GameManager Instance
    {
        get
        {
            if (_Instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();

            }
            return _Instance;
        }
    }


    //public Variables
    public float Health;
    public float EnemyHealth1 = 50;
    public float EnemyHealth2 = 50;
    public float EnemyHealth3 = 50;
    public float EnemyHealth4 = 50;
    public float Timer = 0;
    public float Ai1LapsCounter;
    public float Ai1Laps;
    public float PlayerLaps = 50;
    void Awake()

    {

        _Instance = this;
    }

}


