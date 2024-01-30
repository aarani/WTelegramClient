using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WTelegram; // for GetValueOrDefault

namespace TL
{
	public static class Extensions
	{
		private class CollectorPeer : Peer
		{
			public override long ID => 0;
			internal IDictionary<long, User> _users;
			internal IDictionary<long, ChatBase> _chats;
			protected internal override IPeerInfo UserOrChat(Dictionary<long, User> users, Dictionary<long, ChatBase> chats)
			{
				if (_users != null)
					lock (_users)
						foreach (var user in users.Values)
							if (user != null)
								if (!user.flags.HasFlag(User.Flags.min) || !_users.TryGetValue(user.id, out var prevUser) || prevUser.flags.HasFlag(User.Flags.min))
									_users[user.id] = user;
				if (_chats != null)
					lock (_chats)
						foreach (var kvp in chats)
							if (kvp.Value is not Channel channel)
								_chats[kvp.Key] = kvp.Value;
							else if (!channel.flags.HasFlag(Channel.Flags.min) || !_chats.TryGetValue(channel.id, out var prevChat) || prevChat is not Channel prevChannel || prevChannel.flags.HasFlag(Channel.Flags.min))
								_chats[kvp.Key] = channel;
				return null;
			}
		}

		/// <summary>Accumulate users/chats found in this structure in your dictionaries, ignoring <see href="https://core.telegram.org/api/min">Min constructors</see> when the full object is already stored</summary>
		/// <param name="structure">The structure having a <c>users</c></param>
		public static void CollectUsersChats(this IPeerResolver structure, IDictionary<long, User> users, IDictionary<long, ChatBase> chats)
			=>  structure.UserOrChat(new CollectorPeer { _users = users, _chats = chats });
	}
}
