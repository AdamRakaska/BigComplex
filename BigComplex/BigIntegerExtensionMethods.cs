﻿using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ExtendedNumerics.ExtensionMethods
{
	public static class BigIntegerExtensionMethods
	{
		public static BigInteger SquareRoot(this BigInteger number)
		{
			BigInteger input = number;
			if (input.IsZero)
			{
				return new BigInteger(0);
			}
			if (input.Sign == -1)
			{
				input = -input;
			}

			BigInteger n = new BigInteger(0);
			BigInteger p = new BigInteger(0);
			BigInteger low = new BigInteger(0);
			BigInteger high = BigInteger.Abs(input);

			while (high > low + 1)
			{
				n = (high + low) >> 1;
				p = n * n;
				if (input < p)
				{
					high = n;
				}
				else if (input > p)
				{
					low = n;
				}
				else
				{
					break;
				}
			}
			return input == p ? n : low;
		}
	}
}
