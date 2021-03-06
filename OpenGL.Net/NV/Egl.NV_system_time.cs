
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Binding for eglGetSystemTimeFrequencyNV.
		/// </summary>
		[RequiredByFeature("EGL_NV_system_time")]
		public static UInt64 GetSystemTimeFrequencyNV()
		{
			UInt64 retValue;

			Debug.Assert(Delegates.peglGetSystemTimeFrequencyNV != null, "peglGetSystemTimeFrequencyNV not implemented");
			retValue = Delegates.peglGetSystemTimeFrequencyNV();
			LogCommand("eglGetSystemTimeFrequencyNV", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglGetSystemTimeNV.
		/// </summary>
		[RequiredByFeature("EGL_NV_system_time")]
		public static UInt64 GetSystemTimeNV()
		{
			UInt64 retValue;

			Debug.Assert(Delegates.peglGetSystemTimeNV != null, "peglGetSystemTimeNV not implemented");
			retValue = Delegates.peglGetSystemTimeNV();
			LogCommand("eglGetSystemTimeNV", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglGetSystemTimeFrequencyNV", ExactSpelling = true)]
			internal extern static UInt64 eglGetSystemTimeFrequencyNV();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglGetSystemTimeNV", ExactSpelling = true)]
			internal extern static UInt64 eglGetSystemTimeNV();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_system_time")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 eglGetSystemTimeFrequencyNV();

			[RequiredByFeature("EGL_NV_system_time")]
			internal static eglGetSystemTimeFrequencyNV peglGetSystemTimeFrequencyNV;

			[RequiredByFeature("EGL_NV_system_time")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 eglGetSystemTimeNV();

			[RequiredByFeature("EGL_NV_system_time")]
			internal static eglGetSystemTimeNV peglGetSystemTimeNV;

		}
	}

}
