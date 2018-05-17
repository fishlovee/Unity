### Linear Interpolation (线性插值)
```C#
float result = Mathf.Lerp (3f, 5f, 0.5f);
```

> he Mathf.Lerp function takes 3 float parameters: one representing the value to interpolate from; another representing the value to interpolate to and a final float representing how far to interpolate. In this case, the interpolation value is 0.5 which means 50%. If it was 0, the function would return the ‘from’ value and if it was 1 the function would return the ‘to’ value.  

> Mathf.Lerp 第一个参数表示插入的起点，第二个表示终点，第三个如果是0则返回起点，为1则返回终点。  

> 其他使用 lerp 的例子是： Color.Lerp 和 Vector3.Lerp。  

```C#
Vector3 from = new Vector3 (1f, 2f, 3f);
Vector3 to = new Vector3 (5f, 6f, 7f);

// Here result = (4, 5, 6)
Vector3 result = Vector3.Lerp (from, to, 0.75f);


// 实现灯光强度渐变——每秒增加强度
void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f*Time.deltaTime);
}
```


