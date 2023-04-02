using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] livesUI;
    public GameObject explosionPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "enemy")
        {
            Destroy(collision.collider.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Projectile.enemyCount -= 1;
            lives -= 1;
            for(int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("LoseScreen");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy projectile")
        {
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("LoseScreen");
            }
        }
    }
}
