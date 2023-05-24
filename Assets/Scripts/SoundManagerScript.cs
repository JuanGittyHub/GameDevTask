using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip titleMenuSound, characterDeathSound;
    public static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        titleMenuSound = Resources.Load<AudioClip>("titleMenuSound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
