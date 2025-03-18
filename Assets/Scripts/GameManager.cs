using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public void Awake()
    {
        if (instance) Destroy(this);
        else instance = this;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
