using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AraMenu : MonoBehaviour
{
    public GameObject aramenuobje;
    public bool aramenuacik;
    void Start()
    {
        aramenuacik = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.P))
        {
            aramenuacik = !aramenuacik;
        }

        if (aramenuacik)
        {
            aramenuobje.SetActive(true);
        }
        else
            aramenuobje.SetActive(false);
    }

    public void anaMenu()
    {
        SceneManager.LoadScene("anaMenuScene");
    }

    public void Cikis()
    {
        Application.Quit();
    }
}
