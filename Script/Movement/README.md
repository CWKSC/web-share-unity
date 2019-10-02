# Movement

- ForwardAndRotate.cs

  - use up and down to control forward and back. 使用上下控制前進和後退。

    use left and right to control rotation. 使用左右控制旋轉。

- MoveXY.cs

  - use up, down to move y. 使用上、下移動 y。

    use left, right to move x. 使用左、右移動 x。

- MoveXZ.cs

  - use up, down to move x, 使用上、下移動 y。

    use left, right to move z. 使用左、右移動 z。

## ForwardAndRotate.cs

```C#
public float forwardSpeed = 4;
public float rotateSpeed = 120;

void Update()
{
    transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * forwardSpeed);
    transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed);
}
```

use up and down to control forward and back. 使用上下控制前進和後退。

use left and right to control rotation. 使用左右控制旋轉。

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

use up, down to move y. 使用上、下移動 y。

use left, right to move x. 使用左、右移動 x。

## MoveXZ.cs

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

use up, down to move x, 使用上、下移動 y。

use left, right to move z. 使用左、右移動 z。

___

