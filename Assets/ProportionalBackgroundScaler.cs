using UnityEngine;

public class ProportionalBackgroundScaler : MonoBehaviour
{
    private SpriteRenderer _backgroundImage;

    private void Start()
    {
        _backgroundImage = GetComponent<SpriteRenderer>();
    }

    public void FitImage()
    {
        if (_backgroundImage == null) return;
        
        float width = _backgroundImage.sprite.bounds.size.x;
        float height = _backgroundImage.sprite.bounds.size.y;

        float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        float scale = Mathf.Max(worldScreenWidth / width, worldScreenHeight / height) * 1.1f;

        transform.localScale = new Vector3(scale, scale, 1);

    }
}
