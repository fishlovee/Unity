https://unity3d.com/cn/learn/tutorials/topics/interface-essentials/unity-editor-extensions-menu-items?playlist=17117

### 自定义菜单
> unity允许添加自定义的菜单栏——与原生菜单没有任何区别。通过脚本定义静态函数实现自定义菜单功能。

~~~C#
using UnityEngine;
using UnityEditor;
 
public class MenuItemsExample
{
    // Add a new menu item under an existing menu
 
    [MenuItem("Window/New Option")]     // 在window菜单下添加New Option项
    private static void NewMenuOption()
    {
    }
 
    // Add a menu item with multiple levels of nesting  // 添加嵌套菜单
    [MenuItem("Tools/SubMenu/Option")]
    private static void NewNestedOption()
    {
    }
}
~~~

### 自定义热键
> unity允许将自定义的热键与自定义菜单绑定
* % – CTRL on Windows / CMD on OSX
* \# – Shift
* & – Alt
* LEFT/RIGHT/UP/DOWN – Arrow keys
* F1…F2 – F keys
* HOME, END, PGUP, PGDN

```C#
// Add a new menu item with hotkey CTRL-SHIFT-A

// ctrl + shift + a
[MenuItem("Tools/New Option %#a")]
private static void NewMenuOption()
{
}
 

// ctrl + g
// Add a new menu item with hotkey CTRL-G
[MenuItem("Tools/Item %g")]
private static void NewNestedOption()
{
}
 
// 大写G
// Add a new menu item with hotkey G
[MenuItem("Tools/Item2 _g")]
private static void NewOptionWithHotkey()
{
}
```