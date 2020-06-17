using UnityEngine;

public class LayerSwitcher : MonoBehaviour
{
    public string targetLayer = "Persistent";
    private string originalLayer = string.Empty;

    private void Awake()
    {
        originalLayer = LayerMask.LayerToName(gameObject.layer);
    }

    private void OnEnable()
    {
        SceneLoader.Instance.OnLoadBegin.AddListener(SwitchToLoadLayer);
        SceneLoader.Instance.OnLoadEnd.AddListener(ResetLayer);
    }

    private void OnDisable()
    {
        SceneLoader.Instance.OnLoadBegin.RemoveListener(SwitchToLoadLayer);
        SceneLoader.Instance.OnLoadEnd.RemoveListener(ResetLayer);
    }

    private void SwitchToLoadLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(targetLayer);
    }

    private void ResetLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(originalLayer);
    }
}
