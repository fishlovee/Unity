> awake 和 start 都是在脚本被加载的时候被调用。它们都只会被调用一次，即使你通过disable然后再enable脚本组件，awake和start也不会再被调用。

**awake**
> awake 优先被调用，即使脚本组件没有被激活（awake只需要挂载到游戏对象上就会被调用），一般被用于脚本加载与初始之间的设置。  
> awake is called first even if the script componet is not enabled and is best used for setting up any references between scripts and initiallisation.

**start**
> 只有在脚本组件本激活后，start才会在 awake 之后立即调用（start在脚本挂载到游戏对象后，如果脚本被disable，则不会被调用）。它可以让你延迟初始化代码，直到你真正的需要时。
> start is called immediatly after awake before the first update but only if the script componets is enabled.this means you can use start for anything you 
> need to occur when the script componet is enabled.This allows you to delay any part of your initialisation code until it is really needed.

