﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UploaderSL.MVC
{
	public class ChunkInfo
	{
		public string Filename { get; set; }
		public ChunkSequence Sequence { get; set; }
		public string Hash { get; set; }
	}
}