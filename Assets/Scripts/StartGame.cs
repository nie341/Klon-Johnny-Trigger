using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject move, start;
       // Start is called before the first frame update
     public  void StGame()
    {
        //IronSource.Agent.validateIntegration();
        move.GetComponent<MoveLvl1>().enabled = true;
        start.gameObject.SetActive( false);
    }
    public void RpGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void NExtLVL()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }


}
