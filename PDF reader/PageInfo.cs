using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PDF_reader
{
	public class PageInfo
	{
		public Dictionary<Point, Point> RetangleInfo
		{
			get; set;
		}

		public string PicturePath
		{
			get; set;
		}

		public string ColumeNum
		{
			get; set;
		}

		public string ColumeName
		{
			get; set;
		}

		public int RetangelCount
		{
			get; set;
		}


	}
}
