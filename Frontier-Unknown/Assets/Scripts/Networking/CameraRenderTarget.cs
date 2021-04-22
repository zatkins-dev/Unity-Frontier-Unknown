using UnityEngine;

public class CameraRenderTarget : MonoBehaviour
{
    [Tooltip("Camera to render from")]
    public Camera ExternalCamera;
    private CustomRenderTexture texture;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        if (ExternalCamera != null) {
            texture = new CustomRenderTexture(2048, 2048, RenderTextureFormat.DefaultHDR);
            texture.useMipMap = true;
            texture.autoGenerateMips = true;
            texture.useDynamicScale = true;
            texture.updatePeriod = 0.0f;
            texture.updateMode = CustomRenderTextureUpdateMode.Realtime;
            texture.Create();
            ExternalCamera.targetTexture = texture;
            material = GetComponent<Renderer>().material;
            material.mainTexture = texture;
            GetComponent<Renderer>().material = material; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        texture.Update();
    }

    void OnDestroy() {
        Destroy(material);
        texture.Release();
        Destroy(texture);
    }
}
