using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void NextButton(){
        SceneManager.LoadScene(sceneName);
    }
}
