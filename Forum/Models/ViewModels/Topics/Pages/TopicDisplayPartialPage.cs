﻿using System.Collections.Generic;

namespace Forum.Models.ViewModels.Topics.Pages {
	public class TopicDisplayPartialPage {
		public long Latest { get; set; }
		public List<Messages.DisplayMessage> Messages { get; set; }
	}
}
