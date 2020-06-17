using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
    private void Awake()
    {

    }

    private void OnDestroy()
    {
 
    }

    public void LoadNewScene(string sceneName)
    {

    }

    private IEnumerator LoadScene(string sceneName)
    {
		yield return null;
    }

    private IEnumerator UnloadCurrent()
    {
		yield return null;
    }

    private IEnumerator LoadNew(string sceneName)
    {
		yield return null;
    }

    private void SetActiveScene(Scene scene, LoadSceneMode mode)
    {

    }
}

