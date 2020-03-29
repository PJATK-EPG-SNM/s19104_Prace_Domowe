using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    //public bool IsEnd = false;
    public GameObject Player;
    public GameObject Menu;

    // Update is called once per frame
    void Update()
    {
        if(Player.activeSelf == false)
        {
            End();
        }
    }

    private void End()
    {
        Menu.SetActive(true);
        Time.timeScale = 0;
        //IsEnd = true;
    }
    public void RestartGame()
    {
        //Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
