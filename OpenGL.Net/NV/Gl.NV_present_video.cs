
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_FRAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int FRAME_NV = 0x8E26;

		/// <summary>
		/// [GL] Value of GL_FIELDS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int FIELDS_NV = 0x8E27;

		/// <summary>
		/// [GL] Value of GL_CURRENT_TIME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int CURRENT_TIME_NV = 0x8E28;

		/// <summary>
		/// [GL] Value of GL_NUM_FILL_STREAMS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int NUM_FILL_STREAMS_NV = 0x8E29;

		/// <summary>
		/// [GL] Value of GL_PRESENT_TIME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int PRESENT_TIME_NV = 0x8E2A;

		/// <summary>
		/// [GL] Value of GL_PRESENT_DURATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int PRESENT_DURATION_NV = 0x8E2B;

		/// <summary>
		/// [GL] Binding for glPresentFrameKeyedNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="minPresentTime">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="beginPresentTimeId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="presentDurationId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void PresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, UInt32 key0, Int32 target1, UInt32 fill1, UInt32 key1)
		{
			Debug.Assert(Delegates.pglPresentFrameKeyedNV != null, "pglPresentFrameKeyedNV not implemented");
			Delegates.pglPresentFrameKeyedNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
			LogCommand("glPresentFrameKeyedNV", null, video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPresentFrameDualFillNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="minPresentTime">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="beginPresentTimeId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="presentDurationId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target3">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill3">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void PresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, Int32 target1, UInt32 fill1, Int32 target2, UInt32 fill2, Int32 target3, UInt32 fill3)
		{
			Debug.Assert(Delegates.pglPresentFrameDualFillNV != null, "pglPresentFrameDualFillNV not implemented");
			Delegates.pglPresentFrameDualFillNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
			LogCommand("glPresentFrameDualFillNV", null, video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVideoivNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoNV(UInt32 video_slot, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoivNV != null, "pglGetVideoivNV not implemented");
					Delegates.pglGetVideoivNV(video_slot, pname, p_params);
					LogCommand("glGetVideoivNV", null, video_slot, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVideouivNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoNV(UInt32 video_slot, Int32 pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideouivNV != null, "pglGetVideouivNV not implemented");
					Delegates.pglGetVideouivNV(video_slot, pname, p_params);
					LogCommand("glGetVideouivNV", null, video_slot, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVideoi64vNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoNV(UInt32 video_slot, Int32 pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoi64vNV != null, "pglGetVideoi64vNV not implemented");
					Delegates.pglGetVideoi64vNV(video_slot, pname, p_params);
					LogCommand("glGetVideoi64vNV", null, video_slot, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVideoui64vNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoui64vNV(UInt32 video_slot, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoui64vNV != null, "pglGetVideoui64vNV not implemented");
					Delegates.pglGetVideoui64vNV(video_slot, pname, p_params);
					LogCommand("glGetVideoui64vNV", null, video_slot, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPresentFrameKeyedNV", ExactSpelling = true)]
			internal extern static void glPresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, UInt32 key0, Int32 target1, UInt32 fill1, UInt32 key1);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPresentFrameDualFillNV", ExactSpelling = true)]
			internal extern static void glPresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, Int32 target1, UInt32 fill1, Int32 target2, UInt32 fill2, Int32 target3, UInt32 fill3);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVideoivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoivNV(UInt32 video_slot, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVideouivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideouivNV(UInt32 video_slot, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVideoi64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoi64vNV(UInt32 video_slot, Int32 pname, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVideoui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetVideoui64vNV(UInt32 video_slot, Int32 pname, UInt64* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, UInt32 key0, Int32 target1, UInt32 fill1, UInt32 key1);

			[RequiredByFeature("GL_NV_present_video")]
			[ThreadStatic]
			internal static glPresentFrameKeyedNV pglPresentFrameKeyedNV;

			[RequiredByFeature("GL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, Int32 target1, UInt32 fill1, Int32 target2, UInt32 fill2, Int32 target3, UInt32 fill3);

			[RequiredByFeature("GL_NV_present_video")]
			[ThreadStatic]
			internal static glPresentFrameDualFillNV pglPresentFrameDualFillNV;

			[RequiredByFeature("GL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoivNV(UInt32 video_slot, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_NV_present_video")]
			[ThreadStatic]
			internal static glGetVideoivNV pglGetVideoivNV;

			[RequiredByFeature("GL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideouivNV(UInt32 video_slot, Int32 pname, UInt32* @params);

			[RequiredByFeature("GL_NV_present_video")]
			[ThreadStatic]
			internal static glGetVideouivNV pglGetVideouivNV;

			[RequiredByFeature("GL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoi64vNV(UInt32 video_slot, Int32 pname, Int64* @params);

			[RequiredByFeature("GL_NV_present_video")]
			[ThreadStatic]
			internal static glGetVideoi64vNV pglGetVideoi64vNV;

			[RequiredByFeature("GL_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoui64vNV(UInt32 video_slot, Int32 pname, UInt64* @params);

			[RequiredByFeature("GL_NV_present_video")]
			[ThreadStatic]
			internal static glGetVideoui64vNV pglGetVideoui64vNV;

		}
	}

}
