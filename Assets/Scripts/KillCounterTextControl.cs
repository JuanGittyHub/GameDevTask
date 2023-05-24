using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounterTextControl : MonoBehaviour
{
    public Text killCounterText;
    // Start is called before the first frame update
    void Start()
    {
        killCounterText.text = EnemyHealth.killCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
