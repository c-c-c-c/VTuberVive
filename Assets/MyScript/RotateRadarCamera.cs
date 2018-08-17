using UnityEngine;
using System.Collections;

public class RotateRadarCamera : MonoBehaviour
{

    [SerializeField]
    private Transform character;

    void Update()
    {
        var rot = Quaternion.Slerp(transform.rotation, character.rotation, Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, rot.eulerAngles.y, transform.eulerAngles.z);
    }
}