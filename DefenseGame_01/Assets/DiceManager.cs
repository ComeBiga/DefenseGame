using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public static DiceManager instance = null;

    public GameObject playerDice;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
