using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public static DiceManager instance = null;

    public GameObject playerDice;

    GameObject clickedDice;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 50f, LayerMask.GetMask("Player"));

            clickedDice = hit.transform.gameObject;

            Debug.Log(hit.transform.gameObject);
        }

        if(Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 50f, LayerMask.GetMask("Player"));

            Debug.Log(hit.transform.gameObject);

            Destroy(clickedDice);

            hit.transform.GetComponent<Player>().damage *= 2;
        }
    }
}
