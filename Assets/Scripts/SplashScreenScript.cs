using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(goToTitleMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator goToTitleMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Title Screen");
    }
}
