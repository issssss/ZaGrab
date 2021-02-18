using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public void IdiSnimaj()
    {
        SceneManager.LoadScene(1);
    }

    public void IdiTrazi()
    {
        SceneManager.LoadScene(2);
    }

    public void Izadi()
    {
        Debug.Log("Idemo!");
        Application.Quit();
    }
    public void VratiSe()
    {
        SceneManager.LoadScene(0);
    }
}
