using System;
using System.Threading.Tasks;
using TL.Methods;

namespace TL.Methods
{
	#pragma warning disable IDE1006
	[TLDef(167,0xCB9F372D)]
	public class InvokeAfterMsg : IMethod
	{
		public long msg_id;
		public IMethod query;
	}

	[TLDef(167,0x3DC4B4F0)]
	public class InvokeAfterMsgs : IMethod
	{
		public long[] msg_ids;
		public IMethod query;
	}

	[TLDef(167,0xC1CD5EA9)]
	public class InitConnection : IMethod
	{
		public Flags flags;
		public int api_id;
		public string device_model;
		public string system_version;
		public string app_version;
		public string system_lang_code;
		public string lang_pack;
		public string lang_code;
		[IfFlag(0)] public InputClientProxy proxy;
		[IfFlag(1)] public JSONValue params_;
		public IMethod query;

		[Flags] public enum Flags : uint
		{
			has_proxy = 0x1,
			has_params = 0x2,
		}
	}

	[TLDef(167,0xDA9B0D0D)]
	public class InvokeWithLayer : IMethod
	{
		public int layer;
		public IMethod query;
	}

	[TLDef(167,0xBF9459B7)]
	public class InvokeWithoutUpdates : IMethod
	{
		public IMethod query;
	}

	[TLDef(167,0x365275F2)]
	public class InvokeWithMessagesRange : IMethod
	{
		public MessageRange range;
		public IMethod query;
	}

	[TLDef(167,0xACA9FD2E)]
	public class InvokeWithTakeout : IMethod
	{
		public long takeout_id;
		public IMethod query;
	}

	[TLDef(167,0xA677244F)]
	public class Auth_SendCode : IMethod
	{
		public string phone_number;
		public int api_id;
		public string api_hash;
		public CodeSettings settings;
	}

	[TLDef(167,0x80EEE427)]
	public class Auth_SignUp : IMethod
	{
		public string phone_number;
		public string phone_code_hash;
		public string first_name;
		public string last_name;
	}

	[TLDef(167,0x8D52A951)]
	public class Auth_SignIn : IMethod
	{
		public Flags flags;
		public string phone_number;
		public string phone_code_hash;
		[IfFlag(0)] public string phone_code;
		[IfFlag(1)] public EmailVerification email_verification;

		[Flags] public enum Flags : uint
		{
			has_phone_code = 0x1,
			has_email_verification = 0x2,
		}
	}

	[TLDef(167,0x3E72BA19)]
	public class Auth_LogOut : IMethod { }

	[TLDef(167,0x9FAB0D1A)]
	public class Auth_ResetAuthorizations : IMethod { }

	[TLDef(167,0xE5BFFFCD)]
	public class Auth_ExportAuthorization : IMethod
	{
		public int dc_id;
	}

	[TLDef(167,0xA57A7DAD)]
	public class Auth_ImportAuthorization : IMethod
	{
		public long id;
		public byte[] bytes;
	}

	[TLDef(167,0xCDD42A05)]
	public class Auth_BindTempAuthKey : IMethod
	{
		public long perm_auth_key_id;
		public long nonce;
		public DateTime expires_at;
		public byte[] encrypted_message;
	}

	[TLDef(167,0x67A3FF2C)]
	public class Auth_ImportBotAuthorization : IMethod
	{
		public int flags;
		public int api_id;
		public string api_hash;
		public string bot_auth_token;
	}

	[TLDef(167,0xD18B4D16)]
	public class Auth_CheckPassword : IMethod
	{
		public InputCheckPasswordSRP password;
	}

	[TLDef(167,0xD897BC66)]
	public class Auth_RequestPasswordRecovery : IMethod { }

	[TLDef(167,0x37096C70)]
	public class Auth_RecoverPassword : IMethod
	{
		public Flags flags;
		public string code;
		[IfFlag(0)] public Account_PasswordInputSettings new_settings;

		[Flags] public enum Flags : uint
		{
			has_new_settings = 0x1,
		}
	}

	[TLDef(167,0x3EF1A9BF)]
	public class Auth_ResendCode : IMethod
	{
		public string phone_number;
		public string phone_code_hash;
	}

	[TLDef(167,0x1F040578)]
	public class Auth_CancelCode : IMethod
	{
		public string phone_number;
		public string phone_code_hash;
	}

	[TLDef(167,0x8E48A188)]
	public class Auth_DropTempAuthKeys : IMethod
	{
		public long[] except_auth_keys;
	}

	[TLDef(167,0xB7E085FE)]
	public class Auth_ExportLoginToken : IMethod
	{
		public int api_id;
		public string api_hash;
		public long[] except_ids;
	}

	[TLDef(167,0x95AC5CE4)]
	public class Auth_ImportLoginToken : IMethod
	{
		public byte[] token;
	}

	[TLDef(167,0xE894AD4D)]
	public class Auth_AcceptLoginToken : IMethod
	{
		public byte[] token;
	}

	[TLDef(167,0x0D36BF79)]
	public class Auth_CheckRecoveryPassword : IMethod
	{
		public string code;
	}

	[TLDef(167,0x2DB873A9)]
	public class Auth_ImportWebTokenAuthorization : IMethod
	{
		public int api_id;
		public string api_hash;
		public string web_auth_token;
	}

	[TLDef(167,0x89464B50)]
	public class Auth_RequestFirebaseSms : IMethod
	{
		public Flags flags;
		public string phone_number;
		public string phone_code_hash;
		[IfFlag(0)] public string safety_net_token;
		[IfFlag(1)] public string ios_push_secret;

		[Flags] public enum Flags : uint
		{
			has_safety_net_token = 0x1,
			has_ios_push_secret = 0x2,
		}
	}

	[TLDef(167,0x7E960193)]
	public class Auth_ResetLoginEmail : IMethod
	{
		public string phone_number;
		public string phone_code_hash;
	}

	[TLDef(167,0xEC86017A)]
	public class Account_RegisterDevice : IMethod
	{
		public Flags flags;
		public int token_type;
		public string token;
		public bool app_sandbox;
		public byte[] secret;
		public long[] other_uids;

		[Flags] public enum Flags : uint
		{
			no_muted = 0x1,
		}
	}

	[TLDef(167,0x6A0D3206)]
	public class Account_UnregisterDevice : IMethod
	{
		public int token_type;
		public string token;
		public long[] other_uids;
	}

	[TLDef(167,0x84BE5B93)]
	public class Account_UpdateNotifySettings : IMethod
	{
		public InputNotifyPeerBase peer;
		public InputPeerNotifySettings settings;
	}

	[TLDef(167,0x12B3AD31)]
	public class Account_GetNotifySettings : IMethod
	{
		public InputNotifyPeerBase peer;
	}

	[TLDef(167,0xDB7E1747)]
	public class Account_ResetNotifySettings : IMethod { }

	[TLDef(167,0x78515775)]
	public class Account_UpdateProfile : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public string first_name;
		[IfFlag(1)] public string last_name;
		[IfFlag(2)] public string about;

