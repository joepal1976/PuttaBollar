using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HuvudMeny : MonoBehaviour
{

    public void StartClick()
    {
        Debug.Log("Tryckning på starta");
        SceneManager.LoadScene("Bana2");
    }

    public void ExitClick()
    {
        Debug.Log("Tryckning på avsluta");
        Application.Quit();
    }
}
