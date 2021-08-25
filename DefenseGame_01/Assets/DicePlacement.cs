using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DicePlacement : MonoBehaviour
{
    public GameObject[] place;
    bool[] isEmpty;

    public int width = 5;
    public int height = 3;

    private void Start()
    {
        isEmpty = new bool[width * height];
        for(int i = 0; i < isEmpty.Length; i++)
        {
            isEmpty[i] = true;
        }
        GenerateField();
    }

    void GenerateField()
    {
        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                
            }
        }
    }

    public void CreateDice()
    {
        if (IsFull())
            return;

        Vector2Int randXY = new Vector2Int();
        int randX;
        int randY;

        while (true)
        {
            randXY = RandomPosition();
            randX = randXY.x;
            randY = randXY.y;

            if (isEmpty[randY * width + randX] == true) break;
        }

        Vector3 dicePosition = place[randY * width + randX].transform.position + Vector3.forward * -1;
        var newDice = Instantiate(DiceManager.instance.playerDice, dicePosition, place[randY * width + randX].transform.rotation);
        isEmpty[randY * width + randX] = false;
    }

    Vector2Int RandomPosition()
    {
        int seed = (int)System.DateTime.Now.Ticks;
        System.Random rand = new System.Random(seed);

        int randX = rand.Next(0, width);
        int randY = rand.Next(0, height);

        return new Vector2Int(randX, randY);
    }

    bool IsFull()
    {
        foreach(var v in isEmpty)
        {
            if (v == true) return false;
        }

        return true;
    }
}
