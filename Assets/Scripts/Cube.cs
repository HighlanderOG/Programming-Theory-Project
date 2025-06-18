using UnityEngine;

public class Cube : Shape
{
    public override void SpawnShape()
    {
        if (shape != null)
        {
            Destroy(shape);
        }
        else
        {
            shape = Instantiate(shapes[1]);
            Colorize(); // INHERITANCE
        }
    }
}
