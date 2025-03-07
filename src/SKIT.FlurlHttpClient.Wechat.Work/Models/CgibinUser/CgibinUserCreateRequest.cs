﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/create 接口的请求。</para>
    /// </summary>
    public class CgibinUserCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ExtendedAttribute
            {
                public static class Types
                {
                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置文本属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public TextAttribute? Text { get; set; }

                        /// <summary>
                        /// 获取或设置网页属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("web")]
                        [System.Text.Json.Serialization.JsonPropertyName("web")]
                        public WebAttribute? Web { get; set; }
                    }

                    public class TextAttribute
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }

                    public class WebAttribute
                    {
                        /// <summary>
                        /// 获取或设置网页标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置网页 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置自定义字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("attrs")]
                public IList<Types.Attribute>? AttributeList { get; set; }
            }

            public class ExternalProfile
            {
                public static class Types
                {
                    public class Attribute
                    {
                        /// <summary>
                        /// 获取或设置属性类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置文本属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public TextAttribute? Text { get; set; }

                        /// <summary>
                        /// 获取或设置网页属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("web")]
                        [System.Text.Json.Serialization.JsonPropertyName("web")]
                        public WebAttribute? Web { get; set; }

                        /// <summary>
                        /// 获取或设置小程序属性值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("miniprogram")]
                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                        public MiniProgramAttribute? MiniProgram { get; set; }
                    }

                    public class TextAttribute : ExtendedAttribute.Types.TextAttribute
                    {
                    }

                    public class WebAttribute : ExtendedAttribute.Types.WebAttribute
                    {
                    }

                    public class MiniProgramAttribute
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pagepath")]
                        [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                        public string PagePath { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序页面标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;
                    }

                    public class WechatChannels
                    {
                        /// <summary>
                        /// 获取或设置视频号名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置对外企业简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("external_corp_name")]
                public string? CorpName { get; set; }

                /// <summary>
                /// 获取或设置视频号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wechat_channels")]
                [System.Text.Json.Serialization.JsonPropertyName("wechat_channels")]
                public Types.WechatChannels? WechatChannels { get; set; }

                /// <summary>
                /// 获取或设置对外自定义字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_attr")]
                [System.Text.Json.Serialization.JsonPropertyName("external_attr")]
                public IList<Types.Attribute>? AttributeList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置成员名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置成员别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        [System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 获取或设置邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 获取或设置企业邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_mail")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_mail")]
        public string? BusinessEmail { get; set; }

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置座机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
        public string? TeleNumber { get; set; }

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gender")]
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// 获取或设置职务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("position")]
        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public string? Position { get; set; }

        /// <summary>
        /// 获取或设置部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department")]
        [System.Text.Json.Serialization.JsonPropertyName("department")]
        public IList<long> DepartmentIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置部门次序列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public IList<long>? DepartmentOrderList { get; set; }

        /// <summary>
        /// 获取或设置部门领导状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_leader_in_dept")]
        [System.Text.Json.Serialization.JsonPropertyName("is_leader_in_dept")]
        public IList<int>? DepartmentLeaderStatusList { get; set; }

        /// <summary>
        /// 获取或设置主部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_department")]
        [System.Text.Json.Serialization.JsonPropertyName("main_department")]
        public long? MainDepartmentId { get; set; }

        /// <summary>
        /// 获取或设置直属上级成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direct_leader")]
        [System.Text.Json.Serialization.JsonPropertyName("direct_leader")]
        public IList<string>? DirectLeaderUserIdList { get; set; }

        /// <summary>
        /// 获取或设置头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar_mediaid")]
        public string? AvatarMediaId { get; set; }

        /// <summary>
        /// 获取或设置是否启用成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 获取或设置是否邀请成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_invite")]
        [System.Text.Json.Serialization.JsonPropertyName("to_invite")]
        public bool? RequireInvite { get; set; }

        /// <summary>
        /// 获取或设置自定义字段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extattr")]
        [System.Text.Json.Serialization.JsonPropertyName("extattr")]
        public Types.ExtendedAttribute? ExtendedAttribute { get; set; }

        /// <summary>
        /// 获取或设置对外职务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_position")]
        [System.Text.Json.Serialization.JsonPropertyName("external_position")]
        public string? ExternalPosition { get; set; }

        /// <summary>
        /// 获取或设置对外属性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_profile")]
        [System.Text.Json.Serialization.JsonPropertyName("external_profile")]
        public Types.ExternalProfile? ExternalProfile { get; set; }
    }
}
