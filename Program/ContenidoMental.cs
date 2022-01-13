using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContenidoMental : MonoBehaviour
{  
    public Renderer renderer;
    public float updateInterval = 0.5F;
    private double lastInterval;
    private int frames;
    private float fps;
    // Start is called before the first frame update
    void Start()
    {
        
        renderer  = GetComponent <Renderer>();
        // _MagicMask("Magic Mask", float) = 1
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;

    }

    void OnGUI()
    {
        GUILayout.Label("" + fps.ToString("f2"));
    }


    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A)){
            renderer.material.SetFloat("_MagicMask", 0.5f);
            Debug.Log("Here Pressing A");
        }
        if(Input.GetKey(KeyCode.B)){
            renderer.material.SetFloat("_MagicMask", 1.5f);
            Debug.Log("Here Pressing B");

        }
        
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            fps = (float)(frames / (timeNow - lastInterval));
            frames = 0;
            lastInterval = timeNow;
        }
        
    }
}
