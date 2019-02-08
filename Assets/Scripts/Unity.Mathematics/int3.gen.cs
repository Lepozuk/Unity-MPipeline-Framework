// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(int3.DebuggerProxy))]
    [System.Serializable]
    public partial struct int3 : System.IEquatable<int3>, IFormattable
    {
        public int x;
        public int y;
        public int z;

        /// <summary>int3 zero value.</summary>
        public static readonly int3 zero;

        /// <summary>Constructs a int3 vector from three int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int x, int y, int z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a int3 vector from an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int x, int2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a int3 vector from an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int2 xy, int z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a int3 vector from an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a int3 vector from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a int3 vector from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(bool v)
        {
            this.x = v ? 1 : 0;
            this.y = v ? 1 : 0;
            this.z = v ? 1 : 0;
        }

        /// <summary>Constructs a int3 vector from a bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(bool3 v)
        {
            this.x = v.x ? 1 : 0;
            this.y = v.y ? 1 : 0;
            this.z = v.z ? 1 : 0;
        }

        /// <summary>Constructs a int3 vector from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(uint v)
        {
            this.x = (int)v;
            this.y = (int)v;
            this.z = (int)v;
        }

        /// <summary>Constructs a int3 vector from a uint3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(uint3 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
            this.z = (int)v.z;
        }

        /// <summary>Constructs a int3 vector from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(float v)
        {
            this.x = (int)v;
            this.y = (int)v;
            this.z = (int)v;
        }

        /// <summary>Constructs a int3 vector from a float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(float3 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
            this.z = (int)v.z;
        }

        /// <summary>Constructs a int3 vector from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(double v)
        {
            this.x = (int)v;
            this.y = (int)v;
            this.z = (int)v;
        }

        /// <summary>Constructs a int3 vector from a double3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(double3 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
            this.z = (int)v.z;
        }


        /// <summary>Implicitly converts a single int value to a int3 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3(int v) { return new int3(v); }

        /// <summary>Explicitly converts a single bool value to a int3 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(bool v) { return new int3(v); }

        /// <summary>Explicitly converts a bool3 vector to a int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(bool3 v) { return new int3(v); }

        /// <summary>Explicitly converts a single uint value to a int3 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(uint v) { return new int3(v); }

        /// <summary>Explicitly converts a uint3 vector to a int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(uint3 v) { return new int3(v); }

        /// <summary>Explicitly converts a single float value to a int3 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(float v) { return new int3(v); }

        /// <summary>Explicitly converts a float3 vector to a int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(float3 v) { return new int3(v); }

        /// <summary>Explicitly converts a single double value to a int3 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(double v) { return new int3(v); }

        /// <summary>Explicitly converts a double3 vector to a int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(double3 v) { return new int3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator * (int3 lhs, int3 rhs) { return new int3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator * (int3 lhs, int rhs) { return new int3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator * (int lhs, int3 rhs) { return new int3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int3 lhs, int3 rhs) { return new int3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int3 lhs, int rhs) { return new int3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int lhs, int3 rhs) { return new int3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int3 lhs, int3 rhs) { return new int3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int3 lhs, int rhs) { return new int3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int lhs, int3 rhs) { return new int3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator / (int3 lhs, int3 rhs) { return new int3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator / (int3 lhs, int rhs) { return new int3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator / (int lhs, int3 rhs) { return new int3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator % (int3 lhs, int3 rhs) { return new int3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator % (int3 lhs, int rhs) { return new int3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator % (int lhs, int3 rhs) { return new int3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ++ (int3 val) { return new int3 (++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator -- (int3 val) { return new int3 (--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (int3 lhs, int3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (int3 lhs, int rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (int lhs, int3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (int3 lhs, int3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (int3 lhs, int rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (int lhs, int3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (int3 lhs, int3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (int3 lhs, int rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (int lhs, int3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (int3 lhs, int3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (int3 lhs, int rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (int lhs, int3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int3 val) { return new int3 (-val.x, -val.y, -val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int3 val) { return new int3 (+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on an int3 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator << (int3 x, int n) { return new int3 (x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int3 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator >> (int3 x, int n) { return new int3 (x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int3 lhs, int3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int3 lhs, int rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int lhs, int3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int3 lhs, int3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int3 lhs, int rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int lhs, int3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ~ (int3 val) { return new int3 (~val.x, ~val.y, ~val.z); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int3 lhs, int3 rhs) { return new int3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int3 lhs, int rhs) { return new int3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int lhs, int3 rhs) { return new int3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int3 lhs, int3 rhs) { return new int3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int3 lhs, int rhs) { return new int3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int lhs, int3 rhs) { return new int3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int3 lhs, int3 rhs) { return new int3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int3 lhs, int rhs) { return new int3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int lhs, int3 rhs) { return new int3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(z, z); }
        }



        /// <summary>Returns the int element at a specified index.</summary>
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int3* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the int3 is equal to a given int3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the int3 is equal to a given int3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((int3)o); }


        /// <summary>Returns a hash code for the int3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the int3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the int3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public int z;
            public DebuggerProxy(int3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int3 vector constructed from three int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int x, int y, int z) { return new int3(x, y, z); }

        /// <summary>Returns a int3 vector constructed from an int value and an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int x, int2 yz) { return new int3(x, yz); }

        /// <summary>Returns a int3 vector constructed from an int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int2 xy, int z) { return new int3(xy, z); }

        /// <summary>Returns a int3 vector constructed from an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int3 xyz) { return new int3(xyz); }

        /// <summary>Returns a int3 vector constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int v) { return new int3(v); }

        /// <summary>Returns a int3 vector constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(bool v) { return new int3(v); }

        /// <summary>Return a int3 vector constructed from a bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(bool3 v) { return new int3(v); }

        /// <summary>Returns a int3 vector constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(uint v) { return new int3(v); }

        /// <summary>Return a int3 vector constructed from a uint3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(uint3 v) { return new int3(v); }

        /// <summary>Returns a int3 vector constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(float v) { return new int3(v); }

        /// <summary>Return a int3 vector constructed from a float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(float3 v) { return new int3(v); }

        /// <summary>Returns a int3 vector constructed from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(double v) { return new int3(v); }

        /// <summary>Return a int3 vector constructed from a double3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(double3 v) { return new int3(v); }

        /// <summary>Returns a uint hash code of a int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int3 v)
        {
            return csum(asuint(v) * uint3(0x4C7F6DD1u, 0x4822A3E9u, 0xAAC3C25Du)) + 0xD21D0945u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a int3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(int3 v)
        {
            return (asuint(v) * uint3(0x88FCAB2Du, 0x614DA60Du, 0x5BA2C50Bu)) + 0x8C455ACBu;
        }

        /// <summary>Returns the result of specified shuffling of the components from two int3 vectors into an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int shuffle(int3 a, int3 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two int3 vectors into an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 shuffle(int3 a, int3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return int2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two int3 vectors into an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 shuffle(int3 a, int3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return int3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two int3 vectors into an int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 shuffle(int3 a, int3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return int4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int select_shuffle_component(int3 a, int3 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}