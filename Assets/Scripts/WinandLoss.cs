using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinandLoss: MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        PointManager.score = 0;
        Projectile.enemyCount = 12;
        ProjectileLvl2.enemyCount = 12;

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Space");
    }
}
