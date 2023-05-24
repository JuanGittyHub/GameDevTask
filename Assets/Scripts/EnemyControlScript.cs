using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControlScript : MonoBehaviour
{
    public Rigidbody2D rb;
    GameObject playerCharacter;
    public GameObject characterDeathPrefab;
    public static float moveSpeed = 4f;
    public AudioSource characterDeathSound;
    Vector3 directionToCharacter;

    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }

    void moveEnemy()
    {
        if (playerCharacter != null)
        {
            directionToCharacter = (playerCharacter.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToCharacter.x * moveSpeed, directionToCharacter.y * moveSpeed);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
            
    } 
    
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Character"))
        {
            EnemySpawner.mustSpawn = false;
            characterDeathSound.Play();
            Instantiate(characterDeathPrefab, col.gameObject.transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            playerCharacter = null;
            StartCoroutine(ToGameOverScreen());

        }
    }

    IEnumerator ToGameOverScreen()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("GameOver Screen");
    }
}
