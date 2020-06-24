using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Action<Vector3> OnPlancePressed;

    public void NotifyAboutPressedPlane(Vector3 position)
    {
        OnPlancePressed?.Invoke(position);
    }
}
