
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
		/// [GL] Value of GL_POLYGON_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_polygon_offset")]
		public const int POLYGON_OFFSET_EXT = 0x8037;

		/// <summary>
		/// [GL] Value of GL_POLYGON_OFFSET_BIAS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_polygon_offset")]
		public const int POLYGON_OFFSET_BIAS_EXT = 0x8039;

		/// <summary>
		/// [GL] Binding for glPolygonOffsetEXT.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="bias">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_polygon_offset")]
		public static void PolygonOffsetEXT(float factor, float bias)
		{
			Debug.Assert(Delegates.pglPolygonOffsetEXT != null, "pglPolygonOffsetEXT not implemented");
			Delegates.pglPolygonOffsetEXT(factor, bias);
			LogCommand("glPolygonOffsetEXT", null, factor, bias			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonOffsetEXT", ExactSpelling = true)]
			internal extern static void glPolygonOffsetEXT(float factor, float bias);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_polygon_offset")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonOffsetEXT(float factor, float bias);

			[RequiredByFeature("GL_EXT_polygon_offset")]
			[ThreadStatic]
			internal static glPolygonOffsetEXT pglPolygonOffsetEXT;

		}
	}

}
