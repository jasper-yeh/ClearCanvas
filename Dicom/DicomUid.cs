#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using JetBrains.Annotations;

namespace ClearCanvas.Dicom
{
	/// <summary>
	/// Enumerated value for the various types of DICOM UIDs.
	/// </summary>
	public enum UidType
	{
		// ReSharper disable InconsistentNaming

		TransferSyntax,
		SOPClass,
		MetaSOPClass,
		SOPInstance,
		ApplicationContextName,
		CodingScheme,
		SynchronizationFrameOfReference,
		Unknown

		// ReSharper restore InconsistentNaming
	}

	/// <summary>
	/// Class used to represent a DICOM unique identifier (UID).
	/// </summary>
	public class DicomUid
	{
		#region Private Members

		private readonly string _uid;
		private readonly string _description;
		private readonly UidType _type;

		#endregion

		#region Constructors

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="uid">The UID string.</param>
		/// <param name="desc">A description of the UID.</param>
		/// <param name="type">The type of the UID.</param>
		public DicomUid(string uid, string desc, UidType type)
		{
			if (uid.Length > 64)
				throw new DicomException("Invalid UID length: " + uid.Length + "!");

			_uid = uid;
			_description = desc;
			_type = type;
		}

		#endregion

		#region Public Properties

		/// <summary>
		/// The string representation of the UID.
		/// </summary>
		public string UID
		{
			get { return _uid; }
		}

		/// <summary>
		/// A description of the UID.
		/// </summary>
		public string Description
		{
			get { return _description; }
		}

		/// <summary>
		/// The type of the UID.
		/// </summary>
		public UidType Type
		{
			get { return _type; }
		}

		#endregion

		/// <summary>
		/// Override that displays the type of the UID if known, or else the UID value itself.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if (Type == UidType.Unknown)
				return UID;
			return "==" + Description;
		}

		/// <summary>
		/// Override that compares if two DicomUid instances are equal.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			var uid = obj as DicomUid;
			if (uid != null)
				return uid.UID.Equals(UID);

			var value = obj as String;
			if (value != null)
				return value == UID;

