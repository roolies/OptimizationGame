using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectileLvl2 : MonoBehaviour
{
    public float moveSpeed;
    public GameObject explosionPrefab;
    private PointManager pointManager;
    public static int enemyCount = 18;
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Instantiate(explosionPrefab, transform.position - new Vector3(0, .2f, 0), Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            pointManager.UpdateScore(50);
            enemyCount -= 1;
        }

        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

        if (enemyCount == 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
