using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public Button spawnButton;
    public Button spawnSphere;
    public Button spawnCube;
    [SerializeField]
    protected List<GameObject> shapes = new List<GameObject>();
    [SerializeField]
    protected GameObject shape;
    protected virtual void InitShape()
    {
        // base init logic (optional)
    }
    public virtual void SpawnShape()
    {
        if (shape != null)
        {
            Destroy(shape);
        }
        else
        {
            shape = Instantiate(shapes[Random.Range(0, 2)]);
            Colorize(); // ABSTRACTION
        }
    }

    protected void Colorize()
    {
     
    }
}
