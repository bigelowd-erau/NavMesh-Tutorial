using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToNextScene()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%4);
    }
}
