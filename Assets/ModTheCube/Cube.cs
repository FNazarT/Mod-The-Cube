using UnityEngine;

public class Cube : MonoBehaviour
{
    private float xRange = 5f, yRange = 5f, zRange = 5f, scaleRange = 5f;
    private Vector3[] rotationAxis = { Vector3.right, Vector3.up, Vector3.forward };

    public MeshRenderer Renderer;
    public Vector3 newPosition;
    public int randomAxis;
    public float rotationAngle, scaleFactor, redFactor, greenFactor, blueFactor, opacityFactor;
    
    void Update() => transform.Rotate(rotationAxis[randomAxis], rotationAngle * Time.deltaTime);

    public void ChangeTransform()
    {
        newPosition = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), Random.Range(-zRange, zRange));
        transform.position = newPosition;

        randomAxis = Random.Range(0, 3);
        rotationAngle = Random.Range(10f, 90f);
        transform.rotation = Quaternion.identity;

        scaleFactor = Random.Range(2, scaleRange);
        transform.localScale = Vector3.one * scaleFactor;
    }

     public void ChangeColor()
    {
        redFactor = Random.Range(0f, 1f);
        greenFactor = Random.Range(0f, 1f);
        blueFactor = Random.Range(0f, 1f);
        opacityFactor = Random.Range(0.5f, 1f);

        Renderer.material.color = new Color(redFactor, greenFactor, blueFactor, opacityFactor);
    }
}
