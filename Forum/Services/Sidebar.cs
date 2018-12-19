﻿using Forum.Repositories;

namespace Forum.Services {
	using ViewModels = Models.ViewModels;

	public class Sidebar {
		AccountRepository AccountRepository { get; }
		NotificationRepository NotificationRepository { get; }
		QuoteRepository QuoteRepository { get; }

		public Sidebar(
			AccountRepository accountRepository,
			NotificationRepository notificationRepository,
			QuoteRepository quoteRepository
		) {
			AccountRepository = accountRepository;
			NotificationRepository = notificationRepository;
			QuoteRepository = quoteRepository;
		}

		public ViewModels.Sidebar.Sidebar Generate() {
			var sidebar = new ViewModels.Sidebar.Sidebar {
				Quote = QuoteRepository.Get(),
				OnlineUsers = AccountRepository.GetOnlineList(),
				Notifications = NotificationRepository.Index()
			};

			return sidebar;
		}
	}
}
