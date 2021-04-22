using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public HUDMap _HUDMap;
    public RawImage minimap;
    public Transform playerTransform;
    [SerializeField] RenderTexture texture;

    [Serializable]
    internal struct AmmoDisplay
    {
        public TMP_Text Label;
        public TMP_Text Text;
    };

    [SerializeField] private AmmoDisplay[] _ammoDisplays;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _positionText;

    // Start is called before the first frame update
    void Start()
    {
        minimap = GetComponentInChildren<RawImage>();
        texture = new RenderTexture(512, 512, 0, RenderTextureFormat.Default);
    }

    public void SetAmmoEnabled(int flag)
    {
        for (var i = 0; i < _ammoDisplays.Length; i++)
        {
            var display = ((flag >> i) & 0x01) > 0;
            _ammoDisplays[i].Label.enabled = display;
            _ammoDisplays[i].Text.enabled = display;
        }
    }

    public void UpdateAmmoText(int index, int @new, int max)
    {
        if (_ammoDisplays.Length <= index || index < 0) return;
        _ammoDisplays[index].Text.text = $"{@new}/{max}";
    }

    public void UpdateHealth(float newHealth, float maxHealth)
    {
        _healthText.text = $"{Mathf.RoundToInt(newHealth)}";
        _healthText.color = newHealth / maxHealth > 0.5f
            ? Color.Lerp(Color.yellow, Color.green, 2f * (newHealth / maxHealth - 0.5f))
            : Color.Lerp(Color.red, Color.yellow, 2f * newHealth / maxHealth);
    }

    public void UpdateScore(int @new)
    {
        _scoreText.text = $"{@new}";
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null) {
            _HUDMap.UpdateParameters(playerTransform);
            _HUDMap.RenderToTexture(ref texture);
            minimap.texture = texture;
            minimap.color = Color.white;
            var p = playerTransform.position;
            _positionText.text = $"({p.x:#,###}, {p.y:#,###}, {p.x:#,###})";
        }
        else
        {
            minimap.color = Color.clear;
        }
    }

    
}