		[Flags] public enum Flags : uint
		{
			has_first_name = 0x1,
			has_last_name = 0x2,
			has_about = 0x4,
		}
	}

	[TLDef(167,0x6628562C)]
	public class Account_UpdateStatus : IMethod
	{
		public bool offline;
	}

	[TLDef(167,0x07967D36)]
	public class Account_GetWallPapers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0xC5BA3D86)]
	public class Account_ReportPeer : IMethod
	{
		public InputPeer peer;
		public ReportReason reason;
		public string message;
	}

	[TLDef(167,0x2714D86C)]
	public class Account_CheckUsername : IMethod
	{
		public string username;
	}

	[TLDef(167,0x3E0BDD7C)]
	public class Account_UpdateUsername : IMethod
	{
		public string username;
	}

	[TLDef(167,0xDADBC950)]
	public class Account_GetPrivacy : IMethod
	{
		public InputPrivacyKey key;
	}

	[TLDef(167,0xC9F81CE8)]
	public class Account_SetPrivacy : IMethod
	{
		public InputPrivacyKey key;
		public InputPrivacyRule[] rules;
	}

	[TLDef(167,0xA2C0CF74)]
	public class Account_DeleteAccount : IMethod
	{
		public Flags flags;
		public string reason;
		[IfFlag(0)] public InputCheckPasswordSRP password;

		[Flags] public enum Flags : uint
		{
			has_password = 0x1,
		}
	}

	[TLDef(167,0x08FC711D)]
	public class Account_GetAccountTTL : IMethod { }

	[TLDef(167,0x2442485E)]
	public class Account_SetAccountTTL : IMethod
	{
		public AccountDaysTTL ttl;
	}

	[TLDef(167,0x82574AE5)]
	public class Account_SendChangePhoneCode : IMethod
	{
		public string phone_number;
		public CodeSettings settings;
	}

	[TLDef(167,0x70C32EDB)]
	public class Account_ChangePhone : IMethod
	{
		public string phone_number;
		public string phone_code_hash;
		public string phone_code;
	}

	[TLDef(167,0x38DF3532)]
	public class Account_UpdateDeviceLocked : IMethod
	{
		public int period;
	}

	[TLDef(167,0xE320C158)]
	public class Account_GetAuthorizations : IMethod { }

	[TLDef(167,0xDF77F3BC)]
	public class Account_ResetAuthorization : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x548A30F5)]
	public class Account_GetPassword : IMethod { }

	[TLDef(167,0x9CD4EAF9)]
	public class Account_GetPasswordSettings : IMethod
	{
		public InputCheckPasswordSRP password;
	}

	[TLDef(167,0xA59B102F)]
	public class Account_UpdatePasswordSettings : IMethod
	{
		public InputCheckPasswordSRP password;
		public Account_PasswordInputSettings new_settings;
	}

	[TLDef(167,0x1B3FAA88)]
	public class Account_SendConfirmPhoneCode : IMethod
	{
		public string hash;
		public CodeSettings settings;
	}

	[TLDef(167,0x5F2178C3)]
	public class Account_ConfirmPhone : IMethod
	{
		public string phone_code_hash;
		public string phone_code;
	}

	[TLDef(167,0x449E0B51)]
	public class Account_GetTmpPassword : IMethod
	{
		public InputCheckPasswordSRP password;
		public int period;
	}

	[TLDef(167,0x182E6D6F)]
	public class Account_GetWebAuthorizations : IMethod { }

	[TLDef(167,0x2D01B9EF)]
	public class Account_ResetWebAuthorization : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x682D2594)]
	public class Account_ResetWebAuthorizations : IMethod { }

	[TLDef(167,0xB288BC7D)]
	public class Account_GetAllSecureValues : IMethod { }

	[TLDef(167,0x73665BC2)]
	public class Account_GetSecureValue : IMethod
	{
		public SecureValueType[] types;
	}

	[TLDef(167,0x899FE31D)]
	public class Account_SaveSecureValue : IMethod
	{
		public InputSecureValue value;
		public long secure_secret_id;
	}

	[TLDef(167,0xB880BC4B)]
	public class Account_DeleteSecureValue : IMethod
	{
		public SecureValueType[] types;
	}

	[TLDef(167,0xA929597A)]
	public class Account_GetAuthorizationForm : IMethod
	{
		public long bot_id;
		public string scope;
		public string public_key;
	}

	[TLDef(167,0xF3ED4C73)]
	public class Account_AcceptAuthorization : IMethod
	{
		public long bot_id;
		public string scope;
		public string public_key;
		public SecureValueHash[] value_hashes;
		public SecureCredentialsEncrypted credentials;
	}

	[TLDef(167,0xA5A356F9)]
	public class Account_SendVerifyPhoneCode : IMethod
	{
		public string phone_number;
		public CodeSettings settings;
	}

	[TLDef(167,0x4DD3A7F6)]
	public class Account_VerifyPhone : IMethod
	{
		public string phone_number;
		public string phone_code_hash;
		public string phone_code;
	}

	[TLDef(167,0x98E037BB)]
	public class Account_SendVerifyEmailCode : IMethod
	{
		public EmailVerifyPurpose purpose;
		public string email;
	}

	[TLDef(167,0x032DA4CF)]
	public class Account_VerifyEmail : IMethod
	{
		public EmailVerifyPurpose purpose;
		public EmailVerification verification;
	}

	[TLDef(167,0x8EF3EAB0)]
	public class Account_InitTakeoutSession : IMethod
	{
		public Flags flags;
		[IfFlag(5)] public long file_max_size;

		[Flags] public enum Flags : uint
		{
			contacts = 0x1,
			message_users = 0x2,
			message_chats = 0x4,
			message_megagroups = 0x8,
			message_channels = 0x10,
			files = 0x20,
		}
	}

	[TLDef(167,0x1D2652EE)]
	public class Account_FinishTakeoutSession : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			success = 0x1,
		}
	}

	[TLDef(167,0x8FDF1920)]
	public class Account_ConfirmPasswordEmail : IMethod
	{
		public string code;
	}

	[TLDef(167,0x7A7F2A15)]
	public class Account_ResendPasswordEmail : IMethod { }

	[TLDef(167,0xC1CBD5B6)]
	public class Account_CancelPasswordEmail : IMethod { }

	[TLDef(167,0x9F07C728)]
	public class Account_GetContactSignUpNotification : IMethod { }

	[TLDef(167,0xCFF43F61)]
	public class Account_SetContactSignUpNotification : IMethod
	{
		public bool silent;
	}

	[TLDef(167,0x53577479)]
	public class Account_GetNotifyExceptions : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public InputNotifyPeerBase peer;

		[Flags] public enum Flags : uint
		{
			has_peer = 0x1,
			compare_sound = 0x2,
			compare_stories = 0x4,
		}
	}

	[TLDef(167,0xFC8DDBEA)]
	public class Account_GetWallPaper : IMethod
	{
		public InputWallPaperBase wallpaper;
	}

	[TLDef(167,0xE39A8F03)]
	public class Account_UploadWallPaper : IMethod
	{
		public Flags flags;
		public InputFileBase file;
		public string mime_type;
		public WallPaperSettings settings;

		[Flags] public enum Flags : uint
		{
			for_chat = 0x1,
		}
	}

	[TLDef(167,0x6C5A5B37)]
	public class Account_SaveWallPaper : IMethod
	{
		public InputWallPaperBase wallpaper;
		public bool unsave;
		public WallPaperSettings settings;
	}

	[TLDef(167,0xFEED5769)]
	public class Account_InstallWallPaper : IMethod
	{
		public InputWallPaperBase wallpaper;
		public WallPaperSettings settings;
	}

	[TLDef(167,0xBB3B9804)]
	public class Account_ResetWallPapers : IMethod { }

	[TLDef(167,0x56DA0B3F)]
	public class Account_GetAutoDownloadSettings : IMethod { }

	[TLDef(167,0x76F36233)]
	public class Account_SaveAutoDownloadSettings : IMethod
	{
		public Flags flags;
		public AutoDownloadSettings settings;

		[Flags] public enum Flags : uint
		{
			low = 0x1,
			high = 0x2,
		}
	}

	[TLDef(167,0x1C3DB333)]
	public class Account_UploadTheme : IMethod
	{
		public Flags flags;
		public InputFileBase file;
		[IfFlag(0)] public InputFileBase thumb;
		public string file_name;
		public string mime_type;

		[Flags] public enum Flags : uint
		{
			has_thumb = 0x1,
		}
	}

	[TLDef(167,0x652E4400)]
	public class Account_CreateTheme : IMethod
	{
		public Flags flags;
		public string slug;
		public string title;
		[IfFlag(2)] public InputDocument document;
		[IfFlag(3)] public InputThemeSettings[] settings;

		[Flags] public enum Flags : uint
		{
			has_document = 0x4,
			has_settings = 0x8,
		}
	}

	[TLDef(167,0x2BF40CCC)]
	public class Account_UpdateTheme : IMethod
	{
		public Flags flags;
		public string format;
		public InputThemeBase theme;
		[IfFlag(0)] public string slug;
		[IfFlag(1)] public string title;
		[IfFlag(2)] public InputDocument document;
		[IfFlag(3)] public InputThemeSettings[] settings;

		[Flags] public enum Flags : uint
		{
			has_slug = 0x1,
			has_title = 0x2,
			has_document = 0x4,
			has_settings = 0x8,
		}
	}

	[TLDef(167,0xF257106C)]
	public class Account_SaveTheme : IMethod
	{
		public InputThemeBase theme;
		public bool unsave;
	}

	[TLDef(167,0xC727BB3B)]
	public class Account_InstallTheme : IMethod
	{
		public Flags flags;
		[IfFlag(1)] public InputThemeBase theme;
		[IfFlag(2)] public string format;
		[IfFlag(3)] public BaseTheme base_theme;

		[Flags] public enum Flags : uint
		{
			dark = 0x1,
			has_theme = 0x2,
			has_format = 0x4,
			has_base_theme = 0x8,
		}
	}

	[TLDef(167,0x3A5869EC)]
	public class Account_GetTheme : IMethod
	{
		public string format;
		public InputThemeBase theme;
	}

	[TLDef(167,0x7206E458)]
	public class Account_GetThemes : IMethod
	{
		public string format;
		public long hash;
	}

	[TLDef(167,0xB574B16B)]
	public class Account_SetContentSettings : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			sensitive_enabled = 0x1,
		}
	}

	[TLDef(167,0x8B9B4DAE)]
	public class Account_GetContentSettings : IMethod { }

	[TLDef(167,0x65AD71DC)]
	public class Account_GetMultiWallPapers : IMethod
	{
		public InputWallPaperBase[] wallpapers;
	}

	[TLDef(167,0xEB2B4CF6)]
	public class Account_GetGlobalPrivacySettings : IMethod { }

	[TLDef(167,0x1EDAAAC2)]
	public class Account_SetGlobalPrivacySettings : IMethod
	{
		public GlobalPrivacySettings settings;
	}

	[TLDef(167,0xFA8CC6F5)]
	public class Account_ReportProfilePhoto : IMethod
	{
		public InputPeer peer;
		public InputPhoto photo_id;
		public ReportReason reason;
		public string message;
	}

	[TLDef(167,0x9308CE1B)]
	public class Account_ResetPassword : IMethod { }

	[TLDef(167,0x4C9409F6)]
	public class Account_DeclinePasswordReset : IMethod { }

	[TLDef(167,0xD638DE89)]
	public class Account_GetChatThemes : IMethod
	{
		public long hash;
	}

	[TLDef(167,0xBF899AA0)]
	public class Account_SetAuthorizationTTL : IMethod
	{
		public int authorization_ttl_days;
	}

	[TLDef(167,0x40F48462)]
	public class Account_ChangeAuthorizationSettings : IMethod
	{
		public Flags flags;
		public long hash;
		[IfFlag(0)] public bool encrypted_requests_disabled;
		[IfFlag(1)] public bool call_requests_disabled;

		[Flags] public enum Flags : uint
		{
			has_encrypted_requests_disabled = 0x1,
			has_call_requests_disabled = 0x2,
			confirmed = 0x8,
		}
	}

	[TLDef(167,0xE1902288)]
	public class Account_GetSavedRingtones : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x3DEA5B03)]
	public class Account_SaveRingtone : IMethod
	{
		public InputDocument id;
		public bool unsave;
	}

	[TLDef(167,0x831A83A2)]
	public class Account_UploadRingtone : IMethod
	{
		public InputFileBase file;
		public string file_name;
		public string mime_type;
	}

	[TLDef(167,0xFBD3DE6B)]
	public class Account_UpdateEmojiStatus : IMethod
	{
		public EmojiStatus emoji_status;
	}

	[TLDef(167,0xD6753386)]
	public class Account_GetDefaultEmojiStatuses : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x0F578105)]
	public class Account_GetRecentEmojiStatuses : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x18201AAE)]
	public class Account_ClearRecentEmojiStatuses : IMethod { }

	[TLDef(167,0xEF500EAB)]
	public class Account_ReorderUsernames : IMethod
	{
		public string[] order;
	}

	[TLDef(167,0x58D6B376)]
	public class Account_ToggleUsername : IMethod
	{
		public string username;
		public bool active;
	}

	[TLDef(167,0xE2750328)]
	public class Account_GetDefaultProfilePhotoEmojis : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x915860AE)]
	public class Account_GetDefaultGroupPhotoEmojis : IMethod
	{
		public long hash;
	}

	[TLDef(167,0xADCBBCDA)]
	public class Account_GetAutoSaveSettings : IMethod { }

	[TLDef(167,0xD69B8361)]
	public class Account_SaveAutoSaveSettings : IMethod
	{
		public Flags flags;
		[IfFlag(3)] public InputPeer peer;
		public AutoSaveSettings settings;

		[Flags] public enum Flags : uint
		{
			users = 0x1,
			chats = 0x2,
			broadcasts = 0x4,
			has_peer = 0x8,
		}
	}

	[TLDef(167,0x53BC0020)]
	public class Account_DeleteAutoSaveExceptions : IMethod { }

	[TLDef(167,0xCA8AE8BA)]
	public class Account_InvalidateSignInCodes : IMethod
	{
		public string[] codes;
	}

	[TLDef(167,0x7CEFA15D)]
	public class Account_UpdateColor : IMethod
	{
		public Flags flags;
		[IfFlag(2)] public int color;
		[IfFlag(0)] public long background_emoji_id;

		[Flags] public enum Flags : uint
		{
			has_background_emoji_id = 0x1,
			for_profile = 0x2,
			has_color = 0x4,
		}
	}

	[TLDef(167,0xA60AB9CE)]
	public class Account_GetDefaultBackgroundEmojis : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x0D91A548)]
	public class Users_GetUsers : IMethod
	{
		public InputUserBase[] id;
	}

	[TLDef(167,0xB60F5918)]
	public class Users_GetFullUser : IMethod
	{
		public InputUserBase id;
	}

	[TLDef(167,0x90C894B5)]
	public class Users_SetSecureValueErrors : IMethod
	{
		public InputUserBase id;
		public SecureValueErrorBase[] errors;
	}

	[TLDef(167,0x7ADC669D)]
	public class Contacts_GetContactIDs : IMethod
	{
		public long hash;
	}

	[TLDef(167,0xC4A353EE)]
	public class Contacts_GetStatuses : IMethod { }

	[TLDef(167,0x5DD69E12)]
	public class Contacts_GetContacts : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x2C800BE5)]
	public class Contacts_ImportContacts : IMethod
	{
		public InputContact[] contacts;
	}

	[TLDef(167,0x096A0E00)]
	public class Contacts_DeleteContacts : IMethod
	{
		public InputUserBase[] id;
	}

	[TLDef(167,0x1013FD9E)]
	public class Contacts_DeleteByPhones : IMethod
	{
		public string[] phones;
	}

	[TLDef(167,0x2E2E8734)]
	public class Contacts_Block : IMethod
	{
		public Flags flags;
		public InputPeer id;

		[Flags] public enum Flags : uint
		{
			my_stories_from = 0x1,
		}
	}

	[TLDef(167,0xB550D328)]
	public class Contacts_Unblock : IMethod
	{
		public Flags flags;
		public InputPeer id;

		[Flags] public enum Flags : uint
		{
			my_stories_from = 0x1,
		}
	}

	[TLDef(167,0x9A868F80)]
	public class Contacts_GetBlocked : IMethod
	{
		public Flags flags;
		public int offset;
		public int limit;

		[Flags] public enum Flags : uint
		{
			my_stories_from = 0x1,
		}
	}

	[TLDef(167,0x11F812D8)]
	public class Contacts_Search : IMethod
	{
		public string q;
		public int limit;
	}

	[TLDef(167,0xF93CCBA3)]
	public class Contacts_ResolveUsername : IMethod
	{
		public string username;
	}

	[TLDef(167,0x973478B6)]
	public class Contacts_GetTopPeers : IMethod
	{
		public Flags flags;
		public int offset;
		public int limit;
		public long hash;

		[Flags] public enum Flags : uint
		{
			correspondents = 0x1,
			bots_pm = 0x2,
			bots_inline = 0x4,
			phone_calls = 0x8,
			forward_users = 0x10,
			forward_chats = 0x20,
			groups = 0x400,
			channels = 0x8000,
		}
	}

	[TLDef(167,0x1AE373AC)]
	public class Contacts_ResetTopPeerRating : IMethod
	{
		public TopPeerCategory category;
		public InputPeer peer;
	}

	[TLDef(167,0x879537F1)]
	public class Contacts_ResetSaved : IMethod { }

	[TLDef(167,0x82F1E39F)]
	public class Contacts_GetSaved : IMethod { }

	[TLDef(167,0x8514BDDA)]
	public class Contacts_ToggleTopPeers : IMethod
	{
		public bool enabled;
	}

	[TLDef(167,0xE8F463D0)]
	public class Contacts_AddContact : IMethod
	{
		public Flags flags;
		public InputUserBase id;
		public string first_name;
		public string last_name;
		public string phone;

		[Flags] public enum Flags : uint
		{
			add_phone_privacy_exception = 0x1,
		}
	}

	[TLDef(167,0xF831A20F)]
	public class Contacts_AcceptContact : IMethod
	{
		public InputUserBase id;
	}

	[TLDef(167,0xD348BC44)]
	public class Contacts_GetLocated : IMethod
	{
		public Flags flags;
		public InputGeoPoint geo_point;
		[IfFlag(0)] public int self_expires;

		[Flags] public enum Flags : uint
		{
			has_self_expires = 0x1,
			background = 0x2,
		}
	}

	[TLDef(167,0x29A8962C)]
	public class Contacts_BlockFromReplies : IMethod
	{
		public Flags flags;
		public int msg_id;

		[Flags] public enum Flags : uint
		{
			delete_message = 0x1,
			delete_history = 0x2,
			report_spam = 0x4,
		}
	}

	[TLDef(167,0x8AF94344)]
	public class Contacts_ResolvePhone : IMethod
	{
		public string phone;
	}

	[TLDef(167,0xF8654027)]
	public class Contacts_ExportContactToken : IMethod { }

	[TLDef(167,0x13005788)]
	public class Contacts_ImportContactToken : IMethod
	{
		public string token;
	}

	[TLDef(167,0xBA6705F0)]
	public class Contacts_EditCloseFriends : IMethod
	{
		public long[] id;
	}

	[TLDef(167,0x94C65C76)]
	public class Contacts_SetBlocked : IMethod
	{
		public Flags flags;
		public InputPeer[] id;
		public int limit;

		[Flags] public enum Flags : uint
		{
			my_stories_from = 0x1,
		}
	}

	[TLDef(167,0x63C66506)]
	public class Messages_GetMessages : IMethod
	{
		public InputMessage[] id;
	}

	[TLDef(167,0xA0F4CB4F)]
	public class Messages_GetDialogs : IMethod
	{
		public Flags flags;
		[IfFlag(1)] public int folder_id;
		public DateTime offset_date;
		public int offset_id;
		public InputPeer offset_peer;
		public int limit;
		public long hash;

		[Flags] public enum Flags : uint
		{
			exclude_pinned = 0x1,
			has_folder_id = 0x2,
		}
	}

	[TLDef(167,0x4423E6C5)]
	public class Messages_GetHistory : IMethod
	{
		public InputPeer peer;
		public int offset_id;
		public DateTime offset_date;
		public int add_offset;
		public int limit;
		public int max_id;
		public int min_id;
		public long hash;
	}

	[TLDef(167,0xA0FDA762)]
	public class Messages_Search : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public string q;
		[IfFlag(0)] public InputPeer from_id;
		[IfFlag(1)] public int top_msg_id;
		public MessagesFilter filter;
		public DateTime min_date;
		public DateTime max_date;
		public int offset_id;
		public int add_offset;
		public int limit;
		public int max_id;
		public int min_id;
		public long hash;

		[Flags] public enum Flags : uint
		{
			has_from_id = 0x1,
			has_top_msg_id = 0x2,
		}
	}

	[TLDef(167,0x0E306D3A)]
	public class Messages_ReadHistory : IMethod
	{
		public InputPeer peer;
		public int max_id;
	}

	[TLDef(167,0xB08F922A)]
	public class Messages_DeleteHistory : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int max_id;
		[IfFlag(2)] public DateTime min_date;
		[IfFlag(3)] public DateTime max_date;

		[Flags] public enum Flags : uint
		{
			just_clear = 0x1,
			revoke = 0x2,
			has_min_date = 0x4,
			has_max_date = 0x8,
		}
	}

	[TLDef(167,0xE58E95D2)]
	public class Messages_DeleteMessages : IMethod
	{
		public Flags flags;
		public int[] id;

		[Flags] public enum Flags : uint
		{
			revoke = 0x1,
		}
	}

	[TLDef(167,0x05A954C0)]
	public class Messages_ReceivedMessages : IMethod
	{
		public int max_id;
	}

	[TLDef(167,0x58943EE2)]
	public class Messages_SetTyping : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;
		public SendMessageAction action;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x280D096F)]
	public class Messages_SendMessage : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public InputReplyTo reply_to;
		public string message;
		public long random_id;
		[IfFlag(2)] public ReplyMarkup reply_markup;
		[IfFlag(3)] public MessageEntity[] entities;
		[IfFlag(10)] public DateTime schedule_date;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_reply_to = 0x1,
			no_webpage = 0x2,
			has_reply_markup = 0x4,
			has_entities = 0x8,
			silent = 0x20,
			background = 0x40,
			clear_draft = 0x80,
			has_schedule_date = 0x400,
			has_send_as = 0x2000,
			noforwards = 0x4000,
			update_stickersets_order = 0x8000,
			invert_media = 0x10000,
		}
	}

	[TLDef(167,0x72CCC23D)]
	public class Messages_SendMedia : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public InputReplyTo reply_to;
		public InputMedia media;
		public string message;
		public long random_id;
		[IfFlag(2)] public ReplyMarkup reply_markup;
		[IfFlag(3)] public MessageEntity[] entities;
		[IfFlag(10)] public DateTime schedule_date;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_reply_to = 0x1,
			has_reply_markup = 0x4,
			has_entities = 0x8,
			silent = 0x20,
			background = 0x40,
			clear_draft = 0x80,
			has_schedule_date = 0x400,
			has_send_as = 0x2000,
			noforwards = 0x4000,
			update_stickersets_order = 0x8000,
			invert_media = 0x10000,
		}
	}

	[TLDef(167,0xC661BBC4)]
	public class Messages_ForwardMessages : IMethod
	{
		public Flags flags;
		public InputPeer from_peer;
		public int[] id;
		public long[] random_id;
		public InputPeer to_peer;
		[IfFlag(9)] public int top_msg_id;
		[IfFlag(10)] public DateTime schedule_date;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			silent = 0x20,
			background = 0x40,
			with_my_score = 0x100,
			has_top_msg_id = 0x200,
			has_schedule_date = 0x400,
			drop_author = 0x800,
			drop_media_captions = 0x1000,
			has_send_as = 0x2000,
			noforwards = 0x4000,
		}
	}

	[TLDef(167,0xCF1592DB)]
	public class Messages_ReportSpam : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xEFD9A6A2)]
	public class Messages_GetPeerSettings : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0x8953AB4E)]
	public class Messages_Report : IMethod
	{
		public InputPeer peer;
		public int[] id;
		public ReportReason reason;
		public string message;
	}

	[TLDef(167,0x49E9528F)]
	public class Messages_GetChats : IMethod
	{
		public long[] id;
	}

	[TLDef(167,0xAEB00B34)]
	public class Messages_GetFullChat : IMethod
	{
		public long chat_id;
	}

	[TLDef(167,0x73783FFD)]
	public class Messages_EditChatTitle : IMethod
	{
		public long chat_id;
		public string title;
	}

	[TLDef(167,0x35DDD674)]
	public class Messages_EditChatPhoto : IMethod
	{
		public long chat_id;
		public InputChatPhotoBase photo;
	}

	[TLDef(167,0xF24753E3)]
	public class Messages_AddChatUser : IMethod
	{
		public long chat_id;
		public InputUserBase user_id;
		public int fwd_limit;
	}

	[TLDef(167,0xA2185CAB)]
	public class Messages_DeleteChatUser : IMethod
	{
		public Flags flags;
		public long chat_id;
		public InputUserBase user_id;

		[Flags] public enum Flags : uint
		{
			revoke_history = 0x1,
		}
	}

	[TLDef(167,0x0034A818)]
	public class Messages_CreateChat : IMethod
	{
		public Flags flags;
		public InputUserBase[] users;
		public string title;
		[IfFlag(0)] public int ttl_period;

		[Flags] public enum Flags : uint
		{
			has_ttl_period = 0x1,
		}
	}

	[TLDef(167,0x26CF8950)]
	public class Messages_GetDhConfig : IMethod
	{
		public int version;
		public int random_length;
	}

	[TLDef(167,0xF64DAF43)]
	public class Messages_RequestEncryption : IMethod
	{
		public InputUserBase user_id;
		public int random_id;
		public byte[] g_a;
	}

	[TLDef(167,0x3DBC0415)]
	public class Messages_AcceptEncryption : IMethod
	{
		public InputEncryptedChat peer;
		public byte[] g_b;
		public long key_fingerprint;
	}

	[TLDef(167,0xF393AEA0)]
	public class Messages_DiscardEncryption : IMethod
	{
		public Flags flags;
		public int chat_id;

		[Flags] public enum Flags : uint
		{
			delete_history = 0x1,
		}
	}

	[TLDef(167,0x791451ED)]
	public class Messages_SetEncryptedTyping : IMethod
	{
		public InputEncryptedChat peer;
		public bool typing;
	}

	[TLDef(167,0x7F4B690A)]
	public class Messages_ReadEncryptedHistory : IMethod
	{
		public InputEncryptedChat peer;
		public DateTime max_date;
	}

	[TLDef(167,0x44FA7A15)]
	public class Messages_SendEncrypted : IMethod
	{
		public Flags flags;
		public InputEncryptedChat peer;
		public long random_id;
		public byte[] data;

		[Flags] public enum Flags : uint
		{
			silent = 0x1,
		}
	}

	[TLDef(167,0x5559481D)]
	public class Messages_SendEncryptedFile : IMethod
	{
		public Flags flags;
		public InputEncryptedChat peer;
		public long random_id;
		public byte[] data;
		public InputEncryptedFileBase file;

		[Flags] public enum Flags : uint
		{
			silent = 0x1,
		}
	}

	[TLDef(167,0x32D439A4)]
	public class Messages_SendEncryptedService : IMethod
	{
		public InputEncryptedChat peer;
		public long random_id;
		public byte[] data;
	}

	[TLDef(167,0x55A5BB66)]
	public class Messages_ReceivedQueue : IMethod
	{
		public int max_qts;
	}

	[TLDef(167,0x4B0C8C0F)]
	public class Messages_ReportEncryptedSpam : IMethod
	{
		public InputEncryptedChat peer;
	}

	[TLDef(167,0x36A73F77)]
	public class Messages_ReadMessageContents : IMethod
	{
		public int[] id;
	}

	[TLDef(167,0xD5A5D3A1)]
	public class Messages_GetStickers : IMethod
	{
		public string emoticon;
		public long hash;
	}

	[TLDef(167,0xB8A0A1A8)]
	public class Messages_GetAllStickers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x8B68B0CC)]
	public class Messages_GetWebPagePreview : IMethod
	{
		public Flags flags;
		public string message;
		[IfFlag(3)] public MessageEntity[] entities;

		[Flags] public enum Flags : uint
		{
			has_entities = 0x8,
		}
	}

	[TLDef(167,0xA02CE5D5)]
	public class Messages_ExportChatInvite : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public DateTime expire_date;
		[IfFlag(1)] public int usage_limit;
		[IfFlag(4)] public string title;

		[Flags] public enum Flags : uint
		{
			has_expire_date = 0x1,
			has_usage_limit = 0x2,
			legacy_revoke_permanent = 0x4,
			request_needed = 0x8,
			has_title = 0x10,
		}
	}

	[TLDef(167,0x3EADB1BB)]
	public class Messages_CheckChatInvite : IMethod
	{
		public string hash;
	}

	[TLDef(167,0x6C50051C)]
	public class Messages_ImportChatInvite : IMethod
	{
		public string hash;
	}

	[TLDef(167,0xC8A0EC74)]
	public class Messages_GetStickerSet : IMethod
	{
		public InputStickerSet stickerset;
		public int hash;
	}

	[TLDef(167,0xC78FE460)]
	public class Messages_InstallStickerSet : IMethod
	{
		public InputStickerSet stickerset;
		public bool archived;
	}

	[TLDef(167,0xF96E55DE)]
	public class Messages_UninstallStickerSet : IMethod
	{
		public InputStickerSet stickerset;
	}

	[TLDef(167,0xE6DF7378)]
	public class Messages_StartBot : IMethod
	{
		public InputUserBase bot;
		public InputPeer peer;
		public long random_id;
		public string start_param;
	}

	[TLDef(167,0x5784D3E1)]
	public class Messages_GetMessagesViews : IMethod
	{
		public InputPeer peer;
		public int[] id;
		public bool increment;
	}

	[TLDef(167,0xA85BD1C2)]
	public class Messages_EditChatAdmin : IMethod
	{
		public long chat_id;
		public InputUserBase user_id;
		public bool is_admin;
	}

	[TLDef(167,0xA2875319)]
	public class Messages_MigrateChat : IMethod
	{
		public long chat_id;
	}

	[TLDef(167,0x4BC6589A)]
	public class Messages_SearchGlobal : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public int folder_id;
		public string q;
		public MessagesFilter filter;
		public DateTime min_date;
		public DateTime max_date;
		public int offset_rate;
		public InputPeer offset_peer;
		public int offset_id;
		public int limit;

		[Flags] public enum Flags : uint
		{
			has_folder_id = 0x1,
		}
	}

	[TLDef(167,0x78337739)]
	public class Messages_ReorderStickerSets : IMethod
	{
		public Flags flags;
		public long[] order;

		[Flags] public enum Flags : uint
		{
			masks = 0x1,
			emojis = 0x2,
		}
	}

	[TLDef(167,0xB1F2061F)]
	public class Messages_GetDocumentByHash : IMethod
	{
		public byte[] sha256;
		public long size;
		public string mime_type;
	}

	[TLDef(167,0x5CF09635)]
	public class Messages_GetSavedGifs : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x327A30CB)]
	public class Messages_SaveGif : IMethod
	{
		public InputDocument id;
		public bool unsave;
	}

	[TLDef(167,0x514E999D)]
	public class Messages_GetInlineBotResults : IMethod
	{
		public Flags flags;
		public InputUserBase bot;
		public InputPeer peer;
		[IfFlag(0)] public InputGeoPoint geo_point;
		public string query;
		public string offset;

		[Flags] public enum Flags : uint
		{
			has_geo_point = 0x1,
		}
	}

	[TLDef(167,0xBB12A419)]
	public class Messages_SetInlineBotResults : IMethod
	{
		public Flags flags;
		public long query_id;
		public InputBotInlineResultBase[] results;
		public int cache_time;
		[IfFlag(2)] public string next_offset;
		[IfFlag(3)] public InlineBotSwitchPM switch_pm;
		[IfFlag(4)] public InlineBotWebView switch_webview;

		[Flags] public enum Flags : uint
		{
			gallery = 0x1,
			private_ = 0x2,
			has_next_offset = 0x4,
			has_switch_pm = 0x8,
			has_switch_webview = 0x10,
		}
	}

	[TLDef(167,0xF7BC68BA)]
	public class Messages_SendInlineBotResult : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public InputReplyTo reply_to;
		public long random_id;
		public long query_id;
		public string id;
		[IfFlag(10)] public DateTime schedule_date;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_reply_to = 0x1,
			silent = 0x20,
			background = 0x40,
			clear_draft = 0x80,
			has_schedule_date = 0x400,
			hide_via = 0x800,
			has_send_as = 0x2000,
		}
	}

	[TLDef(167,0xFDA68D36)]
	public class Messages_GetMessageEditData : IMethod
	{
		public InputPeer peer;
		public int id;
	}

	[TLDef(167,0x48F71778)]
	public class Messages_EditMessage : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;
		[IfFlag(11)] public string message;
		[IfFlag(14)] public InputMedia media;
		[IfFlag(2)] public ReplyMarkup reply_markup;
		[IfFlag(3)] public MessageEntity[] entities;
		[IfFlag(15)] public DateTime schedule_date;

		[Flags] public enum Flags : uint
		{
			no_webpage = 0x2,
			has_reply_markup = 0x4,
			has_entities = 0x8,
			has_message = 0x800,
			has_media = 0x4000,
			has_schedule_date = 0x8000,
			invert_media = 0x10000,
		}
	}

	[TLDef(167,0x83557DBA)]
	public class Messages_EditInlineBotMessage : IMethod
	{
		public Flags flags;
		public InputBotInlineMessageIDBase id;
		[IfFlag(11)] public string message;
		[IfFlag(14)] public InputMedia media;
		[IfFlag(2)] public ReplyMarkup reply_markup;
		[IfFlag(3)] public MessageEntity[] entities;

		[Flags] public enum Flags : uint
		{
			no_webpage = 0x2,
			has_reply_markup = 0x4,
			has_entities = 0x8,
			has_message = 0x800,
			has_media = 0x4000,
			invert_media = 0x10000,
		}
	}

	[TLDef(167,0x9342CA07)]
	public class Messages_GetBotCallbackAnswer : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int msg_id;
		[IfFlag(0)] public byte[] data;
		[IfFlag(2)] public InputCheckPasswordSRP password;

		[Flags] public enum Flags : uint
		{
			has_data = 0x1,
			game = 0x2,
			has_password = 0x4,
		}
	}

	[TLDef(167,0xD58F130A)]
	public class Messages_SetBotCallbackAnswer : IMethod
	{
		public Flags flags;
		public long query_id;
		[IfFlag(0)] public string message;
		[IfFlag(2)] public string url;
		public int cache_time;

		[Flags] public enum Flags : uint
		{
			has_message = 0x1,
			alert = 0x2,
			has_url = 0x4,
		}
	}

	[TLDef(167,0xE470BCFD)]
	public class Messages_GetPeerDialogs : IMethod
	{
		public InputDialogPeerBase[] peers;
	}

	[TLDef(167,0x7FF3B806)]
	public class Messages_SaveDraft : IMethod
	{
		public Flags flags;
		[IfFlag(4)] public InputReplyTo reply_to;
		public InputPeer peer;
		public string message;
		[IfFlag(3)] public MessageEntity[] entities;
		[IfFlag(5)] public InputMedia media;

		[Flags] public enum Flags : uint
		{
			no_webpage = 0x2,
			has_entities = 0x8,
			has_reply_to = 0x10,
			has_media = 0x20,
			invert_media = 0x40,
		}
	}

	[TLDef(167,0x6A3F8D65)]
	public class Messages_GetAllDrafts : IMethod { }

	[TLDef(167,0x64780B14)]
	public class Messages_GetFeaturedStickers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x5B118126)]
	public class Messages_ReadFeaturedStickers : IMethod
	{
		public long[] id;
	}

	[TLDef(167,0x9DA9403B)]
	public class Messages_GetRecentStickers : IMethod
	{
		public Flags flags;
		public long hash;

		[Flags] public enum Flags : uint
		{
			attached = 0x1,
		}
	}

	[TLDef(167,0x392718F8)]
	public class Messages_SaveRecentSticker : IMethod
	{
		public Flags flags;
		public InputDocument id;
		public bool unsave;

		[Flags] public enum Flags : uint
		{
			attached = 0x1,
		}
	}

	[TLDef(167,0x8999602D)]
	public class Messages_ClearRecentStickers : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			attached = 0x1,
		}
	}

	[TLDef(167,0x57F17692)]
	public class Messages_GetArchivedStickers : IMethod
	{
		public Flags flags;
		public long offset_id;
		public int limit;

		[Flags] public enum Flags : uint
		{
			masks = 0x1,
			emojis = 0x2,
		}
	}

	[TLDef(167,0x640F82B8)]
	public class Messages_GetMaskStickers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0xCC5B67CC)]
	public class Messages_GetAttachedStickers : IMethod
	{
		public InputStickeredMedia media;
	}

	[TLDef(167,0x8EF8ECC0)]
	public class Messages_SetGameScore : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;
		public InputUserBase user_id;
		public int score;

		[Flags] public enum Flags : uint
		{
			edit_message = 0x1,
			force = 0x2,
		}
	}

	[TLDef(167,0x15AD9F64)]
	public class Messages_SetInlineGameScore : IMethod
	{
		public Flags flags;
		public InputBotInlineMessageIDBase id;
		public InputUserBase user_id;
		public int score;

		[Flags] public enum Flags : uint
		{
			edit_message = 0x1,
			force = 0x2,
		}
	}

	[TLDef(167,0xE822649D)]
	public class Messages_GetGameHighScores : IMethod
	{
		public InputPeer peer;
		public int id;
		public InputUserBase user_id;
	}

	[TLDef(167,0x0F635E1B)]
	public class Messages_GetInlineGameHighScores : IMethod
	{
		public InputBotInlineMessageIDBase id;
		public InputUserBase user_id;
	}

	[TLDef(167,0xE40CA104)]
	public class Messages_GetCommonChats : IMethod
	{
		public InputUserBase user_id;
		public long max_id;
		public int limit;
	}

	[TLDef(167,0x8D9692A3)]
	public class Messages_GetWebPage : IMethod
	{
		public string url;
		public int hash;
	}

	[TLDef(167,0xA731E257)]
	public class Messages_ToggleDialogPin : IMethod
	{
		public Flags flags;
		public InputDialogPeerBase peer;

		[Flags] public enum Flags : uint
		{
			pinned = 0x1,
		}
	}

	[TLDef(167,0x3B1ADF37)]
	public class Messages_ReorderPinnedDialogs : IMethod
	{
		public Flags flags;
		public int folder_id;
		public InputDialogPeerBase[] order;

		[Flags] public enum Flags : uint
		{
			force = 0x1,
		}
	}

	[TLDef(167,0xD6B94DF2)]
	public class Messages_GetPinnedDialogs : IMethod
	{
		public int folder_id;
	}

	[TLDef(167,0xE5F672FA)]
	public class Messages_SetBotShippingResults : IMethod
	{
		public Flags flags;
		public long query_id;
		[IfFlag(0)] public string error;
		[IfFlag(1)] public ShippingOption[] shipping_options;

		[Flags] public enum Flags : uint
		{
			has_error = 0x1,
			has_shipping_options = 0x2,
		}
	}

	[TLDef(167,0x09C2DD95)]
	public class Messages_SetBotPrecheckoutResults : IMethod
	{
		public Flags flags;
		public long query_id;
		[IfFlag(0)] public string error;

		[Flags] public enum Flags : uint
		{
			has_error = 0x1,
			success = 0x2,
		}
	}

	[TLDef(167,0x519BC2B1)]
	public class Messages_UploadMedia : IMethod
	{
		public InputPeer peer;
		public InputMedia media;
	}

	[TLDef(167,0xA1405817)]
	public class Messages_SendScreenshotNotification : IMethod
	{
		public InputPeer peer;
		public InputReplyTo reply_to;
		public long random_id;
	}

	[TLDef(167,0x04F1AAA9)]
	public class Messages_GetFavedStickers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0xB9FFC55B)]
	public class Messages_FaveSticker : IMethod
	{
		public InputDocument id;
		public bool unfave;
	}

	[TLDef(167,0xF107E790)]
	public class Messages_GetUnreadMentions : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;
		public int offset_id;
		public int add_offset;
		public int limit;
		public int max_id;
		public int min_id;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x36E5BF4D)]
	public class Messages_ReadMentions : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x702A40E0)]
	public class Messages_GetRecentLocations : IMethod
	{
		public InputPeer peer;
		public int limit;
		public long hash;
	}

	[TLDef(167,0x456E8987)]
	public class Messages_SendMultiMedia : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public InputReplyTo reply_to;
		public InputSingleMedia[] multi_media;
		[IfFlag(10)] public DateTime schedule_date;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_reply_to = 0x1,
			silent = 0x20,
			background = 0x40,
			clear_draft = 0x80,
			has_schedule_date = 0x400,
			has_send_as = 0x2000,
			noforwards = 0x4000,
			update_stickersets_order = 0x8000,
			invert_media = 0x10000,
		}
	}

	[TLDef(167,0x5057C497)]
	public class Messages_UploadEncryptedFile : IMethod
	{
		public InputEncryptedChat peer;
		public InputEncryptedFileBase file;
	}

	[TLDef(167,0x35705B8A)]
	public class Messages_SearchStickerSets : IMethod
	{
		public Flags flags;
		public string q;
		public long hash;

		[Flags] public enum Flags : uint
		{
			exclude_featured = 0x1,
		}
	}

	[TLDef(167,0x1CFF7E08)]
	public class Messages_GetSplitRanges : IMethod { }

	[TLDef(167,0xC286D98F)]
	public class Messages_MarkDialogUnread : IMethod
	{
		public Flags flags;
		public InputDialogPeerBase peer;

		[Flags] public enum Flags : uint
		{
			unread = 0x1,
		}
	}

	[TLDef(167,0x22E24E22)]
	public class Messages_GetDialogUnreadMarks : IMethod { }

	[TLDef(167,0x7E58EE9C)]
	public class Messages_ClearAllDrafts : IMethod { }

	[TLDef(167,0xD2AAF7EC)]
	public class Messages_UpdatePinnedMessage : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;

		[Flags] public enum Flags : uint
		{
			silent = 0x1,
			unpin = 0x2,
			pm_oneside = 0x4,
		}
	}

	[TLDef(167,0x10EA6184)]
	public class Messages_SendVote : IMethod
	{
		public InputPeer peer;
		public int msg_id;
		public byte[][] options;
	}

	[TLDef(167,0x73BB643B)]
	public class Messages_GetPollResults : IMethod
	{
		public InputPeer peer;
		public int msg_id;
	}

	[TLDef(167,0x6E2BE050)]
	public class Messages_GetOnlines : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xDEF60797)]
	public class Messages_EditChatAbout : IMethod
	{
		public InputPeer peer;
		public string about;
	}

	[TLDef(167,0xA5866B41)]
	public class Messages_EditChatDefaultBannedRights : IMethod
	{
		public InputPeer peer;
		public ChatBannedRights banned_rights;
	}

	[TLDef(167,0x35A0E062)]
	public class Messages_GetEmojiKeywords : IMethod
	{
		public string lang_code;
	}

	[TLDef(167,0x1508B6AF)]
	public class Messages_GetEmojiKeywordsDifference : IMethod
	{
		public string lang_code;
		public int from_version;
	}

	[TLDef(167,0x4E9963B2)]
	public class Messages_GetEmojiKeywordsLanguages : IMethod
	{
		public string[] lang_codes;
	}

	[TLDef(167,0xD5B10C26)]
	public class Messages_GetEmojiURL : IMethod
	{
		public string lang_code;
	}

	[TLDef(167,0x00AE7CC1)]
	public class Messages_GetSearchCounters : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;
		public MessagesFilter[] filters;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x198FB446)]
	public class Messages_RequestUrlAuth : IMethod
	{
		public Flags flags;
		[IfFlag(1)] public InputPeer peer;
		[IfFlag(1)] public int msg_id;
		[IfFlag(1)] public int button_id;
		[IfFlag(2)] public string url;

		[Flags] public enum Flags : uint
		{
			has_peer = 0x2,
			has_url = 0x4,
		}
	}

	[TLDef(167,0xB12C7125)]
	public class Messages_AcceptUrlAuth : IMethod
	{
		public Flags flags;
		[IfFlag(1)] public InputPeer peer;
		[IfFlag(1)] public int msg_id;
		[IfFlag(1)] public int button_id;
		[IfFlag(2)] public string url;

		[Flags] public enum Flags : uint
		{
			write_allowed = 0x1,
			has_peer = 0x2,
			has_url = 0x4,
		}
	}

	[TLDef(167,0x4FACB138)]
	public class Messages_HidePeerSettingsBar : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xF516760B)]
	public class Messages_GetScheduledHistory : IMethod
	{
		public InputPeer peer;
		public long hash;
	}

	[TLDef(167,0xBDBB0464)]
	public class Messages_GetScheduledMessages : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0xBD38850A)]
	public class Messages_SendScheduledMessages : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x59AE2B16)]
	public class Messages_DeleteScheduledMessages : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0xB86E380E)]
	public class Messages_GetPollVotes : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;
		[IfFlag(0)] public byte[] option;
		[IfFlag(1)] public string offset;
		public int limit;

		[Flags] public enum Flags : uint
		{
			has_option = 0x1,
			has_offset = 0x2,
		}
	}

	[TLDef(167,0xB5052FEA)]
	public class Messages_ToggleStickerSets : IMethod
	{
		public Flags flags;
		public InputStickerSet[] stickersets;

		[Flags] public enum Flags : uint
		{
			uninstall = 0x1,
			archive = 0x2,
			unarchive = 0x4,
		}
	}

	[TLDef(167,0xF19ED96D)]
	public class Messages_GetDialogFilters : IMethod { }

	[TLDef(167,0xA29CD42C)]
	public class Messages_GetSuggestedDialogFilters : IMethod { }

	[TLDef(167,0x1AD4A04A)]
	public class Messages_UpdateDialogFilter : IMethod
	{
		public Flags flags;
		public int id;
		[IfFlag(0)] public DialogFilterBase filter;

		[Flags] public enum Flags : uint
		{
			has_filter = 0x1,
		}
	}

	[TLDef(167,0xC563C1E4)]
	public class Messages_UpdateDialogFiltersOrder : IMethod
	{
		public int[] order;
	}

	[TLDef(167,0x7ED094A1)]
	public class Messages_GetOldFeaturedStickers : IMethod
	{
		public int offset;
		public int limit;
		public long hash;
	}

	[TLDef(167,0x22DDD30C)]
	public class Messages_GetReplies : IMethod
	{
		public InputPeer peer;
		public int msg_id;
		public int offset_id;
		public DateTime offset_date;
		public int add_offset;
		public int limit;
		public int max_id;
		public int min_id;
		public long hash;
	}

	[TLDef(167,0x446972FD)]
	public class Messages_GetDiscussionMessage : IMethod
	{
		public InputPeer peer;
		public int msg_id;
	}

	[TLDef(167,0xF731A9F4)]
	public class Messages_ReadDiscussion : IMethod
	{
		public InputPeer peer;
		public int msg_id;
		public int read_max_id;
	}

	[TLDef(167,0xEE22B9A8)]
	public class Messages_UnpinAllMessages : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x5BD0EE50)]
	public class Messages_DeleteChat : IMethod
	{
		public long chat_id;
	}

	[TLDef(167,0xF9CBE409)]
	public class Messages_DeletePhoneCallHistory : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			revoke = 0x1,
		}
	}

	[TLDef(167,0x43FE19F3)]
	public class Messages_CheckHistoryImport : IMethod
	{
		public string import_head;
	}

	[TLDef(167,0x34090C3B)]
	public class Messages_InitHistoryImport : IMethod
	{
		public InputPeer peer;
		public InputFileBase file;
		public int media_count;
	}

	[TLDef(167,0x2A862092)]
	public class Messages_UploadImportedMedia : IMethod
	{
		public InputPeer peer;
		public long import_id;
		public string file_name;
		public InputMedia media;
	}

	[TLDef(167,0xB43DF344)]
	public class Messages_StartHistoryImport : IMethod
	{
		public InputPeer peer;
		public long import_id;
	}

	[TLDef(167,0xA2B5A3F6)]
	public class Messages_GetExportedChatInvites : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public InputUserBase admin_id;
		[IfFlag(2)] public DateTime offset_date;
		[IfFlag(2)] public string offset_link;
		public int limit;

		[Flags] public enum Flags : uint
		{
			has_offset_date = 0x4,
			revoked = 0x8,
		}
	}

	[TLDef(167,0x73746F5C)]
	public class Messages_GetExportedChatInvite : IMethod
	{
		public InputPeer peer;
		public string link;
	}

	[TLDef(167,0xBDCA2F75)]
	public class Messages_EditExportedChatInvite : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public string link;
		[IfFlag(0)] public DateTime expire_date;
		[IfFlag(1)] public int usage_limit;
		[IfFlag(3)] public bool request_needed;
		[IfFlag(4)] public string title;

		[Flags] public enum Flags : uint
		{
			has_expire_date = 0x1,
			has_usage_limit = 0x2,
			revoked = 0x4,
			has_request_needed = 0x8,
			has_title = 0x10,
		}
	}

	[TLDef(167,0x56987BD5)]
	public class Messages_DeleteRevokedExportedChatInvites : IMethod
	{
		public InputPeer peer;
		public InputUserBase admin_id;
	}

	[TLDef(167,0xD464A42B)]
	public class Messages_DeleteExportedChatInvite : IMethod
	{
		public InputPeer peer;
		public string link;
	}

	[TLDef(167,0x3920E6EF)]
	public class Messages_GetAdminsWithInvites : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xDF04DD4E)]
	public class Messages_GetChatInviteImporters : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(1)] public string link;
		[IfFlag(2)] public string q;
		public DateTime offset_date;
		public InputUserBase offset_user;
		public int limit;

		[Flags] public enum Flags : uint
		{
			requested = 0x1,
			has_link = 0x2,
			has_q = 0x4,
		}
	}

	[TLDef(167,0xB80E5FE4)]
	public class Messages_SetHistoryTTL : IMethod
	{
		public InputPeer peer;
		public int period;
	}

	[TLDef(167,0x5DC60F03)]
	public class Messages_CheckHistoryImportPeer : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xE63BE13F)]
	public class Messages_SetChatTheme : IMethod
	{
		public InputPeer peer;
		public string emoticon;
	}

	[TLDef(167,0x31C1C44F)]
	public class Messages_GetMessageReadParticipants : IMethod
	{
		public InputPeer peer;
		public int msg_id;
	}

	[TLDef(167,0x49F0BDE9)]
	public class Messages_GetSearchResultsCalendar : IMethod
	{
		public InputPeer peer;
		public MessagesFilter filter;
		public int offset_id;
		public DateTime offset_date;
	}

	[TLDef(167,0x6E9583A3)]
	public class Messages_GetSearchResultsPositions : IMethod
	{
		public InputPeer peer;
		public MessagesFilter filter;
		public int offset_id;
		public int limit;
	}

	[TLDef(167,0x7FE7E815)]
	public class Messages_HideChatJoinRequest : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public InputUserBase user_id;

		[Flags] public enum Flags : uint
		{
			approved = 0x1,
		}
	}

	[TLDef(167,0xE085F4EA)]
	public class Messages_HideAllChatJoinRequests : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(1)] public string link;

		[Flags] public enum Flags : uint
		{
			approved = 0x1,
			has_link = 0x2,
		}
	}

	[TLDef(167,0xB11EAFA2)]
	public class Messages_ToggleNoForwards : IMethod
	{
		public InputPeer peer;
		public bool enabled;
	}

	[TLDef(167,0xCCFDDF96)]
	public class Messages_SaveDefaultSendAs : IMethod
	{
		public InputPeer peer;
		public InputPeer send_as;
	}

	[TLDef(167,0xD30D78D4)]
	public class Messages_SendReaction : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int msg_id;
		[IfFlag(0)] public Reaction[] reaction;

		[Flags] public enum Flags : uint
		{
			has_reaction = 0x1,
			big = 0x2,
			add_to_recent = 0x4,
		}
	}

	[TLDef(167,0x8BBA90E6)]
	public class Messages_GetMessagesReactions : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x461B3F48)]
	public class Messages_GetMessageReactionsList : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;
		[IfFlag(0)] public Reaction reaction;
		[IfFlag(1)] public string offset;
		public int limit;

		[Flags] public enum Flags : uint
		{
			has_reaction = 0x1,
			has_offset = 0x2,
		}
	}

	[TLDef(167,0xFEB16771)]
	public class Messages_SetChatAvailableReactions : IMethod
	{
		public InputPeer peer;
		public ChatReactions available_reactions;
	}

	[TLDef(167,0x18DEA0AC)]
	public class Messages_GetAvailableReactions : IMethod
	{
		public int hash;
	}

	[TLDef(167,0x4F47A016)]
	public class Messages_SetDefaultReaction : IMethod
	{
		public Reaction reaction;
	}

	[TLDef(167,0x63183030)]
	public class Messages_TranslateText : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public InputPeer peer;
		[IfFlag(0)] public int[] id;
		[IfFlag(1)] public TextWithEntities[] text;
		public string to_lang;

		[Flags] public enum Flags : uint
		{
			has_peer = 0x1,
			has_text = 0x2,
		}
	}

	[TLDef(167,0x3223495B)]
	public class Messages_GetUnreadReactions : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;
		public int offset_id;
		public int add_offset;
		public int limit;
		public int max_id;
		public int min_id;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x54AA7F8E)]
	public class Messages_ReadReactions : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public int top_msg_id;

		[Flags] public enum Flags : uint
		{
			has_top_msg_id = 0x1,
		}
	}

	[TLDef(167,0x107E31A0)]
	public class Messages_SearchSentMedia : IMethod
	{
		public string q;
		public MessagesFilter filter;
		public int limit;
	}

	[TLDef(167,0x16FCC2CB)]
	public class Messages_GetAttachMenuBots : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x77216192)]
	public class Messages_GetAttachMenuBot : IMethod
	{
		public InputUserBase bot;
	}

	[TLDef(167,0x69F59D69)]
	public class Messages_ToggleBotInAttachMenu : IMethod
	{
		public Flags flags;
		public InputUserBase bot;
		public bool enabled;

		[Flags] public enum Flags : uint
		{
			write_allowed = 0x1,
		}
	}

	[TLDef(167,0x269DC2C1)]
	public class Messages_RequestWebView : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public InputUserBase bot;
		[IfFlag(1)] public string url;
		[IfFlag(3)] public string start_param;
		[IfFlag(2)] public DataJSON theme_params;
		public string platform;
		[IfFlag(0)] public InputReplyTo reply_to;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_reply_to = 0x1,
			has_url = 0x2,
			has_theme_params = 0x4,
			has_start_param = 0x8,
			from_bot_menu = 0x10,
			silent = 0x20,
			has_send_as = 0x2000,
		}
	}

	[TLDef(167,0xB0D81A83)]
	public class Messages_ProlongWebView : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public InputUserBase bot;
		public long query_id;
		[IfFlag(0)] public InputReplyTo reply_to;
		[IfFlag(13)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_reply_to = 0x1,
			silent = 0x20,
			has_send_as = 0x2000,
		}
	}

	[TLDef(167,0x1A46500A)]
	public class Messages_RequestSimpleWebView : IMethod
	{
		public Flags flags;
		public InputUserBase bot;
		[IfFlag(3)] public string url;
		[IfFlag(4)] public string start_param;
		[IfFlag(0)] public DataJSON theme_params;
		public string platform;

		[Flags] public enum Flags : uint
		{
			has_theme_params = 0x1,
			from_switch_webview = 0x2,
			from_side_menu = 0x4,
			has_url = 0x8,
			has_start_param = 0x10,
		}
	}

	[TLDef(167,0x0A4314F5)]
	public class Messages_SendWebViewResultMessage : IMethod
	{
		public string bot_query_id;
		public InputBotInlineResultBase result;
	}

	[TLDef(167,0xDC0242C8)]
	public class Messages_SendWebViewData : IMethod
	{
		public InputUserBase bot;
		public long random_id;
		public string button_text;
		public string data;
	}

	[TLDef(167,0x269E9A49)]
	public class Messages_TranscribeAudio : IMethod
	{
		public InputPeer peer;
		public int msg_id;
	}

	[TLDef(167,0x7F1D072F)]
	public class Messages_RateTranscribedAudio : IMethod
	{
		public InputPeer peer;
		public int msg_id;
		public long transcription_id;
		public bool good;
	}

	[TLDef(167,0xD9AB0F54)]
	public class Messages_GetCustomEmojiDocuments : IMethod
	{
		public long[] document_id;
	}

	[TLDef(167,0xFBFCA18F)]
	public class Messages_GetEmojiStickers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x0ECF6736)]
	public class Messages_GetFeaturedEmojiStickers : IMethod
	{
		public long hash;
	}

	[TLDef(167,0x3F64C076)]
	public class Messages_ReportReaction : IMethod
	{
		public InputPeer peer;
		public int id;
		public InputPeer reaction_peer;
	}

	[TLDef(167,0xBB8125BA)]
	public class Messages_GetTopReactions : IMethod
	{
		public int limit;
		public long hash;
	}

	[TLDef(167,0x39461DB2)]
	public class Messages_GetRecentReactions : IMethod
	{
		public int limit;
		public long hash;
	}

	[TLDef(167,0x9DFEEFB4)]
	public class Messages_ClearRecentReactions : IMethod { }

	[TLDef(167,0x84F80814)]
	public class Messages_GetExtendedMedia : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x9EB51445)]
	public class Messages_SetDefaultHistoryTTL : IMethod
	{
		public int period;
	}

	[TLDef(167,0x658B7188)]
	public class Messages_GetDefaultHistoryTTL : IMethod { }

	[TLDef(167,0xFE38D01B)]
	public class Messages_SendBotRequestedPeer : IMethod
	{
		public InputPeer peer;
		public int msg_id;
		public int button_id;
		public InputPeer requested_peer;
	}

	[TLDef(167,0x7488CE5B)]
	public class Messages_GetEmojiGroups : IMethod
	{
		public int hash;
	}

	[TLDef(167,0x2ECD56CD)]
	public class Messages_GetEmojiStatusGroups : IMethod
	{
		public int hash;
	}

	[TLDef(167,0x21A548F3)]
	public class Messages_GetEmojiProfilePhotoGroups : IMethod
	{
		public int hash;
	}

	[TLDef(167,0x2C11C0D7)]
	public class Messages_SearchCustomEmoji : IMethod
	{
		public string emoticon;
		public long hash;
	}

	[TLDef(167,0xE47CB579)]
	public class Messages_TogglePeerTranslations : IMethod
	{
		public Flags flags;
		public InputPeer peer;

		[Flags] public enum Flags : uint
		{
			disabled = 0x1,
		}
	}

	[TLDef(167,0x34FDC5C3)]
	public class Messages_GetBotApp : IMethod
	{
		public InputBotApp app;
		public long hash;
	}

	[TLDef(167,0x8C5A3B3C)]
	public class Messages_RequestAppWebView : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public InputBotApp app;
		[IfFlag(1)] public string start_param;
		[IfFlag(2)] public DataJSON theme_params;
		public string platform;

		[Flags] public enum Flags : uint
		{
			write_allowed = 0x1,
			has_start_param = 0x2,
			has_theme_params = 0x4,
		}
	}

	[TLDef(167,0x8FFACAE1)]
	public class Messages_SetChatWallPaper : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(0)] public InputWallPaperBase wallpaper;
		[IfFlag(2)] public WallPaperSettings settings;
		[IfFlag(1)] public int id;

		[Flags] public enum Flags : uint
		{
			has_wallpaper = 0x1,
			has_id = 0x2,
			has_settings = 0x4,
			for_both = 0x8,
			revert = 0x10,
		}
	}

	[TLDef(167,0x92B4494C)]
	public class Messages_SearchEmojiStickerSets : IMethod
	{
		public Flags flags;
		public string q;
		public long hash;

		[Flags] public enum Flags : uint
		{
			exclude_featured = 0x1,
		}
	}

	[TLDef(167,0xEDD4882A)]
	public class Updates_GetState : IMethod { }

	[TLDef(167,0x19C2F763)]
	public class Updates_GetDifference : IMethod
	{
		public Flags flags;
		public int pts;
		[IfFlag(1)] public int pts_limit;
		[IfFlag(0)] public int pts_total_limit;
		public DateTime date;
		public int qts;
		[IfFlag(2)] public int qts_limit;

		[Flags] public enum Flags : uint
		{
			has_pts_total_limit = 0x1,
			has_pts_limit = 0x2,
			has_qts_limit = 0x4,
		}
	}

	[TLDef(167,0x03173D78)]
	public class Updates_GetChannelDifference : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public ChannelMessagesFilter filter;
		public int pts;
		public int limit;

		[Flags] public enum Flags : uint
		{
			force = 0x1,
		}
	}

	[TLDef(167,0x09E82039)]
	public class Photos_UpdateProfilePhoto : IMethod
	{
		public Flags flags;
		[IfFlag(1)] public InputUserBase bot;
		public InputPhoto id;

		[Flags] public enum Flags : uint
		{
			fallback = 0x1,
			has_bot = 0x2,
		}
	}

	[TLDef(167,0x0388A3B5)]
	public class Photos_UploadProfilePhoto : IMethod
	{
		public Flags flags;
		[IfFlag(5)] public InputUserBase bot;
		[IfFlag(0)] public InputFileBase file;
		[IfFlag(1)] public InputFileBase video;
		[IfFlag(2)] public double video_start_ts;
		[IfFlag(4)] public VideoSizeBase video_emoji_markup;

		[Flags] public enum Flags : uint
		{
			has_file = 0x1,
			has_video = 0x2,
			has_video_start_ts = 0x4,
			fallback = 0x8,
			has_video_emoji_markup = 0x10,
			has_bot = 0x20,
		}
	}

	[TLDef(167,0x87CF7F2F)]
	public class Photos_DeletePhotos : IMethod
	{
		public InputPhoto[] id;
	}

	[TLDef(167,0x91CD32A8)]
	public class Photos_GetUserPhotos : IMethod
	{
		public InputUserBase user_id;
		public int offset;
		public long max_id;
		public int limit;
	}

	[TLDef(167,0xE14C4A71)]
	public class Photos_UploadContactProfilePhoto : IMethod
	{
		public Flags flags;
		public InputUserBase user_id;
		[IfFlag(0)] public InputFileBase file;
		[IfFlag(1)] public InputFileBase video;
		[IfFlag(2)] public double video_start_ts;
		[IfFlag(5)] public VideoSizeBase video_emoji_markup;

		[Flags] public enum Flags : uint
		{
			has_file = 0x1,
			has_video = 0x2,
			has_video_start_ts = 0x4,
			suggest = 0x8,
			save = 0x10,
			has_video_emoji_markup = 0x20,
		}
	}

	[TLDef(167,0xB304A621)]
	public class Upload_SaveFilePart : IMethod
	{
		public long file_id;
		public int file_part;
		public byte[] bytes;
	}

	[TLDef(167,0xBE5335BE)]
	public class Upload_GetFile : IMethod
	{
		public Flags flags;
		public InputFileLocationBase location;
		public long offset;
		public int limit;

		[Flags] public enum Flags : uint
		{
			precise = 0x1,
			cdn_supported = 0x2,
		}
	}

	[TLDef(167,0xDE7B673D)]
	public class Upload_SaveBigFilePart : IMethod
	{
		public long file_id;
		public int file_part;
		public int file_total_parts;
		public byte[] bytes;
	}

	[TLDef(167,0x24E6818D)]
	public class Upload_GetWebFile : IMethod
	{
		public InputWebFileLocationBase location;
		public int offset;
		public int limit;
	}

	[TLDef(167,0x395F69DA)]
	public class Upload_GetCdnFile : IMethod
	{
		public byte[] file_token;
		public long offset;
		public int limit;
	}

	[TLDef(167,0x9B2754A8)]
	public class Upload_ReuploadCdnFile : IMethod
	{
		public byte[] file_token;
		public byte[] request_token;
	}

	[TLDef(167,0x91DC3F31)]
	public class Upload_GetCdnFileHashes : IMethod
	{
		public byte[] file_token;
		public long offset;
	}

	[TLDef(167,0x9156982A)]
	public class Upload_GetFileHashes : IMethod
	{
		public InputFileLocationBase location;
		public long offset;
	}

	[TLDef(167,0xC4F9186B)]
	public class Help_GetConfig : IMethod { }

	[TLDef(167,0x1FB33026)]
	public class Help_GetNearestDc : IMethod { }

	[TLDef(167,0x522D5A7D)]
	public class Help_GetAppUpdate : IMethod
	{
		public string source;
	}

	[TLDef(167,0x4D392343)]
	public class Help_GetInviteText : IMethod { }

	[TLDef(167,0x9CDF08CD)]
	public class Help_GetSupport : IMethod { }

	[TLDef(167,0x9010EF6F)]
	public class Help_GetAppChangelog : IMethod
	{
		public string prev_app_version;
	}

	[TLDef(167,0xEC22CFCD)]
	public class Help_SetBotUpdatesStatus : IMethod
	{
		public int pending_updates_count;
		public string message;
	}

	[TLDef(167,0x52029342)]
	public class Help_GetCdnConfig : IMethod { }

	[TLDef(167,0x3DC0F114)]
	public class Help_GetRecentMeUrls : IMethod
	{
		public string referer;
	}

	[TLDef(167,0x2CA51FD1)]
	public class Help_GetTermsOfServiceUpdate : IMethod { }

	[TLDef(167,0xEE72F79A)]
	public class Help_AcceptTermsOfService : IMethod
	{
		public DataJSON id;
	}

	[TLDef(167,0x3FEDC75F)]
	public class Help_GetDeepLinkInfo : IMethod
	{
		public string path;
	}

	[TLDef(167,0x61E3F854)]
	public class Help_GetAppConfig : IMethod
	{
		public int hash;
	}

	[TLDef(167,0x6F02F748)]
	public class Help_SaveAppLog : IMethod
	{
		public InputAppEvent[] events;
	}

	[TLDef(167,0xC661AD08)]
	public class Help_GetPassportConfig : IMethod
	{
		public int hash;
	}

	[TLDef(167,0xD360E72C)]
	public class Help_GetSupportName : IMethod { }

	[TLDef(167,0x038A08D3)]
	public class Help_GetUserInfo : IMethod
	{
		public InputUserBase user_id;
	}

	[TLDef(167,0x66B91B70)]
	public class Help_EditUserInfo : IMethod
	{
		public InputUserBase user_id;
		public string message;
		public MessageEntity[] entities;
	}

	[TLDef(167,0xC0977421)]
	public class Help_GetPromoData : IMethod { }

	[TLDef(167,0x1E251C95)]
	public class Help_HidePromoData : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xF50DBAA1)]
	public class Help_DismissSuggestion : IMethod
	{
		public InputPeer peer;
		public string suggestion;
	}

	[TLDef(167,0x735787A8)]
	public class Help_GetCountriesList : IMethod
	{
		public string lang_code;
		public int hash;
	}

	[TLDef(167,0xB81B93D4)]
	public class Help_GetPremiumPromo : IMethod { }

	[TLDef(167,0xDA80F42F)]
	public class Help_GetPeerColors : IMethod
	{
		public int hash;
	}

	[TLDef(167,0xABCFA9FD)]
	public class Help_GetPeerProfileColors : IMethod
	{
		public int hash;
	}

	[TLDef(167,0xCC104937)]
	public class Channels_ReadHistory : IMethod
	{
		public InputChannelBase channel;
		public int max_id;
	}

	[TLDef(167,0x84C1FD4E)]
	public class Channels_DeleteMessages : IMethod
	{
		public InputChannelBase channel;
		public int[] id;
	}

	[TLDef(167,0xF44A8315)]
	public class Channels_ReportSpam : IMethod
	{
		public InputChannelBase channel;
		public InputPeer participant;
		public int[] id;
	}

	[TLDef(167,0xAD8C9A23)]
	public class Channels_GetMessages : IMethod
	{
		public InputChannelBase channel;
		public InputMessage[] id;
	}

	[TLDef(167,0x77CED9D0)]
	public class Channels_GetParticipants : IMethod
	{
		public InputChannelBase channel;
		public ChannelParticipantsFilter filter;
		public int offset;
		public int limit;
		public long hash;
	}

	[TLDef(167,0xA0AB6CC6)]
	public class Channels_GetParticipant : IMethod
	{
		public InputChannelBase channel;
		public InputPeer participant;
	}

	[TLDef(167,0x0A7F6BBB)]
	public class Channels_GetChannels : IMethod
	{
		public InputChannelBase[] id;
	}

	[TLDef(167,0x08736A09)]
	public class Channels_GetFullChannel : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0x91006707)]
	public class Channels_CreateChannel : IMethod
	{
		public Flags flags;
		public string title;
		public string about;
		[IfFlag(2)] public InputGeoPoint geo_point;
		[IfFlag(2)] public string address;
		[IfFlag(4)] public int ttl_period;

		[Flags] public enum Flags : uint
		{
			broadcast = 0x1,
			megagroup = 0x2,
			has_geo_point = 0x4,
			for_import = 0x8,
			has_ttl_period = 0x10,
			forum = 0x20,
		}
	}

	[TLDef(167,0xD33C8902)]
	public class Channels_EditAdmin : IMethod
	{
		public InputChannelBase channel;
		public InputUserBase user_id;
		public ChatAdminRights admin_rights;
		public string rank;
	}

	[TLDef(167,0x566DECD0)]
	public class Channels_EditTitle : IMethod
	{
		public InputChannelBase channel;
		public string title;
	}

	[TLDef(167,0xF12E57C9)]
	public class Channels_EditPhoto : IMethod
	{
		public InputChannelBase channel;
		public InputChatPhotoBase photo;
	}

	[TLDef(167,0x10E6BD2C)]
	public class Channels_CheckUsername : IMethod
	{
		public InputChannelBase channel;
		public string username;
	}

	[TLDef(167,0x3514B3DE)]
	public class Channels_UpdateUsername : IMethod
	{
		public InputChannelBase channel;
		public string username;
	}

	[TLDef(167,0x24B524C5)]
	public class Channels_JoinChannel : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0xF836AA95)]
	public class Channels_LeaveChannel : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0x199F3A6C)]
	public class Channels_InviteToChannel : IMethod
	{
		public InputChannelBase channel;
		public InputUserBase[] users;
	}

	[TLDef(167,0xC0111FE3)]
	public class Channels_DeleteChannel : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0xE63FADEB)]
	public class Channels_ExportMessageLink : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public int id;

		[Flags] public enum Flags : uint
		{
			grouped = 0x1,
			thread = 0x2,
		}
	}

	[TLDef(167,0x1F69B606)]
	public class Channels_ToggleSignatures : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0xF8B036AF)]
	public class Channels_GetAdminedPublicChannels : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			by_location = 0x1,
			check_limit = 0x2,
		}
	}

	[TLDef(167,0x96E6CD81)]
	public class Channels_EditBanned : IMethod
	{
		public InputChannelBase channel;
		public InputPeer participant;
		public ChatBannedRights banned_rights;
	}

	[TLDef(167,0x33DDF480)]
	public class Channels_GetAdminLog : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public string q;
		[IfFlag(0)] public ChannelAdminLogEventsFilter events_filter;
		[IfFlag(1)] public InputUserBase[] admins;
		public long max_id;
		public long min_id;
		public int limit;

		[Flags] public enum Flags : uint
		{
			has_events_filter = 0x1,
			has_admins = 0x2,
		}
	}

	[TLDef(167,0xEA8CA4F9)]
	public class Channels_SetStickers : IMethod
	{
		public InputChannelBase channel;
		public InputStickerSet stickerset;
	}

	[TLDef(167,0xEAB5DC38)]
	public class Channels_ReadMessageContents : IMethod
	{
		public InputChannelBase channel;
		public int[] id;
	}

	[TLDef(167,0x9BAA9647)]
	public class Channels_DeleteHistory : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public int max_id;

		[Flags] public enum Flags : uint
		{
			for_everyone = 0x1,
		}
	}

	[TLDef(167,0xEABBB94C)]
	public class Channels_TogglePreHistoryHidden : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0x8341ECC0)]
	public class Channels_GetLeftChannels : IMethod
	{
		public int offset;
	}

	[TLDef(167,0xF5DAD378)]
	public class Channels_GetGroupsForDiscussion : IMethod { }

	[TLDef(167,0x40582BB2)]
	public class Channels_SetDiscussionGroup : IMethod
	{
		public InputChannelBase broadcast;
		public InputChannelBase group;
	}

	[TLDef(167,0x8F38CD1F)]
	public class Channels_EditCreator : IMethod
	{
		public InputChannelBase channel;
		public InputUserBase user_id;
		public InputCheckPasswordSRP password;
	}

	[TLDef(167,0x58E63F6D)]
	public class Channels_EditLocation : IMethod
	{
		public InputChannelBase channel;
		public InputGeoPoint geo_point;
		public string address;
	}

	[TLDef(167,0xEDD49EF0)]
	public class Channels_ToggleSlowMode : IMethod
	{
		public InputChannelBase channel;
		public int seconds;
	}

	[TLDef(167,0x11E831EE)]
	public class Channels_GetInactiveChannels : IMethod { }

	[TLDef(167,0x0B290C69)]
	public class Channels_ConvertToGigagroup : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0xBEAEDB94)]
	public class Channels_ViewSponsoredMessage : IMethod
	{
		public InputChannelBase channel;
		public byte[] random_id;
	}

	[TLDef(167,0xEC210FBF)]
	public class Channels_GetSponsoredMessages : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0x0DC770EE)]
	public class Channels_GetSendAs : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0x367544DB)]
	public class Channels_DeleteParticipantHistory : IMethod
	{
		public InputChannelBase channel;
		public InputPeer participant;
	}

	[TLDef(167,0xE4CB9580)]
	public class Channels_ToggleJoinToSend : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0x4C2985B6)]
	public class Channels_ToggleJoinRequest : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0xB45CED1D)]
	public class Channels_ReorderUsernames : IMethod
	{
		public InputChannelBase channel;
		public string[] order;
	}

	[TLDef(167,0x50F24105)]
	public class Channels_ToggleUsername : IMethod
	{
		public InputChannelBase channel;
		public string username;
		public bool active;
	}

	[TLDef(167,0x0A245DD3)]
	public class Channels_DeactivateAllUsernames : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0xA4298B29)]
	public class Channels_ToggleForum : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0xF40C0224)]
	public class Channels_CreateForumTopic : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public string title;
		[IfFlag(0)] public int icon_color;
		[IfFlag(3)] public long icon_emoji_id;
		public long random_id;
		[IfFlag(2)] public InputPeer send_as;

		[Flags] public enum Flags : uint
		{
			has_icon_color = 0x1,
			has_send_as = 0x4,
			has_icon_emoji_id = 0x8,
		}
	}

	[TLDef(167,0x0DE560D1)]
	public class Channels_GetForumTopics : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		[IfFlag(0)] public string q;
		public DateTime offset_date;
		public int offset_id;
		public int offset_topic;
		public int limit;

		[Flags] public enum Flags : uint
		{
			has_q = 0x1,
		}
	}

	[TLDef(167,0xB0831EB9)]
	public class Channels_GetForumTopicsByID : IMethod
	{
		public InputChannelBase channel;
		public int[] topics;
	}

	[TLDef(167,0xF4DFA185)]
	public class Channels_EditForumTopic : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public int topic_id;
		[IfFlag(0)] public string title;
		[IfFlag(1)] public long icon_emoji_id;
		[IfFlag(2)] public bool closed;
		[IfFlag(3)] public bool hidden;

		[Flags] public enum Flags : uint
		{
			has_title = 0x1,
			has_icon_emoji_id = 0x2,
			has_closed = 0x4,
			has_hidden = 0x8,
		}
	}

	[TLDef(167,0x6C2D9026)]
	public class Channels_UpdatePinnedForumTopic : IMethod
	{
		public InputChannelBase channel;
		public int topic_id;
		public bool pinned;
	}

	[TLDef(167,0x34435F2D)]
	public class Channels_DeleteTopicHistory : IMethod
	{
		public InputChannelBase channel;
		public int top_msg_id;
	}

	[TLDef(167,0x2950A18F)]
	public class Channels_ReorderPinnedForumTopics : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public int[] order;

		[Flags] public enum Flags : uint
		{
			force = 0x1,
		}
	}

	[TLDef(167,0x68F3E4EB)]
	public class Channels_ToggleAntiSpam : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0xA850A693)]
	public class Channels_ReportAntiSpamFalsePositive : IMethod
	{
		public InputChannelBase channel;
		public int msg_id;
	}

	[TLDef(167,0x6A6E7854)]
	public class Channels_ToggleParticipantsHidden : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0x18AFBC93)]
	public class Channels_ClickSponsoredMessage : IMethod
	{
		public InputChannelBase channel;
		public byte[] random_id;
	}

	[TLDef(167,0x621A201F)]
	public class Channels_UpdateColor : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public int color;
		[IfFlag(0)] public long background_emoji_id;

		[Flags] public enum Flags : uint
		{
			has_background_emoji_id = 0x1,
		}
	}

	[TLDef(167,0x9738BB15)]
	public class Channels_ToggleViewForumAsMessages : IMethod
	{
		public InputChannelBase channel;
		public bool enabled;
	}

	[TLDef(167,0x83B70D97)]
	public class Channels_GetChannelRecommendations : IMethod
	{
		public InputChannelBase channel;
	}

	[TLDef(167,0xAA2769ED)]
	public class Bots_SendCustomRequest : IMethod
	{
		public string custom_method;
		public DataJSON params_;
	}

	[TLDef(167,0xE6213F4D)]
	public class Bots_AnswerWebhookJSONQuery : IMethod
	{
		public long query_id;
		public DataJSON data;
	}

	[TLDef(167,0x0517165A)]
	public class Bots_SetBotCommands : IMethod
	{
		public BotCommandScope scope;
		public string lang_code;
		public BotCommand[] commands;
	}

	[TLDef(167,0x3D8DE0F9)]
	public class Bots_ResetBotCommands : IMethod
	{
		public BotCommandScope scope;
		public string lang_code;
	}

	[TLDef(167,0xE34C0DD6)]
	public class Bots_GetBotCommands : IMethod
	{
		public BotCommandScope scope;
		public string lang_code;
	}

	[TLDef(167,0x4504D54F)]
	public class Bots_SetBotMenuButton : IMethod
	{
		public InputUserBase user_id;
		public BotMenuButtonBase button;
	}

	[TLDef(167,0x9C60EB28)]
	public class Bots_GetBotMenuButton : IMethod
	{
		public InputUserBase user_id;
	}

	[TLDef(167,0x788464E1)]
	public class Bots_SetBotBroadcastDefaultAdminRights : IMethod
	{
		public ChatAdminRights admin_rights;
	}

	[TLDef(167,0x925EC9EA)]
	public class Bots_SetBotGroupDefaultAdminRights : IMethod
	{
		public ChatAdminRights admin_rights;
	}

	[TLDef(167,0x10CF3123)]
	public class Bots_SetBotInfo : IMethod
	{
		public Flags flags;
		[IfFlag(2)] public InputUserBase bot;
		public string lang_code;
		[IfFlag(3)] public string name;
		[IfFlag(0)] public string about;
		[IfFlag(1)] public string description;

		[Flags] public enum Flags : uint
		{
			has_about = 0x1,
			has_description = 0x2,
			has_bot = 0x4,
			has_name = 0x8,
		}
	}

	[TLDef(167,0xDCD914FD)]
	public class Bots_GetBotInfo : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public InputUserBase bot;
		public string lang_code;

		[Flags] public enum Flags : uint
		{
			has_bot = 0x1,
		}
	}

	[TLDef(167,0x9709B1C2)]
	public class Bots_ReorderUsernames : IMethod
	{
		public InputUserBase bot;
		public string[] order;
	}

	[TLDef(167,0x053CA973)]
	public class Bots_ToggleUsername : IMethod
	{
		public InputUserBase bot;
		public string username;
		public bool active;
	}

	[TLDef(167,0x1359F4E6)]
	public class Bots_CanSendMessage : IMethod
	{
		public InputUserBase bot;
	}

	[TLDef(167,0xF132E3EF)]
	public class Bots_AllowSendMessage : IMethod
	{
		public InputUserBase bot;
	}

	[TLDef(167,0x087FC5E7)]
	public class Bots_InvokeWebViewCustomMethod : IMethod
	{
		public InputUserBase bot;
		public string custom_method;
		public DataJSON params_;
	}

	[TLDef(167,0x37148DBB)]
	public class Payments_GetPaymentForm : IMethod
	{
		public Flags flags;
		public InputInvoice invoice;
		[IfFlag(0)] public DataJSON theme_params;

		[Flags] public enum Flags : uint
		{
			has_theme_params = 0x1,
		}
	}

	[TLDef(167,0x2478D1CC)]
	public class Payments_GetPaymentReceipt : IMethod
	{
		public InputPeer peer;
		public int msg_id;
	}

	[TLDef(167,0xB6C8F12B)]
	public class Payments_ValidateRequestedInfo : IMethod
	{
		public Flags flags;
		public InputInvoice invoice;
		public PaymentRequestedInfo info;

		[Flags] public enum Flags : uint
		{
			save = 0x1,
		}
	}

	[TLDef(167,0x2D03522F)]
	public class Payments_SendPaymentForm : IMethod
	{
		public Flags flags;
		public long form_id;
		public InputInvoice invoice;
		[IfFlag(0)] public string requested_info_id;
		[IfFlag(1)] public string shipping_option_id;
		public InputPaymentCredentialsBase credentials;
		[IfFlag(2)] public long tip_amount;

		[Flags] public enum Flags : uint
		{
			has_requested_info_id = 0x1,
			has_shipping_option_id = 0x2,
			has_tip_amount = 0x4,
		}
	}

	[TLDef(167,0x227D824B)]
	public class Payments_GetSavedInfo : IMethod { }

	[TLDef(167,0xD83D70C1)]
	public class Payments_ClearSavedInfo : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			credentials = 0x1,
			info = 0x2,
		}
	}

	[TLDef(167,0x2E79D779)]
	public class Payments_GetBankCardData : IMethod
	{
		public string number;
	}

	[TLDef(167,0x0F91B065)]
	public class Payments_ExportInvoice : IMethod
	{
		public InputMedia invoice_media;
	}

	[TLDef(167,0x80ED747D)]
	public class Payments_AssignAppStoreTransaction : IMethod
	{
		public byte[] receipt;
		public InputStorePaymentPurpose purpose;
	}

	[TLDef(167,0xDFFD50D3)]
	public class Payments_AssignPlayMarketTransaction : IMethod
	{
		public DataJSON receipt;
		public InputStorePaymentPurpose purpose;
	}

	[TLDef(167,0x9FC19EB6)]
	public class Payments_CanPurchasePremium : IMethod
	{
		public InputStorePaymentPurpose purpose;
	}

	[TLDef(167,0x2757BA54)]
	public class Payments_GetPremiumGiftCodeOptions : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public InputPeer boost_peer;

		[Flags] public enum Flags : uint
		{
			has_boost_peer = 0x1,
		}
	}

	[TLDef(167,0x8E51B4C1)]
	public class Payments_CheckGiftCode : IMethod
	{
		public string slug;
	}

	[TLDef(167,0xF6E26854)]
	public class Payments_ApplyGiftCode : IMethod
	{
		public string slug;
	}

	[TLDef(167,0xF4239425)]
	public class Payments_GetGiveawayInfo : IMethod
	{
		public InputPeer peer;
		public int msg_id;
	}

	[TLDef(167,0x5FF58F20)]
	public class Payments_LaunchPrepaidGiveaway : IMethod
	{
		public InputPeer peer;
		public long giveaway_id;
		public InputStorePaymentPurpose purpose;
	}

	[TLDef(167,0x9021AB67)]
	public class Stickers_CreateStickerSet : IMethod
	{
		public Flags flags;
		public InputUserBase user_id;
		public string title;
		public string short_name;
		[IfFlag(2)] public InputDocument thumb;
		public InputStickerSetItem[] stickers;
		[IfFlag(3)] public string software;

		[Flags] public enum Flags : uint
		{
			masks = 0x1,
			animated = 0x2,
			has_thumb = 0x4,
			has_software = 0x8,
			videos = 0x10,
			emojis = 0x20,
			text_color = 0x40,
		}
	}

	[TLDef(167,0xF7760F51)]
	public class Stickers_RemoveStickerFromSet : IMethod
	{
		public InputDocument sticker;
	}

	[TLDef(167,0xFFB6D4CA)]
	public class Stickers_ChangeStickerPosition : IMethod
	{
		public InputDocument sticker;
		public int position;
	}

	[TLDef(167,0x8653FEBE)]
	public class Stickers_AddStickerToSet : IMethod
	{
		public InputStickerSet stickerset;
		public InputStickerSetItem sticker;
	}

	[TLDef(167,0xA76A5392)]
	public class Stickers_SetStickerSetThumb : IMethod
	{
		public Flags flags;
		public InputStickerSet stickerset;
		[IfFlag(0)] public InputDocument thumb;
		[IfFlag(1)] public long thumb_document_id;

		[Flags] public enum Flags : uint
		{
			has_thumb = 0x1,
			has_thumb_document_id = 0x2,
		}
	}

	[TLDef(167,0x284B3639)]
	public class Stickers_CheckShortName : IMethod
	{
		public string short_name;
	}

	[TLDef(167,0x4DAFC503)]
	public class Stickers_SuggestShortName : IMethod
	{
		public string title;
	}

	[TLDef(167,0xF5537EBC)]
	public class Stickers_ChangeSticker : IMethod
	{
		public Flags flags;
		public InputDocument sticker;
		[IfFlag(0)] public string emoji;
		[IfFlag(1)] public MaskCoords mask_coords;
		[IfFlag(2)] public string keywords;

		[Flags] public enum Flags : uint
		{
			has_emoji = 0x1,
			has_mask_coords = 0x2,
			has_keywords = 0x4,
		}
	}

	[TLDef(167,0x124B1C00)]
	public class Stickers_RenameStickerSet : IMethod
	{
		public InputStickerSet stickerset;
		public string title;
	}

	[TLDef(167,0x87704394)]
	public class Stickers_DeleteStickerSet : IMethod
	{
		public InputStickerSet stickerset;
	}

	[TLDef(167,0x55451FA9)]
	public class Phone_GetCallConfig : IMethod { }

	[TLDef(167,0x42FF96ED)]
	public class Phone_RequestCall : IMethod
	{
		public Flags flags;
		public InputUserBase user_id;
		public int random_id;
		public byte[] g_a_hash;
		public PhoneCallProtocol protocol;

		[Flags] public enum Flags : uint
		{
			video = 0x1,
		}
	}

	[TLDef(167,0x3BD2B4A0)]
	public class Phone_AcceptCall : IMethod
	{
		public InputPhoneCall peer;
		public byte[] g_b;
		public PhoneCallProtocol protocol;
	}

	[TLDef(167,0x2EFE1722)]
	public class Phone_ConfirmCall : IMethod
	{
		public InputPhoneCall peer;
		public byte[] g_a;
		public long key_fingerprint;
		public PhoneCallProtocol protocol;
	}

	[TLDef(167,0x17D54F61)]
	public class Phone_ReceivedCall : IMethod
	{
		public InputPhoneCall peer;
	}

	[TLDef(167,0xB2CBC1C0)]
	public class Phone_DiscardCall : IMethod
	{
		public Flags flags;
		public InputPhoneCall peer;
		public int duration;
		public PhoneCallDiscardReason reason;
		public long connection_id;

		[Flags] public enum Flags : uint
		{
			video = 0x1,
		}
	}

	[TLDef(167,0x59EAD627)]
	public class Phone_SetCallRating : IMethod
	{
		public Flags flags;
		public InputPhoneCall peer;
		public int rating;
		public string comment;

		[Flags] public enum Flags : uint
		{
			user_initiative = 0x1,
		}
	}

	[TLDef(167,0x277ADD7E)]
	public class Phone_SaveCallDebug : IMethod
	{
		public InputPhoneCall peer;
		public DataJSON debug;
	}

	[TLDef(167,0xFF7A9383)]
	public class Phone_SendSignalingData : IMethod
	{
		public InputPhoneCall peer;
		public byte[] data;
	}

	[TLDef(167,0x48CDC6D8)]
	public class Phone_CreateGroupCall : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int random_id;
		[IfFlag(0)] public string title;
		[IfFlag(1)] public DateTime schedule_date;

		[Flags] public enum Flags : uint
		{
			has_title = 0x1,
			has_schedule_date = 0x2,
			rtmp_stream = 0x4,
		}
	}

	[TLDef(167,0xB132FF7B)]
	public class Phone_JoinGroupCall : IMethod
	{
		public Flags flags;
		public InputGroupCall call;
		public InputPeer join_as;
		[IfFlag(1)] public string invite_hash;
		public DataJSON params_;

		[Flags] public enum Flags : uint
		{
			muted = 0x1,
			has_invite_hash = 0x2,
			video_stopped = 0x4,
		}
	}

	[TLDef(167,0x500377F9)]
	public class Phone_LeaveGroupCall : IMethod
	{
		public InputGroupCall call;
		public int source;
	}

	[TLDef(167,0x7B393160)]
	public class Phone_InviteToGroupCall : IMethod
	{
		public InputGroupCall call;
		public InputUserBase[] users;
	}

	[TLDef(167,0x7A777135)]
	public class Phone_DiscardGroupCall : IMethod
	{
		public InputGroupCall call;
	}

	[TLDef(167,0x74BBB43D)]
	public class Phone_ToggleGroupCallSettings : IMethod
	{
		public Flags flags;
		public InputGroupCall call;
		[IfFlag(0)] public bool join_muted;

		[Flags] public enum Flags : uint
		{
			has_join_muted = 0x1,
			reset_invite_hash = 0x2,
		}
	}

	[TLDef(167,0x041845DB)]
	public class Phone_GetGroupCall : IMethod
	{
		public InputGroupCall call;
		public int limit;
	}

	[TLDef(167,0xC558D8AB)]
	public class Phone_GetGroupParticipants : IMethod
	{
		public InputGroupCall call;
		public InputPeer[] ids;
		public int[] sources;
		public string offset;
		public int limit;
	}

	[TLDef(167,0xB59CF977)]
	public class Phone_CheckGroupCall : IMethod
	{
		public InputGroupCall call;
		public int[] sources;
	}

	[TLDef(167,0xF128C708)]
	public class Phone_ToggleGroupCallRecord : IMethod
	{
		public Flags flags;
		public InputGroupCall call;
		[IfFlag(1)] public string title;
		[IfFlag(2)] public bool video_portrait;

		[Flags] public enum Flags : uint
		{
			start = 0x1,
			has_title = 0x2,
			video = 0x4,
		}
	}

	[TLDef(167,0xA5273ABF)]
	public class Phone_EditGroupCallParticipant : IMethod
	{
		public Flags flags;
		public InputGroupCall call;
		public InputPeer participant;
		[IfFlag(0)] public bool muted;
		[IfFlag(1)] public int volume;
		[IfFlag(2)] public bool raise_hand;
		[IfFlag(3)] public bool video_stopped;
		[IfFlag(4)] public bool video_paused;
		[IfFlag(5)] public bool presentation_paused;

		[Flags] public enum Flags : uint
		{
			has_muted = 0x1,
			has_volume = 0x2,
			has_raise_hand = 0x4,
			has_video_stopped = 0x8,
			has_video_paused = 0x10,
			has_presentation_paused = 0x20,
		}
	}

	[TLDef(167,0x1CA6AC0A)]
	public class Phone_EditGroupCallTitle : IMethod
	{
		public InputGroupCall call;
		public string title;
	}

	[TLDef(167,0xEF7C213A)]
	public class Phone_GetGroupCallJoinAs : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xE6AA647F)]
	public class Phone_ExportGroupCallInvite : IMethod
	{
		public Flags flags;
		public InputGroupCall call;

		[Flags] public enum Flags : uint
		{
			can_self_unmute = 0x1,
		}
	}

	[TLDef(167,0x219C34E6)]
	public class Phone_ToggleGroupCallStartSubscription : IMethod
	{
		public InputGroupCall call;
		public bool subscribed;
	}

	[TLDef(167,0x5680E342)]
	public class Phone_StartScheduledGroupCall : IMethod
	{
		public InputGroupCall call;
	}

	[TLDef(167,0x575E1F8C)]
	public class Phone_SaveDefaultGroupCallJoinAs : IMethod
	{
		public InputPeer peer;
		public InputPeer join_as;
	}

	[TLDef(167,0xCBEA6BC4)]
	public class Phone_JoinGroupCallPresentation : IMethod
	{
		public InputGroupCall call;
		public DataJSON params_;
	}

	[TLDef(167,0x1C50D144)]
	public class Phone_LeaveGroupCallPresentation : IMethod
	{
		public InputGroupCall call;
	}

	[TLDef(167,0x1AB21940)]
	public class Phone_GetGroupCallStreamChannels : IMethod
	{
		public InputGroupCall call;
	}

	[TLDef(167,0xDEB3ABBF)]
	public class Phone_GetGroupCallStreamRtmpUrl : IMethod
	{
		public InputPeer peer;
		public bool revoke;
	}

	[TLDef(167,0x41248786)]
	public class Phone_SaveCallLog : IMethod
	{
		public InputPhoneCall peer;
		public InputFileBase file;
	}

	[TLDef(167,0xF2F2330A)]
	public class Langpack_GetLangPack : IMethod
	{
		public string lang_pack;
		public string lang_code;
	}

	[TLDef(167,0xEFEA3803)]
	public class Langpack_GetStrings : IMethod
	{
		public string lang_pack;
		public string lang_code;
		public string[] keys;
	}

	[TLDef(167,0xCD984AA5)]
	public class Langpack_GetDifference : IMethod
	{
		public string lang_pack;
		public string lang_code;
		public int from_version;
	}

	[TLDef(167,0x42C6978F)]
	public class Langpack_GetLanguages : IMethod
	{
		public string lang_pack;
	}

	[TLDef(167,0x6A596502)]
	public class Langpack_GetLanguage : IMethod
	{
		public string lang_pack;
		public string lang_code;
	}

	[TLDef(167,0x6847D0AB)]
	public class Folders_EditPeerFolders : IMethod
	{
		public InputFolderPeer[] folder_peers;
	}

	[TLDef(167,0xAB42441A)]
	public class Stats_GetBroadcastStats : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;

		[Flags] public enum Flags : uint
		{
			dark = 0x1,
		}
	}

	[TLDef(167,0x621D5FA0)]
	public class Stats_LoadAsyncGraph : IMethod
	{
		public Flags flags;
		public string token;
		[IfFlag(0)] public long x;

		[Flags] public enum Flags : uint
		{
			has_x = 0x1,
		}
	}

	[TLDef(167,0xDCDF8607)]
	public class Stats_GetMegagroupStats : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;

		[Flags] public enum Flags : uint
		{
			dark = 0x1,
		}
	}

	[TLDef(167,0x5630281B)]
	public class Stats_GetMessagePublicForwards : IMethod
	{
		public InputChannelBase channel;
		public int msg_id;
		public int offset_rate;
		public InputPeer offset_peer;
		public int offset_id;
		public int limit;
	}

	[TLDef(167,0xB6E0A3F5)]
	public class Stats_GetMessageStats : IMethod
	{
		public Flags flags;
		public InputChannelBase channel;
		public int msg_id;

		[Flags] public enum Flags : uint
		{
			dark = 0x1,
		}
	}

	[TLDef(167,0x374FEF40)]
	public class Stats_GetStoryStats : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;

		[Flags] public enum Flags : uint
		{
			dark = 0x1,
		}
	}

	[TLDef(167,0xA6437EF6)]
	public class Stats_GetStoryPublicForwards : IMethod
	{
		public InputPeer peer;
		public int id;
		public string offset;
		public int limit;
	}

	[TLDef(167,0x8472478E)]
	public class Chatlists_ExportChatlistInvite : IMethod
	{
		public InputChatlist chatlist;
		public string title;
		public InputPeer[] peers;
	}

	[TLDef(167,0x719C5C5E)]
	public class Chatlists_DeleteExportedInvite : IMethod
	{
		public InputChatlist chatlist;
		public string slug;
	}

	[TLDef(167,0x653DB63D)]
	public class Chatlists_EditExportedInvite : IMethod
	{
		public Flags flags;
		public InputChatlist chatlist;
		public string slug;
		[IfFlag(1)] public string title;
		[IfFlag(2)] public InputPeer[] peers;

		[Flags] public enum Flags : uint
		{
			has_title = 0x2,
			has_peers = 0x4,
		}
	}

	[TLDef(167,0xCE03DA83)]
	public class Chatlists_GetExportedInvites : IMethod
	{
		public InputChatlist chatlist;
	}

	[TLDef(167,0x41C10FFF)]
	public class Chatlists_CheckChatlistInvite : IMethod
	{
		public string slug;
	}

	[TLDef(167,0xA6B1E39A)]
	public class Chatlists_JoinChatlistInvite : IMethod
	{
		public string slug;
		public InputPeer[] peers;
	}

	[TLDef(167,0x89419521)]
	public class Chatlists_GetChatlistUpdates : IMethod
	{
		public InputChatlist chatlist;
	}

	[TLDef(167,0xE089F8F5)]
	public class Chatlists_JoinChatlistUpdates : IMethod
	{
		public InputChatlist chatlist;
		public InputPeer[] peers;
	}

	[TLDef(167,0x66E486FB)]
	public class Chatlists_HideChatlistUpdates : IMethod
	{
		public InputChatlist chatlist;
	}

	[TLDef(167,0xFDBCD714)]
	public class Chatlists_GetLeaveChatlistSuggestions : IMethod
	{
		public InputChatlist chatlist;
	}

	[TLDef(167,0x74FAE13A)]
	public class Chatlists_LeaveChatlist : IMethod
	{
		public InputChatlist chatlist;
		public InputPeer[] peers;
	}

	[TLDef(167,0xC7DFDFDD)]
	public class Stories_CanSendStory : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0xE4E6694B)]
	public class Stories_SendStory : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public InputMedia media;
		[IfFlag(5)] public MediaArea[] media_areas;
		[IfFlag(0)] public string caption;
		[IfFlag(1)] public MessageEntity[] entities;
		public InputPrivacyRule[] privacy_rules;
		public long random_id;
		[IfFlag(3)] public int period;
		[IfFlag(6)] public InputPeer fwd_from_id;
		[IfFlag(6)] public int fwd_from_story;

		[Flags] public enum Flags : uint
		{
			has_caption = 0x1,
			has_entities = 0x2,
			pinned = 0x4,
			has_period = 0x8,
			noforwards = 0x10,
			has_media_areas = 0x20,
			has_fwd_from_id = 0x40,
			fwd_modified = 0x80,
		}
	}

	[TLDef(167,0xB583BA46)]
	public class Stories_EditStory : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int id;
		[IfFlag(0)] public InputMedia media;
		[IfFlag(3)] public MediaArea[] media_areas;
		[IfFlag(1)] public string caption;
		[IfFlag(1)] public MessageEntity[] entities;
		[IfFlag(2)] public InputPrivacyRule[] privacy_rules;

		[Flags] public enum Flags : uint
		{
			has_media = 0x1,
			has_caption = 0x2,
			has_privacy_rules = 0x4,
			has_media_areas = 0x8,
		}
	}

	[TLDef(167,0xAE59DB5F)]
	public class Stories_DeleteStories : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x9A75A1EF)]
	public class Stories_TogglePinned : IMethod
	{
		public InputPeer peer;
		public int[] id;
		public bool pinned;
	}

	[TLDef(167,0xEEB0D625)]
	public class Stories_GetAllStories : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public string state;

		[Flags] public enum Flags : uint
		{
			has_state = 0x1,
			next = 0x2,
			hidden = 0x4,
		}
	}

	[TLDef(167,0x5821A5DC)]
	public class Stories_GetPinnedStories : IMethod
	{
		public InputPeer peer;
		public int offset_id;
		public int limit;
	}

	[TLDef(167,0xB4352016)]
	public class Stories_GetStoriesArchive : IMethod
	{
		public InputPeer peer;
		public int offset_id;
		public int limit;
	}

	[TLDef(167,0x5774CA74)]
	public class Stories_GetStoriesByID : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x7C2557C4)]
	public class Stories_ToggleAllStoriesHidden : IMethod
	{
		public bool hidden;
	}

	[TLDef(167,0xA556DAC8)]
	public class Stories_ReadStories : IMethod
	{
		public InputPeer peer;
		public int max_id;
	}

	[TLDef(167,0xB2028AFB)]
	public class Stories_IncrementStoryViews : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x7ED23C57)]
	public class Stories_GetStoryViewsList : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		[IfFlag(1)] public string q;
		public int id;
		public string offset;
		public int limit;

		[Flags] public enum Flags : uint
		{
			just_contacts = 0x1,
			has_q = 0x2,
			reactions_first = 0x4,
		}
	}

	[TLDef(167,0x28E16CC8)]
	public class Stories_GetStoriesViews : IMethod
	{
		public InputPeer peer;
		public int[] id;
	}

	[TLDef(167,0x7B8DEF20)]
	public class Stories_ExportStoryLink : IMethod
	{
		public InputPeer peer;
		public int id;
	}

	[TLDef(167,0x1923FA8C)]
	public class Stories_Report : IMethod
	{
		public InputPeer peer;
		public int[] id;
		public ReportReason reason;
		public string message;
	}

	[TLDef(167,0x57BBD166)]
	public class Stories_ActivateStealthMode : IMethod
	{
		public Flags flags;

		[Flags] public enum Flags : uint
		{
			past = 0x1,
			future = 0x2,
		}
	}

	[TLDef(167,0x7FD736B2)]
	public class Stories_SendReaction : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public int story_id;
		public Reaction reaction;

		[Flags] public enum Flags : uint
		{
			add_to_recent = 0x1,
		}
	}

	[TLDef(167,0x2C4ADA50)]
	public class Stories_GetPeerStories : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0x9B5AE7F9)]
	public class Stories_GetAllReadPeerStories : IMethod { }

	[TLDef(167,0x535983C3)]
	public class Stories_GetPeerMaxIDs : IMethod
	{
		public InputPeer[] id;
	}

	[TLDef(167,0xA56A8B60)]
	public class Stories_GetChatsToSend : IMethod { }

	[TLDef(167,0xBD0415C4)]
	public class Stories_TogglePeerStoriesHidden : IMethod
	{
		public InputPeer peer;
		public bool hidden;
	}

	[TLDef(167,0x60F67660)]
	public class Premium_GetBoostsList : IMethod
	{
		public Flags flags;
		public InputPeer peer;
		public string offset;
		public int limit;

		[Flags] public enum Flags : uint
		{
			gifts = 0x1,
		}
	}

	[TLDef(167,0x0BE77B4A)]
	public class Premium_GetMyBoosts : IMethod { }

	[TLDef(167,0x6B7DA746)]
	public class Premium_ApplyBoost : IMethod
	{
		public Flags flags;
		[IfFlag(0)] public int[] slots;
		public InputPeer peer;

		[Flags] public enum Flags : uint
		{
			has_slots = 0x1,
		}
	}

	[TLDef(167,0x042F1F61)]
	public class Premium_GetBoostsStatus : IMethod
	{
		public InputPeer peer;
	}

	[TLDef(167,0x39854D1F)]
	public class Premium_GetUserBoosts : IMethod
	{
		public InputPeer peer;
		public InputUserBase user_id;
	}
}
