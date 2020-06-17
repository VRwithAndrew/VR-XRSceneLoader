using UnityEngine;

public class ButtonObject : MonoBehaviour
{
    public void LoadGame()
    {
        SceneLoader.Instance.LoadNewScene("Game");
    }
}
