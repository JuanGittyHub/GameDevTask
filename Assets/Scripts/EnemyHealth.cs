using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int monsterHealth = 2;
    public static int killCount;

    public GameObject monsterDeathPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        monsterHealth -= 1;

        if(monsterHealth <= 0)
        {
            Instantiate(monsterDeathPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            killCount += 1;
        }
    }
}
