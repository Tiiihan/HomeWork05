﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork05._2
{
	internal class InvalidUserInput : Exception
	{
		public InvalidUserInput(string message) : base(message)
		{ } 
	}
}
