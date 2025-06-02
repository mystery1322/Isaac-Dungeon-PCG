using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    public enum DoorType
    {
        left, right, top, bottom
    }
    public DoorType doorType; 
}
