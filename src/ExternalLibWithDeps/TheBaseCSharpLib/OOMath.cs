//using System;
//using System.Runtime.InteropServices;

//namespace TheBaseCSharpLib
//{
//    /// <summary>
//    /// This class demonstrates an approach to usage of c++ objects via c# interop
//    /// </summary>
//    public class OOMath : IDisposable
//    {
//        /// <summary>
//        /// This is the pointer to our unmanaged cpp object
//        /// </summary>
//        private IntPtr _Ptr;

//        public OOMath()
//        {
//            _Ptr = MathObjectConstructor();
//        }

//        public int GetCount()
//        {
//            return MathObject_GetCount(_Ptr);
//        }

//        /// <summary>
//        /// Since our cpp class is unmanaged, we need to make sure its destructed whenever this class is disposed.
//        /// </summary>
//        public void Dispose()
//        {
//            if (_Ptr != null)
//            {
//                MathObjectDestructor(_Ptr);
//            }
//        }

//        static OOMath()
//        {
//            DLLRegister.RegisterNativePath();
//        }


//        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
//        private static extern IntPtr MathObjectConstructor();


//        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
//        private static extern void MathObjectDestructor(IntPtr ptr);


//        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
//        private static extern int MathObject_GetCount(IntPtr ptr);


//        [DllImport("TheCPlusPlusLib.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
//        private static extern void MathObject_Add(IntPtr ptr, int number);
//    }
//}