			return false;
		}

		/// <summary>
		/// An override that determines a hash code for the instance.
		/// </summary>
		/// <returns>The hash code of the UID string.</returns>
		public override int GetHashCode()
		{
			return _uid.GetHashCode();
		}

		#region Static UID Generation Routines

		/* members for UID Generation */
		private static String _lastTimestamp;
		private static String _baseUid = null;
		private static readonly Object _lock = new object();
		private static short _count = 0;

		/// <summary>
		/// This routine generates a DICOM Unique Identifier.  Note, this UID is NOT unique for UIDs generated in the same process across App Domains.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The UID generator uses the ClearCanvas UID base, the computers MAC address, a timestamp,
		/// a process ID, and a counter to ensure uniqueness for the UID.  The UID has the following
		/// components:
		/// </para>
		/// <list type="table">
		///   <listheader>
		///     <term>UID Component</term>
		/// <description>Description</description>
		///   </listheader>
		/// <item>
		///   <term> 1.3.6.1.4.1.25403 </term>
		///   <description>
		///   The ClearCanvas assigned UID root.  This root has been assigned to ClearCanvas by IANA.  This
		///   component uses 17 characters.
		///   </description>
		/// </item>
		/// <item>
		///   <term>MAC Address (.NNNNNNNNNNNNNNN)</term>
		///   <description>
		///   The 6 bytes encoded in the network card's MAC address are masked into an unsigned long, and then 
		///   added as decimal to the UID.  This component guarentees that the UID is
		///   unique to the computer that it is running on.  This component uses 16 characters.
		///   </description>
		/// </item>
		/// <item>
		///   <term> Process ID (.NNNNNNNNNN)</term>
		///   <description>
		///   The process ID of the process creating the UID.  This component along with the timestamp guarentee
		///   that the UID is unique to the specific process that is generating it.  This component has a maximum
		///   of 11 chracters.
		///   </description>
		/// </item>
		/// <item>
		///   <term> Time Stamp (.YYYYMMDDhhmmss) </term>
		///   <description>
		///   The timestamp contains The year/month/day/hour/minute/second that the UID was created.  This
		///   component uses 15 characters.
		///   </description>
		/// </item>
		/// <item>
		///   <term> Counter (.NNNN)</term>
		///   <description>
		///   The counter is used in case more than one UID is generated within a second.  This component has a 
		///   maximum of 5 characters.
		///   </description>
		/// </item>
		/// </list>
		/// <para>
		/// The UID generator uses the above components to insure uniqueness.  The use of the MAC address ensures that 
		/// the UID is unique to the system that the generator is run on.  The use of a timestamp and process ID ensures 
		/// that the Uid is unique to a specific process, and the counter ensures that if more than one Uid is generated
		/// within a second by a process, that it is unique.
		/// </para>
		/// <para>
		/// Note that the definition of the components of the Uid may allow the Uid to reach the maximum length of 
		/// 64 characters, although it is unlikely this will ever happen.
		/// </para>
		/// </remarks>
		/// <returns></returns>
		[UsedImplicitly]
		private static DicomUid ObsoleteGenerateUid()
		{
			lock (_lock)
			{
				if (_baseUid == null)
				{
					NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
					if (nics.Length == 0)
						throw new DicomException("No network cards in system, unable to generate UID");

					byte[] addressBytes = nics[0].GetPhysicalAddress().GetAddressBytes();

					if (addressBytes.Length > 6)
						throw new DicomException("Unexpected length for MAC address, unable to generate a UID");

					ulong address = 0;

					foreach (byte b in addressBytes)
					{
						address <<= 8;
						address |= b;
					}

					var sb = new StringBuilder();

					// ClearCanvas root from IANA
					sb.Append("1.3.6.1.4.1.25403");

					// MAC address converted to decimal
					sb.AppendFormat(".{0}", address);

					// Process Id
					sb.AppendFormat(".{0}", (uint) Process.GetCurrentProcess().Id);

					_baseUid = sb.ToString();

					_lastTimestamp = DateTime.Now.ToString("yyyyMMddhhmmss");
				}

				var uid = new StringBuilder();
				uid.Append(_baseUid);

				String time = DateTime.Now.ToString("yyyyMMddhhmmss");
				if (time.Equals(_lastTimestamp))
				{
					if (_count == 9999)
						throw new DicomException("Unexpected count reached max value in UID generator!");

					_count++;
				}
				else
				{
					_count = 1;
					_lastTimestamp = time;
				}

				uid.AppendFormat(".{0}.{1}", time, _count);

				return new DicomUid(uid.ToString(), "Instance UID", UidType.SOPInstance);
			}
		}

		/// <summary>
		/// This routine generates a DICOM Unique Identifier.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The UID generator uses a GUID to generate the UID, as descriped in DICOM CP-1156:
		///
		/// ftp://medical.nema.org/medical/dicom/final/cp1156_ft.pdf
		/// 
		/// The UID is composed of the following components:
		/// </para>
		/// <list type="table">
		///   <listheader>
		///     <term>UID Component</term> <description>Description</description>
		///   </listheader>
		/// <item>
		///   <term> 2.25 </term>
		///   <description>
		///   The UID root for GUID UIDs as per CP-1156.
		///   </description>
		/// </item>
		/// <item>
		///   <term>GUID as Integer</term>
		///   <description>
		///   The GUID is converted to an integer and displayed in base 10, which can be up to 39 characters long.
		///   </description>
		/// </item>
		/// </list>
		/// <para>
		/// The UID generator uses the above components to ensure uniqueness.  It simply converts a GUID acquired by a 
		/// call to <see cref="Guid.NewGuid"/> into an integer and appends it to the UID for uniqueness.
		/// </para>
		/// </remarks>
		/// <returns></returns>
		public static DicomUid GenerateUid()
		{
			return new DicomUid("2.25." + FormatGuidAsString(Guid.NewGuid()), "Instance UID", UidType.SOPInstance);
		}

#if UNIT_TESTS
		internal static string ConvertGuid(Guid guid)
		{
			return FormatGuidAsString(guid);
		}
