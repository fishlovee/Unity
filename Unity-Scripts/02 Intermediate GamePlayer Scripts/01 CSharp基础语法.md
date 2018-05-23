#### 属性
```C#
public class CTest{
    private int level;
    public int Level{
        get{return level;}
        set{level = value;}
    }
}
```

#### 三目运算
```C#
public class CTest{
    private int level;
    private string target;
    public void Level{
        target = level < 10 ? "基础场":"高级场";
    }
}
```

#### 静态变量
1. 一个类，只有一个该静态变量的实体，所有类的实例都共享一个静态变量的实体。
2. 静态函数只属于类，不能访问类的非静态成员
3. 静态类不可以实例化，仅包含静态成员，不能包含实例构造函数，优点在于编译器能够执行检查以确保不致偶然地添加实例成员，编译器将保证不会创建此类的实例。静态类的另一个特征在于，C#编译器会自动把它标记为sealed，不可扩展。
