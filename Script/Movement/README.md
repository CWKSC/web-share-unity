## Movement

- MoveXY.cs
- MoveXZ.cs

### MoveXY.cs

```C#
public float xSpeed = 1;
public float ySpeed = 1;

void Update()
{
    transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed,
                                     transform.position.y + Input.GetAxis("Vertical")   * Time.deltaTime * ySpeed,
                                     transform.position.z);
}
```

use up, down to move y,

use left, right to mvoe x.

### MoveXZ.cs

```C#
public float xSpeed = 1;
public float zSpeed = 1;

void Update()
{
    transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * xSpeed,
                                     transform.position.y,
                                     transform.position.z + Input.GetAxis("Vertical") * Time.deltaTime * zSpeed);
}
```

use up, down to move x,

use left, right to mvoe z.