#endif

		/// <summary>
		/// Converts the 128-bits of a GUID into a byte stream of 4x 32-bit words, respecting the system endianess so that
		/// the MSB of the GUID is the MSB of the first word, and LSB of the GUID is the LSB of the last word.
		/// </summary>
		private static byte[] GuidToSystemEndianBytes(Guid guid)
		{
			var bytes = guid.ToByteArray();

			// our conversion algorithm uses 4x 32-bit unsigned ints in most-to-least significant word order
			//   (4 system endian) (4 system endian) (4 system endian) (4 system endian)
			// but .NET GUIDs are broken up into parts and separately encoded with first 3 in system endian and last 2 in big endian
			//   (4 system endian)-(2 system endian)-(2 system endian)-(2 big endian)-(6 big endian)
			//
			// if system is little endian, we byte-swap here to build the 4 little endian words in the correct order
			//
			// if system is big endian, the bytes are already big endian and most-to-least significant word order
			// so no swapping is necessary (and all the calculations will be done in big endian anyway)
			if (BitConverter.IsLittleEndian)
			{
				var t = bytes[4];
				bytes[4] = bytes[6];
				bytes[6] = t;

				t = bytes[5];
				bytes[5] = bytes[7];
				bytes[7] = t;

				t = bytes[8];
				bytes[8] = bytes[11];
				bytes[11] = t;

				t = bytes[9];
				bytes[9] = bytes[10];
				bytes[10] = t;

				t = bytes[12];
				bytes[12] = bytes[15];
				bytes[15] = t;

				t = bytes[13];
				bytes[13] = bytes[14];
				bytes[14] = t;
			}

			return bytes;
		}

		/// <summary>
		/// Formats a GUID as a big decimal string of digits.
		/// </summary>
		private static unsafe string FormatGuidAsString(Guid guid)
		{
			// the conversion is based on the pen-and-paper algorithm for converting between bases:
			// 1. divide input by base, remainder is least significant output digit.
			// 2. divide quotient by base, remainder is next least significant output digit.
			// 3. repeat until quotient is zero.
			// 
			// however, we are unable to write normal arirthmetic operations here because the operands are 128-bits, and we can do at best 64-bits!
			// the solution is to do "long division", i.e. division in smaller, manageable units, and carry over the remainder to lower places
			// we choose to break the number into 32-bits at a time, so that we can use 64-bit arirthmetic to accomodate each part plus the carry over
			// put another way, we are "rewriting" the 128-bit number as a 4-digit base 2^32 number
			//
			// thus, our long division algorithm now looks like this:
			// A. divide the most significant word by base, quotient is most significant word of overall quotient
			// B. divide the number (remainder * word base + next most significant word) by base, quotient is next most significant word of overall quotient
			// C. repeat until least significant word, where the remainder is simply the overall remainder
			//
			// the resulting algorithm is perhaps more convoluted than if we were to divide one byte at a time, but this does make it more efficient since
			// we are leveraging the CPU's native 32/64-bit binary base for arithmetic
			//
			// NOTE: The simpler algorithm for converting between bases is to start from the most significant digit, multiply by base, add next most
			// significant digit, multiply all that by base, and so on until you finish the sequence of digits. This does not work for us, because the
			// result of each stage is exponentially increasing, and you will quickly exceed the capabilities of native CPU arithmetic.

			// convert the 128-bits of the GUID to 4x 32-bit unsigned ints
			var bytes = GuidToSystemEndianBytes(guid);

			// allocate space for the string - we know it's at most 39 decimal digits
			const int maxDigits = 39;
			var chars = new char[maxDigits];

			fixed (char* pChars = chars)
			fixed (byte* pBytes = bytes)
			{
				// algorithm produces least significant digit first, so we set digits from the end of the string, and keep track of how many digits
				var countDigits = 0;
				var pC = &pChars[maxDigits - 1];

				// casts the bytes to a uint pointer, since we've rearranged the GUID as such
				var pB = (uint*) pBytes;
				do
				{
					// take the first word, divide by 10, and keep the quotient for the next round of calculations
					ulong r = pB[0];
					ulong q = r/10;
					pB[0] = (uint) q;

					// the remainder (i.e. r - q*10) is prepended to the second word as the most significant digit
					// and then divide by 10, and keep the quotient for the next round of calculations
					r = ((r - q*10) << 32) + pB[1];
					q = r/10;
					pB[1] = (uint) q;

					// the remainder is prepended to the third word as the most significant digit
					// and then divide by 10, and keep the quotient for the next round of calculations
					r = ((r - q*10) << 32) + pB[2];
					q = r/10;
					pB[2] = (uint) q;

					// the remainder is prepended to the fourth word as the most significant digit
					// and then divide by 10, and keep the quotient for the next round of calculations
					r = ((r - q*10) << 32) + pB[3];
					q = r/10;
					pB[3] = (uint) q;

					// the remainder is the next decimal digit in the result
					r = r - q*10;

					// the digits are yielded from least to most significant, so we fill the char array from the end
					*pC-- = (char) ('0' + r); // '0'+r being a way of converting a number between 0 and 9 to the equivalent character '0' to '9'

					// and keep track of how many digits that is
					++countDigits;

					// when the dividend for the next round of calculations is 0 (i.e. all words are 0), we are done
				} while (pB[0] != 0 || pB[1] != 0 || pB[2] != 0 || pB[3] != 0);

				// now return a string based on the pointer and offset based on number of digits we actually produced
				// note that the loop always produces at least one digit, even if that is '0'
				return new string(pChars, maxDigits - countDigits, countDigits);
			}
		}

		#endregion
	}

	public static partial class DicomUids
	{
		public static readonly Dictionary<string, DicomUid> Entries;

		static DicomUids()
		{
			Entries = EnumerateDicomUids().ToDictionary(x => x.UID);
		}

		public static DicomUid Lookup(string uid)
		{
			DicomUid o;
			Entries.TryGetValue(uid, out o);
			return o ?? (new DicomUid(uid, "Unknown UID", UidType.Unknown));
		}
	}
}