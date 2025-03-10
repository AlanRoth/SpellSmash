using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;
    public Animator wizard;
    public float transitionTime = 1.5f;

    public void PlayGame()
    {
        var language = Languages.GetLanguage();
        WordStore.GenerateWords(language); 
        StartCoroutine(LoadLevel("Level"));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        StartCoroutine(LoadLevel("Menu"));
    }

    private IEnumerator LoadLevel(string levelName)
    {
        if(wizard != null)
        {
            wizard.SetTrigger("Drop");
        }
        if(transition != null)
        {
            transition.SetTrigger("Start");
        }
        Time.timeScale = 1f;
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelName);
    }

}
