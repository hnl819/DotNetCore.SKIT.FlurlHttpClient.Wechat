﻿using System;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 一个用于构造 <see cref="WechatTenpayClient"/> 时使用的配置项。
    /// </summary>
    public class WechatTenpayClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置微信支付 API 域名。
        /// <para>默认值：<see cref="WechatTenpayEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = WechatTenpayEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置声明应答中的错误描述使用的自然语言语种。
        /// <para>默认值：<i>根据操作系统自动生成</i></para>
        /// </summary>
        public string UserAgent { get; set; } = $"OS/{Environment.OSVersion.Platform} SKIT.FlurlHttpClient.Wechat.Tenpay/{Assembly.GetExecutingAssembly().GetName().Version}";

        /// <summary>
        /// 获取或设置声明应答中的错误描述使用的自然语言语种。
        /// <para>默认值：zh_CN</para>
        /// </summary>
        public string AcceptLanguage { get; set; } = "zh-CN";

        /// <summary>
        /// 获取或设置微信支付 API 签名认证方式。
        /// <para>默认值：<see cref="Constants.SignAlgorithms.WECHATPAY2_SHA256_RSA2048"/></para>
        /// </summary>
        public string SignAlgorithm { get; set; } = Constants.SignAlgorithms.WECHATPAY2_SHA256_RSA2048;

        /// <summary>
        /// 获取或设置微信支付商户号。
        /// </summary>
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付商户 API v3 密钥（注意与 API 密钥相区分）。
        /// </summary>
        public string MerchantV3Secret { get; set; } = default!;

        /// <summary>
        /// <i>（本参数已废弃，请使用 <see cref="MerchantCertificateSerialNumber"/> 参数）</i>
        /// </summary>
        [Obsolete("本参数已废弃，请使用 `MerchantCertificateSerialNumber` 参数")]
        public string MerchantCertSerialNumber { get { return MerchantCertificateSerialNumber; } set { MerchantCertificateSerialNumber = value; } }

        /// <summary>
        /// 获取或设置微信支付商户 API 证书序列号。
        /// </summary>
        public string MerchantCertificateSerialNumber { get; set; } = default!;

        /// <summary>
        /// <i>（本参数已废弃，请使用 <see cref="MerchantCertificatePrivateKey"/> 参数）</i>
        /// </summary>
        [Obsolete("本参数已废弃，请使用 `MerchantCertificatePrivateKey` 参数")]
        public string MerchantCertPrivateKey { get { return MerchantCertificatePrivateKey; } set { MerchantCertificatePrivateKey = value; } }

        /// <summary>
        /// 获取或设置微信支付商户 API 证书私钥（通常为 `apiclient_key.pem` 文件内容）。
        /// </summary>
        public string MerchantCertificatePrivateKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否自动加密请求中的敏感字段数据。
        /// </summary>
        public bool AutoEncryptRequestSensitiveProperty { get; set; }

        /// <summary>
        /// 获取或设置是否自动解密请求中的敏感字段数据。
        /// </summary>
        public bool AutoDecryptResponseSensitiveProperty { get; set; }

        /// <summary>
        /// <i>（本参数已废弃，请使用 <see cref="PlatformCertificateManager"/> 参数）</i>
        /// </summary>
        [Obsolete("本参数已废弃，请使用 `PlatformCertificateManager` 参数")]
        public Settings.CertificateManager CertificateManager { get { return PlatformCertificateManager; } set { PlatformCertificateManager = value; } }

        /// <summary>
        /// 获取或设置微信支付平台证书管理器。
        /// <para>默认值：<see cref="Settings.InMemoryCertificateManager"/></para>
        /// </summary>
        public Settings.CertificateManager PlatformCertificateManager { get; set; } = new Settings.InMemoryCertificateManager();
    }
}
