using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void Again(){
        PlayerPrefs.SetInt("level", 1);
        SceneManager.LoadScene("MainScene");
    }
}
