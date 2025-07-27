using UnityEngine;

public class ResponsiveUIElement : MonoBehaviour
{
    [SerializeField] private ProportionalBackgroundScaler _background;
    
    private void Start()
    {
        OnRectTransformDimensionsChange();
    }

    private void OnRectTransformDimensionsChange()
    {
        if (_background == null) return;
        
        _background.FitImage();
    }
}