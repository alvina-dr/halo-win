using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3 Destination;
    public List<GameObject> zombies;

    public List<GameObject> getZombies() {
        return zombies;
    }
}
