using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicePlacement : MonoBehaviour
{
    public GameObject[] place;
    int[,] isEmpty;

    public int width = 5;
    public int height = 3;

    private void Start()
    {
        isEmpty = new int[width, height];
        Place();
    }

    void Place()
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
        int seed = (int)Time.time;
        System.Random rand = new System.Random(seed);

        int randX = rand.Next(0, width - 1);
        int randY = rand.Next(0, height - 1);

        Vector3 dicePosition = place[randY * width + randX].transform.position + Vector3.forward * -1;
        Instantiate(DiceManager.instance.playerDice, dicePosition, place[randY * width + randX].transform.rotation);
    }
}
