using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 服务器仿真，主要行为
 * 1. 根据规则创建房间
 * 2. 创建房间池，生成房号并允许根据房号加入房间
 * 3. 判断玩家状态，房间满后不允许再入座，坐满后开局
 * 4. 打满创建规则指定局数后解散房间或者允许主动请求解散房间（所有人都同意）
 * 5. 玩家入座后自动准备，每局统计玩家输赢
 */

public class MainServer
{
}
