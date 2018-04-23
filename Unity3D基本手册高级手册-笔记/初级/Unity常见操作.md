##### 1.平面移动
``` C#

	// 以标准速度移动
    transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

	// 以自定义速度移动
	float fx = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
	float fz = Input.GetAxis("Vertical")*Time.deltaTime*speed;	
	transform.Translate(fx,0.0f,fz);
    //Input.GetAxis() // 用于获取水平轴按钮代表的方向，返回-1~1 ，可以在 Edit->Project Settings->Input 中设置

	// 第一种，通过transform.Translate移动
	public class MoveTest01 : MonoBehaviour {

		public GameObject cube;			
		void Update () {
			if (Input.GetKey(KeyCode.W))
			{
				cube.transform.Translate(Vector3.forward * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.S))
			{
				cube.transform.Translate(Vector3.back * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.A))
			{
				cube.transform.Translate(Vector3.left * Time.deltaTime);
			}
			if (Input.GetKey(KeyCode.D))
			{
				cube.transform.Translate(Vector3.right * Time.deltaTime);
			}
		}
	}


	//第二种，通过给Rigdbody添加一个力来实现移动
	public class MoveTest02 : MonoBehaviour {
		//这个方法会受到物理因素的影响
		public GameObject sphere;
		public Rigidbody sphereRigdbody;

		void Update () {
			if (Input.GetKey(KeyCode.W))
			{
				sphereRigdbody.AddForce(Vector3.forward*15f*Time.deltaTime, ForceMode.Impulse);
			}
			if (Input.GetKey(KeyCode.S))
			{
				sphereRigdbody.AddForce(Vector3.back*15f * Time.deltaTime, ForceMode.Impulse);
			}
			if (Input.GetKey(KeyCode.A))
			{
				sphereRigdbody.AddForce(Vector3.left*15f * Time.deltaTime, ForceMode.Impulse);
			}
			if (Input.GetKey(KeyCode.D))
			{
				sphereRigdbody.AddForce(Vector3.right*15f * Time.deltaTime, ForceMode.Impulse);
			}
		}
	｝

	//第三种，通过获取水平轴和垂直轴来移动
	public class MoveTest03 : MonoBehaviour {

		public int speed = 5;
		public float H;
		public float V;

		void Update () {
			H = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
			V = Input.GetAxis("Vertical") * Time.deltaTime * speed;
			this.gameObject.transform.Translate(H, 0, V);
		}
	}

	//作者：菜鸟程序猿
	//链接：https://www.jianshu.com/p/12f656c29a36
	//來源：简书
	//著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。

	// roll a ball （unity 官方示例） 中使用的方法
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
```


##### 2.绑定摄像机和物体
1. 在camare中添加以下脚本
``` c#
    public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
```

2. 在 inspector 面板中，寻找添加的脚本文件，然后再将需要跟随的物体拖拽到 player 变量上即可



##### 3.为物体添加碰撞
1. 在 hierarchy 面板中选择碰撞物体，在 inspection 面板中通过 add component 添加 rigidbody 
2. rigidbody 选项： 
	1.  use gravity：是否使用重力系统
	2.  is kinematic ：力学
3. 为碰撞物体添加tag —— 在 inspection 面板中选择 tag--add tag-- new tag 新增即可
4. 在碰撞发生时， OnTriggerEnter 会被调用
5. 碰撞代码示例：
``` c#
	void OnTriggerEnter(Collider other){	// 当碰撞发生时，tag名为"your tag"的会被销毁
		if (other.CompareTag ("your tag")) {
			other.gameObject.SetActive (false);
		}
	}
```

#### 4.camera 与 view
    Q：有时候打开一些Unity3D Demo时，发现主摄像机看到的预览效果与Scene窗口看到的不一致。如果想让Scene中看到的与Main Camera中的一致，怎么办呢？
        步骤一：选中Main Camera.
        步骤二：选择菜单栏[GameObject]->Align View To Select即可。

    Q：如果想让Main Camera中看到的与Scene中的一致，怎么办呢？
        步骤一：选中Main Camera.
        步骤二：选择菜单栏[GameObject]->Align With View即可。

    附：Move To View：移动游戏对象到视图的中心点。
	Align With View：移动游戏对象与视图对齐，将选择的对象自动移动到当前视图并以当前视图为中心进行对齐
        Align View To Select：移动视图与游戏对象对齐，将当前视图对齐到选择的对象，并以游戏对象中心为准进行对齐