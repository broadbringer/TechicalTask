using UnityEngine;

public class CubeData
{
    public float Speed { get; set; }
    public Transform CubeTransform;

    public CubeData(float speed, Transform transform)
    {
        Speed = speed;
        CubeTransform = transform;
    }
}