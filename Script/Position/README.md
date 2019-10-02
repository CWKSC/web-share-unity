# Position

- FollowPosition.cs
  - 跟随位置
- LockPosition.cs
  - 锁定位置

## Follow Position 跟随位置

```C#
public GameObject target;

Vector3 offset;
Vector3 oldPosition;

void Start()
{
    oldPosition = target.transform.position;
}

// Update is called once per frame
void Update()
{
    offset = target.transform.position - oldPosition;
    transform.position += offset;
    oldPosition = target.transform.position;
}
```

记录 target 上一次的 position。

利用 oldPosition 计算出 offset 偏移，然后增加到 position 位置。

在 Update 的部分，你可以简化一点点，但可读性似乎降低了：

```C#
void Update()
{
    transform.position += target.transform.position - oldPosition;
    oldPosition = target.transform.position;
}
```

## Lock Position 锁定位置

```C#
public GameObject target;

private Vector3 offset;  //Private variable to store the offset distance between the player and camera

// Use this for initialization
void Start()
{
    //Calculate and store the offset value by getting the distance between the player's position and camera's position.
    offset = transform.position - target.transform.position;
}

// LateUpdate is called after Update each frame
void LateUpdate()
{
    // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
    transform.position = target.transform.position + offset;
}
```

来源： [Movement Basics - Unity Learn 【3. Following the Player with the Camera】](https://learn.unity.com/tutorial/movement-basics?projectId=5c514956edbc2a002069467c#5c7f8528edbc2a002053b711)

先取得 offset (偏移量) ，然后根据这个 offset 去更改 position。

两者的距离和相对位置会被锁定。

## 为什么不使用 child 的方式去锁定 position ？

因为 child 在 parent 的 rotation 改变时，child 也会一起改变。

我們只要 position 跟随。

## Lock 和 Follow 的分别：

Lock Position 锁定位置是死锁。

你不能改变跟随者的位置。

除非你改变跟随者位置同时，改变 offset 。

Follow Position 是按照 target 的位置。

跟随者的位置不会被锁定。

## 其他方法：

设定为 target 的 child。

添加 Rigidbody 组件，freeze rotation。

这个方法没有试过，但应该可行。

___

