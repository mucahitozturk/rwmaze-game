using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecisleri : MonoBehaviour
{

    [SerializeField]
    private string GecisLeveli;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(GecisLeveli);
        }
    }

    public void Bolumler()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
