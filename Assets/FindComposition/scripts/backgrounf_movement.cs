using UnityEngine;

public class backgrounf_movement : MonoBehaviour
{
    
    [Range(-1f , 1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex" , new Vector2(0 , offset));
    }
}
