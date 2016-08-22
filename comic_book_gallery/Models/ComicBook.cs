﻿using System;
namespace comic_book_gallery
{
	public class ComicBook
	{
		public int Id { get; set; }
		public string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public string DescriptionHtml { get; set; }
		public Artist[] Artists { get; set; }
		public bool Favorite { get; set; }

		public ComicBook()
		{
			
		}
	}
}

