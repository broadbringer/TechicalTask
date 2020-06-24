using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public EventManager EventsManager;
    public CubeData Data;
    public CubeMove MoveSystem;
    private Transform GetTransform() => GetComponent<Transform>();
    [SerializeField] private Slider _moveSpeedSlider;

    private void Start()
    {
        Data = new CubeData(10, GetTransform());
        MoveSystem = new CubeMove(Data);
        EventsManager.OnPlancePressed += AddPointToPathWay;
        _moveSpeedSlider.onValueChanged.AddListener(ChangeSpeedOn);
    }

    private void OnDisable()
    {
        EventsManager.OnPlancePressed -= AddPointToPathWay;
        _moveSpeedSlider.onValueChanged.RemoveListener(ChangeSpeedOn);
    }

    private void Update()
    {
        MoveSystem.Move();
    }

    private void AddPointToPathWay(Vector3 point)
    {
        MoveSystem.Points.Enqueue(point);
    }

    private void ChangeSpeedOn(float value)
    {
        Data.Speed = value;
    }
}