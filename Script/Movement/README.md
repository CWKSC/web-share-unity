## Movement

- ForwardAndRotate.cs
- MoveXY.cs
- MoveXZ.cs

### ForwardAndRotate.cs

```C#
public float forwardSpeed = 4;
public float rotateSpeed = 120;

void Update()
{
    transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * forwardSpeed);
    transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed);
}
```

use up and down to control forward and back.

use left and right to control rotation.

## MoveXY.cs

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
