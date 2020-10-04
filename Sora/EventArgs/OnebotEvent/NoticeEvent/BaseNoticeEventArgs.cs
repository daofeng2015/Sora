using Newtonsoft.Json;

namespace Sora.EventArgs.OnebotEvent.NoticeEvent
{
    /// <summary>
    /// 消息事件基类
    /// </summary>
    internal class BaseNoticeEventArgs : OnebotBaseEventArgs
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonProperty(PropertyName = "notice_type")]
        internal string NoticeType { get; set; }
        /// <summary>
        /// 操作对象UID
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        internal long UserId { get; set; }
    }
}