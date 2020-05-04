using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UniRandomUtils
{
	/// <summary>
	/// 乱数に関する汎用的な関数を管理するクラス
	/// </summary>
	public static class RandomUtils
	{
		//================================================================================
		// プロパティ(static)
		//================================================================================
		/// <summary>
		/// 半径 1 の円の内部のランダムな点を返します
		/// </summary>
		public static Vector2 InsideUnitCircle => Random.insideUnitCircle;

		/// <summary>
		/// 半径 1 の球体の内部のランダムな点を返します
		/// </summary>
		public static Vector3 InsideUnitSphere => Random.insideUnitSphere;

		/// <summary>
		/// 半径 1 の球体の表面上にランダムな点を返します
		/// </summary>
		public static Vector3 OnUnitSphere => Random.onUnitSphere;

		/// <summary>
		/// ランダムな Quaternion 型の値を返します
		/// </summary>
		public static Quaternion Rotation => Random.rotation;

		/// <summary>
		/// ランダムな Quaternion 型の値を返します
		/// </summary>
		public static Quaternion RotationUniform => Random.rotationUniform;

		/// <summary>
		/// 0.0 から 1.0 の間の浮動小数点数をランダムに返します
		/// </summary>
		public static float Between0And1 => Random.value;

		/// <summary>
		/// false か true をランダムに返します
		/// </summary>
		public static bool FalseOrTrue => Random.Range( 0, 2 ) == 0;

		/// <summary>
		/// 0 か 1 をランダムに返します
		/// </summary>
		public static byte Value0Or1 => Convert.ToByte( FalseOrTrue );

		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// シード値を指定し、ランダム数生成器の状態を初期化します
		/// </summary>
		public static void InitState( int seed )
		{
			Random.InitState( seed );
		}

		/// <summary>
		/// 指定された配列の中からランダムに要素を返します
		/// </summary>
		public static T RandomAt<T>( params T[] values )
		{
			return values[ Random.Range( 0, values.Length ) ];
		}

		/// <summary>
		/// 指定されたリストの中からランダムに要素を返します
		/// </summary>
		public static T RandomAt<T>( IList<T> values )
		{
			return values[ Random.Range( 0, values.Count ) ];
		}

		/// <summary>
		/// 指定されたリストの中からランダムに要素を返します
		/// </summary>
		public static T RandomAt<T>( IReadOnlyList<T> values )
		{
			return values[ Random.Range( 0, values.Count ) ];
		}

		/// <summary>
		/// 0 から max - 1 の間の整数をランダムに返します
		/// </summary>
		public static int Range( int max )
		{
			return Random.Range( 0, max );
		}

		/// <summary>
		/// 0 から max - 1 の間の整数をランダムに返します
		/// </summary>
		public static byte RangeByte( byte max )
		{
			return ( byte ) Random.Range( 0, max );
		}

		/// <summary>
		/// 0 から max - 1 の間の整数をランダムに返します
		/// </summary>
		public static ushort RangeUshort( uint max )
		{
			return ( ushort ) Random.Range( 0, ( int ) max );
		}

		/// <summary>
		/// 0 から max - 1 の間の整数をランダムに返します
		/// </summary>
		public static uint RangeUint( uint max )
		{
			return ( uint ) Random.Range( 0, ( int ) max );
		}

		/// <summary>
		/// 0 から max - 1 の間の整数をランダムに返します
		/// </summary>
		public static ulong RangeUlong( ulong max )
		{
			return ( ulong ) Random.Range( 0, ( int ) max );
		}

		/// <summary>
		/// min から max - 1 の間の整数をランダムに返します
		/// </summary>
		public static int Range( int min, int max )
		{
			return Random.Range( min, max );
		}

		/// <summary>
		/// min から max の間の浮動小数点数をランダムに返します
		/// </summary>
		public static float Range( float min, float max )
		{
			return Random.Range( min, max );
		}
	}
}