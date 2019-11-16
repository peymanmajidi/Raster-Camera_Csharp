
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;
using System.Runtime.InteropServices;
namespace RasterCamera
{
    /// <summary>
    /// CHCNetSDK µؤصھزھثµأ÷،£
    /// </summary>
    public class CHCNetSDK
    {
        public CHCNetSDK()
        {
            //
            // TODO: شع´ث´¦جي¼س¹¹شى؛¯ت‎آك¼­
            //
        }

        //SDKہàذح
        public const int SDK_PLAYMPEG4 = 1;//²¥·إ؟â
        public const int SDK_HCNETSDK = 2;//حّآç؟â

        public const int NAME_LEN = 32;//سأ»§أû³¤¶ب
        public const int PASSWD_LEN = 16;//أـآë³¤¶ب
        public const int GUID_LEN = 16;      //GUID³¤¶ب
        public const int DEV_TYPE_NAME_LEN = 24;      //ةè±¸ہàذحأû³ئ³¤¶ب
        public const int MAX_NAMELEN = 16;//DVR±¾µطµاآ½أû
        public const int MAX_RIGHT = 32;//ةè±¸ض§³ضµؤب¨دق£¨1-12±يت¾±¾µطب¨دق£¬13-32±يت¾ش¶³جب¨دق£©
        public const int SERIALNO_LEN = 48;//ذٍءذ؛إ³¤¶ب
        public const int MACADDR_LEN = 6;//macµطض·³¤¶ب
        public const int MAX_ETHERNET = 2;//ةè±¸؟ةإنزشج«حّآç
        public const int MAX_NETWORK_CARD = 4; //ةè±¸؟ةإن×î´َحّ؟¨ت‎ؤ؟
        public const int PATHNAME_LEN = 128;//آ·¾¶³¤¶ب

        public const int MAX_NUMBER_LEN = 32;	//؛إآë×î´َ³¤¶ب
        public const int MAX_NAME_LEN = 128; //ةè±¸أû³ئ×î´َ³¤¶ب

        public const int MAX_TIMESEGMENT_V30 = 8;//9000ةè±¸×î´َت±¼ن¶خت‎
        public const int MAX_TIMESEGMENT = 4;//8000ةè±¸×î´َت±¼ن¶خت‎
        public const int MAX_ICR_NUM = 8;   //×¥إؤ»ْ؛ىحâآث¹âئ¬ش¤ضأµمت‎

        public const int MAX_SHELTERNUM = 4;//8000ةè±¸×î´َصعµ²اّسٍت‎
        public const int PHONENUMBER_LEN = 32;//pppoe²¦؛إ؛إآë×î´َ³¤¶ب

        public const int MAX_DISKNUM = 16;//8000ةè±¸×î´َس²إجت‎
        public const int MAX_DISKNUM_V10 = 8;//1.2°و±¾ض®ا°°و±¾

        public const int MAX_WINDOW_V30 = 32;//9000ةè±¸±¾µطدشت¾×î´َ²¥·إ´°؟عت‎
        public const int MAX_WINDOW = 16;//8000ةè±¸×î´َس²إجت‎
        public const int MAX_VGA_V30 = 4;//9000ةè±¸×î´َ؟ة½سVGAت‎
        public const int MAX_VGA = 1;//8000ةè±¸×î´َ؟ة½سVGAت‎

        public const int MAX_USERNUM_V30 = 32;//9000ةè±¸×î´َسأ»§ت‎
        public const int MAX_USERNUM = 16;//8000ةè±¸×î´َسأ»§ت‎
        public const int MAX_EXCEPTIONNUM_V30 = 32;//9000ةè±¸×î´َزى³£´¦ہيت‎
        public const int MAX_EXCEPTIONNUM = 16;//8000ةè±¸×î´َزى³£´¦ہيت‎
        public const int MAX_LINK = 6;//8000ةè±¸µ¥ح¨µہ×î´َتسئµء÷ء¬½ست‎
        public const int MAX_ITC_EXCEPTIONOUT = 32;//×¥إؤ»ْ×î´َ±¨¾¯تن³ِ

        public const int MAX_DECPOOLNUM = 4;//µ¥آ·½âآëئ÷أ؟¸ِ½âآëح¨µہ×î´َ؟ةر­»·½âآëت‎
        public const int MAX_DECNUM = 4;//µ¥آ·½âآëئ÷µؤ×î´َ½âآëح¨µہت‎£¨تµ¼تض»سذز»¸ِ£¬ئنثûب‎¸ِ±£ءô£©
        public const int MAX_TRANSPARENTNUM = 2;//µ¥آ·½âآëئ÷؟ةإنضأ×î´َح¸أ÷ح¨µہت‎
        public const int MAX_CYCLE_CHAN = 16; //µ¥آ·½âآëئ÷×î´َآضر­ح¨µہت‎
        public const int MAX_CYCLE_CHAN_V30 = 64;//×î´َآضر¯ح¨µہت‎£¨ہ©ص¹£©
        public const int MAX_DIRNAME_LENGTH = 80;//×î´َؤ؟آ¼³¤¶ب

        public const int MAX_STRINGNUM_V30 = 8;//9000ةè±¸×î´َOSD×ض·ûذذت‎ت‎
        public const int MAX_STRINGNUM = 4;//8000ةè±¸×î´َOSD×ض·ûذذت‎ت‎
        public const int MAX_STRINGNUM_EX = 8;//8000¶¨ضئہ©ص¹
        public const int MAX_AUXOUT_V30 = 16;//9000ةè±¸×î´َ¸¨ضْتن³ِت‎
        public const int MAX_AUXOUT = 4;//8000ةè±¸×î´َ¸¨ضْتن³ِت‎
        public const int MAX_HD_GROUP = 16;//9000ةè±¸×î´َس²إج×éت‎
        public const int MAX_NFS_DISK = 8; //8000ةè±¸×î´َNFSس²إجت‎

        public const int IW_ESSID_MAX_SIZE = 32;//WIFIµؤSSID؛إ³¤¶ب
        public const int IW_ENCODING_TOKEN_MAX = 32;//WIFIأـثّ×î´َ×ض½عت‎
        public const int WIFI_WEP_MAX_KEY_COUNT = 4;
        public const int WIFI_WEP_MAX_KEY_LENGTH = 33;
        public const int WIFI_WPA_PSK_MAX_KEY_LENGTH = 63;
        public const int WIFI_WPA_PSK_MIN_KEY_LENGTH = 8;
        public const int WIFI_MAX_AP_COUNT = 20;
        public const int MAX_SERIAL_NUM = 64;//×î¶àض§³ضµؤح¸أ÷ح¨µہآ·ت‎
        public const int MAX_DDNS_NUMS = 10;//9000ةè±¸×î´َ؟ةإنddnsت‎
        public const int MAX_EMAIL_ADDR_LEN = 48;//×î´َemailµطض·³¤¶ب
        public const int MAX_EMAIL_PWD_LEN = 32;//×î´َemailأـآë³¤¶ب

        public const int MAXPROGRESS = 100;//»ط·إت±µؤ×î´َ°ظ·ضآت
        public const int MAX_SERIALNUM = 2;//8000ةè±¸ض§³ضµؤ´®؟عت‎ 1-232£¬ 2-485
        public const int CARDNUM_LEN = 20;//؟¨؛إ³¤¶ب
        public const int CARDNUM_LEN_OUT = 32; //حâ²؟½ل¹¹جه؟¨؛إ³¤¶ب
        public const int MAX_VIDEOOUT_V30 = 4;//9000ةè±¸µؤتسئµتن³ِت‎
        public const int MAX_VIDEOOUT = 2;//8000ةè±¸µؤتسئµتن³ِت‎

        public const int MAX_PRESET_V30 = 256;// 9000ةè±¸ض§³ضµؤشئج¨ش¤ضأµمت‎
        public const int MAX_TRACK_V30 = 256;// 9000ةè±¸ض§³ضµؤشئج¨¹ى¼£ت‎
        public const int MAX_CRUISE_V30 = 256;// 9000ةè±¸ض§³ضµؤشئج¨ر²؛½ت‎
        public const int MAX_PRESET = 128;// 8000ةè±¸ض§³ضµؤشئج¨ش¤ضأµمت‎ 
        public const int MAX_TRACK = 128;// 8000ةè±¸ض§³ضµؤشئج¨¹ى¼£ت‎
        public const int MAX_CRUISE = 128;// 8000ةè±¸ض§³ضµؤشئج¨ر²؛½ت‎ 

        public const int CRUISE_MAX_PRESET_NUMS = 32;// ز»جُر²؛½×î¶àµؤر²؛½µم 

        public const int MAX_SERIAL_PORT = 8;//9000ةè±¸ض§³ض232´®؟عت‎
        public const int MAX_PREVIEW_MODE = 8;// ةè±¸ض§³ض×î´َش¤ہہؤ£ت½ت‎ؤ؟ 1»­أو,4»­أو,9»­أو,16»­أو.... 
        public const int MAX_MATRIXOUT = 16;// ×î´َؤ£ؤâ¾طصَتن³ِ¸ِت‎ 
        public const int LOG_INFO_LEN = 11840; // بصض¾¸½¼سذإد¢ 
        public const int DESC_LEN = 16;// شئج¨أèتِ×ض·û´®³¤¶ب 
        public const int PTZ_PROTOCOL_NUM = 200;// 9000×î´َض§³ضµؤشئج¨ذ­زéت‎ 

        public const int MAX_AUDIO = 1;//8000سïزô¶ش½²ح¨µہت‎
        public const int MAX_AUDIO_V30 = 2;//9000سïزô¶ش½²ح¨µہت‎
        public const int MAX_CHANNUM = 16;//8000ةè±¸×î´َح¨µہت‎
        public const int MAX_ALARMIN = 16;//8000ةè±¸×î´َ±¨¾¯تنبëت‎
        public const int MAX_ALARMOUT = 4;//8000ةè±¸×î´َ±¨¾¯تن³ِت‎
        //9000 IPC½سبë
        public const int MAX_ANALOG_CHANNUM = 32;//×î´َ32¸ِؤ£ؤâح¨µہ
        public const int MAX_ANALOG_ALARMOUT = 32; //×î´َ32آ·ؤ£ؤâ±¨¾¯تن³ِ 
        public const int MAX_ANALOG_ALARMIN = 32;//×î´َ32آ·ؤ£ؤâ±¨¾¯تنبë

        public const int MAX_IP_DEVICE = 32;//شتذي½سبëµؤ×î´َIPةè±¸ت‎
        public const int MAX_IP_DEVICE_V40 = 64;//شتذي½سبëµؤ×î´َIPةè±¸ت‎
        public const int MAX_IP_CHANNEL = 32;//شتذي¼سبëµؤ×î¶àIPح¨µہت‎
        public const int MAX_IP_ALARMIN = 128;//شتذي¼سبëµؤ×î¶à±¨¾¯تنبëت‎
        public const int MAX_IP_ALARMOUT = 64;//شتذي¼سبëµؤ×î¶à±¨¾¯تن³ِت‎
        public const int MAX_IP_ALARMIN_V40 = 4096;    //شتذي¼سبëµؤ×î¶à±¨¾¯تنبëت‎
        public const int MAX_IP_ALARMOUT_V40 = 4096;    //شتذي¼سبëµؤ×î¶à±¨¾¯تن³ِت‎

        public const int MAX_RECORD_FILE_NUM = 20;      // أ؟´خة¾³‎»ٍصك؟جآ¼µؤ×î´َخؤ¼‏ت‎

        //SDK_V31 ATM
        public const int MAX_ATM_NUM = 1;
        public const int MAX_ACTION_TYPE = 12;
        public const int ATM_FRAMETYPE_NUM = 4;
        public const int MAX_ATM_PROTOCOL_NUM = 1025;
        public const int ATM_PROTOCOL_SORT = 4;
        public const int ATM_DESC_LEN = 32;
        // SDK_V31 ATM

        /* ×î´َض§³ضµؤح¨µہت‎ ×î´َؤ£ؤâ¼سةد×î´َIPض§³ض */
        public const int MAX_CHANNUM_V30 = MAX_ANALOG_CHANNUM + MAX_IP_CHANNEL;//64
        public const int MAX_ALARMOUT_V30 = MAX_ANALOG_ALARMOUT + MAX_IP_ALARMOUT;//96
        public const int MAX_ALARMIN_V30 = MAX_ANALOG_ALARMIN + MAX_IP_ALARMIN;//160

        public const int MAX_CHANNUM_V40 = 512;
        public const int MAX_ALARMOUT_V40 = MAX_IP_ALARMOUT_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_ALARMIN_V40 = MAX_IP_ALARMIN_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_MULTI_AREA_NUM = 24;

        public const int MAX_HUMAN_PICTURE_NUM = 10;   //×î´َصصئ¬ت‎
        public const int MAX_HUMAN_BIRTHDATE_LEN = 10;

        public const int MAX_LAYERNUMS = 32;

        public const int MAX_ROIDETECT_NUM = 8;    //ض§³ضµؤROIاّسٍت‎
        public const int MAX_LANERECT_NUM   =     5;    //×î´َ³µإئت¶±ًاّسٍت‎
        public const int MAX_FORTIFY_NUM   =      10;   //×î´َ²¼·ہ¸ِت‎
        public const int MAX_INTERVAL_NUM  =      4;    //×î´َت±¼ن¼ن¸ô¸ِت‎
        public const int MAX_CHJC_NUM     =       3;    //×î´َ³µء¾ت،·ف¼ٍ³ئ×ض·û¸ِت‎
        public const int MAX_VL_NUM        =      5;    //×î´َذéؤâدكب¦¸ِت‎
        public const int MAX_DRIVECHAN_NUM =      16;   //×î´َ³µµہت‎
        public const int MAX_COIL_NUM      =      3;    //×î´َدكب¦¸ِت‎
        public const int MAX_SIGNALLIGHT_NUM =    6;   //×î´َذإ؛إµئ¸ِت‎
        public const int LEN_32             =   32;
        public const int LEN_31             =   31;
        public const int MAX_CABINET_COUNT  =     8;    //×î´َض§³ض»ْ¹ٌت‎ء؟
        public const int MAX_ID_LEN         =     48;
        public const int MAX_PARKNO_LEN    =      16;
        public const int MAX_ALARMREASON_LEN =    32;
        public const int MAX_UPGRADE_INFO_LEN=    48; //»ٌب،ة‎¼¶خؤ¼‏ئ¥إنذإد¢(ؤ£؛‎ة‎¼¶)
        public const int MAX_CUSTOMDIR_LEN  =     32; //×ش¶¨زهؤ؟آ¼³¤¶ب

        public const int MAX_TRANSPARENT_CHAN_NUM  =    4;   //أ؟¸ِ´®؟عشتذي½¨ء¢µؤ×î´َح¸أ÷ح¨µہت‎
        public const int MAX_TRANSPARENT_ACCESS_NUM =   4;   //أ؟¸ِ¼àج‎¶ث؟عشتذي½سبëµؤ×î´َض÷»ْت‎

        //ITS
        public const int MAX_PARKING_STATUS  =     8;    //³µخ»×´ج¬ 0´ْ±يخق³µ£¬1´ْ±يسذ³µ£¬2´ْ±ير¹دك(سإدب¼¶×î¸ك), 3جطتâ³µخ» 
        public const int MAX_PARKING_NUM       =      4;    //ز»¸ِح¨µہ×î´َ4¸ِ³µخ» (´س×َµ½سز³µخ» ت‎×é0،«3)

        public const int MAX_ITS_SCENE_NUM    =    16;   //×î´َ³،¾°ت‎ء؟
        public const int MAX_SCENE_TIMESEG_NUM =   16;   //×î´َ³،¾°ت±¼ن¶خت‎ء؟
        public const int MAX_IVMS_IP_CHANNEL  =    128;  //×î´َIPح¨µہت‎
        public const int DEVICE_ID_LEN      =      48;   //ةè±¸±à؛إ³¤¶ب
        public const int MONITORSITE_ID_LEN  =     48;   //¼à²âµم±à؛إ³¤¶ب
        public const int MAX_AUXAREA_NUM       =   16;   //¸¨ضْاّسٍ×î´َت‎ؤ؟
        public const int MAX_SLAVE_CHANNEL_NUM =   16;   //×î´َ´سح¨µہت‎ء؟

        public const int MAX_SCH_TASKS_NUM = 10;

        public const int MAX_SERVERID_LEN   =         64; //×î´َ·‏خٌئ÷IDµؤ³¤¶ب
        public const int MAX_SERVERDOMAIN_LEN =       128; //·‏خٌئ÷سٍأû×î´َ³¤¶ب
        public const int MAX_AUTHENTICATEID_LEN =     64; //بدض¤ID×î´َ³¤¶ب
        public const int MAX_AUTHENTICATEPASSWD_LEN = 32; //بدض¤أـآë×î´َ³¤¶ب
        public const int MAX_SERVERNAME_LEN =         64; //×î´َ·‏خٌئ÷سأ»§أû 
        public const int MAX_COMPRESSIONID_LEN =      64; //±àآëIDµؤ×î´َ³¤¶ب
        public const int MAX_SIPSERVER_ADDRESS_LEN =  128; //SIP·‏خٌئ÷µطض·ض§³ضسٍأû؛حIPµطض·
        //ر¹دك±¨¾¯
        public const int MAX_PlATE_NO_LEN =        32;   //³µإئ؛إآë×î´َ³¤¶ب 2013-09-27
        public const int UPNP_PORT_NUM  =       12;   //upnp¶ث؟عس³ةن¶ث؟عت‎ؤ؟


        public const int MAX_LOCAL_ADDR_LEN = 96;		//SOCKS×î´َ±¾µطحّ¶خ¸ِت‎
        public const int MAX_COUNTRY_NAME_LEN = 4;		//¹ْ¼ز¼ٍذ´أû³ئ³¤¶ب

        //آëء÷ء¬½س·½ت½
        public const int NORMALCONNECT = 1;
        public const int MEDIACONNECT = 2;

        //ةè±¸ذح؛إ(´َہà)
        public const int HCDVR = 1;
        public const int MEDVR = 2;
        public const int PCDVR = 3;
        public const int HC_9000 = 4;
        public const int HF_I = 5;
        public const int PCNVR = 6;
        public const int HC_76NVR = 8;

        //NVRہàذح
        public const int DS8000HC_NVR = 0;
        public const int DS9000HC_NVR = 1;
        public const int DS8000ME_NVR = 2;

        /*******************ب«¾ض´يخَآë begin**********************/
        public const int NET_DVR_NOERROR = 0;//أ»سذ´يخَ
        public const int NET_DVR_PASSWORD_ERROR = 1;//سأ»§أûأـآë´يخَ
        public const int NET_DVR_NOENOUGHPRI = 2;//ب¨دق²»×م
        public const int NET_DVR_NOINIT = 3;//أ»سذ³ُت¼»¯
        public const int NET_DVR_CHANNEL_ERROR = 4;//ح¨µہ؛إ´يخَ
        public const int NET_DVR_OVER_MAXLINK = 5;//ء¬½سµ½DVRµؤ؟ح»§¶ث¸ِت‎³¬¹‎×î´َ
        public const int NET_DVR_VERSIONNOMATCH = 6;//°و±¾²»ئ¥إن
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;//ء¬½س·‏خٌئ÷ت§°ـ
        public const int NET_DVR_NETWORK_SEND_ERROR = 8;//دٍ·‏خٌئ÷·¢ثحت§°ـ
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;//´س·‏خٌئ÷½ستصت‎¾فت§°ـ
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;//´س·‏خٌئ÷½ستصت‎¾ف³¬ت±
        public const int NET_DVR_NETWORK_ERRORDATA = 11;//´«ثحµؤت‎¾فسذخَ
        public const int NET_DVR_ORDER_ERROR = 12;//µ÷سأ´خذٍ´يخَ
        public const int NET_DVR_OPERNOPERMIT = 13;//خق´ثب¨دق
        public const int NET_DVR_COMMANDTIMEOUT = 14;//DVRأüءîض´ذذ³¬ت±
        public const int NET_DVR_ERRORSERIALPORT = 15;//´®؟ع؛إ´يخَ
        public const int NET_DVR_ERRORALARMPORT = 16;//±¨¾¯¶ث؟ع´يخَ
        public const int NET_DVR_PARAMETER_ERROR = 17;//²خت‎´يخَ
        public const int NET_DVR_CHAN_EXCEPTION = 18;//·‏خٌئ÷ح¨µہ´¦سع´يخَ×´ج¬
        public const int NET_DVR_NODISK = 19;//أ»سذس²إج
        public const int NET_DVR_ERRORDISKNUM = 20;//س²إج؛إ´يخَ
        public const int NET_DVR_DISK_FULL = 21;//·‏خٌئ÷س²إجآْ
        public const int NET_DVR_DISK_ERROR = 22;//·‏خٌئ÷س²إج³ِ´ي
        public const int NET_DVR_NOSUPPORT = 23;//·‏خٌئ÷²»ض§³ض
        public const int NET_DVR_BUSY = 24;//·‏خٌئ÷أ¦
        public const int NET_DVR_MODIFY_FAIL = 25;//·‏خٌئ÷ذق¸ؤ²»³ة¹¦
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;//أـآëتنبë¸ٌت½²»ص‎ب·
        public const int NET_DVR_DISK_FORMATING = 27;//س²إجص‎شع¸ٌت½»¯£¬²»ؤـئô¶¯²ظ×÷
        public const int NET_DVR_DVRNORESOURCE = 28;//DVR×تش´²»×م
        public const int NET_DVR_DVROPRATEFAILED = 29;//DVR²ظ×÷ت§°ـ
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;//´ٍ؟ھPCةùزôت§°ـ
        public const int NET_DVR_DVRVOICEOPENED = 31;//·‏خٌئ÷سïزô¶ش½²±»ص¼سأ
        public const int NET_DVR_TIMEINPUTERROR = 32;//ت±¼نتنبë²»ص‎ب·
        public const int NET_DVR_NOSPECFILE = 33;//»ط·إت±·‏خٌئ÷أ»سذض¸¶¨µؤخؤ¼‏
        public const int NET_DVR_CREATEFILE_ERROR = 34;//´´½¨خؤ¼‏³ِ´ي
        public const int NET_DVR_FILEOPENFAIL = 35;//´ٍ؟ھخؤ¼‏³ِ´ي
        public const int NET_DVR_OPERNOTFINISH = 36; //ةد´خµؤ²ظ×÷»¹أ»سذحê³ة
        public const int NET_DVR_GETPLAYTIMEFAIL = 37;//»ٌب،µ±ا°²¥·إµؤت±¼ن³ِ´ي
        public const int NET_DVR_PLAYFAIL = 38;//²¥·إ³ِ´ي
        public const int NET_DVR_FILEFORMAT_ERROR = 39;//خؤ¼‏¸ٌت½²»ص‎ب·
        public const int NET_DVR_DIR_ERROR = 40;//آ·¾¶´يخَ
        public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;//×تش´·ضإن´يخَ
        public const int NET_DVR_AUDIO_MODE_ERROR = 42;//ةù؟¨ؤ£ت½´يخَ
        public const int NET_DVR_NOENOUGH_BUF = 43;//»؛³هاّج«ذ،
        public const int NET_DVR_CREATESOCKET_ERROR = 44;//´´½¨SOCKET³ِ´ي
        public const int NET_DVR_SETSOCKET_ERROR = 45;//ةèضأSOCKET³ِ´ي
        public const int NET_DVR_MAX_NUM = 46;//¸ِت‎´ïµ½×î´َ
        public const int NET_DVR_USERNOTEXIST = 47;//سأ»§²»´وشع
        public const int NET_DVR_WRITEFLASHERROR = 48;//ذ´FLASH³ِ´ي
        public const int NET_DVR_UPGRADEFAIL = 49;//DVRة‎¼¶ت§°ـ
        public const int NET_DVR_CARDHAVEINIT = 50;//½âآë؟¨زر¾­³ُت¼»¯¹‎
        public const int NET_DVR_PLAYERFAILED = 51;//µ÷سأ²¥·إ؟âضذؤ³¸ِ؛¯ت‎ت§°ـ
        public const int NET_DVR_MAX_USERNUM = 52;//ةè±¸¶ثسأ»§ت‎´ïµ½×î´َ
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;//»ٌµأ؟ح»§¶ثµؤIPµطض·»ٍخïہيµطض·ت§°ـ
        public const int NET_DVR_NOENCODEING = 54;//¸أح¨µہأ»سذ±àآë
        public const int NET_DVR_IPMISMATCH = 55;//IPµطض·²»ئ¥إن
        public const int NET_DVR_MACMISMATCH = 56;//MACµطض·²»ئ¥إن
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;//ة‎¼¶خؤ¼‏سïرش²»ئ¥إن
        public const int NET_DVR_MAX_PLAYERPORT = 58;//²¥·إئ÷آ·ت‎´ïµ½×î´َ
        public const int NET_DVR_NOSPACEBACKUP = 59;//±¸·فةè±¸ضذأ»سذ×م¹»؟ص¼ن½ّذذ±¸·ف
        public const int NET_DVR_NODEVICEBACKUP = 60;//أ»سذصزµ½ض¸¶¨µؤ±¸·فةè±¸
        public const int NET_DVR_PICTURE_BITS_ERROR = 61;//ح¼دٌثطخ»ت‎²»·û£¬دق24ة«
        public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;//ح¼ئ¬¸ك*؟ي³¬دق£¬ دق128*256
        public const int NET_DVR_PICTURE_SIZ_ERROR = 63;//ح¼ئ¬´َذ،³¬دق£¬دق100K
        public const int NET_DVR_LOADPLAYERSDKFAILED = 64;//شطبëµ±ا°ؤ؟آ¼دآPlayer Sdk³ِ´ي
        public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;//صز²»µ½Player Sdkضذؤ³¸ِ؛¯ت‎بë؟ع
        public const int NET_DVR_LOADDSSDKFAILED = 66;//شطبëµ±ا°ؤ؟آ¼دآDSsdk³ِ´ي
        public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;//صز²»µ½DsSdkضذؤ³¸ِ؛¯ت‎بë؟ع
        public const int NET_DVR_DSSDK_ERROR = 68;//µ÷سأس²½âآë؟âDsSdkضذؤ³¸ِ؛¯ت‎ت§°ـ
        public const int NET_DVR_VOICEMONOPOLIZE = 69;//ةù؟¨±»¶ہص¼
        public const int NET_DVR_JOINMULTICASTFAILED = 70;//¼سبë¶à²¥×éت§°ـ
        public const int NET_DVR_CREATEDIR_ERROR = 71;//½¨ء¢بصض¾خؤ¼‏ؤ؟آ¼ت§°ـ
        public const int NET_DVR_BINDSOCKET_ERROR = 72;//°َ¶¨ج×½س×ضت§°ـ
        public const int NET_DVR_SOCKETCLOSE_ERROR = 73;//socketء¬½سضذ¶د£¬´ث´يخَح¨³£تاسةسعء¬½سضذ¶د»ٍؤ؟µؤµط²»؟ة´ï
        public const int NET_DVR_USERID_ISUSING = 74;//×¢دْت±سأ»§IDص‎شع½ّذذؤ³²ظ×÷
        public const int NET_DVR_SOCKETLISTEN_ERROR = 75;//¼àج‎ت§°ـ
        public const int NET_DVR_PROGRAM_EXCEPTION = 76;//³جذٍزى³£
        public const int NET_DVR_WRITEFILE_FAILED = 77;//ذ´خؤ¼‏ت§°ـ
        public const int NET_DVR_FORMAT_READONLY = 78;//½ûض¹¸ٌت½»¯ض»¶ءس²إج
        public const int NET_DVR_WITHSAMEUSERNAME = 79;//سأ»§إنضأ½ل¹¹ضذ´وشعدàح¬µؤسأ»§أû
        public const int NET_DVR_DEVICETYPE_ERROR = 80;//µ¼بë²خت‎ت±ةè±¸ذح؛إ²»ئ¥إن
        public const int NET_DVR_LANGUAGE_ERROR = 81;//µ¼بë²خت‎ت±سïرش²»ئ¥إن
        public const int NET_DVR_PARAVERSION_ERROR = 82;//µ¼بë²خت‎ت±بي¼‏°و±¾²»ئ¥إن
        public const int NET_DVR_IPCHAN_NOTALIVE = 83; //ش¤ہہت±حâ½سIPح¨µہ²»شعدك
        public const int NET_DVR_RTSP_SDK_ERROR = 84;//¼سشط¸كاهIPCح¨ر¶؟âStreamTransClient.dllت§°ـ
        public const int NET_DVR_CONVERT_SDK_ERROR = 85;//¼سشط×ھآë؟âت§°ـ
        public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;//³¬³ِ×î´َµؤip½سبëح¨µہت‎

        public const int NET_PLAYM4_NOERROR = 500;//no error
        public const int NET_PLAYM4_PARA_OVER = 501;//input parameter is invalid
        public const int NET_PLAYM4_ORDER_ERROR = 502;//The order of the function to be called is error
        public const int NET_PLAYM4_TIMER_ERROR = 503;//Create multimedia clock failed
        public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;//Decode video data failed
        public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;//Decode audio data failed
        public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;//Allocate memory failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;//Open the file failed
        public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;//Create thread or event failed
        public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;//Create DirectDraw object failed
        public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;//failed when creating off-screen surface
        public const int NET_PLAYM4_BUF_OVER = 511;//buffer is overflow
        public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;//failed when creating audio device
        public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;//Set volume failed
        public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;//The function only support play file
        public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;//The function only support play stream
        public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;//System not support
        public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;//No file header
        public const int NET_PLAYM4_VERSION_INCORRECT = 518;//The version of decoder and encoder is not adapted
        public const int NET_PALYM4_INIT_DECODER_ERROR = 519;//Initialize decoder failed
        public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;//The file data is unknown
        public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;//Initialize multimedia clock failed
        public const int NET_PLAYM4_BLT_ERROR = 522;//Blt failed
        public const int NET_PLAYM4_UPDATE_ERROR = 523;//Update failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;//openfile error, streamtype is multi
        public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;//openfile error, streamtype is video
        public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;//JPEG compress error
        public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;//Don't support the version of this file
        public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;//extract video data failed
        /*******************ب«¾ض´يخَآë end**********************/

        /*************************************************
        NET_DVR_IsSupport()·µ»طضµ
        1£­9خ»·ض±ً±يت¾زشدآذإد¢£¨خ»سëتاTRUE)±يت¾ض§³ض£»
        **************************************************/
        public const int NET_DVR_SUPPORT_DDRAW = 1;//ض§³ضDIRECTDRAW£¬بç¹û²»ض§³ض£¬شٍ²¥·إئ÷²»ؤـ¹¤×÷
        public const int NET_DVR_SUPPORT_BLT = 2;//دش؟¨ض§³ضBLT²ظ×÷£¬بç¹û²»ض§³ض£¬شٍ²¥·إئ÷²»ؤـ¹¤×÷
        public const int NET_DVR_SUPPORT_BLTFOURCC = 4;//دش؟¨BLTض§³ضرصة«×ھ»»£¬بç¹û²»ض§³ض£¬²¥·إئ÷»لسأبي¼‏·½·¨×÷RGB×ھ»»
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 8;//دش؟¨BLTض§³ضXضلثُذ،£»بç¹û²»ض§³ض£¬دµح³»لسأبي¼‏·½·¨×ھ»»
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 16;//دش؟¨BLTض§³ضYضلثُذ،£»بç¹û²»ض§³ض£¬دµح³»لسأبي¼‏·½·¨×ھ»»
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 32;//دش؟¨BLTض§³ضXضل·إ´َ£»بç¹û²»ض§³ض£¬دµح³»لسأبي¼‏·½·¨×ھ»»
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 64;//دش؟¨BLTض§³ضYضل·إ´َ£»بç¹û²»ض§³ض£¬دµح³»لسأبي¼‏·½·¨×ھ»»
        public const int NET_DVR_SUPPORT_SSE = 128;//CPUض§³ضSSEض¸ءî£¬Intel Pentium3زشةدض§³ضSSEض¸ءî
        public const int NET_DVR_SUPPORT_MMX = 256;//CPUض§³ضMMXض¸ءî¼¯£¬Intel Pentium3زشةدض§³ضSSEض¸ءî

        /**********************شئج¨؟طضئأüءî begin*************************/
        public const int LIGHT_PWRON = 2;// ½سح¨µئ¹âµçش´
        public const int WIPER_PWRON = 3;// ½سح¨سêث¢؟ھ¹ط 
        public const int FAN_PWRON = 4;// ½سح¨·çةب؟ھ¹ط
        public const int HEATER_PWRON = 5;// ½سح¨¼سببئ÷؟ھ¹ط
        public const int AUX_PWRON1 = 6;// ½سح¨¸¨ضْةè±¸؟ھ¹ط
        public const int AUX_PWRON2 = 7;// ½سح¨¸¨ضْةè±¸؟ھ¹ط 
        public const int SET_PRESET = 8;// ةèضأش¤ضأµم 
        public const int CLE_PRESET = 9;// اه³‎ش¤ضأµم 

        public const int ZOOM_IN = 11;// ½¹¾àزشثظ¶بSS±ن´َ(±¶آت±ن´َ)
        public const int ZOOM_OUT = 12;// ½¹¾àزشثظ¶بSS±نذ،(±¶آت±نذ،)
        public const int FOCUS_NEAR = 13;// ½¹µمزشثظ¶بSSا°µ÷ 
        public const int FOCUS_FAR = 14;// ½¹µمزشثظ¶بSS؛َµ÷
        public const int IRIS_OPEN = 15;// ¹âب¦زشثظ¶بSSہ©´َ
        public const int IRIS_CLOSE = 16;// ¹âب¦زشثظ¶بSSثُذ، 

        public const int TILT_UP = 21;/* شئج¨زشSSµؤثظ¶بةدرِ */
        public const int TILT_DOWN = 22;/* شئج¨زشSSµؤثظ¶بدآ¸© */
        public const int PAN_LEFT = 23;/* شئج¨زشSSµؤثظ¶ب×َ×ھ */
        public const int PAN_RIGHT = 24;/* شئج¨زشSSµؤثظ¶بسز×ھ */
        public const int UP_LEFT = 25;/* شئج¨زشSSµؤثظ¶بةدرِ؛ح×َ×ھ */
        public const int UP_RIGHT = 26;/* شئج¨زشSSµؤثظ¶بةدرِ؛حسز×ھ */
        public const int DOWN_LEFT = 27;/* شئج¨زشSSµؤثظ¶بدآ¸©؛ح×َ×ھ */
        public const int DOWN_RIGHT = 28;/* شئج¨زشSSµؤثظ¶بدآ¸©؛حسز×ھ */
        public const int PAN_AUTO = 29;/* شئج¨زشSSµؤثظ¶ب×َسز×ش¶¯ة¨أè */

        public const int FILL_PRE_SEQ = 30;/* ½«ش¤ضأµم¼سبëر²؛½ذٍءذ */
        public const int SET_SEQ_DWELL = 31;/* ةèضأر²؛½µمح£¶ظت±¼ن */
        public const int SET_SEQ_SPEED = 32;/* ةèضأر²؛½ثظ¶ب */
        public const int CLE_PRE_SEQ = 33;/* ½«ش¤ضأµم´سر²؛½ذٍءذضذة¾³‎ */
        public const int STA_MEM_CRUISE = 34;/* ؟ھت¼¼اآ¼¹ى¼£ */
        public const int STO_MEM_CRUISE = 35;/* ح£ض¹¼اآ¼¹ى¼£ */
        public const int RUN_CRUISE = 36;/* ؟ھت¼¹ى¼£ */
        public const int RUN_SEQ = 37;/* ؟ھت¼ر²؛½ */
        public const int STOP_SEQ = 38;/* ح£ض¹ر²؛½ */
        public const int GOTO_PRESET = 39;/* ؟ىاٍ×ھµ½ش¤ضأµم */
        /**********************شئج¨؟طضئأüءî end*************************/

        /*************************************************
        »ط·إت±²¥·إ؟طضئأüءî؛ê¶¨زه 
        NET_DVR_PlayBackControl
        NET_DVR_PlayControlLocDisplay
        NET_DVR_DecPlayBackCtrlµؤ؛ê¶¨زه
        ¾كجهض§³ض²é؟´؛¯ت‎ثµأ÷؛ح´ْآë
        **************************************************/
        public const int NET_DVR_PLAYSTART = 1;//؟ھت¼²¥·إ
        public const int NET_DVR_PLAYSTOP = 2;//ح£ض¹²¥·إ
        public const int NET_DVR_PLAYPAUSE = 3;//شفح£²¥·إ
        public const int NET_DVR_PLAYRESTART = 4;//»ض¸´²¥·إ
        public const int NET_DVR_PLAYFAST = 5;//؟ى·إ
        public const int NET_DVR_PLAYSLOW = 6;//آ‎·إ
        public const int NET_DVR_PLAYNORMAL = 7;//ص‎³£ثظ¶ب
        public const int NET_DVR_PLAYFRAME = 8;//µ¥ض،·إ
        public const int NET_DVR_PLAYSTARTAUDIO = 9;//´ٍ؟ھةùزô
        public const int NET_DVR_PLAYSTOPAUDIO = 10;//¹ط±صةùزô
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;//µ÷½عزôء؟
        public const int NET_DVR_PLAYSETPOS = 12;//¸ؤ±نخؤ¼‏»ط·إµؤ½ّ¶ب
        public const int NET_DVR_PLAYGETPOS = 13;//»ٌب،خؤ¼‏»ط·إµؤ½ّ¶ب
        public const int NET_DVR_PLAYGETTIME = 14;//»ٌب،µ±ا°زر¾­²¥·إµؤت±¼ن(°´خؤ¼‏»ط·إµؤت±؛ٍسذذ§)
        public const int NET_DVR_PLAYGETFRAME = 15;//»ٌب،µ±ا°زر¾­²¥·إµؤض،ت‎(°´خؤ¼‏»ط·إµؤت±؛ٍسذذ§)
        public const int NET_DVR_GETTOTALFRAMES = 16;//»ٌب،µ±ا°²¥·إخؤ¼‏×ـµؤض،ت‎(°´خؤ¼‏»ط·إµؤت±؛ٍسذذ§)
        public const int NET_DVR_GETTOTALTIME = 17;//»ٌب،µ±ا°²¥·إخؤ¼‏×ـµؤت±¼ن(°´خؤ¼‏»ط·إµؤت±؛ٍسذذ§)
        public const int NET_DVR_THROWBFRAME = 20;//¶ھBض،
        public const int NET_DVR_SETSPEED = 24;//ةèضأآëء÷ثظ¶ب
        public const int NET_DVR_KEEPALIVE = 25;//±£³ضسëةè±¸µؤذؤجّ(بç¹û»طµ÷×èبû£¬½¨زé2أë·¢ثحز»´خ)
        public const int NET_DVR_PLAYSETTIME = 26;//°´¾ّ¶شت±¼ن¶¨خ»
        public const int NET_DVR_PLAYGETTOTALLEN = 27;//»ٌب،°´ت±¼ن»ط·إ¶شس¦ت±¼ن¶خؤعµؤثùسذخؤ¼‏µؤ×ـ³¤¶ب
        public const int NET_DVR_PLAY_FORWARD = 29;//µ¹·إاذ»»خھص‎·إ
        public const int NET_DVR_PLAY_REVERSE = 30;//ص‎·إاذ»»خھµ¹·إ
        public const int NET_DVR_SET_TRANS_TYPE = 32;//ةèضأ×ھ·â×°ہàذح
        public const int NET_DVR_PLAY_CONVERT = 33;//ص‎·إاذ»»خھµ¹·إ

        //ش¶³ج°´¼ü¶¨زهبçدآ£؛
        /* key value send to CONFIG program */
        public const int KEY_CODE_1 = 1;
        public const int KEY_CODE_2 = 2;
        public const int KEY_CODE_3 = 3;
        public const int KEY_CODE_4 = 4;
        public const int KEY_CODE_5 = 5;
        public const int KEY_CODE_6 = 6;
        public const int KEY_CODE_7 = 7;
        public const int KEY_CODE_8 = 8;
        public const int KEY_CODE_9 = 9;
        public const int KEY_CODE_0 = 10;
        public const int KEY_CODE_POWER = 11;
        public const int KEY_CODE_MENU = 12;
        public const int KEY_CODE_ENTER = 13;
        public const int KEY_CODE_CANCEL = 14;
        public const int KEY_CODE_UP = 15;
        public const int KEY_CODE_DOWN = 16;
        public const int KEY_CODE_LEFT = 17;
        public const int KEY_CODE_RIGHT = 18;
        public const int KEY_CODE_EDIT = 19;
        public const int KEY_CODE_ADD = 20;
        public const int KEY_CODE_MINUS = 21;
        public const int KEY_CODE_PLAY = 22;
        public const int KEY_CODE_REC = 23;
        public const int KEY_CODE_PAN = 24;
        public const int KEY_CODE_M = 25;
        public const int KEY_CODE_A = 26;
        public const int KEY_CODE_F1 = 27;
        public const int KEY_CODE_F2 = 28;

        /* for PTZ control */
        public const int KEY_PTZ_UP_START = KEY_CODE_UP;
        public const int KEY_PTZ_UP_STOP = 32;

        public const int KEY_PTZ_DOWN_START = KEY_CODE_DOWN;
        public const int KEY_PTZ_DOWN_STOP = 33;


        public const int KEY_PTZ_LEFT_START = KEY_CODE_LEFT;
        public const int KEY_PTZ_LEFT_STOP = 34;

        public const int KEY_PTZ_RIGHT_START = KEY_CODE_RIGHT;
        public const int KEY_PTZ_RIGHT_STOP = 35;

        public const int KEY_PTZ_AP1_START = KEY_CODE_EDIT;/* ¹âب¦+ */
        public const int KEY_PTZ_AP1_STOP = 36;

        public const int KEY_PTZ_AP2_START = KEY_CODE_PAN;/* ¹âب¦- */
        public const int KEY_PTZ_AP2_STOP = 37;

        public const int KEY_PTZ_FOCUS1_START = KEY_CODE_A;/* ¾غ½¹+ */
        public const int KEY_PTZ_FOCUS1_STOP = 38;

        public const int KEY_PTZ_FOCUS2_START = KEY_CODE_M;/* ¾غ½¹- */
        public const int KEY_PTZ_FOCUS2_STOP = 39;

        public const int KEY_PTZ_B1_START = 40;/* ±ن±¶+ */
        public const int KEY_PTZ_B1_STOP = 41;

        public const int KEY_PTZ_B2_START = 42;/* ±ن±¶- */
        public const int KEY_PTZ_B2_STOP = 43;

        //9000ذآشِ
        public const int KEY_CODE_11 = 44;
        public const int KEY_CODE_12 = 45;
        public const int KEY_CODE_13 = 46;
        public const int KEY_CODE_14 = 47;
        public const int KEY_CODE_15 = 48;
        public const int KEY_CODE_16 = 49;

        /*************************²خت‎إنضأأüءî begin*******************************/
        //سأسعNET_DVR_SetDVRConfig؛حNET_DVR_GetDVRConfig,×¢زâئن¶شس¦µؤإنضأ½ل¹¹
        public const int NET_DVR_GET_DEVICECFG = 100;//»ٌب،ةè±¸²خت‎
        public const int NET_DVR_SET_DEVICECFG = 101;//ةèضأةè±¸²خت‎
        public const int NET_DVR_GET_NETCFG = 102;//»ٌب،حّآç²خت‎
        public const int NET_DVR_SET_NETCFG = 103;//ةèضأحّآç²خت‎
        public const int NET_DVR_GET_PICCFG = 104;//»ٌب،ح¼دَ²خت‎
        public const int NET_DVR_SET_PICCFG = 105;//ةèضأح¼دَ²خت‎
        public const int NET_DVR_GET_COMPRESSCFG = 106;//»ٌب،ر¹ثُ²خت‎
        public const int NET_DVR_SET_COMPRESSCFG = 107;//ةèضأر¹ثُ²خت‎
        public const int NET_DVR_GET_RECORDCFG = 108;//»ٌب،آ¼دٌت±¼ن²خت‎
        public const int NET_DVR_SET_RECORDCFG = 109;//ةèضأآ¼دٌت±¼ن²خت‎
        public const int NET_DVR_GET_DECODERCFG = 110;//»ٌب،½âآëئ÷²خت‎
        public const int NET_DVR_SET_DECODERCFG = 111;//ةèضأ½âآëئ÷²خت‎
        public const int NET_DVR_GET_RS232CFG = 112;//»ٌب،232´®؟ع²خت‎
        public const int NET_DVR_SET_RS232CFG = 113;//ةèضأ232´®؟ع²خت‎
        public const int NET_DVR_GET_ALARMINCFG = 114;//»ٌب،±¨¾¯تنبë²خت‎
        public const int NET_DVR_SET_ALARMINCFG = 115;//ةèضأ±¨¾¯تنبë²خت‎
        public const int NET_DVR_GET_ALARMOUTCFG = 116;//»ٌب،±¨¾¯تن³ِ²خت‎
        public const int NET_DVR_SET_ALARMOUTCFG = 117;//ةèضأ±¨¾¯تن³ِ²خت‎
        public const int NET_DVR_GET_TIMECFG = 118;//»ٌب،DVRت±¼ن
        public const int NET_DVR_SET_TIMECFG = 119;//ةèضأDVRت±¼ن
        public const int NET_DVR_GET_PREVIEWCFG = 120;//»ٌب،ش¤ہہ²خت‎
        public const int NET_DVR_SET_PREVIEWCFG = 121;//ةèضأش¤ہہ²خت‎
        public const int NET_DVR_GET_VIDEOOUTCFG = 122;//»ٌب،تسئµتن³ِ²خت‎
        public const int NET_DVR_SET_VIDEOOUTCFG = 123;//ةèضأتسئµتن³ِ²خت‎
        public const int NET_DVR_GET_USERCFG = 124;//»ٌب،سأ»§²خت‎
        public const int NET_DVR_SET_USERCFG = 125;//ةèضأسأ»§²خت‎
        public const int NET_DVR_GET_EXCEPTIONCFG = 126;//»ٌب،زى³£²خت‎
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;//ةèضأزى³£²خت‎
        public const int NET_DVR_GET_ZONEANDDST = 128;//»ٌب،ت±اّ؛حدؤت±ضئ²خت‎
        public const int NET_DVR_SET_ZONEANDDST = 129;//ةèضأت±اّ؛حدؤت±ضئ²خت‎
        public const int NET_DVR_GET_SHOWSTRING = 130;//»ٌب،µ‏¼س×ض·û²خت‎
        public const int NET_DVR_SET_SHOWSTRING = 131;//ةèضأµ‏¼س×ض·û²خت‎
        public const int NET_DVR_GET_EVENTCOMPCFG = 132;//»ٌب،تآ¼‏´¥·¢آ¼دٌ²خت‎
        public const int NET_DVR_SET_EVENTCOMPCFG = 133;//ةèضأتآ¼‏´¥·¢آ¼دٌ²خت‎

        public const int NET_DVR_GET_AUXOUTCFG = 140;//»ٌب،±¨¾¯´¥·¢¸¨ضْتن³ِةèضأ(HSةè±¸¸¨ضْتن³ِ2006-02-28)
        public const int NET_DVR_SET_AUXOUTCFG = 141;//ةèضأ±¨¾¯´¥·¢¸¨ضْتن³ِةèضأ(HSةè±¸¸¨ضْتن³ِ2006-02-28)
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;//»ٌب،-sدµءذث«تن³ِش¤ہہ²خت‎(-sدµءذث«تن³ِ2006-04-13)
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;//ةèضأ-sدµءذث«تن³ِش¤ہہ²خت‎(-sدµءذث«تن³ِ2006-04-13)

        public const int NET_DVR_GET_PICCFG_EX = 200;//»ٌب،ح¼دَ²خت‎(SDK_V14ہ©ص¹أüءî)
        public const int NET_DVR_SET_PICCFG_EX = 201;//ةèضأح¼دَ²خت‎(SDK_V14ہ©ص¹أüءî)
        public const int NET_DVR_GET_USERCFG_EX = 202;//»ٌب،سأ»§²خت‎(SDK_V15ہ©ص¹أüءî)
        public const int NET_DVR_SET_USERCFG_EX = 203;//ةèضأسأ»§²خت‎(SDK_V15ہ©ص¹أüءî)
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204;//»ٌب،ر¹ثُ²خت‎(SDK_V15ہ©ص¹أüءî2006-05-15)
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205;//ةèضأر¹ثُ²خت‎(SDK_V15ہ©ص¹أüءî2006-05-15)

        public const int NET_DVR_GET_NETAPPCFG = 222;//»ٌب،حّآçس¦سأ²خت‎ NTP/DDNS/EMAIL
        public const int NET_DVR_SET_NETAPPCFG = 223;//ةèضأحّآçس¦سأ²خت‎ NTP/DDNS/EMAIL
        public const int NET_DVR_GET_NTPCFG = 224;//»ٌب،حّآçس¦سأ²خت‎ NTP
        public const int NET_DVR_SET_NTPCFG = 225;//ةèضأحّآçس¦سأ²خت‎ NTP
        public const int NET_DVR_GET_DDNSCFG = 226;//»ٌب،حّآçس¦سأ²خت‎ DDNS
        public const int NET_DVR_SET_DDNSCFG = 227;//ةèضأحّآçس¦سأ²خت‎ DDNS
        //¶شس¦NET_DVR_EMAILPARA
        public const int NET_DVR_GET_EMAILCFG = 228;//»ٌب،حّآçس¦سأ²خت‎ EMAIL
        public const int NET_DVR_SET_EMAILCFG = 229;//ةèضأحّآçس¦سأ²خت‎ EMAIL

        public const int NET_DVR_GET_NFSCFG = 230;/* NFS disk config */
        public const int NET_DVR_SET_NFSCFG = 231;/* NFS disk config */

        public const int NET_DVR_GET_SHOWSTRING_EX = 238;//»ٌب،µ‏¼س×ض·û²خت‎ہ©ص¹(ض§³ض8جُ×ض·û)
        public const int NET_DVR_SET_SHOWSTRING_EX = 239;//ةèضأµ‏¼س×ض·û²خت‎ہ©ص¹(ض§³ض8جُ×ض·û)
        public const int NET_DVR_GET_NETCFG_OTHER = 244;//»ٌب،حّآç²خت‎
        public const int NET_DVR_SET_NETCFG_OTHER = 245;//ةèضأحّآç²خت‎

        //¶شس¦NET_DVR_EMAILCFG½ل¹¹
        public const int NET_DVR_GET_EMAILPARACFG = 250;//Get EMAIL parameters
        public const int NET_DVR_SET_EMAILPARACFG = 251;//Setup EMAIL parameters

        public const int NET_DVR_GET_DDNSCFG_EX = 274;//»ٌب،ہ©ص¹DDNS²خت‎
        public const int NET_DVR_SET_DDNSCFG_EX = 275;//ةèضأہ©ص¹DDNS²خت‎

        public const int NET_DVR_SET_PTZPOS = 292;//شئج¨ةèضأPTZخ»ضأ
        public const int NET_DVR_GET_PTZPOS = 293;//شئج¨»ٌب،PTZخ»ضأ
        public const int NET_DVR_GET_PTZSCOPE = 294;//شئج¨»ٌب،PTZ·¶خ§

        public const int NET_DVR_GET_AP_INFO_LIST = 305;//»ٌب،خقدكحّآç×تش´²خت‎
        public const int NET_DVR_SET_WIFI_CFG = 306;//ةèضأIP¼à؟طةè±¸خقدك²خت‎
        public const int NET_DVR_GET_WIFI_CFG = 307;//»ٌب،IP¼à؟طةè±¸خقدك²خت‎
        public const int NET_DVR_SET_WIFI_WORKMODE = 308;//ةèضأIP¼à؟طةè±¸حّ؟ع¹¤×÷ؤ£ت½²خت‎
        public const int NET_DVR_GET_WIFI_WORKMODE = 309;//»ٌب،IP¼à؟طةè±¸حّ؟ع¹¤×÷ؤ£ت½²خت‎ 
        public const int NET_DVR_GET_WIFI_STATUS = 310;	//»ٌب،ةè±¸µ±ا°wifiء¬½س×´ج¬
        /***************************DS9000ذآشِأüءî(_V30) begin *****************************/
        //حّآç(NET_DVR_NETCFG_V30½ل¹¹)
        public const int NET_DVR_GET_NETCFG_V30 = 1000;//»ٌب،حّآç²خت‎
        public const int NET_DVR_SET_NETCFG_V30 = 1001;//ةèضأحّآç²خت‎

        //ح¼دَ(NET_DVR_PICCFG_V30½ل¹¹)
        public const int NET_DVR_GET_PICCFG_V30 = 1002;//»ٌب،ح¼دَ²خت‎
        public const int NET_DVR_SET_PICCFG_V30 = 1003;//ةèضأح¼دَ²خت‎

        //ح¼دَ(NET_DVR_PICCFG_V40½ل¹¹)
        public const int NET_DVR_GET_PICCFG_V40 = 6179;//»ٌب،ح¼دَ²خت‎V40ہ©ص¹
        public const int NET_DVR_SET_PICCFG_V40 = 6180;//ةèضأح¼دَ²خت‎V40ہ©ص¹

        //آ¼دٌت±¼ن(NET_DVR_RECORD_V30½ل¹¹)
        public const int NET_DVR_GET_RECORDCFG_V30 = 1004;//»ٌب،آ¼دٌ²خت‎
        public const int NET_DVR_SET_RECORDCFG_V30 = 1005;//ةèضأآ¼دٌ²خت‎

        //سأ»§(NET_DVR_USER_V30½ل¹¹)
        public const int NET_DVR_GET_USERCFG_V30 = 1006;//»ٌب،سأ»§²خت‎
        public const int NET_DVR_SET_USERCFG_V30 = 1007;//ةèضأسأ»§²خت‎

        //9000DDNS²خت‎إنضأ(NET_DVR_DDNSPARA_V30½ل¹¹)
        public const int NET_DVR_GET_DDNSCFG_V30 = 1010;//»ٌب،DDNS(9000ہ©ص¹)
        public const int NET_DVR_SET_DDNSCFG_V30 = 1011;//ةèضأDDNS(9000ہ©ص¹)

        //EMAIL¹¦ؤـ(NET_DVR_EMAILCFG_V30½ل¹¹)
        public const int NET_DVR_GET_EMAILCFG_V30 = 1012;//»ٌب،EMAIL²خت‎ 
        public const int NET_DVR_SET_EMAILCFG_V30 = 1013;//ةèضأEMAIL²خت‎ 

        //ر²؛½²خت‎ (NET_DVR_CRUISE_PARA½ل¹¹)
        public const int NET_DVR_GET_CRUISE = 1020;
        public const int NET_DVR_SET_CRUISE = 1021;

        //±¨¾¯تنبë½ل¹¹²خت‎ (NET_DVR_ALARMINCFG_V30½ل¹¹)
        public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;
        public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;

        //±¨¾¯تن³ِ½ل¹¹²خت‎ (NET_DVR_ALARMOUTCFG_V30½ل¹¹)
        public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;
        public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;

        //تسئµتن³ِ½ل¹¹²خت‎ (NET_DVR_VIDEOOUT_V30½ل¹¹)
        public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;
        public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;

        //µ‏¼س×ض·û½ل¹¹²خت‎ (NET_DVR_SHOWSTRING_V30½ل¹¹)
        public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;
        public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;

        //زى³£½ل¹¹²خت‎ (NET_DVR_EXCEPTION_V30½ل¹¹)
        public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;
        public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

        //´®؟ع232½ل¹¹²خت‎ (NET_DVR_RS232CFG_V30½ل¹¹)
        public const int NET_DVR_GET_RS232CFG_V30 = 1036;
        public const int NET_DVR_SET_RS232CFG_V30 = 1037;

        //حّآçس²إج½سبë½ل¹¹²خت‎ (NET_DVR_NET_DISKCFG½ل¹¹)
        public const int NET_DVR_GET_NET_DISKCFG = 1038;//حّآçس²إج½سبë»ٌب،
        public const int NET_DVR_SET_NET_DISKCFG = 1039;//حّآçس²إج½سبëةèضأ

        //ر¹ثُ²خت‎ (NET_DVR_COMPRESSIONCFG_V30½ل¹¹)
        public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;
        public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;

        //»ٌب،485½âآëئ÷²خت‎ (NET_DVR_DECODERCFG_V30½ل¹¹)
        public const int NET_DVR_GET_DECODERCFG_V30 = 1042;//»ٌب،½âآëئ÷²خت‎
        public const int NET_DVR_SET_DECODERCFG_V30 = 1043;//ةèضأ½âآëئ÷²خت‎

        //»ٌب،ش¤ہہ²خت‎ (NET_DVR_PREVIEWCFG_V30½ل¹¹)
        public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;//»ٌب،ش¤ہہ²خت‎
        public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;//ةèضأش¤ہہ²خت‎

        //¸¨ضْش¤ہہ²خت‎ (NET_DVR_PREVIEWCFG_AUX_V30½ل¹¹)
        public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;//»ٌب،¸¨ضْش¤ہہ²خت‎
        public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;//ةèضأ¸¨ضْش¤ہہ²خت‎

        //IP½سبëإنضأ²خت‎ £¨NET_DVR_IPPARACFG½ل¹¹£©
        public const int NET_DVR_GET_IPPARACFG = 1048; //»ٌب،IP½سبëإنضأذإد¢ 
        public const int NET_DVR_SET_IPPARACFG = 1049;//ةèضأIP½سبëإنضأذإد¢

        //IP½سبëإنضأ²خت‎ £¨NET_DVR_IPPARACFG_V40½ل¹¹£©
        public const int NET_DVR_GET_IPPARACFG_V40 = 1062; //»ٌب،IP½سبëإنضأذإد¢ 
        public const int NET_DVR_SET_IPPARACFG_V40 = 1063;//ةèضأIP½سبëإنضأذإد¢

        //IP±¨¾¯تنبë½سبëإنضأ²خت‎ £¨NET_DVR_IPALARMINCFG½ل¹¹£©
        public const int NET_DVR_GET_IPALARMINCFG = 1050; //»ٌب،IP±¨¾¯تنبë½سبëإنضأذإد¢ 
        public const int NET_DVR_SET_IPALARMINCFG = 1051; //ةèضأIP±¨¾¯تنبë½سبëإنضأذإد¢

        //IP±¨¾¯تن³ِ½سبëإنضأ²خت‎ £¨NET_DVR_IPALARMOUTCFG½ل¹¹£©
        public const int NET_DVR_GET_IPALARMOUTCFG = 1052;//»ٌب،IP±¨¾¯تن³ِ½سبëإنضأذإد¢ 
        public const int NET_DVR_SET_IPALARMOUTCFG = 1053;//ةèضأIP±¨¾¯تن³ِ½سبëإنضأذإد¢

        //س²إج¹ـہيµؤ²خت‎»ٌب، (NET_DVR_HDCFG½ل¹¹)
        public const int NET_DVR_GET_HDCFG = 1054;//»ٌب،س²إج¹ـہيإنضأ²خت‎
        public const int NET_DVR_SET_HDCFG = 1055;//ةèضأس²إج¹ـہيإنضأ²خت‎

        //إج×é¹ـہيµؤ²خت‎»ٌب، (NET_DVR_HDGROUP_CFG½ل¹¹)
        public const int NET_DVR_GET_HDGROUP_CFG = 1056;//»ٌب،إج×é¹ـہيإنضأ²خت‎
        public const int NET_DVR_SET_HDGROUP_CFG = 1057;//ةèضأإج×é¹ـہيإنضأ²خت‎

        //ةè±¸±àآëہàذحإنضأ(NET_DVR_COMPRESSION_AUDIO½ل¹¹)
        public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;//»ٌب،ةè±¸سïزô¶ش½²±àآë²خت‎
        public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;//ةèضأةè±¸سïزô¶ش½²±àآë²خت‎

        //IP½سبëإنضأ²خت‎ £¨NET_DVR_IPPARACFG_V31½ل¹¹£©
        public const int NET_DVR_GET_IPPARACFG_V31 = 1060;//»ٌب،IP½سبëإنضأذإد¢ 
        public const int NET_DVR_SET_IPPARACFG_V31 = 1061; //ةèضأIP½سبëإنضأذإد¢

        //ةè±¸²خت‎إنضأ £¨NET_DVR_DEVICECFG_V40½ل¹¹£©
        public const int NET_DVR_GET_DEVICECFG_V40 = 1100;//»ٌب،ةè±¸²خت‎
        public const int NET_DVR_SET_DEVICECFG_V40 = 1101;//ةèضأةè±¸²خت‎

        //¶àحّ؟¨إنضأ(NET_DVR_NETCFG_MULTI½ل¹¹)
        public const int NET_DVR_GET_NETCFG_MULTI = 1161;
        public const int NET_DVR_SET_NETCFG_MULTI = 1162;

        //BONDINGحّ؟¨(NET_DVR_NETWORK_BONDING½ل¹¹)
        public const int NET_DVR_GET_NETWORK_BONDING = 1254;
        public const int NET_DVR_SET_NETWORK_BONDING = 1255;

        //NATس³ةنإنضأ²خت‎ £¨NET_DVR_NAT_CFG½ل¹¹£©
        public const int NET_DVR_GET_NAT_CFG = 6111;    //»ٌب،NATس³ةن²خت‎
        public const int NET_DVR_SET_NAT_CFG = 6112;    //ةèضأNATس³ةن²خت‎  
        /*************************²خت‎إنضأأüءî end*******************************/

        /************************DVRبصض¾ begin***************************/
        /* ±¨¾¯ */
        //ض÷ہàذح
        public const int MAJOR_ALARM = 1;
        //´خہàذح
        public const int MINOR_ALARM_IN = 1;/* ±¨¾¯تنبë */
        public const int MINOR_ALARM_OUT = 2;/* ±¨¾¯تن³ِ */
        public const int MINOR_MOTDET_START = 3; /* زئ¶¯صى²â±¨¾¯؟ھت¼ */
        public const int MINOR_MOTDET_STOP = 4; /* زئ¶¯صى²â±¨¾¯½لتّ */
        public const int MINOR_HIDE_ALARM_START = 5;/* صعµ²±¨¾¯؟ھت¼ */
        public const int MINOR_HIDE_ALARM_STOP = 6;/* صعµ²±¨¾¯½لتّ */
        public const int MINOR_VCA_ALARM_START = 7;/*ضاؤـ±¨¾¯؟ھت¼*/
        public const int MINOR_VCA_ALARM_STOP = 8;/*ضاؤـ±¨¾¯ح£ض¹*/

        /* زى³£ */
        //ض÷ہàذح
        public const int MAJOR_EXCEPTION = 2;
        //´خہàذح
        public const int MINOR_VI_LOST = 33;/* تسئµذإ؛إ¶ھت§ */
        public const int MINOR_ILLEGAL_ACCESS = 34;/* ·ا·¨·أخت */
        public const int MINOR_HD_FULL = 35;/* س²إجآْ */
        public const int MINOR_HD_ERROR = 36;/* س²إج´يخَ */
        public const int MINOR_DCD_LOST = 37;/* MODEM µôدك(±£ءô²»ت¹سأ) */
        public const int MINOR_IP_CONFLICT = 38;/* IPµطض·³هح» */
        public const int MINOR_NET_BROKEN = 39;/* حّآç¶د؟ھ*/
        public const int MINOR_REC_ERROR = 40;/* آ¼دٌ³ِ´ي */
        public const int MINOR_IPC_NO_LINK = 41;/* IPCء¬½سزى³£ */
        public const int MINOR_VI_EXCEPTION = 42;/* تسئµتنبëزى³£(ض»صë¶شؤ£ؤâح¨µہ) */
        public const int MINOR_IPC_IP_CONFLICT = 43;/*ipc ip µطض· ³هح»*/

        //تسئµ×غ؛دئ½ج¨
        public const int MINOR_FANABNORMAL = 49;/* تسئµ×غ؛دئ½ج¨£؛·çةب×´ج¬زى³£ */
        public const int MINOR_FANRESUME = 50;/* تسئµ×غ؛دئ½ج¨£؛·çةب×´ج¬»ض¸´ص‎³£ */
        public const int MINOR_SUBSYSTEM_ABNORMALREBOOT = 51;/* تسئµ×غ؛دئ½ج¨£؛6467زى³£ضطئô */
        public const int MINOR_MATRIX_STARTBUZZER = 52;/* تسئµ×غ؛دئ½ج¨£؛dm6467زى³££¬ئô¶¯·نأùئ÷ */

        /* ²ظ×÷ */
        //ض÷ہàذح
        public const int MAJOR_OPERATION = 3;
        //´خہàذح
        public const int MINOR_START_DVR = 65;/* ؟ھ»ْ */
        public const int MINOR_STOP_DVR = 66;/* ¹ط»ْ */
        public const int MINOR_STOP_ABNORMAL = 67;/* زى³£¹ط»ْ */
        public const int MINOR_REBOOT_DVR = 68;/*±¾µطضطئôةè±¸*/

        public const int MINOR_LOCAL_LOGIN = 80;/* ±¾µطµاآ½ */
        public const int MINOR_LOCAL_LOGOUT = 81;/* ±¾µط×¢دْµاآ½ */
        public const int MINOR_LOCAL_CFG_PARM = 82;/* ±¾µطإنضأ²خت‎ */
        public const int MINOR_LOCAL_PLAYBYFILE = 83;/* ±¾µط°´خؤ¼‏»ط·إ»ٍدآشط */
        public const int MINOR_LOCAL_PLAYBYTIME = 84;/* ±¾µط°´ت±¼ن»ط·إ»ٍدآشط*/
        public const int MINOR_LOCAL_START_REC = 85;/* ±¾µط؟ھت¼آ¼دٌ */
        public const int MINOR_LOCAL_STOP_REC = 86;/* ±¾µطح£ض¹آ¼دٌ */
        public const int MINOR_LOCAL_PTZCTRL = 87;/* ±¾µطشئج¨؟طضئ */
        public const int MINOR_LOCAL_PREVIEW = 88;/* ±¾µطش¤ہہ (±£ءô²»ت¹سأ)*/
        public const int MINOR_LOCAL_MODIFY_TIME = 89;/* ±¾µطذق¸ؤت±¼ن(±£ءô²»ت¹سأ) */
        public const int MINOR_LOCAL_UPGRADE = 90;/* ±¾µطة‎¼¶ */
        public const int MINOR_LOCAL_RECFILE_OUTPUT = 91;/* ±¾µط±¸·فآ¼دَخؤ¼‏ */
        public const int MINOR_LOCAL_FORMAT_HDD = 92;/* ±¾µط³ُت¼»¯س²إج */
        public const int MINOR_LOCAL_CFGFILE_OUTPUT = 93;/* µ¼³ِ±¾µطإنضأخؤ¼‏ */
        public const int MINOR_LOCAL_CFGFILE_INPUT = 94;/* µ¼بë±¾µطإنضأخؤ¼‏ */
        public const int MINOR_LOCAL_COPYFILE = 95;/* ±¾µط±¸·فخؤ¼‏ */
        public const int MINOR_LOCAL_LOCKFILE = 96;/* ±¾µطثّ¶¨آ¼دٌخؤ¼‏ */
        public const int MINOR_LOCAL_UNLOCKFILE = 97;/* ±¾µط½âثّآ¼دٌخؤ¼‏ */
        public const int MINOR_LOCAL_DVR_ALARM = 98;/* ±¾µطتض¶¯اه³‎؛ح´¥·¢±¨¾¯*/
        public const int MINOR_IPC_ADD = 99;/* ±¾µطجي¼سIPC */
        public const int MINOR_IPC_DEL = 100;/* ±¾µطة¾³‎IPC */
        public const int MINOR_IPC_SET = 101;/* ±¾µطةèضأIPC */
        public const int MINOR_LOCAL_START_BACKUP = 102;/* ±¾µط؟ھت¼±¸·ف */
        public const int MINOR_LOCAL_STOP_BACKUP = 103;/* ±¾µطح£ض¹±¸·ف*/
        public const int MINOR_LOCAL_COPYFILE_START_TIME = 104;/* ±¾µط±¸·ف؟ھت¼ت±¼ن*/
        public const int MINOR_LOCAL_COPYFILE_END_TIME = 105;/* ±¾µط±¸·ف½لتّت±¼ن*/
        public const int MINOR_LOCAL_ADD_NAS = 106;/*±¾µطجي¼سحّآçس²إج*/
        public const int MINOR_LOCAL_DEL_NAS = 107;/* ±¾µطة¾³‎nasإج*/
        public const int MINOR_LOCAL_SET_NAS = 108;/* ±¾µطةèضأnasإج*/

        public const int MINOR_REMOTE_LOGIN = 112;/* ش¶³جµاآ¼ */
        public const int MINOR_REMOTE_LOGOUT = 113;/* ش¶³ج×¢دْµاآ½ */
        public const int MINOR_REMOTE_START_REC = 114;/* ش¶³ج؟ھت¼آ¼دٌ */
        public const int MINOR_REMOTE_STOP_REC = 115;/* ش¶³جح£ض¹آ¼دٌ */
        public const int MINOR_START_TRANS_CHAN = 116;/* ؟ھت¼ح¸أ÷´«تن */
        public const int MINOR_STOP_TRANS_CHAN = 117;/* ح£ض¹ح¸أ÷´«تن */
        public const int MINOR_REMOTE_GET_PARM = 118;/* ش¶³ج»ٌب،²خت‎ */
        public const int MINOR_REMOTE_CFG_PARM = 119;/* ش¶³جإنضأ²خت‎ */
        public const int MINOR_REMOTE_GET_STATUS = 120;/* ش¶³ج»ٌب،×´ج¬ */
        public const int MINOR_REMOTE_ARM = 121;/* ش¶³ج²¼·ہ */
        public const int MINOR_REMOTE_DISARM = 122;/* ش¶³ج³··ہ */
        public const int MINOR_REMOTE_REBOOT = 123;/* ش¶³جضطئô */
        public const int MINOR_START_VT = 124;/* ؟ھت¼سïزô¶ش½² */
        public const int MINOR_STOP_VT = 125;/* ح£ض¹سïزô¶ش½² */
        public const int MINOR_REMOTE_UPGRADE = 126;/* ش¶³جة‎¼¶ */
        public const int MINOR_REMOTE_PLAYBYFILE = 127;/* ش¶³ج°´خؤ¼‏»ط·إ */
        public const int MINOR_REMOTE_PLAYBYTIME = 128;/* ش¶³ج°´ت±¼ن»ط·إ */
        public const int MINOR_REMOTE_PTZCTRL = 129;/* ش¶³جشئج¨؟طضئ */
        public const int MINOR_REMOTE_FORMAT_HDD = 130;/* ش¶³ج¸ٌت½»¯س²إج */
        public const int MINOR_REMOTE_STOP = 131;/* ش¶³ج¹ط»ْ */
        public const int MINOR_REMOTE_LOCKFILE = 132;/* ش¶³جثّ¶¨خؤ¼‏ */
        public const int MINOR_REMOTE_UNLOCKFILE = 133;/* ش¶³ج½âثّخؤ¼‏ */
        public const int MINOR_REMOTE_CFGFILE_OUTPUT = 134;/* ش¶³جµ¼³ِإنضأخؤ¼‏ */
        public const int MINOR_REMOTE_CFGFILE_INTPUT = 135;/* ش¶³جµ¼بëإنضأخؤ¼‏ */
        public const int MINOR_REMOTE_RECFILE_OUTPUT = 136;/* ش¶³جµ¼³ِآ¼دَخؤ¼‏ */
        public const int MINOR_REMOTE_DVR_ALARM = 137;/* ش¶³جتض¶¯اه³‎؛ح´¥·¢±¨¾¯*/
        public const int MINOR_REMOTE_IPC_ADD = 138;/* ش¶³ججي¼سIPC */
        public const int MINOR_REMOTE_IPC_DEL = 139;/* ش¶³جة¾³‎IPC */
        public const int MINOR_REMOTE_IPC_SET = 140;/* ش¶³جةèضأIPC */
        public const int MINOR_REBOOT_VCA_LIB = 141;/*ضطئôضاؤـ؟â*/
        public const int MINOR_REMOTE_ADD_NAS = 142;/* ش¶³ججي¼سnasإج*/
        public const int MINOR_REMOTE_DEL_NAS = 143;/* ش¶³جة¾³‎nasإج*/
        public const int MINOR_REMOTE_SET_NAS = 144;/* ش¶³جةèضأnasإج*/

        //2009-12-16 شِ¼ستسئµ×غ؛دئ½ج¨بصض¾ہàذح
        public const int MINOR_SUBSYSTEMREBOOT = 160;/*تسئµ×غ؛دئ½ج¨£؛dm6467 ص‎³£ضطئô*/
        public const int MINOR_MATRIX_STARTTRANSFERVIDEO = 161;	/*تسئµ×غ؛دئ½ج¨£؛¾طصَاذ»»؟ھت¼´«تنح¼دٌ*/
        public const int MINOR_MATRIX_STOPTRANSFERVIDEO = 162;	/*تسئµ×غ؛دئ½ج¨£؛¾طصَاذ»»ح£ض¹´«تنح¼دٌ*/
        public const int MINOR_REMOTE_SET_ALLSUBSYSTEM = 163;	/*تسئµ×غ؛دئ½ج¨£؛ةèضأثùسذ6467×سدµح³ذإد¢*/
        public const int MINOR_REMOTE_GET_ALLSUBSYSTEM = 164;	/*تسئµ×غ؛دئ½ج¨£؛»ٌب،ثùسذ6467×سدµح³ذإد¢*/
        public const int MINOR_REMOTE_SET_PLANARRAY = 165;	/*تسئµ×غ؛دئ½ج¨£؛ةèضأ¼ئ»®آضر¯×é*/
        public const int MINOR_REMOTE_GET_PLANARRAY = 166;	/*تسئµ×غ؛دئ½ج¨£؛»ٌب،¼ئ»®آضر¯×é*/
        public const int MINOR_MATRIX_STARTTRANSFERAUDIO = 167;	/*تسئµ×غ؛دئ½ج¨£؛¾طصَاذ»»؟ھت¼´«تنزôئµ*/
        public const int MINOR_MATRIX_STOPRANSFERAUDIO = 168;	/*تسئµ×غ؛دئ½ج¨£؛¾طصَاذ»»ح£ض¹´«تنزôئµ*/
        public const int MINOR_LOGON_CODESPITTER = 169;	/*تسئµ×غ؛دئ½ج¨£؛µاآ½آë·ضئ÷*/
        public const int MINOR_LOGOFF_CODESPITTER = 170;	/*تسئµ×غ؛دئ½ج¨£؛حث³ِآë·ضئ÷*/

        /*بصض¾¸½¼سذإد¢*/
        //ض÷ہàذح
        public const int MAJOR_INFORMATION = 4;/*¸½¼سذإد¢*/
        //´خہàذح
        public const int MINOR_HDD_INFO = 161;/*س²إجذإد¢*/
        public const int MINOR_SMART_INFO = 162;/*SMARTذإد¢*/
        public const int MINOR_REC_START = 163;/*؟ھت¼آ¼دٌ*/
        public const int MINOR_REC_STOP = 164;/*ح£ض¹آ¼دٌ*/
        public const int MINOR_REC_OVERDUE = 165;/*¹‎ئعآ¼دٌة¾³‎*/
        public const int MINOR_LINK_START = 166;//ء¬½سا°¶ثةè±¸
        public const int MINOR_LINK_STOP = 167;//¶د؟ھا°¶ثةè±¸،،
        public const int MINOR_NET_DISK_INFO = 168;//حّآçس²إجذإد¢

        //µ±بصض¾µؤض÷ہàذحخھMAJOR_OPERATION=03£¬´خہàذحخھMINOR_LOCAL_CFG_PARM=0x52»ٍصكMINOR_REMOTE_GET_PARM=0x76»ٍصكMINOR_REMOTE_CFG_PARM=0x77ت±£¬dwParaType:²خت‎ہàذحسذذ§£¬ئن؛¬زهبçدآ£؛
        public const int PARA_VIDEOOUT = 1;
        public const int PARA_IMAGE = 2;
        public const int PARA_ENCODE = 4;
        public const int PARA_NETWORK = 8;
        public const int PARA_ALARM = 16;
        public const int PARA_EXCEPTION = 32;
        public const int PARA_DECODER = 64;/*½âآëئ÷*/
        public const int PARA_RS232 = 128;
        public const int PARA_PREVIEW = 256;
        public const int PARA_SECURITY = 512;
        public const int PARA_DATETIME = 1024;
        public const int PARA_FRAMETYPE = 2048;/*ض،¸ٌت½*/
        //vca
        public const int PARA_VCA_RULE = 4096;//ذذخھ¹وشٍ
        /************************DVRبصض¾ End***************************/


        /*******************²éصزخؤ¼‏؛حبصض¾؛¯ت‎·µ»طضµ*************************/
        public const int NET_DVR_FILE_SUCCESS = 1000;//»ٌµأخؤ¼‏ذإد¢
        public const int NET_DVR_FILE_NOFIND = 1001;//أ»سذخؤ¼‏
        public const int NET_DVR_ISFINDING = 1002;//ص‎شع²éصزخؤ¼‏
        public const int NET_DVR_NOMOREFILE = 1003;//²éصزخؤ¼‏ت±أ»سذ¸ü¶àµؤخؤ¼‏
        public const int NET_DVR_FILE_EXCEPTION = 1004;//²éصزخؤ¼‏ت±زى³£

        /*********************»طµ÷؛¯ت‎ہàذح begin************************/
        public const int COMM_ALARM = 0x1100;//8000±¨¾¯ذإد¢ض÷¶¯ةد´«£¬¶شس¦NET_DVR_ALARMINFO
        public const int COMM_ALARM_RULE = 0x1102;//ذذخھ·ضخِ±¨¾¯ذإد¢£¬¶شس¦NET_VCA_RULE_ALARM
        public const int COMM_ALARM_PDC = 0x1103;//بثء÷ء؟ح³¼ئ±¨¾¯ةد´«£¬¶شس¦NET_DVR_PDC_ALRAM_INFO
        public const int COMM_ALARM_ALARMHOST = 0x1105;//حّآç±¨¾¯ض÷»ْ±¨¾¯ةد´«£¬¶شس¦NET_DVR_ALARMHOST_ALARMINFO
        public const int COMM_ALARM_FACE = 0x1106;//بثء³¼ى²âت¶±ً±¨¾¯ذإد¢£¬¶شس¦NET_DVR_FACEDETECT_ALARM
        public const int COMM_RULE_INFO_UPLOAD = 0x1107;  // تآ¼‏ت‎¾فذإد¢ةد´«
        public const int COMM_ALARM_AID = 0x1110;  //½»ح¨تآ¼‏±¨¾¯ذإد¢
        public const int COMM_ALARM_TPS = 0x1111;  //½»ح¨²خت‎ح³¼ئ±¨¾¯ذإد¢
        public const int COMM_UPLOAD_FACESNAP_RESULT = 0x1112;  //بثء³ت¶±ً½ل¹ûةد´«
        public const int COMM_ALARM_TFS = 0x1113;  //½»ح¨ب،ض¤±¨¾¯ذإد¢
        public const int COMM_ALARM_TPS_V41 = 0x1114;  //½»ح¨²خت‎ح³¼ئ±¨¾¯ذإد¢ہ©ص¹
        public const int COMM_ALARM_AID_V41 = 0x1115;  //½»ح¨تآ¼‏±¨¾¯ذإد¢ہ©ص¹
        public const int COMM_ALARM_VQD_EX =  0x1116;	 //تسئµضتء؟صï¶د±¨¾¯
        public const int COMM_SENSOR_VALUE_UPLOAD = 0x1120;  //ؤ£ؤâء؟ت‎¾فتµت±ةد´«
        public const int COMM_SENSOR_ALARM  = 0x1121;  //ؤ£ؤâء؟±¨¾¯ةد´«
        public const int COMM_SWITCH_ALARM   = 0x1122;	 //؟ھ¹طء؟±¨¾¯
        public const int COMM_ALARMHOST_EXCEPTION   =  0x1123; //±¨¾¯ض÷»ْ¹تصد±¨¾¯
        public const int COMM_ALARMHOST_OPERATEEVENT_ALARM  = 0x1124;  //²ظ×÷تآ¼‏±¨¾¯ةد´«
        public const int COMM_ALARMHOST_SAFETYCABINSTATE = 0x1125;	 //·ہ»¤²ص×´ج¬
        public const int COMM_ALARMHOST_ALARMOUTSTATUS  = 0x1126;	 //±¨¾¯تن³ِ؟ع/¾¯؛إ×´ج¬
        public const int COMM_ALARMHOST_CID_ALARM    = 0x1127;	 //±¨¸و±¨¾¯ةد´«
        public const int COMM_ALARMHOST_EXTERNAL_DEVICE_ALARM = 0x1128;	 //±¨¾¯ض÷»ْحâ½سةè±¸±¨¾¯ةد´«
        public const int COMM_ALARMHOST_DATA_UPLOAD    = 0x1129;	 //±¨¾¯ت‎¾فةد´«
        public const int COMM_ALARM_AUDIOEXCEPTION   =  0x1150;	 //ةùزô±¨¾¯ذإد¢
        public const int COMM_ALARM_DEFOCUS    =      0x1151;	 //ذé½¹±¨¾¯ذإد¢
        public const int COMM_ALARM_BUTTON_DOWN_EXCEPTION =  0x1152;	 //°´إ¥°´دآ±¨¾¯ذإد¢
        public const int COMM_ALARM_ALARMGPS   =    0x1202; //GPS±¨¾¯ذإد¢ةد´«
        public const int COMM_TRADEINFO      =  0x1500;  //ATMDVRض÷¶¯ةد´«½»ز×ذإد¢
        public const int COMM_UPLOAD_PLATE_RESULT  =   0x2800;	 //ةد´«³µإئذإد¢
        public const int COMM_ITC_STATUS_DETECT_RESULT  = 0x2810;  //تµت±×´ج¬¼ى²â½ل¹ûةد´«(ضاؤـ¸كاهIPC)
        public const int COMM_IPC_AUXALARM_RESULT  = 0x2820;  //PIR±¨¾¯،¢خقدك±¨¾¯،¢؛ô¾ب±¨¾¯ةد´«
        public const int COMM_UPLOAD_PICTUREINFO    = 0x2900;	 //ةد´«ح¼ئ¬ذإد¢
        public const int COMM_SNAP_MATCH_ALARM   = 0x2902;  //؛عأûµ¥±ب¶ش½ل¹ûةد´«
        public const int COMM_ITS_PLATE_RESULT   =  0x3050;  //ضص¶ثح¼ئ¬ةد´«
        public const int COMM_ITS_TRAFFIC_COLLECT  = 0x3051;  //ضص¶ثح³¼ئت‎¾فةد´«
        public const int COMM_ITS_GATE_VEHICLE = 0x3052;  //³ِبë؟ع³µء¾×¥إؤت‎¾فةد´«
        public const int COMM_ITS_GATE_FACE  = 0x3053 ; //³ِبë؟عبثء³×¥إؤت‎¾فةد´«
        public const int COMM_ITS_GATE_COSTITEM = 0x3054;  //³ِبë؟ع¹‎³µتص·رأ÷د¸ 2013-11-19
        public const int COMM_ITS_GATE_HANDOVER = 0x3055 ; //³ِبë؟ع½»½س°àت‎¾ف 2013-11-19
        public const int COMM_ITS_PARK_VEHICLE  = 0x3056;  //ح£³µ³،ت‎¾فةد´«
        public const int COMM_ITS_BLACKLIST_ALARM  = 0x3057;  //؛عأûµ¥±¨¾¯ةد´«
        public const int COMM_ALARM_V30  =  0x4000;	 //9000±¨¾¯ذإد¢ض÷¶¯ةد´«
        public const int COMM_IPCCFG     =  0x4001;	 //9000ةè±¸IPC½سبëإنضأ¸ؤ±ن±¨¾¯ذإد¢ض÷¶¯ةد´«
        public const int COMM_IPCCFG_V31 = 0x4002;	 //9000ةè±¸IPC½سبëإنضأ¸ؤ±ن±¨¾¯ذإد¢ض÷¶¯ةد´«ہ©ص¹ 9000_1.1
        public const int COMM_IPCCFG_V40 =  0x4003; // IVMS 2000 ±àآë·‏خٌئ÷ NVR IPC½سبëإنضأ¸ؤ±نت±±¨¾¯ذإد¢ةد´«
        public const int COMM_ALARM_DEVICE = 0x4004;  //ةè±¸±¨¾¯ؤعبف£¬سةسعح¨µہضµ´َسع256¶ّہ©ص¹
        public const int COMM_ALARM_CVR  =  0x4005;  //CVR 2.0.Xحâ²؟±¨¾¯ہàذح
        public const int COMM_ALARM_HOT_SPARE = 0x4006;  //بب±¸زى³£±¨¾¯£¨N+1ؤ£ت½زى³£±¨¾¯£©
        public const int COMM_ALARM_V40 = 0x4007;	//زئ¶¯صى²â£¬تسئµ¶ھت§£¬صعµ²£¬IOذإ؛إء؟µب±¨¾¯ذإد¢ض÷¶¯ةد´«£¬±¨¾¯ت‎¾فخھ؟ة±ن³¤

        public const int COMM_ITS_ROAD_EXCEPTION = 0x4500;	 //آ·؟عةè±¸زى³£±¨¾¯
        public const int COMM_ITS_EXTERNAL_CONTROL_ALARM = 0x4520;  //حâ؟ط±¨¾¯
        public const int COMM_SCREEN_ALARM    =  0x5000;  //¶àئء؟طضئئ÷±¨¾¯ہàذح
        public const int COMM_DVCS_STATE_ALARM = 0x5001;  //·ض²¼ت½´َئء؟طضئئ÷±¨¾¯ةد´«
        public const int COMM_ALARM_VQD      = 0x6000;  //VQDض÷¶¯±¨¾¯ةد´« 
        public const int COMM_PUSH_UPDATE_RECORD_INFO  = 0x6001;  //حئؤ£ت½آ¼دٌذإد¢ةد´«
        public const int COMM_DIAGNOSIS_UPLOAD = 0x5100;  //صï¶د·‏خٌئ÷VQD±¨¾¯ةد´«

        /*************²ظ×÷زى³£ہàذح(دûد¢·½ت½, »طµ÷·½ت½(±£ءô))****************/
        public const int EXCEPTION_EXCHANGE = 32768;//سأ»§½»»¥ت±زى³£
        public const int EXCEPTION_AUDIOEXCHANGE = 32769;//سïزô¶ش½²زى³£
        public const int EXCEPTION_ALARM = 32770;//±¨¾¯زى³£
        public const int EXCEPTION_PREVIEW = 32771;//حّآçش¤ہہزى³£
        public const int EXCEPTION_SERIAL = 32772;//ح¸أ÷ح¨µہزى³£
        public const int EXCEPTION_RECONNECT = 32773;//ش¤ہہت±ضطء¬
        public const int EXCEPTION_ALARMRECONNECT = 32774;//±¨¾¯ت±ضطء¬
        public const int EXCEPTION_SERIALRECONNECT = 32775;//ح¸أ÷ح¨µہضطء¬
        public const int EXCEPTION_PLAYBACK = 32784;//»ط·إزى³£
        public const int EXCEPTION_DISKFMT = 32785;//س²إج¸ٌت½»¯

        /********************ش¤ہہ»طµ÷؛¯ت‎*********************/
        public const int NET_DVR_SYSHEAD = 1;//دµح³ح·ت‎¾ف
        public const int NET_DVR_STREAMDATA = 2;//تسئµء÷ت‎¾ف£¨°üہ¨¸´؛دء÷؛حزôتسئµ·ض؟ھµؤتسئµء÷ت‎¾ف£©
        public const int NET_DVR_AUDIOSTREAMDATA = 3;//زôئµء÷ت‎¾ف
        public const int NET_DVR_STD_VIDEODATA = 4;//±ê×¼تسئµء÷ت‎¾ف
        public const int NET_DVR_STD_AUDIODATA = 5;//±ê×¼زôئµء÷ت‎¾ف

        //»طµ÷ش¤ہہضذµؤ×´ج¬؛حدûد¢
        public const int NET_DVR_REALPLAYEXCEPTION = 111;//ش¤ہہزى³£
        public const int NET_DVR_REALPLAYNETCLOSE = 112;//ش¤ہہت±ء¬½س¶د؟ھ
        public const int NET_DVR_REALPLAY5SNODATA = 113;//ش¤ہہ5sأ»سذتصµ½ت‎¾ف
        public const int NET_DVR_REALPLAYRECONNECT = 114;//ش¤ہہضطء¬

        /********************»ط·إ»طµ÷؛¯ت‎*********************/
        public const int NET_DVR_PLAYBACKOVER = 101;//»ط·إت‎¾ف²¥·إحê±د
        public const int NET_DVR_PLAYBACKEXCEPTION = 102;//»ط·إزى³£
        public const int NET_DVR_PLAYBACKNETCLOSE = 103;//»ط·إت±؛ٍء¬½س¶د؟ھ
        public const int NET_DVR_PLAYBACK5SNODATA = 104;//»ط·إ5sأ»سذتصµ½ت‎¾ف

        /*********************»طµ÷؛¯ت‎ہàذح end************************/
        //ةè±¸ذح؛إ(DVRہàذح)
        /* ةè±¸ہàذح */
        public const int DVR = 1;/*¶شةذخ´¶¨زهµؤdvrہàذح·µ»طNETRET_DVR*/
        public const int ATMDVR = 2;/*atm dvr*/
        public const int DVS = 3;/*DVS*/
        public const int DEC = 4;/* 6001D */
        public const int ENC_DEC = 5;/* 6001F */
        public const int DVR_HC = 6;/*8000HC*/
        public const int DVR_HT = 7;/*8000HT*/
        public const int DVR_HF = 8;/*8000HF*/
        public const int DVR_HS = 9;/* 8000HS DVR(no audio) */
        public const int DVR_HTS = 10; /* 8016HTS DVR(no audio) */
        public const int DVR_HB = 11; /* HB DVR(SATA HD) */
        public const int DVR_HCS = 12; /* 8000HCS DVR */
        public const int DVS_A = 13; /* ´ّATAس²إجµؤDVS */
        public const int DVR_HC_S = 14; /* 8000HC-S */
        public const int DVR_HT_S = 15;/* 8000HT-S */
        public const int DVR_HF_S = 16;/* 8000HF-S */
        public const int DVR_HS_S = 17; /* 8000HS-S */
        public const int ATMDVR_S = 18;/* ATM-S */
        public const int LOWCOST_DVR = 19;/*7000Hدµءذ*/
        public const int DEC_MAT = 20; /*¶àآ·½âآëئ÷*/
        public const int DVR_MOBILE = 21;/* mobile DVR */
        public const int DVR_HD_S = 22;   /* 8000HD-S */
        public const int DVR_HD_SL = 23;/* 8000HD-SL */
        public const int DVR_HC_SL = 24;/* 8000HC-SL */
        public const int DVR_HS_ST = 25;/* 8000HS_ST */
        public const int DVS_HW = 26; /* 6000HW */
        public const int DS630X_D = 27; /* ¶àآ·½âآëئ÷ */
        public const int IPCAM = 30;/*IP ةمدٌ»ْ*/
        public const int MEGA_IPCAM = 31;/*X52MFدµءذ,752MF,852MF*/
        public const int IPCAM_X62MF = 32;/*X62MFدµءذ؟ة½سبë9000ةè±¸,762MF,862MF*/
        public const int IPDOME = 40; /*IP ±êاهاٍ»ْ*/
        public const int IPDOME_MEGA200 = 41;/*IP 200حٍ¸كاهاٍ»ْ*/
        public const int IPDOME_MEGA130 = 42;/*IP 130حٍ¸كاهاٍ»ْ*/
        public const int IPMOD = 50;/*IP ؤ£؟é*/
        public const int DS71XX_H = 71;/* DS71XXH_S */
        public const int DS72XX_H_S = 72;/* DS72XXH_S */
        public const int DS73XX_H_S = 73;/* DS73XXH_S */
        public const int DS76XX_H_S = 76;/* DS76XX_H_S */
        public const int DS81XX_HS_S = 81;/* DS81XX_HS_S */
        public const int DS81XX_HL_S = 82;/* DS81XX_HL_S */
        public const int DS81XX_HC_S = 83;/* DS81XX_HC_S */
        public const int DS81XX_HD_S = 84;/* DS81XX_HD_S */
        public const int DS81XX_HE_S = 85;/* DS81XX_HE_S */
        public const int DS81XX_HF_S = 86;/* DS81XX_HF_S */
        public const int DS81XX_AH_S = 87;/* DS81XX_AH_S */
        public const int DS81XX_AHF_S = 88;/* DS81XX_AHF_S */
        public const int DS90XX_HF_S = 90;  /*DS90XX_HF_S*/
        public const int DS91XX_HF_S = 91;  /*DS91XX_HF_S*/
        public const int DS91XX_HD_S = 92; /*91XXHD-S(MD)*/
        /**********************ةè±¸ہàذح end***********************/

        /*************************************************
        ²خت‎إنضأ½ل¹¹،¢²خت‎(ئنضذ_V30خھ9000ذآشِ)
        **************************************************/
        //ذ£ت±½ل¹¹²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME
        {
            public uint dwYear;
            public uint dwMonth;
            public uint dwDay;
            public uint dwHour;
            public uint dwMinute;
            public uint dwSecond;
        }

        //ت±¼ن²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_V30
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
            public ushort wMilliSec;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_EX
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
        }

        //ت±¼ن¶خ(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHEDTIME
        {
            public byte byStartHour;//؟ھت¼ت±¼ن
            public byte byStartMin;//؟ھت¼ت±¼ن
            public byte byStopHour;//½لتّت±¼ن
            public byte byStopMin;//½لتّت±¼ن
        }

        /*ةè±¸±¨¾¯؛حزى³£´¦ہي·½ت½*/
        public const int NOACTION = 0x0;/*خقدىس¦*/
        public const int WARNONMONITOR = 0x1;/*¼àتسئ÷ةد¾¯¸و*/
        public const int WARNONAUDIOOUT = 0x2;/*ةùزô¾¯¸و*/
        public const int UPTOCENTER = 0x4;/*ةد´«ضذذؤ*/
        public const int TRIGGERALARMOUT = 0x8;/*´¥·¢±¨¾¯تن³ِ*/
        public const int TRIGGERCATPIC = 0x10;/*´¥·¢×¥ح¼²¢ةد´«E-mail*/
        public const int SEND_PIC_FTP = 0x200;  /*×¥ح¼²¢ةد´«ftp*/

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STRUCTHEAD
        {
            public ushort wLength;  //½ل¹¹³¤¶ب
            public byte byVersion;	/*¸كµح4خ»·ض±ً´ْ±ي¸كµح°و±¾£¬؛َذّ¸ù¾ف°و±¾؛ح³¤¶ب½ّذذہ©ص¹£¬²»ح¬µؤ°و±¾µؤ³¤¶ب½ّذذدقضئ*/
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V41
        {
            public uint dwHandleType;/*´¦ہي·½ت½,´¦ہي·½ت½µؤ"»ٍ"½ل¹û*/
                                     /*0x00: خقدىس¦*/
                                     /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                     /*0x02: ةùزô¾¯¸و*/
                                     /*0x04: ةد´«ضذذؤ*/
                                     /*0x08: ´¥·¢±¨¾¯تن³ِ*/
                                     /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                     /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                     /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                     /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public uint dwMaxRelAlarmOutChanNum; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎£¨ض»¶ء£©×î´َض§³ضت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //´¥·¢±¨¾¯ح¨µہ      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V40
        {
            public uint dwHandleType;/*´¦ہي·½ت½,´¦ہي·½ت½µؤ"»ٍ"½ل¹û*/
                                     /*0x00: خقدىس¦*/
                                     /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                     /*0x02: ةùزô¾¯¸و*/
                                     /*0x04: ةد´«ضذذؤ*/
                                     /*0x08: ´¥·¢±¨¾¯تن³ِ*/
                                     /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                     /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                     /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                     /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public uint dwMaxRelAlarmOutChanNum; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎£¨ض»¶ء£©×î´َض§³ضت‎
            public uint dwRelAlarmOutChanNum; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎ تµ¼تض§³ضت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //´¥·¢±¨¾¯ح¨µہ      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£ءô
        }

        //±¨¾¯؛حزى³£´¦ہي½ل¹¹(×س½ل¹¹)(¶à´¦ت¹سأ)(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V30
        {
            public uint dwHandleType;/*´¦ہي·½ت½,´¦ہي·½ت½µؤ"»ٍ"½ل¹û*/
            /*0x00: خقدىس¦*/
            /*0x01: ¼àتسئ÷ةد¾¯¸و*/
            /*0x02: ةùزô¾¯¸و*/
            /*0x04: ةد´«ضذذؤ*/
            /*0x08: ´¥·¢±¨¾¯تن³ِ*/
            /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
            /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
            /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
            /*0x200: ×¥ح¼²¢ةد´«FTP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//±¨¾¯´¥·¢µؤتن³ِح¨µہ,±¨¾¯´¥·¢µؤتن³ِ,خھ1±يت¾´¥·¢¸أتن³ِ
        }

        //±¨¾¯؛حزى³£´¦ہي½ل¹¹(×س½ل¹¹)(¶à´¦ت¹سأ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION
        {
            public uint dwHandleType;/*´¦ہي·½ت½,´¦ہي·½ت½µؤ"»ٍ"½ل¹û*/
            /*0x00: خقدىس¦*/
            /*0x01: ¼àتسئ÷ةد¾¯¸و*/
            /*0x02: ةùزô¾¯¸و*/
            /*0x04: ةد´«ضذذؤ*/
            /*0x08: ´¥·¢±¨¾¯تن³ِ*/
            /*0x10: Jpeg×¥ح¼²¢ةد´«EMail*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//±¨¾¯´¥·¢µؤتن³ِح¨µہ,±¨¾¯´¥·¢µؤتن³ِ,خھ1±يت¾´¥·¢¸أتن³ِ
        }

        //DVRةè±¸²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;//DVRأû³ئ
            public uint dwDVRID;//DVR ID,سأسعز£؟طئ÷ //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;//تا·ٌر­»·آ¼دٌ,0:²»تا; 1:تا
            //زشدآ²»؟ة¸ü¸ؤ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ذٍءذ؛إ
            public uint dwSoftwareVersion;//بي¼‏°و±¾؛إ,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public uint dwSoftwareBuildDate;//بي¼‏ةْ³ةبصئع,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;//DSPبي¼‏°و±¾,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public uint dwDSPSoftwareBuildDate;// DSPبي¼‏ةْ³ةبصئع,0xYYYYMMDD
            public uint dwPanelVersion;// ا°أو°ه°و±¾,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public uint dwHardwareVersion;// س²¼‏°و±¾,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public byte byAlarmInPortNum;//DVR±¨¾¯تنبë¸ِت‎
            public byte byAlarmOutPortNum;//DVR±¨¾¯تن³ِ¸ِت‎
            public byte byRS232Num;//DVR 232´®؟ع¸ِت‎
            public byte byRS485Num;//DVR 485´®؟ع¸ِت‎
            public byte byNetworkPortNum;//حّآç؟ع¸ِت‎
            public byte byDiskCtrlNum;//DVR س²إج؟طضئئ÷¸ِت‎
            public byte byDiskNum;//DVR س²إج¸ِت‎
            public byte byDVRType;//DVRہàذح, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR ح¨µہ¸ِت‎
            public byte byStartChan;//ئًت¼ح¨µہ؛إ,ہ‎بçDVS-1,DVR - 1
            public byte byDecordChans;//DVR ½âآëآ·ت‎
            public byte byVGANum;//VGA؟عµؤ¸ِت‎
            public byte byUSBNum;//USB؟عµؤ¸ِت‎
            public byte byAuxoutNum;//¸¨؟عµؤ¸ِت‎
            public byte byAudioNum;//سïزô؟عµؤ¸ِت‎
            public byte byIPChanNum;//×î´َت‎×ضح¨µہت‎
        }

        /*IPµطض·*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IPADDR
        {

            /// char[16]
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpV4;

            /// BYTE[128]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte [ 128 ];
            }
        }

        /*حّآçت‎¾ف½ل¹¹(×س½ل¹¹)(9000ہ©ص¹)*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_V30
        {
            public NET_DVR_IPADDR struDVRIP;//DVR IPµطض·
            public NET_DVR_IPADDR struDVRIPMask;//DVR IPµطض·رعآë
            public uint dwNetInterface;//حّآç½س؟ع£؛1-10MBase-T£»2-10MBase-Tب«ث«¹¤£»3-100MBase-TX£»4-100Mب«ث«¹¤£»5-10M/100M/1000M×شتتس¦£»6-1000Mب«ث«¹¤
            public ushort wDVRPort;//¶ث؟ع؛إ
            public ushort wMTU;//شِ¼سMTUةèضأ£¬ؤ¬بد1500،£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;// خïہيµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*حّآçت‎¾ف½ل¹¹(×س½ل¹¹)*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;//DVR IPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIPMask;//DVR IPµطض·رعآë
            public uint dwNetInterface;//حّآç½س؟ع 1-10MBase-T 2-10MBase-Tب«ث«¹¤ 3-100MBase-TX 4-100Mب«ث«¹¤ 5-10M/100M×شتتس¦
            public ushort wDVRPort;//¶ث؟ع؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;//·‏خٌئ÷µؤخïہيµطض·
        }

        //pppoe½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPOECFG
        {
            public uint dwPPPOE;//0-²»ئôسأ,1-ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoEسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoEأـآë
            public NET_DVR_IPADDR struPPPoEIP;//PPPoE IPµطض·
        }

        //حّآçإنضأ½ل¹¹(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_V30[] struEtherNet;//زشج«حّ؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struRes1;/*±£ءô*/
            public NET_DVR_IPADDR struAlarmHostIpAddr;/* ±¨¾¯ض÷»ْIPµطض· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public ushort wAlarmHostIpPort;
            public byte byUseDhcp;
            public byte byRes3;
            public NET_DVR_IPADDR struDnsServer1IpAddr;/* سٍأû·‏خٌئ÷1µؤIPµطض· */
            public NET_DVR_IPADDR struDnsServer2IpAddr;/* سٍأû·‏خٌئ÷2µؤIPµطض· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wHttpPortNo;
            public NET_DVR_IPADDR struMulticastIpAddr;/* ¶à²¥×éµطض· */
            public NET_DVR_IPADDR struGatewayIpAddr;/* حّ¹طµطض· */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¥¸ِحّ؟¨إنضأذإد¢½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_MULTI
        {
            public NET_DVR_IPADDR struDVRIP;
            public NET_DVR_IPADDR struDVRIPMask;
            public uint dwNetInterface;
            public byte byCardType;  //حّ؟¨ہàذح£¬0-ئصح¨حّ؟¨£¬1-ؤعحّحّ؟¨£¬2-حâحّحّ؟¨
            public byte byRes1;
            public ushort wMTU;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public byte byUseDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_IPADDR struGatewayIpAddr;
            public NET_DVR_IPADDR struDnsServer1IpAddr;
            public NET_DVR_IPADDR struDnsServer2IpAddr;
        }

        //¶àحّ؟¨حّآçإنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_MULTI
        {
            public uint dwSize;
            public byte byDefaultRoute;
            public byte byNetworkCardNum;
            public byte byWorkMode;   //0-ئصح¨¶àحّ؟¨ؤ£ت½£¬1-ؤعحâحّ¸ôہëؤ£ت½
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_MULTI[] struEtherNet;//زشج«حّ؟ع
            public NET_DVR_IPADDR struManageHost1IpAddr;
            public NET_DVR_IPADDR struManageHost2IpAddr;
            public NET_DVR_IPADDR struAlarmHostIpAddr;
            public ushort wManageHost1Port;
            public ushort wManageHost2Port;
            public ushort wAlarmHostIpPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wDvrPort;
            public ushort wHttpPortNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struMulticastIpAddr;/* ¶à²¥×éµطض· */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //حّآçإنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET[] struEtherNet;/* زشج«حّ؟ع */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sManageHostIP;//ش¶³ج¹ـہيض÷»ْµطض·
            public ushort wManageHostPort;//ش¶³ج¹ـہيض÷»ْ¶ث؟ع؛إ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIPServerIP;//IPServer·‏خٌئ÷µطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sMultiCastIP;//¶à²¥×éµطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIP;//حّ¹طµطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNFSIP;//NFSض÷»ْIPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNFSDirectory;//NFSؤ؟آ¼
            public uint dwPPPOE;//0-²»ئôسأ,1-ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoEسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoEأـآë
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sPPPoEIP;//PPPoE IPµطض·(ض»¶ء)
            public ushort wHttpPort;//HTTP¶ث؟ع؛إ
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SIP_CFG
        {
            public uint dwSize;
            public byte byEnableAutoLogin;    //ت¹ؤـ×ش¶¯×¢²ل£¬0-²»ت¹ؤـ£¬1-ت¹ؤـ
            public byte byLoginStatus;  //×¢²ل×´ج¬£¬0-خ´×¢²ل£¬1-زر×¢²ل£¬´ث²خت‎ض»ؤـ»ٌب،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR stuServerIP;  //SIP·‏خٌئ÷IP
            public ushort wServerPort;    //SIP·‏خٌئ÷¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;  //×¢²لسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord; //×¢²لأـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispalyName; //ةè±¸دشت¾أû³ئ
            public ushort wLocalPort;     //±¾µط¶ث؟ع
            public byte byLoginCycle;   //×¢²لضـئع£¬1-99·ضضس
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IP؟ةتس¶ش½²·ض»ْإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_DEVCFG
        {
            public uint dwSize;
            public byte byDefaultRing; //ؤ¬بدءهزô£¬·¶خ§1-6
            public byte byRingVolume;  //ءهزôزôء؟£¬·¶خ§0-9
            public byte byInputVolume; //تنبëزôء؟ضµ£¬·¶خ§0-6
            public byte byOutputVolume; //تن³ِزôء؟ضµ£¬·¶خ§0-9	
            public ushort wRtpPort;  //Rtp¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPreviewDelayTime; //ش¤ہہرست±إنضأ£¬0-30أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Ip؟ةتس¶ش½²زôئµدà¹ط²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_AUDIO_CFG
        {
            public uint dwSize;
            public byte byAudioEncPri1; //زôئµ±àآëسإدب¼¶1£¬0-OggVorbis£¬1-G711_U£¬2-G711_A£¬ 5-MPEG2,6-G726£¬7-AAC
            public byte byAudioEncPri2; //زôئµ±àآëسإدب¼¶2£¬µ±sip·‏خٌئ÷²»ض§³ضزôئµ±àآë1ت±»لت¹سأزôئµ±àآë2£¬0-OggVorbis£¬1-G711_U£¬2-G711_A£¬ 5-MPEG2,6-G726£¬7-AAC
            public ushort wAudioPacketLen1; //زôئµ±àآë1ت‎¾ف°ü³¤¶ب
            public ushort wAudioPacketLen2; //زôئµ±àآë2ت‎¾ف°ü³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IP·ض»ْ؛ô½ذ¶ش½²²خت‎إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_CALL_CFG
        {
            public uint dwSize ;
            public byte byEnableAutoResponse; //ت¹ؤـ×ش¶¯س¦´ً,0-²»ت¹ؤـ£¬1-ت¹ؤـ
            public byte byAudoResponseTime; //×ش¶¯س¦´ًت±¼ن£¬0-30أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byEnableAlarmNumber1; //ئô¶¯±¨¾¯؛إآë1£¬0-²»ئô¶¯£¬1-ئô¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber1; //؛ô½ذ؛إآë1
            public byte byEnableAlarmNumber2; //ئô¶¯±¨¾¯؛إآë2£¬0-²»ئô¶¯£¬1-ئô¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber2; //؛ô½ذ؛إآë2£¬؛ô½ذ؛إآë1ت§°ـ»ل³¢تش؛ô½ذ؛إآë2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        //ح¨µہح¼دَ½ل¹¹
        //زئ¶¯صى²â(×س½ل¹¹)(°´×é·½ت½ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDCHAN
        {
            public uint dwMaxRecordChanNum;   //ةè±¸ض§³ضµؤ×î´َ¹طءھآ¼دٌح¨µہت‎-ض»¶ء
            public uint dwCurRecordChanNum;   //µ±ا°تµ¼تزرإنضأµؤ¹طءھآ¼دٌح¨µہت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint dwRelRecordChan;     /* تµ¼ت´¥·¢آ¼دٌح¨µہ£¬°´ضµ±يت¾,²ةسأ½ô´صذحإإءذ£¬´سدآ±ê0 - MAX_CHANNUM_V30-1سذذ§£¬بç¹ûضذ¼نسِµ½0xffffffff,شٍ؛َذّخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£ءô
        }

        //ح¨µہح¼دَ½ل¹¹
        //زئ¶¯صى²â(×س½ل¹¹)(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOTION_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96*64, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*صى²âاّسٍ,0-96خ»,±يت¾64ذذ,¹²سذ96*64¸ِذ،؛ê؟é,خھ1±يت¾تازئ¶¯صى²âاّسٍ,0-±يت¾²»تا*/
            public byte byMotionSensitive;/*زئ¶¯صى²âءéأô¶ب, 0 - 5,ش½¸كش½ءéأô,oxff¹ط±ص*/
            public byte byEnableHandleMotion;/* تا·ٌ´¦ہيزئ¶¯صى²â 0£­·ٌ 1£­تا*/
            public byte byEnableDisplay;/* ئôسأزئ¶¯صى²â¸كءءدشت¾£؛0- ·ٌ£¬1- تا */
            public byte reservedData;
            public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;/*²¼·ہت±¼ن*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;/* ±¨¾¯´¥·¢µؤآ¼دَح¨µہ*/
        }

        //زئ¶¯صى²â(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*صى²âاّسٍ,¹²سذ22*18¸ِذ،؛ê؟é,خھ1±يت¾¸ؤ؛ê؟éتازئ¶¯صى²âاّسٍ,0-±يت¾²»تا*/
            public byte byMotionSensitive;/*زئ¶¯صى²âءéأô¶ب, 0 - 5,ش½¸كش½ءéأô,0xff¹ط±ص*/
            public byte byEnableHandleMotion;/* تا·ٌ´¦ہيزئ¶¯صى²â */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string reservedData;
            public NET_DVR_HANDLEEXCEPTION strMotionHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
        }

        //صعµ²±¨¾¯(×س½ل¹¹)(9000ہ©ص¹)  اّسٍ´َذ،704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM_V30
        {
            public uint dwEnableHideAlarm;/* تا·ٌئô¶¯صعµ²±¨¾¯ ,0-·ٌ,1-µحءéأô¶ب 2-ضذءéأô¶ب 3-¸كءéأô¶ب*/
            public ushort wHideAlarmAreaTopLeftX;/* صعµ²اّسٍµؤx×ّ±ê */
            public ushort wHideAlarmAreaTopLeftY;/* صعµ²اّسٍµؤy×ّ±ê */
            public ushort wHideAlarmAreaWidth;/* صعµ²اّسٍµؤ؟ي */
            public ushort wHideAlarmAreaHeight;/*صعµ²اّسٍµؤ¸ك*/
            public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;	/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
        }

        //صعµ²±¨¾¯(×س½ل¹¹)  اّسٍ´َذ،704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM
        {
            public uint dwEnableHideAlarm;/* تا·ٌئô¶¯صعµ²±¨¾¯ ,0-·ٌ,1-µحءéأô¶ب 2-ضذءéأô¶ب 3-¸كءéأô¶ب*/
            public ushort wHideAlarmAreaTopLeftX;/* صعµ²اّسٍµؤx×ّ±ê */
            public ushort wHideAlarmAreaTopLeftY;/* صعµ²اّسٍµؤy×ّ±ê */
            public ushort wHideAlarmAreaWidth;/* صعµ²اّسٍµؤ؟ي */
            public ushort wHideAlarmAreaHeight;/*صعµ²اّسٍµؤ¸ك*/
            public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
        }

        //ذإ؛إ¶ھت§±¨¾¯(×س½ل¹¹)(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST_V30
        {
            public byte byEnableHandleVILost;/* تا·ٌ´¦ہيذإ؛إ¶ھت§±¨¾¯ */
            public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
        }

        //ذإ؛إ¶ھت§±¨¾¯(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST
        {
            public byte byEnableHandleVILost;/* تا·ٌ´¦ہيذإ؛إ¶ھت§±¨¾¯ */
            public NET_DVR_HANDLEEXCEPTION strVILostHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
        }

        //صعµ²اّسٍ(×س½ل¹¹)
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct NET_DVR_SHELTER
        {
            public ushort wHideAreaTopLeftX;/* صعµ²اّسٍµؤx×ّ±ê */
            public ushort wHideAreaTopLeftY;/* صعµ²اّسٍµؤy×ّ±ê */
            public ushort wHideAreaWidth;/* صعµ²اّسٍµؤ؟ي */
            public ushort wHideAreaHeight;/*صعµ²اّسٍµؤ¸ك*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COLOR
        {
            public byte byBrightness;/*ءء¶ب,0-255*/
            public byte byContrast;/*¶ش±ب¶ب,0-255*/
            public byte bySaturation;/*±¥؛ح¶ب,0-255*/
            public byte byHue;/*ة«µ÷,0-255*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RGB_COLOR
        {
            public byte byRed;	 //RGBرصة«ب‎·ضء؟ضذµؤ؛ىة«
            public byte byGreen; //RGBرصة«ب‎·ضء؟ضذµؤآجة«
            public byte byBlue;	//RGBرصة«ب‎·ضء؟ضذµؤہ¶ة«
            public byte byRes;	//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DAYTIME
        {
            public byte byHour;//0~24
            public byte byMinute;//0~60
            public byte bySecond;//0~60
            public byte byRes;
            public ushort wMilliSecond; //0~1000
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SCHEDULE_DAYTIME
        {
            public NET_DVR_DAYTIME struStartTime; //؟ھت¼ت±¼ن
            public NET_DVR_DAYTIME struStopTime; //½لتّت±¼ن
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DNMODE
        {
            public byte byObjectSize;//ص¼±ب²خت‎(0~100)
            public byte byMotionSensitive; /*زئ¶¯صى²âءéأô¶ب, 0 - 5,ش½¸كش½ءéأô,0xff¹ط±ص*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_MULTI_AREAPARAM
        {
            public byte byAreaNo;//اّسٍ±à؛إ(IPC- 1~8)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_VCA_RECT struRect;//µ¥¸ِاّسٍµؤ×ّ±êذإد¢(¾طذخ) size = 16;
            public NET_DVR_DNMODE  struDayNightDisable;//¹ط±صؤ£ت½
            public NET_DVR_DNMODE  struDayModeParam;//°×جىؤ£ت½
            public NET_DVR_DNMODE  struNightModeParam;//ز¹حيؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_MULTI_AREA
        {
            public byte byDayNightCtrl;//بصز¹؟طضئ 0~¹ط±ص,1~×ش¶¯اذ»»,2~¶¨ت±اذ»»(ؤ¬بد¹ط±ص)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_SCHEDULE_DAYTIME struScheduleTime;//اذ»»ت±¼ن  16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MULTI_AREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MOTION_MULTI_AREAPARAM[] struMotionMultiAreaParam;//×î´َض§³ض24¸ِاّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_SINGLE_AREA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64*96, ArraySubType = UnmanagedType.I1)]
            public byte[]byMotionScope;		/*صى²âاّسٍ,0-96خ»,±يت¾64ذذ,¹²سذ96*64¸ِذ،؛ê؟é,ؤ؟ا°سذذ§µؤتا22*18,خھ1±يت¾تازئ¶¯صى²âاّسٍ,0-±يت¾²»تا*/
            public byte byMotionSensitive;			/*زئ¶¯صى²âءéأô¶ب, 0 - 5,ش½¸كش½ءéأô,0xff¹ط±ص*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }


        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_MODE_PARAM
        {
            public NET_DVR_MOTION_SINGLE_AREA  struMotionSingleArea; //ئصح¨ؤ£ت½دآµؤµ¥اّسٍةè
            public NET_DVR_MOTION_MULTI_AREA struMotionMultiArea; //×¨¼زؤ£ت½دآµؤ¶àاّسٍةèضأ	
        }

        //زئ¶¯صى²â
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION_V40
        {
            public NET_DVR_MOTION_MODE_PARAM struMotionMode; //(5.1.0ذآشِ)
            public byte byEnableHandleMotion;       /* تا·ٌ´¦ہيزئ¶¯صى²â 0£­·ٌ 1£­تا*/
            public byte byEnableDisplay;	/*ئôسأزئ¶¯صى²â¸كءءدشت¾£¬0-·ٌ£¬1-تا*/
            public byte byConfigurationMode; //0~ئصح¨,1~×¨¼ز(5.1.0ذآشِ)
            public byte byRes1; //±£ءô×ض½ع
            /* زى³£´¦ہي·½ت½ */
            public uint dwHandleType;        //زى³£´¦ہي,زى³£´¦ہي·½ت½µؤ"»ٍ"½ل¹û  
                                             /*0x00: خقدىس¦*/
                                             /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                             /*0x02: ةùزô¾¯¸و*/
                                             /*0x04: ةد´«ضذذؤ*/
                                             /*0x08: ´¥·¢±¨¾¯تن³ِ*/
                                             /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                             /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                             /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                             /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public uint dwMaxRelAlarmOutChanNum ; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎£¨ض»¶ء£©×î´َض§³ضت‎ء؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //تµ¼ت´¥·¢µؤ±¨¾¯تن³ِ؛إ£¬°´ضµ±يت¾,²ةسأ½ô´صذحإإءذ£¬´سدآ±ê0 - dwRelAlarmOut -1سذذ§£¬بç¹ûضذ¼نسِµ½0xffffffff,شٍ؛َذّخقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS*MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*²¼·ہت±¼ن*/
            /*´¥·¢µؤآ¼دٌح¨µہ*/
            public uint dwMaxRecordChanNum;   //ةè±¸ض§³ضµؤ×î´َ¹طءھآ¼دٌح¨µہت‎-ض»¶ء
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;   /* تµ¼ت´¥·¢آ¼دٌح¨µہ£¬°´ضµ±يت¾,²ةسأ½ô´صذحإإءذ£¬´سدآ±ê0 - dwRelRecordChan -1سذذ§£¬بç¹ûضذ¼نسِµ½0xffffffff,شٍ؛َذّخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô×ض½ع
        }

        //صعµ²±¨¾¯
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_HIDEALARM_V40
        {
            public uint dwEnableHideAlarm;  /* تا·ٌئô¶¯صعµ²±¨¾¯£¬0-·ٌ£¬1-µحءéأô¶ب£¬2-ضذءéأô¶ب£¬3-¸كءéأô¶ب*/
            public ushort wHideAlarmAreaTopLeftX;			/* صعµ²اّسٍµؤx×ّ±ê */
            public ushort wHideAlarmAreaTopLeftY;			/* صعµ²اّسٍµؤy×ّ±ê */
            public ushort wHideAlarmAreaWidth;				/* صعµ²اّسٍµؤ؟ي */
            public ushort wHideAlarmAreaHeight;             /*صعµ²اّسٍµؤ¸ك*/
                                                            /* ذإ؛إ¶ھت§´¥·¢±¨¾¯تن³ِ */
            public uint dwHandleType;        //زى³£´¦ہي,زى³£´¦ہي·½ت½µؤ"»ٍ"½ل¹û  
                                             /*0x00: خقدىس¦*/
                                             /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                             /*0x02: ةùزô¾¯¸و*/
                                             /*0x04: ةد´«ضذذؤ*/
                                             /*0x08: ´¥·¢±¨¾¯تن³ِ*/
                                             /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                             /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                             /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                             /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public uint dwMaxRelAlarmOutChanNum ; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎£¨ض»¶ء£©×î´َض§³ضت‎ء؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; /*´¥·¢±¨¾¯تن³ِ؛إ£¬°´ضµ±يت¾,²ةسأ½ô´صذحإإءذ£¬´سدآ±ê0 - dwRelAlarmOut -1سذذ§£¬بç¹ûضذ¼نسِµ½0xffffffff,شٍ؛َذّخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS*MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*²¼·ہت±¼ن*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        //ذإ؛إ¶ھت§±¨¾¯
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_VILOST_V40
        {
            public uint dwEnableVILostAlarm;                /* تا·ٌئô¶¯ذإ؛إ¶ھت§±¨¾¯ ,0-·ٌ,1-تا*/
                                                            /* ذإ؛إ¶ھت§´¥·¢±¨¾¯تن³ِ */
            public uint dwHandleType;        //زى³£´¦ہي,زى³£´¦ہي·½ت½µؤ"»ٍ"½ل¹û     
                                             /*0x00: خقدىس¦*/
                                             /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                             /*0x02: ةùزô¾¯¸و*/
                                             /*0x04: ةد´«ضذذؤ*/
                                             /*0x08: ´¥·¢±¨¾¯تن³ِ*/
                                             /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                             /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                             /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                             /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public uint dwMaxRelAlarmOutChanNum ; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎£¨ض»¶ء£©×î´َض§³ضت‎ء؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; /*´¥·¢±¨¾¯تن³ِ؛إ£¬°´ضµ±يت¾,²ةسأ½ô´صذحإإءذ£¬´سدآ±ê0 - dwRelAlarmOut -1سذذ§£¬بç¹ûضذ¼نسِµ½0xffffffff,شٍ؛َذّخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS*MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime; /*²¼·ہت±¼ن*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_VICOLOR
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_COLOR[]    struColor;/*ح¼دَ²خت‎(µعز»¸ِسذذ§£¬ئنثûب‎¸ِ±£ءô)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]  struHandleTime;/*´¦ہيت±¼ن¶خ(±£ءô)*/
        }

        //ح¨µہح¼دَ½ل¹¹(V40ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;	/* ض»¶ء تسئµضئت½ 1-NTSC 2-PAL  */
            public NET_DVR_VICOLOR struViColor;//	ح¼دٌ²خت‎°´ت±¼ن¶خةèضأ
                                               //دشت¾ح¨µہأû
            public uint dwShowChanName; // ش¤ہہµؤح¼دَةدتا·ٌدشت¾ح¨µہأû³ئ,0-²»دشت¾,1-دشت¾
            public ushort wShowNameTopLeftX;				/* ح¨µہأû³ئدشت¾خ»ضأµؤx×ّ±ê */
            public ushort wShowNameTopLeftY;                /* ح¨µہأû³ئدشت¾خ»ضأµؤy×ّ±ê */
                                                            //ز‏ث½صعµ²
            public uint dwEnableHide;		/* تا·ٌئô¶¯صعµ² ,0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾OSD,0-²»دشت¾,1-دشت¾
            public ushort wOSDTopLeftX;				/* OSDµؤx×ّ±ê */
            public ushort wOSDTopLeftY;				/* OSDµؤy×ّ±ê */
            public byte byOSDType;					/* OSDہàذح(ض÷زھتاؤêشآبص¸ٌت½) */
            /* 0: XXXX-XX-XX ؤêشآبص */
            /* 1: XX-XX-XXXX شآبصؤê */
            /* 2: XXXXؤêXXشآXXبص */
            /* 3: XXشآXXبصXXXXؤê */
            /* 4: XX-XX-XXXX بصشآؤê*/
            /* 5: XXبصXXشآXXXXؤê */
            /*6: xx/xx/xxxx(شآ/بص/ؤê) */
            /*7: xxxx/xx/xx(ؤê/شآ/بص) */
            /*8: xx/xx/xxxx(بص/شآ/ؤê)*/
            public byte byDispWeek;				/* تا·ٌدشت¾ذائع */
            public byte byOSDAttrib;                /* OSDتôذش:ح¸أ÷£¬ةءث¸ */
                                                    /* 0: ²»دشت¾OSD */
                                                    /* 1: ح¸أ÷£¬ةءث¸ */
                                                    /* 2: ح¸أ÷£¬²»ةءث¸ */
                                                    /* 3: ²»ح¸أ÷£¬ةءث¸ */
                                                    /* 4: ²»ح¸أ÷£¬²»ةءث¸ */
            public byte byHourOSDType;				/* OSDذ،ت±ضئ:0-24ذ،ت±ضئ,1-12ذ،ت±ضئ */
            public byte byFontSize;      //16*16(ضذ)/8*16(س¢)£¬1-32*32(ضذ)/16*32(س¢)£¬2-64*64(ضذ)/32*64(س¢) FOR 91دµءذHD-SDI¸كاهDVR
            public byte byOSDColorType;	 //0-ؤ¬بد£¨؛ع°×£©£»1-×ش¶¨زه
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_VILOST_V40 struVILost;  //تسئµذإ؛إ¶ھت§±¨¾¯£¨ض§³ض×é£©
            public NET_DVR_VILOST_V40 struAULost;  /*زôئµذإ؛إ¶ھت§±¨¾¯£¨ض§³ض×é£©*/
            public NET_DVR_MOTION_V40 struMotion;  //زئ¶¯صى²â±¨¾¯£¨ض§³ض×é£©
            public NET_DVR_HIDEALARM_V40 struHideAlarm;  //صعµ²±¨¾¯£¨ض§³ض×é£©
            public NET_DVR_RGB_COLOR struOsdColor;//OSDرصة«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ح¨µہح¼دَ½ل¹¹(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* ض»¶ء تسئµضئت½ 1-NTSC 2-PAL*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byReservedData;/*±£ءô*/
            //دشت¾ح¨µہأû
            public uint dwShowChanName;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾ح¨µہأû³ئ,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576
            public ushort wShowNameTopLeftX;/* ح¨µہأû³ئدشت¾خ»ضأµؤx×ّ±ê */
            public ushort wShowNameTopLeftY;/* ح¨µہأû³ئدشت¾خ»ضأµؤy×ّ±ê */
            //تسئµذإ؛إ¶ھت§±¨¾¯
            public NET_DVR_VILOST_V30 struVILost;
            public NET_DVR_VILOST_V30 struRes;/*±£ءô*/
            //زئ¶¯صى²â
            public NET_DVR_MOTION_V30 struMotion;
            //صعµ²±¨¾¯
            public NET_DVR_HIDEALARM_V30 struHideAlarm;
            //صعµ²  اّسٍ´َذ،704*576
            public uint dwEnableHide;/* تا·ٌئô¶¯صعµ² ,0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾OSD,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576
            public ushort wOSDTopLeftX;/* OSDµؤx×ّ±ê */
            public ushort wOSDTopLeftY;/* OSDµؤy×ّ±ê */
            public byte byOSDType;/* OSDہàذح(ض÷زھتاؤêشآبص¸ٌت½) */
            /* 0: XXXX-XX-XX ؤêشآبص */
            /* 1: XX-XX-XXXX شآبصؤê */
            /* 2: XXXXؤêXXشآXXبص */
            /* 3: XXشآXXبصXXXXؤê */
            /* 4: XX-XX-XXXX بصشآؤê*/
            /* 5: XXبصXXشآXXXXؤê */
            public byte byDispWeek;/* تا·ٌدشت¾ذائع */
            public byte byOSDAttrib;/* OSDتôذش:ح¸أ÷£¬ةءث¸ */
            /* 0: ²»دشت¾OSD */
            /* 1: ح¸أ÷,ةءث¸ */
            /* 2: ح¸أ÷,²»ةءث¸ */
            /* 3: ةءث¸,²»ح¸أ÷ */
            /* 4: ²»ح¸أ÷,²»ةءث¸ */
            public byte byHourOSDType;/* OSDذ،ت±ضئ:0-24ذ،ت±ضئ,1-12ذ،ت±ضئ */
            public byte byFontSize;//×ضجه´َذ،£¬16*16(ضذ)/8*16(س¢)£¬1-32*32(ضذ)/16*32(س¢)£¬2-64*64(ضذ)/32*64(س¢)  3-48*48(ضذ)/24*48(س¢) 0xff-×شتتس¦(adaptive)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ح¨µہح¼دَ½ل¹¹SDK_V14ہ©ص¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* ض»¶ء تسئµضئت½ 1-NTSC 2-PAL*/
            public byte byBrightness;/*ءء¶ب,0-255*/
            public byte byContrast;/*¶ش±ب¶ب,0-255*/
            public byte bySaturation;/*±¥؛ح¶ب,0-255 */
            public byte byHue;/*ة«µ÷,0-255*/
            //دشت¾ح¨µہأû
            public uint dwShowChanName;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾ح¨µہأû³ئ,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576
            public ushort wShowNameTopLeftX;/* ح¨µہأû³ئدشت¾خ»ضأµؤx×ّ±ê */
            public ushort wShowNameTopLeftY;/* ح¨µہأû³ئدشت¾خ»ضأµؤy×ّ±ê */
            //ذإ؛إ¶ھت§±¨¾¯
            public NET_DVR_VILOST struVILost;
            //زئ¶¯صى²â
            public NET_DVR_MOTION struMotion;
            //صعµ²±¨¾¯
            public NET_DVR_HIDEALARM struHideAlarm;
            //صعµ²  اّسٍ´َذ،704*576
            public uint dwEnableHide;/* تا·ٌئô¶¯صعµ² ,0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾OSD,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576
            public ushort wOSDTopLeftX;/* OSDµؤx×ّ±ê */
            public ushort wOSDTopLeftY;/* OSDµؤy×ّ±ê */
            public byte byOSDType;/* OSDہàذح(ض÷زھتاؤêشآبص¸ٌت½) */
            /* 0: XXXX-XX-XX ؤêشآبص */
            /* 1: XX-XX-XXXX شآبصؤê */
            /* 2: XXXXؤêXXشآXXبص */
            /* 3: XXشآXXبصXXXXؤê */
            /* 4: XX-XX-XXXX بصشآؤê*/
            /* 5: XXبصXXشآXXXXؤê */
            public byte byDispWeek;/* تا·ٌدشت¾ذائع */
            public byte byOSDAttrib;/* OSDتôذش:ح¸أ÷£¬ةءث¸ */
            /* 0: ²»دشت¾OSD */
            /* 1: ح¸أ÷,ةءث¸ */
            /* 2: ح¸أ÷,²»ةءث¸ */
            /* 3: ةءث¸,²»ح¸أ÷ */
            /* 4: ²»ح¸أ÷,²»ةءث¸ */
            public byte byHourOsdType;/* OSDذ،ت±ضئ:0-24ذ،ت±ضئ,1-12ذ،ت±ضئ */
        }

        //ح¨µہح¼دَ½ل¹¹(SDK_V13¼°ض®ا°°و±¾)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* ض»¶ء تسئµضئت½ 1-NTSC 2-PAL*/
            public byte byBrightness;/*ءء¶ب,0-255*/
            public byte byContrast;/*¶ش±ب¶ب,0-255*/
            public byte bySaturation;/*±¥؛ح¶ب,0-255 */
            public byte byHue;/*ة«µ÷,0-255*/
            //دشت¾ح¨µہأû
            public uint dwShowChanName;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾ح¨µہأû³ئ,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576
            public ushort wShowNameTopLeftX;/* ح¨µہأû³ئدشت¾خ»ضأµؤx×ّ±ê */
            public ushort wShowNameTopLeftY;/* ح¨µہأû³ئدشت¾خ»ضأµؤy×ّ±ê */
            //ذإ؛إ¶ھت§±¨¾¯
            public NET_DVR_VILOST struVILost;
            //زئ¶¯صى²â
            public NET_DVR_MOTION struMotion;
            //صعµ²±¨¾¯
            public NET_DVR_HIDEALARM struHideAlarm;
            //صعµ²  اّسٍ´َذ،704*576
            public uint dwEnableHide;/* تا·ٌئô¶¯صعµ² ,0-·ٌ,1-تا*/
            public ushort wHideAreaTopLeftX;/* صعµ²اّسٍµؤx×ّ±ê */
            public ushort wHideAreaTopLeftY;/* صعµ²اّسٍµؤy×ّ±ê */
            public ushort wHideAreaWidth;/* صعµ²اّسٍµؤ؟ي */
            public ushort wHideAreaHeight;/*صعµ²اّسٍµؤ¸ك*/
            //OSD
            public uint dwShowOsd;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾OSD,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576
            public ushort wOSDTopLeftX;/* OSDµؤx×ّ±ê */
            public ushort wOSDTopLeftY;/* OSDµؤy×ّ±ê */
            public byte byOSDType;/* OSDہàذح(ض÷زھتاؤêشآبص¸ٌت½) */
            /* 0: XXXX-XX-XX ؤêشآبص */
            /* 1: XX-XX-XXXX شآبصؤê */
            /* 2: XXXXؤêXXشآXXبص */
            /* 3: XXشآXXبصXXXXؤê */
            /* 4: XX-XX-XXXX بصشآؤê*/
            /* 5: XXبصXXشآXXXXؤê */
            public byte byDispWeek;/* تا·ٌدشت¾ذائع */
            public byte byOSDAttrib;/* OSDتôذش:ح¸أ÷£¬ةءث¸ */
            /* 0: ²»دشت¾OSD */
            /* 1: ح¸أ÷,ةءث¸ */
            /* 2: ح¸أ÷,²»ةءث¸ */
            /* 3: ةءث¸,²»ح¸أ÷ */
            /* 4: ²»ح¸أ÷,²»ةءث¸ */
            public byte reservedData2;
        }

        //آëء÷ر¹ثُ²خت‎(×س½ل¹¹)(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_V30
        {
            public byte byStreamType;//آëء÷ہàذح 0-تسئµء÷, 1-¸´؛دء÷, ±يت¾تآ¼‏ر¹ثُ²خت‎ت±×î¸كخ»±يت¾تا·ٌئôسأر¹ثُ²خت‎
            public byte byResolution;//·ض±وآت0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5£¨±£ءô£©16-VGA£¨640*480£© 17-UXGA£¨1600*1200£© 18-SVGA £¨800*600£©19-HD720p£¨1280*720£©20-XVGA  21-HD900p
            public byte byBitrateType;//آëآتہàذح 0:±نآëآت, 1:¶¨آëآت
            public byte byPicQuality;//ح¼دَضتء؟ 0-×î؛أ 1-´خ؛أ 2-½د؛أ 3-ز»°م 4-½د²î 5-²î
            public uint dwVideoBitrate;//تسئµآëآت 0-±£ءô 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //×î¸كخ»(31خ»)ضأ³ة1±يت¾تا×ش¶¨زهآëء÷, 0-30خ»±يت¾آëء÷ضµ،£
            public uint dwVideoFrameRate;//ض،آت 0-ب«²؟; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0°و±¾ضذذآ¼س14-15; 15-18; 16-22;
            public ushort wIntervalFrameI;//Iض،¼ن¸ô
            //2006-08-11 شِ¼سµ¥Pض،µؤإنضأ½س؟ع£¬؟ةزش¸ؤةئتµت±ء÷رست±ختجâ
            public byte byIntervalBPFrame;//0-BBPض،; 1-BPض،; 2-µ¥Pض،
            public byte byres1; //±£ءô
            public byte byVideoEncType;//تسئµ±àآëہàذح 0 hik264;1±ê×¼h264; 2±ê×¼mpeg4;
            public byte byAudioEncType; //زôئµ±àآëہàذح 0£­OggVorbis
            public byte byVideoEncComplexity; //تسئµ±àآë¸´شس¶ب£¬0-µح£¬1-ضذ£¬2¸ك,0xfe:×ش¶¯£¬؛حش´ز»ضآ
            public byte byEnableSvc; //0 - ²»ئôسأSVC¹¦ؤـ£»1- ئôسأSVC¹¦ؤـ
            public byte byFormatType; //·â×°ہàذح£¬1-آمء÷£¬2-RTP·â×°£¬3-PS·â×°£¬4-TS·â×°£¬5-ث½سذ£¬6-FLV£¬7-ASF£¬8-3GP,9-RTP+PS£¨¹ْ±ê£؛GB28181£©£¬0xff-خقذ§
            public byte byAudioBitRate; //زôئµآëآت0-ؤ¬بد£¬1-8Kbps, 2- 16Kbps, 3-32Kbps£¬4-64Kbps£¬5-128Kbps£¬6-192Kbps£»(IPC5.1.0ؤ¬بد4-64Kbps)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎
        }

        //ح¨µہر¹ثُ²خت‎(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_V30
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;//آ¼دٌ ¶شس¦8000µؤئصح¨
            public NET_DVR_COMPRESSION_INFO_V30 struRes;//±£ءô char reserveData[28];
            public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;//تآ¼‏´¥·¢ر¹ثُ²خت‎
            public NET_DVR_COMPRESSION_INFO_V30 struNetPara;//حّ´«(×سآëء÷)
        }

        //آëء÷ر¹ثُ²خت‎(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO
        {
            public byte byStreamType;//آëء÷ہàذح0-تسئµء÷,1-¸´؛دء÷,±يت¾ر¹ثُ²خت‎ت±×î¸كخ»±يت¾تا·ٌئôسأر¹ثُ²خت‎
            public byte byResolution;//·ض±وآت0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(³µشط×¨سأ)
            public byte byBitrateType;//آëآتہàذح0:±نآëآت£¬1:¶¨آëآت
            public byte byPicQuality;//ح¼دَضتء؟ 0-×î؛أ 1-´خ؛أ 2-½د؛أ 3-ز»°م 4-½د²î 5-²î
            public uint dwVideoBitrate; //تسئµآëآت 0-±£ءô 1-16K(±£ءô) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //×î¸كخ»(31خ»)ضأ³ة1±يت¾تا×ش¶¨زهآëء÷, 0-30خ»±يت¾آëء÷ضµ(MIN-32K MAX-8192K)،£
            public uint dwVideoFrameRate;//ض،آت 0-ب«²؟; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
        }

        //ح¨µہر¹ثُ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO struRecordPara;//آ¼دٌ/تآ¼‏´¥·¢آ¼دٌ
            public NET_DVR_COMPRESSION_INFO struNetPara;//حّ´«/±£ءô
        }

        //آëء÷ر¹ثُ²خت‎(×س½ل¹¹)(ہ©ص¹) شِ¼سIض،¼ن¸ô
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_EX
        {
            public byte byStreamType;//آëء÷ہàذح0-تسئµء÷, 1-¸´؛دء÷
            public byte byResolution;//·ض±وآت0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(³µشط×¨سأ)
            public byte byBitrateType;//آëآتہàذح0:±نآëآت£¬1:¶¨آëآت
            public byte byPicQuality;//ح¼دَضتء؟ 0-×î؛أ 1-´خ؛أ 2-½د؛أ 3-ز»°م 4-½د²î 5-²î
            public uint dwVideoBitrate;//تسئµآëآت 0-±£ءô 1-16K(±£ءô) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //×î¸كخ»(31خ»)ضأ³ة1±يت¾تا×ش¶¨زهآëء÷, 0-30خ»±يت¾آëء÷ضµ(MIN-32K MAX-8192K)،£
            public uint dwVideoFrameRate;//ض،آت 0-ب«²؟; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0شِ¼س14-15, 15-18, 16-22;
            public ushort wIntervalFrameI;//Iض،¼ن¸ô
            //2006-08-11 شِ¼سµ¥Pض،µؤإنضأ½س؟ع£¬؟ةزش¸ؤةئتµت±ء÷رست±ختجâ
            public byte byIntervalBPFrame;//0-BBPض،; 1-BPض،; 2-µ¥Pض،
            public byte byRes;
        }

        //ح¨µہر¹ثُ²خت‎(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_EX
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struRecordPara;//آ¼دٌ
            public NET_DVR_COMPRESSION_INFO_EX struNetPara;//حّ´«
        }

        //ت±¼ن¶خآ¼دٌ²خت‎إنضأ(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDSCHED
        {
            public NET_DVR_SCHEDTIME struRecordTime;
            public byte byRecordType;//0:¶¨ت±آ¼دٌ£¬1:زئ¶¯صى²â£¬2:±¨¾¯آ¼دٌ£¬3:¶¯²â|±¨¾¯£¬4:¶¯²â&±¨¾¯, 5:أüءî´¥·¢, 6: ضاؤـآ¼دٌ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string reservedData;
        }

        //ب«جىآ¼دٌ²خت‎إنضأ(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDDAY
        {
            public ushort wAllDayRecord;/* تا·ٌب«جىآ¼دٌ 0-·ٌ 1-تا*/
            public byte byRecordType;/* آ¼دَہàذح 0:¶¨ت±آ¼دٌ£¬1:زئ¶¯صى²â£¬2:±¨¾¯آ¼دٌ£¬3:¶¯²â|±¨¾¯£¬4:¶¯²â&±¨¾¯ 5:أüءî´¥·¢, 6: ضاؤـآ¼دٌ*/
            public byte reservedData;
        }

        //ح¨µہآ¼دٌ²خت‎إنضأ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_V30
        {
            public uint dwSize;
            public uint dwRecord;/*تا·ٌآ¼دٌ 0-·ٌ 1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* آ¼دَرست±³¤¶ب 0-5أë£¬ 1-20أë£¬ 2-30أë£¬ 3-1·ضضس£¬ 4-2·ضضس£¬ 5-5·ضضس£¬ 6-10·ضضس*/
            public uint dwPreRecordTime;/* ش¤آ¼ت±¼ن 0-²»ش¤آ¼ 1-5أë 2-10أë 3-15أë 4-20أë 5-25أë 6-30أë 7-0xffffffff(¾،؟ةؤـش¤آ¼) */
            public uint dwRecorderDuration;/* آ¼دٌ±£´وµؤ×î³¤ت±¼ن */
            public byte byRedundancyRec;/*تا·ٌبكسàآ¼دٌ,ضطزھت‎¾فث«±¸·ف£؛0/1*/
            public byte byAudioRec;/*آ¼دٌت±¸´؛دء÷±àآëت±تا·ٌ¼اآ¼زôئµت‎¾ف£؛¹ْحâسذ´ث·¨¹و*/
            public byte byStreamType;  // 0:ض÷آëء÷ 1£؛×سآëء÷
            public byte byPassbackRecord;  // 0:²»»ط´«آ¼دٌ 1£؛»ط´«آ¼دٌ
            public ushort wLockDuration;  // آ¼دٌثّ¶¨ت±³¤£¬µ¥خ»ذ،ت± 0±يت¾²»ثّ¶¨£¬0xffff±يت¾سہ¾أثّ¶¨£¬آ¼دٌ¶خµؤت±³¤´َسعثّ¶¨µؤ³ضذّت±³¤µؤآ¼دٌ£¬½«²»»لثّ¶¨
            public byte byRecordBackup;  // 0:آ¼دٌ²»´وµµ 1£؛آ¼دٌ´وµµ
            public byte bySVCLevel;	//SVC³éض،ہàذح£؛0-²»³é£¬1-³é¶‏·ضض®ز» 2-³éثؤ·ضض®ب‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;
        }

        //ح¨µہآ¼دٌ²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD
        {
            public uint dwSize;
            public uint dwRecord;/*تا·ٌآ¼دٌ 0-·ٌ 1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* آ¼دَت±¼ن³¤¶ب */
            public uint dwPreRecordTime;/* ش¤آ¼ت±¼ن 0-²»ش¤آ¼ 1-5أë 2-10أë 3-15أë 4-20أë 5-25أë 6-30أë 7-0xffffffff(¾،؟ةؤـش¤آ¼) */
        }

        //شئج¨ذ­زé±ي½ل¹¹إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_PROTOCOL
        {
            public uint dwType;/*½âآëئ÷ہàذحضµ£¬´س1؟ھت¼ء¬ذّµفشِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe;/*½âآëئ÷µؤأèتِ·û£¬؛ح8000ضذµؤز»ضآ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PTZ_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZ_PROTOCOL[] struPtz;/*×î´َ200ضذPTZذ­زé*/
            public uint dwPtzNum;/*سذذ§µؤptzذ­زéت‎ؤ؟£¬´س0؟ھت¼(¼´¼ئثمت±¼س1)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************شئج¨ہàذح(end)******************************/

        //ح¨µہ½âآëئ÷(شئج¨)²خت‎إنضأ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG_V30
        {
            public uint dwSize;
            public uint dwBaudRate;//²¨جطآت(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;
            public byte byDataBit;// ت‎¾فسذ¼¸خ» 0£­5خ»£¬1£­6خ»£¬2£­7خ»£¬3£­8خ»;
            public byte byStopBit;// ح£ض¹خ» 0£­1خ»£¬1£­2خ»
            public byte byParity;// ذ£رé 0£­خقذ£رé£¬1£­ئوذ£رé£¬2£­إ¼ذ£رé;
            public byte byFlowcontrol;// 0£­خق£¬1£­بيء÷؟ط,2-س²ء÷؟ط
            public ushort wDecoderType;//½âآëئ÷ہàذح, ´س0؟ھت¼£¬¶شس¦ptzذ­زéءذ±ي
            public ushort wDecoderAddress;/*½âآëئ÷µطض·:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* ش¤ضأµمتا·ٌةèضأ,0-أ»سذةèضأ,1-ةèضأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* ر²؛½تا·ٌةèضأ: 0-أ»سذةèضأ,1-ةèضأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* ¹ى¼£تا·ٌةèضأ,0-أ»سذةèضأ,1-ةèضأ*/
        }

        //ح¨µہ½âآëئ÷(شئج¨)²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG
        {
            public uint dwSize;
            public uint dwBaudRate; //²¨جطآت(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;
            public byte byDataBit; // ت‎¾فسذ¼¸خ» 0£­5خ»£¬1£­6خ»£¬2£­7خ»£¬3£­8خ»;
            public byte byStopBit;// ح£ض¹خ» 0£­1خ»£¬1£­2خ»;
            public byte byParity; // ذ£رé 0£­خقذ£رé£¬1£­ئوذ£رé£¬2£­إ¼ذ£رé;
            public byte byFlowcontrol;// 0£­خق£¬1£­بيء÷؟ط,2-س²ء÷؟ط
            public ushort wDecoderType;//½âآëئ÷ہàذح, 0£­YouLi£¬1£­LiLin-1016£¬2£­LiLin-820£¬3£­Pelco-p£¬4£­DM DynaColor£¬5£­HD600£¬6£­JC-4116£¬7£­Pelco-d WX£¬8£­Pelco-d PICO
            public ushort wDecoderAddress;/*½âآëئ÷µطض·:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* ش¤ضأµمتا·ٌةèضأ,0-أ»سذةèضأ,1-ةèضأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* ر²؛½تا·ٌةèضأ: 0-أ»سذةèضأ,1-ةèضأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* ¹ى¼£تا·ٌةèضأ,0-أ»سذةèضأ,1-ةèضأ*/
        }

        //ppp²خت‎إنضأ(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG_V30
        {
            public NET_DVR_IPADDR struRemoteIP;//ش¶¶ثIPµطض·
            public NET_DVR_IPADDR struLocalIP;//±¾µطIPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//±¾µطIPµطض·رعآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            public byte byPPPMode;//PPPؤ£ت½, 0£­ض÷¶¯£¬1£­±»¶¯
            public byte byRedial;//تا·ٌ»ط²¦ £؛0-·ٌ,1-تا
            public byte byRedialMode;//»ط²¦ؤ£ت½,0-سة²¦بëصكض¸¶¨,1-ش¤ضأ»ط²¦؛إآë
            public byte byDataEncrypt;//ت‎¾ف¼سأـ,0-·ٌ,1-تا
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//µç»°؛إآë
        }

        //ppp²خت‎إنضأ(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteIP;//ش¶¶ثIPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIP;//±¾µطIPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//±¾µطIPµطض·رعآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            public byte byPPPMode;//PPPؤ£ت½, 0£­ض÷¶¯£¬1£­±»¶¯
            public byte byRedial;//تا·ٌ»ط²¦ £؛0-·ٌ,1-تا
            public byte byRedialMode;//»ط²¦ؤ£ت½,0-سة²¦بëصكض¸¶¨,1-ش¤ضأ»ط²¦؛إآë
            public byte byDataEncrypt;//ت‎¾ف¼سأـ,0-·ٌ,1-تا
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//µç»°؛إآë
        }

        //RS232´®؟ع²خت‎إنضأ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_RS232
        {
            public uint dwBaudRate;/*²¨جطآت(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;*/
            public byte byDataBit;/* ت‎¾فسذ¼¸خ» 0£­5خ»£¬1£­6خ»£¬2£­7خ»£¬3£­8خ» */
            public byte byStopBit;/* ح£ض¹خ» 0£­1خ»£¬1£­2خ» */
            public byte byParity;/* ذ£رé 0£­خقذ£رé£¬1£­ئوذ£رé£¬2£­إ¼ذ£رé */
            public byte byFlowcontrol;/* 0£­خق£¬1£­بيء÷؟ط,2-س²ء÷؟ط */
            public uint dwWorkMode; /* ¹¤×÷ؤ£ت½£¬0£­232´®؟عسأسعPPP²¦؛إ£¬1£­232´®؟عسأسع²خت‎؟طضئ£¬2£­ح¸أ÷ح¨µہ */
        }

        //RS232´®؟ع²خت‎إنضأ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG_V30
        {
            public uint dwSize;
            public NET_DVR_SINGLE_RS232 struRs232;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PPPCFG_V30 struPPPConfig;
        }

        //RS232´®؟ع²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG
        {
            public uint dwSize;
            public uint dwBaudRate;//²¨جطآت(bps)£¬0£­50£¬1£­75£¬2£­110£¬3£­150£¬4£­300£¬5£­600£¬6£­1200£¬7£­2400£¬8£­4800£¬9£­9600£¬10£­19200£¬ 11£­38400£¬12£­57600£¬13£­76800£¬14£­115.2k;
            public byte byDataBit;// ت‎¾فسذ¼¸خ» 0£­5خ»£¬1£­6خ»£¬2£­7خ»£¬3£­8خ»;
            public byte byStopBit;// ح£ض¹خ» 0£­1خ»£¬1£­2خ»;
            public byte byParity;// ذ£رé 0£­خقذ£رé£¬1£­ئوذ£رé£¬2£­إ¼ذ£رé;
            public byte byFlowcontrol;// 0£­خق£¬1£­بيء÷؟ط,2-س²ء÷؟ط
            public uint dwWorkMode;// ¹¤×÷ؤ£ت½£¬0£­ص­´ّ´«تن(232´®؟عسأسعPPP²¦؛إ)£¬1£­؟طضئج¨(232´®؟عسأسع²خت‎؟طضئ)£¬2£­ح¸أ÷ح¨µہ
            public NET_DVR_PPPCFG struPPPConfig;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESETCHAN_INFO
        {
            public uint dwEnablePresetChan;	/*ئôسأش¤ضأµمµؤح¨µہ*/
            public uint dwPresetPointNo;		/*µ÷سأش¤ضأµمح¨µہ¶شس¦µؤش¤ضأµمذٍ؛إ, 0xfffffff±يت¾²»µ÷سأش¤ضأµم،£*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISECHAN_INFO
        {
            public uint dwEnableCruiseChan;	/*ئôسأر²؛½µؤح¨µہ*/
            public uint dwCruiseNo;		/*ر²؛½ح¨µہ¶شس¦µؤر²؛½±à؛إ, 0xfffffff±يت¾خقذ§*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZTRACKCHAN_INFO
        {
            public uint dwEnablePtzTrackChan;	/*ئôسأشئج¨¹ى¼£µؤح¨µہ*/
            public uint dwPtzTrackNo;		/*شئج¨¹ى¼£ح¨µہ¶شس¦µؤ±à؛إ, 0xfffffff±يت¾خقذ§*/
        }

        //±¨¾¯تنبë²خت‎إنضأ(256آ·NVRہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;	/* أû³ئ */
            public byte byAlarmType;	            //±¨¾¯ئ÷ہàذح,0£؛³£؟ھ,1£؛³£±ص
            public byte byAlarmInHandle;	        /* تا·ٌ´¦ہي 0-²»´¦ہي 1-´¦ہي*/
            public byte byChannel;                 // ±¨¾¯تنبë´¥·¢ضاؤـت¶±ًح¨µہ
            public byte byRes1;                    //±£ءô			
            public uint dwHandleType;        //زى³£´¦ہي,زى³£´¦ہي·½ت½µؤ"»ٍ"½ل¹û   
                                             /*0x00: خقدىس¦*/
                                             /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                             /*0x02: ةùزô¾¯¸و*/
                                             /*0x04: ةد´«ضذذؤ*/
                                             /*0x08: ´¥·¢±¨¾¯تن³ِ*/
                                             /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                             /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                             /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                             /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public uint dwMaxRelAlarmOutChanNum ; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎£¨ض»¶ء£©×î´َض§³ضت‎ء؟
            public uint dwRelAlarmOutChanNum; //´¥·¢µؤ±¨¾¯تن³ِح¨µہت‎ تµ¼تض§³ضت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //´¥·¢±¨¾¯ح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            /*´¥·¢µؤآ¼دٌح¨µہ*/
            public uint dwMaxRecordChanNum;   //ةè±¸ض§³ضµؤ×î´َ¹طءھآ¼دٌح¨µہت‎-ض»¶ء
            public uint dwCurRecordChanNum;    //µ±ا°تµ¼تزرإنضأµؤ¹طءھآ¼دٌح¨µہت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;   /* تµ¼ت´¥·¢آ¼دٌح¨µہ£¬°´ضµ±يت¾,²ةسأ½ô´صذحإإءذ£¬´سدآ±ê0 - dwCurRecordChanNum -1سذذ§£¬بç¹ûضذ¼نسِµ½0xffffffff,شٍ؛َذّخقذ§*/
            public uint dwMaxEnablePtzCtrlNun; //×î´َ؟ةئôسأµؤشئج¨؟طضئ×ـت‎(ض»¶ء)
            public uint dwEnablePresetChanNum;  //µ±ا°زرئôسأش¤ضأµمµؤت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PRESETCHAN_INFO[] struPresetChanInfo; //ئôسأµؤش¤ضأµمذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;					/*±£ءô*/
            public uint dwEnableCruiseChanNum;  //µ±ا°زرئôسأر²؛½µؤح¨µہت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISECHAN_INFO[] struCruiseChanInfo; //ئôسأر²؛½¹¦ؤـح¨µہµؤذإد¢
            public uint dwEnablePtzTrackChanNum;  //µ±ا°زرئôسأر²؛½µؤح¨µہت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZTRACKCHAN_INFO[] struPtzTrackInfo; //µ÷سأشئج¨¹ى¼£µؤح¨µہذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±¨¾¯تنبë²خت‎إنضأ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* أû³ئ */
            public byte byAlarmType; //±¨¾¯ئ÷ہàذح,0£؛³£؟ھ,1£؛³£±ص
            public byte byAlarmInHandle; /* تا·ٌ´¦ہي 0-²»´¦ہي 1-´¦ہي*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* تا·ٌµ÷سأش¤ضأµم 0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* µ÷سأµؤشئج¨ش¤ضأµمذٍ؛إ,ز»¸ِ±¨¾¯تنبë؟ةزشµ÷سأ¶à¸ِح¨µہµؤشئج¨ش¤ضأµم, 0xff±يت¾²»µ÷سأش¤ضأµم،£*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*±£ءô*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* تا·ٌµ÷سأر²؛½ 0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* ر²؛½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* تا·ٌµ÷سأ¹ى¼£ 0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* µ÷سأµؤشئج¨µؤ¹ى¼£ذٍ؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_IO_ALARM
        {
            public uint dwAlarmInputNo;		//·¢ةْ±¨¾¯µؤ±¨¾¯تنبëح¨µہ؛إ£¬ز»´خض»سذز»¸ِ
            public uint dwTrigerAlarmOutNum;	/*´¥·¢µؤ±¨¾¯تن³ِ¸ِت‎£¬سأسع؛َأو¼ئثم±ن³¤ت‎¾ف²؟·ضضذثùسذ´¥·¢µؤ±¨¾¯تن³ِح¨µہ؛إ£¬ثؤ×ض½ع±يت¾ز»¸ِ*/
            public uint dwTrigerRecordChanNum;	/*´¥·¢µؤآ¼دٌح¨µہ¸ِت‎£¬سأسع؛َأو¼ئثم±ن³¤ت‎¾ف²؟·ضضذثùسذ´¥·¢µؤآ¼دٌح¨µہ؛إ£¬ثؤ×ض½ع±يت¾ز»¸ِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_CHANNEL
        {
            public uint dwAlarmChanNum;	/*·¢ةْ±¨¾¯ح¨µہت‎¾ف¸ِت‎£¬سأسع؛َأو¼ئثم±ن³¤ت‎¾ف²؟·ضضذثùسذ·¢ةْµؤ±¨¾¯ح¨µہ؛إ£¬ثؤ×ض½ع±يت¾ز»¸ِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_HD
        {
            public uint dwAlarmHardDiskNum;	/*·¢ةْ±¨¾¯µؤس²إجت‎¾ف³¤¶ب£¬سأسع؛َأو¼ئثم±ن³¤ت‎¾ف²؟·ضضذثùسذ·¢ةْ±¨¾¯µؤس²إج؛إ£¬ثؤ½ع±يت¾ز»¸ِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ALARMINFO_FIXED
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnionLen;
            [FieldOffset(0)]
            public STRUCT_IO_ALARM struIOAlarm;// ±¨¾¯ہàذحdwAlarmTypeخھ0ت±سذذ§
            [FieldOffset(0)]
            public STRUCT_ALARM_CHANNEL struAlarmChannel; // dwAlarmTypeخھ2£¬3£¬6£¬9£¬10»ٍ13ت±سذذ§
            [FieldOffset(0)]
            public STRUCT_ALARM_HD struAlarmHardDisk; // dwAlarmTypeخھ1,4,5ت±سذذ§           
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALRAM_FIXED_HEADER
        {
            public uint dwAlarmType;              /*0-ذإ؛إء؟±¨¾¯,1-س²إجآْ,2-ذإ؛إ¶ھت§£¬3£­زئ¶¯صى²â£¬4£­س²إجخ´¸ٌت½»¯,5-ذ´س²إج³ِ´ي,6-صعµ²±¨¾¯£¬7-ضئت½²»ئ¥إن, 8-·ا·¨·أخت£¬9-تسئµذإ؛إزى³££¬10-آ¼دٌزى³££¬11-ضاؤـ³،¾°±ن»¯£¬12-صَءذزى³££¬13-ا°¶ث/آ¼دٌ·ض±وآت²»ئ¥إن*/
            public NET_DVR_TIME_EX struAlarmTime;	//·¢ةْ±¨¾¯µؤت±¼ن
            public UNION_ALARMINFO_FIXED uStruAlarm;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V40
        {
            public NET_DVR_ALRAM_FIXED_HEADER struAlarmFixedHeader;	//±¨¾¯¹ج¶¨²؟·ض
            public IntPtr pAlarmData;   //±¨¾¯؟ة±ن²؟·ضؤعبف
        }

        //±¨¾¯تنبë²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* أû³ئ */
            public byte byAlarmType;//±¨¾¯ئ÷ہàذح,0£؛³£؟ھ,1£؛³£±ص
            public byte byAlarmInHandle;/* تا·ٌ´¦ہي 0-²»´¦ہي 1-´¦ہي*/
            public byte byChannel;     // ±¨¾¯تنبë´¥·¢ضاؤـت¶±ًح¨µہ
            public byte byRes;
            public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;/* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* تا·ٌµ÷سأش¤ضأµم 0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* µ÷سأµؤشئج¨ش¤ضأµمذٍ؛إ,ز»¸ِ±¨¾¯تنبë؟ةزشµ÷سأ¶à¸ِح¨µہµؤشئج¨ش¤ضأµم, 0xff±يت¾²»µ÷سأش¤ضأµم،£*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* تا·ٌµ÷سأر²؛½ 0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* ر²؛½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* تا·ٌµ÷سأ¹ى¼£ 0-·ٌ,1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* µ÷سأµؤشئج¨µؤ¹ى¼£ذٍ؛إ */
        }

        //ؤ£ؤâ±¨¾¯تنبë²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOG_ALARMINCFG
        {
            public uint dwSize;
            public byte byEnableAlarmHandle; //´¦ہي±¨¾¯تنبë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInName; //ؤ£ؤâ±¨¾¯تنبëأû³ئ
            public ushort wAlarmInUpper; //ؤ£ؤâتنبëµçر¹ةددق£¬تµ¼تضµ³ث10£¬·¶خ§0~360
            public ushort wAlarmInLower; //ؤ£ؤâتنبëµçر¹دآدق£¬تµ¼تضµ³ث10£¬·¶خ§0~360 
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType; /* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±»´¥·¢µؤآ¼دٌح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ةد´«±¨¾¯ذإد¢(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V30
        {
            public uint dwAlarmType;/*0-ذإ؛إء؟±¨¾¯,1-س²إجآْ,2-ذإ؛إ¶ھت§,3£­زئ¶¯صى²â,4£­س²إجخ´¸ٌت½»¯,5-¶ءذ´س²إج³ِ´ي,6-صعµ²±¨¾¯,7-ضئت½²»ئ¥إن, 8-·ا·¨·أخت, 0xa-GPS¶¨خ»ذإد¢(³µشط¶¨ضئ)*/
            public uint dwAlarmInputNumber;/*±¨¾¯تنبë¶ث؟ع*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutputNumber;/*´¥·¢µؤتن³ِ¶ث؟ع£¬خھ1±يت¾¶شس¦تن³ِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmRelateChannel;/*´¥·¢µؤآ¼دٌح¨µہ£¬خھ1±يت¾¶شس¦آ¼دٌ, dwAlarmRelateChannel[0]¶شس¦µع1¸ِح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*dwAlarmTypeخھ2»ٍ3,6ت±£¬±يت¾ؤؤ¸ِح¨µہ£¬dwChannel[0]¶شس¦µع1¸ِح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskNumber;/*dwAlarmTypeخھ1,4,5ت±,±يت¾ؤؤ¸ِس²إج, dwDiskNumber[0]¶شس¦µع1¸ِس²إج*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                byAlarmRelateChannel = new byte [ MAX_CHANNUM_V30 ];
                byChannel = new byte [ MAX_CHANNUM_V30 ];
                byAlarmOutputNumber = new byte [ MAX_ALARMOUT_V30 ];
                byDiskNumber = new byte [ MAX_DISKNUM_V30 ];
                for ( int i = 0; i < MAX_CHANNUM_V30; i++ )
                {
                    byAlarmRelateChannel [ i ] = Convert.ToByte(0);
                    byChannel [ i ] = Convert.ToByte(0);
                }
                for ( int i = 0; i < MAX_ALARMOUT_V30; i++ )
                {
                    byAlarmOutputNumber [ i ] = Convert.ToByte(0);
                }
                for ( int i = 0; i < MAX_DISKNUM_V30; i++ )
                {
                    byDiskNumber [ i ] = Convert.ToByte(0);
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for ( int i = 0; i < MAX_CHANNUM_V30; i++ )
                {
                    byAlarmRelateChannel [ i ] = Convert.ToByte(0);
                    byChannel [ i ] = Convert.ToByte(0);
                }
                for ( int i = 0; i < MAX_ALARMOUT_V30; i++ )
                {
                    byAlarmOutputNumber [ i ] = Convert.ToByte(0);
                }
                for ( int i = 0; i < MAX_DISKNUM_V30; i++ )
                {
                    byDiskNumber [ i ] = Convert.ToByte(0);
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_HOT_SPARE
        {
            public uint dwSize;   //½ل¹¹جه
            public uint dwExceptionCase;   //±¨¾¯ش­زٍ   0-حّآçزى³£
            public NET_DVR_IPADDR  struDeviceIP;    //²ْةْزى³£µؤةè±¸IPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO
        {
            public int dwAlarmType;/*0-ذإ؛إء؟±¨¾¯,1-س²إجآْ,2-ذإ؛إ¶ھت§,3£­زئ¶¯صى²â,4£­س²إجخ´¸ٌت½»¯,5-¶ءذ´س²إج³ِ´ي,6-صعµ²±¨¾¯,7-ضئت½²»ئ¥إن, 8-·ا·¨·أخت, 9-´®؟ع×´ج¬, 0xa-GPS¶¨خ»ذإد¢(³µشط¶¨ضئ)*/
            public int dwAlarmInputNumber;/*±¨¾¯تنبë¶ث؟ع, µ±±¨¾¯ہàذحخھ9ت±¸أ±نء؟±يت¾´®؟ع×´ج¬0±يت¾ص‎³££¬ -1±يت¾´يخَ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmOutputNumber;/*´¥·¢µؤتن³ِ¶ث؟ع£¬ؤؤز»خ»خھ1±يت¾¶شس¦ؤؤز»¸ِتن³ِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmRelateChannel;/*´¥·¢µؤآ¼دٌح¨µہ£¬ؤؤز»خ»خھ1±يت¾¶شس¦ؤؤز»آ·آ¼دٌ, dwAlarmRelateChannel[0]¶شس¦µع1¸ِح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwChannel;/*dwAlarmTypeخھ2»ٍ3,6ت±£¬±يت¾ؤؤ¸ِح¨µہ£¬dwChannel[0]خ»¶شس¦µع1¸ِح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwDiskNumber;/*dwAlarmTypeخھ1,4,5ت±,±يت¾ؤؤ¸ِس²إج, dwDiskNumber[0]خ»¶شس¦µع1¸ِس²إج*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                dwAlarmOutputNumber = new int [ MAX_ALARMOUT ];
                dwAlarmRelateChannel = new int [ MAX_CHANNUM ];
                dwChannel = new int [ MAX_CHANNUM ];
                dwDiskNumber = new int [ MAX_DISKNUM ];
                for ( int i = 0; i < MAX_ALARMOUT; i++ )
                {
                    dwAlarmOutputNumber [ i ] = 0;
                }
                for ( int i = 0; i < MAX_CHANNUM; i++ )
                {
                    dwAlarmRelateChannel [ i ] = 0;
                    dwChannel [ i ] = 0;
                }
                for ( int i = 0; i < MAX_DISKNUM; i++ )
                {
                    dwDiskNumber [ i ] = 0;
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for ( int i = 0; i < MAX_ALARMOUT; i++ )
                {
                    dwAlarmOutputNumber [ i ] = 0;
                }
                for ( int i = 0; i < MAX_CHANNUM; i++ )
                {
                    dwAlarmRelateChannel [ i ] = 0;
                    dwChannel [ i ] = 0;
                }
                for ( int i = 0; i < MAX_DISKNUM; i++ )
                {
                    dwDiskNumber [ i ] = 0;
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////
        //IPC½سبë²خت‎إنضأ
        /* IPةè±¸½ل¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO
        {
            public uint dwEnable;/* ¸أIPةè±¸تا·ٌئôسأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /* أـآë */
            public NET_DVR_IPADDR struIP;/* IPµطض· */
            public ushort wDVRPort;/* ¶ث؟ع؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±£ءô */

            public void Init()
            {
                sUserName = new byte [ NAME_LEN ];
                sPassword = new byte [ PASSWD_LEN ];
                byRes = new byte [ 34 ];
            }
        }

        //ipc½سبëةè±¸ذإد¢ہ©ص¹£¬ض§³ضipةè±¸µؤسٍأûجي¼س
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO_V31
        {
            public byte byEnable;//¸أIPةè±¸تا·ٌسذذ§
            public byte byProType;
            public byte byEnableQuickAdd;
            public byte byRes1;//±£ءô×ض¶خ£¬ضأ0
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sUserName;//سأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPassword;//أـآë
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string byDomain;//ةè±¸سٍأû
            public NET_DVR_IPADDR struIP;//IPµطض·
            public ushort wDVRPort;// ¶ث؟ع؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£ءô×ض¶خ£¬ضأ0
        }

        /* IPح¨µہئ¥إن²خت‎ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO
        {
            public byte byEnable;/* ¸أح¨µہتا·ٌشعدك */
            public byte byIPID;/* IPةè±¸ID ب،ضµ1- MAX_IP_DEVICE */
            public byte byChannel;/* ح¨µہ؛إ */
            public byte byIPIDHigh; // IPةè±¸IDµؤ¸ك8خ»
            public byte byTransProtocol;//´«تنذ­زéہàذح0-TCP/auto(¾كجهسذةè±¸¾ِ¶¨)£¬1-UDP 2-¶à²¥ 3-½ِTCP 4-auto
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô,ضأ0
            public void Init()
            {
                byRes = new byte [ 31 ];
            }
        }

        /* IP½سبëإنضأ½ل¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG
        {
            public uint dwSize;/* ½ل¹¹´َذ، */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo;/* IPةè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ؤ£ؤâح¨µہتا·ٌئôسأ£¬´سµحµ½¸ك±يت¾1-32ح¨µہ£¬0±يت¾خقذ§ 1سذذ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPح¨µہ */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO [ MAX_IP_DEVICE ];

                for ( i = 0; i < MAX_IP_DEVICE; i++ )
                {
                    struIPDevInfo [ i ].Init();
                }
                byAnalogChanEnable = new byte [ MAX_ANALOG_CHANNUM ];
                struIPChanInfo = new NET_DVR_IPCHANINFO [ MAX_IP_CHANNEL ];
                for ( i = 0; i < MAX_IP_CHANNEL; i++ )
                {
                    struIPChanInfo [ i ].Init();
                }
            }
        }

        /* ہ©ص¹IP½سبëإنضأ½ل¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V31
        {
            public uint dwSize;/* ½ل¹¹´َذ، */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPةè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ؤ£ؤâح¨µہتا·ٌئôسأ£¬´سµحµ½¸ك±يت¾1-32ح¨µہ£¬0±يت¾خقذ§ 1سذذ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPح¨µہ */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO_V31 [ MAX_IP_DEVICE ];
                byAnalogChanEnable = new byte [ MAX_ANALOG_CHANNUM ];
                struIPChanInfo = new NET_DVR_IPCHANINFO [ MAX_IP_CHANNEL ];
                for ( i = 0; i < MAX_IP_CHANNEL; i++ )
                {
                    struIPChanInfo [ i ].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSERVER_STREAM
        {
            public byte  byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_IPADDR struIPServer;
            public ushort  wPort;
            public ushort  wDvrNameLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRName;
            public ushort  wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public ushort[]  byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byPassWord;
            public byte  byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes2;
            public void Init()
            {
                byRes = new byte [ 3 ];
                byDVRName = new byte [ NAME_LEN ];
                byRes1 = new ushort [ 2 ];
                byDVRSerialNumber = new byte [ SERIALNO_LEN ];
                byUserName = new byte [ NAME_LEN ];
                byPassWord = new byte [ PASSWD_LEN ];
                byRes2 = new byte [ 11 ];
            }
        }

        /*ء÷أ½جه·‏خٌئ÷»ù±¾إنضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG
        {
            public byte byValid;/*تا·ٌئôسأء÷أ½جه·‏خٌئ÷ب،ء÷,0±يت¾خقذ§£¬·ا0±يت¾سذذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;
            public ushort wDevPort;/*ء÷أ½جه·‏خٌئ÷¶ث؟ع*/
            public byte byTransmitType;/*´«تنذ­زéہàذح 0-TCP£¬1-UDP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        //ةè±¸ح¨µہذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO
        {
            public NET_DVR_IPADDR struIP;		    //DVR IPµطض·
            public ushort wDVRPort;			 	//¶ث؟ع؛إ
            public byte byChannel;				//ح¨µہ؛إ
            public byte byTransProtocol;		//´«تنذ­زéہàذح0-TCP£¬1-UDP
            public byte byTransMode;			//´«تنآëء÷ؤ£ت½ 0£­ض÷آëء÷ 1£­×سآëء÷
            public byte byFactoryType;			/*ا°¶ثةè±¸³§¼زہàذح,ح¨¹‎½س؟ع»ٌب،*/
            public byte byDeviceType; //ةè±¸ہàذح(تسئµ×غ؛دئ½ج¨ضاؤـ°هت¹سأ)£¬1-½âآëئ÷£¨´ثت±¸ù¾فتسئµ×غ؛دئ½ج¨ؤـء¦¼¯ضذbyVcaSupportChanMode×ض¶خہ´¾ِ¶¨تات¹سأ½âآëح¨µہ»¹تادشت¾ح¨µہ£©£¬2-±àآëئ÷
            public byte byDispChan;//دشت¾ح¨µہ؛إ,ضاؤـإنضأت¹سأ
            public byte bySubDispChan;//دشت¾ح¨µہ×سح¨µہ؛إ£¬ضاؤـإنضأت±ت¹سأ
            public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w´َئء؟طضئئ÷ت¹سأ£¬´َئء؟طضئئ÷»ل¸ù¾ف¸أ²خت‎·ضإن½âآë×تش´
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;	//ةè±¸سٍأû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//¼à؟طض÷»ْµاآ½صت؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//¼à؟طض÷»ْأـآë
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNS_STREAM_CFG
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struStreamServer;
            public ushort wStreamServerPort;
            public byte byStreamServerTransmitType;
            public byte byRes2;
            public NET_DVR_IPADDR struIPServer;
            public ushort wIPServerPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;
            public ushort wDVRNameLen;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassWord;
            public ushort wDVRPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
            public byte byChannel;
            public byte byTransProtocol;
            public byte byTransMode;
            public byte byFactoryType;
            public void Init()
            {
                byRes1 = new byte [ 3 ];
                byRes3 = new byte [ 2 ];
                sDVRName = new byte [ NAME_LEN ];
                sDVRSerialNumber = new byte [ SERIALNO_LEN ];
                sUserName = new byte [ NAME_LEN ];
                sPassWord = new byte [ PASSWD_LEN ];
                byRes4 = new byte [ 2 ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_URL
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] strURL;
            public byte   byTransPortocol;
            public ushort wIPID;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                strURL = new byte [ 240 ];
                byRes = new byte [ 7 ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HKDDNS_STREAM
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byDDNSDomain;
            public ushort wPort;
            public ushort wAliasLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlias;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public void Init()
            {
                byRes = new byte [ 3 ];
                byDDNSDomain = new byte [ 64 ];
                byAlias = new byte [ NAME_LEN ];
                byRes1 = new byte [ 2 ];
                byDVRSerialNumber = new byte [ SERIALNO_LEN ];
                byUserName = new byte [ NAME_LEN ];
                byPassWord = new byte [ PASSWD_LEN ];
                byRes2 = new byte [ 11 ];
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO_V40
        {
            public byte byEnable;				/* ¸أح¨µہتا·ٌشعدك */
            public byte byRes1;
            public ushort wIPID;                  //IPةè±¸ID
            public uint dwChannel;				//ح¨µہ؛إ
            public byte byTransProtocol;		//´«تنذ­زéہàذح0-TCP£¬1-UDP
            public byte byTransMode;			//´«تنآëء÷ؤ£ت½ 0£­ض÷آëء÷ 1£­×سآëء÷
            public byte byFactoryType;			/*ا°¶ثةè±¸³§¼زہàذح,ح¨¹‎½س؟ع»ٌب،*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 241, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_GET_STREAM_UNION
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 492, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnion;
            public void Init()
            {
                byUnion = new byte [ 492 ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MODE
        {
            public byte byGetStreamType;/*ب،ء÷·½ت½£؛0- ض±½س´سةè±¸ب،ء÷£»1- ´سء÷أ½جهب،ء÷£»2- ح¨¹‎IPServer»ٌµأIPµطض·؛َب،ء÷£»
                                          * 3- ح¨¹‎IPServerصزµ½ةè±¸£¬شظح¨¹‎ء÷أ½جهب،ةè±¸µؤء÷£» 4- ح¨¹‎ء÷أ½جهسةURLب¥ب،ء÷£»
                                          * 5- ح¨¹‎hiDDNSسٍأûء¬½سةè±¸ب»؛َ´سةè±¸ب،ء÷ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_GET_STREAM_UNION uGetStream;
            public void Init()
            {
                byGetStreamType = 0;
                byRes = new byte [ 3 ];
                //uGetStream.Init();
            }
        }

        /* V40ہ©ص¹IP½سبëإنضأ½ل¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V40
        {
            public uint dwSize;/* ½ل¹¹´َذ، */
            public uint dwGroupNum;
            public uint dwAChanNum;
            public uint dwDChanNum;
            public uint dwStartDChan;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ؤ£ؤâح¨µہتا·ٌئôسأ£¬´سµحµ½¸ك±يت¾1-32ح¨µہ£¬0±يت¾خقذ§ 1سذذ§ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPةè±¸ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_STREAM_MODE[] struStreamMode;/* IPح¨µہ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; /* ؤ£ؤâح¨µہتا·ٌئôسأ£¬´سµحµ½¸ك±يت¾1-32ح¨µہ£¬0±يت¾خقذ§ 1سذذ§ */
        }

        //خھCVRہ©ص¹µؤ±¨¾¯ہàذح
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_DEV
        {
            public uint dwAlarmType;  //0-±àآëئ÷(ح¨µہ)ذإ؛إء؟±¨¾¯£»1-ث½سذ¾ي¶‏ثً»µ£»2- NVR·‏خٌحث³ِ£»
                                      //3-±àآëئ÷×´ج¬زى³££»4-دµح³ت±ضسزى³££»5-آ¼دٌ¾يت£سàبفء؟¹‎µح£»
                                      //6-±àآëئ÷(ح¨µہ)زئ¶¯صى²â±¨¾¯£»7-±àآëئ÷(ح¨µہ)صعµ²±¨¾¯،£
            public NET_DVR_TIME   struTime;     //±¨¾¯ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£ءô
            public uint dwNumber;     //ت‎ؤ؟
            public IntPtr pNO;  //dwNumber¸ِWORD; أ؟¸ِWORD±يت¾ز»¸ِح¨µہ؛إ£¬»ٍصك´إإج؛إ, خقذ§ت±خھ0
        }

        /* ±¨¾¯تن³ِ²خت‎ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO
        {
            public byte byIPID;/* IPةè±¸IDب،ضµ1- MAX_IP_DEVICE */
            public byte byAlarmOut;/* ±¨¾¯تن³ِ؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±£ءô */

            public void Init()
            {
                byRes = new byte [ 18 ];
            }
        }

        /* IP±¨¾¯تن³ِإنضأ½ل¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG
        {
            public uint dwSize; /* ½ل¹¹´َذ، */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±¨¾¯تن³ِ */

            public void Init()
            {
                struIPAlarmOutInfo = new NET_DVR_IPALARMOUTINFO [ MAX_IP_ALARMOUT ];
                for ( int i = 0; i < MAX_IP_ALARMOUT; i++ )
                {
                    struIPAlarmOutInfo [ i ].Init();
                }
            }
        }
        /* IP±¨¾¯تن³ِ²خت‎ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO_V40
        {
            public uint dwIPID;					/* IPةè±¸ID */
            public uint dwAlarmOut;				/* IPةè±¸ID¶شس¦µؤ±¨¾¯تن³ِ؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±£ءô */
        }

        /*IP±¨¾¯تن³ِ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG_V40
        {
            public uint dwSize;  //½ل¹¹جه³¤¶ب
            public uint dwCurIPAlarmOutNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO_V40[] struIPAlarmOutInfo;/*IP±¨¾¯تن³ِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /* ±¨¾¯تنبë²خت‎ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO
        {
            public byte byIPID;/* IPةè±¸IDب،ضµ1- MAX_IP_DEVICE */
            public byte byAlarmIn;/* ±¨¾¯تنبë؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±£ءô */
        }

        /* IP±¨¾¯تنبëإنضأ½ل¹¹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG
        {
            public uint dwSize;/* ½ل¹¹´َذ، */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP±¨¾¯تنبë */
        }
        /* IP±¨¾¯تنبë²خت‎ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO_V40
        {
            public uint dwIPID;					/* IPةè±¸ID */
            public uint dwAlarmIn;				/* IPةè±¸ID¶شس¦µؤ±¨¾¯تنبë؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±£ءô */
        }
        /*IP±¨¾¯تنبë×تش´*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG_V40
        {
            public uint dwSize;  //½ل¹¹جه³¤¶ب
            public uint dwCurIPAlarmInNum;  //µ±ا°±¨¾¯تنبë؟عت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN_V40, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_IPALARMININFO_V40[] struIPAlarmInInfo;/* IP±¨¾¯تنبë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ipc alarm info
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo; /* IPةè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ؤ£ؤâح¨µہتا·ٌئôسأ£¬0-خ´ئôسأ 1-ئôسأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPح¨µہ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP±¨¾¯تنبë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±¨¾¯تن³ِ */
        }

        //ipcإنضأ¸ؤ±ن±¨¾¯ذإد¢ہ©ص¹ 9000_1.1
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V31
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPةè±¸ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;/* ؤ£ؤâح¨µہتا·ٌئôسأ£¬0-خ´ئôسأ 1-ئôسأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPح¨µہ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo; /* IP±¨¾¯تنبë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±¨¾¯تن³ِ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo;           // IPةè±¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;           /* ؤ£ؤâح¨µہتا·ٌئôسأ£¬0-خ´ئôسأ 1-ئôسأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;	        /* IPح¨µہ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;    /* IP±¨¾¯تنبë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo; /* IP±¨¾¯تن³ِ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                          // ±£ءô×ض½ع
        }

        public enum HD_STAT
        {
            HD_STAT_OK = 0,/* ص‎³£ */
            HD_STAT_UNFORMATTED = 1,/* خ´¸ٌت½»¯ */
            HD_STAT_ERROR = 2,/* ´يخَ */
            HD_STAT_SMART_FAILED = 3,/* SMART×´ج¬ */
            HD_STAT_MISMATCH = 4,/* ²»ئ¥إن */
            HD_STAT_IDLE = 5, /* ذفأك*/
            NET_HD_STAT_OFFLINE = 6,/*حّآçإج´¦سعخ´ء¬½س×´ج¬ */
            HD_RIADVD_EXPAND = 7,    /* ذéؤâ´إإج؟ةہ©بف */
            HD_STAT_REPARING = 10,   /* س²إجص‎شعذق¸´(9000 2.0) */
            HD_STAT_FORMATING = 11,   /* س²إجص‎شع¸ٌت½»¯(9000 2.0) */
        }

        //±¾µطس²إجذإد¢إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HD
        {
            public uint dwHDNo;/*س²إج؛إ, ب،ضµ0~MAX_DISKNUM_V30-1*/
            public uint dwCapacity;/*س²إجبفء؟(²»؟ةةèضأ)*/
            public uint dwFreeSpace;/*س²إجت£سà؟ص¼ن(²»؟ةةèضأ)*/
            public uint dwHdStatus;/*س²إج×´ج¬(²»؟ةةèضأ) HD_STAT*/
            public byte byHDAttr;/*0-ؤ¬بد, 1-بكسà; 2-ض»¶ء*/
            public byte byHDType;/*0-±¾µطس²إج,1-ESATAس²إج,2-NASس²إج*/
            public byte byDiskDriver;   // ضµ ´ْ±يئنASCII×ض·û 
            public byte byRes1;
            public uint dwHdGroup; /*تôسعؤؤ¸ِإج×é 1-MAX_HD_GROUP*/
            public byte byRecycling;   // تا·ٌر­»·ہûسأ 0£؛²»ر­»·ہûسأ£¬1£؛ر­»·ہûسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwStorageType;    //°´خ»±يت¾ 0-²»ض§³ض ·ا0-ض§³ض
                                          // dwStorageType & 0x1 ±يت¾تا·ٌتائصح¨آ¼دٌ×¨سأ´و´¢إج     
                                          // dwStorageType & 0x2  ±يت¾تا·ٌتا³éض،آ¼دٌ×¨سأ´و´¢إج
                                          // dwStorageType & 0x4 ±يت¾تا·ٌتاح¼ئ¬آ¼دٌ×¨سأ´و´¢إج

            public uint dwPictureCapacity; //س²إجح¼ئ¬بفء؟(²»؟ةةèضأ)£¬µ¥خ»:MB
            public uint dwFreePictureSpace; //ت£سàح¼ئ¬؟ص¼ن(²»؟ةةèضأ)£¬µ¥خ»:MB
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDCFG
        {
            public uint dwSize;
            public uint dwHDCount;/*س²إجت‎(²»؟ةةèضأ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HD[] struHDInfo;//س²إجدà¹ط²ظ×÷¶¼ذèزھضطئô²إؤـةْذ§£»
        }

        //±¾µطإج×éذإد¢إنضأہ©ص¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP_V40
        {
            public uint dwHDGroupNo;       /*إج×é؛إ(²»؟ةةèضأ) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;  //´¥·¢µؤآ¼دٌح¨µہ£¬°´ضµ±يت¾£¬سِµ½0xffffffffت±؛َذّتسخھخقذ§    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±£ءô */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG_V40
        {
            public uint dwSize;                //½ل¹¹جه´َذ،
            public uint dwMaxHDGroupNum; 		  //ةè±¸ض§³ضµؤ×î´َإج×éت‎-ض»¶ء
            public uint dwCurHDGroupNum;       /*µ±ا°إنضأµؤإج×éت‎*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP_V40[] struHDGroupAttr; //س²إجدà¹ط²ظ×÷¶¼ذèزھضطئô²إؤـةْذ§£»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        //±¾µطإج×éذإد¢إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP
        {
            public uint dwHDGroupNo;/*إج×é؛إ(²»؟ةةèضأ) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDGroupChans;/*إج×é¶شس¦µؤآ¼دٌح¨µہ, 0-±يت¾¸أح¨µہ²»آ¼دَµ½¸أإج×é£¬1-±يت¾آ¼دَµ½¸أإج×é*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG
        {
            public uint dwSize;
            public uint dwHDGroupCount;/*إج×é×ـت‎(²»؟ةةèضأ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;//س²إجدà¹ط²ظ×÷¶¼ذèزھضطئô²إؤـةْذ§
        }

        //إنضأثُ·إ²خت‎µؤ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCALECFG
        {
            public uint dwSize;
            public uint dwMajorScale;/* ض÷دشت¾ 0-²»ثُ·إ£¬1-ثُ·إ*/
            public uint dwMinorScale;/* ¸¨دشت¾ 0-²»ثُ·إ£¬1-ثُ·إ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //DVR±¨¾¯تن³ِ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* أû³ئ */
            public uint dwAlarmOutDelay;/* تن³ِ±£³ضت±¼ن(-1خھخقدق£¬تض¶¯¹ط±ص) */
            //0-5أë,1-10أë,2-30أë,3-1·ضضس,4-2·ضضس,5-5·ضضس,6-10·ضضس,7-تض¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* ±¨¾¯تن³ِ¼¤»îت±¼ن¶خ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR±¨¾¯تن³ِ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* أû³ئ */
            public uint dwAlarmOutDelay;/* تن³ِ±£³ضت±¼ن(-1خھخقدق£¬تض¶¯¹ط±ص) */
            //0-5أë,1-10أë,2-30أë,3-1·ضضس,4-2·ضضس,5-5·ضضس,6-10·ضضس,7-تض¶¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* ±¨¾¯تن³ِ¼¤»îت±¼ن¶خ */
        }

        //DVR±¾µطش¤ہہ²خت‎(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG_V30
        {
            public uint dwSize;
            public byte byPreviewNumber;//ش¤ہہت‎ؤ؟,0-1»­أو,1-4»­أو,2-9»­أو,3-16»­أو,0xff:×î´َ»­أو
            public byte byEnableAudio;//تا·ٌةùزôش¤ہہ,0-²»ش¤ہہ,1-ش¤ہہ
            public ushort wSwitchTime;//اذ»»ت±¼ن,0-²»اذ»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PREVIEW_MODE * MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//اذ»»ث³ذٍ,بç¹ûlSwitchSeq[i]خھ 0xff±يت¾²»سأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR±¾µطش¤ہہ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG
        {
            public uint dwSize;
            public byte byPreviewNumber;//ش¤ہہت‎ؤ؟,0-1»­أو,1-4»­أو,2-9»­أو,3-16»­أو,0xff:×î´َ»­أو
            public byte byEnableAudio;//تا·ٌةùزôش¤ہہ,0-²»ش¤ہہ,1-ش¤ہہ
            public ushort wSwitchTime;//اذ»»ت±¼ن,0-²»اذ»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//اذ»»ث³ذٍ,بç¹ûlSwitchSeq[i]خھ 0xff±يت¾²»سأ
        }

        //DVRتسئµتن³ِ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGAPARA
        {
            public ushort wResolution;/* ·ض±وآت */
            public ushort wFreq;/* ث¢ذآئµآت */
            public uint dwBrightness;/* ءء¶ب */
        }

        //MATRIXتن³ِ²خت‎½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOrder;/* ش¤ہہث³ذٍ, 0xff±يت¾دàس¦µؤ´°؟ع²»ش¤ہہ */
            public ushort wSwitchTime;// ش¤ہہاذ»»ت±¼ن 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA
        {
            public ushort wDisplayLogo;/* دشت¾تسئµح¨µہ؛إ */
            public ushort wDisplayOsd;/* دشت¾ت±¼ن */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOOUT
        {
            public byte byVideoFormat;/* تن³ِضئت½,0-PAL,1-NTSC */
            public byte byMenuAlphaValue;/* ²ثµ¥سë±³¾°ح¼دَ¶ش±ب¶ب */
            public ushort wScreenSaveTime;/* ئءؤ»±£»¤ت±¼ن 0-´س²»,1-1·ضضس,2-2·ضضس,3-5·ضضس,4-10·ضضس,5-20·ضضس,6-30·ضضس */
            public ushort wVOffset;/* تسئµتن³ِئ«زئ */
            public ushort wBrightness;/* تسئµتن³ِءء¶ب */
            public byte byStartMode;/* ئô¶¯؛َتسئµتن³ِؤ£ت½(0:²ثµ¥,1:ش¤ہہ)*/
            public byte byEnableScaler;/* تا·ٌئô¶¯ثُ·إ (0-²»ئô¶¯, 1-ئô¶¯)*/
        }

        //DVRتسئµتن³ِ(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;/* VGA²خت‎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MATRIXOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIXPARA_V30[] struMatrixPara;/* MATRIX²خت‎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVRتسئµتن³ِ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;	/* VGA²خت‎ */
            public NET_DVR_MATRIXPARA struMatrixPara;/* MATRIX²خت‎ */
        }

        //µ¥سأ»§²خت‎(×س½ل¹¹)(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;			/* سأ»§أûض»ؤـسأ16×ض½ع */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;			/* أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight; /* ±¾µطب¨دق */
                                        /*ت‎×é0: ±¾µط؟طضئشئج¨*/
                                        /*ت‎×é1: ±¾µطتض¶¯آ¼دَ*/
                                        /*ت‎×é2: ±¾µط»ط·إ*/
                                        /*ت‎×é3: ±¾µطةèضأ²خت‎*/
                                        /*ت‎×é4: ±¾µط²é؟´×´ج¬،¢بصض¾*/
                                        /*ت‎×é5: ±¾µط¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
                                        /*ت‎×é6: ±¾µط²é؟´²خت‎ */
                                        /*ت‎×é7: ±¾µط¹ـہيؤ£ؤâ؛حIP camera */
                                        /*ت‎×é8: ±¾µط±¸·ف */
                                        /*ت‎×é9: ±¾µط¹ط»ْ/ضطئô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* ش¶³جب¨دق */
                                        /*ت‎×é0: ش¶³ج؟طضئشئج¨*/
                                        /*ت‎×é1: ش¶³جتض¶¯آ¼دَ*/
                                        /*ت‎×é2: ش¶³ج»ط·إ */
                                        /*ت‎×é3: ش¶³جةèضأ²خت‎*/
                                        /*ت‎×é4: ش¶³ج²é؟´×´ج¬،¢بصض¾*/
                                        /*ت‎×é5: ش¶³ج¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
                                        /*ت‎×é6: ش¶³ج·¢ئًسïزô¶ش½²*/
                                        /*ت‎×é7: ش¶³جش¤ہہ*/
                                        /*ت‎×é8: ش¶³جاëاَ±¨¾¯ةد´«،¢±¨¾¯تن³ِ*/
                                        /*ت‎×é9: ش¶³ج؟طضئ£¬±¾µطتن³ِ*/
                                        /*ت‎×é10: ش¶³ج؟طضئ´®؟ع*/
                                        /*ت‎×é11: ش¶³ج²é؟´²خت‎ */
                                        /*ت‎×é12: ش¶³ج¹ـہيؤ£ؤâ؛حIP camera */
                                        /*ت‎×é13: ش¶³ج¹ط»ْ/ضطئô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPreviewRight;			/* ش¶³ج؟ةزشش¤ہہµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRecordRight;			/* ±¾µط؟ةزشآ¼دٌµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetRecordRight;			/* ش¶³ج؟ةزشآ¼دٌµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPlaybackRight;			/* ±¾µط؟ةزش»ط·إµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPlaybackRight;			/* ش¶³ج؟ةزش»ط·إµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPTZRight;				/* ±¾µط؟ةزشPTZµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPTZRight;				/* ش¶³ج؟ةزشPTZµؤح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalBackupRight;			/* ±¾µط±¸·فب¨دقح¨µہ£¬´سا°حù؛َث³ذٍإإءذ£¬سِµ½0xffffffff؛َذّ¾ùخھخقذ§*/
            public NET_DVR_IPADDR   struUserIP;				/* سأ»§IPµطض·(خھ0ت±±يت¾شتذيبخ؛خµطض·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;	/* خïہيµطض· */
            public byte byPriority;             /* سإدب¼¶£¬0xff-خق£¬0--µح£¬1--ضذ£¬2--¸ك */
                                                /* خق،­،­±يت¾²»ض§³ضسإدب¼¶µؤةèضأ
                                                µح،­،­ؤ¬بدب¨دق:°üہ¨±¾µط؛حش¶³ج»ط·إ,±¾µط؛حش¶³ج²é؟´بصض¾؛ح×´ج¬,±¾µط؛حش¶³ج¹ط»ْ/ضطئô
                                                ضذ،­،­°üہ¨±¾µط؛حش¶³ج؟طضئشئج¨,±¾µط؛حش¶³جتض¶¯آ¼دٌ,±¾µط؛حش¶³ج»ط·إ,سïزô¶ش½²؛حش¶³جش¤ہہ،¢±¾µط±¸·ف,±¾µط/ش¶³ج¹ط»ْ/ضطئô
                                                ¸ك،­،­¹ـہيش± */
            public byte byAlarmOnRight;         // ±¨¾¯تنبë؟ع²¼·ہب¨دق 1-سذب¨دق£¬0-خقب¨دق
            public byte byAlarmOffRight;         // ±¨¾¯تنبë؟ع³··ہب¨دق 1-سذب¨دق£¬0-خقب¨دق
            public byte byBypassRight;           // ±¨¾¯تنبë؟عإشآ·ب¨دق 1-سذب¨دق£¬0-خقب¨دق 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¥سأ»§²خت‎(×س½ل¹¹)(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;/* ±¾µطب¨دق */
            /*ت‎×é0: ±¾µط؟طضئشئج¨*/
            /*ت‎×é1: ±¾µطتض¶¯آ¼دَ*/
            /*ت‎×é2: ±¾µط»ط·إ*/
            /*ت‎×é3: ±¾µطةèضأ²خت‎*/
            /*ت‎×é4: ±¾µط²é؟´×´ج¬،¢بصض¾*/
            /*ت‎×é5: ±¾µط¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
            /*ت‎×é6: ±¾µط²é؟´²خت‎ */
            /*ت‎×é7: ±¾µط¹ـہيؤ£ؤâ؛حIP camera */
            /*ت‎×é8: ±¾µط±¸·ف */
            /*ت‎×é9: ±¾µط¹ط»ْ/ضطئô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* ش¶³جب¨دق */
            /*ت‎×é0: ش¶³ج؟طضئشئج¨*/
            /*ت‎×é1: ش¶³جتض¶¯آ¼دَ*/
            /*ت‎×é2: ش¶³ج»ط·إ */
            /*ت‎×é3: ش¶³جةèضأ²خت‎*/
            /*ت‎×é4: ش¶³ج²é؟´×´ج¬،¢بصض¾*/
            /*ت‎×é5: ش¶³ج¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
            /*ت‎×é6: ش¶³ج·¢ئًسïزô¶ش½²*/
            /*ت‎×é7: ش¶³جش¤ہہ*/
            /*ت‎×é8: ش¶³جاëاَ±¨¾¯ةد´«،¢±¨¾¯تن³ِ*/
            /*ت‎×é9: ش¶³ج؟طضئ£¬±¾µطتن³ِ*/
            /*ت‎×é10: ش¶³ج؟طضئ´®؟ع*/
            /*ت‎×é11: ش¶³ج²é؟´²خت‎ */
            /*ت‎×é12: ش¶³ج¹ـہيؤ£ؤâ؛حIP camera */
            /*ت‎×é13: ش¶³ج¹ط»ْ/ضطئô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPreviewRight;/* ش¶³ج؟ةزشش¤ہہµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPlaybackRight;/* ±¾µط؟ةزش»ط·إµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPlaybackRight;/* ش¶³ج؟ةزش»ط·إµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRecordRight;/* ±¾µط؟ةزشآ¼دٌµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetRecordRight;/* ش¶³ج؟ةزشآ¼دٌµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPTZRight;/* ±¾µط؟ةزشPTZµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPTZRight;/* ش¶³ج؟ةزشPTZµؤح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalBackupRight;/* ±¾µط±¸·فب¨دقح¨µہ 0-سذب¨دق£¬1-خقب¨دق*/
            public NET_DVR_IPADDR struUserIP;/* سأ»§IPµطض·(خھ0ت±±يت¾شتذيبخ؛خµطض·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* خïہيµطض· */
            public byte byPriority;/* سإدب¼¶£¬0xff-خق£¬0--µح£¬1--ضذ£¬2--¸ك */
            /*
            خق،­،­±يت¾²»ض§³ضسإدب¼¶µؤةèضأ
            µح،­،­ؤ¬بدب¨دق:°üہ¨±¾µط؛حش¶³ج»ط·إ,±¾µط؛حش¶³ج²é؟´بصض¾؛ح×´ج¬,±¾µط؛حش¶³ج¹ط»ْ/ضطئô
            ضذ،­،­°üہ¨±¾µط؛حش¶³ج؟طضئشئج¨,±¾µط؛حش¶³جتض¶¯آ¼دٌ,±¾µط؛حش¶³ج»ط·إ,سïزô¶ش½²؛حش¶³جش¤ہہ
                  ±¾µط±¸·ف,±¾µط/ش¶³ج¹ط»ْ/ضطئô
            ¸ك،­،­¹ـہيش±
            */
            public byte byAlarmOnRight;         // ±¨¾¯تنبë؟ع²¼·ہب¨دق
            public byte byAlarmOffRight;        // ±¨¾¯تنبë؟ع³··ہب¨دق
            public byte byBypassRight;          // ±¨¾¯تنبë؟عإشآ·ب¨دق
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¥سأ»§²خت‎(SDK_V15ہ©ص¹)(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* ب¨دق */
            /*ت‎×é0: ±¾µط؟طضئشئج¨*/
            /*ت‎×é1: ±¾µطتض¶¯آ¼دَ*/
            /*ت‎×é2: ±¾µط»ط·إ*/
            /*ت‎×é3: ±¾µطةèضأ²خت‎*/
            /*ت‎×é4: ±¾µط²é؟´×´ج¬،¢بصض¾*/
            /*ت‎×é5: ±¾µط¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
            public uint dwLocalPlaybackRight;/* ±¾µط؟ةزش»ط·إµؤح¨µہ bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* ب¨دق */
            /*ت‎×é0: ش¶³ج؟طضئشئج¨*/
            /*ت‎×é1: ش¶³جتض¶¯آ¼دَ*/
            /*ت‎×é2: ش¶³ج»ط·إ */
            /*ت‎×é3: ش¶³جةèضأ²خت‎*/
            /*ت‎×é4: ش¶³ج²é؟´×´ج¬،¢بصض¾*/
            /*ت‎×é5: ش¶³ج¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
            /*ت‎×é6: ش¶³ج·¢ئًسïزô¶ش½²*/
            /*ت‎×é7: ش¶³جش¤ہہ*/
            /*ت‎×é8: ش¶³جاëاَ±¨¾¯ةد´«،¢±¨¾¯تن³ِ*/
            /*ت‎×é9: ش¶³ج؟طضئ£¬±¾µطتن³ِ*/
            /*ت‎×é10: ش¶³ج؟طضئ´®؟ع*/
            public uint dwNetPreviewRight;/* ش¶³ج؟ةزشش¤ہہµؤح¨µہ bit0 -- channel 1*/
            public uint dwNetPlaybackRight;/* ش¶³ج؟ةزش»ط·إµؤح¨µہ bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* سأ»§IPµطض·(خھ0ت±±يت¾شتذيبخ؛خµطض·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* خïہيµطض· */
        }

        //µ¥سأ»§²خت‎(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* ب¨دق */
            /*ت‎×é0: ±¾µط؟طضئشئج¨*/
            /*ت‎×é1: ±¾µطتض¶¯آ¼دَ*/
            /*ت‎×é2: ±¾µط»ط·إ*/
            /*ت‎×é3: ±¾µطةèضأ²خت‎*/
            /*ت‎×é4: ±¾µط²é؟´×´ج¬،¢بصض¾*/
            /*ت‎×é5: ±¾µط¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* ب¨دق */
            /*ت‎×é0: ش¶³ج؟طضئشئج¨*/
            /*ت‎×é1: ش¶³جتض¶¯آ¼دَ*/
            /*ت‎×é2: ش¶³ج»ط·إ */
            /*ت‎×é3: ش¶³جةèضأ²خت‎*/
            /*ت‎×é4: ش¶³ج²é؟´×´ج¬،¢بصض¾*/
            /*ت‎×é5: ش¶³ج¸ك¼¶²ظ×÷(ة‎¼¶£¬¸ٌت½»¯£¬ضطئô£¬¹ط»ْ)*/
            /*ت‎×é6: ش¶³ج·¢ئًسïزô¶ش½²*/
            /*ت‎×é7: ش¶³جش¤ہہ*/
            /*ت‎×é8: ش¶³جاëاَ±¨¾¯ةد´«،¢±¨¾¯تن³ِ*/
            /*ت‎×é9: ش¶³ج؟طضئ£¬±¾µطتن³ِ*/
            /*ت‎×é10: ش¶³ج؟طضئ´®؟ع*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* سأ»§IPµطض·(خھ0ت±±يت¾شتذيبخ؛خµطض·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* خïہيµطض· */
        }

        //DVRسأ»§²خت‎(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V40
        {
            public uint dwSize;  //½ل¹¹جه´َذ،
            public uint dwMaxUserNum; //ةè±¸ض§³ضµؤ×î´َسأ»§ت‎-ض»¶ء
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V40[] struUser;  /* سأ»§²خت‎ */
        }

        //DVRسأ»§²خت‎(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V30[] struUser;
        }

        //DVRسأ»§²خت‎(SDK_V15ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_EX[] struUser;
        }

        //DVRسأ»§²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO[] struUser;
        }

        //زى³£²خت‎إنضأہ©ص¹½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V40
        {
            public uint dwSize ;             //½ل¹¹جه´َذ،
            public uint dwMaxGroupNum ;    //ةè±¸ض§³ضµؤ×î´َ×éت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V41[] struExceptionHandle;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£ءô
        }

        //DVRزى³£²خت‎(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
            /*ت‎×é0-إجآْ,1- س²إج³ِ´ي,2-حّدك¶د,3-¾ضسٍحّؤعIP µطض·³هح», 4-·ا·¨·أخت, 5-تنبë/تن³ِتسئµضئت½²»ئ¥إن, 6-تسئµذإ؛إزى³£, 7-آ¼دٌزى³£*/
        }

        //DVRزى³£²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
            /*ت‎×é0-إجآْ,1- س²إج³ِ´ي,2-حّدك¶د,3-¾ضسٍحّؤعIP µطض·³هح»,4-·ا·¨·أخت, 5-تنبë/تن³ِتسئµضئت½²»ئ¥إن, 6-تسئµذإ؛إزى³£*/
        }

        //ح¨µہ×´ج¬(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE_V30
        {
            public byte byRecordStatic;//ح¨µہتا·ٌشعآ¼دٌ,0-²»آ¼دٌ,1-آ¼دٌ
            public byte bySignalStatic;//ء¬½سµؤذإ؛إ×´ج¬,0-ص‎³£,1-ذإ؛إ¶ھت§
            public byte byHardwareStatic;//ح¨µہس²¼‏×´ج¬,0-ص‎³£,1-زى³£,ہ‎بçDSPثہµô
            public byte byRes1;//±£ءô
            public uint dwBitRate;//تµ¼تآëآت
            public uint dwLinkNum;//؟ح»§¶ثء¬½سµؤ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struClientIP;//؟ح»§¶ثµؤIPµطض·
            public uint dwIPLinkNum;//بç¹û¸أح¨µہخھIP½سبë£¬ؤاأ´±يت¾IP½سبëµ±ا°µؤء¬½ست‎
            public byte byExceedMaxLink;		// تا·ٌ³¬³ِءثµ¥آ·6آ·ء¬½ست‎ 0 - خ´³¬³ِ, 1-³¬³ِ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwChannelNo;    //µ±ا°µؤح¨µہ؛إ£¬0xffffffff±يت¾خقذ§

            public void Init()
            {
                struClientIP = new NET_DVR_IPADDR [ MAX_LINK ];

                for ( int i = 0; i < MAX_LINK; i++ )
                {
                    struClientIP [ i ].Init();
                }
                byRes = new byte [ 12 ];
            }
        }

        //ح¨µہ×´ج¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE
        {
            public byte byRecordStatic;//ح¨µہتا·ٌشعآ¼دٌ,0-²»آ¼دٌ,1-آ¼دٌ
            public byte bySignalStatic;//ء¬½سµؤذإ؛إ×´ج¬,0-ص‎³£,1-ذإ؛إ¶ھت§
            public byte byHardwareStatic;//ح¨µہس²¼‏×´ج¬,0-ص‎³£,1-زى³£,ہ‎بçDSPثہµô
            public byte reservedData;//±£ءô
            public uint dwBitRate;//تµ¼تآëآت
            public uint dwLinkNum;//؟ح»§¶ثء¬½سµؤ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.U4)]
            public uint[] dwClientIP;//؟ح»§¶ثµؤIPµطض·
        }

        //س²إج×´ج¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKSTATE
        {
            public uint dwVolume;//س²إجµؤبفء؟
            public uint dwFreeSpace;//س²إجµؤت£سà؟ص¼ن
            public uint dwHardDiskStatic;//س²إجµؤ×´ج¬,0-»î¶¯,1-ذفأك,2-²»ص‎³£
        }

        //ةè±¸¹¤×÷×´ج¬ہ©ص¹½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V40
        {
            public uint dwSize ;            //½ل¹¹جه´َذ،
            public uint dwDeviceStatic; 	 //ةè±¸µؤ×´ج¬,0-ص‎³£,1-CPUص¼سأآتج«¸ك,³¬¹‎85%,2-س²¼‏´يخَ,ہ‎بç´®؟عثہµô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[]  struHardDiskStatic;   //س²إج×´ج¬,ز»´خ×î¶àض»ؤـ»ٌب،33¸ِس²إجذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//ح¨µہµؤ×´ج¬£¬´سا°حù؛َث³ذٍإإءذ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmInStatic; //سذ±¨¾¯µؤ±¨¾¯تنبë؟ع£¬°´ضµ±يت¾£¬°´دآ±êضµث³ذٍإإءذ£¬ضµخھ0xffffffffت±µ±ا°¼°؛َذّضµخقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmOutStatic; //سذ±¨¾¯تن³ِµؤ±¨¾¯تن³ِ؟ع£¬°´ضµ±يت¾£¬°´دآ±êضµث³ذٍإإءذ£¬ضµخھ0xffffffffت±µ±ا°¼°؛َذّضµخقذ§
            public uint dwLocalDisplay;			//±¾µطدشت¾×´ج¬,0-ص‎³£,1-²»ص‎³£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioInChanStatus;		//°´خ»±يت¾سïزôح¨µہµؤ×´ج¬ 0-خ´ت¹سأ£¬1-ت¹سأضذ£¬µع0خ»±يت¾µع1¸ِسïزôح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 				//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GETWORKSTATE_COND
        {
            public uint dwSize ;  //½ل¹¹جه³¤¶ب
            public byte byFindHardByCond; /*0-²éصزب«²؟´إإج(µ«ز»´خ×î¶àض»ؤـ²éصز33¸ِ)£¬´ثت±dwFindHardStatusNumخقذ§*/
            public byte byFindChanByCond ;  /*0-²éصزب«²؟ح¨µہ£¬´ثت±dwFindChanNumخقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindHardStatus ; /*زھ²éصزµؤس²إج؛إ£¬°´ضµ±يت¾£¬¸أضµ²ةسأث³ذٍإإءذ£¬ سِµ½0xffffffffشٍبدخھ؛َذّخقذ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindChanNo; /*زھ²éصزµؤح¨µہ؛إ£¬°´ضµ±يت¾£¬¸أضµ²ةسأث³ذٍإإءذ£¬ سِµ½0xffffffffشٍبدخھ؛َذّخقذ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        //DVR¹¤×÷×´ج¬(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V30
        {
            public uint dwDeviceStatic;//ةè±¸µؤ×´ج¬,0-ص‎³£,1-CPUص¼سأآتج«¸ك,³¬¹‎85%,2-س²¼‏´يخَ,ہ‎بç´®؟عثہµô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//ح¨µہµؤ×´ج¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//±¨¾¯¶ث؟عµؤ×´ج¬,0-أ»سذ±¨¾¯,1-سذ±¨¾¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//±¨¾¯تن³ِ¶ث؟عµؤ×´ج¬,0-أ»سذتن³ِ,1-سذ±¨¾¯تن³ِ
            public uint dwLocalDisplay;//±¾µطدشت¾×´ج¬,0-ص‎³£,1-²»ص‎³£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioChanStatus;//±يت¾سïزôح¨µہµؤ×´ج¬ 0-خ´ت¹سأ£¬1-ت¹سأضذ, 0xffخقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE [ MAX_DISKNUM_V30 ];
                struChanStatic = new NET_DVR_CHANNELSTATE_V30 [ MAX_CHANNUM_V30 ];
                for ( int i = 0; i < MAX_CHANNUM_V30; i++ )
                {
                    struChanStatic [ i ].Init();
                }
                byAlarmInStatic = new byte [ MAX_ALARMOUT_V30 ];
                byAlarmOutStatic = new byte [ MAX_ALARMOUT_V30 ];
                byAudioChanStatus = new byte [ MAX_AUDIO_V30 ];
                byRes = new byte [ 10 ];
            }
        }

        //DVR¹¤×÷×´ج¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE
        {
            public uint dwDeviceStatic;//ةè±¸µؤ×´ج¬,0-ص‎³£,1-CPUص¼سأآتج«¸ك,³¬¹‎85%,2-س²¼‏´يخَ,ہ‎بç´®؟عثہµô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE[] struChanStatic;//ح¨µہµؤ×´ج¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//±¨¾¯¶ث؟عµؤ×´ج¬,0-أ»سذ±¨¾¯,1-سذ±¨¾¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//±¨¾¯تن³ِ¶ث؟عµؤ×´ج¬,0-أ»سذتن³ِ,1-سذ±¨¾¯تن³ِ
            public uint dwLocalDisplay;//±¾µطدشت¾×´ج¬,0-ص‎³£,1-²»ص‎³£

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE [ MAX_DISKNUM ];
                struChanStatic = new NET_DVR_CHANNELSTATE [ MAX_CHANNUM ];
                byAlarmInStatic = new byte [ MAX_ALARMIN ];
                byAlarmOutStatic = new byte [ MAX_ALARMOUT ];
            }
        }

        //بصض¾ذإد¢(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG_V30
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//ض÷ہàذح 1-±¨¾¯; 2-زى³£; 3-²ظ×÷; 0xff-ب«²؟
            public uint dwMinorType;//´خہàذح 0-ب«²؟;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//²ظ×÷أو°هµؤسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//حّآç²ظ×÷µؤسأ»§أû
            public NET_DVR_IPADDR struRemoteHostAddr;//ش¶³جض÷»ْµطض·
            public uint dwParaType;//²خت‎ہàذح
            public uint dwChannel;//ح¨µہ؛إ
            public uint dwDiskNumber;//س²إج؛إ
            public uint dwAlarmInPort;//±¨¾¯تنبë¶ث؟ع
            public uint dwAlarmOutPort;//±¨¾¯تن³ِ¶ث؟ع
            public uint dwInfoLen;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;
        }

        //بصض¾ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//ض÷ہàذح 1-±¨¾¯; 2-زى³£; 3-²ظ×÷; 0xff-ب«²؟
            public uint dwMinorType;//´خہàذح 0-ب«²؟;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//²ظ×÷أو°هµؤسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//حّآç²ظ×÷µؤسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteHostAddr;//ش¶³جض÷»ْµطض·
            public uint dwParaType;//²خت‎ہàذح
            public uint dwChannel;//ح¨µہ؛إ
            public uint dwDiskNumber;//س²إج؛إ
            public uint dwAlarmInPort;//±¨¾¯تنبë¶ث؟ع
            public uint dwAlarmOutPort;//±¨¾¯تن³ِ¶ث؟ع
        }

        /************************¶¯»·±¨¾¯¹ـہيض÷»ْبصض¾²éصز begin************************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_SEARCH_LOG_PARAM
        {
            public ushort wMajorType;		// ض÷ہàذح
            public ushort wMinorType;		// ´خہàذح 
            public NET_DVR_TIME    struStartTime;	// ؟ھت¼ت±¼ن 
            public NET_DVR_TIME    struEndTime;	// ½لتّت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_LOG_RET
        {
            public NET_DVR_TIME struLogTime;                //  بصض¾ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;     // ²ظ×÷سأ»§
            public NET_DVR_IPADDR   struIPAddr;                 // ²ظ×÷IPµطض·
            public ushort wMajorType;                 // ض÷ہàذح 
            public ushort wMinorType;                 // ´خہàذح
            public ushort wParam;	                    // ²ظ×÷²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwInfoLen;	                // أèتِذإد¢³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;       // أèتِذإد¢
        }
        /*************************¶¯»·±¨¾¯¹ـہيض÷»ْبصض¾²éصز end***********************************************/

        //±¨¾¯تن³ِ×´ج¬(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;

            public void Init()
            {
                Output = new byte [ MAX_ALARMOUT_V30 ];
            }
        }

        //±¨¾¯تن³ِ×´ج¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;
        }

        //ATM×¨سأ
        /****************************ATM(begin)***************************/
        public const int NCR = 0;
        public const int DIEBOLD = 1;
        public const int WINCOR_NIXDORF = 2;
        public const int SIEMENS = 3;
        public const int OLIVETTI = 4;
        public const int FUJITSU = 5;
        public const int HITACHI = 6;
        public const int SMI = 7;
        public const int IBM = 8;
        public const int BULL = 9;
        public const int YiHua = 10;
        public const int LiDe = 11;
        public const int GDYT = 12;
        public const int Mini_Banl = 13;
        public const int GuangLi = 14;
        public const int DongXin = 15;
        public const int ChenTong = 16;
        public const int NanTian = 17;
        public const int XiaoXing = 18;
        public const int GZYY = 19;
        public const int QHTLT = 20;
        public const int DRS918 = 21;
        public const int KALATEL = 22;
        public const int NCR_2 = 23;
        public const int NXS = 24;

        //½»ز×ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_TRADEINFO
        {
            public ushort m_Year;
            public ushort m_Month;
            public ushort m_Day;
            public ushort m_Hour;
            public ushort m_Minute;
            public ushort m_Second;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] DeviceName;//ةè±¸أû³ئ
            public uint dwChannelNumer;//ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] CardNumber;//؟¨؛إ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string cTradeType;//½»ز×ہàذح
            public uint dwCash;//½»ز×½ً¶î
        }

        /*ض،¸ٌت½*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FRAMETYPECODE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] code;/* ´ْآë */
        }

        //ATM²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FRAMEFORMAT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sATMIP;/* ATM IPµطض· */
            public uint dwATMType;/* ATMہàذح */
            public uint dwInputMode;/* تنبë·½ت½	0-حّآçصىج‎ 1-حّآç½ستص 2-´®؟عض±½ستنبë 3-´®؟عATMأüءîتنبë*/
            public uint dwFrameSignBeginPos;/* ±¨خؤ±êض¾خ»µؤئًت¼خ»ضأ*/
            public uint dwFrameSignLength;/* ±¨خؤ±êض¾خ»µؤ³¤¶ب */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byFrameSignContent;/* ±¨خؤ±êض¾خ»µؤؤعبف */
            public uint dwCardLengthInfoBeginPos;/* ؟¨؛إ³¤¶بذإد¢µؤئًت¼خ»ضأ */
            public uint dwCardLengthInfoLength;/* ؟¨؛إ³¤¶بذإد¢µؤ³¤¶ب */
            public uint dwCardNumberInfoBeginPos;/* ؟¨؛إذإد¢µؤئًت¼خ»ضأ */
            public uint dwCardNumberInfoLength;/* ؟¨؛إذإد¢µؤ³¤¶ب */
            public uint dwBusinessTypeBeginPos;/* ½»ز×ہàذحµؤئًت¼خ»ضأ */
            public uint dwBusinessTypeLength;/* ½»ز×ہàذحµؤ³¤¶ب */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;/* ہàذح */
        }

        //SDK_V31 ATM
        /*¹‎آثةèضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILTER
        {
            public byte byEnable;/*0,²»ئôسأ;1,ئôسأ*/
            public byte byMode;/*0,ASCII;1,HEX*/
            public byte byFrameBeginPos;// ±¨خؤ±êض¾خ»µؤئًت¼خ»ضأ     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byFilterText;/*¹‎آث×ض·û´®*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*ئًت¼±êت¶ةèضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICAT
        {
            public byte byStartMode;/*0,ASCII;1,HEX*/
            public byte byEndMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_FRAMETYPECODE struStartCode;/*ئًت¼×ض·û*/
            public NET_DVR_FRAMETYPECODE struEndCode;/*½لتّ×ض·û*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        /*±¨خؤذإد¢خ»ضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LOCATION
        {
            public byte byOffsetMode;/*0,token;1,fix*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwOffsetPos;/*modeخھ1µؤت±؛ٍت¹سأ*/
            public NET_DVR_FRAMETYPECODE struTokenCode;/*±êض¾خ»*/
            public byte byMultiplierValue;/*±êض¾خ»¶àةظ´خ³ِدض*/
            public byte byEternOffset;/*¸½¼سµؤئ«زئء؟*/
            public byte byCodeMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*±¨خؤذإد¢³¤¶ب*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LENGTH
        {
            public byte byLengthMode;/*³¤¶بہàذح£¬0,variable;1,fix;2,get from package(ةèضأ؟¨؛إ³¤¶بت¹سأ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFixLength;/*modeخھ1µؤت±؛ٍت¹سأ*/
            public uint dwMaxLength;
            public uint dwMinLength;
            public byte byEndMode;/*ضص½ل·û0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_FRAMETYPECODE struEndCode;/*ضص½ل·û*/
            public uint dwLengthPos;/*lengthModeخھ2µؤت±؛ٍت¹سأ£¬؟¨؛إ³¤¶بشع±¨خؤضذµؤخ»ضأ*/
            public uint dwLengthLen;/*lengthModeخھ2µؤت±؛ٍت¹سأ£¬؟¨؛إ³¤¶بµؤ³¤¶ب*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*OSD µ‏¼سµؤخ»ضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSD_POSITION
        {
            public byte byPositionMode;/*µ‏¼س·ç¸ٌ£¬¹²2ضض£»0£¬²»دشت¾£»1£¬Custom*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPos_x;/*x×ّ±ê£¬positionmodeخھCustomت±ت¹سأ*/
            public uint dwPos_y;/*y×ّ±ê£¬positionmodeخھCustomت±ت¹سأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*بصئعدشت¾¸ٌت½*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DATE_FORMAT
        {
            public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
            public byte byItem2;/*Day,0.dd;*/
            public byte byItem3;/*Year,0.yy;1.yyyy*/
            public byte byDateForm;/*0~5£¬3¸ِitemµؤإإءذ×é؛د*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*·ض¸ô·û*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*دشت¾·ض¸ô·û*/
            public byte byDisplayForm;/*0~5£¬3¸ِitemµؤإإءذ×é؛د*///lili mode by lili
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        /*ت±¼ندشت¾¸ٌت½*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVRT_TIME_FORMAT
        {
            public byte byTimeForm;/*1. HH MM SS;0. HH MM*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*±¨خؤ·ض¸ô·û£¬شفت±أ»سأ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*دشت¾·ض¸ô·û*/
            public byte byDisplayForm;/*0~5£¬3¸ِitemµؤإإءذ×é؛د*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public byte byDisplayHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OVERLAY_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*µ‏¼سµؤح¨µہ*/
            public uint dwDelayTime;/*µ‏¼سرست±ت±¼ن*/
            public byte byEnableDelayTime;/*تا·ٌئôسأµ‏¼سرست±£¬شعخقحث؟¨أüءîت±ئôسأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_ACTION
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struActionCode;/*½»ز×ہàذحµب¶شس¦µؤآë*/
            public NET_DVR_FRAMETYPECODE struPreCode;/*µ‏¼س×ض·ûا°µؤ×ض·û*/
            public byte byActionCodeMode;/*½»ز×ہàذحµب¶شس¦µؤآë0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_DATE
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_DATE_FORMAT struDateForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_TIME
        {
            public NET_DVR_PACKAGE_LOCATION location;
            public NET_DVRT_TIME_FORMAT struTimeForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_OTHERS
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_PACKAGE_LENGTH struPackageLength;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struPreCode;/*µ‏¼س×ض·ûا°µؤ×ض·û*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //سأ»§×ش¶¨زهذ­زé
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_USER_DEFINE_PROTOCOL
        {
            public NET_DVR_IDENTIFICAT        struIdentification;  //±¨خؤ±êض¾
            public NET_DVR_FILTER             struFilter; //ت‎¾ف°ü¹‎آثةèضأ
            public NET_DVR_ATM_PACKAGE_OTHERS struCardNoPara; //µ‏¼س؟¨؛إةèضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ACTION_TYPE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PACKAGE_ACTION[] struTradeActionPara; //µ‏¼س½»ز×ذذخھةèضأ 0-9 زہ´خ¶شس¦InCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
            public NET_DVR_ATM_PACKAGE_OTHERS struAmountPara; //µ‏¼س½»ز×½ً¶îةèضأ
            public NET_DVR_ATM_PACKAGE_OTHERS struSerialNoPara; //µ‏¼س½»ز×ذٍ؛إةèضأ
            public NET_DVR_OVERLAY_CHANNEL    struOverlayChan; //µ‏¼سح¨µہةèضأ
            public NET_DVR_ATM_PACKAGE_DATE   struRes1; //µ‏¼سبصئع£¬±£ءô
            public NET_DVR_ATM_PACKAGE_TIME   struRes2; //µ‏¼ست±¼ن£¬±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;        //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_FRAMEFORMAT_V30
        {
            public uint dwSize;                 //½ل¹¹´َذ،
            public byte byEnable;				/*تا·ٌئôسأ0,²»ئôسأ;1,ئôسأ*/
            public byte byInputMode;			/**تنبë·½ت½:0-حّآç¼àج‎،¢1حّآçذ­زé،¢2-´®؟ع¼àج‎،¢3-´®؟عذ­زé*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //±£ءô×ض½ع 
            public NET_DVR_IPADDR struAtmIp;				/*ATM »ْIP حّآç¼àج‎ت±ت¹سأ */
            public ushort wAtmPort;				/* حّآçذ­زé·½ت½ت±تات¹سأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;              // ±£ءô×ض½ع
            public uint dwAtmType;				/*ATMذ­زéہàذح£¬´سNET_DVR_ATM_PROTOCOL½ل¹¹ضذ»ٌب،£¬بç¹ûہàذحخھ×ش¶¨زهت±ت¹سأسأ»§×ش¶¨زهذ­زé*/
            public NET_DVR_ATM_USER_DEFINE_PROTOCOL  struAtmUserDefineProtocol; //سأ»§×ش¶¨زهذ­زé£¬µ±ATMہàذحخھ×ش¶¨ت±ذèزھت¹سأ¸أ¶¨زه
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //ذ­زéذإد¢ت‎¾ف½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTO_TYPE
        {
            public uint dwAtmType; //ATMذ­زéہàذح£¬ح¬ت±×÷خھث÷ز‎ذٍ؛إ ATM إنضأضذµؤdwAtmType ×ش¶¨زهت±خھ1025
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = ATM_DESC_LEN)]
            public string chDesc; //ATMذ­زé¼ٍµ¥أèتِ
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ATM_PROTO_LIST
        {
            public uint dwAtmProtoNum;/*ذ­زéءذ±يµؤ¸ِت‎*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ATM_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PROTO_TYPE[] struAtmProtoType;/*ذ­زéءذ±يذإد¢*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTOCOL
        {
            public uint dwSize;
            public NET_DVR_ATM_PROTO_LIST struNetListenList;     // حّآç¼àج‎ذ­زéأèتِ
            public NET_DVR_ATM_PROTO_LIST struSerialListenList; //´®؟ع¼àج‎ذ­زéأèتِ
            public NET_DVR_ATM_PROTO_LIST struNetProtoList;     //حّآçذ­زéأèتِ
            public NET_DVR_ATM_PROTO_LIST struSerialProtoList;   //´®؟عذ­زéأèتِ
            public NET_DVR_ATM_PROTO_TYPE struCustomProto;      //×ش¶¨زهذ­زé            
        }

        /*****************************DS-6001D/F(begin)***************************/
        //DS-6001D Decoder
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤأـآë
            public byte bySendMode;//½âآëةè±¸ء¬½س·‏خٌئ÷µؤء¬½سؤ£ت½
            public byte byEncoderChannel;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤح¨µہ؛إ
            public ushort wEncoderPort;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤ¶ث؟ع؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERSTATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤأـآë
            public byte byEncoderChannel;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤح¨µہ؛إ
            public byte bySendMode;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤء¬½سؤ£ت½
            public ushort wEncoderPort;//½âآëةè±¸ء¬½سµؤ·‏خٌئ÷µؤ¶ث؟ع؛إ
            public uint dwConnectState;//½âآëةè±¸ء¬½س·‏خٌئ÷µؤ×´ج¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//±£ءô
        }

        /*½âآëةè±¸؟طضئآë¶¨زه*/
        public const int NET_DEC_STARTDEC = 1;
        public const int NET_DEC_STOPDEC = 2;
        public const int NET_DEC_STOPCYCLE = 3;
        public const int NET_DEC_CONTINUECYCLE = 4;

        /*ء¬½سµؤح¨µہإنضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµطض· */
            public ushort wDVRPort;/* ¶ث؟ع؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            public byte byChannel;/* ح¨µہ؛إ */
            public byte byLinkMode;/* ء¬½سؤ£ت½ */
            public byte byLinkType;/* ء¬½سہàذح 0£­ض÷آëء÷ 1£­×سآëء÷ */
        }

        /*أ؟¸ِ½âآëح¨µہµؤإنضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECINFO
        {
            public byte byPoolChans;/*أ؟آ·½âآëح¨µہةدµؤر­»·ح¨µہت‎ء؟, ×î¶à4ح¨µہ 0±يت¾أ»سذ½âآë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECPOOLNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANINFO[] struchanConInfo;
            public byte byEnablePoll;/*تا·ٌآضر² 0-·ٌ 1-تا*/
            public byte byPoolTime;/*آضر²ت±¼ن 0-±£ءô 1-10أë 2-15أë 3-20أë 4-30أë 5-45أë 6-1·ضضس 7-2·ضضس 8-5·ضضس */
        }

        /*صû¸ِةè±¸½âآëإنضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECCFG
        {
            public uint dwSize;
            public uint dwDecChanNum;/*½âآëح¨µہµؤت‎ء؟*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECINFO[] struDecInfo;
        }

        //2005-08-01
        /* ½âآëةè±¸ح¸أ÷ح¨µہةèضأ */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PORTINFO
        {
            public uint dwEnableTransPort;/* تا·ٌئô¶¯ح¸أ÷ح¨µہ 0£­²»ئôسأ 1£­ئôسأ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IPµطض· */
            public ushort wDecoderPort;/* ¶ث؟ع؛إ */
            public ushort wDVRTransPort;/* إنضأا°¶ثDVRتا´س485/232تن³ِ£¬1±يت¾232´®؟ع,2±يت¾485´®؟ع */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string cReserve;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PORTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRANSPARENTNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PORTINFO[] struTransPortInfo;/* ت‎×é0±يت¾232 ت‎×é1±يت¾485 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct bytime
        {
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/*اëاَتسئµسأ»§أû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            public NET_DVR_TIME struStartTime;/* °´ت±¼ن»ط·إµؤ؟ھت¼ت±¼ن */
            public NET_DVR_TIME struStopTime;/* °´ت±¼ن»ط·إµؤ½لتّت±¼ن */
        }

        /* ؟طضئحّآçخؤ¼‏»ط·إ */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PLAYREMOTEFILE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IPµطض· */
            public ushort wDecoderPort;/* ¶ث؟ع؛إ */
            public ushort wLoadMode;/* »ط·إدآشطؤ£ت½ 1£­°´أû×ض 2£­°´ت±¼ن */

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct mode_size
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                public byte[] byFile;/* »ط·إµؤخؤ¼‏أû */
                [FieldOffsetAttribute(0)]
                public bytime bytime;
            }
        }



        /*µ±ا°ةè±¸½âآëء¬½س×´ج¬*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANSTATUS
        {
            public uint dwWorkType;/*¹¤×÷·½ت½£؛1£؛آضر²،¢2£؛¶¯ج¬ء¬½س½âآë،¢3£؛خؤ¼‏»ط·إدآشط 4£؛°´ت±¼ن»ط·إدآشط*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/*ء¬½سµؤةè±¸ip*/
            public ushort wDVRPort;/*ء¬½س¶ث؟ع؛إ*/
            public byte byChannel;/* ح¨µہ؛إ */
            public byte byLinkMode;/* ء¬½سؤ£ت½ */
            public uint dwLinkType;/*ء¬½سہàذح 0£­ض÷آëء÷ 1£­×سآëء÷*/

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct objectInfo
            {
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct userInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*اëاَتسئµسأ»§أû*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* أـآë */
                    [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 52)]
                    public string cReserve;
                }

                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct fileInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                    public byte[] fileName;
                }
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct timeInfo
                {
                    public uint dwChannel;
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*اëاَتسئµسأ»§أû*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* أـآë */
                    public NET_DVR_TIME struStartTime;/* °´ت±¼ن»ط·إµؤ؟ھت¼ت±¼ن */
                    public NET_DVR_TIME struStopTime;/* °´ت±¼ن»ط·إµؤ½لتّت±¼ن */
                }
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANSTATUS[] struTransPortInfo;
        }
        /*****************************DS-6001D/F(end)***************************/

        //µ¥×ض·û²خت‎(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SHOWSTRINGINFO
        {
            public ushort wShowString;// ش¤ہہµؤح¼دَةدتا·ٌدشت¾×ض·û,0-²»دشت¾,1-دشت¾ اّسٍ´َذ،704*576,µ¥¸ِ×ض·ûµؤ´َذ،خھ32*32
            public ushort wStringSize;/* ¸أذذ×ض·ûµؤ³¤¶ب£¬²»ؤـ´َسع44¸ِ×ض·û */
            public ushort wShowStringTopLeftX;/* ×ض·ûدشت¾خ»ضأµؤx×ّ±ê */
            public ushort wShowStringTopLeftY;/* ×ض·ûأû³ئدشت¾خ»ضأµؤy×ّ±ê */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 44)]
            public string sString;/* زھدشت¾µؤ×ض·ûؤعبف */
        }

        //µ‏¼س×ض·û(9000ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* زھدشت¾µؤ×ض·ûؤعبف */
        }

        //µ‏¼س×ض·ûہ©ص¹(8جُ×ض·û)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* زھدشت¾µؤ×ض·ûؤعبف */
        }

        //µ‏¼س×ض·û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* زھدشت¾µؤ×ض·ûؤعبف */
        }

        /****************************DS9000ذآشِ½ل¹¹(begin)******************************/
        /*EMAIL²خت‎½ل¹¹*/
        //سëش­½ل¹¹جهسذ²îزى
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struReceiver
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sName;/* تص¼‏بثذصأû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAddress;/* تص¼‏بثµطض· */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAccount;/* صث؛إ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_PWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*أـآë */

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct struSender
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sName;/* ·¢¼‏بثذصأû */
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sAddress;/* ·¢¼‏بثµطض· */
            }

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;/* smtp·‏خٌئ÷ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;/* pop3·‏خٌئ÷ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
            public struReceiver[] struStringInfo;/* ×î¶à؟ةزشةèضأ3¸ِتص¼‏بث */

            public byte byAttachment;/* تا·ٌ´ّ¸½¼‏ */
            public byte bySmtpServerVerify;/* ·¢ثح·‏خٌئ÷زھاَةي·فرéض¤ */
            public byte byMailInterval;/* mail interval */
            public byte byEnableSSL;//sslتا·ٌئôسأ9000_1.1
            public ushort wSmtpPort;//gmailµؤ465£¬ئصح¨µؤخھ25  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        /*DVRتµدضر²؛½ت‎¾ف½ل¹¹*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_PARA
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* ش¤ضأµم؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseSpeed;/* ر²؛½ثظ¶ب */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.U2)]
            public ushort[] wDwellTime;/* ح£ءôت±¼ن */
            public byte byEnableThisCruise;/* تا·ٌئôسأ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }
        /****************************DS9000ذآشِ½ل¹¹(end)******************************/
        //ت±¼نµم
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMEPOINT
        {
            public uint dwMonth;//شآ 0-11±يت¾1-12¸ِشآ
            public uint dwWeekNo;//µع¼¸ضـ 0£­µع1ضـ 1£­µع2ضـ 2£­µع3ضـ 3£­µع4ضـ 4£­×î؛َز»ضـ
            public uint dwWeekDate;//ذائع¼¸ 0£­ذائعبص 1£­ذائعز» 2£­ذائع¶‏ 3£­ذائعب‎ 4£­ذائعثؤ 5£­ذائعخه 6£­ذائعءù
            public uint dwHour;//ذ،ت±	؟ھت¼ت±¼ن0£­23 ½لتّت±¼ن1£­23
            public uint dwMin;//·ض	0£­59
        }

        //دؤءîت±²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZONEANDDST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô
            public uint dwEnableDST;//تا·ٌئôسأدؤت±ضئ 0£­²»ئôسأ 1£­ئôسأ
            public byte byDSTBias;//دؤءîت±ئ«زئضµ£¬30min, 60min, 90min, 120min, زش·ضضس¼ئ£¬´«µفش­ت¼ت‎ضµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_TIMEPOINT struBeginPoint;//دؤت±ضئ؟ھت¼ت±¼ن
            public NET_DVR_TIMEPOINT struEndPoint;//دؤت±ضئح£ض¹ت±¼ن
        }

        //ح¼ئ¬ضتء؟
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGPARA
        {
            /*×¢زâ£؛µ±ح¼دٌر¹ثُ·ض±وآتخھVGAت±£¬ض§³ض0=CIF, 1=QCIF, 2=D1×¥ح¼£¬
	        µ±·ض±وآتخھ3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
	        ½ِض§³ضµ±ا°·ض±وآتµؤ×¥ح¼*/
            public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
            public ushort wPicQuality;/* ح¼ئ¬ضتء؟دµت‎ 0-×î؛أ 1-½د؛أ 2-ز»°م */
        }

        /* aux video out parameter */
        //¸¨ضْتن³ِ²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXOUTCFG
        {
            public uint dwSize;
            public uint dwAlarmOutChan;/* ر،شٌ±¨¾¯µ¯³ِ´َ±¨¾¯ح¨µہاذ»»ت±¼ن£؛1»­أوµؤتن³ِح¨µہ: 0:ض÷تن³ِ/1:¸¨1/2:¸¨2/3:¸¨3/4:¸¨4 */
            public uint dwAlarmChanSwitchTime;/* :1أë - 10:10أë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAuxSwitchTime;/* ¸¨ضْتن³ِاذ»»ت±¼ن: 0-²»اذ»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT * MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuxOrder;/* ¸¨ضْتن³ِش¤ہہث³ذٍ, 0xff±يت¾دàس¦µؤ´°؟ع²»ش¤ہہ */
        }

        //ntp
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NTPPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
            public ushort wInterval;/* adjust time interval(hours) */
            public byte byEnableNTP;/* enable NPT client 0-no£¬1-yes*/
            public byte cTimeDifferenceH;/* سë¹ْ¼ت±ê×¼ت±¼نµؤ ذ،ت±ئ«زئ-12 ... +13 */
            public byte cTimeDifferenceM;/* سë¹ْ¼ت±ê×¼ت±¼نµؤ ·ضضسئ«زئ0, 30, 45*/
            public byte res1;
            public ushort wNtpPort; /* ntp server port 9000ذآشِ ةè±¸ؤ¬بدخھ123*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;
        }

        //ddns
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSصث؛إسأ»§أû/أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName; /* سٍأû */
            public byte byEnableDDNS;/*تا·ٌس¦سأ 0-·ٌ£¬1-تا*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_EX
        {
            public byte byHostIndex;/* 0-Hikvision DNS 1£­Dyndns 2£­PeanutHull(»¨ةْ؟ا)*/
            public byte byEnableDDNS;/*تا·ٌس¦سأDDNS 0-·ٌ£¬1-تا*/
            public ushort wDDNSPort;/* DDNS¶ث؟ع؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSسأ»§أû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* DDNSأـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* ةè±¸إن±¸µؤسٍأûµطض· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNS ¶شس¦µؤ·‏خٌئ÷µطض·£¬؟ةزشتاIPµطض·»ٍسٍأû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //9000ہ©ص¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDDNS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSصث؛إسأ»§أû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* ةè±¸إن±¸µؤسٍأûµطض· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNSذ­زé¶شس¦µؤ·‏خٌئ÷µطض·£¬؟ةزشتاIPµطض·»ٍسٍأû */
            public ushort wDDNSPort;/* ¶ث؟ع؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_V30
        {
            public byte byEnableDDNS;
            public byte byHostIndex;/* 0-Hikvision DNS(±£ءô) 1£­Dyndns 2£­PeanutHull(»¨ةْ؟ا)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DDNS_NUMS, ArraySubType = UnmanagedType.Struct)]
            public struDDNS[] struDDNS;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //email
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* ست¼‏صث؛إ/أـآë */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sMailAddr;/* email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr1;/* ةد´«±¨¾¯/زى³£µبµؤemail */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //حّآç²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETAPPCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDNSIp; /* DNS·‏خٌئ÷µطض· */
            public NET_DVR_NTPPARA struNtpClientParam;/* NTP²خت‎ */
            public NET_DVR_DDNSPARA struDDNSClientParam;/* DDNS²خت‎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ±£ءô */
        }

        //nfs½ل¹¹إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SINGLE_NFS
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNfsHostIPAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNfsDirectory;

            public void Init()
            {
                this.sNfsDirectory = new byte [ PATHNAME_LEN ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NFSCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NFS_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NFS[] struNfsDiskParam;

            public void Init()
            {
                this.struNfsDiskParam = new NET_DVR_SINGLE_NFS [ MAX_NFS_DISK ];

                for ( int i = 0; i < MAX_NFS_DISK; i++ )
                {
                    struNfsDiskParam [ i ].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ISCSI_CFG
        {
            public uint dwSize;                   // ½ل¹¹´َذ،
            public ushort wVrmPort;                  // VRM ¼àج‎¶ث؟ع
            public byte byEnable;                  // تا·ٌئôسأ ISCSI´و´¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                 // ±£ءô×ض½ع
            public NET_DVR_IPADDR struVrmAddr;          // VRM ipµطض· 16خ»
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chNvtIndexCode;        //nvt index Code 
        }

        //ر²؛½µمإنضأ(HIK IP؟ىاٍ×¨سأ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_POINT
        {
            public byte PresetNum;//ش¤ضأµم
            public byte Dwell;//ح£ءôت±¼ن
            public byte Speed;//ثظ¶ب
            public byte Reserve;//±£ءô

            public void Init()
            {
                PresetNum = 0;
                Dwell = 0;
                Speed = 0;
                Reserve = 0;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISE_POINT[] struCruisePoint;//×î´َض§³ض32¸ِر²؛½µم

            public void Init()
            {
                struCruisePoint = new NET_DVR_CRUISE_POINT [ 32 ];
                for ( int i = 0; i < 32; i++ )
                {
                    struCruisePoint [ i ].Init();
                }
            }
        }

        /************************************¶àآ·½âآëئ÷(begin)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG_OTHER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DECINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµطض· */
            public ushort wDVRPort;/* ¶ث؟ع؛إ */
            public byte byChannel;/* ح¨µہ؛إ */
            public byte byTransProtocol;/* ´«تنذ­زéہàذح 0-TCP, 1-UDP */
            public byte byTransMode;/* ´«تنآëء÷ؤ£ت½ 0£­ض÷آëء÷ 1£­×سآëء÷*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ¼à؟طض÷»ْµاآ½صت؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ¼à؟طض÷»ْأـآë */
        }

        //ئô¶¯/ح£ض¹¶¯ج¬½âآë
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DYNAMIC_DEC
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ¶¯ج¬½âآëح¨µہذإد¢ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
        {
            public uint dwSize;
            public uint dwIsLinked;/* ½âآëح¨µہ×´ج¬ 0£­ذفأك 1£­ص‎شعء¬½س 2£­زرء¬½س 3-ص‎شع½âآë */
            public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string cRes;/* ±£ءô */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ½âآëح¨µہذإد¢ */
            public uint dwDecState;/* 0-¶¯ج¬½âآë 1£­ر­»·½âآë 2£­°´ت±¼ن»ط·إ 3£­°´خؤ¼‏»ط·إ */
            public NET_DVR_TIME StartTime;/* °´ت±¼ن»ط·إ؟ھت¼ت±¼ن */
            public NET_DVR_TIME StopTime;/* °´ت±¼ن»ط·إح£ض¹ت±¼ن */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* °´خؤ¼‏»ط·إخؤ¼‏أû */
        }

        //ء¬½سµؤح¨µہإنضأ 2007-11-05
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHANINFO
        {
            public uint dwEnable;/* تا·ٌئôسأ 0£­·ٌ 1£­ئôسأ*/
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* آضر­½âآëح¨µہذإد¢ */
        }

        //2007-11-05 ذآشِأ؟¸ِ½âآëح¨µہµؤإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO
        {
            public uint dwSize;
            public uint dwPoolTime;/*آضر²ت±¼ن */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
        }

        //2007-12-22
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct TTY_CONFIG
        {
            public byte baudrate;/* ²¨جطآت */
            public byte databits;/* ت‎¾فخ» */
            public byte stopbits;/* ح£ض¹خ» */
            public byte parity;/* ئوإ¼ذ£رéخ» */
            public byte flowcontrol;/* ء÷؟ط */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
        {
            public byte byTranChanEnable;/* µ±ا°ح¸أ÷ح¨µہتا·ٌ´ٍ؟ھ 0£؛¹ط±ص 1£؛´ٍ؟ھ */
            /*
             *	¶àآ·½âآëئ÷±¾µطسذ1¸ِ485´®؟ع£¬1¸ِ232´®؟ع¶¼؟ةزش×÷خھح¸أ÷ح¨µہ,ةè±¸؛إ·ضإنبçدآ£؛
             *	0 RS485
             *	1 RS232 Console
             */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	ش¶³ج´®؟عتن³ِ»¹تاء½¸ِ,ز»¸ِRS232£¬ز»¸ِRS485
	         *	1±يت¾232´®؟ع
	         *	2±يت¾485´®؟ع
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte res1;/* ±£ءô */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;/* ±£ءô */
            public TTY_CONFIG RemoteSerialDevCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ةèضأؤؤآ·232ح¸أ÷ح¨µہتاب«ث«¹¤µؤ ب،ضµ1µ½MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ةèضأؤؤآ·485ح¸أ÷ح¨µہتاب«ث«¹¤µؤ ب،ضµ1µ½MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ±£ءô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*ح¬ت±ض§³ض½¨ء¢MAX_SERIAL_NUM¸ِح¸أ÷ح¨µہ*/
        }

        //2007-12-24 Merry Christmas Eve...
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµطض· */
            public ushort wDVRPort;/* ¶ث؟ع؛إ */
            public byte byChannel;/* ح¨µہ؛إ */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* أـآë */
            public uint dwPlayMode;/* 0£­°´خؤ¼‏ 1£­°´ت±¼ن*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;/* ²¥·إأüءî ¼ûخؤ¼‏²¥·إأüءî*/
            public uint dwCmdParam;/* ²¥·إأüءî²خت‎ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
        {
            public uint dwSize;
            public uint dwCurMediaFileLen;/* µ±ا°²¥·إµؤأ½جهخؤ¼‏³¤¶ب */
            public uint dwCurMediaFilePosition;/* µ±ا°²¥·إخؤ¼‏µؤ²¥·إخ»ضأ */
            public uint dwCurMediaFileDuration;/* µ±ا°²¥·إخؤ¼‏µؤ×ـت±¼ن */
            public uint dwCurPlayTime;/* µ±ا°زر¾­²¥·إµؤت±¼ن */
            public uint dwCurMediaFIleFrames;/* µ±ا°²¥·إخؤ¼‏µؤ×ـض،ت‎ */
            public uint dwCurDataType;/* µ±ا°´«تنµؤت‎¾فہàذح£¬19-خؤ¼‏ح·£¬20-ء÷ت‎¾ف£¬ 21-²¥·إ½لتّ±êض¾ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //2009-4-11 added by likui ¶àآ·½âآëئ÷new
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_PASSIVEMODE
        {
            public ushort wTransProtol;//´«تنذ­زé£¬0-TCP, 1-UDP, 2-MCAST
            public ushort wPassivePort;//UDP¶ث؟ع, TCPت±ؤ¬بد
            // char	sMcastIP[16];		//TCP,UDPت±خقذ§, MCASTت±خھ¶à²¥µطض·
            public NET_DVR_IPADDR struMcastIP;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO_V30
        {
            public byte byTranChanEnable;/* µ±ا°ح¸أ÷ح¨µہتا·ٌ´ٍ؟ھ 0£؛¹ط±ص 1£؛´ٍ؟ھ */
            /*
	         *	¶àآ·½âآëئ÷±¾µطسذ1¸ِ485´®؟ع£¬1¸ِ232´®؟ع¶¼؟ةزش×÷خھح¸أ÷ح¨µہ,ةè±¸؛إ·ضإنبçدآ£؛
	         *	0 RS485
	         *	1 RS232 Console
	         */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	ش¶³ج´®؟عتن³ِ»¹تاء½¸ِ,ز»¸ِRS232£¬ز»¸ِRS485
	         *	1±يت¾232´®؟ع
	         *	2±يت¾485´®؟ع
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte byRes1;/* ±£ءô */
            public NET_DVR_IPADDR struRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            public byte byIsEstablished;/* ح¸أ÷ح¨µہ½¨ء¢³ة¹¦±êض¾£¬0-أ»سذ³ة¹¦£¬1-½¨ء¢³ة¹¦ */
            public byte byRes2;/* ±£ءô */
            public TTY_CONFIG RemoteSerialDevCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUsername;/* 32BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;/* 16BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ةèضأؤؤآ·232ح¸أ÷ح¨µہتاب«ث«¹¤µؤ ب،ضµ1µ½MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ةèضأؤؤآ·485ح¸أ÷ح¨µہتاب«ث«¹¤µؤ ب،ضµ1µ½MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] vyRes;/* ±£ءô */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*ح¬ت±ض§³ض½¨ء¢MAX_SERIAL_NUM¸ِح¸أ÷ح¨µہ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_INFO_V30
        {
            public uint dwEnable;/* تا·ٌئôسأ 0£­·ٌ 1£­ئôسأ*/
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* آضر­½âآëح¨µہذإد¢ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_V30
        {
            public uint dwSize;
            public uint dwPoolTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struchanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO_V30
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;/*ء÷أ½جه·‏خٌئ÷إنضأ*/
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ½âآëح¨µہذإد¢ */
            public uint dwDecState;/* 0-¶¯ج¬½âآë 1£­ر­»·½âآë 2£­°´ت±¼ن»ط·إ 3£­°´خؤ¼‏»ط·إ */
            public NET_DVR_TIME StartTime;/* °´ت±¼ن»ط·إ؟ھت¼ت±¼ن */
            public NET_DVR_TIME StopTime;/* °´ت±¼ن»ط·إح£ض¹ت±¼ن */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* °´خؤ¼‏»ط·إخؤ¼‏أû */
            public uint dwGetStreamMode;/*ب،ء÷ؤ£ت½:1-ض÷¶¯£¬2-±»¶¯*/
            public NET_DVR_MATRIX_PASSIVEMODE struPassiveMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_RESOLUTIONNUM = 64; //ض§³ضµؤ×î´َ·ض±وآتت‎ؤ؟

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY
        {
            public uint dwSize;
            public byte byDecNums;
            public byte byStartChan;
            public byte byVGANums;
            public byte byBNCNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8*12, ArraySubType = UnmanagedType.I1)]
            public byte[] byVGAWindowMode;/*VGAض§³ضµؤ´°؟عؤ£ت½*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byBNCWindowMode;/*BNCض§³ضµؤ´°؟عؤ£ت½*/
            public byte byDspNums;
            public byte byHDMINums;//HDMIدشت¾ح¨µہ¸ِت‎£¨´س25؟ھت¼£©
            public byte byDVINums;//DVIدشت¾ح¨µہ¸ِت‎£¨´س29؟ھت¼£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESOLUTIONNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] bySupportResolution;//°´صصةدأوµؤأ¶¾ظ¶¨زه,ز»¸ِ×ض½ع´ْ±يز»¸ِ·ض±وآتتا//·ٌض§³ض£¬1£؛ض§³ض£¬0£؛²»ض§³ض
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDMIWindowMode;//HDMIض§³ضµؤ´°؟عؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVIWindowMode;//DVIض§³ضµؤ´°؟عؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ةد´«logo½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_LOGOCFG
        {
            public uint dwCorordinateX;//ح¼ئ¬دشت¾اّسٍX×ّ±ê
            public uint dwCorordinateY;//ح¼ئ¬دشت¾اّسٍY×ّ±ê
            public ushort wPicWidth; //ح¼ئ¬؟ي
            public ushort wPicHeight; //ح¼ئ¬¸ك
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byFlash;//تا·ٌةءث¸1-ةءث¸£¬0-²»ةءث¸
            public byte byTranslucent;//تا·ٌ°ëح¸أ÷1-°ëح¸أ÷£¬0-²»°ëح¸أ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£ءô
            public uint dwLogoSize;//LOGO´َذ،£¬°üہ¨BMPµؤخؤ¼‏ح·
        }

        /*±àآëہàذح*/
        public const int NET_DVR_ENCODER_UNKOWN = 0;/*خ´ضھ±àآë¸ٌت½*/
        public const int NET_DVR_ENCODER_H264 = 1;/*HIK 264*/
        public const int NET_DVR_ENCODER_S264 = 2;/*Standard H264*/
        public const int NET_DVR_ENCODER_MPEG4 = 3;/*MPEG4*/
        public const int NET_DVR_ORIGINALSTREAM = 4;/*Original Stream*/
        public const int NET_DVR_PICTURE = 5;//*Picture*/
        public const int NET_DVR_ENCODER_MJPEG = 6;
        public const int NET_DVR_ECONDER_MPEG2 = 7;
        /* ´ٍ°ü¸ٌت½ */
        public const int NET_DVR_STREAM_TYPE_UNKOWN = 0;/*خ´ضھ´ٍ°ü¸ٌت½*/
        public const int NET_DVR_STREAM_TYPE_HIKPRIVT = 1; /*؛£؟µ×ش¶¨زه´ٍ°ü¸ٌت½*/
        public const int NET_DVR_STREAM_TYPE_TS = 7;/* TS´ٍ°ü */
        public const int NET_DVR_STREAM_TYPE_PS = 8;/* PS´ٍ°ü */
        public const int NET_DVR_STREAM_TYPE_RTP = 9;/* RTP´ٍ°ü */

        /*½âآëح¨µہ×´ج¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_STATUS
        {
            public byte byDecodeStatus;/*µ±ا°×´ج¬:0:خ´ئô¶¯£¬1£؛ئô¶¯½âآë*/
            public byte byStreamType;/*آëء÷ہàذح*/
            public byte byPacketType;/*´ٍ°ü·½ت½*/
            public byte byRecvBufUsage;/*½ستص»؛³هت¹سأآت*/
            public byte byDecBufUsage;/*½âآë»؛³هت¹سأآت*/
            public byte byFpsDecV;/*تسئµ½âآëض،آت*/
            public byte byFpsDecA;/*زôئµ½âآëض،آت*/
            public byte byCpuLoad;/*DSP CPUت¹سأآت*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDecodedV;/*½âآëµؤتسئµض،*/
            public uint dwDecodedA;/*½âآëµؤزôئµض،*/
            public ushort wImgW;/*½âآëئ÷µ±ا°µؤح¼دٌ´َذ،,؟ي*/
            public ushort wImgH; //¸ك
            public byte byVideoFormat;/*تسئµضئت½:0-NON,NTSC--1,PAL--2*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwDecChan; /*»ٌب،ب«²؟½âآëح¨µہ×´ج¬ت±سذذ§£¬ةèضأت±؟ةجî0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*دشت¾ح¨µہ×´ج¬*/
        public const int NET_DVR_MAX_DISPREGION = 16;         /*أ؟¸ِدشت¾ح¨µہ×î¶à؟ةزشدشت¾µؤ´°؟ع*/
        //VGA·ض±وآت£¬ؤ؟ا°ؤـسأµؤتا£؛VGA_THS8200_MODE_XGA_60HZ،¢VGA_THS8200_MODE_SXGA_60HZ،¢
        //
        public enum VGA_MODE
        {
            /*VGA*/
            VGA_NOT_AVALIABLE,
            VGA_THS8200_MODE_SVGA_60HZ,    //(800*600)
            VGA_THS8200_MODE_SVGA_75HZ,    //(800*600)
            VGA_THS8200_MODE_XGA_60HZ,     //(1024*768)
            VGA_THS8200_MODE_XGA_75HZ,     //(1024*768)
            VGA_THS8200_MODE_SXGA_60HZ,    //(1280*1024)
            VGA_THS8200_MODE_720P_60HZ,    //(1280*720)
            VGA_THS8200_MODE_1080I_60HZ,   //(1920*1080)
            VGA_THS8200_MODE_1080P_30HZ,   //(1920*1080)
            VGA_THS8200_MODE_UXGA_30HZ,    //(1600*1200)
            /*HDMI*/
            HDMI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            HDMI_SII9134_MODE_SXGA_60HZ,   //(1280*1024)
            HDMI_SII9134_MODE_SXGA2_60HZ,  //(1280*960)
            HDMI_SII9134_MODE_720P_60HZ,   //(1280*720)	
            HDMI_SII9134_MODE_720P_50HZ,   //(1280*720)		
            HDMI_SII9134_MODE_1080I_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080I_50HZ,  //(1920*1080)	
            HDMI_SII9134_MODE_1080P_25HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_30HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_50HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_UXGA_60HZ,   //(1600*1200)
            /*DVI*/
            DVI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            DVI_SII9134_MODE_SXGA_60HZ,	   //(1280*1024)
            DVI_SII9134_MODE_SXGA2_60HZ,   //(1280*960)
            DVI_SII9134_MODE_720P_60HZ,	   //(1280*720)	
            DVI_SII9134_MODE_720P_50HZ,    //(1280*720)		
            DVI_SII9134_MODE_1080I_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080I_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_25HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_30HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_UXGA_60HZ,     //(1600*1200)
            VGA_DECSVR_MODE_SXGA2_60HZ,
            HDMI_DECSVR_MODE_1080P_24HZ,
            DVI_DECSVR_MODE_1080P_24HZ,
            YPbPr_DECSVR_MODE_720P_60HZ,
            YPbPr_DECSVR_MODE_1080I_60HZ
        }

        //µحض،آت¶¨زه
        public const int LOW_DEC_FPS_1_2 = 51;
        public const int LOW_DEC_FPS_1_4 = 52;
        public const int LOW_DEC_FPS_1_8 = 53;
        public const int LOW_DEC_FPS_1_16 = 54;

        /*تسئµضئت½±ê×¼*/
        public enum VIDEO_STANDARD
        {
            VS_NON = 0,
            VS_NTSC = 1,
            VS_PAL = 2,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM
        {
            /*¸÷¸ِ×س´°؟ع¶شس¦½âآëح¨µہثù¶شس¦µؤ½âآë×سدµح³µؤ²غخ»؛إ(¶شسعتسئµ×غ؛دئ½ج¨ضذ½âآë×سدµح³سذذ§)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG
        {
            public uint dwSize;
            public byte byAudio;/*زôئµتا·ٌ؟ھئô,0-·ٌ£¬1-تا*/
            public byte byAudioWindowIdx;/*زôئµ؟ھئô×س´°؟ع*/
            public byte byVgaResolution;/*VGAµؤ·ض±وآت*/
            public byte byVedioFormat;/*تسئµضئت½£¬1:NTSC,2:PAL,0-NON*/
            public uint dwWindowMode;/*»­أوؤ£ت½£¬´سؤـء¦¼¯ہï»ٌب،£¬ؤ؟ا°ض§³ض1,2,4,9,16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ِ×س´°؟ع¹طءھµؤ½âآëح¨µہ*/
            public byte byEnlargeStatus;          /*تا·ٌ´¦سع·إ´َ×´ج¬£¬0£؛²»·إ´َ£¬1£؛·إ´َ*/
            public byte byEnlargeSubWindowIndex;//·إ´َµؤ×س´°؟ع؛إ
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                [FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM struNotVideoPlatform;
            }
            public byte byUnionType;/*اّ·ض¹²سأجه£¬0-تسئµ×غ؛دئ½ج¨ؤع²؟½âآëئ÷دشت¾ح¨µہإنضأ£¬1-ئنثû½âآëئ÷دشت¾ح¨µہإنضأ*/
            public byte byScale; /*دشت¾ؤ£ت½£¬0---صوتµدشت¾£¬1---ثُ·إدشت¾( صë¶شBNC )*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS
        {
            public byte byDispStatus;/*دشت¾×´ج¬£؛0£؛خ´دشت¾£¬1£؛ئô¶¯دشت¾*/
            public byte byBVGA; /*VGA/BNC*/
            public byte byVideoFormat;/*تسئµضئت½:1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;/*µ±ا°»­أوؤ£ت½*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ِ×س´°؟ع¹طءھµؤ½âآëح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_MAX_DISPREGION, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;/*أ؟¸ِ×س»­أوµؤدشت¾ض،آت*/
            public byte byScreenMode;			//ئءؤ»ؤ£ت½0-ئصح¨ 1-´َئء
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_DECODECHANNUM = 32;//¶àآ·½âآëئ÷×î´َ½âآëح¨µہت‎
        public const int MAX_DISPCHANNUM = 24;//¶àآ·½âآëئ÷×î´َدشت¾ح¨µہت‎

        /*½âآëئ÷ةè±¸×´ج¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECODECHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;/*½âآëح¨µہ×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPCHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS[] struDispChanStatus;/*دشت¾ح¨µہ×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;/*±¨¾¯تنبë×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAalarmOutStatus;/*±¨¾¯تن³ِ×´ج¬*/
            public byte byAudioInChanStatus;/*سïزô¶ش½²×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2009-12-1 شِ¼س±»¶¯½âآë²¥·إ؟طضئ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PASSIVEDECODE_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;		/* ²¥·إأüءî ¼ûخؤ¼‏²¥·إأüءî*/
            public uint dwCmdParam;		/* ²¥·إأüءî²خت‎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//Reverse
        }

        public const int PASSIVE_DEC_PAUSE = 1;	/*±»¶¯½âآëشفح£(½ِخؤ¼‏ء÷سذذ§)*/
        public const int PASSIVE_DEC_RESUME = 2;	/*»ض¸´±»¶¯½âآë(½ِخؤ¼‏ء÷سذذ§)*/
        public const int PASSIVE_DEC_FAST = 3;   /*؟ىثظ±»¶¯½âآë(½ِخؤ¼‏ء÷سذذ§)*/
        public const int PASSIVE_DEC_SLOW = 4;   /*آ‎ثظ±»¶¯½âآë(½ِخؤ¼‏ء÷سذذ§)*/
        public const int PASSIVE_DEC_NORMAL = 5;   /*ص‎³£±»¶¯½âآë(½ِخؤ¼‏ء÷سذذ§)*/
        public const int PASSIVE_DEC_ONEBYONE = 6;  /*±»¶¯½âآëµ¥ض،²¥·إ(±£ءô)*/
        public const int PASSIVE_DEC_AUDIO_ON = 7;   /*زôئµ؟ھئô*/
        public const int PASSIVE_DEC_AUDIO_OFF = 8; 	 /*زôئµ¹ط±ص*/
        public const int PASSIVE_DEC_RESETBUFFER = 9;    /*اه؟ص»؛³هاّ*/

        //2009-12-16 شِ¼س؟طضئ½âآëئ÷½âآëح¨µہثُ·إ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHAN_CONTROL
        {
            public uint dwSize;
            public byte byDecChanScaleStatus;/*½âآëح¨µہدشت¾ثُ·إ؟طضئ,1±يت¾ثُ·إدشت¾£¬0±يت¾صوتµدشت¾*/
            public byte byDecodeDelay;//½âآëرست±£¬0-ؤ¬بد£¬1-تµت±ذش؛أ£¬2-تµت±ذش½د؛أ£¬3-تµت±ذشضذ£¬ء÷³©ذشضذ£¬4-ء÷³©ذش½د؛أ£¬5-ء÷³©ذش؛أ£¬0xff-×ش¶¯µ÷صû   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /************************************¶àآ·½âآëئ÷(end)***************************************/

        /************************************تسئµ×غ؛دئ½ج¨(begin)***************************************/
        public const int MAX_SUBSYSTEM_NUM = 80;   //ز»¸ِ¾طصَدµح³ضذ×î¶à×سدµح³ت‎ء؟
        public const int MAX_SUBSYSTEM_NUM_V40 = 120;   //ز»¸ِ¾طصَدµح³ضذ×î¶à×سدµح³ت‎ء؟
        public const int MAX_SERIALLEN = 36;  //×î´َذٍءذ؛إ³¤¶ب
        public const int MAX_LOOPPLANNUM = 16;  //×î´َ¼ئ»®اذ»»×é
        public const int DECODE_TIMESEGMENT = 4;     //¼ئ»®½âآëأ؟جىت±¼ن¶خت‎

        public const int MAX_DOMAIN_NAME = 64;  /* ×î´َسٍأû³¤¶ب */
        public const int MAX_DISKNUM_V30 = 33; //9000ةè±¸×î´َس²إجت‎/* ×î¶à33¸ِس²إج(°üہ¨16¸ِؤعضأSATAس²إج،¢1¸ِeSATAس²إج؛ح16¸ِNFSإج) */
        public const int MAX_DAYS = 7;       //أ؟ضـجىت‎
        public const int MAX_DISPNUM_V41 = 32;
        public const int MAX_WINDOWS_NUM = 12;
        public const int MAX_VOUTNUM = 32;
        public const int MAX_SUPPORT_RES = 32;
        public const int MAX_BIGSCREENNUM = 100;

        public const int VIDEOPLATFORM_ABILITY = 0x210; //تسئµ×غ؛دئ½ج¨ؤـء¦¼¯
        public const int MATRIXDECODER_ABILITY_V41 = 0x260; //½âآëئ÷ؤـء¦¼¯

        public const int NET_DVR_MATRIX_BIGSCREENCFG_GET = 1140;//»ٌب،´َئءئ´½س²خت‎        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEMINFO
        {
            public byte bySubSystemType;//×سدµح³ہàذح£¬1-½âآëسأ×سدµح³£¬2-±àآëسأ×سدµح³£¬0-NULL£¨´ث²خت‎ض»ؤـ»ٌب،£©
            public byte byChan;//×سدµح³ح¨µہت‎£¨´ث²خت‎ض»ؤـ»ٌب،£©
            public byte byLoginType;//×¢²لہàذح£¬1-ض±ء¬£¬2-DNS£¬3-»¨ةْ؟ا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struSubSystemIP;/*IPµطض·£¨؟ةذق¸ؤ£©*/
            public ushort wSubSystemPort;//×سدµح³¶ث؟ع؛إ£¨؟ةذق¸ؤ£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struSubSystemIPMask;//×سحّرعآë
            public NET_DVR_IPADDR struGatewayIpAddr;	/* حّ¹طµطض·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû £¨´ث²خت‎ض»ؤـ»ٌب،£©*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*أـآë£¨´ث²خت‎ض»ؤـ»ٌب،£©*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDomainName;//سٍأû(؟ةذق¸ؤ)
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDnsAddress;/*DNSسٍأû»ٍIPµطض·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ذٍءذ؛إ£¨´ث²خت‎ض»ؤـ»ٌب،£©
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLSUBSYSTEMINFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEMINFO[] struSubSystemInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOOPPLAN_SUBCFG
        {
            public uint dwSize;
            public uint dwPoolTime; /*آضر¯¼ن¸ô£¬µ¥خ»£؛أë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struChanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMMODECFG
        {
            public uint dwSize;
            public byte byAlarmMode;//±¨¾¯´¥·¢ہàذح£¬1-آضر¯£¬2-±£³ض 
            public ushort wLoopTime;//آضر¯ت±¼ن, µ¥خ»£؛أë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CODESPLITTERINFO
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;/*آë·ضئ÷IPµطض·*/
            public ushort wPort;//آë·ضئ÷¶ث؟ع؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*أـآë */
            public byte byChan;//آë·ضئ÷485؛إ
            public byte by485Port;//485؟عµطض·      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ASSOCIATECFG
        {
            public byte byAssociateType;//¹طءھہàذح£¬1-±¨¾¯
            public ushort wAlarmDelay;//±¨¾¯رست±£¬0£­5أë£»1£­10أë£»2£­30أë£»3£­1·ضضس£»4£­2·ضضس£»5£­5·ضضس£»6£­10·ضضس£»
            public byte byAlarmNum;//±¨¾¯؛إ£¬¾كجهµؤضµسةس¦سأ¸³£¬دàح¬µؤ±¨¾¯¸³دàح¬µؤضµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DYNAMICDECODE
        {
            public uint dwSize;
            public NET_DVR_ASSOCIATECFG struAssociateCfg;//´¥·¢¶¯ج¬½âآë¹طءھ½ل¹¹
            public NET_DVR_PU_STREAM_CFG struPuStreamCfg;//¶¯ج¬½âآë½ل¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODESCHED
        {
            public NET_DVR_SCHEDTIME struSchedTime;
            public byte byDecodeType;/*0-خق£¬1-آضر¯½âآë£¬2-¶¯ج¬½âآë*/
            public byte byLoopGroup;//آضر¯×é؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PU_STREAM_CFG struDynamicDec;//¶¯ج¬½âآë
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLANDECODE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * DECODE_TIMESEGMENT, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_DECODESCHED[] struDecodeSched;//ضـز»×÷خھ؟ھت¼£¬؛ح9000ز»ضآ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }
        /************************************تسئµ×غ؛دئ½ج¨(end)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;//±àآë×سدµح³ت‎ء؟
            public byte byDecodeSubSystemNums;//½âآë×سدµح³ت‎ء؟
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byWindowMode; /*دشت¾ح¨µہض§³ضµؤ´°؟عؤ£ت½*/
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;
        }



        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEM_ABILITY
        {
            /*×سدµح³ہàذح£¬1-½âآëسأ×سدµح³£¬2-±àآëسأ×سدµح³£¬3-¼¶ءھتن³ِ×سدµح³£¬4-¼¶ءھتنبë×سدµح³£¬5-آë·ضئ÷×سدµح³£¬6-±¨¾¯ض÷»ْ×سدµح³£¬7-ضاؤـ×سدµح³£¬8-V6½âآë×سدµح³£¬9-V6×سدµح³£¬0-NULL£¨´ث²خت‎ض»ؤـ»ٌب،£©*/
            public byte bySubSystemType;
            public byte byChanNum;//×سدµح³ح¨µہت‎
            public byte byStartChan;//×سدµح³ئًت¼ح¨µہت‎
            public byte bySlotNum;//²غخ»؛إ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public struDecoderSystemAbility _struAbility;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDecoderSystemAbility
        {
            public byte byVGANums;//VGAدشت¾ح¨µہ¸ِت‎£¨´س1؟ھت¼£©
            public byte byBNCNums;//BNCدشت¾ح¨µہ¸ِت‎£¨´س9؟ھت¼£©
            public byte byHDMINums;//HDMIدشت¾ح¨µہ¸ِت‎£¨´س25؟ھت¼£©
            public byte byDVINums;//DVIدشت¾ح¨µہ¸ِت‎£¨´س29؟ھت¼£©

            public byte byLayerNums;//´َئءئ´½سضذ£¬×ِض÷ئءت±ثùض§³ضح¼²مت‎
            public byte bySpartan;//³©دش¹¦ؤـ£¬0-²»ض§³ض£¬1-ض§³ض
            public byte byDecType; //½âآë×سدµح³ہàذح£¬0-ئصح¨ذح,1-شِا؟ذح(ئصح¨ذح·ضئءت±ا°4´°؟عذèت¹سأ×شةي×تش´£¬شِا؟ذحخق´ثدقضئ£¬شِا؟ذح×î¶à؟ة±»ئنثû×سدµح³½è16آ·D1½âآë×تش´
            //شِا؟ذح±»´َئء¹طءھخھ×سئء؛َ×تش´؟ة±»½èسأ£¬ئصح¨ذحشٍ²»ؤـ±»½èسأ)
            public byte byOutputSwitch;//تا·ٌض§³ضHDMI/DVI»¥دàاذ»»£¬0-²»ض§³ض£¬1-ض§³ض
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDecoderType; //½âآë°هہàذح  0-ئصح¨½âآë°ه 1-حٍؤـ½âآë°ه
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struAbility
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            //  [FieldOffsetAttribute(0)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY_V40
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;
            public byte byDecodeSubSystemNums;//½âآë×سدµح³ت‎ء؟
            public byte bySupportNat;//تا·ٌض§³ضNAT£¬0-²»ض§³ض£¬1-ض§³ض
            public byte byInputSubSystemNums;//¼¶ءھتنبë×سدµح³ت‎ء؟
            public byte byOutputSubSystemNums;//¼¶ءھتن³ِ×سدµح³ت‎ء؟
            public byte byCodeSpitterSubSystemNums;//آë·ض×سدµح³ت‎ء؟
            public byte byAlarmHostSubSystemNums;//±¨¾¯×سدµح³ت‎ء؟
            public byte bySupportBigScreenNum;//ثùض§³ض×î¶à×é³ة´َئءµؤ¸ِت‎
            public byte byVCASubSystemNums;//ضاؤـ×سدµح³ت‎ء؟
            public byte byV6SubSystemNums;//V6×سدµح³ت‎ء؟
            public byte byV6DecoderSubSystemNums;//V6½âآë×سدµح³ت‎ء؟
            public byte bySupportBigScreenX;/*´َئءئ´½سµؤؤ£ت½£؛m،ءn*/
            public byte bySupportBigScreenY;
            public byte bySupportSceneNums;//ض§³ض³،¾°ؤ£ت½µؤ¸ِت‎
            public byte byVcaSupportChanMode;//ضاؤـض§³ضµؤح¨µہت¹سأؤ£ت½£¬0-ت¹سأ½âآëح¨µہ£¬1-ت¹سأدشت¾ح¨µہ¼°×سح¨µہ؛إ
            public byte bySupportScreenNums;//ثùض§³ضµؤ´َئءµؤئءؤ»×î´َ¸ِت‎
            public byte bySupportLayerNums;//ثùض§³ضµؤح¼²مت‎£¬0xff-خقذ§
            public byte byNotSupportPreview;//تا·ٌض§³ضش¤ہہ,1-²»ض§³ض£¬0-ض§³ض
            public byte byNotSupportStorage;//تا·ٌض§³ض´و´¢,1-²»ض§³ض£¬0-ض§³ض
            public byte byUploadLogoMode;//ةد´«logoؤ£ت½£¬0-ةد´«¸ّ½âآëح¨µہ£¬1-ةد´«¸ّدشت¾ح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEM_ABILITY[] struSubSystemAbility;
            public byte by485Nums;//485´®؟ع¸ِت‎
            public byte by232Nums;//232´®؟ع¸ِت‎
            public byte bySerieStartChan;//ئًت¼ح¨µہ
            public byte byScreenMode;//´َئءؤ£ت½£¬0-ض÷ئءسة؟ح»§¶ث·ضإن£¬1-ض÷ئءسةةè±¸¶ث·ضإن
            public byte byDevVersion;//ةè±¸°و±¾£¬0-B10/B11/B12£¬1-B20
            public byte bySupportBaseMapNums;//ثùض§³ضµؤµ×ح¼ت‎£¬µ×ح¼؛إ´س1؟ھت¼
            public ushort wBaseLengthX;//أ؟¸ِئء´َذ،µؤ»ù×¼ضµ£¬B20ت¹سأ
            public ushort wBaseLengthY;
            public byte bySupportPictureTrans;  //تا·ٌض§³ضح¼ئ¬»طدش£¬0-²»ض§³ض£¬1-ض§³ض	
            public byte bySupportPreAllocDec;   //تا·ٌض§³ضضاؤـ½âآë×تش´ش¤·ضإن£¬0-²»ض§³ض£¬1-ض§³ض
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLESCREENCFG
        {
            public byte byScreenSeq;//ئءؤ»ذٍ؛إ£¬0xff±يت¾²»سأ´ثئء,64-T½âآëئ÷µعز»¸ِ±يت¾ض÷ئء
            public byte bySubSystemNum;//½âآë×سدµح³²غخ»؛إ,½âآëئ÷´ثضµأ»سذسأ
            public byte byDispNum;//½âآë×سدµح³ةد¶شس¦دشت¾ح¨µہ؛إ£¬64-T½âآëئ÷ضذ¸أضµ±يت¾½âآëئ÷µؤدشت¾ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG
        {
            public uint dwSize;
            public byte byEnable;//´َئءئ´½ست¹ؤـ£¬0-²»ت¹ؤـ£¬1-ت¹ؤـ
            public byte byModeX;/*´َئءئ´½سؤ£ت½*/
            public byte byModeY;
            public byte byMainDecodeSystem;//×غ؛دئ½ج¨µؤ½âآë°هضذ¸أضµ±يت¾ض÷ئء²غخ»؛إ£¬64-T½âآëئ÷ضذ¸أضµ±يت¾½âآëح¨µہ؛إ
            public byte byMainDecoderDispChan;//ض÷ئءثùسأدشت¾ح¨µہ؛إ£¬1.1netra°و±¾ذآشِ£¬netra½âآëئ÷سذء½¸ِدشت¾ح¨µہ£¬¶¼ؤـ¹»×÷خھض÷ئء،£64-Tضذ¸أضµخقذ§
            public byte byVideoStandard;      //´َئءأ؟¸ِ×سئءضئت½دàح¬ 1:NTSC,2:PAL
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwResolution;         //´َئءأ؟¸ِ×سئء·ض±وآتدàح¬
            //´َئءئ´½س´سئءؤ»ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BIGSCREENNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLESCREENCFG[] struFollowSingleScreen;
            //ئًت¼×ّ±ê±طذëخھ»ù×¼×ّ±êµؤصûت‎±¶
            public ushort wBigScreenX; //´َئءشعµçتسا½ضذئًت¼X×ّ±ê
            public ushort wBigScreenY; //´َئءشعµçتسا½ضذئًت¼Y×ّ±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byRes1 = new byte [ 2 ];
                struFollowSingleScreen = new NET_DVR_SINGLESCREENCFG [ MAX_BIGSCREENNUM ];
                byRes2 = new byte [ 12 ];
            }
        }

        /************************************تسئµ×غ؛دئ½ج¨(end)***************************************/

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_EMAILCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sPassWord;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sFromName;/* Sender *///×ض·û´®ضذµؤµعز»¸ِ×ض·û؛ح×î؛َز»¸ِ×ض·û²»ؤـتا"@",²¢از×ض·û´®ضذزھسذ"@"×ض·û
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sFromAddr;/* Sender address */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName1;/* Receiver1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName2;/* Receiver2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr1;/* Receiver address1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr2;/* Receiver address2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sEmailServer;/* Email server address */
            public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTP،­*/
            public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
            public byte byAttachment;/* enable attachment */
            public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_NEW
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struLowCompression;//¶¨ت±آ¼دٌ
            public NET_DVR_COMPRESSION_INFO_EX struEventCompression;//تآ¼‏´¥·¢آ¼دٌ
        }

        //اٍ»ْخ»ضأذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZPOS
        {
            public ushort wAction;//»ٌب،ت±¸أ×ض¶خخقذ§
            public ushort wPanPos;//ث®ئ½²خت‎
            public ushort wTiltPos;//´¹ض±²خت‎
            public ushort wZoomPos;//±ن±¶²خت‎
        }

        //اٍ»ْ·¶خ§ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZSCOPE
        {
            public ushort wPanPosMin;//ث®ئ½²خت‎min
            public ushort wPanPosMax;//ث®ئ½²خت‎max
            public ushort wTiltPosMin;//´¹ض±²خت‎min
            public ushort wTiltPosMax;//´¹ض±²خت‎max
            public ushort wZoomPosMin;//±ن±¶²خت‎min
            public ushort wZoomPosMax;//±ن±¶²خت‎max
        }

        //rtspإنضأ ipcamera×¨سأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RTSPCFG
        {
            public uint dwSize;//³¤¶ب
            public ushort wPort;//rtsp·‏خٌئ÷صىج‎¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;//ش¤ءô
        }

        /********************************½س؟ع²خت‎½ل¹¹(begin)*********************************/

        //NET_DVR_Login()²خت‎½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ذٍءذ؛إ
            public byte byAlarmInPortNum;//DVR±¨¾¯تنبë¸ِت‎
            public byte byAlarmOutPortNum;//DVR±¨¾¯تن³ِ¸ِت‎
            public byte byDiskNum;//DVRس²إج¸ِت‎
            public byte byDVRType;//DVRہàذح, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR ح¨µہ¸ِت‎
            public byte byStartChan;//ئًت¼ح¨µہ؛إ,ہ‎بçDVS-1,DVR - 1
        }

        //NET_DVR_Login_V30()²خت‎½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;  //ذٍءذ؛إ
            public byte byAlarmInPortNum;		        //±¨¾¯تنبë¸ِت‎
            public byte byAlarmOutPortNum;		        //±¨¾¯تن³ِ¸ِت‎
            public byte byDiskNum;				    //س²إج¸ِت‎
            public byte byDVRType;				    //ةè±¸ہàذح, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				    //ؤ£ؤâح¨µہ¸ِت‎
            public byte byStartChan;			        //ئًت¼ح¨µہ؛إ,ہ‎بçDVS-1,DVR - 1
            public byte byAudioChanNum;                //سïزôح¨µہت‎
            public byte byIPChanNum;					//×î´َت‎×ضح¨µہ¸ِت‎£¬µحخ»  
            public byte byZeroChanNum;			//ءمح¨µہ±àآë¸ِت‎ //2010-01-16
            public byte byMainProto;			//ض÷آëء÷´«تنذ­زéہàذح 0-private, 1-rtsp,2-ح¬ت±ض§³ضprivate؛حrtsp
            public byte bySubProto;				//×سآëء÷´«تنذ­زéہàذح0-private, 1-rtsp,2-ح¬ت±ض§³ضprivate؛حrtsp
            public byte bySupport;        //ؤـء¦£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض£¬
                                          //bySupport & 0x1, ±يت¾تا·ٌض§³ضضاؤـثرث÷
                                          //bySupport & 0x2, ±يت¾تا·ٌض§³ض±¸·ف
                                          //bySupport & 0x4, ±يت¾تا·ٌض§³ضر¹ثُ²خت‎ؤـء¦»ٌب،
                                          //bySupport & 0x8, ±يت¾تا·ٌض§³ض¶àحّ؟¨
                                          //bySupport & 0x10, ±يت¾ض§³ضش¶³جSADP
                                          //bySupport & 0x20, ±يت¾ض§³ضRaid؟¨¹¦ؤـ
                                          //bySupport & 0x40, ±يت¾ض§³ضIPSAN ؤ؟آ¼²éصز
                                          //bySupport & 0x80, ±يت¾ض§³ضrtp over rtsp
            public byte bySupport1;        // ؤـء¦¼¯ہ©³ن£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض
                                           //bySupport1 & 0x1, ±يت¾تا·ٌض§³ضsnmp v30
                                           //bySupport1 & 0x2, ض§³ضاّ·ض»ط·إ؛حدآشط
                                           //bySupport1 & 0x4, تا·ٌض§³ض²¼·ہسإدب¼¶	
                                           //bySupport1 & 0x8, ضاؤـةè±¸تا·ٌض§³ض²¼·ہت±¼ن¶خہ©ص¹
                                           //bySupport1 & 0x10, ±يت¾تا·ٌض§³ض¶à´إإجت‎£¨³¬¹‎33¸ِ£©
                                           //bySupport1 & 0x20, ±يت¾تا·ٌض§³ضrtsp over http	
                                           //bySupport1 & 0x80, ±يت¾تا·ٌض§³ض³µإئذآ±¨¾¯ذإد¢2012-9-28, از»¹±يت¾تا·ٌض§³ضNET_DVR_IPPARACFG_V40½ل¹¹جه
            public byte bySupport2; /*ؤـء¦£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬·ا0±يت¾ض§³ض							
							bySupport2 & 0x1, ±يت¾½âآëئ÷تا·ٌض§³ضح¨¹‎URLب،ء÷½âآë
							bySupport2 & 0x2,  ±يت¾ض§³ضFTPV40
							bySupport2 & 0x4,  ±يت¾ض§³ضANR
							bySupport2 & 0x8,  ±يت¾ض§³ضCCDµؤح¨µہ²خت‎إنضأ
							bySupport2 & 0x10,  ±يت¾ض§³ض²¼·ہ±¨¾¯»ط´«ذإد¢£¨½ِض§³ض×¥إؤ»ْ±¨¾¯ ذآہد±¨¾¯½ل¹¹£©
							bySupport2 & 0x20,  ±يت¾تا·ٌض§³ضµ¥¶ہ»ٌب،ةè±¸×´ج¬×سدî
							bySupport2 & 0x40,  ±يت¾تا·ٌتاآëء÷¼سأـةè±¸*/
            public ushort wDevType;              //ةè±¸ذح؛إ
            public byte bySupport3; //ؤـء¦¼¯ہ©ص¹£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض
                                    //bySupport3 & 0x1, ±يت¾تا·ٌ¶àآëء÷
                                    // bySupport3 & 0x4 ±يت¾ض§³ض°´×éإنضأ£¬ ¾كجه°ü؛¬ ح¨µہح¼دٌ²خت‎،¢±¨¾¯تنبë²خت‎،¢IP±¨¾¯تنبë،¢تن³ِ½سبë²خت‎،¢
                                    // سأ»§²خت‎،¢ةè±¸¹¤×÷×´ج¬،¢JPEG×¥ح¼،¢¶¨ت±؛حت±¼ن×¥ح¼،¢س²إجإج×é¹ـہي 
                                    //bySupport3 & 0x8خھ1 ±يت¾ض§³ضت¹سأTCPش¤ہہ،¢UDPش¤ہہ،¢¶à²¥ش¤ہہضذµؤ"رست±ش¤ہہ"×ض¶خہ´اëاَرست±ش¤ہہ£¨؛َذّ¶¼½«ت¹سأصâضض·½ت½اëاَرست±ش¤ہہ£©،£¶ّµ±bySupport3 & 0x8خھ0ت±£¬½«ت¹سأ "ث½سذرست±ش¤ہہ"ذ­زé،£
                                    //bySupport3 & 0x10 ±يت¾ض§³ض"»ٌب،±¨¾¯ض÷»ْض÷زھ×´ج¬£¨V40£©"،£
                                    //bySupport3 & 0x20 ±يت¾تا·ٌض§³ضح¨¹‎DDNSسٍأû½âخِب،ء÷

            public byte byMultiStreamProto;//تا·ٌض§³ض¶àآëء÷,°´خ»±يت¾,0-²»ض§³ض,1-ض§³ض,bit1-آëء÷3,bit2-آëء÷4,bit7-ض÷آëء÷£¬bit-8×سآëء÷
            public byte byStartDChan;		//ئًت¼ت‎×ضح¨µہ؛إ,0±يت¾خقذ§
            public byte byStartDTalkChan;	//ئًت¼ت‎×ض¶ش½²ح¨µہ؛إ£¬اّ±ًسعؤ£ؤâ¶ش½²ح¨µہ؛إ£¬0±يت¾خقذ§
            public byte byHighDChanNum;		//ت‎×ضح¨µہ¸ِت‎£¬¸كخ»
            public byte bySupport4;
            public byte byLanguageType;// ض§³ضسïضضؤـء¦,°´خ»±يت¾,أ؟ز»خ»0-²»ض§³ض,1-ض§³ض  
                                       //  byLanguageType µبسع0 ±يت¾ ہدةè±¸
                                       //  byLanguageType & 0x1±يت¾ض§³ضضذخؤ
                                       //  byLanguageType & 0x2±يت¾ض§³ضس¢خؤ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		//±£ءô
        }

        //sdkحّآç»·¾³أ¶¾ظ±نء؟£¬سأسعش¶³جة‎¼¶
        public enum SDK_NETWORK_ENVIRONMENT
        {
            LOCAL_AREA_NETWORK = 0,
            WIDE_AREA_NETWORK,
        }

        //دشت¾ؤ£ت½
        public enum DISPLAY_MODE
        {
            NORMALMODE = 0,
            OVERLAYMODE
        }

        //·¢ثحؤ£ت½
        public enum SEND_MODE
        {
            PTOPTCPMODE = 0,
            PTOPUDPMODE,
            MULTIMODE,
            RTPMODE,
            RESERVEDMODE
        }

        //×¥ح¼ؤ£ت½
        public enum CAPTURE_MODE
        {
            BMP_MODE = 0,		//BMPؤ£ت½
            JPEG_MODE = 1		//JPEGؤ£ت½ 
        }

        //تµت±ةùزôؤ£ت½
        public enum REALSOUND_MODE
        {
            MONOPOLIZE_MODE = 1,//¶ہص¼ؤ£ت½
            SHARE_MODE = 2		//¹²ديؤ£ت½
        }

        public struct NET_DVR_CLIENTINFO
        {
            public Int32 lChannel;//ح¨µہ؛إ
            public Int32 lLinkMode;//×î¸كخ»(31)خھ0±يت¾ض÷آëء÷£¬خھ1±يت¾×سآëء÷£¬0£­30خ»±يت¾آëء÷ء¬½س·½ت½: 0£؛TCP·½ت½,1£؛UDP·½ت½,2£؛¶à²¥·½ت½,3 - RTP·½ت½£¬4-زôتسئµ·ض؟ھ(TCP)
            public IntPtr hPlayWnd;//²¥·إ´°؟عµؤ¾ن±ْ,خھNULL±يت¾²»²¥·إح¼دَ
            public string sMultiCastIP;//¶à²¥×éµطض·
        }

        //SDK×´ج¬ذإد¢(9000ذآشِ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKSTATE
        {
            public uint dwTotalLoginNum;//µ±ا°loginسأ»§ت‎
            public uint dwTotalRealPlayNum;//µ±ا°realplayآ·ت‎
            public uint dwTotalPlayBackNum;//µ±ا°»ط·إ»ٍدآشطآ·ت‎
            public uint dwTotalAlarmChanNum;//µ±ا°½¨ء¢±¨¾¯ح¨µہآ·ت‎
            public uint dwTotalFormatNum;//µ±ا°س²إج¸ٌت½»¯آ·ت‎
            public uint dwTotalFileSearchNum;//µ±ا°بصض¾»ٍخؤ¼‏ثرث÷آ·ت‎
            public uint dwTotalLogSearchNum;//µ±ا°بصض¾»ٍخؤ¼‏ثرث÷آ·ت‎
            public uint dwTotalSerialNum;//µ±ا°ح¸أ÷ح¨µہآ·ت‎
            public uint dwTotalUpgradeNum;//µ±ا°ة‎¼¶آ·ت‎
            public uint dwTotalVoiceComNum;//µ±ا°سïزô×ھ·¢آ·ت‎
            public uint dwTotalBroadCastNum;//µ±ا°سïزô¹م²¥آ·ت‎
            public uint dwTotalListenNum;	    //µ±ا°حّآç¼àج‎آ·ت‎
            public uint dwEmailTestNum;       //µ±ا°ست¼‏¼ئت‎آ·ت‎
            public uint dwBackupNum;          // µ±ا°خؤ¼‏±¸·فآ·ت‎
            public uint dwTotalInquestUploadNum; //µ±ا°ةَر¶ةد´«آ·ت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //SDK¹¦ؤـض§³ضذإد¢(9000ذآشِ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKABL
        {
            public uint dwMaxLoginNum;//×î´َloginسأ»§ت‎ MAX_LOGIN_USERS
            public uint dwMaxRealPlayNum;//×î´َrealplayآ·ت‎ WATCH_NUM
            public uint dwMaxPlayBackNum;//×î´َ»ط·إ»ٍدآشطآ·ت‎ WATCH_NUM
            public uint dwMaxAlarmChanNum;//×î´َ½¨ء¢±¨¾¯ح¨µہآ·ت‎ ALARM_NUM
            public uint dwMaxFormatNum;//×î´َس²إج¸ٌت½»¯آ·ت‎ SERVER_NUM
            public uint dwMaxFileSearchNum;//×î´َخؤ¼‏ثرث÷آ·ت‎ SERVER_NUM
            public uint dwMaxLogSearchNum;//×î´َبصض¾ثرث÷آ·ت‎ SERVER_NUM
            public uint dwMaxSerialNum;//×î´َح¸أ÷ح¨µہآ·ت‎ SERVER_NUM
            public uint dwMaxUpgradeNum;//×î´َة‎¼¶آ·ت‎ SERVER_NUM
            public uint dwMaxVoiceComNum;//×î´َسïزô×ھ·¢آ·ت‎ SERVER_NUM
            public uint dwMaxBroadCastNum;//×î´َسïزô¹م²¥آ·ت‎ MAX_CASTNUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //±¨¾¯ةè±¸ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ALARMER
        {
            public byte byUserIDValid;/* useridتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte bySerialValid;/* ذٍءذ؛إتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte byVersionValid;/* °و±¾؛إتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte byDeviceNameValid;/* ةè±¸أû×ضتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte byMacAddrValid; /* MACµطض·تا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte byLinkPortValid;/* login¶ث؟عتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte byDeviceIPValid;/* ةè±¸IPتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public byte bySocketIPValid;/* socket ipتا·ٌسذذ§ 0-خقذ§£¬1-سذذ§ */
            public int lUserID; /* NET_DVR_Login()·µ»طضµ, ²¼·ہت±سذذ§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;/* ذٍءذ؛إ */
            public uint dwDeviceVersion;/* °و±¾ذإد¢ ¸ك16خ»±يت¾ض÷°و±¾£¬µح16خ»±يت¾´خ°و±¾*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sDeviceName;/* ةè±¸أû×ض */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;/* MACµطض· */
            public ushort wLinkPort; /* link port */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sDeviceIP;/* IPµطض· */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sSocketIP;/* ±¨¾¯ض÷¶¯ةد´«ت±µؤsocket IPµطض· */
            public byte byIpProtocol; /* Ipذ­زé 0-IPV4, 1-IPV6 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //س²½âآëدشت¾اّسٍ²خت‎(×س½ل¹¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_PARA
        {
            public int bToScreen;
            public int bToVideoOut;
            public int nLeft;
            public int nTop;
            public int nWidth;
            public int nHeight;
            public int nReserved;
        }

        //س²½âآëش¤ہہ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARDINFO
        {
            public int lChannel;//ح¨µہ؛إ
            public int lLinkMode;//×î¸كخ»(31)خھ0±يت¾ض÷آëء÷£¬خھ1±يت¾×س£¬0£­30خ»±يت¾آëء÷ء¬½س·½ت½:0£؛TCP·½ت½,1£؛UDP·½ت½,2£؛¶à²¥·½ت½,3 - RTP·½ت½£¬4-µç»°دك£¬5£­128k؟ي´ّ£¬6£­256k؟ي´ّ£¬7£­384k؟ي´ّ£¬8£­512k؟ي´ّ£»
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string sMultiCastIP;
            public NET_DVR_DISPLAY_PARA struDisplayPara;
        }

        //آ¼دَخؤ¼‏²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FIND_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//خؤ¼‏أû
            public NET_DVR_TIME struStartTime;//خؤ¼‏µؤ؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//خؤ¼‏µؤ½لتّت±¼ن
            public uint dwFileSize;//خؤ¼‏µؤ´َذ،
        }

        //آ¼دَخؤ¼‏²خت‎(9000)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//خؤ¼‏أû
            public NET_DVR_TIME struStartTime;//خؤ¼‏µؤ؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//خؤ¼‏µؤ½لتّت±¼ن
            public uint dwFileSize;//خؤ¼‏µؤ´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000ةè±¸ض§³ض,1±يت¾´ثخؤ¼‏زر¾­±»ثّ¶¨,0±يت¾ص‎³£µؤخؤ¼‏
            public byte byFileType;  //خؤ¼‏ہàذح:0£­¶¨ت±آ¼دٌ,1-زئ¶¯صى²â £¬2£­±¨¾¯´¥·¢£¬
            //3-±¨¾¯|زئ¶¯صى²â 4-±¨¾¯&زئ¶¯صى²â 5-أüءî´¥·¢ 6-تض¶¯آ¼دٌ,7£­صً¶¯±¨¾¯£¬8-»·¾³±¨¾¯£¬9-ضاؤـ±¨¾¯£¬10-PIR±¨¾¯£¬11-خقدك±¨¾¯£¬12-؛ô¾ب±¨¾¯,14-ضاؤـ½»ح¨تآ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //آ¼دَخؤ¼‏²خت‎(cvr)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//خؤ¼‏أû
            public NET_DVR_TIME struStartTime;//خؤ¼‏µؤ؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//خؤ¼‏µؤ½لتّت±¼ن
            public uint dwFileSize;//خؤ¼‏µؤ´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000ةè±¸ض§³ض,1±يت¾´ثخؤ¼‏زر¾­±»ثّ¶¨,0±يت¾ص‎³£µؤخؤ¼‏
            public byte byFileType;  //خؤ¼‏ہàذح:0£­¶¨ت±آ¼دٌ,1-زئ¶¯صى²â £¬2£­±¨¾¯´¥·¢£¬
                                     //3-±¨¾¯|زئ¶¯صى²â 4-±¨¾¯&زئ¶¯صى²â 5-أüءî´¥·¢ 6-تض¶¯آ¼دٌ,7£­صً¶¯±¨¾¯£¬8-»·¾³±¨¾¯£¬9-ضاؤـ±¨¾¯£¬10-PIR±¨¾¯£¬11-خقدك±¨¾¯£¬12-؛ô¾ب±¨¾¯,14-ضاؤـ½»ح¨تآ¼‏
            public byte byQuickSearch; //0:ئصح¨²éر¯½ل¹û£¬1£؛؟ىثظ£¨بصہْ£©²éر¯½ل¹û
            public byte byRes;
            public uint dwFileIndex; //خؤ¼‏ث÷ز‎؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //آ¼دَخؤ¼‏²خت‎(´ّ؟¨؛إ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_CARD
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//خؤ¼‏أû
            public NET_DVR_TIME struStartTime;//خؤ¼‏µؤ؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//خؤ¼‏µؤ½لتّت±¼ن
            public uint dwFileSize;//خؤ¼‏µؤ´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
        }

        //آ¼دَخؤ¼‏²éصزجُ¼‏½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND
        {
            public int lChannel;//ح¨µہ؛إ
            public uint dwFileType;//آ¼دَخؤ¼‏ہàذح0xff£­ب«²؟£¬0£­¶¨ت±آ¼دٌ,1-زئ¶¯صى²â £¬2£­±¨¾¯´¥·¢£¬
            //3-±¨¾¯|زئ¶¯صى²â 4-±¨¾¯&زئ¶¯صى²â 5-أüءî´¥·¢ 6-تض¶¯آ¼دٌ
            public uint dwIsLocked;//تا·ٌثّ¶¨ 0-ص‎³£خؤ¼‏,1-ثّ¶¨خؤ¼‏, 0xff±يت¾ثùسذخؤ¼‏
            public uint dwUseCardNo;//تا·ٌت¹سأ؟¨؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;//؟¨؛إ
            public NET_DVR_TIME struStartTime;//؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//½لتّت±¼ن
        }

        //شئج¨اّسٍر،شٌ·إ´َثُذ،(HIK ؟ىاٍ×¨سأ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POINT_FRAME
        {
            public int xTop;//·½؟ٍئًت¼µمµؤx×ّ±ê
            public int yTop;//·½؟ٍ½لتّµمµؤy×ّ±ê
            public int xBottom;//·½؟ٍ½لتّµمµؤx×ّ±ê
            public int yBottom;//·½؟ٍ½لتّµمµؤy×ّ±ê
            public int bCounter;//±£ءô
        }

        //سïزô¶ش½²²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_AUDIO
        {
            public byte byAudioEncType;//زôئµ±àآëہàذح 0-G722; 1-G711
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎ 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_AP_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sSsid;
            public uint dwMode;/* 0 mange ؤ£ت½;1 ad-hocؤ£ت½£¬²خ¼ûNICMODE */
            public uint dwSecurity;  /*0 ²»¼سأـ£»1 wep¼سأـ£»2 wpa-psk;3 wpa-Enterprise£¬²خ¼ûWIFISECURITY*/
            public uint dwChannel;/*1-11±يت¾11¸ِح¨µہ*/
            public uint dwSignalStrength;/*0-100ذإ؛إسة×îبُ±نخھ×îا؟*/
            public uint dwSpeed;/*ثظآت,µ¥خ»تا0.01mbps*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AP_INFO_LIST
        {
            public uint dwSize;
            public uint dwCount;/*خقدكAPت‎ء؟£¬²»³¬¹‎20*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = WIFI_MAX_AP_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AP_INFO[] struApInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFIETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpAddress;/*IPµطض·*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpMask;/*رعآë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/*خïہيµطض·£¬ض»سأہ´دشت¾*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes;
            public uint dwEnableDhcp;/*تا·ٌئô¶¯dhcp  0²»ئô¶¯ 1ئô¶¯*/
            public uint dwAutoDns;/*بç¹ûئô¶¯dhcpتا·ٌ×ش¶¯»ٌب،dns,0²»×ش¶¯»ٌب، 1×ش¶¯»ٌب،£»¶شسعسذدكبç¹ûئô¶¯dhcpؤ؟ا°×ش¶¯»ٌب،dns*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDns; /*µعز»¸ِdnsسٍأû*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDns;/*µع¶‏¸ِdnsسٍأû*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIpAddr;/* حّ¹طµطض·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TTLS
        {
            public byte byEapolVersion; //EAPOL°و±¾£¬0-°و±¾1£¬1-°و±¾2
            public byte byAuthType; //ؤع²؟بدض¤·½ت½£¬0-PAP£¬1-MSCHAPV2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //ؤنأûةي·ف
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //سأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //أـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterprisؤ£ت½تتسأ

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_PEAP
        {
            public byte byEapolVersion; //EAPOL°و±¾£¬0-°و±¾1£¬1-°و±¾2
            public byte byAuthType; //ؤع²؟بدض¤·½ت½£¬0-GTC£¬1-MD5£¬2-MSCHAPV2
            public byte byPeapVersion; //PEAP°و±¾£¬0-°و±¾0£¬1-°و±¾1
            public byte byPeapLabel; //PEAP±êا©£¬0-ہد±êا©£¬1-ذآ±êا©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //ؤنأûةي·ف
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //سأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //أـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterprisؤ£ت½تتسأ

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TLS
        {
            public byte byEapolVersion; //EAPOL°و±¾£¬0-°و±¾1£¬1-°و±¾2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIdentity; //ةي·ف
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivateKeyPswd; //ث½ش؟أـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct WIFI_AUTH_PARAM
        {
            [FieldOffsetAttribute(0)]
            public UNION_EAP_TTLS EAP_TTLS;//WPA-enterprise/WPA2-enterprisؤ£ت½تتسأ

            [FieldOffsetAttribute(0)]
            public UNION_EAP_PEAP EAP_PEAP; //WPA-enterprise/WPA2-enterprisؤ£ت½تتسأ

            [FieldOffsetAttribute(0)]
            public UNION_EAP_TLS EAP_TLS;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WEP
        {
            public uint dwAuthentication;/*0 -؟ھ·إت½ 1-¹²ديت½*/
            public uint dwKeyLength;/* 0 -64خ»£»1- 128خ»£»2-152خ»*/
            public uint dwKeyType;/*0 16½ّضئ;1 ASCI */
            public uint dwActive;/*0 ث÷ز‎£؛0---3±يت¾سأؤؤز»¸ِأـش؟*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WEP_MAX_KEY_COUNT * WIFI_WEP_MAX_KEY_LENGTH)]
            public string sKeyInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_PSK
        {
            public uint dwKeyLength;/*8-63¸ِASCII×ض·û*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WPA_PSK_MAX_KEY_LENGTH)]
            public string sKeyInfo;
            public byte byEncryptType;/*WPA/WPA2ؤ£ت½دآ¼سأـہàذح,0-AES, 1-TKIP*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_WPA2
        {
            public byte byEncryptType;  /*¼سأـہàذح,0-AES, 1-TKIP*/
            public byte byAuthType; //بدض¤ہàذح£¬0-EAP_TTLS,1-EAP_PEAP,2-EAP_TLS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public WIFI_AUTH_PARAM auth_param;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFI_CFG_EX
        {
            public NET_DVR_WIFIETHERNET struEtherNet;/*wifiحّ؟ع*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sEssid;/*SSID*/
            public uint dwMode;/* 0 mange ؤ£ت½;1 ad-hocؤ£ت½£¬²خ¼û*/
            public uint dwSecurity;/*0 ²»¼سأـ£»1 wep¼سأـ£»2 wpa-psk; */
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct key
            {
                [FieldOffsetAttribute(0)]
                public UNION_WEP wep;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_PSK wpa_psk;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_WPA2 wpa_wpa2;//WPA-enterprise/WPA2-enterprisؤ£ت½تتسأ
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CFG
        {
            public uint dwSize;
            public NET_DVR_WIFI_CFG_EX struWifiCfg;
        }

        //wifiء¬½س×´ج¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CONNECT_STATUS
        {
            public uint dwSize;
            public byte byCurStatus;	//1-زرء¬½س£¬2-خ´ء¬½س£¬3-ص‎شعء¬½س
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		//±£ءô
            public uint dwErrorCode;	// byCurStatus = 2ت±سذذ§,1-سأ»§أû»ٍأـآë´يخَ,2-خق´ثآ·سةئ÷,3-خ´ضھ´يخَ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_WORKMODE
        {
            public uint dwSize;
            public uint dwNetworkInterfaceMode;/*0 ×ش¶¯اذ»»ؤ£ت½،،1 سذدكؤ£ت½*/
        }

        //ضاؤـ؟طضئذإد¢
        public const int MAX_VCA_CHAN = 16;//×î´َضاؤـح¨µہت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLINFO
        {
            public byte byVCAEnable;//تا·ٌ؟ھئôضاؤـ
            public byte byVCAType;//ضاؤـؤـء¦ہàذح£¬VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA;//آëء÷ضذتا·ٌ´ّضاؤـذإد¢
            public byte byMode;//ؤ£ت½£¬VCA_CHAN_MODE_TYPE ,atmؤـء¦µؤت±؛ٍذèزھإنضأ
            public byte byControlType;   //؟طضئہàذح£¬°´خ»±يت¾£¬0-·ٌ£¬1-تا
            // byControlType &1 تا·ٌئôسأ×¥إؤ¹¦ؤـ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ةèضأخھ0 
        }

        //ضاؤـ؟طضئذإد¢½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_CTRLINFO[] struCtrlInfo;//؟طضئذإد¢,ت‎×é0¶شس¦ةè±¸µؤئًت¼ح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ضاؤـةè±¸ؤـء¦¼¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_ABILITY
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public byte byVCAChanNum;//ضاؤـح¨µہ¸ِت‎
            public byte byPlateChanNum;//³µإئح¨µہ¸ِت‎
            public byte byBBaseChanNum;//ذذخھ»ù±¾°و¸ِت‎
            public byte byBAdvanceChanNum;//ذذخھ¸ك¼¶°و¸ِت‎
            public byte byBFullChanNum;//ذذخھحêصû°و¸ِت‎
            public byte byATMChanNum;//ضاؤـATM¸ِت‎
            public byte byPDCChanNum;         //بثت‎ح³¼ئح¨µہ¸ِت‎
            public byte byITSChanNum;         //½»ح¨تآ¼‏ح¨µہ¸ِت‎
            public byte byBPrisonChanNum;     //ذذخھ¼àسü°و(¼àةل)ح¨µہ¸ِت‎
            public byte byFSnapChanNum;       //بثء³×¥إؤح¨µہ¸ِت‎
            public byte byFSnapRecogChanNum;  //بثء³×¥إؤ؛حت¶±ًح¨µہ¸ِت‎
            public byte byFRetrievalChanNum;  //بثء³؛َ¼ىث÷¸ِت‎
            public byte bySupport;            //ؤـء¦£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض
            //bySupport & 0x1£¬±يت¾تا·ٌض§³ضضاؤـ¸ْ×ظ 2012-3-22
            //bySupport & 0x2£¬±يت¾تا·ٌض§³ض128آ·ب،ء÷ہ©ص¹2012-12-27
            public byte byFRecogChanNum;      //بثء³ت¶±ًح¨µہ¸ِت‎
            public byte byBPPerimeterChanNum; //ذذخھ¼àسü°و(ضـ½ç)ح¨µہ¸ِت‎
            public byte byTPSChanNum;         //½»ح¨سصµ¼ح¨µہ¸ِت‎
            public byte byTFSChanNum;         //µہآ·خ¥صآب،ض¤ح¨µہ¸ِت‎
            public byte byFSnapBFullChanNum;  //بثء³×¥إؤ؛حذذخھ·ضخِح¨µہ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ذذخھ·ضخِؤـء¦ہàذح
        public enum VCA_ABILITY_TYPE : uint
        {
            TRAVERSE_PLANE_ABILITY = 0x01,       //´©ش½¾¯½نأو
            ENTER_AREA_ABILITY = 0x02,       //½ّبëاّسٍ
            EXIT_AREA_ABILITY = 0x04,       //ہë؟ھاّسٍ
            INTRUSION_ABILITY = 0x08,       //بëاض
            LOITER_ABILITY = 0x10,       //إا»²
            LEFT_TAKE_ABILITY = 0x20,       //خïئ·زإءôؤأب،
            PARKING_ABILITY = 0x40,       //ح£³µ
            RUN_ABILITY = 0x80,       //؟ىثظزئ¶¯
            HIGH_DENSITY_ABILITY = 0x100,      //بثش±¾غ¼¯
            LF_TRACK_ABILITY = 0x200,      //اٍ»ْ¸ْ×ظ
            VIOLENT_MOTION_ABILITY = 0x400,      //¾çءزشث¶¯¼ى²â
            REACH_HIGHT_ABILITY = 0x800,      //إت¸ك¼ى²â
            GET_UP_ABILITY = 0x1000,     //ئًةي¼ى²â
            LEFT_ABILITY = 0x2000,     //خïئ·زإءô
            TAKE_ABILITY = 0x4000,     //خïئ·ؤأب،
            LEAVE_POSITION = 0x8000,     //ہë¸ع
            TRAIL_ABILITY = 0x10000,    //خ²ثو 
            KEY_PERSON_GET_UP_ABILITY = 0x20000,    //ضطµمبثش±ئًةي¼ى²â
            FALL_DOWN_ABILITY = 0x80000,    //µ¹µط
            AUDIO_ABNORMAL_ABILITY = 0x100000,   //ةùا؟ح»±ن
            ADV_REACH_HEIGHT_ABILITY = 0x200000,   //صغدكإت¸ك
            TOILET_TARRY_ABILITY = 0x400000,   //بç²ق³¬ت±
            YARD_TARRY_ABILITY = 0x800000,   //·إ·ç³،ضحءô
            ADV_TRAVERSE_PLANE_ABILITY = 0x1000000,  //صغدك¾¯½نأو
            HUMAN_ENTER_ABILITY = 0x10000000, //بث؟؟½üATM ,ض»شعATM_PANELؤ£ت½دآض§³ض
            OVER_TIME_ABILITY = 0x20000000, //²ظ×÷³¬ت±,ض»شعATM_PANELؤ£ت½دآض§³ض
            STICK_UP_ABILITY = 0x40000000, //جùض½جُ
            INSTALL_SCANNER_ABILITY = 0x80000000  //°²×°¶ء؟¨ئ÷
        }

        //ضاؤـح¨µہہàذح
        public enum VCA_CHAN_ABILITY_TYPE
        {
            VCA_BEHAVIOR_BASE = 1,          //ذذخھ·ضخِ»ù±¾°و
            VCA_BEHAVIOR_ADVANCE = 2,          //ذذخھ·ضخِ¸ك¼¶°و
            VCA_BEHAVIOR_FULL = 3,          //ذذخھ·ضخِحêصû°و
            VCA_PLATE = 4,          //³µإئؤـء¦
            VCA_ATM = 5,          //ATMؤـء¦
            VCA_PDC = 6,          //بثء÷ء؟ح³¼ئ
            VCA_ITS = 7,          //ضاؤـ ½»ح¨تآ¼‏
            VCA_BEHAVIOR_PRISON = 8,          //ذذخھ·ضخِ¼àسü°و(¼àةل) 
            VCA_FACE_SNAP = 9,           //بثء³×¥إؤؤـء¦
            VCA_FACE_SNAPRECOG = 10,          //بثء³×¥إؤ؛حت¶±ًؤـء¦
            VCA_FACE_RETRIEVAL = 11,          //بثء³؛َ¼ىث÷ؤـء¦
            VCA_FACE_RECOG = 12,          //بثء³ت¶±ًؤـء¦
            VCA_BEHAVIOR_PRISON_PERIMETER = 13, // ذذخھ·ضخِ¼àسü°و (ضـ½ç)
            VCA_TPS = 14,          //½»ح¨سصµ¼
            VCA_TFS = 15,          //µہآ·خ¥صآب،ض¤
            VCA_BEHAVIOR_FACESNAP = 16           //بثء³×¥إؤ؛حذذخھ·ضخِؤـء¦
        }

        //ضاؤـATMؤ£ت½ہàذح(ATMؤـء¦جطسذ)
        public enum VCA_CHAN_MODE_TYPE
        {
            VCA_ATM_PANEL = 0,//ATMأو°ه
            VCA_ATM_SURROUND = 1,//ATM»·¾³
            VCA_ATM_FACE = 2	//ATMبثء³
        }
        public enum TFS_CHAN_MODE_TYPE
        {
            TFS_CITYROAD = 0,  //TFS ³اتذµہآ·
            TFS_FREEWAY = 1   //TFS ¸كثظµہآ·
        }

        //ذذخھ·ضخِ³،¾°ؤ£ت½
        public enum BEHAVIOR_SCENE_MODE_TYPE
        {
            BEHAVIOR_SCENE_DEFAULT = 0, //دµح³ؤ¬بد
            BEHAVIOR_SCENE_WALL = 1,    //خ§ا½
            BEHAVIOR_SCENE_INDOOR = 2   //تزؤع
        }

        //ح¨µہؤـء¦تنبë²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CHAN_IN_PARAM
        {
            public byte byVCAType;//VCA_CHAN_ABILITY_TYPEأ¶¾ظضµ
            public byte byMode;//ؤ£ت½£¬VCA_CHAN_MODE_TYPE ,atmؤـء¦µؤت±؛ٍذèزھإنضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ةèضأخھ0 
        }

        //ذذخھؤـء¦¼¯½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BEHAVIOR_ABILITY
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public uint dwAbilityType;//ض§³ضµؤؤـء¦ہàذح£¬°´خ»±يت¾£¬¼ûVCA_ABILITY_TYPE¶¨زه
            public byte byMaxRuleNum;//×î´َ¹وشٍت‎
            public byte byMaxTargetNum;//×î´َؤ؟±êت‎
            public byte bySupport;		// ض§³ضµؤ¹¦ؤـہàذح   °´خ»±يت¾  
            // bySupport & 0x01 ض§³ض±ê¶¨¹¦ؤـ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô£¬ةèضأخھ0
        }

        // ½»ح¨ؤـء¦¼¯½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_ABILITY
        {
            public uint dwSize;             // ½ل¹¹جه´َذ،
            public uint dwAbilityType;      // ض§³ضµؤؤـء¦ءذ±ي  ²خصصITS_ABILITY_TYPE
            public byte byMaxRuleNum;	 	//×î´َ¹وشٍت‎
            public byte byMaxTargetNum; 	//×î´َؤ؟±êت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ±£ءô
        }
        /***********************************end*******************************************/

        /************************************ضاؤـ²خت‎½ل¹¹*********************************/
        //ضاؤـ¹²سأ½ل¹¹
        //×ّ±êضµ¹éز»»¯,¸،µمت‎ضµخھµ±ا°»­أوµؤ°ظ·ض±ب´َذ،, ¾«¶بخھذ،ت‎µم؛َب‎خ»
        //µم×ّ±ê½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POINT
        {
            public float fX;// Xضل×ّ±ê, 0.001~1
            public float fY;//Yضل×ّ±ê, 0.001~1
        }

        //اّسٍ؟ٍ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RECT
        {
            public float fX;//±ك½ç؟ٍ×َةد½اµمµؤXضل×ّ±ê, 0.001~1
            public float fY;//±ك½ç؟ٍ×َةد½اµمµؤYضل×ّ±ê, 0.001~1
            public float fWidth;//±ك½ç؟ٍµؤ؟ي¶ب, 0.001~1
            public float fHeight;//±ك½ç؟ٍµؤ¸ك¶ب, 0.001~1
        }

        //ذذخھ·ضخِتآ¼‏ہàذح
        public enum VCA_EVENT_TYPE : uint
        {
            VCA_TRAVERSE_PLANE = 0x1,        //´©ش½¾¯½نأو
            VCA_ENTER_AREA = 0x2,        //ؤ؟±ê½ّبëاّسٍ,ض§³ضاّسٍ¹وشٍ
            VCA_EXIT_AREA = 0x4,        //ؤ؟±êہë؟ھاّسٍ,ض§³ضاّسٍ¹وشٍ
            VCA_INTRUSION = 0x8,        //ضـ½çبëاض,ض§³ضاّسٍ¹وشٍ
            VCA_LOITER = 0x10,       //إا»²,ض§³ضاّسٍ¹وشٍ
            VCA_LEFT_TAKE = 0x20,       //خïئ·زإءôؤأب،,ض§³ضاّسٍ¹وشٍ
            VCA_PARKING = 0x40,       //ح£³µ,ض§³ضاّسٍ¹وشٍ
            VCA_RUN = 0x80,       //؟ىثظزئ¶¯,ض§³ضاّسٍ¹وشٍ
            VCA_HIGH_DENSITY = 0x100,      //اّسٍؤعبثش±¾غ¼¯,ض§³ضاّسٍ¹وشٍ
            VCA_VIOLENT_MOTION = 0x200,		 //¾çءزشث¶¯¼ى²â
            VCA_REACH_HIGHT = 0x400,		 //إت¸ك¼ى²â
            VCA_GET_UP = 0x800,	     //ئًةي¼ى²â
            VCA_LEFT = 0x1000,     //خïئ·زإءô
            VCA_TAKE = 0x2000,     //خïئ·ؤأب،
            VCA_LEAVE_POSITION = 0x4000,     //ہë¸ع
            VCA_TRAIL = 0x8000,     //خ²ثو
            VCA_KEY_PERSON_GET_UP = 0x10000,    //ضطµمبثش±ئًةي¼ى²â
            VCA_FALL_DOWN = 0x80000,    //µ¹µط¼ى²â
            VCA_AUDIO_ABNORMAL = 0x100000,   //ةùا؟ح»±ن¼ى²â
            VCA_ADV_REACH_HEIGHT = 0x200000,   //صغدكإت¸ك
            VCA_TOILET_TARRY = 0x400000,   //بç²ق³¬ت±
            VCA_YARD_TARRY = 0x800000,   //·إ·ç³،ضحءô
            VCA_ADV_TRAVERSE_PLANE = 0x1000000,  //صغدك¾¯½نأو
            VCA_HUMAN_ENTER = 0x10000000, //بث؟؟½üATM           ض»شعATM_PANELؤ£ت½دآض§³ض
            VCA_OVER_TIME = 0x20000000, //²ظ×÷³¬ت±            ض»شعATM_PANELؤ£ت½دآض§³ض
            VCA_STICK_UP = 0x40000000, //جùض½جُ,ض§³ضاّسٍ¹وشٍ
            VCA_INSTALL_SCANNER = 0x80000000  //°²×°¶ء؟¨ئ÷,ض§³ضاّسٍ¹وشٍ
        }

        //ذذخھ·ضخِتآ¼‏ہàذحہ©ص¹
        public enum VCA_RULE_EVENT_TYPE_EX : ushort
        {
            ENUM_VCA_EVENT_TRAVERSE_PLANE = 1,   //´©ش½¾¯½نأو
            ENUM_VCA_EVENT_ENTER_AREA = 2,   //ؤ؟±ê½ّبëاّسٍ,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_EXIT_AREA = 3,   //ؤ؟±êہë؟ھاّسٍ,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_INTRUSION = 4,   //ضـ½çبëاض,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_LOITER = 5,   //إا»²,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_LEFT_TAKE = 6,   //خïئ·زإءôؤأب،,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_PARKING = 7,   //ح£³µ,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_RUN = 8,   //؟ىثظزئ¶¯,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_HIGH_DENSITY = 9,   //اّسٍؤعبثش±¾غ¼¯,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_VIOLENT_MOTION = 10,  //¾çءزشث¶¯¼ى²â
            ENUM_VCA_EVENT_REACH_HIGHT = 11,  //إت¸ك¼ى²â
            ENUM_VCA_EVENT_GET_UP = 12,  //ئًةي¼ى²â
            ENUM_VCA_EVENT_LEFT = 13,  //خïئ·زإءô
            ENUM_VCA_EVENT_TAKE = 14,  //خïئ·ؤأب،
            ENUM_VCA_EVENT_LEAVE_POSITION = 15,  //ہë¸ع
            ENUM_VCA_EVENT_TRAIL = 16,  //خ²ثو
            ENUM_VCA_EVENT_KEY_PERSON_GET_UP = 17,  //ضطµمبثش±ئًةي¼ى²â
            ENUM_VCA_EVENT_FALL_DOWN = 20,  //µ¹µط¼ى²â
            ENUM_VCA_EVENT_AUDIO_ABNORMAL = 21,  //ةùا؟ح»±ن¼ى²â
            ENUM_VCA_EVENT_ADV_REACH_HEIGHT = 22,  //صغدكإت¸ك
            ENUM_VCA_EVENT_TOILET_TARRY = 23,  //بç²ق³¬ت±
            ENUM_VCA_EVENT_YARD_TARRY = 24,  //·إ·ç³،ضحءô
            ENUM_VCA_EVENT_ADV_TRAVERSE_PLANE = 25,  //صغدك¾¯½نأو
            ENUM_VCA_EVENT_HUMAN_ENTER = 29,  //بث؟؟½üATM,ض»شعATM_PANELؤ£ت½دآض§³ض   
            ENUM_VCA_EVENT_OVER_TIME = 30,  //²ظ×÷³¬ت±,ض»شعATM_PANELؤ£ت½دآض§³ض
            ENUM_VCA_EVENT_STICK_UP = 31,  //جùض½جُ,ض§³ضاّسٍ¹وشٍ
            ENUM_VCA_EVENT_INSTALL_SCANNER = 32   //°²×°¶ء؟¨ئ÷,ض§³ضاّسٍ¹وشٍ
        }

        //¾¯½نأو´©ش½·½دٍہàذح
        public enum VCA_CROSS_DIRECTION
        {
            VCA_BOTH_DIRECTION,// ث«دٍ 
            VCA_LEFT_GO_RIGHT,// سة×َضءسز 
            VCA_RIGHT_GO_LEFT,// سةسزضء×َ 
        }

        //دك½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE
        {
            public NET_VCA_POINT struStart;//ئًµم 
            public NET_VCA_POINT struEnd; //ضصµم

            //             public void init()
            //             {
            //                 struStart = new NET_VCA_POINT();
            //                 struEnd = new NET_VCA_POINT();
            //             }
        }

        //¸أ½ل¹¹»لµ¼ضآxaml½çأو³ِ²»ہ´£،£،£،£،£،£،£،£،£،£؟£؟ختجâشفت±»¹أ»سذصزµ½  
        //شفت±ئء±خ½ل¹¹دب
        //¶à±كذح½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POLYGON
        {
            /// DWORD->unsigned int
            public uint dwPointNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = VCA_MAX_POLYGON_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPos;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAVERSE_PLANE
        {
            public NET_VCA_LINE struPlaneBottom;//¾¯½نأوµ×±ك
            public VCA_CROSS_DIRECTION dwCrossDirection;//´©ش½·½دٍ: 0-ث«دٍ£¬1-´س×َµ½سز£¬2-´سسزµ½×َ
            public byte byRes1;//±£ءô
            public byte byPlaneHeight;//¾¯½نأو¸ك¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            //             public void init()
            //             {
            //                 struPlaneBottom = new NET_VCA_LINE();
            //                 struPlaneBottom.init();
            //                 byRes2 = new byte[38];
            //             }
        }

        //½ّبë/ہë؟ھاّسٍ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AREA
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¸ù¾ف±¨¾¯رس³ظت±¼نہ´±êت¶±¨¾¯ضذ´ّح¼ئ¬£¬±¨¾¯¼ن¸ô؛حIO±¨¾¯ز»ضآ£¬1أë·¢ثحز»¸ِ،£
        //بëاض²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_INTRUSION
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;//±¨¾¯رس³ظت±¼ن: 1-120أë£¬½¨زé5أë£¬إذ¶دتاسذذ§±¨¾¯µؤت±¼ن
            public byte bySensitivity;        //ءéأô¶ب²خت‎£¬·¶خ§[1-100]
            public byte byRate;               //ص¼±ب£؛اّسٍؤعثùسذخ´±¨¾¯ؤ؟±ê³ك´çؤ؟±êص¼اّسٍأو»‎µؤ±بضط£¬¹éز»»¯خھ£­£»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //إا»²²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LOITER
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;//´¥·¢إا»²±¨¾¯µؤ³ضذّت±¼ن£؛1-120أë£¬½¨زé10أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶ھ°ü/¼ٌ°ü²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE_LEFT
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;//´¥·¢¶ھ°ü/¼ٌ°ü±¨¾¯µؤ³ضذّت±¼ن£؛1-120أë£¬½¨زé10أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ح£³µ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PARKING
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;//´¥·¢ح£³µ±¨¾¯³ضذّت±¼ن£؛1-120أë£¬½¨زé10أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±¼إـ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RUN
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public float fRunDistance;//بث±¼إـ×î´َ¾àہë, ·¶خ§: [0.1, 1.00]
            public byte byRes1;             // ±£ءô×ض½ع
            public byte byMode;             // 0 دٌثطؤ£ت½  1 تµ¼تؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //بثش±¾غ¼¯²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HIGH_DENSITY
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public float fDensity;//أـ¶ب±بآت, ·¶خ§: [0.1, 1.0]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public ushort wDuration;      // ´¥·¢بثش±¾غ¼¯²خت‎±¨¾¯مذضµ 20-360s
        }

        //¾çءزشث¶¯²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_VIOLENT_MOTION
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;           //´¥·¢¾çءزشث¶¯±¨¾¯مذضµ£؛1-50أë
            public byte bySensitivity;       //ءéأô¶ب²خت‎£¬·¶خ§[1,5]
            public byte byMode;              //0-´؟تسئµؤ£ت½£¬1-زôتسئµءھ؛دؤ£ت½£¬2-´؟زôئµؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //±£ءô
        }

        //إت¸ك²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REACH_HIGHT
        {
            public NET_VCA_LINE struVcaLine;   //إت¸ك¾¯½نأو
            public ushort wDuration; //´¥·¢إت¸ك±¨¾¯مذضµ£؛1-120أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // ±£ءô×ض½ع
        }

        //ئً´²²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_GET_UP
        {
            public NET_VCA_POLYGON struRegion; //اّسٍ·¶خ§
            public ushort wDuration;	        //´¥·¢ئً´²±¨¾¯مذضµ1-100 أë
            public byte byMode;             //ئًةي¼ى²âؤ£ت½,0-´َ´²ح¨ئجؤ£ت½,1-¸كµحئجؤ£ت½,2-´َ´²ح¨ئج×ّء¢ئًةيؤ£ت½
            public byte bySensitivity;      //ءéأô¶ب²خت‎£¬·¶خ§[1,10]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //±£ءô×ض½ع
        }

        //خïئ·زإءô
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEFT
        {
            public NET_VCA_POLYGON struRegion; // اّسٍ·¶خ§
            public ushort wDuration;       // ´¥·¢خïئ·زإءô±¨¾¯مذضµ 10-100أë
            public byte bySensitivity;   // ءéأô¶ب²خت‎£¬·¶خ§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        // ±£ءô×ض½ع
        }

        // خïئ·ؤأب،
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE
        {
            public NET_VCA_POLYGON struRegion;     // اّسٍ·¶خ§
            public ushort wDuration;      // ´¥·¢خïئ·ؤأب،±¨¾¯مذضµ10-100أë
            public byte bySensitivity;  // ءéأô¶ب²خت‎£¬·¶خ§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_OVER_TIME
        {
            public NET_VCA_POLYGON struRegion;    // اّسٍ·¶خ§
            public ushort wDuration;  // ²ظ×÷±¨¾¯ت±¼نمذضµ 4s-60000s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ENTER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;			//±£ءô×ض½ع
        }

        //جùض½جُ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_STICK_UP
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;//±¨¾¯³ضذّت±¼ن£؛10-60أë£¬½¨زé10أë
            public byte bySensitivity;//ءéأô¶ب²خت‎£¬·¶خ§[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶ء؟¨ئ÷²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SCANNER
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;//¶ء؟¨³ضذّت±¼ن£؛10-60أë
            public byte bySensitivity;//ءéأô¶ب²خت‎£¬·¶خ§[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ہë¸عتآ¼‏
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEAVE_POSITION
        {
            public NET_VCA_POLYGON struRegion; //اّسٍ·¶خ§
            public ushort wLeaveDelay;  //خقبث±¨¾¯ت±¼ن£¬µ¥خ»£؛s£¬ب،ضµ1-1800
            public ushort wStaticDelay; //ث¯¾ُ±¨¾¯ت±¼ن£¬µ¥خ»£؛s£¬ب،ضµ1-1800
            public byte byMode;       //ؤ£ت½£¬0-ہë¸عتآ¼‏£¬1-ث¯¸عتآ¼‏£¬2-ہë¸عث¯¸عتآ¼‏
            public byte byPersonType; //ضµ¸عبثت‎ہàذح£¬0-µ¥بثضµ¸ع£¬1-ث«بثضµ¸ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£ءô
        }

        //خ²ثو²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAIL
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wRes;      /* ±£ءô */
            public byte bySensitivity;       /* ءéأô¶ب²خت‎£¬·¶خ§[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ¹µط²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FALL_DOWN
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDuration;      /* ´¥·¢تآ¼‏مذضµ 1-60s*/
            public byte bySensitivity;       /* ءéأô¶ب²خت‎£¬·¶خ§[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ةùا؟ح»±ن²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AUDIO_ABNORMAL
        {
            public ushort wDecibel;       //ةùزôا؟¶ب
            public byte bySensitivity;  //ءéأô¶ب²خت‎£¬·¶خ§[1,5] 
            public byte byAudioMode;    //ةùزô¼ى²âؤ£ت½£¬0-ءéأô¶ب¼ى²â£¬1-·ض±´مذضµ¼ى²â£¬2-ءéأô¶بسë·ض±´مذضµ¼ى²â 
            public byte byEnable;       //ت¹ؤـ£¬تا·ٌ؟ھئô
            public byte byThreshold;    //ةùزôمذضµ[0,100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±£ءô   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_EXCEPTION
        {
            public uint dwSize;
            public byte byEnableAudioInException;  //ت¹ؤـ£¬تا·ٌ؟ھئô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmSched; //²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V40 struHandleException;  //زى³£´¦ہي·½ت½
            public uint dwMaxRelRecordChanNum;  //±¨¾¯´¥·¢µؤآ¼دَح¨µہ ت‎£¨ض»¶ء£©×î´َض§³ضت‎ء؟
            public uint dwRelRecordChanNum;     //±¨¾¯´¥·¢µؤآ¼دَح¨µہ ت‎ تµ¼تض§³ضµؤت‎ء؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byRelRecordChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TOILET_TARRY
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDelay;        //بç²ق³¬ت±ت±¼ن[1,3600]£¬µ¥خ»£؛أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_YARD_TARRY
        {
            public NET_VCA_POLYGON struRegion;//اّسٍ·¶خ§
            public ushort wDelay;        //·إ·ç³،ضحءôت±¼ن[1,120]£¬µ¥خ»£؛أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_REACH_HEIGHT
        {
            public NET_VCA_POLYGON struRegion; //إت¸كصغدك
            public uint dwCrossDirection;   //؟çش½·½دٍ(دê¼ûVCA_CROSS_DIRECTION): 0-ث«دٍ£¬1-´س×َµ½سز2-´سسزµ½×َ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_TRAVERSE_PLANE
        {
            public NET_VCA_POLYGON struRegion; //¾¯½نأوصغدك
            public uint dwCrossDirection;   //؟çش½·½دٍ(دê¼ûVCA_CROSS_DIRECTION): 0-ث«دٍ£¬1-´س×َµ½سز2-´سسزµ½×َ
            public byte bySensitivity;      //ءéأô¶ب²خت‎£¬·¶خ§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //±£ءô×ض½ع
        }

        //¾¯½نتآ¼‏²خت‎
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;//²خت‎

            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TRAVERSE_PLANE struTraversePlane;//´©ش½¾¯½نأو²خت‎ 
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_AREA struArea;//½ّبë/ہë؟ھاّسٍ²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_INTRUSION struIntrusion;//بëاض²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LOITER struLoiter;//إا»²²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TAKE_LEFT struTakeTeft;//¶ھ°ü/¼ٌ°ü²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_PARKING struParking;//ح£³µ²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_RUN struRun;//±¼إـ²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_HIGH_DENSITY struHighDensity;//بثش±¾غ¼¯²خت‎  
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_VIOLENT_MOTION struViolentMotion;	//¾çءزشث¶¯
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_REACH_HIGHT struReachHight;      //إت¸ك
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_GET_UP struGetUp;           //ئً´²
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LEFT struLeft;            //خïئ·زإءô
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TAKE struTake;            // خïئ·ؤأب،
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_HUMAN_ENTER struHumanEnter;      //بثش±½ّبë
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_OVER_TIME struOvertime;        //²ظ×÷³¬ت±
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_STICK_UP struStickUp;//جùض½جُ
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_SCANNER struScanner;//¶ء؟¨ئ÷²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_LEAVE_POSITION struLeavePos;        //ہë¸ع²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TRAIL struTrail;           //خ²ثو²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_FALL_DOWN struFallDown;        //µ¹µط²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;   //ةùا؟ح»±ن
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_ADV_REACH_HEIGHT struReachHeight;     //صغدكإت¸ك²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_TOILET_TARRY struToiletTarry;     //بç²ق³¬ت±²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_YARD_TARRY struYardTarry;       //·إ·ç³،ضحءô²خت‎
            //[FieldOffsetAttribute(0)]
            //public NET_VCA_ADV_TRAVERSE_PLANE struAdvTraversePlane;//صغدك¾¯½نأو²خت‎            
        }

        // ³ك´ç¹‎آثئ÷ہàذح
        public enum SIZE_FILTER_MODE
        {
            IMAGE_PIX_MODE,//¸ù¾فدٌثط´َذ،ةèضأ
            REAL_WORLD_MODE,//¸ù¾فتµ¼ت´َذ،ةèضأ
            DEFAULT_MODE 	// ؤ¬بدؤ£ت½
        }

        //³ك´ç¹‎آثئ÷
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SIZE_FILTER
        {
            public byte byActive;//تا·ٌ¼¤»î³ك´ç¹‎آثئ÷ 0-·ٌ ·ا0-تا
            public byte byMode;//¹‎آثئ÷ؤ£ت½SIZE_FILTER_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ضأ0
            public NET_VCA_RECT struMiniRect;//×îذ،ؤ؟±ê؟ٍ,ب«0±يت¾²»ةèضأ
            public NET_VCA_RECT struMaxRect;//×î´َؤ؟±ê؟ٍ,ب«0±يت¾²»ةèضأ
        }

        //¾¯½ن¹وشٍ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE
        {
            public byte byActive;//تا·ٌ¼¤»î¹وشٍ,0-·ٌ,·ا0-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ةèضأخھ0×ض¶خ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹وشٍأû³ئ
            public VCA_EVENT_TYPE dwEventType;//ذذخھ·ضخِتآ¼‏ہàذح
            public NET_VCA_EVENT_UNION uEventParam;//ذذخھ·ضخِتآ¼‏²خت‎
            public NET_VCA_SIZE_FILTER struSizeFilter;//³ك´ç¹‎آثئ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//´¦ہي·½ت½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
        }

        //ذذخھ·ضخِإنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public byte byPicProType;//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPictureParam;//ح¼ئ¬¹و¸ٌ½ل¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE[] struRule;//¹وشٍت‎×é
        }

        //³ك´ç¹‎آث²كآش
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FILTER_STRATEGY
        {
            public byte byStrategy;      //³ك´ç¹‎آث²كآش 0 - ²»ئôسأ 1-¸ك¶ب؛ح؟ي¶ب¹‎آث,2-أو»‎¹‎آث
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //±£ءô
        }

        //¹وشٍ´¥·¢²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_TRIGGER_PARAM
        {
            public byte byTriggerMode;   //¹وشٍµؤ´¥·¢·½ت½£¬0- ²»ئôسأ£¬1- ¹ى¼£µم 2- ؤ؟±êأو»‎ 
            public byte byTriggerPoint;  //´¥·¢µم£¬´¥·¢·½ت½خھ¹ى¼£µمت±سذذ§ 0- ضذ,1-ةد,2-دآ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //±£ءô
            public float fTriggerArea;    //´¥·¢ؤ؟±êأو»‎°ظ·ض±ب [0,100]£¬´¥·¢·½ت½خھؤ؟±êأو»‎ت±سذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //±£ءô
        }

        //¾¯½ن¹وشٍ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE_V41
        {
            public byte byActive; //تا·ٌ¼¤»î¹وشٍ,0-·ٌ,·ا0-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£ءô£¬ةèضأخھ0×ض¶خ
            public ushort wEventTypeEx; //ذذخھتآ¼‏ہàذحہ©ص¹£¬سأسع´ْجو×ض¶خdwEventType£¬²خ؟¼VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //¹وشٍأû³ئ
            public VCA_EVENT_TYPE dwEventType;	//ذذخھتآ¼‏ہàذح£¬±£ءôتاخھءث¼وبف£¬؛َذّ½¨زéت¹سأwEventTypeEx»ٌب،تآ¼‏ہàذح
            public NET_VCA_EVENT_UNION uEventParam; //ذذخھ·ضخِتآ¼‏²خت‎
            public NET_VCA_SIZE_FILTER struSizeFilter;  //³ك´ç¹‎آثئ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//´¦ہي·½ت½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            public ushort wAlarmDelay; //ضاؤـ±¨¾¯رست±£¬0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£ءô
            public NET_VCA_FILTER_STRATEGY struFilterStrategy; //³ك´ç¹‎آث²كآش
            public NET_VCA_RULE_TRIGGER_PARAM struTriggerParam;   //¹وشٍ´¥·¢²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ذذخھ·ضخِإنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG_V41
        {
            public uint dwSize;			//½ل¹¹³¤¶ب
            public byte byPicProType;	//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            public byte byUpLastAlarm; //2011-04-06 تا·ٌدبةد´«×î½üز»´خµؤ±¨¾¯
            public byte byPicRecordEnable;  /*2012-3-1تا·ٌئôسأح¼ئ¬´و´¢, 0-²»ئôسأ, 1-ئôسأ*/
            public byte byRes1;
            public NET_DVR_JPEGPARA struPictureParam; 		//ح¼ئ¬¹و¸ٌ½ل¹¹	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE_V41[] struRule;  //¹وشٍت‎×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¼ٍ»¯ؤ؟±ê½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TARGET_INFO
        {
            public uint dwID;//ؤ؟±êID ,بثش±أـ¶ب¹‎¸ك±¨¾¯ت±خھ0
            public NET_VCA_RECT struRect; //ؤ؟±ê±ك½ç؟ٍ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        //¼ٍ»¯µؤ¹وشٍذإد¢, °ü؛¬¹وشٍµؤ»ù±¾ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_INFO
        {
            public byte byRuleID;//¹وشٍID,0-7
            public byte byRes;//±£ءô
            public ushort wEventTypeEx;   //ذذخھتآ¼‏ہàذحہ©ص¹£¬سأسع´ْجو×ض¶خdwEventType£¬²خ؟¼VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹وشٍأû³ئ
            public VCA_EVENT_TYPE dwEventType;//¾¯½نتآ¼‏ہàذح
            public NET_VCA_EVENT_UNION uEventParam;//تآ¼‏²خت‎
        }

        //ا°¶ثةè±¸µطض·ذإد¢£¬ضاؤـ·ضخِزا±يت¾µؤتاا°¶ثةè±¸µؤµطض·ذإد¢£¬ئنثûةè±¸±يت¾±¾»ْµؤµطض·
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_INFO
        {
            public NET_DVR_IPADDR struDevIP;//ا°¶ثةè±¸µطض·£¬
            public ushort wPort;//ا°¶ثةè±¸¶ث؟ع؛إ£¬ 
            public byte byChannel;//ا°¶ثةè±¸ح¨µہ£¬
            public byte byRes;// ±£ءô×ض½ع
        }

        //ذذخھ·ضخِ½ل¹ûةد±¨½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_ALARM
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public uint dwRelativeTime;//دà¶شت±±ê
            public uint dwAbsTime;//¾ّ¶شت±±ê
            public NET_VCA_RULE_INFO struRuleInfo;//تآ¼‏¹وشٍذإد¢
            public NET_VCA_TARGET_INFO struTargetInfo;//±¨¾¯ؤ؟±êذإد¢
            public NET_VCA_DEV_INFO struDevInfo;//ا°¶ثةè±¸ذإد¢
            public uint dwPicDataLen;//·µ»طح¼ئ¬µؤ³¤¶ب خھ0±يت¾أ»سذح¼ئ¬£¬´َسع0±يت¾¸أ½ل¹¹؛َأو½ô¸ْح¼ئ¬ت‎¾ف*/
            public byte byPicType;		//  0-ئصح¨ح¼ئ¬ 1-¶ش±بح¼ئ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//±£ءô£¬ةèضأخھ0
            public IntPtr pImage;//ض¸دٍح¼ئ¬µؤض¸صë
        }

        //ذذخھ·ضخِ¹وشٍDSPذإد¢µ‏¼س½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DRAW_MODE
        {
            public uint dwSize;
            public byte byDspAddTarget;//±àآëتا·ٌµ‏¼سؤ؟±ê
            public byte byDspAddRule;//±àآëتا·ٌµ‏¼س¹وشٍ
            public byte byDspPicAddTarget;//×¥ح¼تا·ٌµ‏¼سؤ؟±ê
            public byte byDspPicAddRule;//×¥ح¼تا·ٌµ‏¼س¹وشٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //خïجهہàذح
        public enum OBJECT_TYPE_ENUM
        {
            ENUM_OBJECT_TYPE_COAT = 1  //ةدزآ
        }

        //خïجهرصة«جُ¼‏½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_COND
        {
            public uint dwChannel;   //ح¨µہ؛إ
            public uint dwObjType;   //خïجهہàذح£¬²خ¼ûOBJECT_TYPE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£ءô
        }

        //ح¼ئ¬²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIC
        {
            public byte byPicType;        //ح¼ئ¬ہàذح£¬1-jpg
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //±£ءô
            public uint dwPicWidth;       //ح¼ئ¬؟ي¶ب
            public uint dwPicHeight;      //ح¼ئ¬¸ك¶ب
            public uint dwPicDataLen;     //ح¼ئ¬ت‎¾فتµ¼ت´َذ،
            public uint dwPicDataBuffLen; //ح¼ئ¬ت‎¾ف»؛³هاّ´َذ،
            public IntPtr byPicDataBuff;    //ح¼ئ¬ت‎¾ف»؛³هاّ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //±£ءô
        }

        //رصة«ءھ؛دجه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_UNION
        {
            public NET_DVR_COLOR struColor;   //رصة«ضµ
            public NET_DVR_PIC struPicture; //ح¼ئ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£ءô
        }

        //خïجهرصة«²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR
        {
            public uint dwSize;       //½ل¹¹جه´َذ،
            public byte byEnable;     //0-²»ئôسأ£¬1-ئôسأ
            public byte byColorMode;  //ب،ة«·½ت½£¬1-رصة«ضµ£¬2-ح¼ئ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£ءô
            public NET_DVR_OBJECT_COLOR_UNION uObjColor; //خïجهرصة«ءھ؛دجه£¬ب،ضµزہہµسعب،ة«·½ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£ءô
        }

        //اّسٍہàذح
        public enum AREA_TYPE_ENUM
        {
            ENUM_OVERLAP_REGION = 1,//¹²ح¬اّسٍ
            ENUM_BED_LOCATION = 2   //´²ئجخ»ضأ
        }

        //¸¨ضْاّسٍ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA
        {
            public uint dwAreaType;   //اّسٍہàذح£¬²خ¼ûAREA_TYPE_ENUM
            public byte byEnable;     //0-²»ئôسأ£¬1-ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;     //±£ءô
            public NET_VCA_POLYGON struPolygon; //اّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£ءô
        }

        //¸¨ضْاّسٍءذ±ي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA_LIST
        {
            public uint dwSize;	// ½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AUXAREA[] struArea; //¸¨ضْاّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ±£ءô
        }

        //ح¨µہ¹¤×÷ؤ£ت½
        public enum CHAN_WORKMODE_ENUM
        {
            ENUM_CHAN_WORKMODE_INDEPENDENT = 1,  //¶ہء¢ؤ£ت½
            ENUM_CHAN_WORKMODE_MASTER = 2,      //ض÷ؤ£ت½
            ENUM_CHAN_WORKMODE_SLAVE = 3        //´سؤ£ت½
        }

        //ح¨µہ¹¤×÷ؤ£ت½²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL_WORKMODE
        {
            public uint dwSize;        //½ل¹¹جه´َذ،
            public byte byWorkMode;    //¹¤×÷ؤ£ت½£¬²خ¼ûCHAN_WORKMODE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£ءô
        }

        //ةè±¸ح¨µہ²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddress;	//ةè±¸IP»ٍسٍأû
            public ushort wDVRPort;			 	    //¶ث؟ع؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                   //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	        //ض÷»ْسأ»§أû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;       //ض÷»ْأـآë
            public uint dwChannel;                   //ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  //±£ءô
        }

        //´سح¨µہذإد¢ءھ؛دجه
        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_SLAVE_CHANNEL_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //ءھ؛دجه´َذ،
            [FieldOffsetAttribute(0)]
            public uint dwLocalChannel;    //±¾»ْح¨µہ
            [FieldOffsetAttribute(0)]
            public NET_DVR_CHANNEL struRemoteChannel; //ش¶³جح¨µہ
        }

        //´سح¨µہ²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_PARAM
        {
            public byte byChanType;   //´سح¨µہہàذح£¬1-±¾»ْح¨µہ£¬2-ش¶³جح¨µہ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£ءô
            public NET_DVR_SLAVE_CHANNEL_UNION uSlaveChannel; //´سح¨µہءھ؛دجه£¬ب،ضµزہہµسعbyChanType
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£ءô
        }


        //´سح¨µہ²خت‎إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_CFG
        {
            public uint dwSize;   //½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SLAVE_CHANNEL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SLAVE_CHANNEL_PARAM[] struChanParam;//´سح¨µہ²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
        }

        //تسئµضتء؟صï¶د¼ى²âتآ¼‏
        public enum VQD_EVENT_ENUM
        {
            ENUM_VQD_EVENT_BLUR = 1,  //ح¼دٌؤ£؛‎
            ENUM_VQD_EVENT_LUMA = 2,  //ءء¶بزى³£
            ENUM_VQD_EVENT_CHROMA = 3,  //ح¼دٌئ«ة«
            ENUM_VQD_EVENT_SNOW = 4,  //ر©»¨¸ةبإ
            ENUM_VQD_EVENT_STREAK = 5,  //جُخئ¸ةبإ
            ENUM_VQD_EVENT_FREEZE = 6,  //»­أو¶³½ل
            ENUM_VQD_EVENT_SIGNAL_LOSS = 7,  //ذإ؛إ¶ھت§
            ENUM_VQD_EVENT_PTZ = 8,  //شئج¨ت§؟ط
            ENUM_VQD_EVENT_SCNENE_CHANGE = 9,  //³،¾°ح»±ن
            ENUM_VQD_EVENT_VIDEO_ABNORMAL = 10, //تسئµزى³£
            ENUM_VQD_EVENT_VIDEO_BLOCK = 11, //تسئµصعµ²
        }

        //تسئµضتء؟صï¶دتآ¼‏جُ¼‏½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_COND
        {
            public uint dwChannel;   //ح¨µہ؛إ
            public uint dwEventType; //¼ى²âتآ¼‏ہàذح£¬²خ¼ûVQD_EVENT_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£ءô
        }

        //تسئµضتء؟صï¶دتآ¼‏²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_PARAM
        {
            public byte byThreshold;    //±¨¾¯مذضµ£¬·¶خ§[0,100]
            public byte byTriggerMode;  //1-³ضذّ´¥·¢£¬2-µ¥´خ´¥·¢
            public byte byUploadPic;    //0-²»ةد´«ح¼ئ¬£¬1-ةد´«ح¼ئ¬£¬خقآغتا·ٌةد´«ح¼ئ¬£¬تآ؛َ¶¼؟ةزش´سةè±¸»ٌب،¸أتآ¼‏ثù¶شس¦×îذآµؤز»صإ±¨¾¯ح¼ئ¬£¬²خ¼û½س؟عNET_DVR_StartDownload
            public byte byRes1;         //±£ءô
            public uint dwTimeInterval; //³ضذّ´¥·¢±¨¾¯ت±¼ن¼ن¸ô£¬·¶خ§[0,3600] µ¥خ»£؛أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //±£ءô
        }

        //تسئµضتء؟صï¶دتآ¼‏¹وشٍ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_RULE
        {
            public uint dwSize;       //½ل¹¹جه´َذ، 
            public byte byEnable;     //0-²»ئôسأ£¬1-ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£ءô
            public NET_DVR_VQD_EVENT_PARAM struEventParam; //تسئµضتء؟صï¶دتآ¼‏²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//¼ى²âت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;  //´¦ہي·½ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±¨¾¯´¥·¢µؤآ¼دَح¨µہ£؛1±يت¾´¥·¢¸أح¨µہ£»0±يت¾²»´¥·¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£ءô
        }

        //»ù×¼³،¾°²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASELINE_SCENE
        {
            public uint dwSize;     //½ل¹¹جه´َذ،
            public byte byEnable;   //0-²»ئôسأ£¬1-ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
        }

        //»ù×¼³،¾°²ظ×÷²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_BASELINE_SCENE_PARAM
        {
            public uint dwSize;     //½ل¹¹جه´َذ،
            public uint dwChannel;  //ح¨µہ؛إ
            public byte byCommand;  //²ظ×÷ہàذح£¬1-´ث×ض¶خ±£ءô£¬شف²»ت¹سأ£¬2-¸üذآ»ù×¼³،¾°
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
        }

        //تسئµضتء؟صï¶د±¨¾¯½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_ALARM
        {
            public uint dwSize;                //½ل¹¹جه´َذ،
            public uint dwRelativeTime;        //دà¶شت±±ê
            public uint dwAbsTime;	          //¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO struDevInfo; //ا°¶ثةè±¸ذإد¢ 
            public uint dwEventType;           //تآ¼‏ہàذح£¬²خ؟¼VQD_EVENT_ENUM
            public float fThreshold;            //±¨¾¯مذضµ[0.000,1.000]
            public uint dwPicDataLen;          //ح¼ئ¬³¤¶ب£¬خھ0±يت¾أ»سذح¼ئ¬
            public IntPtr pImage;               //ض¸دٍح¼ئ¬µؤض¸صë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //±£ءô
        }

        //±ê¶¨µم×س½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CB_POINT
        {
            public NET_VCA_POINT struPoint;     //±ê¶¨µم£¬ض÷ةمدٌ»ْ£¨ا¹»ْ£©
            public NET_DVR_PTZPOS struPtzPos;  //اٍ»ْتنبëµؤPTZ×ّ±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±ê¶¨²خت‎إنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CALIBRATION_PARAM
        {
            public byte byPointNum;			//سذذ§±ê¶¨µم¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint; //±ê¶¨µم×é
        }

        //اٍ»ْإنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CFG
        {
            public uint dwSize;				//½ل¹¹³¤¶ب	
            public byte byEnable;				//±ê¶¨ت¹ؤـ
            public byte byFollowChan;          // ±»؟طضئµؤ´سح¨µہ
            public byte byDomeCalibrate;			//ةèضأضاؤـ¸ْ×ظاٍ»ْ±ê¶¨£¬1ةèضأ 0²»ةèضأ 
            public byte byRes;					// ±£ءô×ض½ع
            public NET_DVR_TRACK_CALIBRATION_PARAM struCalParam; //±ê¶¨µم×é
        }

        //¸ْ×ظؤ£ت½
        public enum TRACK_MODE
        {
            MANUAL_CTRL = 0,  //تض¶¯¸ْ×ظ
            ALARM_TRACK    //±¨¾¯´¥·¢¸ْ×ظ
        }

        //تض¶¯؟طضئ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¸ْ×ظؤ£ت½½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_MODE
        {
            public uint dwSize;		//½ل¹¹³¤¶ب
            public byte byTrackMode;   //¸ْ×ظؤ£ت½
            public byte byRuleConfMode;   //¹وشٍإنضأ¸ْ×ظؤ£ت½0-±¾µطإنضأ¸ْ×ظ£¬1-ش¶³جإنضأ¸ْ×ظ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£ءô£¬ضأ0
            [StructLayout(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                public uint[] dwULen;
                [FieldOffsetAttribute(0)]
                public NET_DVR_MANUAL_CTRL_INFO struManualCtrl;//تض¶¯¸ْ×ظ½ل¹¹
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_JPEG
        {
            public byte byPicProType;	    /*±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي 1-ةد´«*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£ءô×ض½ع
            public NET_DVR_JPEGPARA struPicParam; 				/*ح¼ئ¬¹و¸ٌ½ل¹¹*/
        }

        //·ضخِزاذذخھ·ضخِ¹وشٍ½ل¹¹
        //¾¯½ن¹وشٍ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ONE_RULE
        {
            public byte byActive;/* تا·ٌ¼¤»î¹وشٍ,0-·ٌ, ·ا0-تا */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô£¬ةèضأخھ0×ض¶خ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹وشٍأû³ئ
            public VCA_EVENT_TYPE dwEventType;//ذذخھ·ضخِتآ¼‏ہàذح
            public NET_VCA_EVENT_UNION uEventParam;//ذذخھ·ضخِتآ¼‏²خت‎
            public NET_VCA_SIZE_FILTER struSizeFilter;//³ك´ç¹‎آثئ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*±£ءô£¬ةèضأخھ0*/
        }

        // ·ضخِزا¹وشٍ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_RULECFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_ONE_RULE[] struRule; //¹وشٍت‎×é
        }

        // IVMSذذخھ·ضخِإنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_BEHAVIORCFG
        {
            public uint dwSize;
            public byte byPicProType;//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;//ح¼ئ¬¹و¸ٌ½ل¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_RULECFG[] struRuleCfg;//أ؟¸ِت±¼ن¶خ¶شس¦¹وشٍ
        }

        //ضاؤـ·ضخِزاب،ء÷¼ئ»®×س½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_DEVSCHED
        {
            public NET_DVR_SCHEDTIME struTime;//ت±¼ن²خت‎
            public NET_DVR_PU_STREAM_CFG struPUStream;//ا°¶ثب،ء÷²خت‎
        }

        //ضاؤـ·ضخِزا²خت‎إنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_STREAMCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_DEVSCHED[] struDevSched;//°´ت±¼ن¶خإنضأا°¶ثب،ء÷زش¼°¹وشٍذإد¢
        }

        //ئء±خاّسٍ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION
        {
            public byte byEnable;//تا·ٌ¼¤»î, 0-·ٌ£¬·ا0-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ضأ0
            public NET_VCA_POLYGON struPolygon;//ئء±خ¶à±كذخ
        }

        //ئء±خاّسٍء´±ي½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION_LIST
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô£¬ضأ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MASK_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION[] struMask;//ئء±خاّسٍت‎×é
        }

        //ATM½ّبëاّسٍ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ENTER_REGION
        {
            public uint dwSize;
            public byte byEnable;//تا·ٌ¼¤»î£¬0-·ٌ£¬·ا0-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_POLYGON struPolygon;//½ّبëاّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //IVMSئء±خاّسٍء´±ي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_MASK_REGION_LIST
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION_LIST[] struList;
        }

        //IVMSµؤATM½ّبëاّسٍ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ENTER_REGION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ENTER_REGION[] struEnter;//½ّبëاّسٍ
        }

        // ivms ±¨¾¯ح¼ئ¬ةد´«½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ALARM_JPEG
        {
            public byte byPicProType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;
        }

        // IVMS ؛َ¼ىث÷إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_SEARCHCFG
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DEC_REMOTE_PLAY struRemotePlay;// ش¶³ج»ط·إ
            public NET_IVMS_ALARM_JPEG struAlarmJpeg;// ±¨¾¯ةد´«ح¼ئ¬إنضأ
            public NET_IVMS_RULECFG struRuleCfg;//IVMS ذذخھ¹وشٍإنضأ
        }

        /************************************end******************************************/
        //NASبدض¤إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICATION_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* سأ»§أû 32*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* أـآë 16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNT_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;   //ءھ؛دجه½ل¹¹´َذ،
            [FieldOffsetAttribute(0)]
            public NET_DVR_IDENTIFICATION_PARAM struIdentificationParam;//(SMB/CIFSت±ةْذ§)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAS_MOUNT_PARAM
        {
            public byte byMountType; //0،«±£ءô,1~NFS, 2~ SMB/CIFS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MOUNT_PARAM_UNION uMountParam;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNTMETHOD_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen; //ءھ؛دجه½ل¹¹´َذ،   
            [FieldOffsetAttribute(0)]
            public NET_DVR_NAS_MOUNT_PARAM struNasMountParam;//NAS¹زشط·½ت½ (byNetDiskTypeخھNFS(NAS)ت±ةْذ§) 
        }

        //حّآçس²إج½ل¹¹إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_NET_DISK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô
            public NET_DVR_IPADDR struNetDiskAddr;//حّآçس²إجµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDirectory;// PATHNAME_LEN = 128
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£ءô
        }

        public const int MAX_NET_DISK = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NET_DISKCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NET_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NET_DISK_INFO[] struNetDiskParam;
        }

        //تآ¼‏ہàذح
        //ض÷ہàذح
        public enum MAIN_EVENT_TYPE
        {
            EVENT_MOT_DET = 0,//زئ¶¯صى²â
            EVENT_ALARM_IN = 1,//±¨¾¯تنبë
            EVENT_VCA_BEHAVIOR = 2,//ذذخھ·ضخِ
            EVENT_INQUEST = 3,       //ةَر¶تآ¼‏
            EVENT_VCA_DETECTION = 4, //ضاؤـصى²â
            EVENT_STREAM_INFO = 100  //ء÷IDذإد¢
        }

        public const int INQUEST_START_INFO = 0x1001;      /*ر¶خت؟ھت¼ذإد¢*/
        public const int INQUEST_STOP_INFO = 0x1002;       /*ر¶ختح£ض¹ذإد¢*/
        public const int INQUEST_TAG_INFO = 0x1003;       /*ضطµم±ê¼اذإد¢*/
        public const int INQUEST_SEGMENT_INFO = 0x1004;      /*ةَر¶ئ¬¶د×´ج¬ذإد¢*/

        public enum VCA_DETECTION_MINOR_TYPE : uint
        {
            EVENT_VCA_TRAVERSE_PLANE = 1,        //ش½¾¯صى²â
            EVENT_FIELD_DETECTION,		     //اّسٍبëاضصى²â
            EVENT_AUDIO_INPUT_ALARM,      //زôئµتنبëزى³£
            EVENT_SOUND_INTENSITY_ALARM,   //ةùا؟ح»±نصى²â
            EVENT_FACE_DETECTION,             //بثء³صى²â
            EVENT_VIRTUAL_FOCUS_ALARM, /*ذé½¹صى²â*/
            EVENT_SCENE_CHANGE_ALARM, /*³،¾°±ن¸üصى²â*/
            EVENT_ALL = 0xffffffff				//±يت¾ب«²؟
        }

        //ذذخھ·ضخِض÷ہàذح¶شس¦µؤ´ثہàذح£¬ 0xffff±يت¾ب«²؟
        public enum BEHAVIOR_MINOR_TYPE
        {
            EVENT_TRAVERSE_PLANE = 0,// ´©ش½¾¯½نأو,
            EVENT_ENTER_AREA,//ؤ؟±ê½ّبëاّسٍ,ض§³ضاّسٍ¹وشٍ
            EVENT_EXIT_AREA,//ؤ؟±êہë؟ھاّسٍ,ض§³ضاّسٍ¹وشٍ
            EVENT_INTRUSION,// ضـ½çبëاض,ض§³ضاّسٍ¹وشٍ
            EVENT_LOITER,//إا»²,ض§³ضاّسٍ¹وشٍ
            EVENT_LEFT_TAKE,//¶ھ°ü¼ٌ°ü,ض§³ضاّسٍ¹وشٍ
            EVENT_PARKING,//ح£³µ,ض§³ضاّسٍ¹وشٍ
            EVENT_RUN,//±¼إـ,ض§³ضاّسٍ¹وشٍ
            EVENT_HIGH_DENSITY,//اّسٍؤعبثش±أـ¶ب,ض§³ضاّسٍ¹وشٍ
            EVENT_STICK_UP,//جùض½جُ,ض§³ضاّسٍ¹وشٍ
            EVENT_INSTALL_SCANNER,//°²×°¶ء؟¨ئ÷,ض§³ضاّسٍ¹وشٍ
            EVENT_OPERATE_OVER_TIME,        // ²ظ×÷³¬ت±
            EVENT_FACE_DETECT,              // زى³£بثء³
            EVENT_LEFT,                     // خïئ·زإءô
            EVENT_TAKE,                      // خïئ·ؤأب،
            EVENT_LEAVE_POSITION,         //ہë¸عتآ¼‏
            EVENT_TRAIL_INFO = 16,            //خ²ثو
            EVENT_FALL_DOWN_INFO = 19,                 //µ¹µط
            EVENT_OBJECT_PASTE = 20,		// زىخïص³جùاّسٍ
            EVENT_FACE_CAPTURE_INFO = 21,                //ص‎³£بثء³
            EVENT_MULTI_FACES_INFO = 22,                  //¶àصإبثء³
            EVENT_AUDIO_ABNORMAL_INFO = 23,             //ةùا؟ح»±ن
            EVENT_DETECT = 24     			   //ضاؤـصى²â
        }

        // ض÷ہàذح100£¬¶شس¦µؤذ،ہàذح
        public enum STREAM_INFO_MINOR_TYPE
        {
            EVENT_STREAM_ID = 0,				// ء÷ID
            EVENT_TIMING = 1,					// ¶¨ت±آ¼دٌ
            EVENT_MOTION_DETECT = 2,			// زئ¶¯صى²â
            EVENT_ALARM = 3,					// ±¨¾¯آ¼دٌ
            EVENT_ALARM_OR_MOTION_DETECT = 4,	// ±¨¾¯»ٍزئ¶¯صى²â
            EVENT_ALARM_AND_MOTION_DETECT = 5,	// ±¨¾¯؛حزئ¶¯صى²â
            EVENT_COMMAND_TRIGGER = 6,			// أüءî´¥·¢
            EVENT_MANNUAL = 7,					// تض¶¯آ¼دٌ
            EVENT_BACKUP_VOLUME = 8				// ´وµµ¾يآ¼دٌ
        }

        //°îإµCVR
        public const int MAX_ID_COUNT = 256;
        public const int MAX_STREAM_ID_COUNT = 1024;
        public const int STREAM_ID_LEN = 32;
        public const int PLAN_ID_LEN = 32;

        // ء÷ذإد¢ - 72×ض½ع³¤
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byID;      //IDت‎¾ف
            public uint dwChannel;                //¹طءھةè±¸ح¨µہ£¬µبسع0xffffffffت±£¬±يت¾²»¹طءھ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                //±£ءô
            public void init()
            {
                byID = new byte [ STREAM_ID_LEN ];
                byRes = new byte [ 32 ];
            }
        }

        //تآ¼‏ثرث÷جُ¼‏ 200-04-07 9000_1.1
        public const int SEARCH_EVENT_INFO_LEN = 300;

        //±¨¾¯تنبë
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInNo;//±¨¾¯تنبë؛إ£¬byAlarmInNo[0]بôضأ1شٍ±يت¾²éصزسة±¨¾¯تنبë1´¥·¢µؤتآ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byAlarmInNo = new byte [ MAX_ALARMIN_V30 ];
                byRes = new byte [ SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30 ];
            }
        }

        //±¨¾¯تنبë °´ضµ±يت¾
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
            public ushort[] wAlarmInNo;//±¨¾¯تنبë؛إ£¬byAlarmInNo[0]بôضأ1شٍ±يت¾²éصزسة±¨¾¯تنبë1´¥·¢µؤتآ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wAlarmInNo = new ushort [ 128 ];
                byRes = new byte [ 44 ];
            }
        }

        //زئ¶¯صى²â
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotDetChanNo;//زئ¶¯صى²âح¨µہ£¬byMotDetChanNo[0]بôضأ1شٍ±يت¾²éصزسةح¨µہ1·¢ةْزئ¶¯صى²â´¥·¢µؤتآ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byMotDetChanNo = new byte [ MAX_CHANNUM_V30 ];
                byRes = new byte [ SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30 ];
            }
        }

        //زئ¶¯صى²â--°´ضµ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wMotDetChanNo;//±¨¾¯تنبë؛إ£¬byAlarmInNo[0]بôضأ1شٍ±يت¾²éصزسة±¨¾¯تنبë1´¥·¢µؤتآ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wMotDetChanNo = new ushort [ 64 ];
                byRes = new byte [ 172 ];
            }
        }

        //ذذخھ·ضخِ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChanNo;//´¥·¢تآ¼‏µؤح¨µہ
            public byte byRuleID;//¹وشٍID£¬0xff±يت¾ب«²؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô

            public void init()
            {
                byChanNo = new byte [ MAX_CHANNUM_V30 ];
                byRes1 = new byte [ 235 ];
            }
        }

        //ذذخھ·ضخِ--°´ضµ·½ت½²éصز 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wChanNo;	//´¥·¢تآ¼‏µؤح¨µہ			
            public byte byRuleID;      //ذذخھ·ضخِہàذح£¬¹وشٍ0xff±يت¾ب«²؟£¬´س0؟ھت¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	 /*±£ءô*/
            public void init()
            {
                wChanNo = new ushort [ 64 ];
                byRes = new byte [ 171 ];
            }
        }

        //ةَر¶تآ¼‏ثرث÷جُ¼‏
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_PARAM
        {
            public byte byRoomIndex;    //ةَر¶تز±à؛إ,´س1؟ھت¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£ءô
            public void init()
            {
                byRes = new byte [ 299 ];
            }
        }

        //ضاؤـصى²â²éصزجُ¼‏
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;//´¥·¢ضاؤـصى²âµؤح¨µہ؛إ£¬°´ت‎×éدآ±ê±يت¾£¬byChan[0]بôضأ1شٍ±يت¾²éصزسةح¨µہ1·¢ةْزئ¶¯صى²â´¥·¢µؤتآ¼‏ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£ءô
            public void init()
            {
                byChan = new byte [ 256 ];
                byRes = new byte [ 44 ];
            }
        }

        //ضاؤـصى²â²éصزجُ¼‏ £¬ح¨µہ؛إ°´ضµ±يت¾
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30-1, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo;// ´¥·¢ح¨µہ؛إ,°´ضµ±يت¾£¬0xffffffffخقذ§£¬از؛َذّت‎¾فز²±يت¾خقذ§ضµ
            public byte byAll;//0-±يت¾²»تاب«²؟£¬1-±يت¾ب«²؟،£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 47, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                dwChanNo = new uint [ MAX_CHANNUM_V30 - 1 ];
                byRes = new byte [ 47 ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_PARAM
        {
            public NET_DVR_STREAM_INFO struIDInfo; // ء÷idذإد¢£¬72×ض½ع³¤
            public uint dwCmdType;  // حâ²؟´¥·¢ہàذح£¬NVR½سبëشئ´و´¢ت¹سأ
            public byte byBackupVolumeNum; //´وµµ¾ي؛إ£¬CVRت¹سأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 223, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                struIDInfo.init();
                byRes = new byte [ 223 ];
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYBIT struAlarmParam;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYVALUE struAlarmParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYBIT struMotionParam;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYVALUE struMotionParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYBIT struVcaParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYVALUE struVcaParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_INQUEST_PARAM struInquestParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYBIT struVCADetectByBit;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYVALUE struVCADetectByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_STREAMID_PARAM struStreamIDParam;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_PARAM
        {
            public ushort wMajorType;//0-زئ¶¯صى²â£¬1-±¨¾¯تنبë, 2-ضاؤـتآ¼‏
            public ushort wMinorType;//ثرث÷´خہàذح- ¸ù¾فض÷ہàذح±ن»¯£¬0xffff±يت¾ب«²؟
            public NET_DVR_TIME struStartTime;//ثرث÷µؤ؟ھت¼ت±¼ن£¬ح£ض¹ت±¼ن: ح¬ت±خھ(0, 0) ±يت¾´س×îشçµؤت±¼ن؟ھت¼£¬µ½×î؛َ£¬×îا°أوµؤ4000¸ِتآ¼‏
            public NET_DVR_TIME struEndTime;
            public byte byLockType;		// 0xff-ب«²؟£¬0-خ´ثّ£¬1-ثّ¶¨
            public byte byValue;			//0-°´خ»±يت¾£¬1-°´ضµ±يت¾
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
            public SEARCH_EVENT_UNION uSeniorPara;
        }

        //±¨¾¯تنبë½ل¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_RET
        {
            public uint dwAlarmInNo;//±¨¾¯تنبë؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte [ SEARCH_EVENT_INFO_LEN ];
            }
        }
        //زئ¶¯صى²â½ل¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_RET
        {
            public uint dwMotDetNo;//زئ¶¯صى²âح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte [ SEARCH_EVENT_INFO_LEN ];
            }
        }
        //ذذخھ·ضخِ½ل¹û 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_RET
        {
            public uint dwChanNo;//´¥·¢تآ¼‏µؤح¨µہ؛إ
            public byte byRuleID;//¹وشٍID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//¹وشٍأû³ئ
            public NET_VCA_EVENT_UNION uEvent;//ذذخھتآ¼‏²خت‎£¬wMinorType = VCA_EVENT_TYPE¾ِ¶¨تآ¼‏ہàذح

            public void init()
            {
                byRes1 = new byte [ 3 ];
                byRuleName = new byte [ NAME_LEN ];
            }
        }

        //ةَر¶تآ¼‏²éر¯½ل¹û 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_RET
        {
            public byte byRoomIndex;  //ةَر¶تز±à؛إ,´س1؟ھت¼
            public byte byDriveIndex; //؟جآ¼»ْ±à؛إ,´س1؟ھت¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£ءô            
            public uint dwSegmentNo;     //±¾ئ¬¶دشع±¾´خةَر¶ضذµؤذٍ؛إ,´س1؟ھت¼ 
            public ushort wSegmetSize;     //±¾ئ¬¶دµؤ´َذ،, µ¥خ»M 
            public ushort wSegmentState;   //±¾ئ¬¶د×´ج¬ 0 ؟جآ¼ص‎³££¬1 ؟جآ¼زى³££¬2 ²»؟جآ¼ةَر¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //±£ءô

            public void init()
            {
                byRes1 = new byte [ 6 ];
                byRes2 = new byte [ 288 ];
            }
        }

        //ء÷idآ¼دٌ²éر¯½ل¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_RET
        {
            public uint dwRecordType;	//آ¼دٌہàذح 0-¶¨ت±آ¼دٌ 1-زئ¶¯صى²â 2-±¨¾¯آ¼دٌ 3-±¨¾¯|زئ¶¯صى²â 4-±¨¾¯&زئ¶¯صى²â 5-أüءî´¥·¢ 6-تض¶¯آ¼دٌ 7-صً¶¯±¨¾¯ 8-»·¾³´¥·¢ 9-ضاؤـ±¨¾¯ 10-»ط´«آ¼دٌ
            public uint dwRecordLength;	//آ¼دٌ´َذ،
            public byte byLockFlag;    // ثّ¶¨±êض¾ 0£؛أ»ثّ¶¨ 1£؛ثّ¶¨
            public byte byDrawFrameType;    // 0£؛·ا³éض،آ¼دٌ 1£؛³éض،آ¼دٌ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileName; 	//خؤ¼‏أû
            public uint dwFileIndex;    		// ´وµµ¾يةدµؤخؤ¼‏ث÷ز‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes1 = new byte [ 2 ];
                byFileName = new byte [ NAME_LEN ];
                byRes = new byte [ 256 ];
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_RET
        {
            [FieldOffset(0)]
            public EVENT_ALARM_RET struAlarmRet;
            [FieldOffset(0)]
            public EVENT_MOTION_RET struMotionRet;
            [FieldOffset(0)]
            public EVENT_VCA_RET struVcaRet;
            [FieldOffset(0)]
            public EVENT_INQUEST_RET struInquestRet;
            [FieldOffset(0)]
            public EVENT_STREAMID_RET struStreamIDRet;
            public void init()
            {
                struAlarmRet = new EVENT_ALARM_RET();
                struAlarmRet.init();
                //struMotionRet = new EVENT_MOTION_RET();
                //struMotionRet.init();
            }
        }
        //²éصز·µ»ط½ل¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_RET
        {
            public ushort wMajorType;//ض÷ہàذحMA
            public ushort wMinorType;//´خہàذح
            public NET_DVR_TIME struStartTime;//تآ¼‏؟ھت¼µؤت±¼ن
            public NET_DVR_TIME struEndTime;//تآ¼‏ح£ض¹µؤت±¼ن£¬آِ³هتآ¼‏ت±؛ح؟ھت¼ت±¼نز»رù
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public SEARCH_EVENT_RET uSeniorRet;

            public void init()
            {
                byChan = new byte [ MAX_CHANNUM_V30 ];
                byRes = new byte [ 36 ];
                uSeniorRet = new SEARCH_EVENT_RET();
                uSeniorRet.init();
            }
        }

        //SDK_V35  2009-10-26

        // ±ê¶¨إنضأہàذح
        public enum tagCALIBRATE_TYPE
        {
            PDC_CALIBRATE = 0x01,  // PDC ±ê¶¨
            BEHAVIOR_OUT_CALIBRATE = 0x02, //ذذخھتزحâ³،¾°±ê¶¨  
            BEHAVIOR_IN_CALIBRATE = 0x03,    // ذذخھتزؤع³،¾°±ê¶¨ 
            ITS_CALBIRETE = 0x04      //  ½»ح¨تآ¼‏±ê¶¨
        }

        public const int MAX_RECT_NUM = 6;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECT_LIST
        {
            public byte byRectNum;    // ¾طذخ؟ٍµؤ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£ءô×ض½ع 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struVcaRect; // ×î´َخھ6¸ِRect 
        }

        // PDC ±ê¶¨²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_CALIBRATION
        {
            public NET_DVR_RECT_LIST struRectList;       // ±ê¶¨¾طذخ؟ٍءذ±ي
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£ءô×ض½ع 
        }

        // ±ê¶¨دكµؤتôذشہà±ً£¬سأہ´±يت¾µ±ا°±ê¶¨دكشعتµ¼ت±يت¾µؤتا¸ك¶بدك»¹تا³¤¶بدك،£
        public enum LINE_MODE
        {
            HEIGHT_LINE,        //¸ك¶برù±¾دك
            LENGTH_LINE        //³¤¶برù±¾دك
        }
        /*شعةèضأ±ê¶¨ذإد¢µؤت±؛ٍ£¬بç¹ûدàس¦خ»ةèضأءثت¹ؤـ£¬²¢ةèضأدà¹ط²خت‎£¬بôأ»سذةèضأت¹ؤـ£¬شٍ±ê¶¨؛َ؟ةزش»ٌب،دà¹طµؤةمدٌ»ْ²خت‎*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_PARAM
        {
            public byte byEnableHeight;     // تا·ٌت¹ؤـةèضأةمدٌ»ْ¸ك¶بدك
            public byte byEnableAngle;      // تا·ٌت¹ؤـةèضأةمدٌ»ْ¸©رِ½ا¶ب
            public byte byEnableHorizon;    // تا·ٌت¹ؤـةèضأةمدٌ»ْµطئ½دك
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£ءô×ض½ع 
            public float  fCameraHeight;    // ةمدٌ»ْ¸ك¶ب
            public float  fCameraAngle;     // ةمدٌ»ْ¸©رِ½ا¶ب
            public float  fHorizon;         // ³،¾°ضذµؤµطئ½دك
        }

        /*µ±fValue±يت¾ؤ؟±ê¸ك¶بµؤت±؛ٍ£¬struStartPoint؛حstruEndPoint·ض±ً±يت¾ؤ؟±êح·²؟µم؛ح½إ²؟µم،£
         * µ±fValue±يت¾دك¶خ³¤¶بµؤت±؛ٍ£¬struStartPoint؛حstruEndPoint·ض±ً±يت¾دك¶خئًت¼µم؛حضصµم£¬
         * mode±يت¾µ±ا°رù±¾دك±يت¾¸ك¶بدك»¹تا³¤¶بدك،£*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINE_SEGMENT
        {
            public byte byLineMode;     // ²خصص LINE_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£ءô×ض½ع 
            public NET_VCA_POINT   struStartPoint;
            public NET_VCA_POINT   struEndPoint;
            public float fValue;
        }

        public const int MAX_LINE_SEG_NUM = 8;

        /*±ê¶¨رù±¾دكؤ؟ا°ذèزھ4-8µ÷رù±¾دك£¬زش»ٌب،ةمدٌ»ْدà¹ط²خت‎*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_OUT_CALIBRATION
        {
            public uint dwLineSegNum;          // رù±¾دك¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINE_SEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LINE_SEGMENT[]  struLineSegment;    // رù±¾دك×î´َ¸ِت‎
            public NET_DVR_CAMERA_PARAM  struCameraParam;    // ةمدٌ»ْ²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*¸أ½ل¹¹جه±يت¾IASضاؤـ؟â±ê¶¨رù±¾£¬ئنضذ°üہ¨ز»¸ِؤ؟±ê؟ٍ؛حز»جُ¶شس¦µؤ¸ك¶ب±ê¶¨دك£»
         * ؤ؟±ê؟ٍخھص¾ء¢µؤبثجهحâ½س¾طذخ؟ٍ£»¸ك¶بدكرù±¾±êت¶´سبثح·¶¥µمµ½½إµمµؤ±ê¶¨دك£»سأ¹éز»»¯×ّ±ê±يت¾£»*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IN_CAL_SAMPLE
        {
            public NET_VCA_RECT struVcaRect;   // ؤ؟±ê؟ٍ
            public NET_DVR_LINE_SEGMENT struLineSegment;    // ¸ك¶ب±ê¶¨دك
        }

        public const int MAX_SAMPLE_NUM = 5;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_IN_CALIBRATION
        {
            public uint dwCalSampleNum;      //  ±ê¶¨رù±¾¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SAMPLE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IN_CAL_SAMPLE[]  struCalSample; // ±ê¶¨رù±¾×î´َ¸ِت‎
            public NET_DVR_CAMERA_PARAM    struCameraParam;    // ةمدٌ»ْ²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int CALIB_PT_NUM = 4;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_CALIBRATION
        {
            public uint dwPointNum; //±ê¶¨µمت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CALIB_PT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPoint; //ح¼دٌ×ّ±ê
            public float fWidth;
            public float fHeight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        // ±£ءô×ض½ع
        }

        // ±ê¶¨²خت‎ءھ؛دجه
        // ؛َذّµؤدà¹ط±ê¶¨²خت‎؟ةزش·إشع¸أ½ل¹¹ہïأو
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_CALIBRATION_PRARM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //ءھ؛دجه½ل¹¹´َذ،
            [FieldOffsetAttribute(0)]
            public NET_DVR_PDC_CALIBRATION struPDCCalibration;  //PDC ±ê¶¨²خت‎
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_OUT_CALIBRATION  struBehaviorOutCalibration;  //  ذذخھتزحâ³،¾°±ê¶¨  ض÷زھس¦سأسعIVSµب
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_IN_CALIBRATION  struBehaviorInCalibration;     // ذذخھتزؤع³،¾°±ê¶¨£¬ض÷زھس¦سأIASµب 
            [FieldOffsetAttribute(0)]
            public NET_DVR_ITS_CALIBRATION struITSCalibration;
        }

        // ±ê¶¨إنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CALIBRATION_CFG
        {
            public uint dwSize;               //±ê¶¨½ل¹¹´َذ،
            public byte byEnable;           // تا·ٌئôسأ±ê¶¨
            public byte byCalibrationType;    // ±ê¶¨ہàذح ¸ù¾ف²»ح¬ہàذحشعءھ؛دجهہàر،شٌ²»ح¬µؤ±ê¶¨ ²خ؟¼CALIBRATE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_CALIBRATION_PRARM_UNION uCalibrateParam;  // ±ê¶¨²خت‎ءھ؛دجه
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ء÷ء؟ح³¼ئ·½دٍ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ENTER_DIRECTION
        {
            public NET_VCA_POINT struStartPoint; //ء÷ء؟ح³¼ئ·½دٍئًت¼µم
            public NET_VCA_POINT struEndPoint;    // ء÷ء؟ح³¼ئ·½دٍ½لتّµم 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG
        {
            public uint dwSize;              //½ل¹¹´َذ،
            public byte byEnable;             // تا·ٌ¼¤»î¹وشٍ;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±£ءô×ض½ع 
            public NET_VCA_POLYGON  struPolygon;            // ¶à±كذخ
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // ء÷ء؟½ّبë·½دٍ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG_V41
        {
            public uint dwSize;              //½ل¹¹´َذ،
            public byte byEnable;             // تا·ٌ¼¤»î¹وشٍ;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±£ءô×ض½ع 
            public NET_VCA_POLYGON struPolygon;            // ¶à±كذخ
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // ء÷ء؟½ّبë·½دٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_TIME_EX struDayStartTime; //°×جى؟ھت¼ت±¼ن£¬ت±·ضأëسذذ§
            public NET_DVR_TIME_EX struNightStartTime; //ز¹حي؟ھت¼ت±¼ن£¬ت±·ضأëسذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±£ءô×ض½ع
        }

        //تشسأ°وذإد¢½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIAL_VERSION_CFG
        {
            public uint dwSize;
            public ushort wReserveTime; //تشسأئعت£سàت±¼ن£¬0xffff±يت¾خقذ§£¬µ¥خ»£؛جى
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYN_CHANNEL_NAME_PARAM
        {
            public uint dwSize;
            public uint dwChannel; //ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RESET_COUNTER_CFG
        {
            public uint dwSize;
            public byte byEnable; //تا·ٌئôسأ£¬0-²»ئôسأ£¬1-ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TIME_EX[] struTime;//ت‎¾فاهءمت±¼ن£¬ت±·ضأëسذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_COND
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO  struStreamInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_CFG
        {
            public uint dwSize;
            public byte byVCAEnable;     //تا·ٌ؟ھئôضاؤـ
            public byte byVCAType;       //ضاؤـؤـء¦ہàذح£¬VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA; //آëء÷ضذتا·ٌ´ّضاؤـذإد¢
            public byte byMode;			//ؤ£ت½£¬ATM ؤـء¦ت±²خصصVCA_CHAN_MODE_TYPE ,TFS ؤـء¦ت±²خصص TFS_CHAN_MODE_TYPE£¬ذذخھ·ضخِحêصû°وت±²خصصBEHAVIOR_SCENE_MODE_TYPE
            public byte byControlType;   //؟طضئہàذح£¬°´خ»±يت¾£¬0-·ٌ£¬1-تا
                                         //byControlType &1 تا·ٌئôسأ×¥إؤ¹¦ؤـ
                                         //byControlType &2 تا·ٌئôسأءھ¶¯ا°¶ثةè±¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 		//±£ءô£¬ةèضأخھ0
        }

        /*ةèضأبثء÷ء؟ح³¼ئ²خت‎  ¸´سأذذخھؤع²؟¹ط¼ü×ض²خت‎
         * HUMAN_GENERATE_RATE
         * ؤ؟±êةْ³ةثظ¶ب²خت‎£¬؟طضئPDC؟âةْ³ةؤ؟±êµؤثظ¶ب،£ثظ¶بش½؟ى£¬ؤ؟±êش½بفز×ةْ³ة،£
         * µ±تنبëتسئµ¹âصصجُ¼‏½د²î£¬¶ش±ب¶ب½دµحت±£¬»ٍصكةèضأµؤ¹وشٍاّسٍ½دذ،ت±£¬س¦¼س؟ىؤ؟±êةْ³ةثظ¶ب£¬ ±ـأâؤ؟±êµؤآ©¼ى£»
         * µ±تنبëتسئµضذ¶ش±ب¶ب½د¸كت±£¬»ٍصك¹وشٍاّسٍ½د´َت±£¬س¦¸أ½µµحؤ؟±êةْ³ةثظ¶ب£¬زش¼ُةظخَ¼ى،£
         * ؤ؟±êةْ³ةثظ¶ب²خت‎¹²سذ5¼¶£¬1¼¶ثظ¶ب×îآ‎£¬5¼¶×î؟ى£¬ؤ¬بد²خت‎خھ3،£
         *
         * DETECT_SENSITIVE
         * ؤ؟±ê¼ى²âءéأô¶ب؟طضئ²خت‎£¬؟طضئPDC؟âضذز»¸ِ¾طذخاّسٍ±»¼ى²âخھؤ؟±êµؤءéأô¶ب،£
         * ءéأô¶بش½¸ك£¬¾طذخاّسٍش½بفز×±»¼ى²âخھؤ؟±ê£¬ءéأô¶بش½µحشٍش½ؤر¼ى²âخھؤ؟±ê،£
         * µ±تنبëتسئµ¹âصصجُ¼‏½د²î£¬¶ش±ب¶ب½دµحت±£¬س¦جل¸ك¼ى²âءéأô¶ب£¬ ±ـأâؤ؟±êµؤآ©¼ى£»
         * µ±تنبëتسئµضذ¶ش±ب¶ب½د¸كت±£¬س¦¸أ½µµح¼ى²âءéأô¶ب£¬زش¼ُةظخَ¼ى،£
         * ¶شس¦²خت‎¹²سذ5¼¶£¬¼¶±ً1ءéأô¶ب×îµح£¬5¼¶×î¸ك£¬ؤ¬بد¼¶±ًخھ3،£
         * 
         * TRAJECTORY_LEN
         * ¹ى¼£ةْ³ة³¤¶ب؟طضئ²خت‎£¬±يت¾ةْ³ة¹ى¼£ت±زھاَؤ؟±êµؤ×î´َخ»زئدٌثط،£
         * ¶شس¦²خت‎¹²سذ5¼¶£¬¼¶±ً1£¬ةْ³ة³¤¶ب×î³¤£¬¹ى¼£ةْ³ة×îآ‎£¬5¼¶ةْ³ة³¤¶ب×î¶ج£¬¹ى¼£ةْ³ة×î؟ى£¬ؤ¬بد¼¶±ًخھ3،£
         * 
         * TRAJECT_CNT_LEN
         * ¹ى¼£¼ئت‎³¤¶ب؟طضئ²خت‎£¬±يت¾¹ى¼£¼ئت‎ت±زھاَؤ؟±êµؤ×î´َخ»زئدٌثط،£
         * ¶شس¦²خت‎¹²سذ5¼¶£¬¼¶±ً1£¬¼ئت‎زھاَ³¤¶ب×î³¤£¬¹ى¼£¼ئت‎×îآ‎£¬5¼¶¼ئت‎زھاَ³¤¶ب×î¶ج£¬¹ى¼£¼ئت‎×î؟ى£¬ؤ¬بد¼¶±ًخھ3،£
         * 
         * PREPROCESS
         * ح¼دٌش¤´¦ہي؟طضئ²خت‎£¬0 - ²»´¦ہي£»1 - ´¦ہي،£ؤ¬بدخھ0£»
         * 
         * CAMERA_ANGLE
         * ةمدٌ»ْ½ا¶بتنبë²خت‎£¬ 0 - امذ±£» 1 - ´¹ض±،£ؤ¬بدخھ0£»
         */

        public enum PDC_PARAM_KEY
        {
            HUMAN_GENERATE_RATE = 50,  // ؤ؟±êةْ³ةثظ¶ب ´س50؟ھت¼
            DETECT_SENSITIVE = 51,  // ¼ى²âءéأô¶ب
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_INFO
        {
            public uint dwTargetID;                 // ؤ؟±êid 
            public NET_VCA_RECT struTargetRect;    // ؤ؟±ê؟ٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_IN_FRAME
        {
            public byte byTargetNum;                   //ؤ؟±ê¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] yRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PDC_TARGET_INFO[]  struTargetInfo;   //ؤ؟±êذإد¢ت‎×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  // ±£ءô×ض½ع
        }

        //µ¥ض،ح³¼ئ½ل¹ûت±ت¹سأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATFRAME
        {
            public uint dwRelativeTime;     // دà¶شت±±ê
            public uint dwAbsTime;          // ¾ّ¶شت±±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATTIME
        {
            public NET_DVR_TIME tmStart; // ح³¼ئئًت¼ت±¼ن 
            public NET_DVR_TIME tmEnd;  //  ح³¼ئ½لتّت±¼ن 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ALRAM_INFO
        {
            public uint dwSize;           // PDCبثء÷ء؟±¨¾¯ةد´«½ل¹¹جه´َذ،
            public byte byMode;            // 0 µ¥ض،ح³¼ئ½ل¹û 1×îذ،ت±¼ن¶خح³¼ئ½ل¹û  
            public byte byChannel;           // ±¨¾¯ةد´«ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;         // ±£ءô×ض½ع   
            public NET_VCA_DEV_INFO      struDevInfo;		        //ا°¶ثةè±¸ذإد¢
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uStatModeParam
            {
                [FieldOffsetAttribute(0)]
                //µ¥ض،ح³¼ئ½ل¹ûت±ت¹سأ
                public UNION_STATFRAME struStatFrame;

                [FieldOffsetAttribute(0)]
                public UNION_STATTIME struStatTime;
            }
            public uint dwLeaveNum;        // ہë؟ھبثت‎
            public uint dwEnterNum;        // ½ّبëبثت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ±£ءô×ض½ع
        }

        //بثء÷ء؟ذإد¢²éر¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_QUERY
        {
            public NET_DVR_TIME tmStart;
            public NET_DVR_TIME tmEnd;
            public uint dwLeaveNum;
            public uint dwEnterNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_POSITION
        {
            // تا·ٌئôسأ³،¾°£¬شعةèضأ³،¾°ذذخھ¹وشٍµؤت±؛ٍ¸أ×ض¶خخقذ§£¬شعةèضأاٍ»ْ±¾µطإنضأ³،¾°خ»ضأذإد¢ت±×÷خھت¹ؤـخ»
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPtzPositionName; //³،¾°خ»ضأأû³ئ
            public NET_DVR_PTZPOS struPtzPos; //ptz ×ّ±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG
        {
            public uint dwSize;             // ½ل¹¹´َذ، 
            public NET_DVR_PTZ_POSITION    struPtzPosition;    // ³،¾°خ»ضأذإد¢
            public NET_VCA_RULECFG         struVcaRuleCfg;     //ذذخھ¹وشٍإنضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG_V41
        {
            public uint dwSize;             // ½ل¹¹´َذ، 
            public NET_DVR_PTZ_POSITION  struPtzPosition;    // ³،¾°خ»ضأذإد¢
            public NET_VCA_RULECFG_V41   struVcaRuleCfg;     //ذذخھ¹وشٍإنضأ
            public byte byTrackEnable; //تا·ٌئôسأ¸ْ×ظ
            public byte byRes1;
            public ushort wTrackDuration; //¸ْ×ظ³ضذّت±¼ن£¬µ¥خ»s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIMIT_ANGLE
        {
            public byte byEnable;	// تا·ٌئôسأ³،¾°دقخ»¹¦ؤـ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_PTZPOS  struUp;     // ةددقخ»
            public NET_DVR_PTZPOS  struDown;   // دآدقخ»
            public NET_DVR_PTZPOS  struLeft;   // ×َدقخ»
            public NET_DVR_PTZPOS  struRight;  // سزدقخ»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_INDEX
        {
            public byte byIndex;    // ³،¾°ث÷ز‎
            public byte byRes1;
            public ushort wDwell;	// ح£ءôت±¼ن 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   // ±£ءô×ض½ع
        }

        public const int MAX_POSITION_NUM = 10;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_TRACK_CFG
        {
            public uint dwSize;
            public byte byNum; // ³،¾°¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_POSITION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_POSITION_INDEX[]   struPositionIndex;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ر²؛½آ·¾¶³،¾°ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_SCENE_INFO
        {
            public ushort wDwell;         // ح£ءôت±¼ن 30-300
            public byte byPositionID;   // ³،¾°؛إ1-10£¬ؤ¬بد0±يت¾¸أر²؛½µم²»جي¼س³،¾°
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //³،¾°ر²؛½¸ْ×ظإنضأذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_TRACKCFG
        {
            public uint dwSize;  // ½ل¹¹´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PATROL_SCENE_INFO[] struPatrolSceneInfo;    // ر²؛½آ·¾¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                              // ±£ءô×ض½ع
        }

        //اٍ»ْ±¾µط¹وشٍ²ثµ¥إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_PARAMCFG
        {
            public uint dwSize;             // ½ل¹¹´َذ،
            public ushort wAlarmDelayTime;    // ±¨¾¯رست±ت±¼ن£¬ؤ؟ا°اٍ»ْض»ض§³ضب«¾ضبëاض ·¶خ§1-120أë
            public ushort wTrackHoldTime;     // ±¨¾¯¸ْ×ظ³ضذّت±¼ن  ·¶خ§0-300أë
            public byte byTrackMode;        //  ²خصص IPDOME_TRACK_MODE
            public byte byPreDirection;	// ¸ْ×ظ·½دٍش¤إذ 0-²»ئôسأ 1-ئôسأ
            public byte byTrackSmooth;	    // ¸ْ×ظء¬ذّ  0-²»ئôسأ 1-ئôسأ
            public byte byZoomAdjust;	// ±¶آتدµت‎µ÷صû ²خ¼ûدآ±ي
            public byte byMaxTrackZoom;	//×î´َ¸ْ×ظ±¶آتدµت‎,0-±يت¾ؤ¬بد±¶آتدµت‎,µب¼¶6-±ê¶¨ضµ*1.0(ؤ¬بد),1-5خھثُذ،±ê¶¨ضµ£¬ضµش½ذ،£¬ثُذ،µؤ±بہ‎ش½´َ,7-15خھ·إ´َ£¬ضµش½´َ£¬·إ´َµؤ±بہ‎ش½´َ
            public byte byStopTrackWhenFindFace;  //بثء³¼ى²âµ½؛َتا·ٌح£ض¹¸ْ×ظ 0-·ٌ 1-تا
            public byte byStopTrackThreshold;   //¸ْ×ظضصض¹ئہ·ضمذضµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //  ±£ءô×ض½ع                
        }

        //اٍ»ْ»ْذ¾²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DOME_MOVEMENT_PARAM
        {
            public ushort wMaxZoom;   // اٍ»ْ×î´َ±¶آتدµت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£ءô×ض½ع
        }

        /********************************ضاؤـ½»ح¨تآ¼‏ begin****************************************/
        public const int MAX_REGION_NUM = 8;  // اّسٍءذ±ي×î´َت‎ؤ؟
        public const int MAX_TPS_RULE = 8;   // ×î´َ²خت‎¹وشٍت‎ؤ؟
        public const int MAX_AID_RULE = 8;   // ×î´َتآ¼‏¹وشٍت‎ؤ؟
        public const int MAX_LANE_NUM = 8;   // ×î´َ³µµہت‎ؤ؟

        //½»ح¨تآ¼‏ہàذح
        public enum TRAFFIC_AID_TYPE
        {
            CONGESTION = 0x01,    //سµ¶آ
            PARKING = 0x02,    //ح£³µ  
            INVERSE = 0x04,    //ؤوذذ
            PEDESTRIAN = 0x08,    //ذذبث                      
            DEBRIS = 0x10,    //زإءôخï إ×ب÷خïثéئ¬ 
            SMOKE = 0x20,    //رجخي  
            OVERLINE = 0x40,     //ر¹دك
            VEHICLE_CONTROL_LIST = 0x80,  //؛عأûµ¥ت‎¾ف
            SPEED = 0x100  //³¬ثظ
        }

        public enum TRAFFIC_SCENE_MODE
        {
            FREEWAY = 0,    //  ¸كثظ»§حâ³،¾°
            TUNNEL,         //  ¸كثظثيµہ³،¾°
            BRIDGE          //  ¸كثظاإء؛³،¾°
        }

        public enum ITS_ABILITY_TYPE
        {
            ITS_CONGESTION_ABILITY = 0x01,      //سµ¶آ
            ITS_PARKING_ABILITY = 0x02,      //ح£³µ  
            ITS_INVERSE_ABILITY = 0x04,      //ؤوذذ
            ITS_PEDESTRIAN_ABILITY = 0x08,      //ذذبث                      
            ITS_DEBRIS_ABILITY = 0x10,      //زإءôخï إ×ب÷خïثéئ¬
            ITS_SMOKE_ABILITY = 0x20,      //رجخي-ثيµہ
            ITS_OVERLINE_ABILITY = 0x40,      //ر¹دك
            ITS_VEHICLE_CONTROL_LIST_ABILITY = 0x80,        //؛عأûµ¥ت‎¾ف
            ITS_SPEED_ABILITY = 0x100,	    //³¬ثظ	
            ITS_LANE_VOLUME_ABILITY = 0x010000,  //³µµہء÷ء؟
            ITS_LANE_VELOCITY_ABILITY = 0x020000,  //³µµہئ½¾ùثظ¶ب
            ITS_TIME_HEADWAY_ABILITY = 0x040000,  //³µح·ت±¾à
            ITS_SPACE_HEADWAY_ABILITY = 0x080000,  //³µح·¼ن¾à
            ITS_TIME_OCCUPANCY_RATIO_ABILITY = 0x100000,  //³µµہص¼سذآت£¬£¨ت±¼نةد)
            ITS_SPACE_OCCUPANCY_RATIO_ABILITY = 0x200000,  //³µµہص¼سذآت£¬°ظ·ض±ب¼ئثم£¨؟ص¼نةد)
            ITS_LANE_QUEUE_ABILITY = 0x400000,  //إإ¶س³¤¶ب
            ITS_VEHICLE_TYPE_ABILITY = 0x800000,  //³µء¾ہàذح
            ITS_TRAFFIC_STATE_ABILITY = 0x1000000  //½»ح¨×´ج¬
        }

        // ½»ح¨ح³¼ئ²خت‎
        public enum ITS_TPS_TYPE
        {
            LANE_VOLUME = 0x01,    //³µµہء÷ء؟
            LANE_VELOCITY = 0x02,    //³µµہثظ¶ب
            TIME_HEADWAY = 0x04,    //³µح·ت±¾à
            SPACE_HEADWAY = 0x08,    //³µح·¼ن¾à
            TIME_OCCUPANCY_RATIO = 0x10,    //³µµہص¼سذآت (ت±¼نةد)
            SPACE_OCCUPANCY_RATIO = 0x20,    //³µµہص¼سذآت£¬°ظ·ض±ب¼ئثم(؟ص¼نةد)
            QUEUE = 0x40,    //إإ¶س³¤¶ب
            VEHICLE_TYPE = 0x80,    //³µء¾ہàذح
            TRAFFIC_STATE = 0x100    //½»ح¨×´ج¬
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REGION_LIST
        {
            public uint dwSize;	// ½ل¹¹جه´َذ،
            public byte byNum;      // اّسٍ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POLYGON[] struPolygon; // اّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ±£ءô×ض½ع
        }

        //·½دٍ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIRECTION
        {
            public NET_VCA_POINT struStartPoint;   // ·½دٍئًت¼µم
            public NET_VCA_POINT struEndPoint;     // ·½دٍ½لتّµم 
        }

        //µ¥¸ِ³µµہ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LANE
        {
            public byte byEnable;  //³µµہتا·ٌئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	   // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneName;       // ³µµہ¹وشٍأû³ئ
            public NET_DVR_DIRECTION struFlowDirection;// ³µµہؤع³µء÷·½دٍ
            public NET_VCA_POLYGON struPolygon;		// ³µµہاّسٍ
        }

        //³µµہإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_CFG
        {
            public uint dwSize;	// ½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LANE[] struLane;	// ³µµہ²خت‎ ت‎×éدآ±ê×÷خھ³µµہID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	 // ±£ءô×ض½ع
        }

        //½»ح¨تآ¼‏²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_PARAM
        {
            public ushort wParkingDuration;       // خ¥ح£¼ى²âءéأô¶ب  10-120s
            public ushort wPedestrianDuration;    // ذذبث³ضذّت±¼ن    1-120s
            public ushort wDebrisDuration;        // إ×ب÷خï³ضذّت±¼ن  10-120s
            public ushort wCongestionLength;      // سµ¶آ³¤¶بمذضµ    5-200£¨أ×£©
            public ushort wCongestionDuration;    // سµ¶آ³ضذّ²خت‎    10-120s
            public ushort wInverseDuration;       // ؤوذذ³ضذّت±¼ن    1-10s
            public ushort wInverseDistance;       // ؤوذذ¾àہëمذضµ µ¥خ»m ·¶خ§[2-100] ؤ¬بد 10أ×
            public ushort wInverseAngleTolerance; // شتذي½ا¶بئ«²î 90-180¶ب,³µء÷سëؤوذذشتذيµؤ¼ذ½ا
            public ushort wIllegalParkingTime;    // خ¥ح£ت±¼ن[4,60]£¬µ¥خ»£؛·ضضس ,TFS(½»ح¨خ¥صآب،ض¤) ³اتذؤ£ت½دآ
            public ushort wIllegalParkingPicNum;  // خ¥ح£ح¼ئ¬ت‎ء؟[1,6], TFS(½»ح¨خ¥صآب،ض¤) ³اتذؤ£ت½دآ
            public byte byMergePic;             // ح¼ئ¬ئ´½س,TFS ³اتذؤ£ت½دآ 0- ²»ئ´½س 1- ئ´½س
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;             // ±£ءô×ض½ع
        }

        //µ¥جُ½»ح¨تآ¼‏¹وشٍ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE
        {
            public byte byEnable;                   // تا·ٌئôسأتآ¼‏¹وشٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;       // ¹وشٍأû³ئ 
            public uint dwEventType;                // ½»ح¨تآ¼‏¼ى²âہàذح TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; // ³ك´ç¹‎آثئ÷
            public NET_VCA_POLYGON     struPolygon;    // ¹وشٍاّسٍ
            public NET_DVR_AID_PARAM   struAIDParam;   //  تآ¼‏²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //´¦ہي·½ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //½»ح¨تآ¼‏¹وشٍ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG
        {
            public uint dwSize;                    // ½ل¹¹جه´َذ، 
            public byte byPicProType;              //±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                 // ±£ءô×ض½ع
            public NET_DVR_JPEGPARA struPictureParam; //ح¼ئ¬¹و¸ٌ½ل¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE[]  struOneAIDRule;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //µ¥جُ½»ح¨تآ¼‏¹وشٍ½ل¹¹جه(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE_V41
        {
            public byte byEnable;                 // تا·ٌئôسأتآ¼‏¹وشٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;     // ¹وشٍأû³ئ 
            public uint dwEventType;              // ½»ح¨تآ¼‏¼ى²âہàذح TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter;           // ³ك´ç¹‎آثئ÷
            public NET_VCA_POLYGON struPolygon;              // ¹وشٍاّسٍ
            public NET_DVR_AID_PARAM struAIDParam;             // تآ¼‏²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;// ²¼·ہت±¼ن¶خ
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	          //´¦ہي·½ت½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±¨¾¯´¥·¢µؤآ¼دَح¨µہ£؛1±يت¾´¥·¢¸أح¨µہ£»0±يت¾²»´¥·¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //±£ءô
        }

        //½»ح¨تآ¼‏¹وشٍ(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG_V41
        {
            public uint dwSize;                     // ½ل¹¹جه´َذ، 
            public byte byPicProType;               // ±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // ±£ءô×ض½ع
            public NET_DVR_JPEGPARA struPictureParam; 	// ح¼ئ¬¹و¸ٌ½ل¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE_V41[]  struAIDRule;  //¹وشٍت‎×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //±£ءô
        }

        //½»ح¨ح³¼ئ²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE
        {
            public byte byEnable;                   //تا·ٌت¹ؤـ³µµہ½»ح¨¹وشٍ²خت‎
            public byte byLaneID;		            //³µµہID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwCalcType;                 //ح³¼ئ²خت‎ہàذحITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; //³ك´ç¹‎آثئ÷ 
            public NET_VCA_POLYGON struVitrualLoop;    //ذéؤâدكب¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//´¦ہي·½ت½,ز»°مخھ´¦ہيتا·ٌةد´«ضذذؤ£¬ئنثû¹¦ؤـ²»ذèزھ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                         //±£ءô×ض½ع
        }

        //½»ح¨²خت‎ح³¼ئ¹وشٍإنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG
        {
            public uint dwSize;              // ½ل¹¹´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE[] struOneTpsRule; // دآ±ê¶شس¦½»ح¨²خت‎ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±£ءô×ض½ع
        }

        //½»ح¨ح³¼ئ²خت‎½ل¹¹جه(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE_V41
        {
            public byte byEnable;                     //تا·ٌت¹ؤـ³µµہ½»ح¨¹وشٍ²خت‎
            public byte byLaneID;		              //³µµہID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //±£ءô
            public uint dwCalcType;                   // ح³¼ئ²خت‎ہàذحITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER  struSizeFilter;  //³ك´ç¹‎آثئ÷ 
            public NET_VCA_POLYGON  struVitrualLoop; //ذéؤâدكب¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]  struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	   //´¦ہي·½ت½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   // ±£ءô×ض½ع
        }

        //½»ح¨²خت‎ح³¼ئ¹وشٍإنضأ½ل¹¹جه(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG_V41
        {
            public uint dwSize;         // ½ل¹¹´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE_V41[] struOneTpsRule; // دآ±ê¶شس¦½»ح¨²خت‎ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ±£ءô
        }

        //½»ح¨تآ¼‏ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_INFO
        {
            public byte byRuleID;   // ¹وشٍذٍ؛إ£¬خھ¹وشٍإنضأ½ل¹¹دآ±ê£¬0-16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //  ¹وشٍأû³ئ
            public uint dwAIDType;  // ±¨¾¯تآ¼‏ہàذح
            public NET_DVR_DIRECTION   struDirect; // ±¨¾¯ض¸دٍاّسٍ  
            public byte bySpeedLimit; //دقثظضµ£¬µ¥خ»km/h[0,255]
            public byte byCurrentSpeed; //µ±ا°ثظ¶بضµ£¬µ¥خ»km/h[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  // ±£ءô×ض½ع 
        }

        //½»ح¨تآ¼‏±¨¾¯ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM
        {
            public uint dwSize;         // ½ل¹¹³¤¶ب
            public uint dwRelativeTime;	// دà¶شت±±ê
            public uint dwAbsTime;		// ¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO struDevInfo;	// ا°¶ثةè±¸ذإد¢
            public NET_DVR_AID_INFO struAIDInfo;    // ½»ح¨تآ¼‏ذإد¢
            public uint dwPicDataLen;   // ·µ»طح¼ئ¬µؤ³¤¶ب خھ0±يت¾أ»سذح¼ئ¬£¬´َسع0±يت¾¸أ½ل¹¹؛َأو½ô¸ْح¼ئ¬ت‎¾ف
            public IntPtr pImage;        // ض¸دٍح¼ئ¬µؤض¸صë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£ءô×ض½ع  
        }

        //³µµہ¶سءذ½ل¹¹جه 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_QUEUE
        {
            public NET_VCA_POINT struHead;       //¶سءذح·
            public NET_VCA_POINT struTail;       //¶سءذخ²
            public uint dwLength;      //تµ¼ت¶سءذ³¤¶ب µ¥خ»خھأ× [0-500]
        }

        public enum TRAFFIC_DATA_VARY_TYPE
        {
            NO_VARY,         //خق±ن»¯ 
            VEHICLE_ENTER,   //³µء¾½ّبëذéؤâدكب¦
            VEHICLE_LEAVE,   //³µء¾ہë؟ھذéؤâدكب¦ 
            UEUE_VARY        //¶سءذ±ن»¯             
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;  //³µµہ¹وشٍأû³ئ 
            public byte byRuleID;              //¹وشٍذٍ؛إ£¬خھ¹وشٍإنضأ½ل¹¹دآ±ê£¬0-7 
            public byte byVaryType;            //³µµہ½»ح¨²خت‎±ن»¯ہàذح ²خصص TRAFFIC_DATA_VARY_TYPE
            public byte byLaneType;			   //³µµہةدذذ»ٍدآذذ
            public byte byRes1;
            public uint dwLaneVolume;         //³µµہء÷ء؟ £¬ح³¼ئسذ¶àةظ³µ×سح¨¹‎
            public uint dwLaneVelocity;        //³µµہثظ¶ب£¬¹«ہï¼ئثم
            public uint dwTimeHeadway;         //³µح·ت±¾à£¬زشأë¼ئثم
            public uint dwSpaceHeadway;        //³µح·¼ن¾à£¬زشأ×ہ´¼ئثم
            public float fSpaceOccupyRation;    //³µµہص¼سذآت£¬°ظ·ض±ب¼ئثم£¨؟ص¼نةد)
            public NET_DVR_LANE_QUEUE struLaneQueue;    //³µµہ¶سءذ³¤¶ب
            public NET_VCA_POINT struRuleLocation; //دكب¦¹وشٍµؤضذذؤµمخ»ضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO
        {
            public uint dwLanNum;   // ½»ح¨²خت‎µؤ³µµہت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM[]  struLaneParam;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM
        {
            public uint dwSize;          //½ل¹¹جه´َذ،
            public uint dwRelativeTime;  //دà¶شت±±ê
            public uint dwAbsTime;       //¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO  struDevInfo;     //ا°¶ثةè±¸ذإد¢
            public NET_DVR_TPS_INFO  struTPSInfo;     //½»ح¨تآ¼‏ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      //±£ءô×ض½ع
        }

        public enum TRAFFIC_DATA_VARY_TYPE_EX_ENUM
        {
            ENUM_TRAFFIC_VARY_NO = 0x00,   //خق±ن»¯
            ENUM_TRAFFIC_VARY_VEHICLE_ENTER = 0x01,   //³µء¾½ّبëذéؤâدكب¦
            ENUM_TRAFFIC_VARY_VEHICLE_LEAVE = 0x02,   //³µء¾ہë؟ھذéؤâدكب¦
            ENUM_TRAFFIC_VARY_QUEUE = 0x04,   //¶سءذ±ن»¯
            ENUM_TRAFFIC_VARY_STATISTIC = 0x08,   //ح³¼ئت‎¾ف±ن»¯£¨أ؟·ضضس±ن»¯ز»´خ°üہ¨ئ½¾ùثظ¶ب£¬³µµہ؟ص¼ن/ت±¼نص¼سذآت£¬½»ح¨×´ج¬£©        
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM_V41
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; // ³µµہ¹وشٍأû³ئ
            public byte byRuleID;             // ¹وشٍذٍ؛إ£¬خھ¹وشٍإنضأ½ل¹¹دآ±ê£¬0-7 
            public byte byLaneType;		     // ³µµہةدذذ»ٍدآذذ
            public byte byTrafficState;       // ³µµہµؤ½»ح¨×´ج¬£¬0-خقذ§£¬1-³©ح¨£¬2-سµ¼·£¬3-¶آبû
            public byte byRes1;               // ±£ءô
            public uint dwVaryType;           // ³µµہ½»ح¨²خت‎±ن»¯ہàذح²خصص  TRAFFIC_DATA_VARY_TYPE_EX_ENUM£¬°´خ»اّ·ض
            public uint dwTpsType;            // ت‎¾ف±ن»¯ہàذح±êض¾£¬±يت¾µ±ا°ةد´«µؤح³¼ئ²خت‎ضذ£¬ؤؤذ©ت‎¾فسذذ§£¬²خصصITS_TPS_TYPE,°´خ»اّ·ض
            public uint dwLaneVolume;	     // ³µµہء÷ء؟£¬ح³¼ئسذ¶àةظ³µ×سح¨¹‎
            public uint dwLaneVelocity;       // ³µµہثظ¶ب£¬¹«ہï¼ئثم
            public uint dwTimeHeadway ;       // ³µح·ت±¾à£¬زشأë¼ئثم
            public uint dwSpaceHeadway;       // ³µح·¼ن¾à£¬زشأ×ہ´¼ئثم
            public float fSpaceOccupyRation;   // ³µµہص¼سذآت£¬°ظ·ض±ب¼ئثم£¨؟ص¼نةد)
            public float fTimeOccupyRation;    // ت±¼نص¼سذآت£¬°ظ·ض±ب¼ئثم
            public uint dwLightVehicle;       // ذ،ذح³µت‎ء؟
            public uint dwMidVehicle;         // ضذذح³µت‎ء؟
            public uint dwHeavyVehicle;       // ضطذح³µت‎ء؟
            public NET_DVR_LANE_QUEUE struLaneQueue;        // ³µµہ¶سءذ³¤¶ب
            public NET_VCA_POINT struRuleLocation;     // ¹وشٍخ»ضأذéؤâدكب¦µؤضذذؤ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO_V41
        {
            public uint dwLanNum;          // ½»ح¨²خت‎µؤ³µµہت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM_V41[]  struLaneParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£ءô
        }

        //بثء³¹وشٍإنضأ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG
        {
            public uint dwSize;              // ½ل¹¹جه´َذ،
            public byte byEnable;            // تا·ٌئôسأ
            public byte byEventType;			//¾¯½نتآ¼‏ہàذح£¬ 0-زى³£بثء³; 1-ص‎³£بثء³;2-زى³£بثء³&ص‎³£بثء³;
            public byte byUpLastAlarm;       //2011-04-06 تا·ٌدبةد´«×î½üز»´خµؤ±¨¾¯
            public byte byUpFacePic; //تا·ٌةد´«بثء³×سح¼£¬0-·ٌ£¬1-تا	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON     struVcaPolygon;    // بثء³¼ى²â¹وشٍاّسٍ
            public byte byPicProType;	//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            public byte bySensitivity;   // ¹وشٍءéأô¶ب
            public ushort wDuration;      // ´¥·¢بثء³±¨¾¯ت±¼نمذضµ
            public NET_DVR_JPEGPARA    struPictureParam; 		//ح¼ئ¬¹و¸ٌ½ل¹¹
            public NET_VCA_SIZE_FILTER struSizeFilter;         //³ك´ç¹‎آثئ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //´¦ہي·½ت½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            public byte byPicRecordEnable;  /*2012-3-1تا·ٌئôسأح¼ئ¬´و´¢, 0-²»ئôسأ, 1-ئôسأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PIPCFG
        {
            public byte byEnable; //تا·ٌ؟ھئô»­ضذ»­
            public byte byBackChannel; //±³¾°ح¨µہ؛إ£¨أو°هح¨µہ£©
            public byte byPosition; //µ‏¼سخ»ضأ£¬0-×َةد,1-×َدآ,2-سزةد,3-سزدآ
            public byte byPIPDiv; //·ضئءدµت‎(بثء³»­أو:أو°ه»­أو)£¬0-1:4,1-1:9,2-1:16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG_V41
        {
            public uint dwSize;              // ½ل¹¹جه´َذ،
            public byte byEnable;            // تا·ٌئôسأ
            public byte byEventType;			//¾¯½نتآ¼‏ہàذح£¬ 0-زى³£بثء³; 1-ص‎³£بثء³;2-زى³£بثء³&ص‎³£بثء³;
            public byte byUpLastAlarm;       //2011-04-06 تا·ٌدبةد´«×î½üز»´خµؤ±¨¾¯
            public byte byUpFacePic; //تا·ٌةد´«بثء³×سح¼£¬0-·ٌ£¬1-تا	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON struVcaPolygon;    // بثء³¼ى²â¹وشٍاّسٍ
            public byte byPicProType;	//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            public byte bySensitivity;   // ¹وشٍءéأô¶ب
            public ushort wDuration;      // ´¥·¢بثء³±¨¾¯ت±¼نمذضµ
            public NET_DVR_JPEGPARA    struPictureParam; 		//ح¼ئ¬¹و¸ٌ½ل¹¹
            public NET_VCA_SIZE_FILTER struSizeFilter;         //³ك´ç¹‎آثئ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //´¦ہي·½ت½ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            public byte byPicRecordEnable;  /*2012-10-22تا·ٌئôسأح¼ئ¬´و´¢, 0-²»ئôسأ, 1-ئôسأ*/
            public byte byRes1;
            public ushort wAlarmDelay; //2012-10-22ضاؤـ±¨¾¯رست±£¬0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            public NET_DVR_FACE_PIPCFG struFacePIP; //2012-11-7»­ضذ»­²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_ALARM
        {
            public uint dwSize;     		// ½ل¹¹´َذ،
            public uint dwRelativeTime; // دà¶شت±±ê
            public uint dwAbsTime;			// ¾ّ¶شت±±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;   // ¹وشٍأû³ئ
            public NET_VCA_TARGET_INFO  struTargetInfo;	//±¨¾¯ؤ؟±êذإد¢
            public NET_VCA_DEV_INFO      struDevInfo;		//ا°¶ثةè±¸ذإد¢
            public uint dwPicDataLen;						//·µ»طح¼ئ¬µؤ³¤¶ب خھ0±يت¾أ»سذح¼ئ¬£¬´َسع0±يت¾¸أ½ل¹¹؛َأو½ô¸ْح¼ئ¬ت‎¾ف*/
            public byte byAlarmPicType;			// 0-زى³£بثء³±¨¾¯ح¼ئ¬ 1- بثء³ح¼ئ¬,2-¶àصإبثء³ 
            public byte byPanelChan;        /*2012-3-1بثء³ح¨µہ¹طءھµؤأو°هح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFacePicDataLen;			//بثء³ح¼ئ¬µؤ³¤¶ب خھ0±يت¾أ»سذح¼ئ¬£¬´َسع0±يت¾¸أ½ل¹¹؛َأو½ô¸ْح¼ئ¬ت‎¾ف*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£ءô×ض½ع
            public IntPtr pFaceImage; //ض¸دٍبثء³ح¼ض¸صë
            public IntPtr pImage;   						//ض¸دٍح¼ئ¬µؤض¸صë
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;        	// ءھ؛دجه´َذ،خھ12×ض½ع
            public uint dwHumanIn;  	//سذخقبث½س½ü 0 - خقبث 1- سذبث  
            public float fCrowdDensity;  // بثش±¾غ¼¯ضµ
        }

        //ؤ؟ا°ض»سذسذبثخقبثتآ¼‏؛حبثش±¾غ¼¯تآ¼‏تµت±±¨¾¯ةد´«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO
        {
            public byte byRuleID;				// Rule ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				// ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;	// ¹وشٍأû³ئ
            public uint dwEventType;    		// ²خصصVCA_EVENT_TYPE
            public NET_DVR_EVENT_PARAM_UNION uEventParam;  // 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO_LIST
        {
            public byte byNum;		// تآ¼‏تµت±ذإد¢¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_EVENT_INFO[] struEventInfo;	// تآ¼تتµت±ذإد¢
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RULE_INFO_ALARM
        {
            public uint dwSize;				// ½ل¹¹جه´َذ،
            public uint dwRelativeTime; 	// دà¶شت±±ê
            public uint dwAbsTime;			// ¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO     struDevInfo;		// ا°¶ثةè±¸ذإد¢
            public NET_DVR_EVENT_INFO_LIST struEventInfoList;	//تآ¼‏ذإد¢ءذ±ي
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±£ءô×ض½ع
        }

        //µ¥جُ³،¾°ت±¼ن¶خ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_TIME
        {
            public byte byActive;                     //0 -خقذ§,1¨Cسذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //±£ءô
            public uint dwSceneID;                    //³،¾°ID
            public NET_DVR_SCHEDTIME struEffectiveTime;   //³،¾°ئًذ§ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   //±£ءô
        }

        //³،¾°ئًذ§ت±¼ن¶خإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_TIME_CFG
        {
            public uint dwSize;                                               //½ل¹¹´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SCENE_TIMESEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_TIME[] struSceneTime; //³،¾°ت±¼ن¶خت‎×é
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                            //±£ءô
        }

        //µ¥جُ³،¾°إنضأذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_CFG
        {
            public byte byEnable;                 //تا·ٌئôسأ¸أ³،¾°,0-²»ئôسأ 1- ئôسأ
            public byte byDirection;              //¼à²â·½دٍ 1-ةدذذ£¬2-دآذذ£¬3-ث«دٍ£¬4-سة¶«دٍخ÷£¬5-سةؤددٍ±±£¬6-سةخ÷دٍ¶«£¬7-سة±±دٍؤد£¬8-ئنثü
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                //±£ءô
            public uint dwSceneID;                //³،¾°ID(ض»¶ء), 0 - ±يت¾¸أ³،¾°خقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;    //³،¾°أû³ئ
            public NET_DVR_PTZPOS struPtzPos;       //ptz ×ّ±ê
            public uint dwTrackTime;              //اٍ»ْ¸ْ×ظت±¼ن[5,300] أë£¬TFS(½»ح¨ب،ض¤)ؤ£ت½دآسذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //±£ءô
        }

        //³،¾°إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_CFG
        {
            public uint dwSize;                                          //½ل¹¹´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITS_SCENE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_CFG[] struSceneCfg; //³،¾°إنضأذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                      //±£ءô
        }

        //¶à³،¾°²ظ×÷جُ¼‏
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_COND
        {
            public uint dwSize;       //½ل¹¹´َذ،
            public Int32 lChannel;     //ح¨µہ؛إ
            public uint dwSceneID;    //³،¾°ID, 0-±يت¾¸أ³،¾°خقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£ءô
        }

        //ب،ض¤·½ت½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FORENSICS_MODE
        {
            public uint dwSize;      //½ل¹¹´َذ،
            public byte byMode;      // 0-تض¶¯ب،ض¤ ,1-×ش¶¯ب،ض¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±£ءô
        }

        //±¨¾¯³،¾°ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_INFO
        {
            public uint dwSceneID;              //³،¾°ID, 0 - ±يت¾¸أ³،¾°خقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;  //³،¾°أû³ئ
            public byte byDirection;            //¼à²â·½دٍ 1-ةدذذ£¬2-دآذذ£¬3-ث«دٍ£¬4-سة¶«دٍخ÷£¬5-سةؤددٍ±±£¬6-سةخ÷دٍ¶«£¬7-سة±±دٍؤد£¬8-ئنثü
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //±£ءô
            public NET_DVR_PTZPOS  struPtzPos;             //Ptz ×ّ±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2 ;            //±£ءô
        }

        //½»ح¨تآ¼‏±¨¾¯(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM_V41
        {
            public uint dwSize;              //½ل¹¹³¤¶ب
            public uint dwRelativeTime;	    //دà¶شت±±ê
            public uint dwAbsTime;			//¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO  struDevInfo;		    //ا°¶ثةè±¸ذإد¢
            public NET_DVR_AID_INFO  struAIDInfo;         //½»ح¨تآ¼‏ذإد¢
            public NET_DVR_SCENE_INFO struSceneInfo;       //³،¾°ذإد¢
            public uint dwPicDataLen;        //ح¼ئ¬³¤¶ب
            public IntPtr pImage; 			//ض¸دٍح¼ئ¬µؤض¸صë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£ءô
        }

        //½»ح¨ح³¼ئذإد¢±¨¾¯(ہ©ص¹)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM_V41
        {
            public uint dwSize;          // ½ل¹¹جه´َذ،
            public uint dwRelativeTime;  // دà¶شت±±ê
            public uint dwAbsTime;       // ¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO struDevInfo;     // ا°¶ثةè±¸ذإد¢
            public NET_DVR_TPS_INFO_V41  struTPSInfo;     // ½»ح¨²خت‎ح³¼ئذإد¢ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_VERSION
        {
            public ushort wMajorVersion;		// ض÷°و±¾؛إ
            public ushort wMinorVersion;		// ´خ°و±¾؛إ
            public ushort wRevisionNumber;	// ذقص‎؛إ
            public ushort wBuildNumber;		// ±àزë؛إ
            public ushort wVersionYear;		//	°و±¾بصئع-ؤê
            public byte byVersionMonth;		//	°و±¾بصئع-شآ
            public byte byVersionDay;		//	°و±¾بصئع-بص
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			// ±£ءô×ض½ع
        }
        /*******************************ضاؤـ½»ح¨تآ¼‏ end*****************************************/

        /******************************³µإئت¶±ً begin******************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_PARAM
        {
            public byte byPlateRecoMode;    //³µإئت¶±ًµؤؤ£ت½,ؤ¬بدخھ1(تسئµ´¥·¢ؤ£ت½)
            public byte byBelive;	/*صûإئضأذإ¶بمذضµ, ض»سأسعتسئµت¶±ً·½ت½, ¸ù¾ف±³¾°¸´شس³ج¶بةèضأ, خَ´¥·¢آت¸ك¾حةè¸ك, آ©³µآت¸ك¾حةèµح, 
                                     * ½¨زéشع80-90·¶خ§ؤع*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATECFG
        {
            public uint dwSize;
            public uint dwEnable;				           /* تا·ٌئôسأتسئµ³µإئت¶±ً 0£­·ٌ 1£­تا */
            public byte byPicProType;	//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي ·ا0-ةد´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // ±£ءô×ض½ع
            public NET_DVR_JPEGPARA struPictureParam; 		//ح¼ئ¬¹و¸ٌ½ل¹¹
            public NET_DVR_PLATE_PARAM struPlateParam;   // ³µإئت¶±ً²خت‎إنضأ
            public NET_DVR_HANDLEEXCEPTION struHandleType;	   /* ´¦ہي·½ت½ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£ءô×ض½ع
        }

        //³µإئت¶±ً½ل¹û×س½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_INFO
        {
            public byte byPlateType; //³µإئہàذح
            public byte byColor; //³µإئرصة«
            public byte byBright; //³µإئءء¶ب
            public byte byLicenseLen;	//³µإئ×ض·û¸ِت‎
            public byte byEntireBelieve;//صû¸ِ³µإئµؤضأذإ¶ب£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
            public NET_VCA_RECT struPlateRect;	//³µإئخ»ضأ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;	//³µإئ؛إآë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelieve; //¸÷¸ِت¶±ً×ض·ûµؤضأذإ¶ب£¬بç¼ى²âµ½³µإئ"صمA12345", ضأذإ¶بخھ,20,30,40,50,60,70£¬شٍ±يت¾"صم"×ضص‎ب·µؤ؟ةؤـذشض»سذ%£¬"A"×ضµؤص‎ب·µؤ؟ةؤـذشتا%
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATERECO_RESULE
        {
            public uint dwSize;
            public uint dwRelativeTime;	//دà¶شت±±ê
            public uint dwAbsTime;	//¾ّ¶شت±±ê
            public NET_VCA_DEV_INFO struDevInfo; // ا°¶خةè±¸ذإد¢
            public NET_DVR_PLATE_INFO struPlateInfo;
            public uint dwPicDataLen;	//·µ»طح¼ئ¬µؤ³¤¶ب خھ0±يت¾أ»سذح¼ئ¬£¬´َسع0±يت¾¸أ½ل¹¹؛َأو½ô¸ْح¼ئ¬ت‎¾ف
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;	//±£ءô£¬ةèضأخھ0
            public IntPtr pImage;   //ض¸دٍح¼ئ¬µؤض¸صë
        }
        /******************************³µإئت¶±ً end******************************************/

        /******************************×¥إؤ»ْ*******************************************/
        //IOتنبëإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_INCFG
        {
            public uint dwSize;
            public byte byIoInStatus;//تنبëµؤIO؟ع×´ج¬£¬0-دآ½µرط£¬1-ةدة‎رط£¬2-ةدة‎رط؛حدآ½µرط£¬3-¸كµçئ½£¬4-µحµçئ½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô×ض½ع
        }

        //IOتن³ِإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_OUTCFG
        {
            public uint dwSize;
            public byte byDefaultStatus;//IOؤ¬بد×´ج¬£؛0-µحµçئ½£¬1-¸كµçئ½ 
            public byte byIoOutStatus;//IOئًذ§ت±×´ج¬£؛0-µحµçئ½£¬1-¸كµçئ½£¬2-آِ³ه
            public ushort wAheadTime;//تن³ِIOجلا°ت±¼ن£¬µ¥خ»us
            public uint dwTimePluse;//آِ³ه¼ن¸ôت±¼ن£¬µ¥خ»us
            public uint dwTimeDelay;//IOسذذ§³ضذّت±¼ن£¬µ¥خ»us
            public byte byFreqMulti;		//±¶ئµ£¬ت‎ضµ·¶خ§[1,15]
            public byte byDutyRate;		//ص¼؟ص±ب£¬[0,40%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ةء¹âµئإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLASH_OUTCFG
        {
            public uint dwSize;
            public byte byMode;//ةء¹âµئةءث¸ؤ£ت½£¬0-²»ةء£¬1-ةء£¬2-¹طءھةء£¬3-آضةء
            public byte byRelatedIoIn;//ةء¹âµئ¹طءھµؤتنبëIO؛إ£¨¹طءھةءت±´ث²خت‎سذذ§£©
            public byte byRecognizedLane;  /*¹طءھµؤIO؛إ£¬°´خ»±يت¾£¬bit0±يت¾IO1تا·ٌ¹طءھ£¬0-²»¹طءھ£¬1-¹طءھ*/
            public byte byDetectBrightness;/*×ش¶¯¼ى²âءء¶بت¹ؤـةء¹âµئ0-²»¼ى²â£»1-¼ى²â*/
            public byte byBrightnessThreld;/*ت¹ؤـةء¹âµئءء¶بمذضµ£¬·¶خ§[0,100],¸كسعمذضµةء*/
            public byte byStartHour;		//؟ھت¼ت±¼ن-ذ،ت±,ب،ضµ·¶خ§0-23
            public byte byStartMinute;		//؟ھت¼ت±¼ن-·ض,ب،ضµ·¶خ§0-59
            public byte byEndHour;		 	//½لتّت±¼ن-ذ،ت±,ب،ضµ·¶خ§0-23
            public byte byEndMinute;		//½لتّت±¼ن-·ض,ب،ضµ·¶خ§0-59
            public byte byFlashLightEnable;	//ةèضأةء¹âµئت±¼نت¹ؤـ:0-¹ط;1-؟ھ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //؛ىآجµئ¹¦ؤـ£¨2¸ِIOتنبëز»×é£©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIGHTSNAPCFG
        {
            public uint dwSize;
            public byte byLightIoIn;//؛ىآجµئµؤIO ؛إ
            public byte byTrigIoIn;//´¥·¢µؤIO؛إ
            public byte byRelatedDriveWay;//´¥·¢IO¹طءھµؤ³µµہ؛إ
            public byte byTrafficLight; //0-¸كµçئ½؛ىµئ£¬µحµçئ½آجµئ£»1-¸كµçئ½آجµئ£¬µحµçئ½؛ىµئ
            public byte bySnapTimes1; //؛ىµئ×¥إؤ´خت‎1£¬0-²»×¥إؤ£¬·ا0-ء¬إؤ´خت‎£¬×î´َ5´خ 
            public byte bySnapTimes2; //آجµئ×¥إؤ´خت‎2£¬0-²»×¥إؤ£¬·ا0-ء¬إؤ´خت‎£¬×î´َ5´خ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//؛ىµئء¬إؤ¼ن¸ôت±¼ن£¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//آجµئء¬إؤ¼ن¸ôت±¼ن£¬ms
            public byte byRecord;//´³؛ىµئضـئعآ¼دٌ±êض¾£¬0-²»آ¼دٌ£¬1-آ¼دٌ
            public byte bySessionTimeout;//´³؛ىµئضـئعآ¼دٌ³¬ت±ت±¼ن£¨أë£©
            public byte byPreRecordTime;//´³؛ىµئآ¼دٌئ¬¶خش¤آ¼ت±¼ن(أë)
            public byte byVideoDelay;//´³؛ىµئآ¼دٌئ¬¶خرست±ت±¼ن£¨أë£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£ءô×ض½ع
        }

        //²âثظ¹¦ؤـ(2¸ِIOتنبëز»×é£©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MEASURESPEEDCFG
        {
            public uint dwSize;
            public byte byTrigIo1;   //²âثظµع1دكب¦
            public byte byTrigIo2;   //²âثظµع2دكب¦
            public byte byRelatedDriveWay;//´¥·¢IO¹طءھµؤ³µµہ؛إ
            public byte byTestSpeedTimeOut;//²âثظؤ£ت½³¬ت±ت±¼ن£¬µ¥خ»s
            public uint dwDistance;//دكب¦¾àہë,cm
            public byte byCapSpeed;//²âثظؤ£ت½ئًإؤثظ¶ب£¬µ¥خ»km/h
            public byte bySpeedLimit;//دقثظضµ£¬µ¥خ»km/h
            public byte bySnapTimes1; //دكب¦1×¥إؤ´خت‎£¬0-²»×¥إؤ£¬·ا0-ء¬إؤ´خت‎£¬×î´َ5´خ 
            public byte bySnapTimes2; //دكب¦2×¥إؤ´خت‎£¬0-²»×¥إؤ£¬·ا0-ء¬إؤ´خت‎£¬×î´َ5´خ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//دكب¦1ء¬إؤ¼ن¸ôت±¼ن£¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//دكب¦2ء¬إؤ¼ن¸ôت±¼ن£¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô×ض½ع
        }

        //تسئµ²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOEFFECT
        {
            public byte byBrightnessLevel; /*0-100*/
            public byte byContrastLevel; /*0-100*/
            public byte bySharpnessLevel; /*0-100*/
            public byte bySaturationLevel; /*0-100*/
            public byte byHueLevel; /*0-100,£¨±£ءô£©*/
            public byte byEnableFunc; //ت¹ؤـ£¬°´خ»±يت¾£¬bit0-SMART IR(·ہ¹‎ئط)£¬bit1-µحصص¶ب,bit2-ا؟¹âزضضئت¹ؤـ£¬0-·ٌ£¬1-تا
            public byte byLightInhibitLevel; //ا؟¹âزضضئµب¼¶£¬[1-3]±يت¾µب¼¶
            public byte byGrayLevel; //»ز¶بضµسٍ£¬0-[0-255]£¬1-[16-235]
        }

        //شِزوإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAIN
        {
            public byte byGainLevel; /*شِزو£؛0-100*/
            public byte byGainUserSet; /*سأ»§×ش¶¨زهشِزو£»0-100£¬¶شسع×¥إؤ»ْ£¬تاCCDؤ£ت½دآµؤ×¥إؤشِزو*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMaxGainValue;/*×î´َشِزوضµ£¬µ¥خ»dB*/
        }

        //°×ئ½؛âإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WHITEBALANCE
        {
            public byte byWhiteBalanceMode; /*0-تض¶¯°×ئ½؛â£¨MWB£©,1-×ش¶¯°×ئ½؛â1£¨AWB1£©,2-×ش¶¯°×ئ½؛â2 (AWB2),3-×ش¶¯؟طضئ¸ؤأûخھثّ¶¨°×ئ½؛â(Locked WB)£¬
	                         4-تزحâ(Indoor)£¬5-تزؤع(Outdoor)6-بص¹âµئ(Fluorescent Lamp)£¬7-ؤئµئ(Sodium Lamp)£¬
	                         8-×ش¶¯¸ْ×ظ(Auto-Track)9-ز»´خ°×ئ½؛â(One Push)£¬10-تزحâ×ش¶¯(Auto-Outdoor)£¬
	                         11-ؤئµئ×ش¶¯ (Auto-Sodiumlight)£¬12-ث®زّµئ(Mercury Lamp)£¬13-×ش¶¯°×ئ½؛â(Auto)£¬
	                         14-°×³مµئ (IncandescentLamp)£¬15-إ¯¹âµئ(Warm Light Lamp)£¬16-×شب»¹â(Natural Light) */
            public byte byWhiteBalanceModeRGain; /*تض¶¯°×ئ½؛âت±سذذ§£¬تض¶¯°×ئ½؛â Rشِزو*/
            public byte byWhiteBalanceModeBGain; /*تض¶¯°×ئ½؛âت±سذذ§£¬تض¶¯°×ئ½؛â Bشِزو*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ئط¹â؟طضئ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXPOSURE
        {
            public byte byExposureMode; /*0 تض¶¯ئط¹â 1×ش¶¯ئط¹â*/
            public byte byAutoApertureLevel; /* ×ش¶¯¹âب¦ءéأô¶ب, 0-10 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwVideoExposureSet; /* ×ش¶¨زهتسئµئط¹âت±¼ن£¨µ¥خ»us£©*//*×¢:×ش¶¯ئط¹âت±¸أضµخھئط¹â×îآ‎ضµ ذآشِ20-1s(1000000us)*/
            public uint dwExposureUserSet; /* ×ش¶¨زهئط¹âت±¼ن,شع×¥إؤ»ْةدس¦سأت±£¬CCDؤ£ت½ت±تا×¥إؤ؟ىأإثظ¶ب*/
            public uint dwRes;
        }

        //؟ي¶¯ج¬إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WDR
        {
            public byte byWDREnabled; /*؟ي¶¯ج¬£؛0 dsibale  1 enable 2 auto*/
            public byte byWDRLevel1; /*0-F*/
            public byte byWDRLevel2; /*0-F*/
            public byte byWDRContrastLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //بصز¹×ھ»»¹¦ؤـإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DAYNIGHT
        {
            public byte byDayNightFilterType; /*بصز¹اذ»»£؛0-°×جى£¬1-ز¹حي£¬2-×ش¶¯£¬3-¶¨ت±£¬4-±¨¾¯تنبë´¥·¢*/
            public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(±£ءô)*/
            //¶¨ت±ؤ£ت½²خت‎
            public byte byBeginTime; /*؟ھت¼ت±¼ن£¨ذ،ت±£©£¬0-23*/
            public byte byEndTime; /*½لتّت±¼ن£¨ذ،ت±£©£¬0-23*/
            //ؤ£ت½2
            public byte byDayToNightFilterLevel; //0-7
            public byte byNightToDayFilterLevel; //0-7
            public byte byDayNightFilterTime;//(60أë)
            //¶¨ت±ؤ£ت½²خت‎
            public byte byBeginTimeMin; //؟ھت¼ت±¼ن£¨·ض£©£¬0-59
            public byte byBeginTimeSec; //؟ھت¼ت±¼ن£¨أë£©£¬0-59
            public byte byEndTimeMin; //½لتّت±¼ن£¨·ض£©£¬0-59
            public byte byEndTimeSec; //½لتّت±¼ن£¨أë£©£¬0-59
                                      //±¨¾¯تنبë´¥·¢ؤ£ت½²خت‎
            public byte byAlarmTrigState; //±¨¾¯تنبë´¥·¢×´ج¬£¬0-°×جى£¬1-ز¹حي
        }

        //Gammaذ£ص‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAMMACORRECT
        {
            public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
            public byte byGammaCorrectionLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±³¹â²¹³¥إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKLIGHT
        {
            public byte byBacklightMode; /*±³¹â²¹³¥:0 off 1 UP،¢2 DOWN،¢3 LEFT،¢4 RIGHT،¢5MIDDLE،¢6×ش¶¨زه*/
            public byte byBacklightLevel; /*0x0-0xF*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPositionX1; //£¨X×ّ±ê1£©
            public uint dwPositionY1; //£¨Y×ّ±ê1£©
            public uint dwPositionX2; //£¨X×ّ±ê2£©
            public uint dwPositionY2; //£¨Y×ّ±ê2£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ت‎×ض½µشë¹¦ؤـ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NOISEREMOVE
        {
            public byte byDigitalNoiseRemoveEnable; /*0-²»ئôسأ£¬1-ئصح¨ؤ£ت½ت‎×ض½µشë£¬2-×¨¼زؤ£ت½ت‎×ض½µشë*/
            public byte byDigitalNoiseRemoveLevel; /*ئصح¨ؤ£ت½ت‎×ض½µشë¼¶±ً£؛0x0-0xF*/
            public byte bySpectralLevel;       /*×¨¼زؤ£ت½دآ؟صسٍا؟¶ب£؛0-100*/
            public byte byTemporalLevel;   /*×¨¼زؤ£ت½دآت±سٍا؟¶ب£؛0-100*/
            public byte byDigitalNoiseRemove2DEnable;         /* ×¥إؤض،2D½µشë£¬0-²»ئôسأ£¬1-ئôسأ */
            public byte byDigitalNoiseRemove2DLevel;            /* ×¥إؤض،2D½µشë¼¶±ً£¬0-100 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //CMOSؤ£ت½دآا°¶ث¾µح·إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CMOSMODECFG
        {
            public byte byCaptureMod;   //×¥إؤؤ£ت½£؛0-×¥إؤؤ£ت½1£»1-×¥إؤؤ£ت½2
            public byte byBrightnessGate;//ءء¶بمذضµ
            public byte byCaptureGain1;   //×¥إؤشِزو1,0-100
            public byte byCaptureGain2;   //×¥إؤشِزو2,0-100
            public uint dwCaptureShutterSpeed1;//×¥إؤ؟ىأإثظ¶ب1
            public uint dwCaptureShutterSpeed2;//×¥إؤ؟ىأإثظ¶ب2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ا°¶ث²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*ءء¶ب،¢¶ش±ب¶ب،¢±¥؛ح¶ب،¢بٌ¶ب،¢ة«µ÷إنضأ*/
            public NET_DVR_GAIN struGain;/*×ش¶¯شِزو*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*°×ئ½؛â*/
            public NET_DVR_EXPOSURE struExposure; /*ئط¹â؟طضئ*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*Gammaذ£ص‎*/
            public NET_DVR_WDR struWdr;/*؟ي¶¯ج¬*/
            public NET_DVR_DAYNIGHT struDayNight;/*بصز¹×ھ»»*/
            public NET_DVR_BACKLIGHT struBackLight;/*±³¹â²¹³¥*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*ت‎×ض½µشë*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0 ×ش¶¯¹âب¦ 1تض¶¯¹âب¦*/
            public byte byMirror ;  /* ¾µدٌ£؛0 off£¬1- leftright£¬2- updown£¬3-center */
            public byte byDigitalZoom;  /*ت‎×ضثُ·إ:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*»µµم¼ى²â,0 dsibale  1 enable*/
            public byte byBlackPwl;/*؛عµçئ½²¹³¥ ,  0-255*/
            public byte byEptzGate;// EPTZ؟ھ¹ط±نء؟:0-²»ئôسأµç×سشئج¨£¬1-ئôسأµç×سشئج¨
            public byte byLocalOutputGate;//±¾µطتن³ِ؟ھ¹ط±نء؟0-±¾µطتن³ِ¹ط±ص1-±¾µطBNCتن³ِ´ٍ؟ھ 2-HDMIتن³ِ¹ط±ص  
                                          //20-HDMI_720P50تن³ِ؟ھ
                                          //21-HDMI_720P60تن³ِ؟ھ
                                          //22-HDMI_1080I60تن³ِ؟ھ
                                          //23-HDMI_1080I50تن³ِ؟ھ
                                          //24-HDMI_1080P24تن³ِ؟ھ
                                          //25-HDMI_1080P25تن³ِ؟ھ
                                          //26-HDMI_1080P30تن³ِ؟ھ
                                          //27-HDMI_1080P50تن³ِ؟ھ
                                          //28-HDMI_1080P60تن³ِ؟ھ
                                          //40-SDI_720P50,
                                          //41-SDI_720P60,
                                          //42-SDI_1080I50,
                                          //43-SDI_1080I60,
                                          //44-SDI_1080P24,
                                          //45-SDI_1080P25,
                                          //46-SDI_1080P30,
                                          //47-SDI_1080P50,
                                          //48-SDI_1080P60
            public byte byCoderOutputMode;//±àآëئ÷fpgaتن³ِؤ£ت½0ض±ح¨3دٌثط°ل¼ز
            public byte byLineCoding; //تا·ٌ؟ھئôذذ±àآë£؛0-·ٌ£¬1-تا
            public byte byDimmerMode; //µ÷¹âؤ£ت½£؛0-°ë×ش¶¯£¬1-×ش¶¯
            public byte byPaletteMode; //µ÷ة«°ه£؛0-°×بب£¬1-؛عبب£¬2-µ÷ة«°ه2£¬،­£¬8-µ÷ة«°ه8
            public byte byEnhancedMode; //شِا؟·½ت½£¨ج½²âخïجهضـ±ك£©£؛0-²»شِا؟£¬1-1£¬2-2£¬3-3£¬4-4
            public byte byDynamicContrastEN;    //¶¯ج¬¶ش±ب¶بشِا؟ 0-1
            public byte byDynamicContrast;    //¶¯ج¬¶ش±ب¶ب 0-100
            public byte byJPEGQuality;    //JPEGح¼دٌضتء؟ 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSؤ£ت½دآا°¶ث²خت‎إنضأ£¬¾µح·ؤ£ت½´سؤـء¦¼¯»ٌب،
            public byte byFilterSwitch; //آث²¨؟ھ¹ط£؛0-²»ئôسأ£¬1-ئôسأ
            public byte byFocusSpeed; //¾µح·µ÷½¹ثظ¶ب£؛0-10
            public byte byAutoCompensationInterval; //¶¨ت±×ش¶¯؟ىأإ²¹³¥£؛1-120£¬µ¥خ»£؛·ضضس
            public byte bySceneMode;  //³،¾°ؤ£ت½£؛0-تزحâ£¬1-تزؤع£¬2-ؤ¬بد£¬3-بُ¹â
        }

        //ح¸خي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOGCFG
        {
            public byte byMode; //ؤ£ت½£¬0-²»ئôسأ£¬1-×ش¶¯ؤ£ت½£¬2-³£؟ھؤ£ت½
            public byte byLevel; //µب¼¶£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µç×س·ہ¶¶
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ELECTRONICSTABILIZATION
        {
            public byte byEnable;//ت¹ؤـ 0- ²»ئôسأ£¬1- ئôسأ
            public byte byLevel; //µب¼¶£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //×كہبؤ£ت½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRIDOR_MODE_CCD
        {
            public byte byEnableCorridorMode; //تا·ٌئôسأ×كہبؤ£ت½ 0،«²»ئôسأ£¬ 1،«ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //SMART IR(·ہ¹‎ئط)إنضأ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMARTIR_PARAM
        {
            public byte byMode;//0،«تض¶¯£¬1،«×ش¶¯
            public byte byIRDistance;//؛ىحâ¾àہëµب¼¶(µب¼¶£¬¾àہëص‎±بہ‎)level:1~100 ؤ¬بد:50£¨تض¶¯ؤ£ت½دآشِ¼س£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //شعbyIrisMode خھP-Iris1ت±ةْذ§£¬إنضأ؛ىحâ¹âب¦´َذ،µب¼¶£¬إنضأؤ£ت½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIRIS_PARAM
        {
            public byte byMode;//0-×ش¶¯£¬1-تض¶¯
            public byte byPIrisAperture;//؛ىحâ¹âب¦´َذ،µب¼¶(µب¼¶,¹âب¦´َذ،ص‎±بہ‎)level:1~100 ؤ¬بد:50£¨تض¶¯ؤ£ت½دآشِ¼س£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ا°¶ث²خت‎إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG_EX
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*ءء¶ب،¢¶ش±ب¶ب،¢±¥؛ح¶ب،¢بٌ¶ب،¢ة«µ÷إنضأ*/
            public NET_DVR_GAIN struGain;/*×ش¶¯شِزو*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*°×ئ½؛â*/
            public NET_DVR_EXPOSURE struExposure; /*ئط¹â؟طضئ*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*Gammaذ£ص‎*/
            public NET_DVR_WDR struWdr;/*؟ي¶¯ج¬*/
            public NET_DVR_DAYNIGHT struDayNight;/*بصز¹×ھ»»*/
            public NET_DVR_BACKLIGHT struBackLight;/*±³¹â²¹³¥*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*ت‎×ض½µشë*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0-×ش¶¯¹âب¦ 1-تض¶¯¹âب¦, 2-P-Iris1*/
            public byte byMirror ;  /* ¾µدٌ£؛0 off£¬1- leftright£¬2- updown£¬3-center */
            public byte byDigitalZoom;  /*ت‎×ضثُ·إ:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*»µµم¼ى²â,0 dsibale  1 enable*/
            public byte byBlackPwl;/*؛عµçئ½²¹³¥ ,  0-255*/
            public byte byEptzGate;// EPTZ؟ھ¹ط±نء؟:0-²»ئôسأµç×سشئج¨£¬1-ئôسأµç×سشئج¨
            public byte byLocalOutputGate;//±¾µطتن³ِ؟ھ¹ط±نء؟0-±¾µطتن³ِ¹ط±ص1-±¾µطBNCتن³ِ´ٍ؟ھ 2-HDMIتن³ِ¹ط±ص  
                                          //20-HDMI_720P50تن³ِ؟ھ
                                          //21-HDMI_720P60تن³ِ؟ھ
                                          //22-HDMI_1080I60تن³ِ؟ھ
                                          //23-HDMI_1080I50تن³ِ؟ھ
                                          //24-HDMI_1080P24تن³ِ؟ھ
                                          //25-HDMI_1080P25تن³ِ؟ھ
                                          //26-HDMI_1080P30تن³ِ؟ھ
                                          //27-HDMI_1080P50تن³ِ؟ھ
                                          //28-HDMI_1080P60تن³ِ؟ھ
            public byte byCoderOutputMode;//±àآëئ÷fpgaتن³ِؤ£ت½0ض±ح¨3دٌثط°ل¼ز
            public byte byLineCoding; //تا·ٌ؟ھئôذذ±àآë£؛0-·ٌ£¬1-تا
            public byte byDimmerMode; //µ÷¹âؤ£ت½£؛0-°ë×ش¶¯£¬1-×ش¶¯
            public byte byPaletteMode; //µ÷ة«°ه£؛0-°×بب£¬1-؛عبب£¬2-µ÷ة«°ه2£¬،­£¬8-µ÷ة«°ه8
            public byte byEnhancedMode; //شِا؟·½ت½£¨ج½²âخïجهضـ±ك£©£؛0-²»شِا؟£¬1-1£¬2-2£¬3-3£¬4-4
            public byte byDynamicContrastEN;    //¶¯ج¬¶ش±ب¶بشِا؟ 0-1
            public byte byDynamicContrast;    //¶¯ج¬¶ش±ب¶ب 0-100
            public byte byJPEGQuality;    //JPEGح¼دٌضتء؟ 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSؤ£ت½دآا°¶ث²خت‎إنضأ£¬¾µح·ؤ£ت½´سؤـء¦¼¯»ٌب،
            public byte byFilterSwitch; //آث²¨؟ھ¹ط£؛0-²»ئôسأ£¬1-ئôسأ
            public byte byFocusSpeed; //¾µح·µ÷½¹ثظ¶ب£؛0-10
            public byte byAutoCompensationInterval; //¶¨ت±×ش¶¯؟ىأإ²¹³¥£؛1-120£¬µ¥خ»£؛·ضضس
            public byte bySceneMode;  //³،¾°ؤ£ت½£؛0-تزحâ£¬1-تزؤع£¬2-ؤ¬بد£¬3-بُ¹â
            public NET_DVR_DEFOGCFG struDefogCfg;//ح¸خي²خت‎
            public NET_DVR_ELECTRONICSTABILIZATION struElectronicStabilization;//µç×س·ہ¶¶
            public NET_DVR_CORRIDOR_MODE_CCD struCorridorMode;//×كہبؤ£ت½
            public byte byExposureSegmentEnable; //0~²»ئôسأ,1~ئôسأ  ئط¹âت±¼ن؛حشِزو³ت½×جف×´µ÷صû£¬±ببçئط¹âحùةدµ÷صûت±£¬دبجل¸كئط¹âت±¼نµ½ضذ¼نضµ£¬ب»؛َجل¸كشِزوµ½ضذ¼نضµ£¬شظجل¸كئط¹âµ½×î´َضµ£¬×î؛َجل¸كشِزوµ½×î´َضµ
            public byte byBrightCompensate;//ءء¶بشِا؟ [0~100]

            /*0-¹ط±ص،¢1-640*480@25fps،¢2-640*480@30ps،¢3-704*576@25fps،¢4-704*480@30fps،¢5-1280*720@25fps،¢6-1280*720@30fps،¢
             * 7-1280*720@50fps،¢8-1280*720@60fps،¢9-1280*960@15fps،¢10-1280*960@25fps،¢11-1280*960@30fps،¢
             * 12-1280*1024@25fps،¢13--1280*1024@30fps،¢14-1600*900@15fps،¢15-1600*1200@15fps،¢16-1920*1080@15fps،¢
             * 17-1920*1080@25fps،¢18-1920*1080@30fps،¢19-1920*1080@50fps،¢20-1920*1080@60fps،¢21-2048*1536@15fps،¢22-2048*1536@20fps،¢
             * 23-2048*1536@24fps،¢24-2048*1536@25fps،¢25-2048*1536@30fps،¢26-2560*2048@25fps،¢27-2560*2048@30fps،¢
             * 28-2560*1920@7.5fps،¢29-3072*2048@25fps،¢30-3072*2048@30fps،¢31-2048*1536@12.5،¢32-2560*1920@6.25،¢
             * 33-1600*1200@25،¢34-1600*1200@30،¢35-1600*1200@12.5،¢36-1600*900@12.5،¢37-1600@900@15،¢38-800*600@25،¢39-800*600@30*/
            public byte byCaptureModeN; //تسئµتنبëؤ£ت½£¨Nضئ£©
            public byte byCaptureModeP; //تسئµتنبëؤ£ت½£¨Pضئ£©
            public NET_DVR_SMARTIR_PARAM struSmartIRParam; //؛ىحâ·إ¹‎±¬إنضأذإد¢
            public NET_DVR_PIRIS_PARAM struPIrisParam;//PIrisإنضأذإد¢¶شس¦byIrisMode×ض¶خ´س2-PIris1؟ھت¼ةْذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //³µإئرصة«
        public enum VCA_PLATE_COLOR
        {
            VCA_BLUE_PLATE = 0,//ہ¶ة«³µإئ
            VCA_YELLOW_PLATE,//»ئة«³µإئ
            VCA_WHITE_PLATE,//°×ة«³µإئ
            VCA_BLACK_PLATE,//؛عة«³µإئ
            VCA_GREEN_PLATE //آجة«³µإئ
        }

        //³µإئہàذح
        public enum VCA_PLATE_TYPE
        {
            VCA_STANDARD92_PLATE = 0,//±ê×¼أٌسأ³µسë¾ü³µ
            VCA_STANDARD02_PLATE,//02ت½أٌسأ³µإئ 
            VCA_WJPOLICE_PLATE,//خن¾¯³µ 
            VCA_JINGCHE_PLATE,//¾¯³µ
            STANDARD92_BACK_PLATE,//أٌسأ³µث«ذذخ²إئ
            VCA_SHIGUAN_PLATE,          //ت¹¹ف³µإئ
            VCA_NONGYONG_PLATE,         //إ©سأ³µ
            VCA_MOTO_PLATE              //ؤ¦حذ³µ
        }

        public enum VLR_VEHICLE_CLASS
        {
            VLR_OTHER = 0,   //ئنثü
            VLR_VOLKSWAGEN = 1,    //´َضع
            VLR_BUICK = 2,  //±ً؟ث
            VLR_BMW = 3,   //±¦آي
            VLR_HONDA = 4,   //±¾جï
            VLR_PEUGEOT = 5,   //±êضآ
            VLR_TOYOTA = 6,   //·لجï
            VLR_FORD = 7,  //¸£جط
            VLR_NISSAN = 8,  //بص²ْ
            VLR_AUDI = 9,  //°آµد
            VLR_MAZDA = 10,  //آي×ش´ï
            VLR_CHEVROLET = 11,   //ر©·ًہ¼
            VLR_CITROEN = 12,  //ر©جْءْ
            VLR_HYUNDAI = 13,   //دض´ْ
            VLR_CHERY = 14   //ئوبً
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VEHICLE_INFO
        {
            public uint dwIndex;
            public byte byVehicleType;
            public byte byColorDepth;
            public byte byColor;
            public byte byRes1;
            public ushort wSpeed;
            public ushort wLength;
            public byte byIllegalType;
            public byte byVehicleLogoRecog; //²خ؟¼أ¶¾ظہàذح VLR_VEHICLE_CLASS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byCustomInfo;  //×ش¶¨زهذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes2 = new byte [ 2 ];
                byCustomInfo = new byte [ 16 ];
                byRes = new byte [ 16 ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RESULT
        {
            public uint dwSize;
            public byte byResultType;
            public byte byChanIndex;
            public ushort wAlarmRecordID;	//±¨¾¯آ¼دٌID(سأسع²éر¯آ¼دٌ£¬½ِµ±byResultTypeخھ2ت±سذذ§)
            public uint dwRelativeTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAbsTime;
            public uint dwPicLen;
            public uint dwPicPlateLen;
            public uint dwVideoLen;
            public byte byTrafficLight;
            public byte byPicNum;
            public byte byDriveChan;
            public byte byVehicleType; //0- خ´ضھ£¬1- ؟ح³µ£¬2- »ُ³µ£¬3- ½خ³µ£¬4- أو°ü³µ£¬5- ذ،»ُ³µ
            public uint dwBinPicLen;
            public uint dwCarPicLen;
            public uint dwFarCarPicLen;
            public IntPtr pBuffer3;
            public IntPtr pBuffer4;
            public IntPtr pBuffer5;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_PLATE_INFO struPlateInfo;
            public NET_DVR_VEHICLE_INFO struVehicleInfo;
            public IntPtr pBuffer1;
            public IntPtr pBuffer2;

            public void Init()
            {
                byAbsTime = new byte [ 32 ];
                byRes3 = new byte [ 8 ];
            }
        }

        //ح¼دٌµ‏¼سذإد¢إنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IMAGEOVERLAYCFG
        {
            public uint dwSize;
            public byte byOverlayInfo;//µ‏¼ست¹ؤـ؟ھ¹ط£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayMonitorInfo;//تا·ٌµ‏¼س¼à²âµمذإد¢£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayTime;//تا·ٌµ‏¼ست±¼ن£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlaySpeed;//تا·ٌµ‏¼سثظ¶ب£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlaySpeeding;//تا·ٌµ‏¼س³¬ثظ±بہ‎£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayLimitFlag;//تا·ٌµ‏¼سدقثظ±êض¾£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayPlate;//تا·ٌµ‏¼س³µإئ؛إ£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayColor;//تا·ٌµ‏¼س³µةيرصة«£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayLength;//تا·ٌµ‏¼س³µ³¤£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayType;//تا·ٌµ‏¼س³µذح£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayColorDepth;//تا·ٌµ‏¼س³µةيرصة«ةîا³£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayDriveChan;//تا·ٌµ‏¼س³µµہ£¬0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayMilliSec; //µ‏¼س؛ءأëذإد¢ 0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayIllegalInfo; //µ‏¼سخ¥صآذإد¢ 0-²»µ‏¼س£¬1-µ‏¼س
            public byte byOverlayRedOnTime;  //µ‏¼س؛ىµئزرءءت±¼ن 0-²»µ‏¼س£¬1-µ‏¼س
            public byte byFarAddPlateJpeg;      //ش¶¾°ح¼تا·ٌµ‏¼س³µإئ½طح¼,0-²»µ‏¼س,1-µ‏¼س
            public byte byNearAddPlateJpeg;      //½ü¾°ح¼تا·ٌµ‏¼س³µإئ½طح¼,0-²»µ‏¼س,1-µ‏¼س
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo1;    //¼à²âµمذإد¢1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo2; //¼ى²âµمذإد¢2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPCFG
        {
            public uint dwSize;
            public byte byRelatedDriveWay;
            public byte bySnapTimes;
            public ushort wSnapWaitTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public enum ITC_MAINMODE_ABILITY
        {
            ITC_MODE_UNKNOW = 0x0,   //خق
            ITC_POST_MODE = 0x1,  //؟¨؟عؤ£ت½
            ITC_EPOLICE_MODE = 0x2,  //µç¾¯ؤ£ت½
            ITC_POSTEPOLICE_MODE = 0x4  //؟¨ت½µç¾¯ؤ£ت½
        }

        public enum ITC_RECOG_REGION_TYPE
        {
            ITC_REGION_RECT = 0x0,   //¾طذخ
            ITC_REGION_POLYGON = 0x1,  //¶à±كذخ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAP_ABILITY
        {
            public uint dwSize;
            public byte byIoInNum;//IOتنبë؟عت‎
            public byte byIoOutNum;//IOتن³ِ؟عت‎
            public byte bySingleSnapNum;//µ¥IO´¥·¢×éت‎
            public byte byLightModeArrayNum;//؛ىآجµئؤ£ت½×éت‎
            public byte byMeasureModeArrayNum;//²âثظؤ£ت½×éت‎
            public byte byPlateEnable; //³µإئت¶±ًؤـء¦
            public byte byLensMode;//¾µح·ؤ£ت½0-CCD,1-CMOS
            public byte byPreTriggerSupport; //تا·ٌض§³ضش­´¥·¢ؤ£ت½£¬0-ض§³ض£¬1-²»ض§³ض
            public uint dwAbilityType; //ض§³ضµؤ´¥·¢ؤ£ت½ؤـء¦£¬°´خ»±يت¾£¬¶¨زه¼ûITC_MAINMODE_ABILITY
            public byte byIoSpeedGroup; //ض§³ضµؤIO²âثظ×éت‎
            public byte byIoLightGroup; //ض§³ضµؤIO؛ىآجµئ×éت‎
            public byte byRecogRegionType; //إئت¶اّسٍض§³ضµؤہàذح£¬دê¼û¶¨زهITC_RECOG_REGION_TYPE
            public byte bySupport; //ةè±¸ؤـء¦£¬°´خ»±يت¾£¬0-²»ض§³ض£¬1-ض§³ض
                                   // bySupport&0x1£¬±يت¾تا·ٌض§³ضہ©ص¹µؤ×ض·ûµ‏¼سإنضأ
                                   // bySupport&0x2£¬±يت¾تا·ٌض§³ضہ©ص¹µؤذ£ت±إنضأ½ل¹¹
                                   // bySupport&0x4, ±يت¾تا·ٌض§³ض¶àحّ؟¨(¶àحّ¸ôہë)
                                   // bySupport&0x8, ±يت¾تا·ٌض§³ضحّ؟¨µؤbonding¹¦ؤـ(حّآçبف´ي)
                                   // bySupport&0x10, ±يت¾تا·ٌض§³ضسïزô¶ش½²
                                   //2013-07-09 ؤـء¦¼¯·µ»ط
            public ushort wSupportMultiRadar;// ةè±¸ؤـء¦£¬°´خ»±يت¾£¬0-²»ض§³ض£¬1-ض§³ض
                                             // wSupportMultiRadar&0x1£¬±يت¾ ؟¨؟عRS485ہ×´ï ض§³ض³µµہ¹طءھہ×´ï´¦ہي
                                             // wSupportMultiRadar&0x2£¬±يت¾ ؟¨؟عذéؤâدكب¦ ض§³ض³µµہ¹طءھہ×´ï´¦ہي
                                             // wSupportMultiRadar&0x4£¬±يت¾ »ىذذ؟¨؟ع ض§³ض³µµہ¹طءھہ×´ï´¦ہي
                                             // wSupportMultiRadar&0x8£¬±يت¾ تسئµ¼ى²â ض§³ض³µµہ¹طءھہ×´ï´¦ہي
            public byte byICRPresetNum;
            // ±يت¾ض§³ضµؤICRش¤ضأµم£¨آث¹âئ¬ئ«زئµم£©ت‎
            public byte byICRTimeSlot;//±يت¾ض§³ضµؤICRµؤت±¼ن¶خت‎£¨1،«8£©
            public byte bySupportRS485Num;//±يت¾ض§³ضµؤRS485؟عµؤت‎ء؟
            public byte byExpandRs485SupportSensor;// ةè±¸ؤـء¦£¬°´خ»±يت¾£¬0-²»ض§³ض£¬1-ض§³ض
                                                   // byExpandRs485SupportSensor &0x1£¬±يت¾µç¾¯³µ¼ىئ÷ض§³ض³µ¼ىئ÷
                                                   // byExpandRs485SupportSensor &0x2£¬±يت¾؟¨ت½µç¾¯³µ¼ىئ÷ض§³ض³µ¼ىئ÷
            public byte byExpandRs485SupportSignalLampDet;// ةè±¸ؤـء¦£¬°´خ»±يت¾£¬0-²»ض§³ض£¬1-ض§³ض
                                                          // byExpandRs485SupportSignalLampDet &0x1£¬±يت¾µç¾¯³µ¼ىئ÷ض§³ضحâ½سذإ؛إµئ¼ى²âئ÷
                                                          // byExpandRs485SupportSignalLampDet &0x2£¬±يت¾؟¨ت½µç¾¯³µ¼ىئ÷ض§³ضحâ½سذإ؛إµئ¼ى²âئ÷
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRTIMECFG
        {
            public NET_DVR_SCHEDTIME  struTime;
            public byte byAssociateRresetNo;//ش¤ضأµم؛إ1،«8 , 0´ْ±يخق
            public byte bySubSwitchMode;//1~°×جى£¬2~حيةد (µ±ش¤ضأµمµبسع0 µؤت±؛ٍةْذ§)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_TIMESWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_ICRTIMECFG[] struAutoCtrlTime;//×ش¶¯اذ»»ت±¼ن¶خ (×ش¶¯اذ»»دآ ت±؟صدآةْذ§ دضشعض§³ض4×é£¬ش¤ءô4×é)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //تµ¼تةْذ§¸ù¾فؤـء¦¼¯¶¯ج¬دشت¾ [0~100] ت‎×éدآ±ê±يت¾ش¤ضأµم؛إ1،«8 £¨0،«7 دà¶شس¦£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_MANUALSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //تµ¼تةْذ§¸ù¾فؤـء¦¼¯¶¯ج¬دشت¾ [0~100]
            public byte  bySubSwitchMode;//1~°×جى£¬2~حيةد
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_AOTOSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //تµ¼تةْذ§¸ù¾فؤـء¦¼¯¶¯ج¬دشت¾ [0~100] ت‎×éدآ±ê±يت¾ش¤ضأµم؛إ1،«8 £¨0،«7 دà¶شس¦£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 148, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 156, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;
            public NET_ITC_ICR_AOTOSWITCH_PARAM struICRAutoSwitch;
            public NET_ITC_ICR_MANUALSWITCH_PARAM struICRManualSwitch;
            public NET_ITC_ICR_TIMESWITCH_PARAM struICRTimeSwitch;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRCFG
        {
            public uint dwSize;
            public byte bySwitchType;//1~×ش¶¯اذ»»£¬2~تض¶¯اذ»» ,3~¶¨ت±اذ»» 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_ITC_ICR_PARAM_UNION uICRParam;
        }

        //2013-07-09 زى³£´¦ہي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_HANDLEEXCEPTION
        {
            public uint dwHandleType; //زى³£´¦ہي,زى³£´¦ہي·½ت½µؤ"»ٍ"½ل¹û
                                      /*0x00: خقدىس¦*/
                                      /*0x01: ¼àتسئ÷ةد¾¯¸و*/
                                      /*0x02: ةùزô¾¯¸و*/
                                      /*0x04: ةد´«ضذذؤ*/
                                      /*0x08: ´¥·¢±¨¾¯تن³ِ£¨¼جµçئ÷تن³ِ£©*/
                                      /*0x10: ´¥·¢JPRG×¥ح¼²¢ةد´«Email*/
                                      /*0x20: خقدكةù¹â±¨¾¯ئ÷ءھ¶¯*/
                                      /*0x40: ءھ¶¯µç×سµطح¼(ؤ؟ا°ض»سذPCNVRض§³ض)*/
                                      /*0x200: ×¥ح¼²¢ةد´«FTP*/
            public byte byEnable; //0،«²»ئôسأ£¬1،«ئôسأ
            public byte byRes;
            public ushort wDuration;//³ضذّت±¼ن(µ¥خ»/s)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_EXCEPTIONOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutTriggered;//´¥·¢تن³ِح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_HANDLEEXCEPTION[] struSnapExceptionType;
            //ت‎×éµؤأ؟¸ِشھثط¶¼±يت¾ز»ضضزى³££¬ت‎×é0- س²إج³ِ´ي,1-حّدك¶د,2-IP µطض·³هح», 3-³µ¼ىئ÷زى³£, 4-ذإ؛إµئ¼ى²âئ÷زى³£
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIGCOORDINATE
        {
            public ushort wTopLeftX; /*دكب¦×َةد½ا؛ل×ّ±ê£¨2¸ِ×ض½ع£©*/
            public ushort wTopLeftY; /*دكب¦×َةد½ا×ف×ّ±ê£¨2¸ِ×ض½ع£©*/
            public ushort wWdith; /*دكب¦؟ي¶ب£¨2¸ِ×ض½ع£©*/
            public ushort wHeight; /*دكب¦¸ك¶ب£¨2¸ِ×ض½ع£©*/
        }

        public enum PROVINCE_CITY_IDX
        {
            ANHUI_PROVINCE = 0,              //°²»ص
            AOMEN_PROVINCE = 1,              //°ؤأإ
            BEIJING_PROVINCE = 2,              //±±¾©
            CHONGQING_PROVINCE = 3,              //ضطاى
            FUJIAN_PROVINCE = 4,              //¸£½¨
            GANSU_PROVINCE = 5,              //¸تثà
            GUANGDONG_PROVINCE = 6,              //¹م¶«
            GUANGXI_PROVINCE = 7,              //¹مخ÷
            GUIZHOU_PROVINCE = 8,              //¹َضف
            HAINAN_PROVINCE = 9,              //؛£ؤد
            HEBEI_PROVINCE = 10,             //؛س±±
            HENAN_PROVINCE = 11,             //؛سؤد
            HEILONGJIANG_PROVINCE = 12,             //؛عءْ½­
            HUBEI_PROVINCE = 13,             //؛‏±±
            HUNAN_PROVINCE = 14,             //؛‏ؤد
            JILIN_PROVINCE = 15,             //¼ھءض
            JIANGSU_PROVINCE = 16,             //½­ثص
            JIANGXI_PROVINCE = 17,             //½­خ÷
            LIAONING_PROVINCE = 18,             //ءةؤ‏
            NEIMENGGU_PROVINCE = 19,             //ؤعأة¹إ
            NINGXIA_PROVINCE = 20,             //ؤ‏دؤ
            QINGHAI_PROVINCE = 21,             //اà؛£
            SHANDONG_PROVINCE = 22,             //ة½¶«
            SHANXI_JIN_PROVINCE = 23,             //ة½خ÷
            SHANXI_SHAN_PROVINCE = 24,             //ةآخ÷
            SHANGHAI_PROVINCE = 25,             //ةد؛£
            SICHUAN_PROVINCE = 26,             //ثؤ´¨
            TAIWAN_PROVINCE = 27,             //ج¨حه
            TIANJIN_PROVINCE = 28,             //جى½ٍ
            XIZANG_PROVINCE = 29,             //خ÷²ط
            XIANGGANG_PROVINCE = 30,             //دم¸غ
            XINJIANG_PROVINCE = 31,             //ذآ½®
            YUNNAN_PROVINCE = 32,             //شئؤد
            ZHEJIANG_PROVINCE = 33              //صم½­
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GEOGLOCATION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public int[] iRes; /*±£ءô*/
            public uint dwCity; /*³اتذ£¬دê¼ûPROVINCE_CITY_IDX */
        }

        //³،¾°ؤ£ت½
        public enum SCENE_MODE
        {
            UNKOWN_SCENE_MODE = 0,            //خ´ضھ³،¾°ؤ£ت½
            HIGHWAY_SCENE_MODE = 1,            //¸كثظ³،¾°ؤ£ت½
            SUBURBAN_SCENE_MODE = 2,            //½¼اّ³،¾°ؤ£ت½(±£ءô)
            URBAN_SCENE_MODE = 3,            //تذاّ³،¾°ؤ£ت½
            TUNNEL_SCENE_MODE = 4             //ثيµہ³،¾°ؤ£ت½(±£ءô)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VTPARAM
        {
            public uint dwSize;
            public byte byEnable;  /* تا·ٌت¹ؤـذéؤâدكب¦£¬0-²»ت¹سأ£¬1-ت¹سأ*/
            public byte byIsDisplay; /* تا·ٌدشت¾ذéؤâدكب¦£¬0-²»دشت¾£¬1-دشت¾*/
            public byte byLoopPos; //حي¼ن´¥·¢دكب¦µؤئ«دٍ£؛0-دٍةد£¬1-دٍدآ
            public byte bySnapGain; /*×¥إؤشِزو*/
            public uint dwSnapShutter; /*×¥إؤ؟ىأإثظ¶ب*/
            public NET_DVR_TRIGCOORDINATE struTrigCoordinate; //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TRIGCOORDINATE[] struRes;
            public byte byTotalLaneNum;/*تسئµ´¥·¢µؤ³µµہت‎1*/
            public byte byPolarLenType; /*ئ«صٌ¾µہàذح£¬0£؛²»¼سئ«صٌ¾µ£»1£؛¼ست©ؤحµآئ«صٌ¾µ،£*/
            public byte byDayAuxLightMode; /*°×جى¸¨ضْصصأ÷ؤ£ت½£¬0£؛خق¸¨ضْصصأ÷£»1£؛LEDµئصصأ÷£»2£؛ةء¹âµئصصأ÷*/
            public byte byLoopToCalRoadBright; /*سأزش¼ئثمآ·أوءء¶بµؤ³µµہ(ذéؤâدكب¦)*/
            public byte byRoadGrayLowTh; /*آ·أوءء¶بµحمذضµ³ُت¼»¯ضµ1*/
            public byte byRoadGrayHighTh; /*آ·أوءء¶ب¸كمذضµ³ُت¼»¯ضµ140*/
            public ushort wLoopPosBias; /*حي¼ن´¥·¢دكب¦خ»زئ30*/
            public uint dwHfrShtterInitValue; /*ء¬ذّح¼دٌئط¹âت±¼نµؤ³ُت¼ضµ2000*/
            public uint dwSnapShtterInitValue; /*×¥إؤح¼دٌئط¹âت±¼نµؤ³ُت¼ضµ500*/
            public uint dwHfrShtterMaxValue; /*ء¬ذّح¼دٌئط¹âت±¼نµؤ×î´َضµ20000*/
            public uint dwSnapShtterMaxValue; /*×¥إؤح¼دٌئط¹âت±¼نµؤ×î´َضµ1500*/
            public uint dwHfrShtterNightValue; /*حي¼نء¬ذّح¼دٌئط¹âت±¼نµؤةèضأضµ3000*/
            public uint dwSnapShtterNightMinValue; /*حي¼ن×¥إؤح¼دٌئط¹âت±¼نµؤ×îذ،ضµ3000*/
            public uint dwSnapShtterNightMaxValue; /*حي¼ن×¥إؤح¼دٌئط¹âت±¼نµؤ×î´َضµ5000*/
            public uint dwInitAfe; /*شِزوµؤ³ُت¼ضµ200*/
            public uint dwMaxAfe; /*شِزوµؤ×î´َضµ400*/
            public ushort wResolutionX;/* ةè±¸µ±ا°·ض±وآت؟ي*/
            public ushort wResolutionY;/* ةè±¸µ±ا°·ض±وآت¸ك*/
            public uint dwGainNightValue; /*حي¼نشِزو£¬ؤ¬بدضµ70*/
            public uint dwSceneMode; /*³،¾°ؤ£ت½£¬ دê¼ûSCENE_MODE */
            public uint dwRecordMode; /*آ¼دٌ±êض¾£؛0-²»آ¼دٌ£¬1-آ¼دٌ*/
            public NET_DVR_GEOGLOCATION struGeogLocation; /*µطض·خ»ضأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigFlag; /*´¥·¢±êض¾£¬0-³µح·´¥·¢£»1-³µخ²´¥·¢£»2-³µح·/³µخ²¶¼´¥·¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigSensitive;  /*´¥·¢ءéأô¶ب£¬1-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPENABLECFG
        {
            public uint dwSize;
            public byte byPlateEnable;//تا·ٌض§³ض³µإئت¶±ً£¬0-²»ض§³ض£¬1-ض§³ض
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   //±£ءô
            public byte byFrameFlip;   //ح¼دٌتا·ٌ·­×ھ 0-²»·­×ھ£¬1-·­×ھ
            public ushort wFlipAngle;    //ح¼دٌ·­×ھ½ا¶ب 0,90,180,270
            public ushort wLightPhase;   //دàخ»£¬ب،ضµ·¶خ§[0, 360]
            public byte byLightSyncPower;  //تا·ٌذإ؛إµئµçش´ح¬²½£¬0-²»ح¬²½£»1-ح¬²½
            public byte byFrequency;		//ذإ؛إئµآت
            public byte byUploadSDEnable;  //تا·ٌ×ش¶¯ةد´«SDح¼ئ¬£¬0-·ٌ£»1-تا
            public byte byPlateMode; //ت¶±ًؤ£ت½²خت‎:0-تسئµ´¥·¢,1-حâ²؟´¥·¢
            public byte byUploadInfoFTP; //تا·ٌةد´«×¥إؤ¸½¼سذإد¢µ½FTP£¬0-·ٌ£¬1-تا
            public byte byAutoFormatSD; //تا·ٌ×ش¶¯¸ٌت½»¯SD؟¨£¬0-·ٌ£¬1-تا
            public ushort wJpegPicSize; //Jpegح¼ئ¬´َذ،[64-8196]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        /*ftpةد´«²خت‎*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FTPCFG
        {
            public uint dwSize;
            public uint dwEnableFTP;			/*تا·ٌئô¶¯ftpةد´«¹¦ؤـ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFTPIP;				/*ftp ·‏خٌئ÷*/
            public uint dwFTPPort;				/*ftp¶ث؟ع*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*سأ»§أû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/*أـآë*/
            public uint dwDirLevel;	/*0 = ²»ت¹سأؤ؟آ¼½ل¹¹£¬ض±½س±£´وشع¸ùؤ؟آ¼,1 = ت¹سأ1¼¶ؤ؟آ¼,2=ت¹سأ2¼¶ؤ؟آ¼*/
            public ushort wTopDirMode;	/* ز»¼¶ؤ؟آ¼£¬0x1 = ت¹سأةè±¸أû,0x2 = ت¹سأةè±¸؛إ,0x3 = ت¹سأةè±¸ipµطض·£¬0x4=ت¹سأ¼à²âµم,0x5=ت¹سأت±¼ن(ؤêشآ),0x=6×ش¶¨زه,0x7=خ¥¹وہàذح,0x8=·½دٍ,0x9=µطµم*/
            public ushort wSubDirMode;	/* ¶‏¼¶ؤ؟آ¼£¬0x1 = ت¹سأح¨µہأû,0x2 = ت¹سأح¨µہ؛إ£¬,0x3=ت¹سأت±¼ن(ؤêشآبص),0x4=ت¹سأ³µµہ؛إ,0x=5×ش¶¨زه,0x6=خ¥¹وہàذح,0x7=·½دٍ,0x8=µطµم*/
            public byte byEnableAnony; //ئôسأؤنأû£¬0-·ٌ£¬1-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*؟ةسأہ´أüأûح¼ئ¬µؤدà¹طشھثط */
        public const int PICNAME_ITEM_DEV_NAME = 1;		/*ةè±¸أû*/
        public const int PICNAME_ITEM_DEV_NO = 2;		/*ةè±¸؛إ*/
        public const int PICNAME_ITEM_DEV_IP = 3;		/*ةè±¸IP*/
        public const int PICNAME_ITEM_CHAN_NAME = 4;	/*ح¨µہأû*/
        public const int PICNAME_ITEM_CHAN_NO = 5;		/*ح¨µہ؛إ*/
        public const int PICNAME_ITEM_TIME = 6;		/*ت±¼ن*/
        public const int PICNAME_ITEM_CARDNO = 7;		/*؟¨؛إ*/
        public const int PICNAME_ITEM_PLATE_NO = 8;   /*³µإئ؛إآë*/
        public const int PICNAME_ITEM_PLATE_COLOR = 9;   /*³µإئرصة«*/
        public const int PICNAME_ITEM_CAR_CHAN = 10;  /*³µµہ؛إ*/
        public const int PICNAME_ITEM_CAR_SPEED = 11;  /*³µء¾ثظ¶ب*/
        public const int PICNAME_ITEM_CARCHAN = 12;  /*¼à²âµم*/
        public const int PICNAME_ITEM_PIC_NUMBER = 13;  //ح¼ئ¬ذٍ؛إ
        public const int PICNAME_ITEM_CAR_NUMBER = 14;  //³µء¾ذٍ؛إ

        public const int PICNAME_ITEM_SPEED_LIMIT_VALUES = 15; //دقثظضµ
        public const int PICNAME_ITEM_ILLEGAL_CODE = 16; //¹ْ±êخ¥·¨´ْآë
        public const int PICNAME_ITEM_CROSS_NUMBER = 17; //آ·؟ع±à؛إ
        public const int PICNAME_ITEM_DIRECTION_NUMBER = 18; //·½دٍ±à؛إ

        public const int PICNAME_MAXITEM = 15;
        //ح¼ئ¬أüأû
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	èٌت‎×é¶¨زهخؤ¼‏أüأûµؤ¹وشٍ */
            public byte byDelimiter;		/*·ض¸ô·û£¬ز»°مخھ'_'*/
        }


        //أüأû¹وشٍ£؛2013-09-27
        public const int PICNAME_ITEM_PARK_DEV_IP = 1;	/*ةè±¸IP*/
        public const int PICNAME_ITEM_PARK_PLATE_NO = 2;/*³µإئ؛إآë*/
        public const int PICNAME_ITEM_PARK_TIME = 3;	/*ت±¼ن*/
        public const int PICNAME_ITEM_PARK_INDEX = 4;   /*³µخ»±à؛إ*/
        public const int PICNAME_ITEM_PARK_STATUS = 5;  /*³µخ»×´ج¬*/

        //ح¼ئ¬أüأûہ©ص¹ 2013-09-27
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	èٌت‎×é¶¨زهخؤ¼‏أüأûµؤ¹وشٍ */
            public byte byDelimiter;	            	/*·ض¸ô·û£¬ز»°مخھ'_'*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                      /*±£ءô*/
        }

        /* ´®؟ع×¥ح¼ةèضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CATCHPIC_PARA
        {
            public byte byStrFlag;	/*´®؟عت‎¾ف؟ھت¼·û*/
            public byte byEndFlag;	/*½لتّ·û*/
            public ushort wCardIdx;	/*؟¨؛إدà¶شئًت¼خ»*/
            public uint dwCardLen;	/*؟¨؛إ³¤¶ب*/
            public uint dwTriggerPicChans;	/*ثù´¥·¢µؤح¨µہ؛إ£¬°´خ»£¬´سµع1خ»؟ھت¼¼ئ£¬¼´0x2±يت¾µعز»ح¨µہ*/
        }

        //DVR×¥ح¼²خت‎إنضأ£¨»ùدك£©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_JPEGPARA[] struJpegPara;	/*أ؟¸ِح¨µہµؤح¼دٌ²خت‎*/
            public ushort wBurstMode;							/*×¥ح¼·½ت½,°´خ»ةèضأ.0x1=±¨¾¯تنبë´¥·¢£¬0x2=زئ¶¯صى²â´¥·¢ 0x4=232´¥·¢£¬0x8=485´¥·¢£¬0x10=حّآç´¥·¢*/
            public ushort wUploadInterval;					/*ح¼ئ¬ةد´«¼ن¸ô(أë)[0,65535]*/
            public NET_DVR_PICTURE_NAME     struPicNameRule;	/* ح¼ئ¬أüأû¹وشٍ */
            public byte bySaveToHD;		/*تا·ٌ±£´وµ½س²إج*/
            public byte byRes1;
            public ushort wCatchInterval;		/*×¥ح¼¼ن¸ô(؛ءأë)[0,65535]*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs232Cfg;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs485Cfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwTriggerPicTimes;	/* أ؟¸ِح¨µہز»´خ´¥·¢إؤصص´خت‎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAlarmInPicChanTriggered; /*±¨¾¯´¥·¢×¥إؤح¨µہ,°´خ»ةèضأ£¬´سµع1خ»؟ھت¼*/
        }

        //×¥إؤ´¥·¢اëاَ½ل¹¹(±£ءô)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUALSNAP
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SPRCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHJC_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDefaultCHN; /*ةè±¸شثذذت،·فµؤ؛؛×ض¼ٍذ´*/
            public byte byPlateOSD;    /*0:²»·¢ثح³µإئ²تة«ح¼,1:·¢ثح³µإئ²تة«ح¼*/
            public byte bySendJPEG1;   /*0-²»´«ثح½ü¾°JPEGح¼,1-´«ثح½ü¾°JPEGح¼*/
            public byte bySendJPEG2;   /*0-²»´«ثحش¶¾°JPEGح¼,1-´«ثحش¶¾°JPEGح¼*/
            public ushort wDesignedPlateWidth;   /*³µإئةè¼ئ؟ي¶ب*/
            public byte byTotalLaneNum;  /*ت¶±ًµؤ³µµہت‎*/
            public byte byRes1;      /*±£ءô*/
            public ushort wRecognizedLane;  /*ت¶±ًµؤ³µµہ؛إ£¬°´خ»±يت¾£¬bit0±يت¾³µµہ1تا·ٌت¶±ً£¬0-²»ت¶±ً£¬1-ت¶±ً*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANERECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect;  /*³µµہت¶±ًاّسٍ*/
            public uint dwRecogMode;  /*ت¶±ًµؤہàذح£¬
	        bit0-±³دٍت¶±ً£؛0-ص‎دٍ³µإئت¶±ً£¬1-±³دٍت¶±ً(خ²إئت¶±ً) £» 
		    bit1-´َ³µإئت¶±ً»ٍذ،³µإئت¶±ً£؛0-ذ،³µإئت¶±ً£¬1-´َ³µإئت¶±ً £»
		    bit2-³µةيرصة«ت¶±ً£؛0-²»²ةسأ³µةيرصة«ت¶±ً£¬شع±³دٍت¶±ً»ٍذ،³µإئت¶±ًت±½ûض¹ئôسأ£¬1-³µةيرصة«ت¶±ً£»
		    bit3-إ©سأ³µت¶±ً£؛0-²»²ةسأإ©سأ³µت¶±ً£¬1-إ©سأ³µت¶±ً£» 
		    bit4-ؤ£؛‎ت¶±ً£؛0-²»²ةسأؤ£؛‎ت¶±ً£¬1-ؤ£؛‎ت¶±ً£»
		    bit5-ض،¶¨خ»»ٍ³،¶¨خ»£؛0-ض،¶¨خ»£¬1-³،¶¨خ»£»
		    bit6-ض،ت¶±ً»ٍ³،ت¶±ً£؛0-ض،ت¶±ً£¬1-³،ت¶±ً£» 
		    bit7-حيةد»ٍ°×جى£؛0-°×جى£¬1-حيةد */
            public byte bySendPRRaw;       	//تا·ٌ·¢ثحش­ح¼£؛0-²»·¢ثح£¬1-·¢ثح 
            public byte bySendBinImage;  	//تا·ٌ·¢ثح³µإئ¶‏ضµح¼£؛0-²»·¢ثح£¬1-·¢ثح 
            public byte byDelayCapture;  //رست±×¥إؤ؟طضئ,µ¥خ»£؛ض،
            public byte byUseLED;    //ت¹سأLED؟طضئ£¬0-·ٌ£¬1-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLCCFG
        {
            public uint dwSize;
            public byte byPlcEnable;	//تا·ٌئôسأ³µإئءء¶ب²¹³¥£¨ؤ¬بدئôسأ£©£؛0-¹ط±ص£¬1-ئôسأ 
            public byte byPlateExpectedBright;	//³µإئµؤش¤ئعءء¶ب£¨ؤ¬بدضµ50£©, ·¶خ§[0, 100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±£ءô 
            public byte byTradeoffFlash;     //تا·ٌ؟¼آاةء¹âµئµؤس°دى: 0 - ·ٌ;  1 - تا(ؤ¬بد); 
                                             //ت¹سأةء¹âµئ²¹¹âت±, بç¹û؟¼آا¼ُبُةء¹âµئµؤءء¶بشِا؟ذ§س¦, شٍذèزھةèخھ1;·ٌشٍخھ0
            public byte byCorrectFactor;     //¾ہص‎دµت‎, ·¶خ§[0, 100], ؤ¬بدضµ50 (شعtradeoff_flashاذ»»ت±,»ض¸´ؤ¬بدضµ£©
            public ushort wLoopStatsEn;  //تا·ٌ¸أدكب¦µؤءء¶ب£¬°´خ»±يت¾£¬0-²»ح³¼ئ£¬1-ح³¼ئ
            public byte byPlcBrightOffset;// ³µإئءء¶ب²¹³¥ءéأô¶ب(ذéؤâدكب¦ؤ£ت½ئًذ§)£¬ب،ضµ·¶خ§1~100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICESTATECFG
        {
            public uint dwSize;
            public ushort wPreviewNum; //ش¤ہہء¬½س¸ِت‎
            public ushort wFortifyLinkNum; //²¼·ہء¬½س¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struPreviewIP;  //ش¤ہہµؤسأ»§IPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struFortifyIP; //²¼·ہء¬½سµؤسأ»§IPµطض·
            public uint dwVideoFrameRate;	//ض،آت£؛0-ب«²؟; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
            public byte byResolution;  	//·ض±وآت0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5£¨±£ءô£©,16-VGA£¨640*480£©, 17-UXGA£¨1600*1200£©, 18-SVGA £¨800*600£©,19-HD720p£¨1280*720£©,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte bySnapResolution;  	//×¥إؤ·ض±وآت0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5£¨±£ءô£©,16-VGA£¨640*480£©, 17-UXGA£¨1600*1200£©, 18-SVGA £¨800*600£©,19-HD720p£¨1280*720£©,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte byStreamType; //´«تنہàذح£؛0-ض÷آëء÷£»1-×سآëء÷
            public byte byTriggerType; //´¥·¢ؤ£ت½£؛0-تسئµ´¥·¢£»1-ئصح¨´¥·¢
            public uint dwSDVolume;  //SD؟¨بفء؟
            public uint dwSDFreeSpace; //SD؟¨ت£سà؟ص¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DRIVECHAN_NUM * MAX_COIL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDetectorState;  //³µ¼ىئ÷×´ج¬£؛0-خ´ت¹سأ£»1-ص‎³££»2-زى³£
            public byte byDetectorLinkState; //³µ¼ىئ÷ء¬½س×´ج¬£؛0-خ´ء¬½س£»1-ء¬½س
            public byte bySDStatus;    //SD؟¨×´ج¬ 0£­»î¶¯£»1£­ذفأك£»2£­زى³££¬3-خقsd؟¨
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byFortifyLevel; //²¼·ہµب¼¶£¬0-خق£¬1-ز»µب¼¶£¨¸ك£©£¬2-¶‏µب¼¶£¨ضذ£©£¬3-ب‎µب¼¶£¨µح£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSTEPOLICECFG
        {
            public uint dwSize;
            public uint dwDistance;//دكب¦¾àہë,µ¥خ»cm£¬ب،ضµ·¶خ§[0,20000]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SIGNALLIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLightChan;	//ذإ؛إµئح¨µہ؛إ
            public byte byCapSpeed;//±êض¾دقثظ£¬µ¥خ»km/h£¬ب،ضµ·¶خ§[0,255]
            public byte bySpeedLimit;//دقثظضµ£¬µ¥خ»km/h£¬ب،ضµ·¶خ§[0,255]
            public byte byTrafficDirection;//³µء÷·½دٍ£¬0-سة¶«دٍخ÷£¬1-سةخ÷دٍ¶«£¬2-سةؤددٍ±±£¬3-سة±±دٍؤد
            public byte byRes1; //±£ءô
            public ushort wLoopPreDist;        /*´¥·¢رس³ظ¾àہë £¬µ¥خ»£؛·ضأ×*/
            public ushort wTrigDelay;             /*´¥·¢س²رست±ت±¼ن £¬µ¥خ»£؛؛ءأë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô×ض½ع
        }
        /***************************** end *********************************************/
        public const int IPC_PROTOCOL_NUM = 50;  //ipc ذ­زé×î´َ¸ِت‎

        //ذ­زéہàذح
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE
        {
            public uint dwType;               /*ipcذ­زéضµ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = DESC_LEN)]
            public string byDescribe; /*ذ­زéأèتِ×ض¶خ*/
        }

        //ذ­زéءذ±ي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PROTO_LIST
        {
            public uint dwSize;
            public uint dwProtoNum;           /*سذذ§µؤipcذ­زéت‎ؤ؟*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = IPC_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struProto;   /*سذذ§µؤipcذ­زé*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_ALERTLINE_NUM = 8; //×î´َ¾¯½ندكجُت‎	

        //ش½½çصى²â²éر¯جُ¼‏
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRAVERSE_PLANE_SEARCHCOND
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALERTLINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_TRAVERSE_PLANE[] struVcaTraversePlane;  //´©ش½¾³½çأو²خت‎
            public uint dwPreTime;   /*ضاؤـ±¨¾¯جلا°ت±¼ن µ¥خ»:أë*/
            public uint dwDelayTime; /*ضاؤـ±¨¾¯رس³ظت±¼ن µ¥خ»:أë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        public const int MAX_INTRUSIONREGION_NUM = 8; //×î´َاّسٍت‎ت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INTRUSION_SEARCHCOND
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTRUSIONREGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_INTRUSION[] struVcaIntrusion; //بëاضاّسٍ
            public uint dwPreTime;   /*ضاؤـ±¨¾¯جلا°ت±¼ن µ¥خ»:أë*/
            public uint dwDelayTime; /*ضاؤـ±¨¾¯رس³ظت±¼ن µ¥خ»:أë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }


        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_AREA_SMARTSEARCH_COND_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;  //½ل¹¹جه³¤¶ب
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope; //صى²âاّسٍ 0-96خ»±يت¾64ذذ£¬¹²سذ96*64¸ِذ،؛ê؟é£¬1-تازئ¶¯صى²âاّسٍ£¬0-·ازئ¶¯صى²âاّسٍ 
            [FieldOffsetAttribute(0)]
            public NET_DVR_TRAVERSE_PLANE_SEARCHCOND struTraversPlaneCond; //ش½½çصى²â
            [FieldOffsetAttribute(0)]
            public NET_DVR_INTRUSION_SEARCHCOND struIntrusionCond; //اّسٍبëاض
        }

        //ضاؤـثرث÷²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_PARAM
        {
            public byte byChan;					//ح¨µہ؛إ
            public byte bySearchCondType; //ضاؤـ²éصزءھ؛دجهNET_DVR_AREA_SMARTSEARCH_COND_UNIONµؤث÷ز‎     
                                          /*0-زئ¶¯صى²âاّسٍ £¬1-ش½½çصى²â£¬ 2-اّسٍبëاض*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struStartTime;		//آ¼دٌ؟ھت¼µؤت±¼ن
            public NET_DVR_TIME struEndTime;		//آ¼دٌح£ض¹µؤت±¼ن
            public NET_DVR_AREA_SMARTSEARCH_COND_UNION uSmartSearchCond;  //ضاؤـ²éصزجُ¼‏
            public byte bySensitivity;   			//زئ¶¯صى²âثرث÷ءéأô¶ب,1	>80%  2 40%~80%  3 1%~40%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_RET
        {
            public NET_DVR_TIME struStartTime;	//زئ¶¯صى²â±¨¾¯؟ھت¼µؤت±¼ن
            public NET_DVR_TIME struEndTime;   //تآ¼‏ح£ض¹µؤت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IPSAN خؤ¼‏ؤ؟آ¼²éصز
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_PARAM
        {
            public NET_DVR_IPADDR  struIP;     // IPSAN IPµطض·
            public ushort wPort;      // IPSAN  ¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectory;  // ·µ»طµؤخؤ¼‏ؤ؟آ¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVRةè±¸²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName; //DVRأû³ئ
            public uint dwDVRID;				//DVR ID,سأسعز£؟طئ÷ //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;		//تا·ٌر­»·آ¼دٌ,0:²»تا; 1:تا
            //زشدآ²»؟ة¸ü¸ؤ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber; //ذٍءذ؛إ
            public uint dwSoftwareVersion;			//بي¼‏°و±¾؛إ,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public uint dwSoftwareBuildDate;			//بي¼‏ةْ³ةبصئع,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;		    //DSPبي¼‏°و±¾,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public uint dwDSPSoftwareBuildDate;		// DSPبي¼‏ةْ³ةبصئع,0xYYYYMMDD
            public uint dwPanelVersion;				// ا°أو°ه°و±¾,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public uint dwHardwareVersion;	// س²¼‏°و±¾,¸ك16خ»تاض÷°و±¾,µح16خ»تا´خ°و±¾
            public byte byAlarmInPortNum;		//DVR±¨¾¯تنبë¸ِت‎
            public byte byAlarmOutPortNum;		//DVR±¨¾¯تن³ِ¸ِت‎
            public byte byRS232Num;			//DVR 232´®؟ع¸ِت‎
            public byte byRS485Num;			//DVR 485´®؟ع¸ِت‎ 
            public byte byNetworkPortNum;		//حّآç؟ع¸ِت‎
            public byte byDiskCtrlNum;			//DVR س²إج؟طضئئ÷¸ِت‎
            public byte byDiskNum;				//DVR س²إج¸ِت‎
            public byte byDVRType;				//DVRہàذح, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				//DVR ح¨µہ¸ِت‎
            public byte byStartChan;			//ئًت¼ح¨µہ؛إ,ہ‎بçDVS-1,DVR - 1
            public byte byDecordChans;			//DVR ½âآëآ·ت‎
            public byte byVGANum;				//VGA؟عµؤ¸ِت‎ 
            public byte byUSBNum;				//USB؟عµؤ¸ِت‎
            public byte byAuxoutNum;			//¸¨؟عµؤ¸ِت‎
            public byte byAudioNum;			//سïزô؟عµؤ¸ِت‎
            public byte byIPChanNum;			//×î´َت‎×ضح¨µہت‎ µح8خ»£¬¸ك8خ»¼ûbyHighIPChanNum 
            public byte byZeroChanNum;			//ءمح¨µہ±àآë¸ِت‎
            public byte bySupport;        //ؤـء¦£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض£¬
                                          //bySupport & 0x1, ±يت¾تا·ٌض§³ضضاؤـثرث÷
                                          //bySupport & 0x2, ±يت¾تا·ٌض§³ض±¸·ف
                                          //bySupport & 0x4, ±يت¾تا·ٌض§³ضر¹ثُ²خت‎ؤـء¦»ٌب،
                                          //bySupport & 0x8, ±يت¾تا·ٌض§³ض¶àحّ؟¨
                                          //bySupport & 0x10, ±يت¾ض§³ضش¶³جSADP
                                          //bySupport & 0x20, ±يت¾ض§³ضRaid؟¨¹¦ؤـ
                                          //bySupport & 0x40, ±يت¾ض§³ضIPSANثرث÷
                                          //bySupport & 0x80, ±يت¾ض§³ضrtp over rtsp
            public byte byEsataUseage;		//Esataµؤؤ¬بدسأح¾£¬0-ؤ¬بد±¸·ف£¬1-ؤ¬بدآ¼دٌ
            public byte byIPCPlug;			//0-¹ط±ص¼´²ه¼´سأ£¬1-´ٍ؟ھ¼´²ه¼´سأ
            public byte byStorageMode;		//0-إج×éؤ£ت½,1-´إإجإن¶î, 2³éض،ؤ£ت½
            public byte bySupport1;     //ؤـء¦£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض
                                        //bySupport1 & 0x1, ±يت¾تا·ٌض§³ضsnmp v30
                                        //bySupport1 & 0x2, ض§³ضاّ·ض»ط·إ؛حدآشط
                                        //bySupport1 & 0x4, تا·ٌض§³ض²¼·ہسإدب¼¶	
                                        //bySupport1 & 0x8, ضاؤـةè±¸تا·ٌض§³ض²¼·ہت±¼ن¶خہ©ص¹
                                        //bySupport1 & 0x10, ±يت¾تا·ٌض§³ض¶à´إإجت‎£¨³¬¹‎33¸ِ£©
                                        //bySupport1 & 0x20, ±يت¾تا·ٌض§³ضrtsp over http	
            public ushort wDevType;//ةè±¸ذح؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEV_TYPE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevTypeName;//ةè±¸ذح؛إأû³ئ 
            public byte bySupport2; //ؤـء¦¼¯ہ©ص¹£¬خ»سë½ل¹ûخھ0±يت¾²»ض§³ض£¬1±يت¾ض§³ض
                                    //bySupport2 & 0x1, ±يت¾تا·ٌض§³ضہ©ص¹µؤOSD×ض·ûµ‏¼س(ضص¶ث؛ح×¥إؤ»ْہ©ص¹اّ·ض)
            public byte byAnalogAlarmInPortNum; //ؤ£ؤâ±¨¾¯تنبë¸ِت‎
            public byte byStartAlarmInNo;    //ؤ£ؤâ±¨¾¯تنبëئًت¼؛إ
            public byte byStartAlarmOutNo;  //ؤ£ؤâ±¨¾¯تن³ِئًت¼؛إ
            public byte byStartIPAlarmInNo;  //IP±¨¾¯تنبëئًت¼؛إ  0-خقذ§
            public byte byStartIPAlarmOutNo; //IP±¨¾¯تن³ِئًت¼؛إ 0-خقذ§
            public byte byHighIPChanNum;     //ت‎×ضح¨µہ¸ِت‎£¬¸ك8خ» 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//±£ءô
        }

        public const int MAX_ZEROCHAN_NUM = 16;
        //ءمح¨µہر¹ثُإنضأ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZEROCHANCFG
        {
            public uint dwSize;			    //½ل¹¹³¤¶ب
            public byte byEnable;			//0-ح£ض¹ءمح¨µہ±àآë£¬1-±يت¾ئôسأءمح¨µہ±àآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//±£ءô
            public uint dwVideoBitrate; 	/*تسئµآëآت 0-±£ءô 1-16K(±£ءô) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
                                             * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
                                             * 23-2048K
                                             * ×î¸كخ»(31خ»)ضأ³ة1±يت¾تا×ش¶¨زهآëء÷, 0-30خ»±يت¾آëء÷ضµ(MIN-32K MAX-8192K) */
            public uint dwVideoFrameRate;   //ض،آت 0-ب«²؟; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
                                            //V2.0شِ¼س14-15, 15-18, 16-22;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;        //±£ءô
        }

        //ءمح¨µہثُ·إ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZERO_ZOOMCFG
        {
            public uint dwSize;			    //½ل¹¹³¤¶ب
            public NET_VCA_POINT struPoint;	//»­أوضذµؤ×ّ±êµم
            public byte byState;		 //دضشعµؤ×´ج¬£¬0-ثُذ،£¬1-·إ´َ  
            public byte byPreviewNumber;       //ش¤ہہت‎ؤ؟,0-1»­أو,1-4»­أو,2-9»­أو,3-16»­أو ¸أ²خت‎ض»¶ء
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPreviewSeq;//»­أوح¨µہذإد¢ ¸أ²خت‎ض»¶ء
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				//±£ءô 
        }

        public const int DESC_LEN_64 = 64;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG
        {
            public uint dwSize;			//½ل¹¹³¤¶ب
            public byte byEnable;			//0-½ûسأSNMP£¬1-±يت¾ئôسأSNMP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//±£ءô
            public ushort wVersion;		//snmp °و±¾  v1 = 1, v2 =2, v3 =3£¬ةè±¸ؤ؟ا°²»ض§³ض v3
            public ushort wServerPort; //snmpدûد¢½ستص¶ث؟ع£¬ؤ¬بد 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity; //¶ء¹²ح¬جه£¬×î¶à31,ؤ¬بد"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;//ذ´¹²ح¬جه,×î¶à31 ×ض½ع,ؤ¬بد "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;	//×شدفض÷»ْipµطض·أèتِ£¬ض§³ضIPV4 IPV6؛حسٍأûأèتِ    
            public ushort wTrapHostPort;   //trapض÷»ْ¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPv3_USER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;			// سأ»§أû				
            public byte bySecLevel;	//°²ب«¼¶±ً 1-خقذ£رé 2-خقتعب¨ذ£رé 3-تعب¨ذ£رé
            public byte byAuthtype;	//بدض¤ہàذح 0-MD5بدض¤ 1-SHAبدض¤ 2: none
            public byte byPrivtype;	//0: DES; 1: AES; 2: none;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuthpass;	//بدض¤أـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivpass;	//¼سأـأـآë
        }

        //snmpv30
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG_V30
        {
            public uint dwSize;			//½ل¹¹³¤¶ب
            public byte byEnableV1;		//0-½ûسأSNMP V1£¬1-±يت¾ئôسأSNMP V1
            public byte byEnableV2;		//0-½ûسأSNMP V2£¬1-±يت¾ئôسأSNMP V2
            public byte byEnableV3;		//0-½ûسأSNMP V3£¬1-±يت¾ئôسأSNMP V3
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wServerPort;					//snmpدûد¢½ستص¶ث؟ع£¬ؤ¬بد 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity;		//¶ء¹²ح¬جه£¬×î¶à31,ؤ¬بد"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;		//ذ´¹²ح¬جه,×î¶à31 ×ض½ع,ؤ¬بد "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;		//×شدفض÷»ْipµطض·أèتِ£¬ض§³ضIPV4 IPV6؛حسٍأûأèتِ    
            public ushort wTrapHostPort;					// trapض÷»ْ¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SNMPv3_USER struRWUser;    // ¶ءذ´سأ»§
            public NET_DVR_SNMPv3_USER struROUser;    // ض»¶ءسأ»§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
        }

        public const int PROCESSING = 0;    //ص‎شع´¦ہي
        public const int PROCESS_SUCCESS = 100;   //¹‎³جحê³ة
        public const int PROCESS_EXCEPTION = 400;   //¹‎³جزى³£
        public const int PROCESS_FAILED = 500;   //¹‎³جت§°ـ
        public const int PROCESS_QUICK_SETUP_PD_COUNT = 501; //ز»¼üإنضأضءةظ3؟éس²إج

        public const int SOFTWARE_VERSION_LEN = 48;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO
        {
            public NET_DVR_IPADDR struIP;     // ةè±¸IPµطض·
            public ushort wPort;      // ةè±¸¶ث؟ع؛إ
            public ushort wFactoryType;   // ةè±¸³§¼زہàذح
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = SOFTWARE_VERSION_LEN)]
            public string chSoftwareVersion;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string chSerialNo; // ذٍءذ؛إ
            public ushort wEncCnt;   // ±àآëح¨µہ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;		// MAC µطض·
            public NET_DVR_IPADDR struSubDVRIPMask;   // DVR IPµطض·رعآë
            public NET_DVR_IPADDR struGatewayIpAddr;  // حّ¹ط
            public NET_DVR_IPADDR struDnsServer1IpAddr;	/* سٍأû·‏خٌئ÷1µؤIPµطض· */
            public NET_DVR_IPADDR struDnsServer2IpAddr;	/* سٍأû·‏خٌئ÷2µؤIPµطض· */
            public byte byDns;
            public byte byDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ±£ءô×ض½ع
        }

        public const int MAX_SADP_NUM = 256;  //ثرث÷µ½ةè±¸×î´َت‎ؤ؟
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO_LIST
        {
            public uint dwSize;   //  ½ل¹¹´َذ،
            public ushort wSadpNum;   // ثرث÷µ½ةè±¸ت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SADP_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SADPINFO[] struSadpInfo; // ثرث÷
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADP_VERIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string chPassword;
            public NET_DVR_IPADDR struOldIP;
            public ushort wOldPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************** end *********************************************/

        /*******************************±¸·ف½ل¹¹ begin********************************/
        //»ٌب،±¸·فةè±¸ذإد¢½س؟ع¶¨زه
        public const int DESC_LEN_32 = 32;   //أèتِ×ض³¤¶ب
        public const int MAX_NODE_NUM = 256;  //½عµم¸ِت‎

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DESC_NODE
        {
            public int iValue;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; //أèتِ×ض¶خ 
            public uint dwFreeSpace; //»ٌب،´إإجءذ±ي×¨سأ,µ¥خ»خھM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			  //±£ءô  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKABILITY_LIST
        {
            public uint dwSize;            //½ل¹¹³¤¶ب
            public uint dwNodeNum;		 //ؤـء¦½لµم¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[] struDescNode;  //أèتِ²خت‎  
        }

        //±¸·ف½ّ¶بءذ±ي
        public const int BACKUP_SUCCESS            =    100;  //±¸·فحê³ة
        public const int BACKUP_CHANGE_DEVICE      =    101;  //±¸·فةè±¸زرآْ£¬¸ü»»ةè±¸¼جذّ±¸·ف

        public const int BACKUP_SEARCH_DEVICE      =    300;  //ص‎شعثرث÷±¸·فةè±¸
        public const int BACKUP_SEARCH_FILE        =    301;  //ص‎شعثرث÷آ¼دٌخؤ¼‏
        public const int BACKUP_SEARCH_LOG_FILE    =    302;  //ص‎شعثرث÷بصض¾خؤ¼‏

        public const int BACKUP_EXCEPTION          =    400;  //±¸·فزى³£
        public const int BACKUP_FAIL               =    500;  //±¸·فت§°ـ

        public const int BACKUP_TIME_SEG_NO_FILE   =    501;  //ت±¼ن¶خؤعخقآ¼دٌخؤ¼‏
        public const int BACKUP_NO_RESOURCE        =    502;  //ةêاë²»µ½×تش´
        public const int BACKUP_DEVICE_LOW_SPACE   =    503;  //±¸·فةè±¸بفء؟²»×م
        public const int BACKUP_DISK_FINALIZED     =    504;  //؟جآ¼¹âإج·âإج
        public const int BACKUP_DISK_EXCEPTION     =    505;  //؟جآ¼¹âإجزى³£
        public const int BACKUP_DEVICE_NOT_EXIST   =    506;  //±¸·فةè±¸²»´وشع
        public const int BACKUP_OTHER_BACKUP_WORK  =    507;  //سذئنثû±¸·ف²ظ×÷شع½ّذذ
        public const int BACKUP_USER_NO_RIGHT      =    508;  //سأ»§أ»سذ²ظ×÷ب¨دق
        public const int BACKUP_OPERATE_FAIL       =    509;  //²ظ×÷ت§°ـ
        public const int BACKUP_NO_LOG_FILE        =    510;  //س²إجضذخقبصض¾

        //±¸·ف¹‎³ج½س؟ع¶¨زه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_NAME_PARAM
        {
            public uint dwFileNum;   //خؤ¼‏¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_FILE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FINDDATA_V30[] struFileList; //خؤ¼‏ءذ±ي
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;   //±¸·ف´إإجأèتِ
            public byte byWithPlayer;      //تا·ٌ±¸·ف²¥·إئ÷
            public byte byContinue;    /*تا·ٌ¼جذّ±¸·ف 0²»¼جذّ 1¼جذّ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_TIME_PARAM
        {
            public int lChannel;        //°´ت±¼ن±¸·فµؤح¨µہ
            public NET_DVR_TIME struStartTime;   //±¸·فµؤئًت¼ت±¼ن
            public NET_DVR_TIME struStopTime;    //±¸·فµؤضصض¹ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;     //±¸·ف´إإجأèتِ
            public byte byWithPlayer;               //تا·ٌ±¸·ف²¥·إئ÷
            public byte byContinue;                 //تا·ٌ¼جذّ±¸·ف 0²»¼جذّ 1¼جذّ
            public byte byDrawFrame;			     //0 ²»³éض،  1 ³éض،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					 // ±£ءô×ض½ع 
        }
        /********************************* end *******************************************/
        public enum COMPRESSION_ABILITY_TYPE
        {
            COMPRESSION_STREAM_ABILITY = 0, //آëء÷ر¹ثُہàذح
            MAIN_RESOLUTION_ABILITY = 1,    //ض÷آëء÷ر¹ثُ·ض±وآت
            SUB_RESOLUTION_ABILITY = 2, //×سآëء÷ر¹ثُ·ض±وآت
            EVENT_RESOLUTION_ABILITY = 3,  //تآ¼‏ر¹ثُ²خت‎·ض±وآت
            FRAME_ABILITY = 4,              //ض،آتؤـء¦
            BITRATE_TYPE_ABILITY = 5,       //خ»آتہàذحؤـء¦
            BITRATE_ABILITY = 6,            //خ»آتةددق
            THIRD_RESOLUTION_ABILITY = 7,   //ب‎آëء÷ر¹ثُ·ض±وآت
            STREAM_TYPE_ABILITY = 8,        //آëء÷ہàذح
            PIC_QUALITY_ABILITY = 9,         //ح¼دٌضتء؟
            INTERVAL_BPFRAME_ABILITY = 10,  //BPض،¼ن¸ô
            VIDEO_ENC_ABILITY = 11,           //تسئµ±àآëؤـء¦
            AUDIO_ENC_ABILITY = 12,           //زôئµ±àآëؤـء¦
            VIDEO_ENC_COMPLEXITY_ABILITY = 13, //تسئµ±àآë¸´شس¶بؤـء¦
            FORMAT_ABILITY = 14, //·â×°¸ٌت½ؤـء¦
        }

        //ؤـء¦ءذ±ي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ABILITY_LIST
        {
            public uint dwAbilityType;	//ؤـء¦ہàذح COMPRESSION_ABILITY_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£ءô×ض½ع
            public uint dwNodeNum;		//ؤـء¦½لµم¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[]  struDescNode;  //أèتِ²خت‎  
        }

        public const int MAX_ABILITYTYPE_NUM = 12;   //×î´َؤـء¦دî

        // ر¹ثُ²خت‎ؤـء¦ءذ±ي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_ABILITY
        {
            public uint dwSize;            //½ل¹¹³¤¶ب
            public uint dwAbilityNum;		//ؤـء¦ہàذح¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ABILITYTYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ABILITY_LIST[] struAbilityNode; //أèتِ²خت‎  
        }

        //ؤ£ت½A 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEA
        {
            public byte byStartMonth;	// ؟ھت¼شآ ´س1؟ھت¼
            public byte byStartDay;		// ؟ھت¼بص ´س1؟ھت¼
            public byte byEndMonth;		// ½لتّشآ 
            public byte byEndDay;		// ½لتّبص
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEB
        {
            public byte byStartMonth;	// ´س1؟ھت¼
            public byte byStartWeekNum;	// µع¼¸¸ِذائع ´س1؟ھت¼ 
            public byte byStartWeekday;	// ذائع¼¸
            public byte byEndMonth;		// ´س1؟ھت¼
            public byte byEndWeekNum;	// µع¼¸¸ِذائع ´س1؟ھت¼ 
            public byte byEndWeekday;	// ذائع¼¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEC
        {
            public ushort wStartYear;		// ؤê
            public byte byStartMon;		// شآ
            public byte byStartDay;		// بص
            public ushort wEndYear;		// ؤê
            public byte byEndMon;		// شآ
            public byte byEndDay;		// بص
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_HOLIDATE_UNION
        {
            //ءھ؛دجه´َذ، 12×ض½ع
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwSize;
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEA   struModeA;	// ؤ£ت½A
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEB   struModeB;	// ؤ£ت½B
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEC   struModeC;	// ؤ£ت½C
        }

        public enum HOLI_DATE_MODE
        {
            HOLIDATE_MODEA = 0,
            HOLIDATE_MODEB,
            HOLIDATE_MODEC
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM
        {
            public byte byEnable;			// تا·ٌئôسأ
            public byte byDateMode;			// بصئعؤ£ت½ 0-ؤ£ت½A 1-ؤ£ت½B 2-ؤ£ت½C
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±£ءô×ض½ع
            public NET_DVR_HOLIDATE_UNION uHolidate;	// ¼ظبصبصئع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;	// ¼ظبصأû³ئ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±£ءô×ض½ع
        }

        public const int MAX_HOLIDAY_NUM = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM_CFG
        {
            public uint dwSize;			// ½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HOLIDAY_PARAM[] struHolidayParam;	// ¼ظبص²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô²خت‎
        }

        //¼ظبص±¨¾¯´¦ہي·½ت½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_HANDLE
        {
            public uint dwSize;				// ½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;	// ²¼·ہت±¼ن¶خ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_RECORD
        {
            public uint dwSize;
            public NET_DVR_RECORDDAY struRecDay;     // آ¼دٌ²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched; // آ¼دٌت±¼ن¶خ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //  ±£ءô×ض½ع
        }

        public const int MAX_LINK_V30 = 128;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LINK
        {
            public NET_DVR_IPADDR  struIP;     // ؟ح»§¶ثIP
            public int lChannel;   // ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINK_STATUS
        {
            public uint dwSize;      // ½ل¹¹جه´َذ،
            public ushort wLinkNum;    // ء¬½سµؤت‎ؤ؟
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LINK[] struOneLink;   // ء¬½سµؤ؟ح»§¶ثذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±£ءô×ض½ع
        }

        public const int MAX_BOND_NUM = 2;

        //µ¥BONDINGحّ؟¨إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ONE_BONDING
        {
            public byte byMode;
            public byte byUseDhcp;
            public byte byMasterCard;
            public byte byStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.I1)]
            public byte[] byBond;
            public NET_DVR_ETHERNET_V30 struEtherNet;
            public NET_DVR_IPADDR struGatewayIpAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //BONDINGحّ؟¨إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETWORK_BONDING
        {
            public uint dwSize;
            public byte byEnable;
            public byte byNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BOND_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_BONDING[] struOneBond;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }


        //´إإجإن¶î
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA
        {
            public byte byQuotaType;	 // ´إإجإن¶îہàذح,1 - °´بفء؟ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±£ءô×ض½ع
            public uint dwHCapacity;     // ·ضإنµؤ´إإجبفء؟¸ك32خ» µ¥خ»MB
            public uint dwLCapacity;     // ·ضإنµؤ´إإجبفء؟µح32خ» µ¥خ»MB
            public uint dwHUsedSpace;    // زرت¹سأµؤ´إإج´َذ،¸ك32خ» µ¥خ»MB
            public uint dwLUsedSpace;    // زرت¹سأµؤ´إإج´َذ،µح32خ» µ¥خ»MB
            public byte byQuotaRatio;    //	·ضإنµؤ´إإج±بہ‎,µ¥خ»:%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA_CFG
        {
            public uint dwSize;         // ½ل¹¹جه´َذ،
            public NET_DVR_DISK_QUOTA struPicQuota;    //  ح¼ئ¬إن¶î
            public NET_DVR_DISK_QUOTA struRecordQuota;    //  آ¼دٌإن¶î
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMING_CAPTURE
        {
            public NET_DVR_JPEGPARA struJpegPara;   // ¶¨ت±×¥ح¼ح¼ئ¬ضتء؟
            public uint dwPicInterval; //¶¨ت±×¥ح¼ت±¼ن¼ن¸ô,µ¥خ»s   1-1s 2-2s 3-3s 4-4s 5-5s 
                                       //6-10m 7-30m 8-1h 9-12h 10-24h
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;    // °´خ»±يت¾
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          // ±£ءô×ض½ع
        }

        public const int MAX_PIC_EVENT_NUM = 32;
        public const int MAX_ALARMIN_CAPTURE = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN_V40
        {
            public uint dwMaxRelCaptureChanNum;  //×î´َ؟ة´¥·¢µؤ¹طءھح¨µہت‎-ض»¶ءتôذش
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo; //´¥·¢µؤ¹طءھ×¥ح¼ح¨µہ؛إ£¬°´ضµ±يت¾£¬²ةسأ½ô´صذحإإءذ,0xffffffff±يت¾؛َذّخقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE_V40
        {
            public NET_DVR_JPEGPARA struJpegPara;   // تآ¼‏×¥ح¼ح¼ئ¬ضتء؟
            public uint dwPicInterval;   // تآ¼‏×¥ح¼ت±¼ن¼ن¸ô  µ¥خ»خھأë 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struRelCaptureChan;   // ت‎×éدآ±ê 0 زئ¶¯صى²â´¥·¢×¥ح¼ 1 تسئµصعµ²´¥·¢×¥ح¼ 2 تسئµ¶ھت§´¥·¢×¥ح¼,ت‎×é3±يت¾PIR±¨¾¯×¥ح¼£¬ت‎×é4±يت¾خقدك±¨¾¯×¥ح¼£¬ت‎×é5±يت¾؛ô¾ب±¨¾¯×¥ح¼,ت‎×é6±يت¾ضاؤـ×¥ح¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struAlarmInCapture;    // ±¨¾¯تنبë´¥·¢×¥ح¼£¬دآ±ê0 ´ْ±ي±¨¾¯تنبë1 زہ´خہàحئ
            public uint dwMaxGroupNum;  //ةè±¸ض§³ضµؤ×î´َ±¨¾¯تنبë×éت‎£¬أ؟×é16¸ِ±¨¾¯تنبë
            public byte byCapTimes; //×¥ح¼صإت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE
        {
            public NET_DVR_JPEGPARA  struJpegPara;   // تآ¼‏×¥ح¼ح¼ئ¬ضتء؟
            public uint dwPicInterval;  /*تآ¼‏×¥ح¼ت±¼ن¼ن¸ô  µ¥خ»خھأë  1-1s 2-2s 3-3s 4-4s 5-5s 
                                             * 6-10m 7-30m 8-1h 9-12h 10-24h*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struRelCaptureChan; /* ت‎×éدآ±ê 0 زئ¶¯صى²â´¥·¢×¥ح¼ 1 تسئµصعµ²´¥·¢×¥ح¼,
                                                                   * 2 تسئµ¶ھت§´¥·¢×¥ح¼,ت‎×é3±يت¾PIR±¨¾¯×¥ح¼£¬ت‎×é4±يت¾خقدك±¨¾¯×¥ح¼£¬
                                                                   * ت‎×é5±يت¾؛ô¾ب±¨¾¯×¥ح¼,ت‎×é6±يت¾ضاؤـ×¥ح¼£¬ ت‎×é7±يت¾بثء³صى²â*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struAlarmInCapture;  //±¨¾¯تنبë´¥·¢×¥ح¼£¬دآ±ê0 ´ْ±ي±¨¾¯تنبë1 زہ´خہàحئ
            public byte byCapTimes; //×¥ح¼صإت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG_V40
        {
            public uint dwSize;               //½ل¹¹جه³¤¶ب
            public NET_DVR_TIMING_CAPTURE struTimingCapture;
            public NET_DVR_EVENT_CAPTURE_V40 struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG
        {
            public uint dwSize;         // ½ل¹¹جه´َذ،
            public NET_DVR_TIMING_CAPTURE struTimingCapture;
            public NET_DVR_EVENT_CAPTURE struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_DAY
        {
            public byte byAllDayCapture;	// تا·ٌب«جى×¥ح¼
            public byte byCaptureType;		// ×¥ح¼ہàذح£؛0-¶¨ت±×¥ح¼£¬1-زئ¶¯صى²â×¥ح¼£¬2-±¨¾¯×¥ح¼£¬3-زئ¶¯صى²â»ٍ±¨¾¯×¥ح¼£¬4-زئ¶¯صى²â؛ح±¨¾¯×¥ح¼£¬6-ضاؤـ±¨¾¯×¥ح¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_SCHED
        {
            public NET_DVR_SCHEDTIME struCaptureTime;        // ×¥ح¼ت±¼ن¶خ
            public byte byCaptureType;       // ×¥ح¼ہàذح£؛0-¶¨ت±×¥ح¼£¬1-زئ¶¯صى²â×¥ح¼£¬2-±¨¾¯×¥ح¼£¬3-زئ¶¯صى²â»ٍ±¨¾¯×¥ح¼£¬4-زئ¶¯صى²â؛ح±¨¾¯×¥ح¼£¬6-ضاؤـ±¨¾¯×¥ح¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // ±£ءô×ض½ع
        }

        //ح¨µہ×¥ح¼¼ئ»®
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHED_CAPTURECFG
        {
            public uint dwSize;     //½ل¹¹جه
            public byte byEnable;	//تا·ٌ×¥ح¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_DAY[] struCaptureDay;//ب«جى×¥ح¼¼ئ»®
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struCaptureSched;//ت±¼ن¶خ×¥ح¼²¼·ہ¼ئ»®
            public NET_DVR_CAPTURE_DAY  struCaptureHoliday;	//¼ظبص×¥ح¼¼ئ»®
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struHolidaySched;	//ت±¼ن¶خ¼ظبص×¥ح¼²¼·ہ¼ئ»®
            public uint dwRecorderDuration;	//×¥ح¼±£´و×î³¤ت±¼ن 0xffffffff±يت¾¸أضµخقذ§ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			//±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_TEST_PARAM
        {
            public uint dwSize;              //½ل¹¹´َذ،
            public int lCardIndex;         //حّ؟¨ث÷ز‎
            public uint dwInterval;         //ةè±¸ةد´«ء÷ء؟ت±¼ن¼ن¸ô, µ¥خ»:100ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_INFO
        {
            public uint dwSize;             //½ل¹¹´َذ،
            public uint dwSendFlowSize;     //·¢ثحء÷ء؟´َذ،,µ¥خ»kbps
            public uint dwRecvFlowSize;     //½ستصء÷ء؟´َذ،,µ¥خ»kbps
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±£ءô 
        }

        //آ¼دٌ±êا©
        public const int LABEL_NAME_LEN = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_LABEL
        {
            public uint dwSize;					// ½ل¹¹جه´َذ،
            public NET_DVR_TIME struTimeLabel;			// ±êا©µؤت±¼ن 
            public byte byQuickAdd;				// تا·ٌ؟ىثظجي¼س ؟ىثظجي¼ست±±êا©أû³ئخقذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				// ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ±êا©µؤأû³ئ ³¤¶بخھ40×ض½ع  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// ±£ءô×ض½ع
        }

        public const int LABEL_IDENTIFY_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LABEL_IDENTIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_IDENTIFY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelIdentify;    // 64×ض½ع±êت¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;               // ±£ءô×ض½ع
        }

        public const int MAX_DEL_LABEL_IDENTIFY = 20;// ة¾³‎µؤ×î´َ±êا©±êت¶¸ِت‎

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEL_LABEL_PARAM
        {
            public uint dwSize;       // ½ل¹¹جه´َذ،
            public byte byMode;   // °´خ»±يت¾,0x01±يت¾°´±êت¶ة¾³‎
            public byte byRes1;
            public ushort wLabelNum;      // ±êا©ت‎ؤ؟   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DEL_LABEL_IDENTIFY, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LABEL_IDENTIFY[] struIndentify; // ±êا©±êت¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±£ءô×ض½ع    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOD_LABEL_PARAM
        {
            public NET_DVR_LABEL_IDENTIFY struIndentify; //زھذق¸ؤµؤ±êا©±êت¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//ذق¸ؤ؛َµؤ±êا©أû³ئ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //±êا©ثرث÷½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_LABEL
        {
            public uint dwSize;          // ½ل¹¹جه´َذ،
            public int lChannel;		// ²éصزµؤح¨µہ
            public NET_DVR_TIME struStartTime;	// ؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;	// ½لتّت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//  آ¼دٌ±êا©أû³ئ بç¹û±êا©أû³ئخھ؟ص£¬شٍثرث÷ئًض¹ت±¼نثùسذ±êا©
            public byte byDrawFrame;		//0:²»³éض،£¬1£؛³éض،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
        }

        //±êا©ذإد¢½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINDLABEL_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ±êا©أû³ئ
            public NET_DVR_TIME struTimeLabel;		// ±êا©ت±¼ن
            public NET_DVR_LABEL_IDENTIFY struLabelIdentify; // ±êا©±êت¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±£ءô×ض½ع
        }

        public const int CARDNUM_LEN_V30 = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE_PARAM
        {
            public uint dwSize;        //½ل¹¹جه´َذ، 
            public int lChannel;       //ح¨µہ؛إ
            public byte byFileType;   /* ²éصزµؤح¼ئ¬ہàذح:0¶¨ت±×¥ح¼1 زئ¶¯صى²â×¥ح¼ 2 ±¨¾¯×¥ح¼3  ±¨¾¯ | زئ¶¯صى²â×¥ح¼ 4 ±¨¾¯ & زئ¶¯صى²â×¥ح¼
                                       * 6 تض¶¯×¥ح¼ ,9-ضاؤـح¼ئ¬,10- PIR±¨¾¯£¬11- خقدك±¨¾¯£¬12- ؛ô¾ب±¨¾¯,0xa ش¤ہہت±½طح¼£¬0xd بثء³صى²â, 
                                       * 0xe ش½½çصى²â£¬0xf بëاضاّسٍصى²â£¬0x10 ³،¾°±ن¸üصى²â, 0x11-ةè±¸±¾µط»ط·إت±½طح¼, 0x12-ضاؤـصى²â£¬
                                       * 0xff- ب«²؟ہàذح 2013-07-16*/
            public byte byNeedCard;     //تا·ٌذèزھ؟¨؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // ±£ءô×ض½ع
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNum;     // ؟¨؛إ
            public NET_DVR_TIME  struStartTime;//²éصزح¼ئ¬µؤ؟ھت¼ت±¼ن
            public NET_DVR_TIME  struStopTime;// ²éصزح¼ئ¬µؤ½لتّت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     // ±£ءô×ض½ع
        }

        public const int PICTURE_NAME_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PICTURE_NAME_LEN)]
            public string sFileName;//ح¼ئ¬أû
            public NET_DVR_TIME struTime;//ح¼ئ¬µؤت±¼ن
            public uint dwFileSize;//ح¼ئ¬µؤ´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = CARDNUM_LEN_V30)]
            public string sCardNum;	//؟¨؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		//  ±£ءô×ض½ع
        }

        public const int MAX_RECORD_PICTURE_NUM = 50;   //×î´َ±¸·فح¼ئ¬صإت‎  

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_PICTURE_PARAM
        {
            public uint dwSize;         // ½ل¹¹جه´َذ،   
            public uint dwPicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FIND_PICTURE[] struPicture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;
            public byte byWithPlayer;
            public byte byContinue;    /*تا·ٌ¼جذّ±¸·ف 0²»¼جذّ 1¼جذّ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_LIMIT
        {
            public uint dwSize;           //½ل¹¹جه´َذ،
            public uint dwChannel;        //ح¨µہ؛إ
            public byte byCompressType;   //´‎»ٌب،µؤر¹ثُ²خت‎ہàذح1,ض÷آëء÷2,×سآëء÷3,تآ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£ءô
            public NET_DVR_COMPRESSIONCFG_V30  struCurrentCfg; //µ±ا°ر¹ثُ²خت‎إنضأ
        }

        public const int STEP_READY      = 0;    //×¼±¸ة‎¼¶
        public const int STEP_RECV_DATA  = 1;    //½ستصة‎¼¶°üت‎¾ف
        public const int STEP_UPGRADE    = 2;    //ة‎¼¶دµح³
        public const int STEP_BACKUP     = 3;    //±¸·فدµح³
        public const int STEP_SEARCH     = 255;  //ثرث÷ة‎¼¶خؤ¼‏

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_EFFECT
        {
            public uint dwBrightValue;      //ءء¶ب[0,255]
            public uint dwContrastValue;    //¶ش±ب¶ب[0,255]
            public uint dwSaturationValue;  //±¥؛ح¶ب[0,255]
            public uint dwHueValue;         //ة«µ÷[0,255]
            public uint dwSharpness;		  //بٌ¶ب[0,255]
            public uint dwDenoising;		  //ب¥شë[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_INPUT_EFFECT
        {
            public uint dwSize;				//½ل¹¹جه´َذ،
            public ushort wEffectMode;        //ؤ£ت½ 0-±ê×¼ 1-تزؤع 2-بُ¹â 3-تزحâ  255-×ش¶¨زه
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //±£ءô
            public NET_DVR_VIDEO_EFFECT struVideoEffect;	//تسئµذ§¹û²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPARA_V40
        {
            public uint dwChannel;			// ح¨µہ؛إ
            public uint dwVideoParamType;  	// تسئµ²خت‎ہàذح 0-ءء¶ب 1-¶ش±ب¶ب 2-±¥؛ح¶ب 3-ة«¶ب 4-بٌ¶ب 5-ب¥شë
            public uint dwVideoParamValue;  //¶شس¦µؤتسئµ²خت‎ضµ£¬·¶خ§زہ¾فؤـء¦¼¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFAULT_VIDEO_COND
        {
            public uint dwSize;			// ½ل¹¹جه´َذ،
            public uint dwChannel;		// ح¨µہ؛إ
            public uint dwVideoMode;	// ؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ENCODE_JOINT_PARAM
        {
            public uint dwSize;			// ½ل¹¹جه´َذ،
            public byte byJointed;		//  0 أ»سذ¹طءھ 1 زر¾­¹طءھ
            public byte byDevType;		// ±»¹طءھµؤةè±¸ہàذح  1 ´ْ±يضاؤـةè±¸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		// ±£ءô×ض½ع
            public NET_DVR_IPADDR   struIP;			// ¹طءھµؤ±»ب،ء÷ةè±¸IPµطض·
            public ushort wPort;			// ¹طءھµؤ±»ب،ء÷ةè±¸¶ث؟ع؛إ
            public ushort wChannel;		// ¹طءھµؤ±»ب،ء÷ةè±¸ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CHAN_WORKSTATUS
        {
            public byte byJointed;				// 0-أ»سذ¹طءھ  1-زر¾­¹طءھ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR   struIP;					// ¹طءھµؤب،ء÷ةè±¸IPµطض·
            public ushort wPort;					// ¹طءھµؤب،ء÷ةè±¸¶ث؟ع؛إ
            public ushort wChannel;				// ¹طءھµؤب،ء÷ةè±¸ح¨µہ؛إ
            public byte byVcaChanStatus;		// 0 - خ´ئôسأ 1 - ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_DEV_WORKSTATUS
        {
            public uint dwSize;			// ½ل¹¹جه´َذ،
            public byte byDeviceStatus;	// ةè±¸µؤ×´ج¬0 - ص‎³£¹¤×÷ 1- ²»ص‎³£¹¤×÷
            public byte byCpuLoad;		// CPUت¹سأآت0-100 ·ض±ً´ْ±يت¹سأ°ظ·ضآت
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VCA_CHAN_WORKSTATUS[] struVcaChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM_V40
        {
            /*¸÷¸ِ×س´°؟ع¶شس¦½âآëح¨µہثù¶شس¦µؤ½âآë×سدµح³µؤ²غخ»؛إ(¶شسعتسئµ×غ؛دئ½ج¨ضذ½âآë×سدµح³سذذ§)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            //دشت¾´°؟عثù½âتسئµ·ض±وآت£¬1-D1,2-720P,3-1080P£¬ةè±¸¶ثذèزھ¸ù¾ف´ث//·ض±وآت½ّذذ½âآëح¨µہµؤ·ضإن£¬بç1·ضئءإنضأ³ة1080P£¬شٍةè±¸»ل°ر4¸ِ½âآëح¨
            //µہ¶¼·ضإن¸ّ´ث½âآëح¨µہ
            public byte byDecResolution;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 143, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG_V40
        {
            public uint dwSize;
            public byte byAudio;			/*زôئµتا·ٌ؟ھئô*/
            public byte byAudioWindowIdx;      /*زôئµ؟ھئô×س´°؟ع*/
            public byte byVgaResolution;      /*·ض±وآت£¬´سؤـء¦¼¯»ٌب،*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL£¬0-NULL*/
            public uint dwWindowMode;       /*»­أوؤ£ت½£¬ؤـء¦¼¯»ٌب،*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ِ×س´°؟ع¹طءھµؤ½âآëح¨µہ*/
            public byte byEnlargeStatus;          /*تا·ٌ´¦سع·إ´َ×´ج¬£¬0£؛²»·إ´َ£¬1£؛·إ´َ*/
            public byte byEnlargeSubWindowIndex;//·إ´َµؤ×س´°؟ع؛إ
            public byte byScale; /*دشت¾ؤ£ت½£¬0---صوتµدشت¾£¬1---ثُ·إدشت¾( صë¶شBNC )*/
                                 /*اّ·ض¹²سأجه£¬0-تسئµ×غ؛دئ½ج¨ؤع²؟½âآëئ÷دشت¾ح¨µہإنضأ£¬1-ئنثû½âآëئ÷دشت¾ح¨µہإنضأ*/
            public byte byUnionType;

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                [FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM_V40 struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM_V40 struNotVideoPlatform;
            }
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_V6SUBSYSTEMPARAM
        {
            public byte bySerialTrans;//تا·ٌح¸´«£¬0-·ٌ£¬1-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_V6PSUBSYSTEMARAM_GET = 1501;//»ٌب،V6×سدµح³إنضأ
        public const int NET_DVR_V6PSUBSYSTEMARAM_SET = 1502;//ةèضأV6×سدµح³إنضأ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRECT_DEADPIXEL_PARAM
        {
            public uint dwSize;
            public uint dwCommand; //أüءî£؛0-½ّبë»µµمؤ£ت½£¬1-جي¼س»µµم£¬2-±£´و»µµم£¬3-حث³ِ»µµم
            public uint dwDeadPixelX; //»µµمX×ّ±ê
            public uint dwDeadPixelY; //»µµمY×ّ±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        public const int MAX_REDAREA_NUM = 6;   //×î´َ؛ىآجµئاّسٍ¸ِت‎

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REDAREACFG
        {
            public uint dwSize;
            public uint dwCorrectEnable; //تا·ٌ؟ھئôذ£ص‎¹¦ؤـ£¬0-¹ط±ص£¬1-؟ھئô
            public uint dwCorrectLevel; //ذ£ص‎¼¶±ً£¬1(ذ£ص‎¶ب×îµح)-10(ذ£ص‎¶ب×î¸ك),ؤ¬بدخھ5
            public uint dwAreaNum; //ذ£ص‎اّسٍ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REDAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect; //ذ£ص‎اّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HISTORICDATACFG
        {
            public uint dwSize;
            public uint dwTotalNum;  //ہْت·ت‎¾ف¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int INQUEST_MESSAGE_LEN  = 44;    //ةَر¶ضطµم±ê¼اذإد¢³¤¶ب
        public const int INQUEST_MAX_ROOM_NUM = 2;    //×î´َةَر¶تز¸ِت‎
        public const int MAX_RESUME_SEGMENT   = 2;     //ض§³ضح¬ت±»ض¸´µؤئ¬¶خت‎ؤ؟

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM
        {
            public byte byRoomIndex;     //ةَر¶تز±à؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_MESSAGE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = INQUEST_MESSAGE_LEN)]
            public string sMessage; //ضطµم±ê¼اذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                     //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_DEVICE
        {
            public ushort wDeviceType;	//ت‎¾ف²ة¼¯ةè±¸ذح؛إ:0-خق 1-أ×ہض 2-ہط²ت 3-سإء¦ 4-¼رأث 5-سہ؟ط،¢6-غâةد،¢7-خ¬ؤةث¹´ï
            public ushort wDeviceAddr;	//ت‎¾ف²ة¼¯ةè±¸µطض·	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	    //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_SENSOR_DEVICE[] struSensorDevice;
            public uint  dwSupportPro;      //ض§³ضذ­زéہàذح,°´خ»±يت¾, ذآ°و±¾×كؤـء¦¼¯£¬²»شظہ©ص¹´ث×ض¶خ
                                            //0x1:أ×ہض 0x2:ہط²ت 0x4:سإء¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string szCDName;	//¹âإجأû³ئ£¬µ¥تزث«؟ج¹âإجأû³ئتاز»رùµؤ
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uCalcMode
            {
                [FieldOffsetAttribute(0)]
                public byte byBitRate;  // byCalcTypeخھ0ت±سذذ§£¬(0-32،¢1-48،¢2-64،¢3-80،¢4-96،¢5-128،¢
                                        //6-160،¢7-192،¢8-224،¢9-256،¢10-320،¢11-384،¢12-448،¢
                                        //13-512،¢14-640،¢15-768،¢16-896ا°16¸ِضµ±£ءô)17-1024،¢18-1280،¢19-1536،¢
                                        //20-1792،¢21-2048،¢22-3072،¢23-4096،¢24-8192
                [FieldOffsetAttribute(0)]
                public byte byInquestTime;  // byCalcTypeخھ1ت±سذذ§£¬0-1ذ،ت±, 1-2ذ،ت±,2-3ذ،ت±,3-4ذ،ت±, 4-6ذ،ت±,5-8ذ،ت±
                                            //8-16ذ،ت±, 9-20ذ،ت±,10-22ذ،ت±,11-24ذ،ت±
            }
            public byte byCalcType;			//؟جآ¼¼ئثمہàذح0-°´آëآت 1-°´ت±¼ن
            public byte byAutoDelRecord;	// تا·ٌ×ش¶¯ة¾³‎آ¼دٌ£¬0-²»ة¾³‎£¬¼´½لتّت±±£´وآ¼دٌ 1-ة¾³‎
            public byte byAlarmThreshold;		// ةùزô±¨¾¯·§ضµ
            public byte byInquestChannelResolution;     //ةَر¶ح¨µہ·ض±وآت£¬0:720P  1:1080P
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SYSTEM_INFO
        {
            public uint dwRecordMode;         //؟جآ¼ؤ£ت½:1 µ¥تزث«؟جؤ£ت½ 2 µ¥تزآض؟جؤ£ت½ 3 ث«تزث«؟جؤ£ت½£¨ذق¸ؤذèزھضطئôةè±¸£©
            public uint  dwWorkMode;           //¹¤×÷ؤ£ت½:0 ±ê×¼ؤ£ت½ 1 ح¨سأؤ£ت½(±£ءô£¬ؤ؟ا°ض»سذ±ê×¼ؤ£ت½)
            public uint dwResolutionMode;     //ةè±¸·ض±وآت£¬0:±êاه 1:D1 2:720P 3:1080P£¨¸كاهةَر¶»ْ²»سأ´ث×ض¶خ£©
            public NET_DVR_INQUEST_SENSOR_INFO struSensorInfo;  //خآتھ¶ب´«¸ذئ÷إنضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_ROOM_INFO[] struInquestRoomInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_SEGMENT
        {
            public NET_DVR_TIME  struStartTime; //تآ¼‏ئًت¼ت±¼ن
            public NET_DVR_TIME  struStopTime;  //تآ¼‏ضصض¹ت±¼ن
            public byte byRoomIndex;         //ةَر¶تز±à؛إ,´س1؟ھت¼
            public byte byDriveIndex;        //؟جآ¼»ْ±à؛إ,´س1؟ھت¼
            public ushort wSegmetSize;         //±¾ئ¬¶دµؤ´َذ،, µ¥خ»M 
            public uint dwSegmentNo;         //±¾ئ¬¶دشع±¾´خةَر¶ضذµؤذٍ؛إ,´س1؟ھت¼ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_EVENT
        {
            public uint  dwResumeNum;       //ذè»ض¸´µؤتآ¼‏¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESUME_SEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_RESUME_SEGMENT[] struResumeSegment;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_DEVICE_VERSION
        {
            public byte byMainVersion;         /*»ùدكض÷°و±¾.
								   0 : خ´ضھ
								   1 : 8000ةَر¶DVR
								       ´خ°و±¾: 1 : 8000HD-S
								   2 : 8100ةَر¶DVR 
									   ´خ°و±¾: 1 : ةَر¶81SNL
											   2 : ةَر¶81SH
											   3 : ةَر¶81SFH
								   3 : 8608¸كاهةَر¶»ْNVR 
									   ´خ°و±¾: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
            public byte bySubVersion;          //»ùدك´خ°و±¾
            public byte byUpgradeVersion;      //ة‎¼¶°و±¾,خ´ة‎¼¶خھ0
            public byte byCustomizeVersion;     //¶¨ضئ°و±¾,·ا¶¨ضئخھ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;             //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_RAID_INFO
        {
            public uint dwSize;   //½ل¹¹جه´َذ،
            public byte byEnable;  //´إإجRaidتا·ٌ½ûسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYNCHRONOUS_IPC
        {
            public uint dwSize;    //½ل¹¹جه´َذ،
            public byte byEnable;  //تا·ٌئôسأ£؛خھا°¶ثIPCح¬²½ةè±¸²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PASSWD
        {
            public uint dwSize;    //½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sOldPasswd;  //IPCµؤ¾ةأـآë£¬´«¸ّDVRبأDVRرéض¤
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sNewPasswd;  //IPCµؤذآأـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ح¨¹‎»ٌب،DVRµؤحّآç×´ج¬£؛µ¥خ»bps
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DEVICE_NET_USING_INFO
        {
            public uint dwSize;    //½ل¹¹جه´َذ،
            public uint dwPreview;   //ش¤ہہ
            public uint dwPlayback;  //»ط·إ
            public uint dwIPCModule; //IPC½سبë
            public uint dwNetDiskRW; //حّإج¶ءذ´
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //ح¨¹‎DVRةèضأا°¶ثIPCµؤIPµطض·
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_NETCFG
        {
            public uint dwSize;      //½ل¹¹جه´َذ،
            public NET_DVR_IPADDR struIP;       //IPCµؤIPµطض·
            public ushort wPort;       //IPCµؤ¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 126)]
            public string res;
        }

        //°´ت±¼نثّ¶¨
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_LOCK
        {
            public uint dwSize;      //½ل¹¹جه´َذ،
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            public uint dwChannel;        //ح¨µہ؛إ, 0xff±يت¾ثùسذح¨µہ
            public uint dwRecordType;     //آ¼دٌہàذح:  0xffffffff£­ب«²؟£¬0£­¶¨ت±آ¼دٌ£¬1-زئ¶¯صى²â£¬2£­±¨¾¯´¥·¢£¬3-±¨¾¯´¥·¢»ٍزئ¶¯صى²â£¬4-±¨¾¯´¥·¢؛حزئ¶¯صى²â£¬5-أüءî´¥·¢£¬6-تض¶¯آ¼دٌ£¬7-ضاؤـآ¼دٌ(ح¬خؤ¼‏²éصز)
            public uint dwLockDuration;   //ثّ¶¨³ضذّت±¼ن,µ¥خ»أë,0xffffffff±يت¾سہ¾أثّ¶¨
            public NET_DVR_TIME_EX strUnlockTimePoint;	//¼سثّت±سذذ§£¬µ±dwLockDuration²»خھسہ¾أثّ¶¨ت±£¬ثّ¶¨³ضذّµؤت±¼نµ½´ثت±¼نµم¾ح×ش¶¯½âثّ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCK_RETURN
        {
            public uint dwSize;      //½ل¹¹جه´َذ،
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //67DVS
        //ض¤تéدآشطہàذح
        public enum NET_SDK_UPLOAD_TYPE
        {
            UPGRADE_CERT_FILE = 0,
            UPLOAD_CERT_FILE = 1,
            TRIAL_CERT_FILE = 2,
            CONFIGURATION_FILE = 3
        }

        public enum NET_SDK_DOWNLOAD_TYPE
        {
            NET_SDK_DOWNLOAD_CERT = 0,      //دآشطض¤تé
            NET_SDK_DOWNLOAD_IPC_CFG_FILE = 1,//دآشطIPCإنضأخؤ¼‏
            NET_SDK_DOWNLOAD_BASELINE_SCENE_PIC = 2, //دآشط»ù×¼³،¾°ح¼ئ¬
            NET_SDK_DOWNLOAD_VQD_ALARM_PIC = 3,       //دآشطVQD±¨¾¯ح¼ئ¬
            NET_SDK_DOWNLOAD_CONFIGURATION_FILE = 4   //دآشطإنضأخؤ¼‏
        }

        //دآشط×´ج¬
        public enum NET_SDK_DOWNLOAD_STATUS
        {
            NET_SDK_DOWNLOAD_STATUS_SUCCESS = 1,    //دآشط³ة¹¦
            NET_SDK_DOWNLOAD_STATUS_PROCESSING,     //ص‎شعدآشط
            NET_SDK_DOWNLOAD_STATUS_FAILED,         //دآشطت§°ـ
            NET_SDK_DOWNLOAD_STATUS_UNKOWN_ERROR    //خ´ضھ´يخَ 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BONJOUR_CFG
        {
            public uint dwSize;				// ½ل¹¹جه´َذ،
            public byte byEnableBonjour;		// Bonjourت¹ؤـ 0 £؛؟ھئô 1£؛¹ط±ص
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendlyName; 	// ·‏خٌأû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SOCKS_CFG
        {
            public uint dwSize;				// ½ل¹¹جه´َذ،
            public byte byEnableSocks;  		// ت¹ؤـ 0£؛¹ط±ص 1£؛؟ھئô
            public byte byVersion;  			// SOCKS°و±¾ 4£؛SOCKS4   5£؛SOCKS5
            public ushort wProxyPort;				// ´ْہي¶ث؟ع£¬ؤ¬بد1080
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byProxyaddr;  	// ´ْہيIPµطض·£¬؟ةزشتاسٍأû
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; 	// سأ»§أû SOCKS²إسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;			// أـآëSOCKS5²إسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LOCAL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalAddr;  //²»ت¹سأsocks´ْہيµؤحّ¶خ£¬¸ٌت½خھ"ip/netmask;ip/netmask;،­"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_QOS_CFG
        {
            public uint dwSize;
            public byte byManageDscp;   // ¹ـہيت‎¾فµؤDSCPضµ [0-63]
            public byte byAlarmDscp;    // ±¨¾¯ت‎¾فµؤDSCPضµ [0-63]
            public byte byVideoDscp;    // تسئµت‎¾فµؤDSCPضµ [0-63]£¬byFlagخھ0ت±£¬±يت¾زôتسئµ
            public byte byAudioDscp;    // زôئµت‎¾فµؤDSCPضµ [0-63]£¬byFlagخھ1ت±سذذ§
            public byte byFlag;			// 0£؛زôتسئµ؛دز»£¬1£؛زôتسئµ·ض؟ھ
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HTTPS_CFG
        {
            public uint dwSize;
            public ushort wHttpsPort;		// HTTPS¶ث؟ع
            public byte byEnable;		// ت¹ؤـ 0£؛¹ط±ص 1£؛؟ھئô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ض¤تéدà¹ط
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_COUNTRY_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCountry;  			//¹ْ¼ز´ْ؛إ CNµب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byState;				//ضق»ٍت،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocality;			//µطاّ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byOrganization;		//×éض¯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnit;				//µ¥خ»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byCommonName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmail;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_PARAM
        {
            public uint dwSize;
            public ushort wCertFunc; //ض¤تéضضہà£¬0-802.1x,1-HTTPS
            public ushort wCertType; //ض¤تéہàذح£¬0-CA£¬1-Certificate,2-ث½ش؟خؤ¼‏
            public byte byFileType; //ض¤تéخؤ¼‏ہàذح£¬0-PEM,1-PFX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int UPLOAD_CERTIFICATE = 1; //ةد´«ض¤تé

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_INFO
        {
            public uint dwSize;
            public NET_DVR_CERT_PARAM struCertParam;	//ض¤تé²خت‎
            public uint dwValidDays;   //سذذ§جىت‎£¬ہàذحخھ×شا©أûت±سذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPasswd;   //ث½ش؟أـآë
            public NET_DVR_CERT_NAME struCertName;    // ض¤تéأû³ئ
            public NET_DVR_CERT_NAME struIssuerName;    // ض¤تé·¢ذذصكأû³ئ£¨×شا©أûض¤تéذإد¢»ٌب،ت±سذذ§£©
            public NET_DVR_TIME_EX struBeginTime;   //ض¤تé´´½¨ت±¼ن£¨×شا©أûض¤تéذإد¢»ٌب،ت±سذذ§£©
            public NET_DVR_TIME_EX struEndTime;   //ض¤تé½طض¹ت±¼ن£¨×شا©أûض¤تéذإد¢»ٌب،ت±سذذ§£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] serialNumber;   //ض¤تé±êت¶آë£¨×شا©أûض¤تéذإد¢»ٌب،ت±سذذ§£©
            public byte byVersion;
            public byte byKeyAlgorithm;			//¼سأـہàذح 0-RSA  1-DSA
            public byte byKeyLen;				//¼سأـ³¤¶ب 0-512  1-1024،¢ 2-2048
            public byte bySignatureAlgorithm; //ا©أûثم·¨ہàذح£¨×شا©أûض¤تéذإد¢»ٌب،ت±سذذ§£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //channel record status
        //***ح¨µہآ¼دٌ×´ج¬*****//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANS_RECORD_STATUS
        {
            public byte byValid;       //تا·ٌسذذ§
            public byte byRecord;      /*(ض»¶ء)آ¼دٌہàذح, °´خ»±يت¾:0: ²»شعآ¼دٌ£»1£؛شعآ¼دٌ 2-؟صدذ 
						3-خقء¬½س 4-خقتنبëتسئµ 5-خ´¼سشط 6-´وµµضذ
							7-»ط´«ضذ 8-سأ»§أû»ٍأـآë´ي 9-خ´رéض¤
							10-´وµµضذ؛حآ¼دٌضذ 11-آ¼دٌ»ط´«ضذ؛حآ¼دٌضذ*/
            public ushort wChannelNO;   //ح¨µہ؛إ
            public uint dwRelatedHD;  //¹طءھ´إإج
            public byte byOffLineRecord;  //¶دحّآ¼دٌ¹¦ؤـ 0-¹ط±ص 1-؟ھئô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IP_ALARM_GROUP_NUM
        {
            public uint dwSize;
            public uint dwIPAlarmInGroup;      //IPح¨µہ±¨¾¯تنبë×éت‎
            public uint dwIPAlarmInNum;       //IPح¨µہ±¨¾¯تنبë¸ِت‎
            public uint dwIPAlarmOutGroup;     //IPح¨µہ±¨¾¯تن³ِ×éت‎
            public uint dwIPAlarmOutNum;      //IPح¨µہ±¨¾¯تن³ِ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //****NVR end***//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHAN_GROUP_RECORD_STATUS
        {
            public uint dwSize; //½ل¹¹جه´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANS_RECORD_STATUS[] struChanStatus; //ز»×é64¸ِ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG
        {
            public ushort wXCoordinate; /*¾طذخ×َةد½ائًت¼µمX×ّ±ê*/
            public ushort wYCoordinate; /*¾طذخ×َةد½اY×ّ±ê*/
            public ushort wWidth;       /*¾طذخ؟ي¶ب*/
            public ushort wHeight;      /*¾طذخ¸ك¶ب*/
        }

        /*´°؟عذإد¢*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputIdx;          /*تنبëش´ث÷ز‎*/
            public byte byLayerIdx;          /*ح¼²م£¬0خھ×îµ×²م*/
            public byte byTransparency; //ح¸أ÷¶ب£¬0،«100 
            public NET_DVR_RECTCFG  struWin;//ؤ؟µؤ´°؟ع(دà¶شدشت¾ا½)
            public ushort wScreenHeight;//´َئء¸ك
            public ushort wScreenWidth;//´َئء؟ي
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLWINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENZOOM
        {
            public uint dwSize;
            public uint dwScreenNum;//´َئء؛إ
            public NET_DVR_POINT_FRAME struPointFrame;
            public byte byLayer;//ح¼²م؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2011-04-18
        /*ةمدٌ»ْذإد¢,×î¶à9999¸ِ£¬´س1؟ھت¼ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_CAMERAINFO
        {
            public uint dwGlobalCamId;      /* camµؤب«¾ض±à؛إ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName; /*camµؤأû³ئ*/
            public uint dwMatrixId;          /*cam¶شس¦¾طصَµؤ±à؛إ*/
            public uint dwLocCamId;         /*cam¶شس¦¾طصَµؤؤع²؟±à؛إ*/
            public byte byValid;    /*تا·ٌسذذ§£¬0-·ٌ£¬1-تا*/
            public byte byPtzCtrl; /* تا·ٌ؟ة؟ط£¬0-·ٌ£¬1-تا*/
            public byte byUseType; //*ت¹سأہàذح£¬0-²»×÷خھ¸ةدكت¹سأ£¬1-BNC£¬2-SP3,3-V6¹âدث£¬4-ئنثû¹âدث*/ 
            public byte byUsedByTrunk;//µ±ا°ت¹سأ×´ج¬£¬0-أ»سذ±»ت¹سأ£¬1-±»¸ةدكت¹سأ 
            public byte byTrunkReq; /*ةمدٌ»ْ·ض±وآت,زشD1خھµ¥خ»£؛1 - 1¸ِD1£¬2- 2¸ِD1£¬×÷خھ¸ةدكت¹سأت±£¬ض¸µؤتا¸ةدكµؤ´ّ؟ي*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struInstallTime;//°²×°ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*سأح¾أèتِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*¼àتسئ÷ذإد¢£¬×î¶à2048¸ِ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MONITORINFO
        {
            public uint dwGloalMonId; /*mon µؤح³ز»±à؛إ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sMonName;
            public uint dwMatrixId;  /*monثùشع¾طصَµؤ±à؛إ*/
            public uint dwLocalMonId; /*monµؤؤع²؟±à؛إ*/
            public byte byValid;    /*تا·ٌسذذ§£¬0-·ٌ£¬1-تا*/
            public byte byTrunkType; /*ت¹سأہàذح£¬0-²»×÷خھ¸ةدكت¹سأ£¬1-BNC£¬2-SP3,3-V6¹âدث£¬4-ئنثû¹âدث*/
            public byte byUsedByTrunk;//µ±ا°ت¹سأ×´ج¬£¬0-أ»سذ±»ت¹سأ£¬1-±»¸ةدكت¹سأ 
            public byte byTrunkReq; /*·ض±وآت, زشD1خھµ¥خ»£؛1- 1¸ِD1£¬2- 2¸ِD1£¬×÷خھ¸ةدكت¹سأت±£¬ض¸µؤتا¸ةدكµؤ´ّ؟ي*/
            public NET_DVR_TIME struInstallTime;//°²×°ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*سأح¾أèتِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_DIGITALMATRIX
        {
            public NET_DVR_IPADDR struAddress; /*ةè±¸خھت‎×ضةè±¸ت±µؤIPذإد¢*/
            public ushort wPort;
            public byte byNicNum; /*0 - eth0, 1 - eth1, ؟¼آاث«حّ؟عبç؛خح¨ذإ¼سبë°َ¶¨µؤحّ؟ع*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_ANALOGMATRIX
        {
            public byte bySerPortNum;   /*ء¬½سµؤ´®؟ع؛إ*/
            public byte byMatrixSerPortType;/* ¾طصَ½سبëحّ¹طµؤ´®؟عسëؤ£ؤâ¾طصَµؤ¼üإج؟ع(¼üإجذ­زé)ء¬½س»¹تاسë¾طصَح¨ذإ؟ع£¨¾طصَذ­زé£©ء¬½س £¬0 --- ¾طصَذ­زéح¨ر¶؟ع 1 --- ¼üإجح¨ر¶؟ع*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SINGLE_RS232 struRS232;	//232´®؟ع²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_MATRIX_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_MATRIX_DIGITALMATRIX struDigitalMatrix;
            [FieldOffsetAttribute(0)]
            public NET_MATRIX_ANALOGMATRIX struAnalogMatrix;
        }

        /*¾طصَإنضأذإد¢£¬×î¶à20¸ِ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MATRIXINFO
        {
            public uint dwSize;
            public uint dwMatrixId;  /*¾طصَ±à؛إ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;
            public byte byCtrlType; /*ض¸ح¨ر¶·½ت½تا´®؟عح¨ذإ, »¹تاحّآçح¨ذإ*/
            public byte byProtocolType;/*ةèضأح¨ذإ؟طضئذ­زé*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   /*ش¤ءô*/
            public NET_MATRIX_UNION struMatrixUnion;
            public uint dwMaxPortsIn; /*¾طصَتنبëت‎*/
            public uint dwMaxPortsOut;/*¾طصَتن³ِت‎*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;   /*µاآ¼سأ»§أû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;  /*µاآ¼أـآë*/
            public NET_DVR_TIME struInstallTime;//°²×°ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*سأح¾أèتِ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   /*ش¤ءô*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMatrixNum;//ةè±¸·µ»طµؤ¾طصَت‎ء؟
            public IntPtr pBuffer;//¾طصَذإد¢»؛³هاّ
            public uint dwBufLen;//ثù·ضإنض¸صë³¤¶ب£¬تنبë²خت‎
        }

        /*´®؟عإنضأذإد¢*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_UARTPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPortName;
            public ushort wUserId; /*سأ»§±à؛إ£¬µ±ء¬½سةè±¸خھ¼üإجت±£¬°َ¶¨ز»¸ِسأ»§£¬سأسعب¨دق¹ـہي*/
            public byte byPortType;    /*´®؟عہàذح£¬ب‎ضض0-RS232/1-RS485/2-RS422*/
            public byte byFuncType; /*´®؟عء¬½سµؤةè±¸µؤہàذح0-؟صدذ£¬1-¼üإج£¬2-سأ×÷ح¸أ÷ح¨µہ(485´®؟ع²»؟ةإنضأ³ةح¸أ÷ح¨µہ),3-ؤ£ؤâ¾طصَ*/
            public byte byProtocolType;  /*´®؟عض§³ضµؤذ­زéہàذح, µ±ء¬½س¼üإجةè±¸ت±ذèزھ¸أذإد¢,»ٌب،¼üإجض§³ضذ­زéµؤ±à؛إ¼°أèتِ·û*/
            public byte byBaudRate;
            public byte byDataBits;
            public byte byStopBits;   /*ح£ض¹خ»*/
            public byte byParity;      /*ذ£رé*/
            public byte byFlowCtrl;   /*ء÷؟ط£¬بي¼‏ء÷؟ط£¬خقء÷؟ط*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     /*ش¤ءô*/
        }

        //×î¶à256¸ِسأ»§£¬1،«256
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            public byte byRole;/*سأ»§½اة«:0-¹ـہيش±,1-²ظ×÷ش±£»ض»سذز»¸ِدµح³¹ـہيش±£¬255¸ِ²ظ×÷ش±*/
            public byte byLevel;  /*ح³ز»¼¶±ً£¬سأسع²ظ×÷¼¶±ً¹ـہي,1- 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //×î¶à255¸ِ×تش´×é
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_RESOURSEGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byGroupName;
            public byte byGroupType;/*0-ةمدٌ»ْCAM×é£¬1-¼àتسئ÷MON×é*/
            public byte byRes1;
            public ushort wMemNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
            public uint[] dwGlobalId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //×î¶à255¸ِسأ»§×é
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wUserMember;  /*°ü؛¬µؤسأ»§³ةش±*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wResorceGroupMember; /*°ü؛¬µؤ×تش´×é³ةش±*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byPermission;//ب¨دق£¬ت‎×é0-ptzب¨دق،¢اذ»»ب¨دق،¢²éر¯ب¨دق
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_TRUNKPARAM
        {
            public uint dwSize;
            public uint dwTrunkId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sTrunkName;
            public uint dwSrcMonId;
            public uint dwDstCamId;
            public byte byTrunkType;  /*ت¹سأہàذح  1-BNC£¬2-SP3¹âدث¸كاه£¬3-SP3¹âدثD1£¬ 4-V6¹âدث£¬5-ئنثû¹âدث*/
            public byte byAbility;     /*±يت¾¹âدثµؤ´ّ؟ي£¬؟ةزش´«تن¼¸آ·*/
            public byte bySubChan;   /*صë¶ش¹âدث¸ةدك¶ّرش£¬±يت¾×سح¨µہ؛إ*/
            public byte byLevel;		/* ¸ةدك¼¶±ً 1-255*/
            public ushort wReserveUserID;	//ش¤ءôµؤسأ»§ID£؛ 1~256 £¬0±يت¾تح·إش¤ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRUNKLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwTrunkNum;//ةè±¸·µ»طµؤ¸ةدكت‎ء؟
            public IntPtr pBuffer;//¸ةدكذإد¢»؛³هاّ
            public uint dwBufLen;//ثù·ضإنض¸صë³¤¶ب£¬تنبë²خت‎
        }

        public const int MATRIX_PROTOCOL_NUM   = 20;    //ض§³ضµؤ×î´َ¾طصَذ­زéت‎
        public const int KEYBOARD_PROTOCOL_NUM = 20;    //ض§³ضµؤ×î´َ¼üإجذ­زéت‎

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE_EX
        {
            public ushort wType;               /*ipcذ­زéضµ*/
            public ushort wCommunitionType;		/*0£؛ؤ£ؤâ 1£؛ت‎×ض 2£؛¼وبفؤ£ؤâ،¢ت‎×ض*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*ذ­زéأèتِ×ض¶خ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXMANAGE_ABIILITY
        {
            public uint dwSize;
            public uint dwMaxCameraNum;//×î´َCameraت‎ء؟
            public uint dwMaxMonitorNum;//×î´َ¼àتسئ÷ت‎ء؟
            public ushort wMaxMatrixNum;//×î´َ¾طصَت‎ء؟
            public ushort wMaxSerialNum;//´®؟عت‎ء؟
            public ushort wMaxUser;//×î´َسأ»§ت‎
            public ushort wMaxResourceArrayNum;//×î´َ×تش´×éت‎
            public ushort wMaxUserArrayNum;//×î´َسأ»§×éت‎
            public ushort wMaxTrunkNum;//×î´َ¸ةدكت‎
            public byte nStartUserNum;//ئًت¼سأ»§؛إ
            public byte nStartUserGroupNum;//ئًت¼سأ»§×é؛إ
            public byte nStartResourceGroupNum;//ئًت¼×تش´×é؛إ
            public byte nStartSerialNum;//ئًت¼´®؟ع؛إ
            public uint  dwMatrixProtoNum;     /*سذذ§µؤ¾طصَذ­زéت‎ؤ؟£¬´س0؟ھت¼*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struMatrixProto;/*×î´َذ­زéءذ±ي³¤¶ب*/
            public uint dwKeyBoardProtoNum;     /*سذذ§µؤ¼üإجذ­زéت‎ؤ؟£¬´س0؟ھت¼*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struKeyBoardProto;/*×î´َذ­زéءذ±ي³¤¶ب*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //بثء³×¥إؤ¹وشٍ(µ¥جُ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_FACESNAPCFG
        {
            public byte byActive;				//تا·ٌ¼¤»î¹وشٍ£؛0-·ٌ£¬1-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£ءô
            public NET_VCA_SIZE_FILTER struSizeFilter;   //³ك´ç¹‎آثئ÷
            public NET_VCA_POLYGON struVcaPolygon;		//بثء³ت¶±ًاّسٍ
        }

        //بثء³×¥إؤ¹وشٍ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAPCFG
        {
            public uint dwSize;
            public byte bySnapTime;					//µ¥¸ِؤ؟±êبثء³µؤ×¥إؤ´خت‎0-10
            public byte bySnapInterval;                 //×¥إؤ¼ن¸ô£¬µ¥خ»£؛ض،
            public byte bySnapThreshold;               //×¥إؤمذضµ£¬0-100
            public byte byGenerateRate; 		//ؤ؟±êةْ³ةثظ¶ب,·¶خ§[1, 5]	
            public byte bySensitive;			//ؤ؟±ê¼ى²âءéأô¶ب£¬·¶خ§[1, 5]
            public byte byReferenceBright; //2012-3-27²خ؟¼ءء¶ب[0,100]
            public byte byMatchType;         //2012-5-3±ب¶ش±¨¾¯ؤ£ت½£¬0-ؤ؟±êدûت§؛َ±¨¾¯£¬1-تµت±±¨¾¯
            public byte byMatchThreshold;  //2012-5-3تµت±±ب¶شمذضµ£¬0~100
            public NET_DVR_JPEGPARA struPictureParam; //ح¼ئ¬¹و¸ٌ½ل¹¹
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_FACESNAPCFG[] struRule; //بثء³×¥إؤ¹وشٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //بثء³×¥إؤ½ل¹û±¨¾¯ةد´«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_RESULT
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwFacePicID;
            public uint dwFaceScore;
            public NET_VCA_TARGET_INFO struTargetInfo;
            public NET_VCA_RECT struRect;
            public NET_VCA_DEV_INFO struDevInfo;
            public uint dwFacePicLen;
            public uint dwBackgroundPicLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
            public IntPtr pBuffer1;//ض¸دٍبثء³×سح¼µؤح¼ئ¬ت‎¾ف
            public IntPtr pBuffer2;//±³¾°ح¼µؤح¼ئ¬ت‎¾ف£¨±£ءô£¬ح¨¹‎²éصز±³¾°ح¼½س؟ع؟ةزش»ٌب،±³¾°ح¼£©
        }

        //ذé½¹صى²â½ل¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOCUS_ALARM
        {
            public uint dwSize;     /*½ل¹¹³¤¶ب*/
            public NET_VCA_DEV_INFO struDevInfo;/*ةè±¸ذإد¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOEXCEPTION_ALARM
        {
            public uint    dwSize;     /*½ل¹¹³¤¶ب*/
            public byte byAlarmType;//±¨¾¯ہàذح£¬1-زôئµتنبëزى³££¬2-زôئµتنبëح»±ن
            public byte byRes1;
            public ushort wAudioDecibel;//ةùزôا؟¶ب£¨زôئµتنبëح»±نت±سأµ½£©
            public NET_VCA_DEV_INFO struDevInfo;/*ةè±¸ذإد¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_BUTTON_DOWN_EXCEPTION_ALARM
        {
            public uint dwSize;     /*½ل¹¹³¤¶ب*/
            public NET_VCA_DEV_INFO struDevInfo;/*ةè±¸ذإد¢*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_IMAGE_CFG
        {
            public uint dwWidth;                  //»ز¶بح¼دٌت‎¾ف؟ي¶ب
            public uint dwHeight;                 //»ز¶بح¼دٌ¸ك¶ب
            public uint dwImageLen;  //»ز¶بح¼دٌت‎¾ف³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
            public IntPtr pImage;    //»ز¶بح¼دٌت‎¾ف
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_CFG
        {
            public uint  dwSize;           //½ل¹¹´َذ،
            public byte byEnable;         //تا·ٌ¼¤»î¹وشٍ;
            public byte bySensitivity;      //¼ى²âءéأô¶ب£¬[0,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //±£ءô×ض½ع 
            public NET_VCA_SIZE_FILTER struSizeFilter;  //³ك´ç¹‎آثئ÷
            public NET_VCA_POLYGON  struPolygon;    //¶à±كذخ
            public NET_VCA_FD_IMAGE_CFG struFDImage;  //ح¼ئ¬ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_PROCIMG
        {
            public uint dwImageLen;  //ح¼ئ¬ت‎¾ف³¤¶ب
            public uint dwFaceScore;		//بثء³ئہ·ض,0-100
            public NET_VCA_RECT struVcaRect; //بثء³×سح¼اّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
            public IntPtr pImage;  //ح¼ئ¬ت‎¾ف
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_RESULT
        {
            public uint dwSize;   //½ل¹¹´َذ،
            public uint dwImageId; //´َح¼ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
            public uint dwSubImageNum;  //بثء³×سح¼صإت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SUB_PROCIMG[] struProcImg;  //µ¥صإ×سح¼ذإد¢
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PICMODEL_RESULT
        {
            public uint dwImageLen;  //ح¼ئ¬ت‎¾ف³¤¶ب
            public uint dwModelLen;  //ؤ£ذحت‎¾ف³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
            public IntPtr pImage;  //بثء³ح¼ئ¬ت‎¾فض¸صë
            public IntPtr pModel;  //ؤ£ذحت‎¾فض¸صë
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REGISTER_PIC
        {
            public uint dwImageID; //´َح¼ID
            public uint dwFaceScore;		//بثء³ئہ·ض,0-100
            public NET_VCA_RECT struVcaRect;  //بثء³×سح¼اّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
        }

        //¼®¹ل²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AREAINFOCFG
        {
            public ushort wNationalityID;//¹ْ¼®
            public ushort wProvinceID;//ت،
            public ushort wCityID;//تذ
            public ushort wCountyID;//دط
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        //بثش±ذإد¢½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ATTRIBUTE
        {
            public byte bySex;//ذش±ً£؛0-ؤذ£¬1-إ®
            public byte byCertificateType;//ض¤¼‏ہàذح£؛0-ةي·فض¤£¬1-¾¯¹ظض¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBirthDate;//³ِةْؤêشآ£¬بç£؛201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //ذصأû
            public NET_DVR_AREAINFOCFG struNativePlace;//¼®¹ل²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber; //ض¤¼‏؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMANATTRIBUTE_COND
        {
            public byte bySex; //ذش±ً£؛0-²»ئôسأ£¬1-ؤذ£¬2-إ®
            public byte byCertificateType; //ض¤¼‏ہàذح£؛0-²»ئôسأ£¬1-ةي·فض¤£¬2-¾¯¹ظض¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStartBirthDate; //ئًت¼³ِةْؤêشآ£¬بç£؛201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEndBirthDate; //½طض¹³ِةْؤêشآ£¬بç201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //ذصأû
            public NET_DVR_AREAINFOCFG struNativePlace; //¼®¹ل²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber;  //ض¤¼‏؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //؛عأûµ¥ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO
        {
            public uint dwSize;//½ل¹¹´َذ،
            public uint dwRegisterID;//أûµ¥×¢²لID؛إ£¨ض»¶ء£©
            public uint dwGroupNo;//·ض×é؛إ
            public byte byType;//؛ع°×أûµ¥±êض¾£؛0-ب«²؟£¬1-°×أûµ¥£¬2-؛عأûµ¥
            public byte byLevel;//؛عأûµ¥µب¼¶£¬0-ب«²؟£¬1-µح£¬2-ضذ£¬3-¸ك
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute;//بثش±ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemark;//±¸×¢ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PARA
        {
            public uint dwSize;   //½ل¹¹´َذ،
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //؛عأûµ¥»ù±¾²خت‎
            public uint dwRegisterPicNum;  //؛عأûµ¥ح¼¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struRegisterPic;  //؛عأûµ¥ح¼ئ¬ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_COND
        {
            public Int32 lChannel; //ح¨µہ؛إ
            public uint dwGroupNo; //·ض×é؛إ
            public byte byType; //؛ع°×أûµ¥±êض¾£؛0-ب«²؟£¬1-°×أûµ¥£¬2-؛عأûµ¥
            public byte byLevel; //؛عأûµ¥µب¼¶£¬0-ب«²؟£¬1-µح£¬2-ضذ£¬3-¸ك
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±£ءô
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute; //بثش±ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PIC
        {
            public uint dwSize;   //½ل¹¹´َذ،
            public uint dwFacePicNum;  //بثء³ح¼¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struBlackListPic;  //µ¥صإصصئ¬ذإد¢
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND
        {
            public Int32 lChannel;//ح¨µہ؛إ
            public NET_DVR_TIME struStartTime;//؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//½لتّت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        public const int MAX_FACE_PIC_LEN = 6144;   //×î´َبثء³ح¼ئ¬ت‎¾ف³¤¶ب

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_SNAPPIC_DATA
        {
            public uint dwFacePicID; //بثء³ح¼ID
            public uint dwFacePicLen;  //بثء³ح¼ت‎¾ف³¤¶ب
            public NET_DVR_TIME struSnapTime;  //×¥إؤت±¼ن
            public uint dwSimilarity; //دàثئ¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_FACE_PIC_LEN)]
            public string sPicBuf;  //ح¼ئ¬ت‎¾ف
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADVANCE_FIND
        {
            public uint dwFacePicID; //بثء³ح¼ئ¬ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_NORMAL_FIND
        {
            public uint dwImageID; //´َح¼ID
            public uint dwFaceScore;  //بثء³ئہ·ض
            public NET_VCA_RECT struVcaRect; //بثء³×سح¼اّسٍ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_FIND_SNAPPIC_UNION
        {
            //ءھ؛دجه´َذ،خھ44×ض½ع
            [FieldOffsetAttribute(0)]
            public NET_VCA_NORMAL_FIND  struNormalFind; //ئصح¨¼ىث÷
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADVANCE_FIND struAdvanceFind; //¸ك¼¶¼ىث÷
        }

        public enum VCA_FIND_SNAPPIC_TYPE
        {
            VCA_NORMAL_FIND = 0x00000000,   //ئصح¨¼ىث÷
            VCA_ADVANCE_FIND = 0x00000001  //¸ك¼¶¼ىث÷
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND_ADVANCE
        {
            public Int32 lChannel;//ح¨µہ؛إ
            public NET_DVR_TIME struStartTime;//؟ھت¼ت±¼ن
            public NET_DVR_TIME struStopTime;//½لتّت±¼ن
            public byte byThreshold;  //مذضµ£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
            public VCA_FIND_SNAPPIC_TYPE dwFindType;//¼ىث÷ہàذح£¬دê¼ûVCA_FIND_SNAPPIC_TYPE
            public NET_VCA_FIND_SNAPPIC_UNION uFindParam; //¼ىث÷²خت‎
        }

        //بثء³×¥إؤذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM
        {
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwSnapFacePicID;
            public uint dwSnapFacePicLen;
            public NET_VCA_DEV_INFO struDevInfo;//بثء³×¥إؤةد´«ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
            public IntPtr pBuffer1;//ض¸دٍح¼ئ¬µؤض¸صë
        }
        //؛عأûµ¥±¨¾¯ذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;
            public uint dwBlackListPicLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
            public IntPtr pBuffer1;//ض¸دٍح¼ئ¬µؤض¸صë
        }

        //؛عأûµ¥±ب¶ش½ل¹û±¨¾¯ةد´«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM
        {
            public uint dwSize;
            public float fSimilarity;//دàثئ¶ب£¬ب،ضµ·¶خ§£؛[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM struSnapInfo;//بثء³×¥إؤةد´«ذإد¢
            public NET_VCA_BLACKLIST_INFO_ALARM struBlackListInfo;//؛عأûµ¥±¨¾¯ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM_LOG
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo; //؛عأûµ¥»ù±¾ذإد¢
            public uint dwBlackListPicID;       //؛عأûµ¥بثء³×سح¼ID£¬سأسع²éصزح¼ئ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM_LOG
        {
            public uint dwRelativeTime;     // دà¶شت±±ê
            public uint dwAbsTime;			// ¾ّ¶شت±±ê
            public uint dwSnapFacePicID;       //×¥إؤبثء³ح¼ID
            public NET_VCA_DEV_INFO struDevInfo;		//ا°¶ثةè±¸ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM_LOG
        {
            public uint dwSize;     		// ½ل¹¹´َذ،
            public float fSimilarity; //دàثئ¶ب£¬[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM_LOG  struSnapInfoLog; //×¥إؤذإد¢
            public NET_VCA_BLACKLIST_INFO_ALARM_LOG struBlackListInfoLog; //؛عأûµ¥ذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICCOND
        {
            public uint dwSize;     		// ½ل¹¹´َذ،
            public uint dwSnapFaceID; //×¥إؤبثء³×سح¼ID
            public uint dwBlackListID; //ئ¥إنµؤ؛عأûµ¥ID
            public uint dwBlackListFaceID; //±ب¶شµؤ؛عأûµ¥بثء³×سح¼ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±£ءô×ض½ع
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICTURE
        {
            public uint dwSize;     		// ½ل¹¹´َذ،
            public uint dwSnapFaceLen; //×¥إؤبثء³×سح¼³¤¶ب
            public uint dwBlackListFaceLen; //±ب¶شµؤ؛عأûµ¥بثء³×سح¼³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              //±£ءô×ض½ع
            public IntPtr pSnapFace;  //×¥إؤبثء³×سح¼µؤح¼ئ¬ت‎¾ف
            public IntPtr pBlackListFace;  //±ب¶شµؤ؛عأûµ¥بثء³×سح¼ت‎¾ف
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_FASTREGISTER_PARA
        {
            public uint dwSize;   //½ل¹¹´َذ،
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //؛عأûµ¥»ù±¾²خت‎
            public uint dwImageLen;  //ح¼دٌت‎¾ف³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
            public IntPtr pImage;    //ح¼دٌت‎¾ف
        }

        //µ¥¸ِ·ضاّإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_PATH
        {
            public byte byActive;  // تا·ٌ؟ةسأ,0-·ٌ,1-تا 
            public byte byType;   //0-´و´¢×¥إؤ£¬1-´و´¢؛عأûµ¥±ب¶ش±¨¾¯£¬2-´و´¢×¥إؤ؛ح؛عأûµ¥±ب¶ش±¨¾¯£¬0xff-خقذ§
            public byte bySaveAlarmPic; //تا·ٌسأسع±£´و¶دحّµؤ±¨¾¯ح¼ئ¬£¬0-·ٌ£¬1-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //±£ءô
            public uint dwDiskDriver;   //إج·û؛إ£¬´س0؟ھت¼
            public uint dwLeftSpace;   //ش¤ءôبفء؟£¨µ¥خ»خھG£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±£ءô
        }

        //´و´¢آ·¾¶ةèضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SAVE_PATH_CFG
        {
            public uint dwSize;   //½ل¹¹´َذ،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_PATH[] struPathInfo; //µ¥¸ِ·ضاّ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_ACCESS_CFG
        {
            public uint   dwSize;
            public NET_DVR_IPADDR struIP;		//½سبëةè±¸µؤIPµطض·
            public ushort wDevicePort;			 	//¶ث؟ع؛إ
            public byte byEnable;		         //تا·ٌئôسأ£¬0-·ٌ£¬1-تا
            public byte byRes1;				//±£ءô
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//½سبëةè±¸µؤµاآ¼صت؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//½سبëةè±¸µؤµاآ¼أـآë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        /********************************ضاؤـبثء³ت¶±ً end****************************/
        //·ض±وآت
        public const int NOT_AVALIABLE = 0;
        public const int SVGA_60HZ = 52505660;
        public const int SVGA_75HZ = 52505675;
        public const int XGA_60HZ = 67207228;
        public const int XGA_75HZ = 67207243;
        public const int SXGA_60HZ = 84017212;
        public const int SXGA2_60HZ = 84009020;
        public const int _720P_60HZ = 83978300;
        public const int _720P_50HZ = 83978290;
        public const int _1080I_60HZ = 394402876;
        public const int _1080I_50HZ = 394402866;
        public const int _1080P_60HZ = 125967420;
        public const int _1080P_50HZ = 125967410;
        public const int _1080P_30HZ = 125967390;
        public const int _1080P_25HZ = 125967385;
        public const int _1080P_24HZ = 125967384;
        public const int UXGA_60HZ = 105011260;
        public const int UXGA_30HZ = 105011230;
        public const int WSXGA_60HZ = 110234940;
        public const int WUXGA_60HZ = 125982780;
        public const int WUXGA_30HZ = 125982750;
        public const int WXGA_60HZ = 89227324;
        public const int SXGA_PLUS_60HZ = 91884860;

        //دشت¾ح¨µہ»­أو·ض¸îؤ£ت½
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPWINDOWMODE
        {
            public byte byDispChanType;//دشت¾ح¨µہہàذح£؛0-VGA, 1-BNC, 2-HDMI, 3-DVI
            public byte byDispChanSeq;//دشت¾ح¨µہذٍ؛إ,´س1؟ھت¼£¬بç¹ûہàذحتاVGA£¬شٍ±يت¾µع¼¸¸ِVGA
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispMode;
        }

        //دشت¾ح¨µہذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPINFO
        {
            public byte byChanNums;//ح¨µہ¸ِت‎
            public byte byStartChan;//ئًت¼ح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUPPORT_RES, ArraySubType = UnmanagedType.U1)]
            public uint[] dwSupportResolution;//ض§³ضµؤ·ض±وآت
        }

        //´َئءئ´½سذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINFO
        {
            public byte bySupportBigScreenNums;//×î¶à´َئءئ´½ست‎ء؟
            public byte byStartBigScreenNum;//´َئءئ´½سئًت¼؛إ
            public byte byMaxScreenX;//´َئءئ´½سؤ£ت½
            public byte byMaxScreenY;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY_V41
        {
            public uint dwSize;
            public byte byDspNums;//DSP¸ِت‎  
            public byte byDecChanNums;//½âآëح¨µہت‎
            public byte byStartChan;//ئًت¼½âآëح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            public NET_DVR_DISPINFO struVgaInfo;//VGAدشت¾ح¨µہذإد¢
            public NET_DVR_DISPINFO struBncInfo;//BNCدشت¾ح¨µہذإد¢
            public NET_DVR_DISPINFO struHdmiInfo;//HDMIدشت¾ح¨µہذإد¢
            public NET_DVR_DISPINFO struDviInfo;//DVIدشت¾ح¨µہذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISPWINDOWMODE[] struDispMode;
            public NET_DVR_SCREENINFO struBigScreenInfo;
            public byte bySupportAutoReboot; //تا·ٌض§³ض×ش¶¯ضطئô£¬0-²»ض§³ض£¬1-ض§³ض
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_WINDOWS = 16;//×î´َ´°؟عت‎
        public const int MAX_WINDOWS_V41 = 36;

        public const int STARTDISPCHAN_VGA = 1;
        public const int STARTDISPCHAN_BNC = 9;
        public const int STARTDISPCHAN_HDMI = 25;
        public const int STARTDISPCHAN_DVI = 29;

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_VIDEO_PLATFORM
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [FieldOffsetAttribute(0)]
            public VideoPlatform struVideoPlatform;
            [FieldOffsetAttribute(0)]
            public NotVideoPlatform struNotVideoPlatform;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public NET_DVR_RECTCFG struPosition; //دشت¾ح¨µہشعµçتسا½ضذخ»ضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NotVideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*دشت¾ح¨µہإنضأ½ل¹¹جه*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_VOUTCFG
        {
            public uint dwSize;
            public byte byAudio;			/*زôئµتا·ٌ؟ھئô*/
            public byte byAudioWindowIdx;      /*زôئµ؟ھئô×س´°؟ع*/
            public byte byDispChanType;      /*دشت¾ح¨µہہàذح£؛0-BNC£¬1-VGA£¬2-HDMI£¬3-DVI£¬4-YPbPr(½âآë؟¨·‏خٌئ÷DECODER_SERVER×¨سأ)*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL£¬0-NULL*/
            public uint dwResolution;//·ض±وآت
            public uint dwWindowMode;		/*»­أوؤ£ت½£¬ؤـء¦¼¯»ٌب،*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ِ×س´°؟ع¹طءھµؤ½âآëح¨µہ,ةè±¸ض§³ض½âآë×تش´×ش¶¯·ضإنت±´ث²خت‎²»سأجî³ن*/
            public byte byEnlargeStatus;          /*تا·ٌ´¦سع·إ´َ×´ج¬£¬0£؛²»·إ´َ£¬1£؛·إ´َ*/
            public byte byEnlargeSubWindowIndex;//·إ´َµؤ×س´°؟ع؛إ
            public byte byScale; /*دشت¾ؤ£ت½£¬0---صوتµدشت¾£¬1---ثُ·إدشت¾( صë¶شBNC )*/
            public byte byUnionType;/*اّ·ض¹²سأجه,0-تسئµ×غ؛دئ½ج¨ؤع²؟½âآëئ÷دشت¾ح¨µہإنضأ£¬1-ئنثû½âآëئ÷دشت¾ح¨µہإنضأ*/
            public NET_DVR_VIDEO_PLATFORM struDiff;
            public uint dwDispChanNum; //دشت¾تن³ِ؛إ£¬´ث²خت‎شعب«²؟»ٌب،ت±سذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*½âآëئ÷ةè±¸×´ج¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS_V41
        {
            public byte byDispStatus;      /*دشت¾×´ج¬£؛0£؛خ´دشت¾£¬1£؛ئô¶¯دشت¾*/
            public byte byBVGA;              /*0-BNC£¬1-VGA£¬ 2-HDMI£¬3-DVI£¬0xff-خقذ§*/
            public byte byVideoFormat;     /*تسئµضئت½£¬1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;       /*»­أوؤ£ت½*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;   /*¸÷¸ِ×س»­أو¹طءھµؤ½âآëح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;        /*أ؟¸ِ×س»­أوµؤدشت¾ض،آت*/
            public byte byScreenMode;		/*ئءؤ»ؤ£ت½0-ئصح¨ 1-´َئء*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDispChan; /*»ٌب،ب«²؟دشت¾ح¨µہ×´ج¬ت±سذذ§£¬ةèضأت±؟ةجî0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*½âآëئ÷ةè±¸×´ج¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS_V41
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;     /*½âآëح¨µہ×´ج¬*/
                                                                       /*دشت¾ح¨µہ×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS_V41[] struDispChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;         /*±¨¾¯تنبë×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatus;       /*±¨¾¯تن³ِ×´ج¬*/
            public byte byAudioInChanStatus;          /*سïزô¶ش½²×´ج¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************خؤ¼‏»ط·إ-ش¶³ج»ط·إةèضأ*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_V41
        {
            public uint dwSize;
            public NET_DVR_IPADDR   struIP;     /* DVR IPµطض· */
            public ushort wDVRPort;         /* ¶ث؟ع؛إ */
            public byte byChannel;			/* ح¨µہ؛إ */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* سأ»§أû */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* أـآë */
            public uint dwPlayMode;     /* 0£­°´خؤ¼‏ 1£­°´ت±¼ن*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		/*±£ءô*/
        }

        public const int MAX_BIGSCREENNUM_SCENE = 100;

        //دشت¾ح¨µہإنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG_SCENE
        {
            public ushort wXCoordinate; /*¾طذخ×َةد½ائًت¼µمX×ّ±ê*/
            public ushort wYCoordinate; /*¾طذخ×َةد½اY×ّ±ê*/
            public ushort wWidth;       /*¾طذخ؟ي¶ب*/
            public ushort wHeight;      /*¾طذخ¸ك¶ب*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENEDISPCFG
        {
            public byte byEnable;//تا·ٌئôسأ£¬0-²»ئôسأ£¬1-ئôسأ
            public byte bySoltNum;//²غخ»؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDispChanNum;
            public byte byAudio;				/*زôئµتا·ٌ؟ھئô,0-·ٌ£¬1-تا*/
            public byte byAudioWindowIdx;      /*زôئµ؟ھئô×س´°؟ع*/
            public byte byVedioFormat;          /*1:NTSC,2:PAL£¬0-NULL*/
            public byte byWindowMode;			/*»­أوؤ£ت½£¬´سؤـء¦¼¯»ٌب،*/
            public byte byEnlargeStatus;         /*تا·ٌ´¦سع·إ´َ×´ج¬£¬0£؛²»·إ´َ£¬1£؛·إ´َ*/
            public byte byEnlargeSubWindowIndex;//·إ´َµؤ×س´°؟ع؛إ    
            public byte byScale; /*دشت¾ؤ£ت½£¬0-صوتµدشت¾£¬1-ثُ·إدشت¾( صë¶شBNC )*/
            public uint dwResolution;//·ض±وآت
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*¸÷¸ِ×س´°؟ع¹طءھµؤ½âآëح¨µہ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;/*²غخ»؛إ*/
            //دشت¾´°؟عثù½âتسئµ·ض±وآت£¬1-D1,2-720P,3-1080P£¬ةè±¸¶ثذèزھ¸ù¾ف´ث//·ض±وآت½ّذذ½âآëح¨µہµؤ·ضإن£¬بç1·ضئءإنضأ³ة1080P£¬شٍةè±¸»ل°ر4¸ِ½âآëح¨µہ¶¼·ضإن¸ّ´ث½âآëح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public byte byRow;//´َئءثùشعµؤذذµؤذٍ؛إ
            public byte byColumn;//´َئءثùشعµؤءذµؤذٍ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_RECTCFG struDisp; //µçتسا½دشت¾خ»ضأ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO_SCENE
        {
            public NET_DVR_IPADDR struIP;				/* DVR IPµطض· */
            public ushort wDVRPort;			 	/* ¶ث؟ع؛إ */
            public byte byChannel;		/* ح¨µہ؛إ£¬¶شسع9000µبةè±¸µؤIPC½سبë£¬ح¨µہ؛إ´س33؟ھت¼ */
            public byte byTransProtocol;		/* ´«تنذ­زéہàذح0-TCP£¬1-UDP £¬2-MCAST£¬3-RTP*/
            public byte byTransMode;			/* ´«تنآëء÷ؤ£ت½ 0£­ض÷آëء÷ 1£­×سآëء÷*/
            public byte byFactoryType;				/*ا°¶ثةè±¸³§¼زہàذح*/
            public byte byDeviceType;			//ةè±¸ہàذح£¬1-IPC£¬2- ENCODER
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/* ¼à؟طض÷»ْµاآ½صت؛إ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/* ¼à؟طض÷»ْأـآë */
        }

        /*ء÷أ½جه·‏خٌئ÷»ù±¾إنضأ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE
        {
            public byte byValid;			/*تا·ٌئôسأء÷أ½جه·‏خٌئ÷ب،ء÷,0±يت¾خقذ§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;	/*ء÷أ½جه·‏خٌئ÷µطض·*/
            public ushort wDevPort;			/*ء÷أ½جه·‏خٌئ÷¶ث؟ع*/
            public byte byTransmitType;		/*´«تنذ­زéہàذح0-TCP£¬1-UDP */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG_SCENE
        {
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE    streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE              struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYC_SUR_CHAN_ELE_SCENE
        {
            public byte byEnable;	/* تا·ٌئôسأ 0£­·ٌ 1£­ئôسأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE    struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE          struDecChanInfo;	/*آضر²½âآëح¨µہذإد¢*/
        }

        //آضر²½âآë½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_SCENE
        {
            public ushort wPoolTime;		/*آضر¯¼ن¸ô*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYC_SUR_CHAN_ELE_SCENE[] struChanArray;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //µ¥¸ِ½âآëح¨µہإنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODECHANCFG_SCENE
        {
            public byte byDecodeEnable;//½âآëئًح£±êض¾£¬0-ح£ض¹£¬1-ئôسأ¶¯ج¬½âآë£¬2-ئôسأآضر²½âآë
            public byte bySlotNum;//²غخ»؛إ
            public byte byDecChan;
            public byte byJointAllDecodeChan;		//تا·ٌ¹طءھحٍؤـ½âآëح¨µہ 0-²»¹طءھ£¬1-¹طءھ
            public byte byJointSlotNum;			//¹طءھµؤ²غخ»؛إ£¨حٍؤـ½âآë°هµؤ²غخ»؛إ£©
            public byte byJointChanNum;		//¹طءھµؤح¨µہ؛إ£¨حٍؤـ½âآë°هح¨µہ؛إ£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public STRUDECCFG struDecCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct STRUDECCFG
        {
            //[FieldOffsetAttribute(0)]
            //[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5480, ArraySubType = UnmanagedType.I1)]
            //public byte[] byRes;
            [FieldOffsetAttribute(0)]
            public NET_DVR_PU_STREAM_CFG_SCENE struSceneDynamicDecCfg;
            [FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_LOOP_DECINFO_SCENE struSceneCycDecCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG_SCENE
        {
            public byte byAllValid; /*آ‏سخت¹ؤـ±êض¾ */
            public byte byAssociateBaseMap;//¹طءھµؤµ×ح¼ذٍ؛إ£¬0´ْ±ي²»¹طءھ
            public byte byEnableSpartan;//´َئء³©دشت¹ؤـ£¬1-؟ھ£¬0-¹ط
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            public NET_DVR_BIGSCREENCFG struBigScreen;

            public void Init()
            {
                struBigScreen = new NET_DVR_BIGSCREENCFG();
                struWinCfg = new NET_DVR_WINCFG [ MAX_LAYERNUMS ];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_SCENECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSceneName;
            public byte byBigScreenNums;//´َئءµؤ¸ِت‎£¬×î´َضµح¨¹‎ؤـء¦¼¯»ٌب،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wDecChanNums;//³،¾°ضذ½âآëح¨µہµؤ¸ِت‎
            public ushort wDispChanNums;//³،¾°ضذدشت¾ح¨µہµؤ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public IntPtr pBigScreenBuffer;//´َئءإنضأ»؛³هاّ, byBigScreenNums،ءsizeof(NET_DVR_BIGSCREENCFG_SCENE)
            public IntPtr pDecChanBuffer;//½âآëح¨µہإنضأ»؛³هاّ, wDecChanNums،ءsizeof(NET_DVR_DECODECHANCFG_SCENE)
            public IntPtr pDispChanBuffer;//دشت¾ح¨µہإنضأ»؛³هاّ, wDispChanNums،ءsizeof(NET_DVR_SCENEDISPCFG)
            public void Init()
            {
                sSceneName = new byte [ NAME_LEN ];
                byRes1 = new byte [ 3 ];
                byRes1 = new byte [ 12 ];
            }
        }
        public const int NET_DVR_GET_ALLWINCFG = 1503; //´°؟ع²خت‎»ٌب،

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENASSOCIATECFG
        {
            public uint dwSize;
            public byte byEnableBaseMap;//ت¹ؤـµ×ح¼دشت¾
            public byte byAssociateBaseMap;//¹طءھµؤµ×ح¼ذٍ؛إ£¬0´ْ±ي²»¹طءھ
            public byte byEnableSpartan;//´َئء³©دشت¹ؤـ£¬1-؟ھ£¬0-¹ط
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************´°؟عةèضأ*******************************/
        public const int MAX_WIN_COUNT = 224; //ض§³ضµؤ×î´َ؟ھ´°ت‎

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputType;		//¼ûCAM_MDOE
            public ushort wInputIdx;			/*تنبëش´ث÷ز‎*/
            public uint dwLayerIdx;			/*ح¼²م£¬0خھ×îµ×²م*/
            public NET_DVR_RECTCFG struWin;	//ؤ؟µؤ´°؟ع(دà¶شدشت¾ا½)
            public byte byWndIndex;			//´°؟ع؛إ
            public byte byCBD;				//0-خق£¬1-´ّ±³¾°£¬2-²»´ّ±³¾°
            public byte bySubWnd;			//0²»تا£¬1تا
            public byte byRes1;
            public uint dwDeviceIndex;//ةè±¸ذٍ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINLIST
        {
            public uint dwSize;
            public ushort wScreenSeq;	//ةè±¸ذٍ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwWinNum;	//ةè±¸·µ»طµؤ´°؟عت‎ء؟
            public IntPtr pBuffer;	//´°؟عذإد¢»؛³هاّ£¬×î´َخھ224*sizeof(NET_DVR_WINCFG)
            public uint dwBufLen;	//ثù·ضإنض¸صë³¤¶ب
        }

        public const int MAX_LAYOUT_COUNT = 16;		//×î´َ²¼¾ضت‎

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUTCFG
        {
            public uint dwSize;
            public byte byValid;								//²¼¾ضتا·ٌسذذ§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLayoutName;			//²¼¾ضأû³ئ			
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WIN_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCREEN_WINCFG[] struWinCfg;	//²¼¾ضؤع´°؟ع²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUT_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYOUT_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LAYOUTCFG[] struLayoutInfo;   //ثùسذ²¼¾ض
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_CAM_COUNT = 224;

        public enum NET_DVR_CAM_MODE
        {
            NET_DVR_UNKNOW = 0,//خقذ§
            NET_DVR_CAM_BNC,
            NET_DVR_CAM_VGA,
            NET_DVR_CAM_DVI,
            NET_DVR_CAM_HDMI,
            NET_DVR_CAM_IP,
            NET_DVR_CAM_RGB,
            NET_DVR_CAM_DECODER,
            NET_DVR_CAM_MATRIX,
            NET_DVR_CAM_YPBPR,
            NET_DVR_CAM_USB,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAMCFG
        {
            public uint dwSize ;
            public byte byValid ;
            public byte byCamMode;						//ذإ؛إتنبëش´ہàذح£¬¼ûNET_DVR_CAM_MODE
            public ushort wInputNo;						//ذإ؛إش´ذٍ؛إ0-224
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName;			//ذإ؛إتنبëش´أû³ئ
            public NET_DVR_VIDEOEFFECT struVideoEffect;	//تسئµ²خت‎
            public NET_DVR_PU_STREAM_CFG struPuStream;	//ipتنبëت±ت¹سأ
            public ushort wBoardNum ;						//ذإ؛إش´ثùشعµؤ°ه؟¨؛إ
            public ushort wInputIdxOnBoard;				//ذإ؛إش´شع°ه؟¨ةدµؤخ»ضأ
            public ushort wResolutionX;					//·ض±وآت
            public ushort wResolutionY;
            public byte byVideoFormat;					//تسئµضئت½£¬0-خق£¬1-NTSC£¬2-PAL
            public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp ،£حّآçذإ؛إش´µؤ·ض±وآت£¬شعجي¼سحّآçذإ؛إش´ت±´«¸ّةè±¸£¬ةè±¸¸ù¾فصâ¸ِ·ض±وآتہ´·ضإن½âآë×تش´،£
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;	//حّآçذإ؛إش´·ض×é ×éأû
            public byte byJointMatrix;			//  ¹طءھ¾طصَ £¬0-²»¹طءھ  1-¹طءھ
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAM_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CAM_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INPUTSTREAMCFG[] struInputStreamInfo; //ثùسذذإ؛إش´
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************تن³ِ²خت‎إنضأ*******************************/
        /*تن³ِح¨µہ¹ـہي*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTPARAM
        {
            public uint  dwSize;
            public byte byMonMode;		/*تن³ِء¬½سؤ£ت½,1-BNC,2-VGA,3-DVI,4-HDMI*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint  dwResolution;	/*·ض±وآت£¬¸ù¾فؤـء¦¼¯»ٌب،ثùض§³ضµؤ½ّذذةèضأ*/
            public NET_DVR_VIDEOEFFECT  struVideoEffect;	/*تن³ِح¨µہتسئµ²خت‎إنضأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTCFG
        {
            public uint dwSize;
            public byte byScreenLayX;						//´َئء²¼¾ض-؛ل×ّ±ê
            public byte byScreenLayY;						//´َئء²¼¾ض-×ف×ّ±ê
            public ushort wOutputChanNum;					//تن³ِح¨µہ¸ِت‎£¬0±يت¾ةè±¸ض§³ضµؤ×î´َتن³ِح¨µہ¸ِت‎£¬×î´َ¸ِت‎´سؤـء¦¼¯»ٌب،£¬ئنثûضµ±يت¾تµ¼تتن³ِح¨µہ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_OUTPUTPARAM struOutputParam;	/*تن³ِح¨µہتسئµ²خت‎إنضأ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sWallName;					//µçتسا½أû³ئ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ؤـء¦¼¯*******************************/
        public const int SCREEN_PROTOCOL_NUM = 20;   //ض§³ضµؤ×î´َ´َئء؟طضئئ÷ذ­زéت‎

        //¶àئء·‏خٌئ÷ؤـء¦¼¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENSERVER_ABILITY
        {
            public uint dwSize;   			/*½ل¹¹³¤¶ب*/
            public byte byIsSupportScreenNum; /*ثùض§³ض´َئء؟طضئئ÷µؤت‎ؤ؟*/
            public byte bySerialNums;			//´®؟ع¸ِت‎
            public byte byMaxInputNums;
            public byte byMaxLayoutNums;
            public byte byMaxWinNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byMaxScreenLayX;//´َئء²¼¾ض-×î´َ؛ل×ّ±ê´َئءت‎
            public byte byMaxScreenLayY;//´َئء²¼¾ض-×î´َ×ف×ّ±ê´َئءت‎
            public ushort wMatrixProtoNum; /*سذذ§µؤ´َئءذ­زéت‎ؤ؟*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SCREEN_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struScreenProto;/*×î´َذ­زéءذ±ي*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //¶àئء؟طضئئ÷ؤـء¦¼¯
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENCONTROL_ABILITY
        {
            public uint dwSize;   		/*½ل¹¹³¤¶ب*/
            public byte byLayoutNum; 		/* ²¼¾ض¸ِت‎*/
            public byte byWinNum; 			/*ئءؤ»´°؟ع¸ِت‎*/
            public byte byOsdNum;  		/*OSD¸ِت‎*/
            public byte byLogoNum; 		/*Logo¸ِت‎*/
            public byte byInputStreamNum;  //تنبëش´¸ِت‎ ---ةè±¸ض§³ض×î´َتنبëح¨µہ¸ِت‎£¨°üہ¨±¾µطتنبëش´؛ححّآçتنبëش´£©
            public byte byOutputChanNum;	//تن³ِح¨µہ¸ِت‎---ةè±¸ض§³ض×î´َتن³ِح¨µہ¸ِت‎
            public byte byCamGroupNum;		/*·ض×é¸ِت‎*/
            public byte byPlanNum;    		/*ش¤°¸¸ِت‎*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byIsSupportPlayBack;  /*تا·ٌض§³ض»ط·إ*/
            public byte byMatrixInputNum;  //ض§³ضتنبë¾طصَ×î´َ¸ِت‎
            public byte byMatrixOutputNum; //ض§³ضتن³ِ¾طصَ×î´َ¸ِت‎
            public NET_DVR_DISPINFO struVgaInfo;//VGAتن³ِذإد¢
            public NET_DVR_DISPINFO struBncInfo;//BNCتن³ِذإد¢
            public NET_DVR_DISPINFO struHdmiInfo;//HDMIتن³ِذإد¢
            public NET_DVR_DISPINFO struDviInfo;//DVIتن³ِذإد¢
            public byte byMaxUserNums;//ض§³ضسأ»§ت‎
            public byte byPicSpan;		//µ×ح¼؟ç¶ب£¬ز»صإµ×ح¼×î¶à؟ة¸²¸اµؤئءؤ»ت‎
            public ushort wDVCSDevNum;	//·ض²¼ت½´َئء؟طضئئ÷×î´َةè±¸ت‎
            public ushort wNetSignalNum;	//×î´َحّآçتنبëش´¸ِت‎
            public ushort wBaseCoordinateX;//»ù×¼×ّ±ê
            public ushort wBaseCoordinateY;
            public byte byExternalMatrixNum;	//×î´َحâ½س¾طصَ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************تنبëذإ؛إ×´ج¬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGINPUTSTATUS
        {
            public uint dwLostFrame;		/*تسئµتنبë¶ھض،ت‎*/
            public byte byHaveSignal;		/*تا·ٌسذتسئµذإ؛إتنبë*/
            public byte byVideoFormat;		/*تسئµضئت½£¬1£؛NTSC,2£؛PAL,0£؛خق*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_INPUTSTATUS_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_CHAN_STATUS struIpInputStatus;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGINPUTSTATUS struAnalogInputStatus;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTATUS
        {
            public ushort wInputNo;		/*ذإ؛إش´ذٍ؛إ*/
            public byte byInputType;	//¼ûNET_DVR_CAM_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_INPUTSTATUS_UNION struStatusUnion;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINPUTSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwNums;		//ةè±¸·µ»طµؤتنبëش´×´ج¬µؤت‎ء؟
            public IntPtr pBuffer;	//»؛³هاّ
            public uint dwBufLen;	//ثù·ضإنض¸صë³¤¶ب£¬تنبë²خت‎
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENALARMCFG
        {
            public uint dwSize;
            public byte byAlarmType;	//±¨¾¯ہàذح£¬1-×س°ه°خ³ِ£¬2-×س°ه²هبë£¬3-×سدµح³×´ج¬زى³££¬4-×سدµح³»ض¸´»ض¸´ 5-تنبëش´زى³£   6-خآ¶ب±¨¾¯ 7-FPGA°و±¾²»ئ¥إن 8-ش¤°¸؟ھت¼ 9-ش¤°¸½لتّ 10-½âآë°ه¶دحّ 11-½âآë°هIPµطض·³هح»£¬12-·çةبزى³£
            public byte byBoardType;	// 1-تنبë°ه 2-تن³ِ°ه £¬3-ض÷°ه£¬4-±³°ه£¬±¨¾¯ہàذحخھ1£¬2£¬3£¬6µؤت±؛ٍت¹سأ 
            public byte bySubException;	//تنبëزى³£ت±¾كجه×سزى³£ 1- ·ض±وآتص‎³£¸ؤ±ن 2-تنبë¶ث؟عہàذح¸ؤ±ن3-·ض±وآت´يخَ4-·ض±وآت¸ؤ±نµ¼ضآ½âآë×تش´²»×م£¬¹ط±ص¸أتنبëش´¶شس¦´°؟ع،£5-·ض±وآت¸ؤ±ن£¬µ¼ضآزر؟ھ´°µؤثُ·إ±بہ‎²»شع1/8µ½8±¶·¶خ§،£6-·ض±وآت»ض¸´ص‎³£,7-·ض±وآت¸ؤ±نµ¼ضآتن³ِ°هت‎¾فء؟³¬دق,ةè±¸¹ط±ص´°؟ع 
            public byte byRes1;
            public ushort wStartInputNum; // زى³£تنبëش´£¨زى³£ئًµم£© 
            public ushort wEndInputNum;	// زى³£تنبëش´£¨زى³£ضصµم£© 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CFG
        {
            public byte byValid;				//إذ¶دتا·ٌتاؤ£ؤâ¾طصَ£¨تا·ٌسذذ§£©
            public byte byCommandProtocol;	//ؤ£ؤâ¾طصَµؤض¸ءî£¨4ضض£©
            public byte byScreenType;			//±£ءô	
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byScreenToMatrix;	//ؤ£ؤâ¾طصَµؤتن³ِسëئءؤ»µؤ¶شس¦¹طدµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIGITALSCREEN
        {
            public NET_DVR_IPADDR  struAddress;/*ةè±¸خھت‎×ضةè±¸ت±µؤIPذإد¢*/
            public ushort wPort;		//ح¨µہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGSCREEN
        {
            public byte byDevSerPortNum;   /*ء¬½سةè±¸µؤ´®؟ع؛إ*/
            public byte byScreenSerPort;  /*ء¬½س´َئءµؤ´®؟ع؛إ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MATRIX_CFG struMatrixCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_DIGITALSCREEN struDigitalScreen;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGSCREEN struAnalogScreen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_SCREENINFO
        {
            public uint dwSize;
            public byte byValid;				//تا·ٌسذذ§
            public byte nLinkMode;				//ء¬½س·½ت½£¬0-´®؟ع£¬1-حّ؟ع
            public byte byDeviceType;			//ةè±¸ذح؛إ£¬ؤـء¦¼¯»ٌب،
            public byte byScreenLayX;			//´َئء²¼¾ض-؛ل×ّ±ê
            public byte byScreenLayY;			//´َئء²¼¾ض-×ف×ّ±ê
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*µاآ¼سأ»§أû*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /*µاآ¼أـآë*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;	/*ةè±¸أû³ئ*/
            public NET_DVR_SCREEN_UNION struScreenUnion;
            public byte byInputNum;			// تنبëش´¸ِت‎
            public byte byOutputNum;			// تن³ِش´¸ِت‎
            public byte byCBDNum;				//CBD¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************µ×ح¼ةد´«*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASEMAP_CFG
        {
            public byte byScreenIndex;         //ئءؤ»µؤذٍ؛إ
            public byte byMapNum;				/*±»·ض¸î³ةءث¶àةظ؟é*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
            public ushort wSourWidth;			/* ش­ح¼ئ¬µؤ؟ي¶ب */
            public ushort wSourHeight;			/* ش­ح¼ئ¬µؤ¸ك¶ب */
        }

        /*******************************OSD*******************************/
        public const int MAX_OSDCHAR_NUM = 256;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSDCFG
        {
            public uint dwSize;
            public byte byValid;    /*تا·ٌسذذ§ 0خقذ§ 1سذذ§*/
            public byte byDispMode;  //دشت¾ؤ£ت½£¬1-ح¸أ÷£¬2-°ëح¸أ÷£¬3-¸²¸اب‎ضضؤ£ت½
            public byte byFontColorY; /*×ضجهرصة«Y,0-255*/
            public byte byFontColorU; /*×ضجهرصة«U,0-255*/
            public byte byFontColorV; /*×ضجهرصة«V,0-255*/
            public byte byBackColorY; /*±³¾°رصة«Y,0-255*/
            public byte byBackColorU; /*±³¾°رصة«U,0-255*/
            public byte byBackColorV; /*±³¾°رصة«V,0-255*/
            public ushort wXCoordinate;   /*OSDشعئءؤ»×َةد½اخ»ضأx*/
            public ushort wYCoordinate;   /*OSDشعئءؤ»×َةد½اخ»ضأy*/
            public ushort wWidth;       /*OSD؟ي¶ب*/
            public ushort wHeight;      /*OSD¸ك¶ب*/
            public uint dwCharCnt;     /*×ض·ûµؤ¸ِت‎*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OSDCHAR_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOSDChar;       /*OSD×ض·ûؤعبف*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************»ٌب،´®؟عذإد¢*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CONTROL
        {
            public uint dwSize ;
            public byte bySerialNum;        // ´®؟ع¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] bySerial;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ئءؤ»؟طضئ*******************************/
        //ئءؤ»تنبëش´؟طضئ
        public enum INPUT_INTERFACE_TYPE
        {
            INTERFACE_VGA = 0,
            INTERFACE_SVIDEO, // 2046NL²»ض§³ض£¬2046NHض§³ض
            INTERFACE_YPBPR,
            INTERFACE_DVI,
            INTERFACE_BNC,
            INTERFACE_DVI_LOOP,//(»·ح¨) 2046NH²»ض§³ض£¬2046NLض§³ض
            INTERFACE_BNC_LOOP, //(»·ح¨) 2046NH²»ض§³ض£¬2046NL.ض§³ض
            INTERFACE_HDMI,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_INTERFACE_CTRL
        {
            public byte byInputSourceType;	//¼ûINPUT_INTERFACE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //دشت¾µ¥شھرصة«؟طضئ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_COLOR_CTRL
        {
            public byte byColorType;		//1-ءء¶ب 2-¶ش±ب¶ب 3-±¥؛ح¶ب 4-اهخْ¶ب
            public char byScale;			//-1 ،¢0،¢+1ب‎¸ِضµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //دشت¾µ¥شھخ»ضأ؟طضئ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_POSITION_CTRL
        {
            public byte byPositionType;	//1-ث®ئ½خ»ضأ 2-´¹ض±خ»ضأ£¬
            public char byScale;			//-1 ،¢0،¢+1ب‎¸ِضµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_CONTROL_PARAM
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_INPUT_INTERFACE_CTRL struInputCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_COLOR_CTRL struDisplayCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_POSITION_CTRL struPositionCtrl;
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL
        {
            public uint dwSize;
            public uint dwCommand ;      /* ؟طضئ·½·¨ 1-؟ھ 2-¹ط 3-ئءؤ»تنبëش´ر،شٌ 4-دشت¾µ¥شھرصة«؟طضئ 5-دشت¾µ¥شھخ»ضأ؟طضئ*/
            public byte byProtocol;      //´®؟عذ­زéہàذح,1:LCD-S1,2:LCD-S2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SCREEN_CONTROL_PARAM struControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ئءؤ»؟طضئV41*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL_V41
        {
            public uint dwSize;
            public byte bySerialNo;		//´®؟ع؛إ
            public byte byBeginAddress;	//×َةد½ائءؤ»؛إ£¬´س1؟ھت¼
            public byte byEndAddress;	//سزدآ½ائءؤ»؛إ£¬´س1؟ھت¼
            public byte byProtocol;      	   // ´®؟عذ­زéہàذح  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 £¬ 4-LCD-DLP£¬ 5-LCD-S3 , 6-LCD-H1 
            public uint dwCommand ;      /* ؟طضئ·½·¨ 1-؟ھ 2-¹ط 3-ئءؤ»تنبëش´ر،شٌ 4-دشت¾µ¥شھرصة«؟طضئ 5-دشت¾µ¥شھخ»ضأ؟طضئ*/
            public NET_DVR_SCREEN_CONTROL_PARAM struControlParam;
            public byte byWallNo;		// µçتسا½؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************ش¤°¸¹ـہي*******************************/
        public const int MAX_PLAN_ACTION_NUM = 32; 	//ش¤°¸¶¯×÷¸ِت‎
        public const int DAYS_A_WEEK = 7;	//ز»ضـ7جى
        public const int MAX_PLAN_COUNT = 16;	//ش¤°¸¸ِت‎

        public enum NET_DVR_PLAN_OPERATE_TYPE
        {
            NET_DVR_SWITCH_LAYOUT = 1,      // ²¼¾ضاذ»» ؤ¬بد
            NET_DVR_SCREEN_POWER_OFF,       // ¹ط±ص´َئءؤ»دشت¾
            NET_DVR_SCREEN_POWER_ON,   		// ´ٍ؟ھ´َئءؤ»دشت¾
        }

        /*ش¤°¸دîذإد¢*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_INFO
        {
            public byte byValid;      	// ¸أدîتا·ٌسذذ§
            public byte byType;       	// ¼û¶¨زهNET_DVR_PLAN_OPERATE_TYPE
            public ushort wLayoutNo;  	// ²¼¾ض؛إ
            public byte byScreenStyle;    //ئءؤ»ذح؛إ£¬؟ھ¹ط»ْثùسأ£¬1تاµحءء£¬2تا¸كءء
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDelayTime;  	// ز»¸ِدîµؤشثذذت±¼ن, µ¥خ»أë
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYCLE_TIME
        {
            public byte byValid;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_TIME_EX struTime;
        }

        /*ش¤°¸¹ـہي*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_CFG
        {
            public uint dwSize;
            public byte byValid;      	// ¸أش¤°¸تا·ٌسذذ§
            public byte byWorkMode;  	// ش¤°¸¹¤×÷ؤ£ت½ 1±يت¾تض¶¯£¬2×ش¶¯£¬3ش¤°¸ر­»·
            public byte byWallNo;		//µçتسا½؛إ£¬´س1؟ھت¼
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlanName; //ش¤°¸أû³ئ
            public NET_DVR_TIME_EX struTime; // ¹¤×÷ؤ£ت½خھ×ش¶¯ت±ت¹سأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DAYS_A_WEEK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYCLE_TIME[] struTimeCycle; /*ر­»·ت±¼ن£¬ضـئعخھز»¸ِذائع£¬ؤê،¢شآ،¢بصب‎¸ِ²خت‎²»ت¹سأ،£بç£؛struTimeCycle[0]ضذµؤbyValidµؤضµتا1£¬±يت¾ذائعجىض´ذذ¸أش¤°¸،£ذائعب،ضµاّ¼نخھ[0,6]£¬ئنضذ0´ْ±يذائعجى£¬1´ْ±يذائعز»£¬زش´ثہàحئ*/
            public uint dwWorkCount;  	// ش¤°¸ؤعبفض´ذذ´خت‎£¬0خھز»ض±ر­»·²¥·إ£¬ئنثûضµ±يت¾´خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLAN_ACTION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PLAN_INFO[] strPlanEntry;  // ش¤°¸ض´ذذµؤؤعبف
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************»ٌب،ةè±¸×´ج¬*******************************/
        /*ش¤°¸ءذ±ي*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_LIST
        {
            public uint dwSize;
            public uint dwPlanNums;			//ةè±¸تنبëذإ؛إش´ت‎ء؟
            public IntPtr pBuffer;			//ض¸دٍdwInputSignalNums¸ِNET_DVR_PLAN_CFG½ل¹¹´َذ،µؤ»؛³هاّ
            public byte byWallNo;			//ا½؛إ£¬´س1؟ھت¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//ثù·ضإن»؛³هاّ³¤¶ب£¬تنبë²خت‎£¨´َسعµبسعdwInputSignalNums¸ِNET_DVR_PLAN_CFG½ل¹¹´َذ،£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ش¤°¸؟طضئ*******************************/
        //¸أ½ل¹¹جه؟ة×÷خھح¨سأ؟طضئ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_PARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceID; //±»؟طةè±¸µؤةè±¸ID
            public ushort wChan;				 //±»؟طح¨µہ
            public byte byIndex;			 //؟طضئث÷ز‎£¬¸ù¾فأüءîب·¶¨¾كجه±يت¾ت²أ´ث÷ز‎
            public byte byRes1;
            public uint dwControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************»ٌب،ةè±¸×´ج¬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICE_RUN_STATUS
        {
            public uint dwSize;
            public uint dwMemoryTotal;		//ؤع´و×ـء؟	µ¥خ»Kbyte
            public uint dwMemoryUsage;		//ؤع´وت¹سأء؟ µ¥خ»Kbyte
            public byte byCPUUsage;			//CPUت¹سأآت 0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //91دµءذHD-SDI¸كاهDVR دà»ْذإد¢
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACCESS_CAMERA_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCameraInfo;		// ا°¶ثدà»ْذإد¢
            public byte  byInterfaceType;		// ا°¶ث½سبë½س؟عہàذح£¬1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_INPUT_PARAM
        {
            public byte byAudioInputType;  //زôئµتنبëہàذح£¬0-mic in£¬1-line in
            public byte byVolume; //volume,[0-100]
            public byte byEnableNoiseFilter; //تا·ٌ؟ھئôةùزô¹‎آث-¹ط£¬-؟ھ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_DEHAZE_CFG
        {
            public uint dwSize;
            public byte byDehazeMode; //0-²»ئôسأ£¬1-×ش¶¯ؤ£ت½£¬2-؟ھ
            public byte byLevel; //µب¼¶£¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_SIGNAL_LIST
        {
            public uint dwSize;
            public uint dwInputSignalNums;	//ةè±¸تنبëذإ؛إش´ت‎ء؟
            public IntPtr pBuffer;			//ض¸دٍdwInputSignalNums¸ِNET_DVR_INPUTSTREAMCFG½ل¹¹´َذ،µؤ»؛³هاّ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//ثù·ضإن»؛³هاّ³¤¶ب£¬تنبë²خت‎£¨´َسعµبسعdwInputSignalNums¸ِNET_DVR_INPUTSTREAMCFG½ل¹¹´َذ،£©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //°²ب«°خإج×´ج¬
        public const int PULL_DISK_SUCCESS = 1;     // °²ب«°خإج³ة¹¦
        public const int PULL_DISK_FAIL = 2;        // °²ب«°خإجت§°ـ
        public const int PULL_DISK_PROCESSING = 3;  // ص‎شعح£ض¹صَءذ
        public const int PULL_DISK_NO_ARRAY = 4;	// صَءذ²»´وشع 
        public const int PULL_DISK_NOT_SUPPORT = 5; // ²»ض§³ض°²ب«°خإج

        //ة¨أèصَءذ×´ج¬
        public const int SCAN_RAID_SUC = 1; 	// ة¨أèصَءذ³ة¹¦
        public const int SCAN_RAID_FAIL = 2; 	// ة¨أèصَءذت§°ـ
        public const int SCAN_RAID_PROCESSING = 3;	// ص‎شعة¨أèصَءذ
        public const int SCAN_RAID_NOT_SUPPORT = 4; // ²»ض§³ضصَءذة¨أè

        //ةèضأا°¶ثدà»ْہàذح×´ج¬
        public const int SET_CAMERA_TYPE_SUCCESS = 1;  // ³ة¹¦
        public const int SET_CAMERA_TYPE_FAIL = 2;  // ت§°ـ
        public const int SET_CAMERA_TYPE_PROCESSING = 3;   // ص‎شع´¦ہي

        //9000 2.2
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN_INQUIRY
        {
            public uint dwSize;    //½ل¹¹جه´َذ،
            public byte byType;    //0 ص‎³£زôتسئµآ¼دٌ, 1ح¼ئ¬ح¨µہآ¼دٌ, 2ANRح¨µہآ¼دٌ, 3³éض،ح¨µہآ¼دٌ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN
        {
            public uint dwSize;        //½ل¹¹جه´َذ،
            public NET_DVR_TIME strBeginTime;  //؟ھت¼ت±¼ن
            public NET_DVR_TIME strEndTime;    //½لتّت±¼ن
            public byte byType;        //0 ص‎³£زôتسئµآ¼دٌ, 1ح¼ئ¬ح¨µہآ¼دٌ, 2ANRح¨µہآ¼دٌ, 3³éض،ح¨µہآ¼دٌ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DRAWFRAME_DISK_QUOTA_CFG
        {
            public uint dwSize;					//½ل¹¹جه´َذ،
            public byte byPicQuota;				//ح¼ئ¬°ظ·ض±ب	 [0%,  30%]
            public byte byRecordQuota;				//ئصح¨آ¼دٌ°ظ·ض±ب [20%, 40%]
            public byte byDrawFrameRecordQuota;	//³éض،آ¼دٌ°ظ·ض±ب [30%, 80%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					//±£ءô×ض½ع
        }

        //¶ث؟عس³ةنإنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_PORT
        {
            public ushort wEnable;
            public ushort wExtPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶ث؟عس³ةنإنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_CFG
        {
            public uint dwSize;
            public ushort wEnableUpnp;
            public ushort wEnableNat;
            public NET_DVR_IPADDR struIpAddr;//دؤت±ضئح£ض¹ت±¼ن
            public NET_DVR_NAT_PORT struHttpPort;//دؤت±ضئح£ض¹ت±¼ن
            public NET_DVR_NAT_PORT struCmdPort;//دؤت±ضئح£ض¹ت±¼ن
            public NET_DVR_NAT_PORT struRtspPort;//دؤت±ضئح£ض¹ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendName;
            public byte byNatType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_NAT_PORT struHttpsPort;//دؤت±ضئح£ض¹ت±¼ن
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Upnp¶ث؟عس³ةن×´ج¬½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_PORT_STATE
        {
            public uint dwEnabled;//¸أ¶ث؟عتا·ٌ±»ت¹ؤـس³ةن
            public ushort wInternalPort;//س³ةنا°µؤ¶ث؟ع
            public ushort wExternalPort;//س³ةن؛َµؤ¶ث؟ع
            public uint dwStatus;//¶ث؟عس³ةن×´ج¬£؛0- خ´ةْذ§£»1- خ´ةْذ§£؛س³ةنش´¶ث؟عسëؤ؟µؤ¶ث؟عذèز»ضآ£»2- خ´ةْذ§£؛س³ةن¶ث؟ع؛إزر±»ت¹سأ£»3- ةْذ§
            public NET_DVR_IPADDR struNatExternalIp;//س³ةن؛َµؤحâ²؟µطض·
            public NET_DVR_IPADDR struNatInternalIp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        //Upnp¶ث؟عس³ةن×´ج¬½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_NAT_STATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_UPNP_PORT_STATE[] strUpnpPort;//¶ث؟عس³ةن×´ج¬:£؛ت‎×é0- web server¶ث؟ع£¬ت‎×é1- ¹ـہي¶ث؟ع£¬ت‎×é2- rtsp¶ث
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAYCOND
        {
            public uint dwChannel;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame;  //0:²»³éض،£¬1£؛³éض،
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£ءô
        }

        //آ¼دٌ»ط·إ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOD_PARA
        {
            public uint dwSize; //½ل¹¹جه´َذ،
            public NET_DVR_STREAM_INFO struIDInfo; //ء÷IDذإد¢
            public NET_DVR_TIME struBeginTime;//»ط·إ؟ھت¼ت±¼ن
            public NET_DVR_TIME struEndTime;//»ط·إ½لتّت±¼ن
            public IntPtr hWnd;//»ط·إ´°؟ع
            public byte byDrawFrame;//تا·ٌ³éض،£؛0- ²»³éض،£¬1- ³éض،
            public byte byVolumeType;//0-ئصح¨آ¼دٌ¾ي£¬1-´وµµ¾ي£¬تتسأسعCVRةè±¸£¬ئصح¨¾يسأسعح¨µہآ¼دٌ£¬´وµµ¾يسأسع±¸·فآ¼دٌ
            public byte byVolumeNum;//´وµµ¾ي؛إ 
            public byte byRes1;//±£ءô
            public uint dwFileIndex;//´وµµ¾يةدµؤآ¼دٌخؤ¼‏ث÷ز‎£¬ثرث÷´وµµ¾يآ¼دٌت±·µ»طµؤضµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATMFINDINFO
        {
            public byte byTransactionType;       //½»ز×ہàذح 0-ب«²؟£¬1-²éر¯£¬ 2-ب،؟î£¬ 3-´و؟î£¬ 4-ذق¸ؤأـآë£¬5-×ھصث£¬ 6-خق؟¨²éر¯ 7-خق؟¨´و؟î£¬ 8-حج³® 9-حج؟¨ 10-×ش¶¨زه
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±£ءô
            public uint dwTransationAmount ;     //½»ز×½ً¶î ;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SPECIAL_FINDINFO_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byLenth ;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ATMFINDINFO struATMFindInfo;	       //ATM²éر¯
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND_V40
        {
            public Int32 lChannel;
            public uint dwFileType;
            public uint dwIsLocked;
            public uint dwUseCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_OUT, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame; //0:²»³éض،£¬1£؛³éض،
            public byte byFindType; //0:²éر¯ئصح¨¾ي£¬1£؛²éر¯´وµµ¾ي
            public byte byQuickSearch; //0:ئصح¨²éر¯£¬1£؛؟ىثظ£¨بصہْ£©²éر¯
            public byte bySpecialFindInfoType ;    //×¨سذ²éر¯جُ¼‏ہàذح 0-خقذ§£¬ 1-´ّATM²éر¯جُ¼‏  
            public uint dwVolumeNum;  //´وµµ¾ي؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = GUID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWorkingDeviceGUID;    //¹¤×÷»ْGUID£¬ح¨¹‎»ٌب،N+1µأµ½
            public NET_DVR_SPECIAL_FINDINFO_UNION uSpecialFindInfo ;   //×¨سذ²éر¯جُ¼‏
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±£ءô
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AES_KEY_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sAESKey;  /*آëء÷¼سأـأـش؟*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  /*±£ءô×ض½ع*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POE_CFG
        {
            public NET_DVR_IPADDR struIP;     //IPµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±£ءô
        }

        public const int MAX_PRO_PATH = 256; //×î´َذ­زéآ·¾¶³¤¶ب

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CUSTOM_PROTOCAL
        {
            public uint dwSize;              //½ل¹¹جه´َذ،
            public uint dwEnabled;           //تا·ٌئôسأ¸أذ­زé0 ²»ئôسأ 1 ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = DESC_LEN)]
            public string sProtocalName;   //×ش¶¨زهذ­زéأû³ئ, 16خ»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;          //±£ءô,سأسعذ­زéأû³ئہ©ص¹
            public uint dwEnableSubStream;   //×سآëء÷تا·ٌئôسأ0 ²»ئôسأ 1 ئôسأ	
            public byte byMainProType;        //ض÷آëء÷ذ­زéہàذح 1 RTSP
            public byte byMainTransType;		//ض÷آëء÷´«تنہàذح 0£؛Auto 1£؛udp 2£؛rtp over rtsp
            public ushort wMainPort;           //ض÷آëء÷¶ث؟ع	
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sMainPath;  //ض÷آëء÷آ·¾¶	
            public byte bySubProType;         //×سآëء÷ذ­زéہàذح 1 RTSP
            public byte bySubTransType;		//×سآëء÷´«تنہàذح 0£؛Auto 1£؛udp 2£؛rtp over rtsp
            public ushort wSubPort;   //×سآëء÷¶ث؟ع
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sSubPath;   //×سآëء÷آ·¾¶ 	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;          //±£ءô
        }

        //ش¤ہہV40½س؟ع
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWINFO
        {
            public Int32 lChannel;//ح¨µہ؛إ
            public uint dwStreamType;	// آëء÷ہàذح£¬0-ض÷آëء÷£¬1-×سآëء÷£¬2-آëء÷3£¬3-آëء÷4 µبزش´ثہàحئ
            public uint dwLinkMode;// 0£؛TCP·½ت½,1£؛UDP·½ت½,2£؛¶à²¥·½ت½,3 - RTP·½ت½£¬4-RTP/RTSP,5-RSTP/HTTP 
            public IntPtr hPlayWnd;//²¥·إ´°؟عµؤ¾ن±ْ,خھNULL±يت¾²»²¥·إح¼دَ
            public bool bBlocked;  //0-·ا×èبûب،ء÷, 1-×èبûب،ء÷, بç¹û×èبûSDKؤع²؟connectت§°ـ½«»لسذ5sµؤ³¬ت±²إؤـ¹»·µ»ط,²»تت؛دسعآضر¯ب،ء÷²ظ×÷.
            public bool bPassbackRecord; //0-²»ئôسأآ¼دٌ»ط´«,1ئôسأآ¼دٌ»ط´«
            public byte byPreviewMode;//ش¤ہہؤ£ت½£¬0-ص‎³£ش¤ہہ£¬1-رس³ظش¤ہہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStreamID;//ء÷ID£¬lChannelخھ0xffffffffت±ئôسأ´ث²خت‎
            public byte byProtoType; //س¦سأ²مب،ء÷ذ­زé£¬0-ث½سذذ­زé£¬1-RTSPذ­زé
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 222, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        ///×¥إؤ»ْ
        ///
        public const int MAX_OVERLAP_ITEM_NUM = 50;       //×î´َ×ض·ûµ‏¼سضضت‎
        public const int NET_ITS_GET_OVERLAP_CFG = 5072;//»ٌب،×ض·ûµ‏¼س²خت‎إنضأ£¨دà»ْ»ٍITSضص¶ث£©
        public const int NET_ITS_SET_OVERLAP_CFG = 5073;//ةèضأ×ض·ûµ‏¼س²خت‎إنضأ£¨دà»ْ»ٍITSضص¶ث£©

        //×ض·ûµ‏¼سإنضأجُ¼‏²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAPCFG_COND
        {
            public uint dwSize;
            public uint dwChannel;//ح¨µہ؛إ 
            public uint dwConfigMode;//إنضأؤ£ت½£؛0- ضص¶ث£¬1- ا°¶ث(ض±ء¬ا°¶ث»ٍضص¶ث½سا°¶ث)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        //µ¥جُ×ض·ûµ‏¼سذإد¢½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_SINGLE_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô
            public byte byItemType;//ہàذح
            public byte byChangeLineNum;//µ‏¼سدî؛َµؤ»»ذذت‎£¬ب،ضµ·¶خ§£؛[0,10]£¬ؤ¬بد£؛0 
            public byte bySpaceNum;//µ‏¼سدî؛َµؤ؟ص¸ٌت‎£¬ب،ضµ·¶خ§£؛[0-255]£¬ؤ¬بد£؛0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        //×ض·û´®²خت‎إنضأ½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OVERLAP_ITEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_OVERLAP_SINGLE_ITEM_PARAM[] struSingleItem;//×ض·û´®ؤعبفذإد¢
            public uint dwLinePercent;
            public uint dwItemsStlye;
            public ushort wStartPosTop;
            public ushort wStartPosLeft;
            public ushort wCharStyle;
            public ushort wCharSize;
            public ushort wCharInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±£ءô
            public uint dwForeClorRGB;//ا°¾°ة«µؤRGBضµ£¬bit0~bit7: B£¬bit8~bit15: G£¬bit16~bit23: R£¬ؤ¬بد£؛x00FFFFFF-°×
            public uint dwBackClorRGB;//±³¾°ة«µؤRGBضµ£¬ض»¶شح¼ئ¬حâµ‏¼سسذذ§£¬bit0~bit7: B£¬bit8~bit15: G£¬bit16~bit23: R£¬ؤ¬بد£؛x00000000-؛ع 
            public byte byColorAdapt;//رصة«تا·ٌ×شتتس¦£؛0-·ٌ£¬1-تا
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô
        }

        //×ض·ûµ‏¼سؤعبفذإد¢½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_INFO_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] bySite;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRoadNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byInstrumentNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirection;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectionDesc;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneDes;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite1;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite2;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎ 
        }

        //×ض·ûµ‏¼سإنضأجُ¼‏²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_CFG
        {
            public uint dwSize;
            public byte byEnable;//تا·ٌئôسأ£؛0- ²»ئôسأ£¬1- ئôسأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎
            public NET_ITS_OVERLAP_ITEM_PARAM struOverLapItem;//×ض·û´®²خت‎
            public NET_ITS_OVERLAP_INFO_PARAM struOverLapInfo;//×ض·û´®ؤعبفذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎ 
        }

        //±¨¾¯²¼·ہ²خت‎½ل¹¹جه
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SETUPALARM_PARAM
        {
            public uint dwSize;
            public byte byLevel;//²¼·ہسإدب¼¶£؛0- ز»µب¼¶£¨¸ك£©£¬1- ¶‏µب¼¶£¨ضذ£©£¬2- ب‎µب¼¶£¨µح£¬±£ءô£©
            public byte byAlarmInfoType;//ةد´«±¨¾¯ذإد¢ہàذح£¨ضاؤـ½»ح¨ةمدٌ»ْض§³ض£©£؛0- ہد±¨¾¯ذإد¢£¨NET_DVR_PLATE_RESULT£©£¬1- ذآ±¨¾¯ذإد¢(NET_ITS_PLATE_RESULT) 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//صâہï±£ءôزôئµµؤر¹ثُ²خت‎ 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_GATE_VEHICLE
        {
            public uint dwSize;
            public uint dwMatchNo;
            public byte byGroupNum;
            public byte byPicNo;
            public byte bySecondCam;

            public byte byRes;
            public ushort wLaneid;
            public byte byCamLaneId;
            public byte byRes1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byAlarmReason;

            public ushort wBackList;
            public ushort wSpeedLimit;
            public uint dwChanIndex;


            public NET_DVR_PLATE_INFO struPlateInfo;

            public NET_DVR_VEHICLE_INFO struVehicleInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byMonitoringSiteID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byDeviceID;


            public byte byDir;
            public byte byDetectType;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byRes2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] byCardNo;

            public uint dwPicNum;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_PICTURE_INFO[] struPicInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bySwipeTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_PICTURE_INFO
        {
            public uint dwDataLen;
            public byte byType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes1;
            public uint dwRedLightTime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byAbsTime;
            public NET_VCA_RECT struPlateRect;
            public NET_VCA_RECT struPlateRecgRect;
            public IntPtr pBuffer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] byRes2;
        }
        /********************************½س؟ع²خت‎½ل¹¹(end)*********************************/


        /********************************SDK½س؟ع؛¯ت‎ةùأ÷*********************************/

        /*********************************************************
        Function:	NET_DVR_Init
        Desc:		³ُت¼»¯SDK£¬µ÷سأئنثûSDK؛¯ت‎µؤا°جل،£
        Input:	
        Output:	
        Return:	TRUE±يت¾³ة¹¦£¬FALSE±يت¾ت§°ـ،£
        **********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();

        /*********************************************************
        Function:	NET_DVR_Cleanup
        Desc:		تح·إSDK×تش´£¬شع½لتّض®ا°×î؛َµ÷سأ
        Input:	
        Output:	
        Return:	TRUE±يت¾³ة¹¦£¬FALSE±يت¾ت§°ـ
        **********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();



        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessage( uint nMessage, IntPtr hWnd );

        /*********************************************************
        Function:	EXCEPYIONCALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void EXCEPYIONCALLBACK( uint dwType, int lUserID, int lHandle, IntPtr pUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetExceptionCallBack_V30( uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser );


        /*********************************************************
        Function:	MESSCALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACK( int lCommand, string sDVRIP, string pBuf, uint dwBufLen );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack( MESSCALLBACK fMessCallBack );

        /*********************************************************
        Function:	MESSCALLBACKEX
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKEX( int iCommand, int iUserID, string pBuf, uint dwBufLen );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_EX( MESSCALLBACKEX fMessCallBack_EX );

        /*********************************************************
        Function:	MESSCALLBACKNEW
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKNEW( int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_NEW( MESSCALLBACKNEW fMessCallBack_NEW );

        /*********************************************************
        Function:	MESSAGECALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSAGECALLBACK( int lCommand, System.IntPtr sDVRIP, System.IntPtr pBuf, uint dwBufLen, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack( MESSAGECALLBACK fMessageCallBack, uint dwUser );


        /*********************************************************
        Function:	MSGCallBack
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void MSGCallBack( int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V30( MSGCallBack fMessageCallBack, IntPtr pUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConnectTime( uint dwWaitTime, uint dwTryTimes );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetReconnect( uint dwInterval, int bEnableRecon );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetLocalIP( byte [ ] strIP, ref uint pValidNum, ref Boolean pEnableBind );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetValidIP( uint dwIPIndex, Boolean bEnableBind );

        [DllImport(@"HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKVersion();

        [DllImport(@"HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKBuildVersion();

        [DllImport(@"HCNetSDK.dll")]
        public static extern Int32 NET_DVR_IsSupport();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StartListen( string sLocalIP, ushort wLocalPort );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen();

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_StartListen_V30( String sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen_V30( Int32 lListenHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login( string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout( int iUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();

        [DllImport(@"HCNetSDK.dll")]
        public static extern string NET_DVR_GetErrorMsg( ref int pErrorNo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetShowMode( uint dwShowType, uint colorKey );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr( string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX( string sServerIP, ushort wServerPort, byte [ ] sDVRName, ushort wDVRNameLen, byte [ ] sDVRSerialNumber, ushort wDVRSerialLen, byte [ ] sGetIP, ref uint dwPort );
        //ش¤ہہدà¹ط½س؟ع
        [DllImport(@"HCNetSDK.dll")]
        public static extern Int32 NET_DVR_RealPlay( int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern Int32 NET_SDK_RealPlay( int iUserLogID, ref NET_DVR_CLIENTINFO lpDVRClientInfo );
        /*********************************************************
		Function:	REALDATACALLBACK
		Desc:		ش¤ہہ»طµ÷
		Input:	lRealHandle µ±ا°µؤش¤ہہ¾ن±ْ 
				dwDataType ت‎¾فہàذح
				pBuffer ´و·إت‎¾فµؤ»؛³هاّض¸صë 
				dwBufSize »؛³هاّ´َذ، 
				pUser سأ»§ت‎¾ف 
		Output:	
		Return:	void
		**********************************************************/
        public delegate void REALDATACALLBACK( Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser );
        [DllImport(@"HCNetSDK.dll")]

        /*********************************************************
        Function:	NET_DVR_RealPlay_V30
        Desc:		تµت±ش¤ہہ،£
        Input:	lUserID [in] NET_DVR_Login()»ٍNET_DVR_Login_V30()µؤ·µ»طضµ 
                lpClientInfo [in] ش¤ہہ²خت‎ 
                cbRealDataCallBack [in] آëء÷ت‎¾ف»طµ÷؛¯ت‎ 
                pUser [in] سأ»§ت‎¾ف 
                bBlocked [in] اëاَآëء÷¹‎³جتا·ٌ×èبû£؛0£­·ٌ£»1£­تا 
        Output:	
        Return:	1±يت¾ت§°ـ£¬ئنثûضµ×÷خھNET_DVR_StopRealPlayµب؛¯ت‎µؤ¾ن±ْ²خت‎
        **********************************************************/
        public static extern int NET_DVR_RealPlay_V30( int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, UInt32 bBlocked );

        /*********************************************************
        Function:	NET_DVR_RealPlay_V40
        Desc:		تµت±ش¤ہہہ©ص¹½س؟ع،£
        Input:	lUserID [in] NET_DVR_Login()»ٍNET_DVR_Login_V30()µؤ·µ»طضµ 
                lpPreviewInfo [in] ش¤ہہ²خت‎ 
                fRealDataCallBack_V30 [in] آëء÷ت‎¾ف»طµ÷؛¯ت‎ 
                pUser [in] سأ»§ت‎¾ف 
        Output:	
        Return:	1±يت¾ت§°ـ£¬ئنثûضµ×÷خھNET_DVR_StopRealPlayµب؛¯ت‎µؤ¾ن±ْ²خت‎
        **********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_V40( int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser );

        // [DllImport(@"HCNetSDK.dll")]
        // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        /*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		ح£ض¹ش¤ہہ،£
		Input:	lRealHandle [in] ش¤ہہ¾ن±ْ£¬NET_DVR_RealPlay»ٍصكNET_DVR_RealPlay_V30µؤ·µ»طضµ 
		Output:	
		Return:	
		**********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopRealPlay( int iRealHandle );

        /*********************************************************
        Function:	DRAWFUN
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void DRAWFUN( int lRealHandle, IntPtr hDc, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterDrawFun( int lRealHandle, DRAWFUN fDrawFun, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayerBufNumber( Int32 lRealHandle, uint dwBufNum );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ThrowBFrame( Int32 lRealHandle, uint dwNum );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAudioMode( uint dwMode );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound( Int32 lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSoundShare( Int32 lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSoundShare( Int32 lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_Volume( Int32 lRealHandle, ushort wVolume );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData( Int32 lRealHandle, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopSaveRealData( Int32 lRealHandle );

        /*********************************************************
        Function:	REALDATACALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SETREALDATACALLBACK( int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRealDataCallBack( int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser );

        /*********************************************************
        Function:	STDDATACALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void STDDATACALLBACK( int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetStandardDataCallBack( int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser );


        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture( Int32 lRealHandle, string sPicFileName );

        //¶¯ج¬ةْ³ةIض،
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrame( Int32 lUserID, Int32 lChannel );//ض÷آëء÷

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrameSub( Int32 lUserID, Int32 lChannel );//×سآëء÷

        //شئج¨؟طضئدà¹ط½س؟ع
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl( Int32 lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl_Other( Int32 lUserID, int lChannel );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl( Int32 lRealHandle, uint dwPTZCommand, uint dwStop );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_Other( Int32 lUserID, Int32 lChannel, uint dwPTZCommand, uint dwStop );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ( Int32 lRealHandle, string pPTZCodeBuf, uint dwBufSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_Other( int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset( int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_Other( int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_EX( int lRealHandle, string pPTZCodeBuf, uint dwBufSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_EX( int lRealHandle, uint dwPTZCommand, uint dwStop );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_EX( int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise( int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_Other( int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_EX( int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack( int lRealHandle, uint dwPTZTrackCmd );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_Other( int lUserID, int lChannel, uint dwPTZTrackCmd );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_EX( int lRealHandle, uint dwPTZTrackCmd );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed( int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other( int lUserID, int lChannel, int dwPTZCommand, int dwStop, int dwSpeed );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_EX( int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCruise( int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack( int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_Other( int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_EX( int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex );

        //خؤ¼‏²éصزسë»ط·إ
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile( int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile( int lFindHandle, ref NET_DVR_FIND_DATA lpFindData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose( int lFindHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V30( int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V40( int lFindHandle, ref NET_DVR_FINDDATA_V40 lpFindData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V30( int lUserID, ref NET_DVR_FILECOND pFindCond );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V40( int lUserID, ref NET_DVR_FILECOND_V40 pFindCond );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose_V30( int lFindHandle );

        //2007-04-16شِ¼س²éر¯½ل¹û´ّ؟¨؛إµؤخؤ¼‏²éصز
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_Card( int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_Card( int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_LockFileByName( int lUserID, string sLockFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_UnlockFileByName( int lUserID, string sUnlockFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName( int lUserID, string sPlayBackFileName, IntPtr hWnd );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime( int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime_V40( int lUserID, ref NET_DVR_VOD_PARA pVodPara );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl( int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl_V40( int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint LPOutValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack( int lPlayHandle );

        /*********************************************************
        Function:	PLAYDATACALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void PLAYDATACALLBACK( int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayDataCallBack( int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser );


        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackSaveData( int lPlayHandle, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBackSave( int lPlayHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPlayBackOsdTime( int lPlayHandle, ref NET_DVR_TIME lpOsdTime );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackCaptureFile( int lPlayHandle, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByName( int lUserID, string sDVRFileName, string sSavedFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime( int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime_V40( int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopGetFile( int lFileHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetDownloadPos( int lFileHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPos( int lPlayHandle );

        //ة‎¼¶
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_Upgrade( int lUserID, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeState( int lUpgradeHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeProgress( int lUpgradeHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseUpgradeHandle( int lUpgradeHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetNetworkEnvironment( uint dwEnvironmentLevel );

        //ش¶³ج¸ٌت½»¯س²إج
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FormatDisk( int lUserID, int lDiskNumber );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetFormatProgress( int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseFormatHandle( int lFormatHandle );

        //±¨¾¯
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan( int lAlarmHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V30( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V41( int lUserID, ref NET_DVR_SETUPALARM_PARAM lpSetupParam );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan_V30( int lAlarmHandle );

        //سïزô¶ش½²
        /*********************************************************
        Function:	VOICEDATACALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACK( int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom( int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser );

        /*********************************************************
        Function:	VOICEDATACALLBACKV30
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACKV30( int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_V30( int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser );


        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVoiceComClientVolume( int lVoiceComHandle, ushort wVolume );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopVoiceCom( int lVoiceComHandle );

        //سïزô×ھ·¢
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR( int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR_V30( int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_VoiceComSendData( int lVoiceComHandle, string pSendBuf, uint dwBufSize );

        //سïزô¹م²¥
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart();

        /*********************************************************
        Function:	VOICEAUDIOSTART
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEAUDIOSTART( string pRecvDataBuffer, uint dwBufSize, IntPtr pUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart_V30( VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser );


        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStop();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_AddDVR( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_AddDVR_V30( int lUserID, uint dwVoiceChan );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR_V30( int lVoiceHandle );


        //ح¸أ÷ح¨µہةèضأ
        /*********************************************************
        Function:	SERIALDATACALLBACK
        Desc:		(»طµ÷؛¯ت‎)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SERIALDATACALLBACK( int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStart( int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser );

        //485×÷خھح¸أ÷ح¨µہت±£¬ذèزھض¸أ÷ح¨µہ؛إ£¬زٍخھ²»ح¬ح¨µہ؛إ485µؤةèضأ؟ةزش²»ح¬(±ببç²¨جطآت)
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialSend( int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStop( int lSerialHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SendTo232Port( int lUserID, string pSendBuf, uint dwBufSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SendToSerialPort( int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize );

        //½âآë nBitrate = 16000
        [DllImport(@"HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_InitG722Decoder( int nBitrate );

        [DllImport(@"HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Decoder( IntPtr pDecHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG722Frame( IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer );

        //±àآë
        [DllImport(@"HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_InitG722Encoder();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG722Frame( IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer );

        [DllImport(@"HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Encoder( IntPtr pEncodeHandle );

        //ش¶³ج؟طضئ±¾µطدشت¾
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClickKey( int lUserID, int lKeyIndex );

        //ش¶³ج؟طضئةè±¸¶ثتض¶¯آ¼دٌ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDVRRecord( int lUserID, int lChannel, int lRecordType );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDVRRecord( int lUserID, int lChannel );

        //½âآë؟¨
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDevice_Card( ref int pDeviceTotalChan );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDevice_Card();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDraw_Card( IntPtr hParent, uint colorKey );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDraw_Card();

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_Card( int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ResetPara_Card( int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshSurface_Card();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClearSurface_Card();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreSurface_Card();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound_Card( int lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound_Card( int lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVolume_Card( int lRealHandle, ushort wVolume );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_AudioPreview_Card( int lRealHandle, int bEnable );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetCardLastError_Card();

        [DllImport(@"HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_GetChanHandle_Card( int lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture_Card( int lRealHandle, string sPicFileName );

        //»ٌب،½âآë؟¨ذٍءذ؛إ´ث½س؟عخقذ§£¬¸ؤسأGetBoardDetail½س؟ع»ٌµأ(2005-12-08ض§³ض)
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSerialNum_Card( int lChannelNum, ref uint pDeviceSerialNo );

        //بصض¾
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog( int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog( int lLogHandle, ref NET_DVR_LOG lpLogData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose( int lLogHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_V30( int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_V30( int lLogHandle, ref NET_DVR_LOG_V30 lpLogData );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose_V30( int lLogHandle );

        //½طض¹2004ؤê8شآ5بص,¹²113¸ِ½س؟ع
        //ATM DVR
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByCard( int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime );


        //2005-09-15
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture( int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName );

        //JPEG×¥ح¼µ½ؤع´و
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture_NEW( int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, byte [ ] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned );

        //2006-02-16
        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetRealPlayerIndex( int lRealHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPlayerIndex( int lPlayHandle );

        //2006-08-28 704-640 ثُ·إإنضأ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG( int lUserID, uint dwScale );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG( int lUserID, ref uint lpOutScale );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG_V30( int lUserID, ref NET_DVR_SCALECFG pScalecfg );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG_V30( int lUserID, ref NET_DVR_SCALECFG pScalecfg );

        //2006-08-28 ATM»ْ¶ث؟عةèضأ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetATMPortCFG( int lUserID, ushort wATMPort );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetATMPortCFG( int lUserID, ref ushort LPOutATMPort );

        //2006-11-10 ض§³ضدش؟¨¸¨ضْتن³ِ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDrawDevice();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDrawDevice();

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_GetDDrawDeviceTotalNums();

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDDrawDevice( int lPlayPort, uint nDeviceNum );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn( int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn_EX( int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame );

        //½âآëةè±¸DS-6001D/DS-6001F
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecode( int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecode( int lUserID, int lChannel );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecoderState( int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState );

        //2005-08-01
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecInfo( int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecInfo( int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecTransPort( int lUserID, ref NET_DVR_PORTCFG lpTransPort );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecTransPort( int lUserID, ref NET_DVR_PORTCFG lpTransPort );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DecPlayBackCtrl( int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecSpecialCon( int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecSpecialCon( int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlDec( int lUserID, int lChannel, uint dwControlCode );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlScreen( int lUserID, int lChannel, uint dwControl );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecCurLinkStatus( int lUserID, int lChannel, ref NET_DVR_DECSTATUS lpDecStatus );

        //¶àآ·½âآëئ÷
        //2007-11-30 V211ض§³ضزشدآ½س؟ع //11
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopDynamic( int lUserID, uint dwDecChanNum );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanEnable( int lUserID, uint dwDecChanNum, uint dwEnable );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanEnable( int lUserID, uint dwDecChanNum, ref uint lpdwEnable );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecEnable( int lUserID, ref uint lpdwEnable );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDecChanEnable( int lUserID, uint dwDecChanNum, uint dwEnable );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanEnable( int lUserID, uint dwDecChanNum, ref uint lpdwEnable );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanStatus( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter );

        //2007-12-22 شِ¼سض§³ض½س؟ع //18
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo( int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo( int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlay( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlayControl( int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetRemotePlayStatus( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter );

        //2009-4-13 ذآشِ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic_V30( int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo_V30( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V30 lpInter );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo_V30( int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo_V30( int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDisplayCfg( int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDisplayCfg( int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg );


        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_MatrixStartPassiveDecode( int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_PASSIVEMODE lpPassiveMode );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSendData( int lPassiveHandle, System.IntPtr pSendBuf, uint dwBufSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopPassiveDecode( int lPassiveHandle );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_UploadLogo( int lUserID, uint dwDispChanNum, ref NET_DVR_DISP_LOGOCFG lpDispLogoCfg, System.IntPtr sLogoBuffer );

        public const int NET_DVR_SHOWLOGO = 1;/*دشت¾LOGO*/
        public const int NET_DVR_HIDELOGO = 2;/*ز‏²طLOGO*/

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_LogoSwitch( int lUserID, uint dwDecChan, uint dwLogoSwitch );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDeviceStatus( int lUserID, ref NET_DVR_DECODER_WORK_STATUS lpDecoderCfg );

        /*دشت¾ح¨µہأüءîآë¶¨زه*/
        //ةد؛£تہ²© ¶¨ضئ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterPlayBackDrawFun( int lRealHandle, DRAWFUN fDrawFun, uint dwUser );


        public const int DISP_CMD_ENLARGE_WINDOW = 1;	/*دشت¾ح¨µہ·إ´َؤ³¸ِ´°؟ع*/
        public const int DISP_CMD_RENEW_WINDOW = 2;	/*دشت¾ح¨µہ´°؟ع»¹ش­*/

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixDiaplayControl( int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam );

        //end
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshPlay( int lPlayHandle );

        //»ض¸´ؤ¬بدضµ
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreConfig( int lUserID );

        //±£´و²خت‎
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveConfig( int lUserID );

        //ضطئô
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_RebootDVR( int lUserID );

        //¹ط±صDVR
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ShutDownDVR( int lUserID );

        //»ٌب،ةè±¸ض§³ضµؤIPCذ­زé±ي
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetIPCProtoList( int lUserID, ref NET_DVR_IPC_PROTO_LIST lpProtoList );

        //²خت‎إنضأ begin
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRConfig( int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRConfig( int lUserID, uint dwCommand, int lChannel, System.IntPtr lpInBuffer, uint dwInBufferSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState_V30( int lUserID, IntPtr pWorkState );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState( int lUserID, ref NET_DVR_WORKSTATE lpWorkState );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVideoEffect( int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVideoEffect( int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetframeformat( int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetframeformat( int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAtmProtocol( int lUserID, ref NET_DVR_ATM_PROTOCOL lpAtmProtocol );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut_V30( int lUserID, IntPtr lpAlarmOutState );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut( int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAlarmOut( int lUserID, int lAlarmOutPort, int lAlarmOutStatic );

        //»ٌب،UPNP¶ث؟عس³ةن×´ج¬
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetUpnpNatState( int lUserID, ref NET_DVR_UPNP_NAT_STATE lpState );

        //تسئµ²خت‎µ÷½ع
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetVideoEffect( int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetVideoEffect( int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue );

        //إنضأخؤ¼‏
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile( int lUserID, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile( int lUserID, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_V30( int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_EX( int lUserID, string sOutBuffer, uint dwOutSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile_EX( int lUserID, string sInBuffer, uint dwInSize );

        //ئôسأبصض¾خؤ¼‏ذ´بë½س؟ع
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLogToFile( int bLogEnable, string strLogDir, bool bAutoDel );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKState( ref NET_DVR_SDKSTATE pSDKState );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKAbility( ref NET_DVR_SDKABL pSDKAbl );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZProtocol( int lUserID, ref NET_DVR_PTZCFG pPtzcfg );

        //ا°أو°هثّ¶¨
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_LockPanel( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_UnLockPanel( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRtspConfig( int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRtspConfig( int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize );

        //تسئµ×غ؛دئ½ج¨
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetSceneCfg( int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg );
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetSceneCfg( int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg );

        //SDK_V222
        //ضاؤـةè±¸ہàذح
        public const int DS6001_HF_B = 60;//ذذخھ·ضخِ£؛DS6001-HF/B
        public const int DS6001_HF_P = 61;//³µإئت¶±ً£؛DS6001-HF/P
        public const int DS6002_HF_B = 62;//ث«»ْ¸ْ×ظ£؛DS6002-HF/B
        public const int DS6101_HF_B = 63;//ذذخھ·ضخِ£؛DS6101-HF/B
        public const int IDS52XX = 64;//ضاؤـ·ضخِزاIVMS
        public const int DS9000_IVS = 65;//9000دµءذضاؤـDVR
        public const int DS8004_AHL_A = 66;//ضاؤـATM, DS8004AHL-S/A
        public const int DS6101_HF_P = 67;//³µإئت¶±ً£؛DS6101-HF/P

        //ؤـء¦»ٌب،أüءî
        public const int VCA_DEV_ABILITY = 256;//ةè±¸ضاؤـ·ضخِµؤ×ـؤـء¦
        public const int VCA_CHAN_ABILITY = 272;//ذذخھ·ضخِؤـء¦
        public const int MATRIXDECODER_ABILITY = 512;//¶àآ·½âآëئ÷دشت¾،¢½âآëؤـء¦
        //»ٌب،/ةèضأ´َ½س؟ع²خت‎إنضأأüءî
        //³µإئت¶±ً£¨NET_VCA_PLATE_CFG£©
        public const int NET_DVR_SET_PLATECFG = 150;//ةèضأ³µإئت¶±ً²خت‎
        public const int NET_DVR_GET_PLATECFG = 151;//»ٌب،³µإئت¶±ً²خت‎
        //ذذخھ¶شس¦£¨NET_VCA_RULECFG£©
        public const int NET_DVR_SET_RULECFG = 152;//ةèضأذذخھ·ضخِ¹وشٍ
        public const int NET_DVR_GET_RULECFG = 153;//»ٌب،ذذخھ·ضخِ¹وشٍ

        //ث«ةمدٌ»ْ±ê¶¨²خت‎£¨NET_DVR_LF_CFG£©
        public const int NET_DVR_SET_LF_CFG = 160;//ةèضأث«ةمدٌ»ْµؤإنضأ²خت‎
        public const int NET_DVR_GET_LF_CFG = 161;//»ٌب،ث«ةمدٌ»ْµؤإنضأ²خت‎

        //ضاؤـ·ضخِزاب،ء÷إنضأ½ل¹¹
        public const int NET_DVR_SET_IVMS_STREAMCFG = 162;//ةèضأضاؤـ·ضخِزاب،ء÷²خت‎
        public const int NET_DVR_GET_IVMS_STREAMCFG = 163;//»ٌب،ضاؤـ·ضخِزاب،ء÷²خت‎

        //ضاؤـ؟طضئ²خت‎½ل¹¹
        public const int NET_DVR_SET_VCA_CTRLCFG = 164;//ةèضأضاؤـ؟طضئ²خت‎
        public const int NET_DVR_GET_VCA_CTRLCFG = 165;//»ٌب،ضاؤـ؟طضئ²خت‎

        //ئء±خاّسٍNET_VCA_MASK_REGION_LIST
        public const int NET_DVR_SET_VCA_MASK_REGION = 166;//ةèضأئء±خاّسٍ²خت‎
        public const int NET_DVR_GET_VCA_MASK_REGION = 167;//»ٌب،ئء±خاّسٍ²خت‎

        //ATM½ّبëاّسٍ NET_VCA_ENTER_REGION
        public const int NET_DVR_SET_VCA_ENTER_REGION = 168;//ةèضأ½ّبëاّسٍ²خت‎
        public const int NET_DVR_GET_VCA_ENTER_REGION = 169;//»ٌب،½ّبëاّسٍ²خت‎

        //±ê¶¨دكإنضأNET_VCA_LINE_SEGMENT_LIST
        public const int NET_DVR_SET_VCA_LINE_SEGMENT = 170;//ةèضأ±ê¶¨دك
        public const int NET_DVR_GET_VCA_LINE_SEGMENT = 171;//»ٌب،±ê¶¨دك

        // ivmsئء±خاّسٍNET_IVMS_MASK_REGION_LIST
        public const int NET_DVR_SET_IVMS_MASK_REGION = 172;//ةèضأIVMSئء±خاّسٍ²خت‎
        public const int NET_DVR_GET_IVMS_MASK_REGION = 173;//»ٌب،IVMSئء±خاّسٍ²خت‎
        // ivms½ّبë¼ى²âاّسٍNET_IVMS_ENTER_REGION
        public const int NET_DVR_SET_IVMS_ENTER_REGION = 174;//ةèضأIVMS½ّبëاّسٍ²خت‎
        public const int NET_DVR_GET_IVMS_ENTER_REGION = 175;//»ٌب،IVMS½ّبëاّسٍ²خت‎

        public const int NET_DVR_SET_IVMS_BEHAVIORCFG = 176;//ةèضأضاؤـ·ضخِزاذذخھ¹وشٍ²خت‎
        public const int NET_DVR_GET_IVMS_BEHAVIORCFG = 177;//»ٌب،ضاؤـ·ضخِزاذذخھ¹وشٍ²خت‎

        // IVMS »ط·إ¼ىث÷
        public const int NET_DVR_IVMS_SET_SEARCHCFG = 178;//ةèضأIVMS»ط·إ¼ىث÷²خت‎
        public const int NET_DVR_IVMS_GET_SEARCHCFG = 179;//»ٌب،IVMS»ط·إ¼ىث÷²خت‎        

        //½ل¹¹²خت‎؛ê¶¨زه 
        public const int VCA_MAX_POLYGON_POINT_NUM = 10;//¼ى²âاّسٍ×î¶àض§³ض10¸ِµمµؤ¶à±كذخ
        public const int MAX_RULE_NUM = 8;//×î¶à¹وشٍجُت‎
        public const int MAX_TARGET_NUM = 30;//×î¶àؤ؟±ê¸ِت‎
        public const int MAX_CALIB_PT = 6;//×î´َ±ê¶¨µم¸ِت‎
        public const int MIN_CALIB_PT = 4;//×îذ،±ê¶¨µم¸ِت‎
        public const int MAX_TIMESEGMENT_2 = 2;//×î´َت±¼ن¶خت‎
        public const int MAX_LICENSE_LEN = 16;//³µإئ؛إ×î´َ³¤¶ب
        public const int MAX_PLATE_NUM = 3;//³µإئ¸ِت‎
        public const int MAX_MASK_REGION_NUM = 4;//×î¶àثؤ¸ِئء±خاّسٍ
        public const int MAX_SEGMENT_NUM = 6;//ةمدٌ»ْ±ê¶¨×î´َرù±¾دكت‎ؤ؟
        public const int MIN_SEGMENT_NUM = 3;//ةمدٌ»ْ±ê¶¨×îذ،رù±¾دكت‎ؤ؟        
        /*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE±يت¾³ة¹¦£¬FALSE±يت¾ت§°ـ،£
		**********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDeviceAbility( int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength );

        //²خت‎¹ط¼ü×ض
        public enum IVS_PARAM_KEY
        {
            OBJECT_DETECT_SENSITIVE = 1,//ؤ؟±ê¼ى²âءéأô¶ب
            BACKGROUND_UPDATE_RATE = 2,//±³¾°¸üذآثظ¶ب
            SCENE_CHANGE_RATIO = 3,//³،¾°±ن»¯¼ى²â×îذ،ضµ
            SUPPRESS_LAMP = 4,//تا·ٌزضضئ³µح·µئ
            MIN_OBJECT_SIZE = 5,//ؤـ¼ى²â³ِµؤ×îذ،ؤ؟±ê´َذ،
            OBJECT_GENERATE_RATE = 6,//ؤ؟±êةْ³ةثظ¶ب
            MISSING_OBJECT_HOLD = 7,//ؤ؟±êدûت§؛َ¼جذّ¸ْ×ظت±¼ن
            MAX_MISSING_DISTANCE = 8,//ؤ؟±êدûت§؛َ¼جذّ¸ْ×ظ¾àہë
            OBJECT_MERGE_SPEED = 9,//¶à¸ِؤ؟±ê½»´يت±£¬ؤ؟±êµؤبع؛دثظ¶ب
            REPEATED_MOTION_SUPPRESS = 10,//ضط¸´شث¶¯زضضئ
            ILLUMINATION_CHANGE = 11,//¹âس°±ن»¯زضضئ؟ھ¹ط
            TRACK_OUTPUT_MODE = 12,//¹ى¼£تن³ِؤ£ت½£؛0-تن³ِؤ؟±êµؤضذذؤ£¬1-تن³ِؤ؟±êµؤµ×²؟ضذذؤ
            ENTER_CHANGE_HOLD = 13,//¼ى²âاّسٍ±ن»¯مذضµ
            RESUME_DEFAULT_PARAM = 255,//»ض¸´ؤ¬بد¹ط¼ü×ض²خت‎
        }

        //ةèضأ/»ٌب،²خت‎¹ط¼ü×ض
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetBehaviorParamKey( int lUserID, int lChannel, uint dwParameterKey, int nValue );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetBehaviorParamKey( int lUserID, int lChannel, uint dwParameterKey, ref int pValue );

        //»ٌب،/ةèضأذذخھ·ضخِؤ؟±êµ‏¼س½س؟ع
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVCADrawMode( int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVCADrawMode( int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode );

        //±ê¶¨²خت‎إنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CALIBRATION_PARAM
        {
            public byte byPointNum;//سذذ§±ê¶¨µم¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint;//±ê¶¨µم×é
        }

        //LFث«ةمدٌ»ْإنضأ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CFG
        {
            public uint dwSize;//½ل¹¹³¤¶ب	
            public byte byEnable;//±ê¶¨ت¹ؤـ
            public byte byFollowChan;// ±»؟طضئµؤ´سح¨µہ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_LF_CALIBRATION_PARAM struCalParam;//±ê¶¨µم×é
        }

        //L/Fتض¶¯؟طضئ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //L/Fؤ؟±ê¸ْ×ظ½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_TARGET_INFO
        {
            public uint dwTargetID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_MODE
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public byte byTrackMode;//¸ْ×ظؤ£ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ضأ0
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                [FieldOffsetAttribute(0)]
                public uint[] dwULen;
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_MANUAL_CTRL_INFO struManualCtrl;//تض¶¯¸ْ×ظ½ل¹¹
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_TRACK_TARGET_INFO struTargetTrack;//ؤ؟±ê¸ْ×ظ½ل¹¹
            }
        }

        //ث«ةمدٌ»ْ¸ْ×ظؤ£ت½ةèضأ½س؟ع
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLFTrackMode( int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetLFTrackMode( int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode );

        //ت¶±ً³،¾°
        public enum VCA_RECOGNIZE_SCENE
        {
            VCA_LOW_SPEED_SCENE = 0,//µحثظح¨¹‎³،¾°£¨تص·رص¾،¢ذ،اّأإ؟ع،¢ح£³µ³،£©
            VCA_HIGH_SPEED_SCENE = 1,//¸كثظح¨¹‎³،¾°£¨؟¨؟ع،¢¸كثظ¹«آ·،¢زئ¶¯»ü²é)
            VCA_MOBILE_CAMERA_SCENE = 2,//زئ¶¯ةمدٌ»ْس¦سأ£© 
        }

        //ت¶±ً½ل¹û±êض¾
        public enum VCA_RECOGNIZE_RESULT
        {
            VCA_RECOGNIZE_FAILURE = 0,//ت¶±ًت§°ـ
            VCA_IMAGE_RECOGNIZE_SUCCESS,//ح¼دٌت¶±ً³ة¹¦
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_BEST_LICENSE,//تسئµت¶±ً¸üسإ½ل¹û
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_NEW_LICENSE,//تسئµت¶±ًµ½ذآµؤ³µإئ
            VCA_VIDEO_RECOGNIZE_FINISH_OF_CUR_LICENSE,//تسئµت¶±ً³µإئ½لتّ
        }



        //تسئµت¶±ً´¥·¢ہàذح
        public enum VCA_TRIGGER_TYPE
        {
            INTER_TRIGGER = 0,// ؤ£؟éؤع²؟´¥·¢ت¶±ً
            EXTER_TRIGGER = 1,// حâ²؟خïہيذإ؛إ´¥·¢£؛دكب¦،¢ہ×´ï،¢تض¶¯´¥·¢ذإ؛إ£»
        }

        public const int MAX_CHINESE_CHAR_NUM = 64;    // ×î´َ؛؛×ضہà±ًت‎ء؟
        //³µإئ؟ة¶¯ج¬ذق¸ؤ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_PARAM
        {
            public NET_VCA_RECT struSearchRect;//ثرث÷اّسٍ(¹éز»»¯)
            public NET_VCA_RECT struInvalidateRect;//خقذ§اّسٍ£¬شعثرث÷اّسٍؤع²؟ (¹éز»»¯)
            public ushort wMinPlateWidth;//³µإئ×îذ،؟ي¶ب
            public ushort wTriggerDuration;//´¥·¢³ضذّض،ت‎
            public byte byTriggerType;//´¥·¢ؤ£ت½, VCA_TRIGGER_TYPE
            public byte bySensitivity;//ءéأô¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ضأ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byCharPriority;// ؛؛×ضسإدب¼¶
        }

        /*wMinPlateWidth:¸أ²خت‎ؤ¬بدإنضأخھ80دٌثط£»¸أ²خت‎µؤإنضأ¶شسع³µإئ؛£؟µح‏تس³µإئت¶±ًثµأ÷خؤµµ 
	    ت¶±ًسذس°دى£¬بç¹ûةèضأ¹‎´َ£¬ؤاأ´بç¹û³،¾°ضذ³ِدضذ،³µإئ¾ح»لآ©ت¶±ً£»بç¹û³،¾°ضذ³µإئ؟ي¶بئص±é½د´َ£¬؟ةزش°ر¸أ²خت‎ةèضأةش´َ£¬±مسع¼ُةظ¶شذé¼ظ³µإئµؤ´¦ہي،£شع±êاهاé؟ِدآ½¨زéةèضأخھ80£¬ شع¸كاهاé؟ِدآ½¨زéةèضأخھ120
        wTriggerDuration £­ حâ²؟´¥·¢ذإ؛إ³ضذّض،ت‎ء؟£¬ئن؛¬زهتا´س´¥·¢ذإ؛إ؟ھت¼ت¶±ًµؤض،ت‎ء؟،£¸أضµشعµحثظ³،¾°½¨زéةèضأخھ50،«100£»¸كثظ³،¾°½¨زéةèضأخھ15،«25£»زئ¶¯ت¶±ًت±بç¹ûز²سذحâ²؟´¥·¢£¬ةèضأخھ15،«25£»¾كجه؟ةزش¸ù¾فدض³،اé؟ِ½ّذذإنضأ
        */
        //³µإئت¶±ً²خت‎×س½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATEINFO
        {
            public VCA_RECOGNIZE_SCENE eRecogniseScene;//ت¶±ً³،¾°(µحثظ؛ح¸كثظ)
            public NET_VCA_PLATE_PARAM struModifyParam;//³µإئ؟ة¶¯ج¬ذق¸ؤ²خت‎
        }

        //³µإئت¶±ًإنضأ²خت‎
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATECFG
        {
            public uint dwSize;
            public byte byPicProType;//±¨¾¯ت±ح¼ئ¬´¦ہي·½ت½ 0-²»´¦ہي 1-ةد´«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ةèضأخھ0
            public NET_DVR_JPEGPARA struPictureParam;//ح¼ئ¬¹و¸ٌ½ل¹¹
            public NET_VCA_PLATEINFO struPlateInfo;//³µإئذإد¢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//²¼·ہت±¼ن
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//´¦ہي·½ت½
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±¨¾¯´¥·¢µؤآ¼دَح¨µہ,خھ1±يت¾´¥·¢¸أح¨µہ
        }

        //³µإئت¶±ً½ل¹û×س½ل¹¹
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_VCA_PLATE_INFO
        {
            public VCA_RECOGNIZE_RESULT eResultFlag;//ت¶±ً½ل¹û±êض¾ 
            public VCA_PLATE_TYPE ePlateType;//³µإئہàذح
            public VCA_PLATE_COLOR ePlateColor;//³µإئرصة«
            public NET_VCA_RECT struPlateRect;//³µإئخ»ضأ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//±£ءô£¬ةèضأخھ0 
            public uint dwLicenseLen;//³µإئ³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;//³µإئ؛إآë 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sBelieve;//¸÷¸ِت¶±ً×ض·ûµؤضأذإ¶ب£¬بç¼ى²âµ½³µإئ"صمA12345", ضأذإ¶بخھ10,20,30,40,50,60,70£¬شٍ±يت¾"صم"×ضص‎ب·µؤ؟ةؤـذشض»سذ10%£¬"A"×ضµؤص‎ب·µؤ؟ةؤـذشتا20%
        }

        //³µإئ¼ى²â½ل¹û
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_RESULT
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public uint dwRelativeTime;//دà¶شت±±ê
            public uint dwAbsTime;//¾ّ¶شت±±ê
            public byte byPlateNum;//³µإئ¸ِت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLATE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PLATE_INFO[] struPlateInfo;//³µإئذإد¢½ل¹¹
            public uint dwPicDataLen;//·µ»طح¼ئ¬µؤ³¤¶ب خھ0±يت¾أ»سذح¼ئ¬£¬´َسع0±يت¾¸أ½ل¹¹؛َأو½ô¸ْح¼ئ¬ت‎¾ف
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes2;//±£ءô£¬ةèضأخھ0 ح¼ئ¬µؤ¸ك؟ي
            public System.IntPtr pImage;//ض¸دٍح¼ئ¬µؤض¸صë
        }

        //ضطئôضاؤـ؟â
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_VCA_RestartLib( int lUserID, int lChannel );

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEGMENT
        {
            public NET_VCA_POINT struStartPoint;//±يت¾¸ك¶بدكت±£¬±يت¾ح·²؟µم
            public NET_VCA_POINT struEndPoint;//±يت¾¸ك¶بدكت±£¬±يت¾½إ²؟µم
            public float fValue;//¸ك¶بضµ£¬µ¥خ»أ×
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±ê¶¨دكء´±ي
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEG_LIST
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public byte bySegNum;//±ê¶¨دكجُت‎
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;//±£ءô£¬ضأ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SEGMENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_LINE_SEGMENT[] struSeg;
        }

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealHeight( int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpHeight );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealLength( int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpLength );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData_V30( int lRealHandle, uint dwTransType, string sFileName );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG711Frame( uint iType, ref byte pInBuffer, ref byte pOutBuffer );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG711Frame( uint iType, ref byte pInBuffer, ref byte pOutBuffer );

        //2009-7-22 end  

        //ست¼‏·‏خٌ²âتش 9000_1.1
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_EmailTest( int lUserID );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByEvent( int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam );

        [DllImport(@"HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextEvent( int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET lpSearchEventRet );


        //2009-8-18 ×¥إؤ»ْ
        public const int PLATE_INFO_LEN = 1024;
        public const int PLATE_NUM_LEN = 16;
        public const int FILE_NAME_LEN = 256;

        //liscense plate result
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RET
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlateNum;//³µإئ؛إ
            public byte byVehicleType;// ³µہàذح
            public byte byTrafficLight;//0-آجµئ£»1-؛ىµئ
            public byte byPlateColor;//³µإئرصة«
            public byte byDriveChan;//´¥·¢³µµہ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byTimeInfo;/*ت±¼نذإد¢*///plate_172.6.113.64_20090724155526948_197170484 
            //ؤ؟ا°تا17خ»£¬¾«ب·µ½ms:20090724155526948
            public byte byCarSpeed;/*µ¥خ»km/h*/
            public byte byCarSpeedH;/*cm/s¸ك8خ»*/
            public byte byCarSpeedL;/*cm/sµح8خ»*/
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_INFO_LEN - 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byInfo;
            public uint dwPicLen;
        }
        /*×¢£؛؛َأو½ô¸ْ dwPicLen ³¤¶بµؤ ح¼ئ¬ ذإد¢*/

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE( int lUserID, int lChannel, string pPicFileName, ref NET_DVR_PLATE_RET pPlateRet, string pPicBuf, uint dwPicBufLen );

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CCD_CFG
        {
            public uint dwSize;//½ل¹¹³¤¶ب
            public byte byBlc;/*±³¹â²¹³¥0-off; 1-on*/
            public byte byBlcMode;/*blcہàذح0-×ش¶¨زه1-ةد£»2-دآ£»3-×َ£»4-سز£»5-ضذ£»×¢£؛´ثدîشعblcخھ on ت±²إئًذ§*/
            public byte byAwb;/*×ش¶¯°×ئ½؛â0-×ش¶¯1; 1-×ش¶¯2; 2-×ش¶¯؟طضئ*/
            public byte byAgc;/*×ش¶¯شِزو0-¹ط; 1-µح; 2-ضذ; 3-¸ك*/
            public byte byDayNight;/*بصز¹×ھ»»£»0 ²تة«£»1؛ع°×£»2×ش¶¯*/
            public byte byMirror;/*¾µدٌ0-¹ط;1-×َسز;2-ةددآ;3-ضذذؤ*/
            public byte byShutter;/*؟ىأإ0-×ش¶¯; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
            public byte byIrCutTime;/*IRCUTاذ»»ت±¼ن£¬5, 10, 15, 20, 25*/
            public byte byLensType;/*¾µح·ہàذح0-µç×س¹âب¦; 1-×ش¶¯¹âب¦*/
            public byte byEnVideoTrig;/*تسئµ´¥·¢ت¹ؤـ£؛1-ض§³ض£»0-²»ض§³ض،£تسئµ´¥·¢ؤ£ت½دآتسئµ؟ىأإثظ¶ب°´صصbyShutterثظ¶ب£¬×¥إؤح¼ئ¬µؤ؟ىأإثظ¶ب°´صصbyCapShutterثظ¶ب£¬×¥إؤحê³ة؛َ»ل×ش¶¯µ÷½ع»طتسئµؤ£ت½*/
            public byte byCapShutter;/*×¥إؤت±µؤ؟ىأإثظ¶ب£¬1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
            public byte byEnRecognise;/*1-ض§³ضت¶±ً£»0-²»ض§³ضت¶±ً*/
        }

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetCCDCfg( int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg );

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_SetCCDCfg( int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg );

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagCAMERAPARAMCFG
        {
            public uint dwSize;
            public uint dwPowerLineFrequencyMode;/*0-50HZ; 1-60HZ*/
            public uint dwWhiteBalanceMode;/*0تض¶¯°×ئ½؛â; 1×ش¶¯°×ئ½؛â1£¨·¶خ§ذ،£©; 2 ×ش¶¯°×ئ½؛â2£¨·¶خ§؟ي£¬2200K-15000K£©;3×ش¶¯؟طضئ3*/
            public uint dwWhiteBalanceModeRGain;/*تض¶¯°×ئ½؛âت±سذذ§£¬تض¶¯°×ئ½؛â Rشِزو*/
            public uint dwWhiteBalanceModeBGain;/*تض¶¯°×ئ½؛âت±سذذ§£¬تض¶¯°×ئ½؛â Bشِزو*/
            public uint dwExposureMode;/*0 تض¶¯ئط¹â 1×ش¶¯ئط¹â*/
            public uint dwExposureSet;/* 0-USERSET, 1-×ش¶¯x2£¬2-×ش¶¯4£¬3-×ش¶¯81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
            public uint dwExposureUserSet;/* ×ش¶¯×ش¶¨زهئط¹âت±¼ن*/
            public uint dwExposureTarget;/*تض¶¯ئط¹âت±¼ن ·¶خ§£¨Manumalسذذ§£¬خ¢أë£©*/
            public uint dwIrisMode;/*0 ×ش¶¯¹âب¦ 1تض¶¯¹âب¦*/
            public uint dwGainLevel;/*شِزو£؛0-100*/
            public uint dwBrightnessLevel;/*0-100*/
            public uint dwContrastLevel;/*0-100*/
            public uint dwSharpnessLevel;/*0-100*/
            public uint dwSaturationLevel;/*0-100*/
            public uint dwHueLevel;/*0-100£¬£¨±£ءô£©*/
            public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
            public uint dwGammaCorrectionLevel;/*0-100*/
            public uint dwWDREnabled;/*؟ي¶¯ج¬£؛0 dsibale  1 enable*/
            public uint dwWDRLevel1;/*0-F*/
            public uint dwWDRLevel2;/*0-F*/
            public uint dwWDRContrastLevel;/*0-100*/
            public uint dwDayNightFilterType;/*بصز¹اذ»»£؛0 day,1 night,2 auto */
            public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(±£ءô)*/
            //ؤ£ت½1(±£ءô)
            public uint dwBeginTime;	/*0-100*/
            public uint dwEndTime;/*0-100*/
            //ؤ£ت½2
            public uint dwDayToNightFilterLevel;//0-7
            public uint dwNightToDayFilterLevel;//0-7
            public uint dwDayNightFilterTime;//(60أë)
            public uint dwBacklightMode;/*±³¹â²¹³¥:0 USERSET 1 UP،¢2 DOWN،¢3 LEFT،¢4 RIGHT،¢5MIDDLE*/
            public uint dwPositionX1;//£¨X×ّ±ê1£©
            public uint dwPositionY1;//£¨Y×ّ±ê1£©
            public uint dwPositionX2;//£¨X×ّ±ê2£©
            public uint dwPositionY2;//£¨Y×ّ±ê2£©
            public uint dwBacklightLevel;/*0x0-0xF*/
            public uint dwDigitalNoiseRemoveEnable; /*ت‎×ضب¥شë£؛0 dsibale  1 enable*/
            public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
            public uint dwMirror; /* ¾µدٌ£؛0 Left;1 Right,;2 Up;3Down */
            public uint dwDigitalZoom;/*ت‎×ضثُ·إ:0 dsibale  1 enable*/
            public uint dwDeadPixelDetect;/*»µµم¼ى²â,0 dsibale  1 enable*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        public const int NET_DVR_GET_CCDPARAMCFG = 1067;       //IPC»ٌب،CCD²خت‎إنضأ
        public const int NET_DVR_SET_CCDPARAMCFG = 1068;      //IPCةèضأCCD²خت‎إنضأ

        //ح¼دٌشِا؟زا
        //ح¼دٌشِا؟ب¥شïاّسٍإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEREGION
        {
            public uint dwSize;//×ـµؤ½ل¹¹³¤¶ب
            public ushort wImageRegionTopLeftX;/* ح¼دٌشِا؟ب¥شïµؤ×َةدx×ّ±ê */
            public ushort wImageRegionTopLeftY;/* ح¼دٌشِا؟ب¥شïµؤ×َةدy×ّ±ê */
            public ushort wImageRegionWidth;/* ح¼دٌشِا؟ب¥شïاّسٍµؤ؟ي */
            public ushort wImageRegionHeight;/*ح¼دٌشِا؟ب¥شïاّسٍµؤ¸ك*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ح¼دٌشِا؟،¢ب¥شë¼¶±ً¼°خب¶¨ذشت¹ؤـإنضأ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGESUBPARAM
        {
            public NET_DVR_SCHEDTIME struImageStatusTime;//ح¼دٌ×´ج¬ت±¼ن¶خ
            public byte byImageEnhancementLevel;//ح¼دٌشِا؟µؤ¼¶±ً£¬0-7£¬0±يت¾¹ط±ص
            public byte byImageDenoiseLevel;//ح¼دٌب¥شëµؤ¼¶±ً£¬0-7£¬0±يت¾¹ط±ص
            public byte byImageStableEnable;//ح¼دٌخب¶¨ذشت¹ؤـ£¬0±يت¾¹ط±ص£¬1±يت¾´ٍ؟ھ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_GET_IMAGEREGION = 1062;       //ح¼دٌشِا؟زاح¼دٌشِا؟ب¥شïاّسٍ»ٌب،
        public const int NET_DVR_SET_IMAGEREGION = 1063;       //ح¼دٌشِا؟زاح¼دٌشِا؟ب¥شïاّسٍ»ٌب،
        public const int NET_DVR_GET_IMAGEPARAM = 1064;       // ح¼دٌشِا؟زاح¼دٌ²خت‎(ب¥شë،¢شِا؟¼¶±ً£¬خب¶¨ذشت¹ؤـ)»ٌب،
        public const int NET_DVR_SET_IMAGEPARAM = 1065;       // ح¼دٌشِا؟زاح¼دٌ²خت‎(ب¥شë،¢شِا؟¼¶±ً£¬خب¶¨ذشت¹ؤـ)ةèضأ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEPARAM
        {
            public uint dwSize;
            //ح¼دٌشِا؟ت±¼ن¶خ²خت‎إنضأ£¬ضـبص؟ھت¼	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public tagIMAGESUBPARAM[] struImageParamSched;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_GetParamSetMode( int lUserID, ref uint dwParamSetMode );

        /*********************************************************
        Function:	NET_DVR_Login_V30
        Desc:		
        Input:	sDVRIP [in] ةè±¸IPµطض· 
                wServerPort [in] ةè±¸¶ث؟ع؛إ 
                sUserName [in] µاآ¼µؤسأ»§أû 
                sPassword [in] سأ»§أـآë 
        Output:	lpDeviceInfo [out] ةè±¸ذإد¢ 
        Return:	-1±يت¾ت§°ـ£¬ئنثûضµ±يت¾·µ»طµؤسأ»§IDضµ
        **********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login_V30( string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo );

        /*********************************************************
        Function:	NET_DVR_Logout_V30
        Desc:		سأ»§×¢²لةè±¸،£
        Input:	lUserID [in] سأ»§ID؛إ
        Output:	
        Return:	TRUE±يت¾³ة¹¦£¬FALSE±يت¾ت§°ـ
        **********************************************************/
        [DllImport(@"HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout_V30( Int32 lUserID );











        #region  ب،ء÷ؤ£؟éدà¹ط½ل¹¹سë½س؟ع

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PLAY_INFO
        {
            public int iUserID;      //×¢²لسأ»§ID
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strDeviceIP;
            public int iDevicePort;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string strDevAdmin;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string strDevPsd;
            public int iChannel;      //²¥·إح¨µہ؛إ(´س0؟ھت¼)
            public int iLinkMode;   //×î¸كخ»(31)خھ0±يت¾ض÷آëء÷£¬خھ1±يت¾×سآëء÷£¬0£­30خ»±يت¾آëء÷ء¬½س·½ت½: 0£؛TCP·½ت½,1£؛UDP·½ت½,2£؛¶à²¥·½ت½,3 - RTP·½ت½£¬4-زôتسئµ·ض؟ھ(TCP)
            public bool bUseMedia;     //تا·ٌئôسأء÷أ½جه
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strMediaIP; //ء÷أ½جهIPµطض·
            public int iMediaPort;   //ء÷أ½جه¶ث؟ع؛إ
        }


        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_Init();

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_UnInit();


        [DllImport("GetStream.dll")]
        public static extern int CLIENT_SDK_GetStream( PLAY_INFO lpPlayInfo ); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SetRealDataCallBack( int iRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint lUser ); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_StopStream( int iRealHandle );

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_GetVideoEffect( int iRealHandle, ref int iBrightValue, ref int iContrastValue, ref int iSaturationValue, ref int iHueValue );

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_SetVideoEffect( int iRealHandle, int iBrightValue, int iContrastValue, int iSaturationValue, int iHueValue );

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_MakeKeyFrame( int iRealHandle );

        #endregion


        #region VODµم²¥·إ؟â

        public const int WM_NETERROR = 0x0400 + 102;          //حّآçزى³£دûد¢
        public const int WM_STREAMEND = 0x0400 + 103;		  //خؤ¼‏²¥·إ½لتّ

        public const int FILE_HEAD = 0;      //خؤ¼‏ح·
        public const int VIDEO_I_FRAME = 1;  //تسئµIض،
        public const int VIDEO_B_FRAME = 2;  //تسئµBض،
        public const int VIDEO_P_FRAME = 3;  //تسئµPض،
        public const int VIDEO_BP_FRAME = 4; //تسئµBPض،
        public const int VIDEO_BBP_FRAME = 5; //تسئµBض،Bض،Pض،
        public const int AUDIO_PACKET = 10;   //زôئµ°ü

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct BLOCKTIME
        {
            public ushort wYear;
            public byte bMonth;
            public byte bDay;
            public byte bHour;
            public byte bMinute;
            public byte bSecond;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODSEARCHPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VOD؟ح»§¶ث¾ن±ْ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVRµؤحّآçµطض·
            public uint dvrPort;                                            //	[in]DVRµؤ¶ث؟عµطض·
            public uint channelNum;                                         //  [in]DVRµؤح¨µہ؛إ
            public BLOCKTIME startTime;                                     //	[in]²éر¯µؤ؟ھت¼ت±¼ن
            public BLOCKTIME stopTime;                                      //	[in]²éر¯µؤ½لتّت±¼ن
            public bool bUseIPServer;                                       //  [in]تا·ٌت¹سأIPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]ةè±¸µؤذٍءذ؛إ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SECTIONLIST
        {
            public BLOCKTIME startTime;
            public BLOCKTIME stopTime;
            public byte byRecType;
            public IntPtr pNext;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODOPENPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VOD؟ح»§¶ث¾ن±ْ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVRµؤحّآçµطض·
            public uint dvrPort;                                            //	[in]DVRµؤ¶ث؟عµطض·
            public uint channelNum;                                         //  [in]DVRµؤح¨µہ؛إ
            public BLOCKTIME startTime;                                     //	[in]²éر¯µؤ؟ھت¼ت±¼ن
            public BLOCKTIME stopTime;                                      //	[in]²éر¯µؤ½لتّت±¼ن
            public uint uiUser;
            public bool bUseIPServer;                                       //  [in]تا·ٌت¹سأIPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]ةè±¸µؤذٍءذ؛إ

            public VodStreamFrameData streamFrameData;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CONNPARAM
        {
            public uint uiUser;
            public ErrorCallback errorCB;
        }


        // زى³£»طµ÷؛¯ت‎
        public delegate void ErrorCallback( System.IntPtr hSession, uint dwUser, int lErrorType );
        //ض،ت‎¾ف»طµ÷؛¯ت‎
        public delegate void VodStreamFrameData( System.IntPtr hStream, uint dwUser, int lFrameType, System.IntPtr pBuffer, uint dwSize );

        //ؤ£؟é³ُت¼»¯
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerConnect( string strServerIp, uint uiServerPort, ref IntPtr hSession, ref CONNPARAM struConn, IntPtr hWnd );

        //ؤ£؟éدْ»ظ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerDisconnect( IntPtr hSession );

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStreamSearch( IntPtr pSearchParam, ref IntPtr pSecList );

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODDeleteSectionList( IntPtr pSecList );

        // ¸ù¾فID،¢ت±¼ن¶خ´ٍ؟ھء÷»ٌب،ء÷¾ن±ْ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenStream( IntPtr pOpenParam, ref IntPtr phStream );

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseStream( IntPtr hStream );

        //¸ù¾فID،¢ت±¼ن¶خ´ٍ؟ھإْء؟دآشط
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenDownloadStream( ref VODOPENPARAM struVodParam, ref IntPtr phStream );

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseDownloadStream( IntPtr hStream );

        // ؟ھت¼ء÷½âخِ£¬·¢ثحت‎¾فض،
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStartStreamData( IntPtr phStream );
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODPauseStreamData( IntPtr hStream, bool bPause );
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStopStreamData( IntPtr hStream );

        // ¸ù¾فت±¼ن¶¨خ»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSeekStreamData( IntPtr hStream, IntPtr pStartTime );


        // ¸ù¾فت±¼ن¶¨خ»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSetStreamSpeed( IntPtr hStream, int iSpeed );

        // ¸ù¾فت±¼ن¶¨خ»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODGetStreamCurrentTime( IntPtr hStream, ref BLOCKTIME pCurrentTime );

        #endregion


        #region ض،·ضخِ؟â


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PACKET_INFO
        {
            public int nPacketType;     // packet type
            // 0:  file head
            // 1:  video I frame
            // 2:  video B frame
            // 3:  video P frame
            // 10: audio frame
            // 11: private frame only for PS


            //      [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
            public IntPtr pPacketBuffer;
            public uint dwPacketSize;
            public int nYear;
            public int nMonth;
            public int nDay;
            public int nHour;
            public int nMinute;
            public int nSecond;
            public uint dwTimeStamp;
        }



        /******************************************************************************
        * function£؛get a empty port number
        * parameters£؛
        * return£؛ 0 - 499 : empty port number
        *          -1      : server is full  			
        * comment£؛
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetSafeHandle();


        /******************************************************************************
        * function£؛open standard stream data for analyzing
        * parameters£؛lHandle - working port number
        *             pHeader - pointer to file header or info header
        * return£؛TRUE or FALSE
        * comment£؛
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataOpenStreamEx( int iHandle, byte [ ] pFileHead );


        /******************************************************************************
        * function£؛close analyzing
        * parameters£؛lHandle - working port number
        * return£؛
        * comment£؛
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataClose( int iHandle );


        /******************************************************************************
        * function£؛input stream data
        * parameters£؛lHandle		- working port number
        *			  pBuffer		- data pointer
        *			  dwBuffersize	- data size
        * return£؛TRUE or FALSE
        * comment£؛
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataInputData( int iHandle, IntPtr pBuffer, uint uiSize ); //byte []


        /******************************************************************************
        * function£؛get analyzed packet
        * parameters£؛lHandle		- working port number
        *			  pPacketInfo	- returned structure
        * return£؛-1 : error
        *          0 : succeed
        *		   1 : failed
        *		   2 : file end (only in file mode)				
        * comment£؛
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetPacket( int iHandle, ref PACKET_INFO pPacketInfo );  //زھ°رpPacketInfo×ھ»»³ةPACKET_INFO½ل¹¹


        /******************************************************************************
        * function£؛get remain data from input buffer
        * parameters£؛lHandle		- working port number
        *			  pBuf	        - pointer to the mem which stored remain data
        *             dwSize        - size of remain data  
        * return£؛ TRUE or FALSE				
        * comment£؛
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataGetTail( int iHandle, ref IntPtr pBuffer, ref uint uiSize );


        [DllImport("AnalyzeData.dll")]
        public static extern uint AnalyzeDataGetLastError( int iHandle );

        #endregion


        #region آ¼دٌ؟â

        public const int DATASTREAM_HEAD = 0;		//ت‎¾فح·
        public const int DATASTREAM_BITBLOCK = 1;		//×ض½عت‎¾ف
        public const int DATASTREAM_KEYFRAME = 2;		//¹ط¼üض،ت‎¾ف
        public const int DATASTREAM_NORMALFRAME = 3;		//·ا¹ط¼üض،ت‎¾ف


        public const int MESSAGEVALUE_DISKFULL = 0x01;
        public const int MESSAGEVALUE_SWITCHDISK = 0x02;
        public const int MESSAGEVALUE_CREATEFILE = 0x03;
        public const int MESSAGEVALUE_DELETEFILE = 0x04;
        public const int MESSAGEVALUE_SWITCHFILE = 0x05;




        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STOREINFO
        {
            public int iMaxChannels;
            public int iDiskGroup;
            public int iStreamType;
            public bool bAnalyze;
            public bool bCycWrite;
            public uint uiFileSize;

            public CALLBACKFUN_MESSAGE funCallback;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CREATEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileCreateTime;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CLOSEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileSwitchTime;
        }



        public delegate int CALLBACKFUN_MESSAGE( int iMessageType, System.IntPtr pBuf, int iBufLen );


        [DllImport("RecordDLL.dll")]
        public static extern int Initialize( STOREINFO struStoreInfo );

        [DllImport("RecordDLL.dll")]
        public static extern int Release();

        [DllImport("RecordDLL.dll")]
        public static extern int OpenChannelRecord( string strCameraid, IntPtr pHead, uint dwHeadLength );

        [DllImport("RecordDLL.dll")]
        public static extern bool CloseChannelRecord( int iRecordHandle );

        [DllImport("RecordDLL.dll")]
        public static extern int GetData( int iHandle, int iDataType, IntPtr pBuf, uint uiSize );

        #endregion

        //ةè±¸اّسٍةèضأ
        public const int REGIONTYPE = 0;//´ْ±ياّسٍ
        public const int MATRIXTYPE = 11;//¾طصَ½عµم
        public const int DEVICETYPE = 2;//´ْ±يةè±¸
        public const int CHANNELTYPE = 3;//´ْ±يح¨µہ
        public const int USERTYPE = 5;//´ْ±يسأ»§

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOG_MATRIX
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;
            public uint dwMinorType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;
            public NET_DVR_IPADDR struRemoteHostAddr;
            public uint dwParaType;
            public uint dwChannel;
            public uint dwDiskNumber;
            public uint dwAlarmInPort;
            public uint dwAlarmOutPort;
            public uint dwInfoLen;
            public byte byDevSequence;//²غخ»؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MACµطض·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ذٍءذ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN - SERIALNO_LEN - MACADDR_LEN - 1)]
            public string sInfo;
        }

        //تسئµ×غ؛دئ½ج¨بي¼‏
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagVEDIOPLATLOG
        {
            public byte bySearchCondition;//ثرث÷جُ¼‏£¬0-°´²غخ»؛إثرث÷£¬1-°´ذٍءذ؛إثرث÷ 2-°´MACµطض·½ّذذثرث÷
            public byte byDevSequence;//²غخ»؛إ£¬0-79£؛¶شس¦×سدµح³µؤ²غخ»؛إ£»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//ذٍءذ؛إ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MACµطض·
        }

        [DllImportAttribute(@"..\lib\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_MATRIX( int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData );


        [DllImportAttribute(@"..\lib\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_Matrix( int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime );
    }
}

