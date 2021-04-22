using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "HUDMap", menuName = "ScriptableObjects/HUDMap", order = 1)]
public class HUDMap : ScriptableObject
{
    public bool debug = false;
    [Tooltip("Specifies the zoom level as pixels/unit of the map.")]
    [Range(0.1f, 10f)]
    public float zoom = 1;
    public ComputeShader shader;
    public Vector2 mapSize;
    public Color background = new Color(0,0,0,127);
    public float scale = 3;
    public Vector2Int res;
    [Range(1f, 100f)]
    public float borderWidthRel=10;
    

    public Color[] TeamColors;

    struct ShipData
    {
        public Vector3 Pos;
        public Color Color;
    }

    int kernel;
    int threadGroupSize;
    [SerializeField] ComputeBuffer buffer;

    [SerializeField] ShipData[] debugData;
    

    // Start is called before the first frame update
    void Awake()
    {
        kernel = shader.FindKernel("MiniMap");
        uint size;
        shader.GetKernelThreadGroupSizes(kernel, out size, out _, out _);
        Debug.Log($"Thread group size: {size}");
        threadGroupSize = (int)size;
    }

    void OnValidate()
    {
        kernel = shader.FindKernel("MiniMap");
        uint size;
        shader.GetKernelThreadGroupSizes(kernel, out size, out _, out _);
        Debug.Log($"Thread group size: {size}");
        threadGroupSize = (int)size;
    }

    public void UpdateParameters(Transform playerTransform)
    {
        OnValidate();
        shader.SetMatrix("rotation", playerTransform.worldToLocalMatrix);
        var pos = playerTransform.position;
        float[] posFloat3 = new float[3]{ pos.x, pos.y, pos.z};
        shader.SetFloats("center", posFloat3);
        shader.SetInt("res_x", res.x);
        shader.SetInt("res_y", res.y);
        shader.SetFloat("zoom", zoom);
        shader.SetFloat("scale", scale);
        shader.SetFloat("border_width_rel", borderWidthRel);

        if (debug) {
            debugData ??= new[]
            {
                new ShipData {Pos = new Vector3(0, 0, 0), Color = TeamColors[0]},
                new ShipData {Pos = new Vector3(0, 0, 10), Color = TeamColors[0]},
                new ShipData {Pos = new Vector3(0, 0, 20), Color = TeamColors[0]},
                new ShipData {Pos = new Vector3(0, 0, 30), Color = TeamColors[0]},
                new ShipData {Pos = new Vector3(20, 0, 0), Color = TeamColors[1]},
                new ShipData {Pos = new Vector3(20, 0, 10), Color = TeamColors[1]},
                new ShipData {Pos = new Vector3(20, 0, 20), Color = TeamColors[1]},
                new ShipData {Pos = new Vector3(20, 0, 30), Color = TeamColors[1]},
                new ShipData {Pos = new Vector3(40, 0, 0), Color = TeamColors[2]},
                new ShipData {Pos = new Vector3(40, 0, 10), Color = TeamColors[2]},
                new ShipData {Pos = new Vector3(40, 0, 20), Color = TeamColors[2]},
                new ShipData {Pos = new Vector3(40, 0, 30), Color = TeamColors[2]},
                new ShipData {Pos = new Vector3(60, 0, 0), Color = TeamColors[3]},
                new ShipData {Pos = new Vector3(60, 0, 10), Color = TeamColors[3]},
                new ShipData {Pos = new Vector3(60, 0, 20), Color = TeamColors[3]},
                new ShipData {Pos = new Vector3(60, 0, 30), Color = TeamColors[3]},
            };
            buffer = new ComputeBuffer(debugData.Length, 3*sizeof(float)+4*sizeof(float));
            buffer.SetData(debugData);
            shader.SetBuffer(kernel, "Ships", buffer);
            shader.SetInt("numShips", debugData.Length);
            return; 
        }

        var shipDataList = ShipLocator.Singleton.locations;
        var shipDatas = shipDataList.ToList();
        var numShips = shipDatas.Count;
        if (numShips > 0)
        {
            buffer = new ComputeBuffer(numShips, 3*sizeof(float)+4*sizeof(float));
            ShipData[] data = new ShipData[numShips];
            int i = 0;
            foreach (var shipData in shipDatas)
                data[i++] = new ShipData { Pos = shipData.Pos, Color = TeamColors[shipData.TeamID] };
            buffer.SetData(data);
            shader.SetBuffer(kernel, "Ships", buffer);

            shader.SetInt("numShips", numShips);
        }
    }

    public void RenderToTexture(ref RenderTexture tex)
    {
        if (buffer == null || !buffer.IsValid()) return;
        tex.Release();
        tex = new RenderTexture(res.x, res.y, 0, RenderTextureFormat.Default) {enableRandomWrite = true};
        tex.Create();
        shader.SetTexture(kernel, "Result", tex);

        shader.Dispatch(0, res.x/threadGroupSize, res.y/threadGroupSize, 1);
        buffer.Release();
    }

}
