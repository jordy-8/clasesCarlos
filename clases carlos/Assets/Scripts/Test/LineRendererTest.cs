using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTest : MonoBehaviour
{
    public LineRenderer lineRenderer;

    public Color startColor;
    public Color endColor;

    public Vector3 origin;
    public Vector3 distance;

    public bool cerrarFigura; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.startColor = startColor;
        lineRenderer.endColor = endColor;

        lineRenderer.loop = cerrarFigura;

        lineRenderer.SetPosition(0, origin);
        lineRenderer.SetPosition(1, distance);
    }
}
