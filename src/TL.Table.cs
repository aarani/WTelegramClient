using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using TL.Methods;

namespace TL
{
	public static class Layer
	{
		public const int Version = 167;					// fetched 30/11/2023 15:07:08
		internal const int SecretChats = 144;
		internal const int MTProto2 = 73;
		internal const uint VectorCtor = 0x1CB5C415;
		internal const uint NullCtor = 0x56730BCC;
		internal const uint RpcResultCtor = 0xF35C6D01;
		internal const uint RpcErrorCtor = 0x2144CA19;
		internal const uint MsgContainerCtor = 0x73F1F8DC;
		internal const uint BadMsgCtor = 0xA7EFF811;
		internal const uint GZipedCtor = 0x3072CFA1;

		public readonly static Dictionary<uint, Type> Table =
			(from t in Assembly.GetExecutingAssembly().GetTypes()
			where t.IsClass && t.Namespace != null && t.Namespace.StartsWith("TL")
			where t.GetInterfaces().Contains(typeof(IObject))
			where t.GetCustomAttribute(typeof(TLDefAttribute)) != null
			select t).ToDictionary(x => ((TLDefAttribute)x.GetCustomAttribute(typeof(TLDefAttribute))).CtorNb, x => x);

		internal readonly static Dictionary<Type, uint> Nullables = new()
		{
			// from TL.MTProto:
			// from TL.Schema:
			[typeof(Null)]                           = 0x56730BCC, //null
			[typeof(InputPeer)]                      = 0x7F3B18EA, //inputPeerEmpty
			[typeof(InputUserBase)]                  = 0xB98886CF, //inputUserEmpty
			[typeof(InputMedia)]                     = 0x9664F57F, //inputMediaEmpty
			[typeof(InputChatPhotoBase)]             = 0x1CA48F57, //inputChatPhotoEmpty
			[typeof(InputGeoPoint)]                  = 0xE4C123D6, //inputGeoPointEmpty
			[typeof(InputPhoto)]                     = 0x1CD7BF0D, //inputPhotoEmpty
			[typeof(UserProfilePhoto)]               = 0x4F11BAE1, //userProfilePhotoEmpty
			[typeof(UserStatus)]                     = 0x09D05049, //userStatusEmpty
			[typeof(ChatPhoto)]                      = 0x37C1011C, //chatPhotoEmpty
			[typeof(MessageMedia)]                   = 0x3DED6320, //messageMediaEmpty
			[typeof(MessageAction)]                  = 0xB6AEF7B0, //messageActionEmpty
			[typeof(GeoPoint)]                       = 0x1117DD5F, //geoPointEmpty
			[typeof(Contacts_Contacts)]              = 0xB74BA9D2, //contacts.contactsNotModified
			[typeof(MessagesFilter)]                 = 0x57E2F66C, //inputMessagesFilterEmpty
			[typeof(Help_AppUpdate)]                 = 0xC45A6536, //help.noAppUpdate
			[typeof(EncryptedFile)]                  = 0xC21F497E, //encryptedFileEmpty
			[typeof(InputEncryptedFileBase)]         = 0x1837C364, //inputEncryptedFileEmpty
			[typeof(InputDocument)]                  = 0x72F0EAAE, //inputDocumentEmpty
			[typeof(Messages_Stickers)]              = 0xF1749A22, //messages.stickersNotModified
			[typeof(Messages_AllStickers)]           = 0xE86602C3, //messages.allStickersNotModified
			[typeof(InputStickerSet)]                = 0xFFB62B95, //inputStickerSetEmpty
			[typeof(Messages_StickerSet)]            = 0xD3F924EB, //messages.stickerSetNotModified
			[typeof(InputChannelBase)]               = 0xEE8C1E86, //inputChannelEmpty
			[typeof(ChannelMessagesFilter)]          = 0x94D42EE7, //channelMessagesFilterEmpty
			[typeof(Channels_ChannelParticipants)]   = 0xF0173FE9, //channels.channelParticipantsNotModified
			[typeof(Messages_SavedGifs)]             = 0xE8025CA2, //messages.savedGifsNotModified
			[typeof(Contacts_TopPeersBase)]          = 0xDE266EF5, //contacts.topPeersNotModified
			[typeof(Messages_RecentStickers)]        = 0x0B17F890, //messages.recentStickersNotModified
			[typeof(RichText)]                       = 0xDC3D824F, //textEmpty
			[typeof(Messages_FavedStickers)]         = 0x9E8FA6D3, //messages.favedStickersNotModified
			[typeof(Messages_FoundStickerSets)]      = 0x0D54B65D, //messages.foundStickerSetsNotModified
			[typeof(SecureFile)]                     = 0x64199744, //secureFileEmpty
			[typeof(Help_DeepLinkInfo)]              = 0x66AFA166, //help.deepLinkInfoEmpty
			[typeof(PasswordKdfAlgo)]                = 0xD45AB096, //passwordKdfAlgoUnknown
			[typeof(SecurePasswordKdfAlgo)]          = 0x004A8537, //securePasswordKdfAlgoUnknown
			[typeof(InputCheckPasswordSRP)]          = 0x9880F658, //inputCheckPasswordEmpty
			[typeof(Help_PassportConfig)]            = 0xBFB9F457, //help.passportConfigNotModified
			[typeof(Help_UserInfo)]                  = 0xF3AE2EED, //help.userInfoEmpty
			[typeof(Account_WallPapers)]             = 0x1C199183, //account.wallPapersNotModified
			[typeof(UrlAuthResult)]                  = 0xA9D6DB1F, //urlAuthResultDefault
			[typeof(ChannelLocation)]                = 0xBFB5AD8B, //channelLocationEmpty
			[typeof(Account_Themes)]                 = 0xF41EB622, //account.themesNotModified
			[typeof(DialogFilter)]                   = 0x363293AE, //dialogFilterDefault
			[typeof(Help_CountriesList)]             = 0x93CC1F32, //help.countriesListNotModified
			[typeof(BotCommandScope)]                = 0x2F6CB2AB, //botCommandScopeDefault
			[typeof(Messages_SponsoredMessages)]     = 0x1839490F, //messages.sponsoredMessagesEmpty
			[typeof(Messages_AvailableReactions)]    = 0x9F071957, //messages.availableReactionsNotModified
			[typeof(AttachMenuBots)]                 = 0xF1D88A5C, //attachMenuBotsNotModified
			[typeof(BotMenuButtonBase)]              = 0x7533A588, //botMenuButtonDefault
			[typeof(Account_SavedRingtones)]         = 0xFBF6E8B1, //account.savedRingtonesNotModified
			[typeof(NotificationSound)]              = 0x97E8BEBE, //notificationSoundDefault
			[typeof(EmojiStatus)]                    = 0x2DE11AAE, //emojiStatusEmpty
			[typeof(Account_EmojiStatuses)]          = 0xD08CE645, //account.emojiStatusesNotModified
			[typeof(Reaction)]                       = 0x79F5D419, //reactionEmpty
			[typeof(ChatReactions)]                  = 0xEAFC32BC, //chatReactionsNone
			[typeof(Messages_Reactions)]             = 0xB06FDBDF, //messages.reactionsNotModified
			// from TL.Secret:
			[typeof(DialogFilterBase)]               = 0x363293AE, //dialogFilterDefault
			[typeof(EmojiList)]                      = 0x481EADFA, //emojiListNotModified
			[typeof(Messages_EmojiGroups)]           = 0x6FB4AD87, //messages.emojiGroupsNotModified
			[typeof(Help_AppConfig)]                 = 0x7CDE641D, //help.appConfigNotModified
			[typeof(BotApp)]                         = 0x5DA674B7, //botAppNotModified
			[typeof(Help_PeerColors)]                = 0x2BA1F5CE, //help.peerColorsNotModified
			[typeof(DecryptedMessageMedia)]          = 0x089F5C4A, //decryptedMessageMediaEmpty
		};
	}
}
