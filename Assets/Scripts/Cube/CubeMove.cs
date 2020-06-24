using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : IMoveSystem
{
    private CubeData Cube;
    private MoveState _moveState;
    private Vector3 Target;

    public Queue<Vector3> Points;

    public CubeMove(CubeData cube)
    {
        Cube = cube;
        _moveState = MoveState.WaitForPoint;
        Points = new Queue<Vector3>();
    }

    public void Move()
    {
        if (_moveState == MoveState.WaitForPoint)
        {
            if (Points.Count > 0)
            {
                _moveState = MoveState.Runing;
                Target = Points.Dequeue();
            }
        }

        if (_moveState == MoveState.Runing)
        {
            Cube.CubeTransform.position =
                Vector3.MoveTowards(Cube.CubeTransform.position, Target, Cube.Speed * Time.deltaTime);
            if (IsNeedToFindAnotherPoint(Target))
            {
                _moveState = MoveState.WaitForPoint;
            }
        }
    }

    private bool IsNeedToFindAnotherPoint(Vector3 point)
    {
        return Vector3.Distance(Cube.CubeTransform.position, point) < 0.5f;
    }

    private enum MoveState
    {
        WaitForPoint,
        Runing
    }
}