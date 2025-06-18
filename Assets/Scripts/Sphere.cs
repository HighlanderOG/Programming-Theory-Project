using UnityEngine;

public class Sphere : Shape
{
    public override void SpawnShape()
    {
        if (shape != null)
        {
            Destroy(shape);
        }
        else
        {
            shape = Instantiate(shapes[0]);
            Colorize(); //inheretence!!
        }
    }
}
