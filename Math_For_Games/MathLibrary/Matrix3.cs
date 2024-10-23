using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Matrix3
    {
        public float
            m00, m01, m02,
            m10, m11, m12,
            m20, m21, m22;

        public Matrix3(
            float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
        }

        public static Matrix3 Identity
        {
            get
            {
                return new Matrix3(); 
            }
        }

        public static Matrix3 operator +(Matrix3 a, Matrix3 b) 
        {
        
        }
        public static Matrix3 operator -(Matrix3 a, Matrix3 b) 
        {
        
        }
        public static Matrix3 operator *(Matrix3 a, Matrix3 b)
        {
           
        }
    }
}
