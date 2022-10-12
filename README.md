# Kogane Random Utils

乱数に関する汎用的な関数を管理するクラス

## 使用例

```cs
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private void Start()
    {
        // 半径 1 の円の内部のランダムな点
        Debug.Log( RandomUtils.InsideUnitCircle );

        // 半径 1 の球体の内部のランダムな点
        Debug.Log( RandomUtils.InsideUnitSphere );

        // 半径 1 の球体の表面上にランダムな点
        Debug.Log( RandomUtils.OnUnitSphere );

        // ランダムな Quaternion 型の値
        Debug.Log( RandomUtils.Rotation );

        // ランダムな Quaternion 型の値
        Debug.Log( RandomUtils.RotationUniform );

        // 0.0 から 1.0 の間の浮動小数点数
        Debug.Log( RandomUtils.Between0And1 );

        // false か true
        Debug.Log( RandomUtils.FalseOrTrue );

        // 0 か 1
        Debug.Log( RandomUtils.Value0Or1 );

        var list = new[] { 1, 2, 3 };

        // 指定されたリストの中からランダムに要素を取得
        Debug.Log( RandomUtils.RandomAt( list ) );
        Debug.Log( RandomUtils.RandomAt( 1, 2, 3 ) );

        // min から max - 1 の間の int 値
        Debug.Log( RandomUtils.Range( 100 ) );
        Debug.Log( RandomUtils.Range( 0, 100 ) );

        // min から max - 1 の間の byte 値
        Debug.Log( RandomUtils.RangeByte( 100 ) );
        Debug.Log( RandomUtils.RangeByte( 0, 100 ) );

        // min から max - 1 の間の short 値
        Debug.Log( RandomUtils.RangeUshort( 100 ) );
        Debug.Log( RandomUtils.RangeUshort( 0, 100 ) );

        // min から max - 1 の間の ushort 値
        Debug.Log( RandomUtils.RangeShort( 100 ) );
        Debug.Log( RandomUtils.RangeShort( 0, 100 ) );

        // min から max - 1 の間の uint 値
        Debug.Log( RandomUtils.RangeUint( 100 ) );
        Debug.Log( RandomUtils.RangeUint( 0, 100 ) );

        // min から max - 1 の間の long 値
        Debug.Log( RandomUtils.RangeLong( 100 ) );
        Debug.Log( RandomUtils.RangeLong( 0, 100 ) );

        // min から max - 1 の間の ulong 値
        Debug.Log( RandomUtils.RangeUlong( 100 ) );
        Debug.Log( RandomUtils.RangeUlong( 0, 100 ) );
    }
}
```
